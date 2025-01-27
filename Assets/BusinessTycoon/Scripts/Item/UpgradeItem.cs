using System;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItem : MonoBehaviour
{
    [HideInInspector]
    public Upgrade upgrade;
    private LevelData level;
    public Image icon;
    public Button buyButton;
    public Text buyButtonText;
    public Text CostText;
    public Text NameText;
    public Text DescriptionText;

    // Use this for initialization
    void Start()
    {

    }

    public void UpdateCostText()
    {
        if (upgrade.CurrencyId == 0) // Cash
        {
            CostText.text = NumberUtility.Convert(upgrade.Cost, 1000000000.0, false);
        }
        else if (upgrade.CurrencyId == 1) // Investor
        {
            CostText.text = NumberUtility.Convert(upgrade.Cost, 1000000.0, false, 0) + " Продюсер" + ((upgrade.Cost <= 1) ? string.Empty : "ов");
        }
        else if (upgrade.CurrencyId == 3) // Gold
        {
            CostText.text = NumberUtility.Convert(upgrade.Cost, 1000000.0, false, 0) + " Золота";
        }
    }

    public void Initialize(Upgrade upgradeData, LevelData levelData, Sprite sprite = null)
    {
        transform.localPosition = Vector3.zero;
        level = levelData;
        name = "Upgrade_" + upgradeData.Id.ToString();
        icon.sprite = sprite;
        icon.preserveAspect = true;
        SetPurchasableState(false);
        upgrade = upgradeData;
        NameText.text = upgrade.Name;
        DescriptionText.text = EffectTypeDescription.GetDescription(upgradeData.EffectType, upgradeData.Effect, levelData.GetBusinessNameById(upgradeData.BusinessId), levelData.GetBusinessNameByIdInPlural(upgradeData.BusinessId));

        UpdateCostText();

        if (upgrade.Unlocked)
        {
            DestroyItem();
            return;
        }

        level.OnUpgradePurchase -= OnUpgradePurchase;
        level.OnUpgradePurchase += OnUpgradePurchase;
    }

    private void SetPurchasableState(bool enable)
    {
        if (buyButton.interactable != enable)
        {
            buyButton.interactable = enable;
            if (enable)
            {
                buyButtonText.color = Color.white;
            }
            else
            {
                buyButtonText.color = GameManager.instance.InactiveButtonTextColor;
            }
        }
    }

    private void UpdatePurchasableState()
    {
        bool purchasableState;
        switch (upgrade.CurrencyId)
        {
            case 0:
                purchasableState = (level.Balance >= upgrade.Cost);
                break;
            case 1:
                purchasableState = (level.Investors >= upgrade.Cost);
                break;
            case 3:
                purchasableState = (GameManager.instance.GameState.Gold >= upgrade.Cost);
                break;
            default:
                purchasableState = false;
                break;
        }
        SetPurchasableState(purchasableState);
    }

    public void UnlockUpgrade()
    {
        if (upgrade.CurrencyId == 1)
        {
            var title = "Хотите потратить {0}% ваших инвесторов?";
            var num = Math.Ceiling(upgrade.Cost / GameManager.instance.LevelData.Investors * 100.0);
            if (num >= 3.0)
            {
                title = string.Format(title, num.ToString("N0"));
                MessageBoxUI.instance.Show("Предупреждение", title, UnlockUpgradeConfirmed, MessageBoxUI.ButtonOptions.OK_Cancel, "Да", "Нет", true);
            }
            else
            {
                UnlockUpgradeConfirmed();
            }
        }
        else
        {
            UnlockUpgradeConfirmed();
        }
    }

    public void UnlockUpgradeConfirmed()
    {
        if (upgrade.Unlocked)
        {
            return;
        }
        level.UnlockUpgrade(upgrade);
        transform.gameObject.SetActive(false);
    }

    private void OnUpgradePurchase(Upgrade upgrade)
    {
        if (upgrade == this.upgrade && upgrade.Unlocked)
        {
            SetPurchasableState(false);
            DestroyItem();
        }
    }

    private void DestroyItem()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePurchasableState();
        if (upgrade.Unlocked)
        {
            DestroyItem();
        }
    }
}
