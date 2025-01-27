using System;
using System.Collections;
using System.Linq;
using UnityEngine;

public class BusinessItem : MonoBehaviour
{
    public delegate void BusinessEvent(Business business);
    public event BusinessEvent OnBusinessTimerEnd = delegate { };

    [HideInInspector]
    public Business business;

    [HideInInspector]
    private LevelData level;

    [SerializeField]
    private BusinessUI businessUI;

    private AnimationState progressMax;

    // Use this for initialization
    void Start()
    {
        progressMax = businessUI.progressBarMaxImage.GetComponent<Animation>()["ProgressMax"];
    }

    // Update is called once per frame
    void Update()
    {
        businessUI.PurchaseBusinessEnable(level.Balance >= CostForNext(level.BuyCount));

        if (business.PurchasedCount == 0)
        {
            var initialPurchase = level.Balance >= CostForNext(level.BuyCount);
            businessUI.PurchaseInitialBusinessEnabled(initialPurchase);
        }
    }

    private double CostForNext(int buyCount)
    {
        return CostForNext(business, buyCount, out var num);
    }

    public void Initialize(Business businessData, LevelData levelData, Sprite sprite)
    {
        transform.localPosition = Vector3.zero;
        business = businessData;
        level = levelData;
        name = business.Id.ToString();

        var purchased = business.PurchasedCount > 0;
        var baseCost = NumberUtility.Convert(business.Cost, 1000000000.0, true);
        businessUI.Initialize(business.Id, sprite, business.Name, baseCost, purchased);
        businessUI.UpdateLabels(business.PurchasedCount, "0", "0", 1);

        if (business.CurrentTime > 0.0 || business.ManagerUnlocked)
        {
            StartCoroutine(StartCooldown());
        }
        else
        {
            ProgressEnable(business.PurchasedCount > 0);
        }

        var num = business.TimerInSeconds;
        var timeSpan = new TimeSpan((int)(num / 3600.0 % 60.0), (int)(num / 60.0 % 60.0), (int)num % 60);
        businessUI.UpdateTimeRemaining(timeSpan.ToString());

        businessUI.ShowCashPerSec(businessData.ShowCashPerSec);

        levelData.OnBusinessPurchase -= OnBusinessPurchase;
        levelData.OnBusinessPurchase += OnBusinessPurchase;
        levelData.OnUpgradePurchase -= OnUpgradePurchase;
        levelData.OnUpgradePurchase += OnUpgradePurchase;
        levelData.OnProductPurchase -= OnProductPurchase;
        levelData.OnProductPurchase += OnProductPurchase;
        levelData.OnManagerPurchase -= OnManagerPurchase;
        levelData.OnManagerPurchase += OnManagerPurchase;
        levelData.OnMilestoneAchieve -= OnMilestoneEarned;
        levelData.OnMilestoneAchieve += OnMilestoneEarned;
        GameManager.instance.OnCashChange -= OnCashChanged;
        GameManager.instance.OnCashChange += OnCashChanged;
        OnBusinessPurchase(business);
    }

    private void OnMilestoneEarned(Milestone milestone)
    {
        if (milestone.TargetId == business.Id || milestone.TargetId == 0)
        {
            UpdateBusinessBonus(milestone.EffectType, milestone.Effect);
        }
    }

    private void UpdateBusinessBonus(string effectType, double effect)
    {
        switch (effectType)
        {
            case "Cost":
                business.BaseCost -= (business.BaseCost * effect);
                break;
            case "Run":
                business.ManagerUnlocked = true;
                if (business.CurrentTime <= 0)
                {
                    StartCoroutine(StartCooldown());
                }
                break;
            case "Profit":
                business.BaseProfit *= effect;
                break;
            case "Speed":
                business.TimerInSeconds *= effect;
                break;
            case "Buy":
                business.PurchasedCount += Convert.ToInt32(effect);
                businessUI.SetPurchaseState(true);
                GameManager.instance.LevelData.CheckMilestone(business);
                break;
            case "Multiplier":
                business.PermanentMultiplier += effect;
                break;
        }
        UpdateUiText();
    }

    public void OnCashChanged()
    {
        UpdateUiText();
    }

    private void OnManagerPurchase(Manager manager)
    {
        if (manager.BusinessId == business.Id || manager.BusinessId == 0)
        {
            manager.Unlocked = true;
            UpdateBusinessBonus(manager.EffectType, manager.Effect);
        }
    }

    private void OnUpgradePurchase(Upgrade upgrade)
    {
        if (upgrade.BusinessId == business.Id || upgrade.BusinessId == 0)
        {
            upgrade.Unlocked = true;
            UpdateBusinessBonus(upgrade.EffectType, upgrade.Effect);
        }
    }

    private void OnProductPurchase(StoreProduct product)
    {
        if (product.BusinessId == business.Id || product.BusinessId == 0)
        {
            product.Unlocked = true;
            UpdateBusinessBonus(product.EffectType, product.Effect);
        }
    }

    public static double CostForNext(Business currentBusiness, int buyAmount, out int canAfford)
    {
        canAfford = 0;
        if (currentBusiness == null)
        {
            return 0.0;
        }
        canAfford = 1;
        var num = currentBusiness.Cost;
        var num2 = currentBusiness.Cost * currentBusiness.CostMultiplier;
        var num3 = 1;
        while ((buyAmount == -1) ? (num + num2 <= GameManager.instance.LevelData.Balance) : (num3 < buyAmount))
        {
            canAfford++;
            num += num2;
            num2 *= currentBusiness.CostMultiplier;
            num3++;
            if (canAfford >= 10000)
            {
                break;
            }
        }
        return num;
    }

