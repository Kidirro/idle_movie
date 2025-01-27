using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StatisticsUI : MonoBehaviour
{
    public static StatisticsUI instance;

    [HideInInspector]
    private RectTransform rectTransform;

    public GameObject totalResetsObject;
    public GameObject totalInvestorsClaimedObject;
    public GameObject totalInvestorsUsedObject;

    public Text cashOnHand;
    public Text sessionEarnings;
    public Text totalEarnings;
    public Text totalResets;
    public Text totalInvestorsClaimed;
    public Text totalInvestorsUsed;

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
    }

    // Use this for initialization
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.Hide();
    }

    public void Show()
    {

        if (GameManager.instance.LevelData.TotalResets <= 0.0)
        {
            totalResetsObject.SetActive(false);
        }
        else
        {
            totalResets.text = GameManager.instance.LevelData.TotalResets.ToString();
        }

        var amount = GameManager.instance.LevelData.Investors + GameManager.instance.LevelData.InvestorsSpent;
        if (amount <= 0.0)
        {
            totalInvestorsClaimedObject.SetActive(false);
        }
        else
        {
            totalInvestorsClaimed.text = NumberUtility.Convert(amount, 1000000.0, true) + " investors";
        }

        amount = GameManager.instance.LevelData.InvestorsSpent;
        if (amount <= 0.0)
        {
            totalInvestorsUsedObject.SetActive(false);
        }
        else
        {
            totalInvestorsUsed.text = NumberUtility.Convert(amount, 1000000.0, true) + " investors";
        }

        instance.rectTransform.Show();
    }

    public void Hide()
    {
        instance.rectTransform.Hide();
    }

    // Update is called once per frame
    void Update()
    {
        var amount = (GameManager.instance.LevelData.Balance < 0.0) ? 0.0 : GameManager.instance.LevelData.Balance;
        cashOnHand.text = NumberUtility.Convert(amount, 1000000000.0, true);

        amount = (GameManager.instance.LevelData.TotalBalance < 0.0) ? 0.0 : GameManager.instance.LevelData.TotalBalance;
        sessionEarnings.text = NumberUtility.Convert(amount, 1000000000.0, true);

        amount = GameManager.instance.LevelData.OverallTotalCash + GameManager.instance.LevelData.TotalBalance;
        totalEarnings.text = NumberUtility.Convert(amount, 1000000000.0, true);
    }
}