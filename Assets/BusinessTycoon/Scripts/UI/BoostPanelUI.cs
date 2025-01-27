using System;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class BoostPanelUI : MonoBehaviour
{
    [SerializeField]
    private Text multiplierText;

    [SerializeField]
    private GameObject bonusGift;
    [SerializeField]
    private Text bonusGiftTimer;

    [SerializeField]
    private GameObject daily;
    [SerializeField]
    private Text dailyTimer;

    [SerializeField]
    private GameObject adBoost;
    [SerializeField]
    private Text adBoostTimer;

    private GameManager gameManager;

    private Animator giftAnimator;
    private Animator dailyAnimator;
    private Animator adBoostAnimator;
    private Button bonusGiftButton;
    private Button dailyGiftButton;

    void Start()
    {
        bonusGiftButton = bonusGift.gameObject.GetComponent<Button>();
        dailyGiftButton = daily.gameObject.GetComponent<Button>();

        giftAnimator = bonusGift.gameObject.GetComponent<Animator>();
        dailyAnimator = daily.gameObject.GetComponent<Animator>();
        adBoostAnimator = adBoost.gameObject.GetComponent<Animator>();

        gameManager = GameManager.instance;
        multiplierText.text = gameManager.LevelData.GetMultiplierCountText();
    }

    public void OnClickGift()
    {
        FreeGiftUI.instance.Show();
    }

    public void OnClickDailyGift()
    {
        DailyGiftUI.instance.Show();
    }

    public void OnClickAdBoost()
    {
        ProfitBoostUI.instance.Show();
    }

    public void OnClickMultiplier()
    {
        multiplierText.text = gameManager.LevelData.ChangeMultiplier();

        foreach (var business in gameManager.BusinessItems)
        {
            business.UpdateUiText();
        }
    }

    private void LateUpdate()
    {
        UpdateDailyTimer();
        UpdateGiftTimer();
        UpdateAdBoostTimer();
    }

    private void UpdateGiftTimer()
    {
        var giftTimer = Convert.ToInt32((DateTime.FromOADate(gameManager.LevelData.LastFreeGift) - DateTime.Now).TotalSeconds - Time.deltaTime);
        if (giftTimer >= 1)
        {
            var hours = giftTimer / 3600;
            var minutes = giftTimer / 60 % 60;
            var seconds = giftTimer % 60;
            bonusGiftTimer.text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            giftAnimator.Play(0);
            bonusGiftButton.interactable = false;
        }
        else
        {
            bonusGiftButton.interactable = true;
            bonusGiftTimer.text = "Бесплатно";
        }
    }

    private void UpdateDailyTimer()
    {
        var dailygiftTimer = Convert.ToInt32((DateTime.FromOADate(gameManager.GameState.DailyGift) - DateTime.Now).TotalSeconds - Time.deltaTime);
        if (dailygiftTimer >= 1)
        {
            var hours = dailygiftTimer / 3600;
            var minutes = dailygiftTimer / 60 % 60;
            var seconds = dailygiftTimer % 60;
            dailyTimer.text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            dailyAnimator.Play(0);
            dailyGiftButton.interactable = false;
        }
        else
        {
            dailyGiftButton.interactable = true;
            dailyTimer.text = "Ежедневный подарок";
        }
    }

    private void UpdateAdBoostTimer()
    {
        var videoAdBoostTimer = Convert.ToInt32((DateTime.FromOADate(gameManager.LevelData.VideoStarted) - DateTime.Now).TotalSeconds - Time.deltaTime);
        if (videoAdBoostTimer >= 1)
        {
            gameManager.LevelData.VideoMultiplier = 2;
            var hours = videoAdBoostTimer / 3600;
            var minutes = videoAdBoostTimer / 60 % 60;
            var seconds = videoAdBoostTimer % 60;
            adBoostTimer.text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            if (hours > 1)
            {
                adBoostAnimator.Play(0);
            }
        }
        else
        {
            gameManager.LevelData.VideoMultiplier = 1;
            adBoostTimer.text = "Ускорь заработок";
        }
    }
}