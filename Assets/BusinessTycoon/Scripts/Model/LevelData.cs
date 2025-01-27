using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using RuStore.BillingClient;
using UnityEngine;

[Serializable]
public class LevelData
{
    public delegate void BusinessPurchased(Business business);
    public delegate void MilestoneAchieved(Milestone achievement);
    public delegate void ManagerPurchased(Manager manager);
    public delegate void UpgradePurchased(Upgrade upgrade);
    public delegate void ProductPurchased(StoreProduct product);
    public delegate void GoldPurchased(StoreProduct product);
    public delegate void GameReset();

    public event BusinessPurchased OnBusinessPurchase = delegate { };
    public event MilestoneAchieved OnMilestoneAchieve = delegate { };
    public event ManagerPurchased OnManagerPurchase = delegate { };
    public event UpgradePurchased OnUpgradePurchase = delegate { };
    public event ProductPurchased OnProductPurchase = delegate { };
    public event GoldPurchased OnGoldPurchase = delegate { };
    public event GameReset OnGameReset;

    public double Balance = 0;
    public double TotalCashPerSec = 0;
    public double TimeStamp = DateTime.Now.ToOADate();
    public int BuyCount = 1;

    public double Investors = 0;
    public double InvestorsSpent = 0;
    public double InvestorEffect = 0.02;
    public double TotalBalance = 0;
    public double OverallTotalCash = 0;
    public int TotalResets = 0;
    public bool Completed = false;
    public float Version = 0f;

    public double LastFreeGift = DateTime.Now.ToOADate();
    public int VideoMultiplier = 1;
    public double VideoStarted = DateTime.Now.ToOADate();

    public int PermanentMultiplier = 0;

    public List<Business> Businesses = new List<Business>();
    public List<Manager> Managers = new List<Manager>();
    public List<Upgrade> Upgrades = new List<Upgrade>();
    public List<StoreProduct> Products = new List<StoreProduct>();
    public List<Milestone> Milestones = new List<Milestone>();

    public LevelData()
    {

    }

    public double TotalMultiplier
    {
        get
        {
            var num = 0f;
            if (VideoMultiplier > 1f)
            {
                num += VideoMultiplier;
            }

            if (PermanentMultiplier > 1f)
            {
                num += PermanentMultiplier;
            }

            return (num <= 0f) ? 1f : num;
        }
    }

    public string GetMultiplierCountText()
    {
        if (BuyCount >= 1)
        {
            return "x" + BuyCount;
        }
        else
        {
            return "Max";
        }
    }

    public string ChangeMultiplier()
    {
        switch (BuyCount.ToString())
        {
            case "1":
                BuyCount = 10;
                break;
            case "10":
                BuyCount = 50;
                break;
            case "50":
                BuyCount = 100;
                break;
            case "100":
                BuyCount = -1; // Max
                break;
            default:
                BuyCount = 1;
                break;
        }

        return GetMultiplierCountText();
    }

    public double CalculateInvestors()
    {
        return CalculateInvestors(TotalBalance + OverallTotalCash) - CalculateInvestors(OverallTotalCash);
    }

    public double CalculateInvestors(double totalCash)
    {
        var num = Math.Floor(Math.Sqrt(1.0 + 9.0 * (totalCash / Math.Pow(10.0, 11.0)) - 1.0) / 2.0);
        var num2 = num - InvestorsSpent;
        return (num2 <= 0.0) ? 0.0 : num2;
    }

    public void ClaimInvestorsWithGold()
    {
        Investors += CalculateInvestors();
        OverallTotalCash += TotalBalance;
        TotalBalance = 0;
        TotalResets++;
    }

    public void ResetLevel()
    {
        ClaimInvestorsAndResetGame();
        Investors = 0;
        InvestorsSpent = 0;
        OverallTotalCash = 0;
        TotalBalance = 0;

        foreach (var milestone in Milestones)
        {
            milestone.Unlocked = false;
        }
    }

