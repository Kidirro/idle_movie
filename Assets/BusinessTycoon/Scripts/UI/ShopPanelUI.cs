using UnityEngine;
using UnityEngine.UI;

public class ShopPanelUI : MonoBehaviour
{
    [SerializeField]
    private GameObject boostPanel;
    [SerializeField]
    private GameObject goldPanel;

    [SerializeField]
    private Image goldButtonImage;
    [SerializeField]
    private Image boostButtonImage;

    void OnEnable()
    {
        if (GameManager.instance != null)
        {
            OnClickGoldButton();
        }
    }

    // Click events
    public void OnClickPremiumButton()
    {
        goldButtonImage.color = GameManager.instance.InactiveTabColor;
        goldPanel.SetActive(false);

        boostButtonImage.color = GameManager.instance.ActiveTabColor;
        boostPanel.SetActive(true);
    }

    public void OnClickGoldButton()
    {
        boostButtonImage.color = GameManager.instance.InactiveTabColor;
        boostPanel.SetActive(false);

        goldButtonImage.color = GameManager.instance.ActiveTabColor;
        goldPanel.SetActive(true);
    }
}
