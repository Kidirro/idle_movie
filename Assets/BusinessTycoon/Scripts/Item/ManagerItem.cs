using System;
using UnityEngine;
using UnityEngine.UI;

public class ManagerItem : MonoBehaviour
{
    [HideInInspector]
    public Manager manager;
    public Image icon;
    public Button buyButton;
    public Text buyButtonText;
    public Text CostText;
    public Text NameText;
    public Text DescriptionText;

    private LevelData level;
    // Use this for initialization
    void Start()
    {

    }

    public void UpdateCostText()
    {
        if (manager.CurrencyId == 0) // Cash
        {
            CostText.text = NumberUtility.Convert(manager.Cost, 1000000000.0, false);
        }
    }

    public void Initialize(Manager managerData, LevelData levelData)
    {
        transform.localPosition = Vector3.zero;
        level = levelData;
        name = "Manager_" + managerData.Id.ToString();
        icon.sprite = GameManager.instance.FindManagerSheetIcon("Manager_" + managerData.Id);
        icon.preserveAspect = true;
        SetPurchaseButtonState(false);
        manager = managerData;
        NameText.text = manager.Name;
        DescriptionText.text = EffectTypeDescription.GetDescription(managerData.EffectType, managerData.Effect, levelData.GetBusinessNameById(managerData.BusinessId), levelData.GetBusinessNameByIdInPlural(managerData.BusinessId));

        UpdateCostText();

        if (manager.Unlocked)
        {
            DestroyItem();
            return;
        }

        level.OnManagerPurchase -= OnManagerPurchase;
        level.OnManagerPurchase += OnManagerPurchase;
    }

    private void SetPurchaseButtonState(bool enable)
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

    private void UpdatePurchasableState()
    {
        bool purchasableState;
        switch (manager.CurrencyId)
        {
            case 0:
                purchasableState = (level.Balance >= manager.Cost);
                break;
            case 1:
                purchasableState = (level.Investors >= manager.Cost);
                break;
            default:
                purchasableState = false;
                break;
        }
        SetPurchaseButtonState(purchasableState);
    }

    public void HireManager()
    {
        if (manager.Unlocked)
        {
            return;
        }
        level.UnlockManager(manager);
        transform.gameObject.SetActive(false);
    }

    private void OnManagerPurchase(Manager manager)
    {
        if (manager == this.manager && manager.Unlocked)
        {

        Io.AppMetrica.AppMetrica.ReportEvent($"Buy manager {manager.Id}");
            SetPurchaseButtonState(false);
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
        if (manager.Unlocked)
        {
            DestroyItem();
        }
    }
}