    public void ClaimInvestorsAndResetGame()
    {
        Investors += CalculateInvestors();
        OverallTotalCash += TotalBalance;
        string eventParameters = "{\"TotalProduser\":\""+Investors+"\", \"ProduserNew\":\""+CalculateInvestors()+"\"}";
        Io.AppMetrica.AppMetrica.ReportEvent("Updates installed", eventParameters);
        var currentLevelData = LevelHandler.CreateGameData();
        var businessList = currentLevelData.Businesses;

        InvestorEffect = currentLevelData.InvestorEffect;
        TotalCashPerSec = 0;

        PermanentMultiplier = 0;

        for (var i = 0; i < Businesses.Count; i++)
        {
            Businesses[i].Copy(businessList[i]);
        }

        foreach (var item in GameManager.instance.UpgradeItems)
        {
            if (item.upgrade.CurrencyId == 0 || item.upgrade.CurrencyId == 1)
            {
                item.upgrade.Unlocked = false;
                item.gameObject.SetActive(false);
            }
            else
            {
                if (item.upgrade.Unlocked)
                {
                    UnlockUpgradeWithOutCheck(item.upgrade);
                }
            }
        }

        foreach (var item in GameManager.instance.ManagerItems)
        {
            if (item.manager.CurrencyId == 0 || item.manager.CurrencyId == 1)
            {
                item.manager.Unlocked = false;
                item.gameObject.SetActive(false);
            }
            else
            {
                if (item.manager.Unlocked)
                {
                    UnlockManagerWithOutCheck(item.manager);
                }
            }
        }

        foreach (var item in GameManager.instance.ProductItems)
        {
            if (item.product.CurrencyId == 0 || item.product.CurrencyId == 1)
            {
                item.product.Unlocked = false;
                item.gameObject.SetActive(false);
            }
            else
            {
                if (item.product.Unlocked)
                {
                    UnlockProductWithOutCheck(item.product);
                }
            }
        }

        foreach (var milestone in Milestones)
        {
            if ((new[] { "Profit", "Speed" }).Contains(milestone.EffectType))
            {
                milestone.Unlocked = false;
            }
        }

        if (OnGameReset != null)
        {
            OnGameReset();
        }

        SetBalance(0);
        TotalResets++;
    }

    public void Purchase(Business business, int buyCount)
    {
        for (var i = 0; i < buyCount; i++)
        {
            if (Balance - business.Cost < 0.0)
            {
                break;
            }
            business.Purchase(this);
        }

        OnBusinessPurchase(business);
        CheckMilestone(business);
        UpdateTotalCashPerSec();
    }

    public void CheckMilestone(Business business)
    {
        var list = Milestones.FindAll(t => t.BusinessId == business.Id && t.Unlocked == false);
        Milestone milestone = null;
        foreach (var item in list)
        {
            if (business.PurchasedCount >= item.Count)
            {
                milestone = item;
                item.Unlocked = true;
                if (OnMilestoneAchieve != null)
                {
                    OnMilestoneAchieve(milestone);
                    CheckIfLevelIsCompleted();
                }
            }
        }

        list = Milestones.FindAll(t => t.BusinessId == 0 && t.Unlocked == false);
        foreach (var item in list)
        {
            var newMilestone = true;
            foreach (var businessItem in Businesses)
            {
                if (businessItem.PurchasedCount < item.Count)
                {
                    newMilestone = false;
                    break;
                }
            }

            if (newMilestone == true)
            {
                item.Unlocked = true;
                milestone = item;
                if (OnMilestoneAchieve != null)
                {
                    OnMilestoneAchieve(milestone);
                    CheckIfLevelIsCompleted();
                }
            }
        }
    }

    public void CheckIfLevelIsCompleted()
    {
        var uncompletedMilestones = Milestones.Count(t => t.Unlocked == false);
        if (uncompletedMilestones == 0)
        {
            MainUIController.instance.ShowLevelCompleted();
            MainUIController.instance.OnClickWelcomeBackHide();
        }
    }

    public void Finished(Business business, int times)
    {
        var num = business.CalculateProfit(Investors, InvestorEffect);
        Balance += num * (double)times * (double)TotalMultiplier;
        TotalBalance += num * (double)times * (double)TotalMultiplier;
    }

    public double AddToBalanceWithoutMultiplier(double amount)
    {
        Balance += amount;
        if (amount > 0)
        {
            TotalBalance += amount;
        }

        return amount;
    }

    public double AddToBalance(double amount)
    {
        amount *= (double)TotalMultiplier;
        Balance += amount;
        TotalBalance += amount;
        return amount;
    }

    private void SetBalance(double amount)
    {
        Balance = amount;
        TotalBalance = amount;
    }

    public void UpdateLongUpgradeListItems()
    {
        //Fix number of active upgrades
        var maxListItem = 20;
        var maxBoostListItem = 10;
        var items = GameManager.instance.UpgradeItems.Where(t => t.upgrade.Unlocked == false && t.upgrade.CurrencyId == 0).Take(maxListItem);
        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }

