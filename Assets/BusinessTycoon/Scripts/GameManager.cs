using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using Game;
//using YG;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public event OnCashChanged OnCashChange;
    public delegate void OnCashChanged();

    public event OfflineEarnings OfflineEarningsCalculated;
    public delegate void OfflineEarnings(double elapsed, double cashEarned);

    public List<BusinessItem> BusinessItems;
    public List<ManagerItem> ManagerItems;
    public List<UpgradeItem> UpgradeItems;
    public List<ProductItem> ProductItems;
    public List<MilestoneItem> MilestoneItems;
    public List<MilestoneItem> MilestoneGalleryItems;

    public GameState GameState;
    public LevelData LevelData;

    public Color ActiveTabColor = new Color(1f, 1f, 1f, 1f);
    public Color InactiveTabColor = new Color(0.5f, 0.6f, 0.7f, 1f);

    public Color InactiveButtonTextColor = new Color(0.5f, 0.5f, 0.5f, 1f);

    public Color ProgressbarColor = new Color(0.25f, 0.6f, 0.8f, 1f);
    public Color ProgressbarMaxedColor = new Color(0.25f, 0.6f, 0.8f, 1f);

    public Color BusinessRunningColor = new Color(0.25f, 0.35f, 0.45f, 1f);
    public Color BusinessStoppedColor = new Color(0f, 0.45f, 0.70f, 1f);

    public Color BusinessActiveButtonColor = new Color(0.35f, 0.70f, 0.30f, 1);
    public Color BusinessInactiveButtonColor = new Color(0.65f, 0.65f, 0.65f, 1f);

    public Color BusinessMilestoneColor = new Color(1f, 0.6f, 0f, 1f);
    public Color BusinessMilestoneMaxedColor = new Color(1f, 1f, 0, 1f);

    private string gameFilePath;
    private string gameFileName;
    private DateTime currentDate;

    private Sprite[] businessSpriteSheet;
    private Sprite[] itemSpriteSheet;
    private Sprite[] managerSheet;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        gameFilePath = Application.persistentDataPath + "/userData";
        gameFileName = "/data{0}.dat";
        instance.Load();

        itemSpriteSheet = Resources.LoadAll<Sprite>("items");

        businessSpriteSheet = Resources.LoadAll<Sprite>("posters");

        managerSheet = Resources.LoadAll<Sprite>("Manager");

        currentDate = DateTime.Now;

        BusinessItems = new List<BusinessItem>();
        ManagerItems = new List<ManagerItem>();
        UpgradeItems = new List<UpgradeItem>();
        MilestoneItems = new List<MilestoneItem>();
    }

    private void Start()
    {
        StartCoroutine(CheckOfflineTime());
    }

    private IEnumerator CheckOfflineTime()
    {
        yield return new WaitForSeconds(3);
        CheckElapsedTime();
        yield break;
    }
    private void OnApplicationPause(bool paused)
    {
        if (GameState == null)
        {
            return;
        }

        if (paused)
        {
            LevelData.TimeStamp = DateTime.Now.ToOADate();
            instance.Save();
            //Debug.Log("Sleep");
        }
        else
        {
            StartCoroutine(CheckOfflineTime());
            //Debug.Log("Wake Up");
        }
    }

    private void OnApplicationQuit()
    {
        LevelData.TimeStamp = DateTime.Now.ToOADate();
        instance.Save();
        //Debug.Log("Shutdown");
    }

    void Update()
    {
        if (OnCashChange != null)
        {
            OnCashChange();
        }
    }

    private void CheckElapsedTime()
    {
        currentDate = DateTime.Now;

        var timeStamp = DateTime.FromOADate(LevelData.TimeStamp);
        if (currentDate > timeStamp)
        {
            var num = (currentDate - timeStamp).TotalSeconds;
            if (num > 0.0)
            {
                StartCoroutine(AddOfflineCash(num));
            }
            else
            {
                Debug.Log("Time changed");
            }
        }
    }

    private IEnumerator AddOfflineCash(double elapsed)
    {
        var offlineCash = 0.0;
        foreach (var business in LevelData.Businesses)
        {
            offlineCash += business.AddOfflineTime(elapsed, LevelData);
        }

        if (OfflineEarningsCalculated != null)
        {
            OfflineEarningsCalculated(elapsed, offlineCash);
        }

        yield break;
    }

    public void Save()
    {
        LevelData.TimeStamp = DateTime.Now.ToOADate();
        if (DateTime.Now < currentDate)
        {
            LevelData.TimeStamp = currentDate.AddMinutes(10).ToOADate();
        }

        if (!Directory.Exists(gameFilePath))
        {
            Directory.CreateDirectory(gameFilePath);
        }

        SaveDataFile(string.Format(gameFileName, "0"), GameState.ToJsonString());
        SaveDataFile(string.Format(gameFileName, "1"), LevelData.ToJsonString());
    }

    private void SaveDataFile(string fileName, string dataFile)
    {
#if UNITY_ANDROID || UNITY_IOS || UNITY_EDITOR
        File.WriteAllText(gameFilePath + "/" + fileName, dataFile);
#elif YG_PLUGIN_YANDEX_GAME
        YandexGame.savesData.pathFiles[fileName] = dataFile;
        YandexGame.SaveCloud();
#endif
    }

    public void Load()
    {
        GameState = new GameState();
        var latestVersion = GameState.Version;
        LevelData = null;

#if UNITY_ANDROID || UNITY_IOS || UNITY_EDITOR
      try
        {
            if (File.Exists(gameFilePath + "/" + string.Format(gameFileName, "0")))
            {
                var file = File.ReadAllText(gameFilePath + "/" + string.Format(gameFileName, "0"));
                GameState.FromJsonFile(file);

                LevelData = LevelHandler.CreateGameData();

                if (File.Exists(gameFilePath + "/" + string.Format(gameFileName, "1")))
                {
                    file = File.ReadAllText(gameFilePath + "/" + string.Format(gameFileName, "1"));
                    LevelData.FromJsonFile(file, GameState.Version);
                }

                GameState.Version = latestVersion;
            }
            else
            {
                GameState = new GameState();
                LevelData = LevelHandler.CreateGameData();
            }
        }
        catch (Exception e)
        {
            GameState = new GameState();
            LevelData = LevelHandler.CreateGameData();
        }
#elif YG_PLUGIN_YANDEX_GAME
        YandexGame.LoadProgress();
        try
        {
            GameState.FromJsonFile(YandexGame.savesData.pathFiles["0"]);
            LevelData.FromJsonFile(YandexGame.savesData.pathFiles["1"], GameState.Version);
        } 
        catch (Exception e)
        {
            GameState = new GameState();
            LevelData = LevelHandler.CreateGameData();
        }
#endif

        if (GameState.FreeGift == null || GameState.FreeGift.Count == 0)  
        {
            GameState.FreeGift = Reward.GetRandomReward(false);
        }
    }

    public double TimeJumpHours(int hours)
    {
        return TimeJump(3600 * hours);
    }

    public double TimeJumpDays(int days)
    {
        return TimeJump(86400 * days);
    }

    private double TimeJump(double seconds)
    {
        double totalAmount = 0;
        foreach (var business in LevelData.Businesses)
        {
            if (business.ManagerUnlocked)
            {
                totalAmount += business.ProfitGrowth(seconds, LevelData);
            }
        }

        return totalAmount;
    }

    public Sprite FindBusinessSpriteSheetIcon(string name)
    {
        var icon = businessSpriteSheet.FirstOrDefault(t => t.name == name);
        if (icon == null)
        {
            icon = businessSpriteSheet.FirstOrDefault(t => t.name == "b0");
        }

        return icon;
    }

    public Sprite FindItemSpriteSheetIcon(string name)
    {
        var icon = itemSpriteSheet.FirstOrDefault(t => t.name == name);
        if (icon == null)
        {
            icon = itemSpriteSheet.FirstOrDefault(t => t.name == "Star");
        }

        return icon;
    }

    public Sprite FindManagerSheetIcon(string name)
    {
        var icon = managerSheet.FirstOrDefault(t => t.name == name);
        if (icon == null)
        {
            icon = managerSheet.FirstOrDefault(t => t.name == "Manager_1");
        }

        return icon;
    }
}