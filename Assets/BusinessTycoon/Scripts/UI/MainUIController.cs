using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Game;

public class MainUIController : MonoBehaviour
{
    public static MainUIController instance;

    [SerializeField]
    private RectTransform businessContainer;
    [SerializeField]
    private GameObject businessPrefab;

    [SerializeField]
    private RectTransform cashManagerContainer;
    [SerializeField]
    private GameObject managerPrefab;

    [SerializeField]
    private RectTransform cashUpgradeContainer;
    [SerializeField]
    private RectTransform investorUpgradeContainer;
    [SerializeField]
    private RectTransform goldUpgradeContainer;
    [SerializeField]
    private GameObject upgradePrefab;

    [SerializeField]
    private RectTransform premiumProductContainer;
    [SerializeField]
    private RectTransform goldProductContainer;
    [SerializeField]
    private GameObject productPrefab;

    [SerializeField]
    private RectTransform milestoneContainer;
    [SerializeField]
    private RectTransform milestoneGalleryContainer;
    [SerializeField]
    private GameObject milestonePrefab;
    [SerializeField]
    private GameObject milestoneItemPrefab;

    [SerializeField]
    private RectTransform milestonesPanel;
    [SerializeField]
    private RectTransform milestonesGalleryPanel;
    [SerializeField]
    private RectTransform managerPanel;
    [SerializeField]
    private RectTransform upgradePanel;
    [SerializeField]
    private RectTransform shopPanel;
    [SerializeField]
    private RectTransform welcomeBackPanel;
    [SerializeField]
    private RectTransform freeGiftPanel;
    [SerializeField]
    private RectTransform dailyGiftPanel;
    [SerializeField]
    private RectTransform profitBoostPanel;
    [SerializeField]
    private RectTransform investorsPanel;
    [SerializeField]
    private RectTransform settingsPanel;
    [SerializeField]
    private RectTransform loadingPanel;
    [SerializeField]
    private RectTransform rewardPanel;
    [SerializeField]
    private RectTransform resetLevelPanel;
    [SerializeField]
    private RectTransform wheelOfFortunePanel;
    [SerializeField]
    private RectTransform debugPanel;
    [SerializeField]
    private Text goldBalanceText;
    [SerializeField]
    private Text balanceText;
    [SerializeField]
    private Text balanceScaleText;
    [SerializeField]
    private Text milestoneCountText;

    [SerializeField]
    private Text currentInvestorText;
    [SerializeField]
    private Text currentInvestorEffectText;
    [SerializeField]
    private Text investorText;

    [SerializeField]
    private Image managerNotifyImage;
    [SerializeField]
    private Image upgradeNotifyImage;
    [SerializeField]
    private Image investorsNotifyImage;

    private GameManager gameManager;

    private double offlineCash = 0;

    public void ShowLevelCompleted()
    {
        resetLevelPanel.Show();
    }

    public void OnClickResetLevel()
    {
        gameManager.LevelData.ResetLevel();
        resetLevelPanel.Hide();
        if (GameManager.instance.LevelData.Completed)
        {
            RewardUI.instance.Show(Reward.RewardGold(100));
        }
        else
        {
            RewardUI.instance.Show(Reward.RewardGold(500));
            GameManager.instance.LevelData.Completed = true;
        }
    }

    public void OnClickResetLevelLater()
    {
        resetLevelPanel.Hide();
    }

    public void OnClickClaimInvestorWithReset()
    {
        if (gameManager.LevelData.CalculateInvestors() <= 0)
        {
            MessageBoxUI.instance.Show("Придержи коней", "У вас нет продюссеров для получения.", null, MessageBoxUI.ButtonOptions.OK, "Ok");
            return;
        }

        void Action()
        {
            var num = gameManager.LevelData.CalculateInvestors();
            gameManager.LevelData.ClaimInvestorsAndResetGame();
            PrestigeClaimUI.instance.Show(num);
            OnClickInvestorsHide();
        }

        MessageBoxUI.instance.Show("Получить продюссеров и обнулить", "Вы хотите обнулить прогресс и получить продюссеров?", Action, MessageBoxUI.ButtonOptions.OK_Cancel, "Yes", "Cancel", true);
    }