        items = GameManager.instance.UpgradeItems.Where(t => t.upgrade.Unlocked == false && t.upgrade.CurrencyId == 1).Take(maxListItem);
        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }

        items = GameManager.instance.UpgradeItems.Where(t => t.upgrade.Unlocked == false && t.upgrade.CurrencyId == 3).Take(maxBoostListItem);
        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }
    }

    public void UpdateLongProductListItems()
    {
        //Fix number of active products
        var maxListItem = 10;
        var items = GameManager.instance.ProductItems.Where(t => t.product.Unlocked == false && t.product.CurrencyId == 2 || t.product.CurrencyId == 3).Take(maxListItem);

        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }

        items = GameManager.instance.ProductItems.Where(t => t.product.Unlocked == false && t.product.CurrencyId == 10).Take(maxListItem);

        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }
    }

    public void UpdateLongManagerListItems()
    {
        //Fix number of active upgrades
        var maxListItem = 10;
        var items = GameManager.instance.ManagerItems.Where(t => t.manager.Unlocked == false && t.manager.CurrencyId == 0).Take(maxListItem);
        foreach (var item in items)
        {
            item.gameObject.SetActive(true);
        }
    }

    public void UnlockManager(Manager manager)
    {
        switch (manager.CurrencyId)
        {
            case 0: //Cash
                if (Balance - manager.Cost < 0.0)
                {
                    return;
                }
                Balance -= manager.Cost;
                break;
            case 1: //Investor
                if (Investors - manager.Cost < 0.0)
                {
                    return;
                }
                Investors -= manager.Cost;
                InvestorsSpent += manager.Cost;
                break;
            default:
                return;
        }

        UnlockManagerWithOutCheck(manager);
        UpdateLongManagerListItems();
    }

    public void UnlockManagerWithOutCheck(Manager manager)
    {
        if (manager.EffectType == "iEffect")
        {
            InvestorEffect += manager.Effect;
        }

        if (OnManagerPurchase != null)
        {
            OnManagerPurchase(manager);
        }
        UpdateTotalCashPerSec();
    }

    public void UnlockProduct(StoreProduct product)
    {
        switch (product.CurrencyId)
        {
            case 3: // Gold
                if (GameManager.instance.GameState.Gold - product.Cost < 0.0)
                {
                    return;
                }
                GameManager.instance.GameState.Gold -= product.Cost;
                break;
            case 10: // Real Money
                
#if UNITY_ANDROID
                PurchaseManager.instance.BuyProductAndroidID(product);
#elif UNITY_IOS
                PurchaseManager.instance.BuyProductIOSID(product.SKU);
#elif YG_PLUGIN_YANDEX_GAME
                PurchaseManager.instance.BuyProductYandexID(product.YAN_Id);
#endif
                return;
            default:
                return;
        }
        Io.AppMetrica.AppMetrica.ReportEvent($"Buy product {product.Name}");
            

        UnlockProductWithOutCheck(product);
        UpdateLongProductListItems();
    }

    public void UnlockUpgrade(Upgrade upgrade)
    {
        switch (upgrade.CurrencyId)
        {
            case 0: //Cash
                if (Balance - upgrade.Cost < 0.0)
                {
                    return;
                }
                Balance -= upgrade.Cost;
                break;
            case 1: //Investor
                if (Investors - upgrade.Cost < 0.0)
                {
                    return;
                }
                Investors -= upgrade.Cost;
                InvestorsSpent += upgrade.Cost;
                break;
            case 3: //Gold
                if (GameManager.instance.GameState.Gold - upgrade.Cost < 0.0)
                {
                    return;
                }
                GameManager.instance.GameState.Gold -= upgrade.Cost;
                break;
            default:
                return;
        }

        Io.AppMetrica.AppMetrica.ReportEvent($"Buy upgrade {upgrade.Name} : {upgrade.Id}");
        UnlockUpgradeWithOutCheck(upgrade);
        UpdateLongUpgradeListItems();
    }

    public void UnlockUpgradeWithOutCheck(Upgrade upgrade)
    {
        if (upgrade.EffectType == "iEffect")
        {
            InvestorEffect += upgrade.Effect;
        }

        if (OnUpgradePurchase != null)
        {
            OnUpgradePurchase(upgrade);
        }

        UpdateTotalCashPerSec();
    }

    public void UnlockProductWithOutCheck(StoreProduct product)
    {
        if (product.EffectType == "iEffect")
        {
            InvestorEffect += product.Effect;
        }

        if (product.CurrencyId == 3)
        {
            if (OnGoldPurchase != null)
            {
                OnGoldPurchase(product);
            }
        }
        else
        {
            if (OnProductPurchase != null)
            {
                OnProductPurchase(product);
            }
        }

        UpdateTotalCashPerSec();
    }

    public string GetBusinessNameById(int id)
    {
        var name = "Все";

        var business = Businesses.FirstOrDefault(t => t.Id == id);
        if (business != null)
        {
            name = business.Name;
        }

        return name;
    }

    public string GetBusinessNameByIdInPlural(int id)
    {
        var name = "Все";

        var business = Businesses.FirstOrDefault(t => t.Id == id);
        if (business != null)
        {
            name = business.Name;
        }

        return name;
    }

    private void UpdateTotalCashPerSec()
    {
        double total = 0;

        foreach (var business in Businesses.Where(t => t.ManagerUnlocked))
        {
            total += business.CashPerSecond(Investors, InvestorEffect);
        }

        TotalCashPerSec = total;

    }

    public string ToJsonString()
    {
        return Encrypt.EncryptString(JsonUtility.ToJson(this));
    }

    public void FromJsonFile(string file, float version)
    {
        var json = Encrypt.DecryptString(file);

        if (Version != version)
        {
            var loadedLevel = JsonUtility.FromJson<LevelData>(json);

            Balance = loadedLevel.Balance;
            BuyCount = loadedLevel.BuyCount;
            InvestorEffect = loadedLevel.InvestorEffect;
            Investors = loadedLevel.Investors;
            InvestorsSpent = loadedLevel.InvestorsSpent;
            LastFreeGift = loadedLevel.LastFreeGift;
            OverallTotalCash = loadedLevel.OverallTotalCash;
            PermanentMultiplier = loadedLevel.PermanentMultiplier;
            TimeStamp = loadedLevel.TimeStamp;
            TotalBalance = loadedLevel.TotalBalance;
            TotalCashPerSec = loadedLevel.TotalCashPerSec;
            TotalResets = loadedLevel.TotalResets;
            Completed = loadedLevel.Completed;
            VideoMultiplier = loadedLevel.VideoMultiplier;
            VideoStarted = loadedLevel.VideoStarted;
            Version = version;

            foreach (var business in Businesses)
            {
                foreach (var loadedBusiness in loadedLevel.Businesses)
                {
                    if (business.Id == loadedBusiness.Id)
                    {
                        business.BaseCost = loadedBusiness.BaseCost;
                        business.BaseProfit = loadedBusiness.BaseProfit;
                        business.CostMultiplier = loadedBusiness.CostMultiplier;
                        business.PurchasedCount = loadedBusiness.PurchasedCount;
                        business.CurrentTime = loadedBusiness.CurrentTime;
                        business.ManagerUnlocked = loadedBusiness.ManagerUnlocked;
                        business.PermanentMultiplier = loadedBusiness.PermanentMultiplier;
                        business.ShowCashPerSec = loadedBusiness.ShowCashPerSec;
                        business.TimerInSeconds = loadedBusiness.TimerInSeconds;
                    }
                }
            }

            foreach (var manager in Managers)
            {
                foreach (var loadedManager in loadedLevel.Managers)
                {
                    if (manager.Id == loadedManager.Id)
                    {
                        manager.Unlocked = loadedManager.Unlocked;
                    }
                }
            }

            foreach (var upgrade in Upgrades)
            {
                foreach (var loadedUpgrade in loadedLevel.Upgrades)
                {
                    if (upgrade.Id == loadedUpgrade.Id)
                    {
                        upgrade.Unlocked = loadedUpgrade.Unlocked;
                    }
                }
            }

            foreach (var product in Products)
            {
                foreach (var loadedProduct in loadedLevel.Products)
                {
                    if (product.Id == loadedProduct.Id)
                    {
                        product.Unlocked = loadedProduct.Unlocked;
                    }
                }
            }

            foreach (var milestorne in Milestones)
            {
                foreach (var loadedMilestone in loadedLevel.Milestones)
                {
                    if (milestorne.Id == loadedMilestone.Id)
                    {
                        milestorne.Unlocked = loadedMilestone.Unlocked;
                    }
                }
            }
        }
        else
        {
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}