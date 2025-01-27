using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource BuySound;
    public AudioSource TimerSound;
    public AudioSource MultiplierSound;
    public AudioSource RewardSound;

    public AudioSource MusicSource;

    private bool soundFxEnabled;

    // Use this for initialization
    void Awake()
    {
        // Singelton - There can be only one...
        if (instance == null)
        {
            //DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ToggleBackgroundMusic();
        ToggleSoundFx();

        GameManager.instance.LevelData.OnGoldPurchase -= OnGoldPurchased;
        GameManager.instance.LevelData.OnGoldPurchase += OnGoldPurchased;
        GameManager.instance.LevelData.OnProductPurchase -= OnProductPurchase;
        GameManager.instance.LevelData.OnProductPurchase += OnProductPurchase;
        GameManager.instance.LevelData.OnMilestoneAchieve -= OnMilestoneAchieved;
        GameManager.instance.LevelData.OnMilestoneAchieve += OnMilestoneAchieved;
        GameManager.instance.LevelData.OnBusinessPurchase -= OnBusinessPurchase;
        GameManager.instance.LevelData.OnBusinessPurchase += OnBusinessPurchase;
        GameManager.instance.LevelData.OnManagerPurchase -= OnManagerPurchase;
        GameManager.instance.LevelData.OnManagerPurchase += OnManagerPurchase;
        GameManager.instance.LevelData.OnUpgradePurchase -= OnUpgradePurchase;
        GameManager.instance.LevelData.OnUpgradePurchase += OnUpgradePurchase;
    }

    public void ToggleBackgroundMusic()
    {
        if (GameManager.instance.GameState.Music == true)
        {
            MusicSource.Play();
        }
        else
        {
            MusicSource.Stop();
        }
    }

    public void ToggleSoundFx()
    {
        soundFxEnabled = GameManager.instance.GameState.SoundFx;
    }

    public void Playsound(string soundName)
    {
        if (soundFxEnabled)
        {
            //if (SoundFxSource.isPlaying)
            //{
            //    SoundFxSource.Stop();
            //}

            switch (soundName)
            {
                case "hiremanager":
                case "buyupgrade":
                case "buyitem":
                case "buystore":
                    if (!BuySound.isPlaying)
                    {
                        BuySound.Play();
                    }
                    break;
                case "starttimer":
                    if (!TimerSound.isPlaying)
                    {
                        TimerSound.Play();
                    }
                    break;
                case "multiplier":
                    if (!MultiplierSound.isPlaying)
                    {
                        MultiplierSound.Play();
                    }
                    break;
                case "reward":
                    if (!RewardSound.isPlaying)
                    {
                        RewardSound.Play();
                    }
                    break;

            }
        }
    }

    private void OnGoldPurchased(StoreProduct product)
    {
        if (product != null)
        {
            Playsound("buyitem");
        }
    }

    private void OnMilestoneAchieved(Milestone milestone)
    {
        if (milestone != null)
        {
            Playsound("multiplier");
        }
    }

    private void OnBusinessPurchase(Business business)
    {
        Playsound("buystore");
    }

    private void OnManagerPurchase(Manager manager)
    {
        Playsound("hiremanager");
    }

    private void OnUpgradePurchase(Upgrade upgrade)
    {
        Playsound("buyupgrade");
    }

    private void OnProductPurchase(StoreProduct product)
    {
        Playsound("buyupgrade");
    }
}