    public void OnClickClaimInvestorWithGold()
    {
        if (gameManager.LevelData.CalculateInvestors() <= 0)
        {
            MessageBoxUI.instance.Show("Придержи коней", "У вас нет продюссеров для получения.", null, MessageBoxUI.ButtonOptions.OK, "Ok");
            return;
        }
        if (GameManager.instance.GameState.Gold - 20 < 0.0)
        {
            MessageBoxUI.instance.Show("Дефицит золота", "У вас не хватает золото, чтобы совершить действие.\nХотите посетить магазин?", OnClickShopShow, MessageBoxUI.ButtonOptions.OK_Cancel, "Yes", "No", true);
        }
        else
        {
            void Action()
            {
                var num = gameManager.LevelData.CalculateInvestors();
                GameManager.instance.GameState.Gold -= 20;
                gameManager.LevelData.ClaimInvestorsWithGold();
                PrestigeClaimUI.instance.Show(num);
                OnClickInvestorsHide();
            }

            MessageBoxUI.instance.Show("Получить продюссеров за золото?", "Хотите потратить 20 золота и получить продюссеров без обнуления?", Action, MessageBoxUI.ButtonOptions.OK_Cancel, "Yes", "No", true);
        }
    }

    public void DoubleOfflineEarning()
    {
        // Offline cash already added, add only the double and show message.
        GameManager.instance.LevelData.AddToBalanceWithoutMultiplier(offlineCash);
        ToastUI.instance.FlashToast("Оффлайн заработок x2", NumberUtility.Convert(offlineCash * 2, 1000000.0, true), 5f);
        OnClickWelcomeBackHide();
    }

    public void OnClickInvestorsShow()
    {
        currentInvestorText.text = NumberUtility.Convert(gameManager.LevelData.Investors, 1000000.0);
        currentInvestorEffectText.text = (gameManager.LevelData.InvestorEffect * 100) + "% за каждого продюссера.";
       
        investorsPanel.Show();
    }

    public void OnClickSettingsShow()
    {
        settingsPanel.Show();
    }

    public void OnClickSettingsHide()
    {
        settingsPanel.Hide();
    }

    public void SpinWheelShow()
    {
        wheelOfFortunePanel.Show();
    }

    public void SpinWheelHide()
    {
        wheelOfFortunePanel.Hide();
    }

    public void DebugShow()
    {
        debugPanel.Show();
    }

    public void DebugHide()
    {
        debugPanel.Hide();
    }

    public void RewardPanelShow(string prize, int amount)
    {
        rewardPanel.Show();
    }

    public void OnClickInvestorsHide()
    {
        investorsPanel.Hide();
    }

    public void OnClickManagerShow()
    {
        cashManagerContainer.anchoredPosition = Vector3.zero;
        GameManager.instance.LevelData.UpdateLongManagerListItems();
        managerPanel.Show();
    }

    public void OnClickManagerHide()
    {
        foreach (var item in gameManager.ManagerItems)
        {
            item.gameObject.SetActive(false);
        }
        managerPanel.Hide();
    }

    public void OnClickUpgradeShow()
    {
        cashUpgradeContainer.anchoredPosition = Vector3.zero;
        investorUpgradeContainer.anchoredPosition = Vector3.zero;
        goldUpgradeContainer.anchoredPosition = Vector3.zero;
        GameManager.instance.LevelData.UpdateLongUpgradeListItems();
        upgradePanel.Show();
    }

    public void OnClickShopShow()
    {
        premiumProductContainer.anchoredPosition = Vector3.zero;
        goldProductContainer.anchoredPosition = Vector3.zero;
        GameManager.instance.LevelData.UpdateLongProductListItems();
        shopPanel.Show();
    }