    private void OnBusinessPurchase(Business business)
    {
        if (business == this.business)
        {
            UpdateUiText();
            if (business.PurchasedCount > 0 && business.CurrentTime == 0.0f)
            {
                ProgressEnable(true);
                businessUI.SetPurchaseState(true);
            }
        }
    }

    public void UpdateUiText()
    {
        var profit = NumberUtility.Convert(business.CalculateProfit(level.Investors, level.InvestorEffect) * (double)level.TotalMultiplier, 1000000.0, true);
        var num = CostForNext(business, level.BuyCount, out var canAfford);
        var cost = NumberUtility.Convert(num, 1000000.0, true);
        businessUI.UpdateLabels(business.PurchasedCount, profit, cost, canAfford);
        businessUI.PurchaseBusinessEnable(num <= level.Balance);
    }

    private IEnumerator StartCooldown()
    {
        yield return null;
        ProgressEnable(false);
        while (business.CurrentTime < business.TimerInSeconds && business.PurchasedCount > 0)
        {
            business.CurrentTime += Time.deltaTime;
            UpdateProgressBar();
            yield return null;
        }
        if (business.ManagerUnlocked)
        {
            var times = (int)Math.Floor(business.CurrentTime / business.TimerInSeconds);
            if (times < 1)
            {
                times = 1;
            }
            business.CurrentTime -= times * business.TimerInSeconds;
            if (business.CurrentTime < 0.0)
            {
                business.CurrentTime = 0.0;
            }
            level.Finished(business, times);
            if (OnBusinessTimerEnd != null)
            {
                OnBusinessTimerEnd(business);
            }
        }
        else
        {
            business.CurrentTime = 0.0;
            level.Finished(business, 1);
            if (OnBusinessTimerEnd != null)
            {
                OnBusinessTimerEnd(business);
            }
        }
        if (business.ManagerUnlocked)
        {
            StartCoroutine(StartCooldown());
        }
        else
        {
            UpdateProgressBar();
            if (business.PurchasedCount > 0)
            {
                ProgressEnable(true);
            }
        }
        yield break;
    }

    public void ProgressEnable(bool enable)
    {
        businessUI.RunBusinessEnable(enable);
    }

    private void UpdateProgressBar()
    {
        if (GameManager.instance != null)
        {
            var progress = 0f;
            if (business.TimerInSeconds <= 0.2f && business.CurrentTime > 0.0)
            {
                if (business.ManagerUnlocked)
                {
                    progress = 100f;
                    businessUI.ShowCashPerSec(true);
                    business.ShowCashPerSec = true;
                    businessUI.progressBarMaxImage.gameObject.SetActive(true);
                    //businessUI.progressBarImage.gameObject.SetActive(false);
                    var speed = Mathf.Abs(0.99f * (1f - (float)business.TimerInSeconds / 0.2f) + 1f);
                    if (speed > 1.5f)
                    {
                        speed = 1.5f;
                    }

                    progressMax.speed = speed;
                }
                else
                {
                    progress = 1f;
                }
            }
            else
            {
                if (business.ShowCashPerSec == false)
                {
                    progress = (float)business.Progress;
                    businessUI.progressBarMaxImage.gameObject.SetActive(false);
                    businessUI.progressBarImage.gameObject.SetActive(true);
                }
            }

            businessUI.UpdateProgressBar(progress);
            var num = business.TimerInSeconds - business.CurrentTime;
            if (business.PurchasedCount <= 0 || business.CurrentTime <= 0.10000000149011612)
            {
                num = business.TimerInSeconds;
            }
            var timeSpan = new TimeSpan((int)(num / 3600.0 % 60.0), (int)(num / 60.0 % 60.0), (int)num % 60);
            string time = timeSpan.ToString();
            if (business.ShowCashPerSec)
            {
                var unformatted = business.CashPerSecond(level.Investors, level.InvestorEffect) * (double)level.TotalMultiplier;
                var cashPerSec = NumberUtility.Convert(unformatted, 1000000.0, true);
                businessUI.UpdateCashPerSec(cashPerSec);
            }

            businessUI.UpdateTimeRemaining(time);
        }
    }

    public void PurchaseBusiness()
    {
        if (business.PurchasedCount == 0)
        {
            businessUI.SetPurchaseState(true);
            if (level.InvestorEffect + level.InvestorsSpent == 0)
                Io.AppMetrica.AppMetrica.ReportEvent($"Open Upgrade {business.Id}");
        }

        var num = level.BuyCount;
        if (num == -1)
        {
            CostForNext(business, -1, out num);
        }
        level.Purchase(business, num);
    }

    public void StartBusiness()
    {
        if (business.CurrentTime <= 0.0f)
        {
            AudioManager.instance.Playsound("starttimer");
            StartCoroutine(StartCooldown());
        }
    }

    public void Reset()
    {
        StopAllCoroutines();
        business.CurrentTime = 0.0f;
        UpdateProgressBar();
        ProgressEnable(business.PurchasedCount > 0);
        businessUI.SetPurchaseState(business.PurchasedCount > 0);
        businessUI.ShowCashPerSec(false);
    }
}