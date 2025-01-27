using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusinessUI : MonoBehaviour
{
    [SerializeField]
    private int businessId;
    [SerializeField]
    private GameObject purchasedState;
    [SerializeField]
    private GameObject notPurchaseState;
    [SerializeField]
    private Button buyButton;
    [SerializeField]
    private Text buyLabel;
    [SerializeField]
    private Button businessImageButton;
    public Image progressBarImage;
    public Image progressBarMaxImage;
    public Image milestoneProgressBar;
    [SerializeField]
    private Text profitLabel;
    [SerializeField]
    private Text profitTextLabel;
    [SerializeField]
    private Text costLabel;
    [SerializeField]
    private Text costTextLabel;
    [SerializeField]
    private Text quantityLabel;
    [SerializeField]
    private Text timeRemainingLabel;
    [SerializeField]
    private Text costPerLabel;
    [SerializeField]
    private Text businessName;
    [SerializeField]
    private Image businessIcon;
    [SerializeField]
    private Image LockedbusinessIcon;
    private Sprite enabledSprite;
    private bool cashPerSec;

    // Use this for initialization
    void Start()
    {
        SetupProgressColor();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize(int id, Sprite sprite, string nameOfBusiness, string costPer, bool purchased)
    {
        businessId = id;
        transform.localScale = Vector3.one;
        enabledSprite = sprite;
        businessIcon.sprite = enabledSprite;
        LockedbusinessIcon.sprite = enabledSprite;
        businessIcon.preserveAspect = true;
        businessName.text = nameOfBusiness;
        costPerLabel.text = costPer;
        progressBarImage.fillAmount = 0f;
        progressBarMaxImage.gameObject.SetActive(false);
        SetPurchaseState(purchased);
        UpdateLabels(0, "0", "0", 1);
        UpdateTimeRemaining("00:00:00");
        UpdateProgressBar(0f);
    }

    public void SetupProgressColor()
    {
        progressBarImage.color = GameManager.instance.ProgressbarColor;
        progressBarMaxImage.color = GameManager.instance.ProgressbarMaxedColor;
    }

    public void SetPurchaseState(bool purchased)
    {
        purchasedState.SetActive(purchased);
        notPurchaseState.SetActive(!purchased);
    }

    public void ShowCashPerSec(bool show)
    {
        cashPerSec = show;
    }

    public void UpdateLabels(int quantity, string profit, string cost, int canAfford)
    {
        quantityLabel.text = quantity.ToString();
        var array = profit.Split(new char[] { ' ' }, StringSplitOptions.None);
        if (cashPerSec != true)
        {
            profitLabel.text = array[0];
            if (array.Length > 1)
            {
                profitTextLabel.text = array[1].ToUpper();
            }
            else
            {
                profitTextLabel.text = string.Empty;
            }
        }

        var array2 = cost.Split(new char[] { ' ' }, StringSplitOptions.None);
        costLabel.text = array2[0];
        costPerLabel.text = array2[0];
        if (array2.Length > 1)
        {
            costTextLabel.text = array2[1].ToUpper();
            costPerLabel.text = array2[0] + " " + array2[1].ToLower();
        }
        else
        {
            costTextLabel.text = string.Empty;
        }

        if (GameManager.instance.LevelData.BuyCount == -1)
        {
            buyLabel.text = "Купить x" + canAfford;
        }
        else
        {
            buyLabel.text = "Купить x" + GameManager.instance.LevelData.BuyCount;
        }
        UpdateMilestoneProgress(quantity);
    }

    private void UpdateMilestoneProgress(int count)
    {
        if (milestoneProgressBar == null)
        {
            return;
        }

        var list = GameManager.instance.LevelData.Milestones.FindAll(t => t.BusinessId == businessId);
        Milestone milestone = null;
        Milestone milestone2 = null;
        foreach (var item in list)
        {
            if (count >= item.Count)
            {
                milestone = item;
            }
            else
            {
                milestone2 = item;
                break;
            }
        }

        if (milestone2 != null)
        {
            var num2 = (milestone == null) ? 0 : milestone.Count;
            var num3 = milestone2.Count;
            var num4 = count - num2;
            num3 -= num2;
            var fillAmount = (float)num4 / (float)num3;
            milestoneProgressBar.fillAmount = fillAmount;
            milestoneProgressBar.color = GameManager.instance.BusinessMilestoneColor;
        }
        else
        {
            milestoneProgressBar.color = GameManager.instance.BusinessMilestoneMaxedColor;
            milestoneProgressBar.fillAmount = 1f;
        }
    }

    public void UpdateTimeRemaining(string time)
    {
        timeRemainingLabel.text = time;
    }

    public void UpdateProgressBar(float progress)
    {
        progressBarImage.fillAmount = Mathf.Clamp01(progress);
    }

    public void RunBusinessEnable(bool enable)
    {
    }

    public void PurchaseInitialBusinessEnabled(bool enable)
    {
        notPurchaseState.GetComponent<Button>().interactable = enable;
        if (enable == true)
        {
            notPurchaseState.GetComponent<Image>().color = GameManager.instance.BusinessActiveButtonColor;
        }
        else
        {
            notPurchaseState.GetComponent<Image>().color = GameManager.instance.BusinessInactiveButtonColor;
        }
    }

    public void PurchaseBusinessEnable(bool enable)
    {
        buyButton.interactable = enable;
        if (enable == true)
        {
            buyButton.GetComponent<Image>().color = GameManager.instance.BusinessActiveButtonColor;
        }
        else
        {
            buyButton.GetComponent<Image>().color = GameManager.instance.BusinessInactiveButtonColor;
        }
    }

    public void UpdateCashPerSec(string cashPerSec)
    {
        var array = cashPerSec.Split(new char[] { ' ' }, StringSplitOptions.None);
        profitLabel.text = array[0] + " / sec";
        if (array.Length > 1)
        {
            profitTextLabel.text = array[1].ToUpper();
        }
    }
}