    public void OnClickUpgradeHide()
    {
        foreach (var item in gameManager.UpgradeItems)
        {
            item.gameObject.SetActive(false);
        }
        upgradePanel.Hide();
    }

    public void OnClickShopHide()
    {
        foreach (var item in gameManager.UpgradeItems)
        {
            item.gameObject.SetActive(false);
        }
        shopPanel.Hide();
    }

    public void OnClickMilestonesShow()
    {
        foreach (var item in gameManager.MilestoneItems)
        {
            item.gameObject.SetActive(true);
            var currentCount = -1;
            var business = gameManager.BusinessItems.FirstOrDefault(t => t.business.Id == item.milestone.BusinessId);
            if (business != null)
            {
                currentCount = business.business.PurchasedCount;
            }
            var nextMilestone = gameManager.MilestoneGalleryItems.OrderBy(t => t.milestone.Count).FirstOrDefault(t => t.milestone.BusinessId == item.milestone.BusinessId && t.milestone.Unlocked == false);
            if (nextMilestone != null)
            {
                if (currentCount != -1)
                {
                    item.Count.text = currentCount + "/" + nextMilestone.milestone.Count.ToString();
                }
                else
                {
                    item.Count.text = nextMilestone.milestone.Count.ToString();
                }
                item.DescriptionText.text = nextMilestone.DescriptionText.text;
            }
            else
            {
                item.Count.text = "All done!";
            }
        }

        milestoneContainer.anchoredPosition = Vector3.zero;
        milestoneCountText.text = string.Format("{0}/{1}", gameManager.MilestoneGalleryItems.Count(t => t.milestone.Unlocked), gameManager.MilestoneGalleryItems.Count());
        milestonesPanel.Show();
    }

    public void OnClickMilestonesHide()
    {
        milestonesPanel.Hide();
        foreach (var item in gameManager.MilestoneItems)
        {
            item.gameObject.SetActive(false);
        }
    }

    public void OnClickMilestonesGalleryShow(int id)
    {
        foreach (var item in gameManager.MilestoneGalleryItems)
        {
            var itemTransform = item.transform;
            itemTransform.gameObject.SetActive(false);
            item.icon.gameObject.SetActive(false);
            if (item.milestone.Unlocked == true)
            {
                item.icon.gameObject.SetActive(true);
            }
            if (item.milestone.BusinessId == id)
            {
                itemTransform.gameObject.SetActive(true);
            }
        }

        milestoneGalleryContainer.anchoredPosition = Vector3.zero;

        milestonesGalleryPanel.Show();
    }

    public void OnClickMilestonesGalleryHide()
    {
        milestonesGalleryPanel.Hide();
        foreach (var item in gameManager.MilestoneGalleryItems)
        {
            item.gameObject.SetActive(false);
        }
    }

    public void OnClickWelcomeBackHide()
    {
        welcomeBackPanel.Hide();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        StartCoroutine(ShowLoadingScreen(2));
    }

    public void ShowLoadingOverlay(float seconds)
    {
        StartCoroutine(ShowLoadingScreen(seconds));
    }

    private IEnumerator HideModals()
    {
        yield return null;
        investorsPanel.Hide();
        managerPanel.Hide();
        upgradePanel.Hide();
        shopPanel.Hide();
        milestonesPanel.Hide();
        milestonesGalleryPanel.Hide();
        wheelOfFortunePanel.Hide();
        settingsPanel.Hide();
        yield break;
    }

    void Start()
    {
        gameManager = GameManager.instance;

        gameManager.LevelData.OnGameReset -= HandleOnReset;
        gameManager.LevelData.OnGameReset += HandleOnReset;
        gameManager.OfflineEarningsCalculated -= OnOfflineEarningsCalculated;
        gameManager.OfflineEarningsCalculated += OnOfflineEarningsCalculated;
        gameManager.LevelData.OnMilestoneAchieve -= OnMilestoneAchieved;
        gameManager.LevelData.OnMilestoneAchieve += OnMilestoneAchieved;
        gameManager.LevelData.OnGoldPurchase -= OnGoldPurchased;
        gameManager.LevelData.OnGoldPurchase += OnGoldPurchased;

        Initialize();
    }

