using System;
using UnityEngine;
using UnityEngine.UI;

public class ProductItem : MonoBehaviour
{
    [HideInInspector]
    public StoreProduct product;
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

    public void Initialize(StoreProduct productData, LevelData levelData, Sprite sprite = null)
    {
        transform.localPosition = Vector3.zero;
        level = levelData;
        name = "Product_" + productData.Id.ToString();
        icon.sprite = sprite;
        icon.preserveAspect = true;
        SetPurchasableState(false);
        product = productData;
        NameText.text = product.Name;
        DescriptionText.text = EffectTypeDescription.GetDescription(productData.EffectType, productData.Effect, levelData.GetBusinessNameById(productData.BusinessId), levelData.GetBusinessNameByIdInPlural(productData.BusinessId));

        if (product.CurrencyId == 3) // Gold
        {
            CostText.text = NumberUtility.Convert(product.Cost, 10000.0, false, 0) + " Золота";
            DescriptionText.text = "Купить " + DescriptionText.text;
        }
        else if (product.CurrencyId == 10) // Real money
        {
#if UNITY_IOS
        CostText.text = "$" + product.Cost;
#elif UNITY_ANDROID
            CostText.text = product.Android_Cosat.ToString();
#elif YG_PLUGIN_YANDEX_GAME
        CostText.text = product.YAN_Cost + " Yan";
#endif
            DescriptionText.text = "Купить " + DescriptionText.text;
        }

        if (product.Unlocked)
        {
            DestroyItem();
            return;
        }

        level.OnProductPurchase -= OnProductPurchase;
        level.OnProductPurchase += OnProductPurchase;
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
        switch (product.CurrencyId)
        {
            case 3:
                purchasableState = (GameManager.instance.GameState.Gold >= product.Cost);
                break;
            case 10:
                purchasableState = true;
                break;
            default:
                purchasableState = false;
                break;
        }
        SetPurchasableState(purchasableState);
    }

    public void UnlockProduct()
    {
        if (product.Unlocked)
        {
            return;
        }
        level.UnlockProduct(product);
        if (product.CurrencyId != 3 && product.CurrencyId != 10)
        {
            transform.gameObject.SetActive(false);
        }
    }

    private void OnProductPurchase(StoreProduct product)
    {
        if (product == this.product && product.Unlocked)
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
        if (product.Unlocked)
        {
            DestroyItem();
        }
    }
}
