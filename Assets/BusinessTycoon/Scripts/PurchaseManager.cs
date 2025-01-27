using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using System.Linq;
using RuStore.BillingClient;
using UnityEngine.Purchasing.Extension;
using Product = UnityEngine.Purchasing.Product;

public class PurchaseManager : MonoBehaviour, IDetailedStoreListener
{
    public static PurchaseManager instance = null;

    public List<StoreProduct> Products;

    private static IStoreController m_StoreController;

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
    }

    void Start()
    {
#if !UNITY_WEBGL // Disable shop in WebGL version
        if (m_StoreController == null)
        {
            InitializePurchasing();
        }
#elif YG_PLUGIN_YANDEX_GAME
        YandexGame.PurchaseSuccessEvent += PurchaseYandexSuccessEvent;
#endif
        
    }

    private void OnDestroy()
    {
#if YG_PLUGIN_YANDEX_GAME
        //YandexGame.PurchaseSuccessEvent -= PurchaseYandexSuccessEvent;
#endif
    }

    public void InitializePurchasing()
    {
        if (IsInitialized())
        {
            return;
        }

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        foreach (var product in Products)
        {
            builder.AddProduct(product.SKU, ProductType.Consumable);
        }

        UnityPurchasing.Initialize(this, builder);
    }


    private bool IsInitialized()
    {
        return m_StoreController != null;
    }

    public void BuyProductIOSID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                //Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            // Otherwise ...
            else
            {
                //Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
                //MessageBoxUI.instance.Show("Purchase", "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase", null, MessageBoxUI.ButtonOptions.OK, "OK");
            }
        }
        // Otherwise ...
        else
        {
            //Debug.Log("BuyProductID FAIL. Not initialized.");
            //MessageBoxUI.instance.Show("FAIL", "BuyProductID FAIL. Not initialized.", null, MessageBoxUI.ButtonOptions.OK, "OK");
        }
    }
    
    
    public void BuyProductAndroidID(StoreProduct product)
    {
        if (RuStoreBillingClient.Instance.IsInitialized == false)
            RuStoreBillingClient.Instance.Init();
                
        RuStoreBillingClient.Instance.PurchaseProduct(product.Android_Id, 1, "Purchase",
            _ => {},
            _  =>
            {
                PurchaseYandexSuccessEvent(product.YAN_Id);
            });
    }
   
    public void BuyProductYandexID(string productId)
    {
        //YandexGame.BuyPayments(productId);
    }

    //  
    // --- IStoreListener
    //

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");
        m_StoreController = controller;
    }


    public void OnInitializeFailed(InitializationFailureReason error)
    {
        // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
        //MessageBoxUI.instance.Show("Init failure", error.ToString(), null, MessageBoxUI.ButtonOptions.OK, "OK");
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public void OnInitializeFailed(InitializationFailureReason error, string? message)
    {
        // Purchasing set-up has not succeeded. Check error for reason. Consider sharing this reason with the user.
        //MessageBoxUI.instance.Show("Init failure", error.ToString(), null, MessageBoxUI.ButtonOptions.OK, "OK");
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + message);
    }


    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        var item = GameManager.instance.ProductItems.FirstOrDefault(t => t.product.SKU == args.purchasedProduct.definition.id);

        if (item != null && String.Equals(args.purchasedProduct.definition.id, item.product.SKU, StringComparison.Ordinal))
        {
            //Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            MainUIController.instance.InAppPurchased(item.product);
        }
        // Or ... an unknown product has been purchased by this user. Fill in additional products here....
        else
        {
            //MessageBoxUI.instance.Show("Init failure", "ProcessPurchase: FAIL. Unrecognized product: '{0}'", null, MessageBoxUI.ButtonOptions.OK, "OK");
            //Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        }

        // Return a flag indicating whether this product has completely been received, or if the application needs 
        // to be reminded of this purchase at next app launch. Use PurchaseProcessingResult.Pending when still 
        // saving purchased products to the cloud, and when that save is delayed. 
        return PurchaseProcessingResult.Complete;
    }


    private void PurchaseYandexSuccessEvent(string id)
    {
        var item = GameManager.instance.ProductItems.FirstOrDefault(t => t.product.YAN_Id == id);

        if (item != null && String.Equals(id, item.product.YAN_Id, StringComparison.Ordinal))
        {
            //Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", args.purchasedProduct.definition.id));

            MainUIController.instance.InAppPurchased(item.product);
        }
    }
    

    public void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription)
    {
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
    }
}