    private void HandleOnReset()
    {
        foreach (var item in gameManager.BusinessItems)
        {
            item.Reset();
        }
    }

    private void OnOfflineEarningsCalculated(double elapsed, double cashEarned)
    {
        if (elapsed > 180 && cashEarned > 0)
        {
            offlineCash = cashEarned;
            var welcomeBack = welcomeBackPanel.GetComponent<WelcomeBackUI>();
            welcomeBack.SetUp(elapsed, cashEarned);
            welcomeBackPanel.Show();
        }

        if (elapsed > 50)
        {
            gameManager.LevelData.CheckIfLevelIsCompleted();
        }
    }

    void Update()
    {
        if (gameManager != null)
        {
            var unformatted = (gameManager.LevelData.Balance < 0.0) ? 0.0 : gameManager.LevelData.Balance;
            var text = NumberUtility.Convert(unformatted, 1000000000.0, true);
            var array = text.Split(new char[] { ' ' }, StringSplitOptions.None);

            balanceText.text = "$ " + array[0];
            if (array.Length > 1)
            {
                balanceScaleText.text = array[1].ToUpper();
            }
            else
            {
                balanceScaleText.text = string.Empty;
            }

            goldBalanceText.text = gameManager.GameState.Gold.ToString();

            investorText.text = NumberUtility.Convert(gameManager.LevelData.CalculateInvestors(), 1000000.0) + " Investors";

            UpdateButtonNotifications();
        }
    }

    private void UpdateButtonNotifications()
    {
        var managers = gameManager.ManagerItems.Count(t => t.manager.Unlocked == false && (t.manager.CurrencyId == 0 && t.manager.Cost <= gameManager.LevelData.Balance));
        if (managers >= 1)
        {
            managerNotifyImage.gameObject.SetActive(true);
        }
        else
        {
            managerNotifyImage.gameObject.SetActive(false);
        }

        var upgrades = gameManager.UpgradeItems.Count(t => t.upgrade.Unlocked == false && (t.upgrade.CurrencyId == 0 && t.upgrade.Cost <= gameManager.LevelData.Balance || t.upgrade.CurrencyId == 1 && (Math.Ceiling(t.upgrade.Cost / gameManager.LevelData.Investors * 100)) < 5.0));
        if (upgrades >= 1)
        {
            upgradeNotifyImage.gameObject.SetActive(true);
        }
        else
        {
            upgradeNotifyImage.gameObject.SetActive(false);
        }

        var calculatedInvestors = gameManager.LevelData.CalculateInvestors();
        var investors = (calculatedInvestors >= 50 && calculatedInvestors > (gameManager.LevelData.Investors * 3));
        if (investors)
        {
            investorsNotifyImage.gameObject.SetActive(true);
        }
        else
        {
            investorsNotifyImage.gameObject.SetActive(false);
        }
    }

    private void Initialize()
    {
        SetupBusinesses();
        StartCoroutine(SetupManagers());
        StartCoroutine(SetupUpgrades());
        StartCoroutine(SetupProducts());
        StartCoroutine(SetupUnlocks());
        StartCoroutine(HideModals());
    }

    private void SetupBusinesses()
    {
        foreach (var item in gameManager.LevelData.Businesses)
        {
            var business = item;
            var businessObject = Instantiate(businessPrefab);

            businessObject.transform.SetParent(businessContainer);

            var icon = gameManager.FindBusinessSpriteSheetIcon("b" + business.Id);

            var businessItem = businessObject.GetComponent<BusinessItem>();

            gameManager.BusinessItems.Add(businessItem);
            businessItem.Initialize(business, gameManager.LevelData, icon);
        }
    }

