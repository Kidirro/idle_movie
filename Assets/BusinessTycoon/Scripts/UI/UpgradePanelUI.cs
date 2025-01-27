using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelUI : MonoBehaviour
{
    [SerializeField]
    private GameObject cashUpgradePanel;
    [SerializeField]
    private GameObject investorUpgradePanel;
    [SerializeField]
    private GameObject goldUpgradePanel;

    [SerializeField]
    private GameObject investorTab;

    [SerializeField]
    private Image cashButtonImage;
    [SerializeField]
    private Image investorButtonImage;
    [SerializeField]
    private Image goldButtonImage;

    void OnEnable()
    {
        if (GameManager.instance != null)
        {
            OnClickCashButton();
        }
    }

    // Click events

    public void OnClickCashButton()
    {
        investorButtonImage.color = GameManager.instance.InactiveTabColor;
        investorUpgradePanel.SetActive(false);

        goldButtonImage.color = GameManager.instance.InactiveTabColor;
        goldUpgradePanel.SetActive(false);

        cashButtonImage.color = GameManager.instance.ActiveTabColor;
        cashUpgradePanel.SetActive(true);
    }

    public void OnClickInvestorButton()
    {
        cashButtonImage.color = GameManager.instance.InactiveTabColor;
        cashUpgradePanel.SetActive(false);

        goldButtonImage.color = GameManager.instance.InactiveTabColor;
        goldUpgradePanel.SetActive(false);

        investorButtonImage.color = GameManager.instance.ActiveTabColor;
        investorUpgradePanel.SetActive(true);
    }

    public void OnClickGoldButton()
    {
        cashButtonImage.color = GameManager.instance.InactiveTabColor;
        cashUpgradePanel.SetActive(false);

        investorButtonImage.color = GameManager.instance.InactiveTabColor;
        investorUpgradePanel.SetActive(false);

        goldButtonImage.color = GameManager.instance.ActiveTabColor;
        goldUpgradePanel.SetActive(true);
    }
}