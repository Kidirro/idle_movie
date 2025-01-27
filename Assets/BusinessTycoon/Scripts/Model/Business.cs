using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[Serializable]
public class Business
{
    public int Id = 0;
    [NonSerialized]
    public string Name = "";
    public int PurchasedCount = 0;
    public double BaseCost = 0;
    public double BaseProfit = 0;
    public double PermanentMultiplier = 0;
    public double TimerInSeconds = 0;
    public double CurrentTime = 0;
    public float CostMultiplier = 1;
    public bool ManagerUnlocked = false;
    public bool ShowCashPerSec = false;

    public Business()
    {

    }

    public double Progress => CurrentTime / TimerInSeconds;

    public double Profit
    {
        get
        {
            return BaseProfit * PurchasedCount * (PermanentMultiplier <= 0 ? 1 : PermanentMultiplier);
        }
    }

    public double Cost
    {
        get
        {
            return BaseCost * Math.Pow(CostMultiplier, PurchasedCount);
        }
    }

    public void Purchase(LevelData levelData)
    {
        levelData.Balance -= Cost;
        PurchasedCount++;
    }

    public double AddOfflineTime(double elapsed, LevelData levelData)
    {
        if (CurrentTime <= 0.0)
        {
            return 0.0;
        }
        if (TimerInSeconds > CurrentTime + elapsed)
        {
            CurrentTime += elapsed;
            return 0.0;
        }
        if (ManagerUnlocked)
        {
            var num = (CurrentTime + elapsed) / TimerInSeconds;
            var num2 = (num - Math.Truncate(num)) * TimerInSeconds;
            CurrentTime = num2;
        }
        else
        {
            CurrentTime = TimerInSeconds;
            elapsed = 0;
        }
        return AddProfit(elapsed, levelData);
    }

    public double CashPerSecond(double investors, double investorEffect)
    {
        return CalculateProfit(investors, investorEffect) / TimerInSeconds;
    }

    public double CalculateProfit(double investors, double investorEffect)
    {
        return Profit * (1 + investors * investorEffect);
    }

    public double ProfitGrowth(double seconds, LevelData levelData)
    {
        return AddProfit(seconds, levelData);
    }

    private double AddProfit(double seconds, LevelData levelData)
    {
        var addAmount = CashPerSecond(levelData.Investors, levelData.InvestorEffect) * seconds;
        return levelData.AddToBalance(addAmount);
    }

    public void Copy(Business copyFrom)
    {
        BaseCost = copyFrom.BaseCost;
        BaseProfit = copyFrom.BaseProfit;
        CostMultiplier = copyFrom.CostMultiplier;
        PurchasedCount = copyFrom.PurchasedCount;
        CurrentTime = copyFrom.CurrentTime;
        Id = copyFrom.Id;
        ManagerUnlocked = copyFrom.ManagerUnlocked;
        Name = copyFrom.Name;
        PermanentMultiplier = copyFrom.PermanentMultiplier;
        ShowCashPerSec = copyFrom.ShowCashPerSec;
        TimerInSeconds = copyFrom.TimerInSeconds;
    }
}