    private IEnumerator SetupManagers()
    {
        yield return null;
        var managers = gameManager.LevelData.Managers.OrderBy(t => t.Cost).ThenBy(t => t.BusinessId);

        foreach (var managerItem in managers)
        {
            var managerObject = Instantiate(managerPrefab);
            managerObject.name = managerItem.Id.ToString("D4");

            switch (managerItem.CurrencyId)
            {
                case 0:
                    managerObject.transform.SetParent(cashManagerContainer);
                    break;
            }

            managerObject.transform.localScale = Vector3.one;
            var manager = managerObject.GetComponent<ManagerItem>();

            gameManager.ManagerItems.Add(manager);
            manager.Initialize(managerItem, gameManager.LevelData);

            manager.gameObject.SetActive(false);
        }
        yield break;
    }

    private IEnumerator ShowLoadingScreen(float secondsToWait)
    {
        loadingPanel.Show();
        yield return new WaitForSeconds(secondsToWait);
        loadingPanel.Hide();
        yield break;
    }

    private IEnumerator SetupUpgrades()
    {
        yield return null;
        var upgrades = gameManager.LevelData.Upgrades.OrderByDescending(t => t.CurrencyId).ThenBy(t => t.Cost).ThenBy(t => t.BusinessId);
        foreach (var upgradeItem in upgrades)
        {
            var upgradeObject = Instantiate(upgradePrefab);
            upgradeObject.name = upgradeItem.Id.ToString("D4");

            switch (upgradeItem.CurrencyId)
            {
                case 0:
                    upgradeObject.transform.SetParent(cashUpgradeContainer);
                    break;
                case 1:
                    upgradeObject.transform.SetParent(investorUpgradeContainer);
                    break;
                case 3:
                    upgradeObject.transform.SetParent(goldUpgradeContainer);
                    break;
            }

            upgradeObject.transform.localScale = Vector3.one;
            var upgrade = upgradeObject.GetComponent<UpgradeItem>();
            var icon = gameManager.FindBusinessSpriteSheetIcon("b" + upgradeItem.BusinessId);

            gameManager.UpgradeItems.Add(upgrade);
            upgrade.Initialize(upgradeItem, gameManager.LevelData, icon);

            upgrade.gameObject.SetActive(false);
        }

        yield break;
    }

    private IEnumerator SetupProducts()
    {
        yield return null;
        var products = gameManager.LevelData.Products.OrderByDescending(t => t.CurrencyId).ThenBy(t => t.Cost).ThenBy(t => t.BusinessId).ToList();
        products.AddRange(PurchaseManager.instance.Products.OrderBy(t => t.Cost));

        foreach (var productItem in products)
        {
            var productObject = Instantiate(productPrefab);
            productObject.name = productItem.Id.ToString("D4");
            Sprite icon;

            switch (productItem.CurrencyId)
            {
                case 2:
                case 3:
                    productObject.transform.SetParent(premiumProductContainer);
                    break;
                case 10:
                    productObject.transform.SetParent(goldProductContainer);
                    break;
            }

            if (productItem.BusinessId == 100)
            {
                icon = gameManager.FindItemSpriteSheetIcon(productItem.EffectType);
            }
            else if (productItem.BusinessId == 1000)
            {
                icon = gameManager.FindItemSpriteSheetIcon(productItem.EffectType);
            }
            else
            {
                icon = gameManager.FindBusinessSpriteSheetIcon("b" + productItem.BusinessId);
            }

            productObject.transform.localScale = Vector3.one;
            var product = productObject.GetComponent<ProductItem>();

            gameManager.ProductItems.Add(product);

            //var item = YandexGame.PurchaseByID(productItem.Id.ToString());
            product.Initialize(productItem, gameManager.LevelData, icon);

            product.gameObject.SetActive(false);
        }

        yield break;
    }

