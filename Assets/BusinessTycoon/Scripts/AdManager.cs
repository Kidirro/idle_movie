using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using YandexMobileAds;
using YandexMobileAds.Base;

#if UNITY_WEBGL
using YG;
#endif

public class AdManager : MonoBehaviour
{
    public static AdManager instance = null;

    private Interstitial _interstitialAd;
    private RewardedAd _rewardedAd;

    InterstitialAdLoader interstitialAdLoader;
    RewardedAdLoader rewardedAdLoader;



    public string RewardedId_Android = "R-M-12416217-1";

    public bool TestMode = false;

    private string gameId;
    private string rewardedId;
    private static string rewardType;
    private bool isReady = false;

    void Awake()
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

        Initialize();
        
        
    }

    
#if YG_PLUGIN_YANDEX_GAME
    private void YG_RewardVideoEvent(int obj)
    {
        AddRewardToPlayer();
    }
#endif

    public void Initialize()
    {
        interstitialAdLoader = new InterstitialAdLoader();


        rewardedAdLoader = new RewardedAdLoader();
        rewardedAdLoader.OnAdLoaded += HandleAdLoaded;
        rewardedAdLoader.OnAdFailedToLoad += HandleAdFailedToLoad;
        OnInitializationComplete();
        
        
#if YG_PLUGIN_YANDEX_GAME
        //YandexGame.RewardVideoEvent += YG_RewardVideoEvent;
        isReady = true;
#endif
    }

    public void OnDestroy()
    {
#if YG_PLUGIN_YANDEX_GAME
        //YandexGame.RewardVideoEvent -= YG_RewardVideoEvent;
#endif
    }

    public void HandleAdLoaded(object sender, RewardedAdLoadedEventArgs args)
    {

        isReady = true;
        args.RewardedAd.OnAdShown += (x, y) => { AddRewardToPlayer(); LoadRewardedAd(); };
        Debug.Log("Rewarded ad loaded with response : " + args.RewardedAd.GetInfo());

        // Rewarded ad was loaded successfully. Now you can handle it.
        _rewardedAd = args.RewardedAd;
    }

    public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        isReady = false;
        Debug.LogError("Rewarded ad failed to load an ad with error : " + args.Message);
        // Ad {args.AdUnitId} failed for to load with {args.Message}
        // Attempting to load new ad from the OnAdFailedToLoad event is strongly discouraged.
    }
    
    public void LoadRewardedAd()
    {
        AdRequestConfiguration adRequestConfiguration = new AdRequestConfiguration.Builder(RewardedId_Android).Build();
        rewardedAdLoader.LoadAd(adRequestConfiguration);
    }

    #region Interface Implementations
    public void OnInitializationComplete()
    {
        Debug.Log("Init Success");
        LoadRewardedAd();
    }



    #endregion

    public bool UnityAdReady()
    {
        return isReady;
    }

    public void ShowAd(string reward)
    {
        rewardType = reward;
#if UNITY_ANDROID || UNITY_IOS


        if (_rewardedAd != null)
        {
            Debug.Log("Showing rewarded ad.");
            _rewardedAd.Show();
        }
        else
        {
            Debug.LogError("Rewarded ad is not ready yet.");
        }

#elif YG_PLUGIN_YANDEX_GAME
        
        YandexGame.RewVideoShow(reward);
#endif

    }

    private void AddRewardToPlayer()
    {
        // Video completed - Offer a reward to the player
        switch (rewardType)
        {
            case "OfflineEarning":
                MainUIController.instance.DoubleOfflineEarning();
                break;
            case "DoubleGift":
                FreeGiftUI.instance.DoubleReward();
                break;
            case "DoubleProfit":
                ProfitBoostUI.instance.ExtendBoostTime();
                break;
        }
    }
}