    private IEnumerator SetupUnlocks()
    {
        yield return null;

        var businessIds = gameManager.LevelData.Businesses.OrderBy(t => t.Id).Select(t => t.Id).ToList();
        var milestones = gameManager.LevelData.Milestones;

        businessIds.Add(0);

        for (var i = 0; i < businessIds.Count; i++)
        {
            var businessId = businessIds[i];
            var firstMilestoneItem = milestones.OrderBy(t => t.Count).FirstOrDefault(t => t.BusinessId == businessId && t.Unlocked == false);
            if (firstMilestoneItem == null)
            {
                firstMilestoneItem = milestones.OrderBy(t => t.Count).Last(t => t.BusinessId == businessId);
            }
            var milestoneObject = Instantiate(milestonePrefab);
            milestoneObject.name = "b" + i.ToString("D4");
            milestoneObject.transform.SetParent(milestoneContainer);
            milestoneObject.transform.localScale = Vector3.one;
            var milestone = milestoneObject.GetComponent<MilestoneItem>();
            var milestoneButton = milestoneObject.GetComponent<Button>();
            milestoneButton.onClick.AddListener(delegate { OnClickMilestonesGalleryShow(businessId); });
            var icon = gameManager.FindBusinessSpriteSheetIcon("b" + businessId);

            gameManager.MilestoneItems.Add(milestone);
            milestone.Initialize(firstMilestoneItem, gameManager.LevelData, false, icon);

            milestone.gameObject.SetActive(false);
        }

        var milestoneList = gameManager.LevelData.Milestones.OrderBy(t => t.Count);
        foreach (var ms in milestoneList)
        {
            var milestoneObject = Instantiate(milestoneItemPrefab);
            milestoneObject.name = "milestoneGallery" + ms.Id.ToString("D4");
            milestoneObject.transform.SetParent(milestoneGalleryContainer);
            milestoneObject.transform.localScale = Vector3.one;
            var milestone = milestoneObject.GetComponent<MilestoneItem>();

            gameManager.MilestoneGalleryItems.Add(milestone);
            milestone.Initialize(ms, gameManager.LevelData, true);

            milestone.gameObject.SetActive(false);
        }
        yield break;
    }

    private void OnMilestoneAchieved(Milestone milestone)
    {
        if (milestone != null)
        {
            switch (milestone.EffectType)
            {
                case "Profit":
                case "Speed":
                case "Cost":
                case "Buy":
                    break;
                case "Luck":
                    SpinWheelShow();
                    break;
                case "Gold":
                    RewardUI.instance.Show(Reward.RewardGold((int)milestone.Effect));
                    break;
                case "iEffect":
                    gameManager.LevelData.InvestorEffect += milestone.Effect;
                    break;
                default:
                    return;
            }

            var businessName = gameManager.LevelData.GetBusinessNameById(milestone.BusinessId) + " - Level " + milestone.Count;
            var businessNamePlural = gameManager.LevelData.GetBusinessNameByIdInPlural(milestone.TargetId);

            var bonusText = EffectTypeDescription.GetDescription(milestone.EffectType, milestone.Effect, businessName, businessNamePlural);

            ToastUI.instance.FlashToast(businessName, bonusText, 6f);
        }
    }

    public void InAppPurchased(StoreProduct product)
    {
        OnGoldPurchased(product);
    }

    private void OnGoldPurchased(StoreProduct product)
    {
        if (product != null)
        {
            switch (product.EffectType)
            {
                case "TimeJump":
                    var timeJump = Reward.RewardTimeJump((int)product.Effect);
                    timeJump.Title = "Покупка совершена";
                    timeJump.LongDescription = timeJump.Description;
                    RewardUI.instance.Show(timeJump);
                    break;
                case "Gold":
                    var gold = Reward.RewardGold((int)product.Effect);
                    gold.Title = "Покупка совершена";
                    gold.LongDescription = gold.Description;
                    RewardUI.instance.Show(gold);
                    break;
                default:
                    return;
            }
        }
    }
}
