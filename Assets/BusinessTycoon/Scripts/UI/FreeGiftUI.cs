using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Game;

public class FreeGiftUI : MonoBehaviour
{
    public static FreeGiftUI instance;

    [SerializeField]
    private Image giftImage;

    [SerializeField]
    private Text body;

    private RectTransform rectTransform;

    private Reward currentReward;

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

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.Hide();
    }

    public void Show()
    {
        if (instance != null)
        {
            var reward = GameManager.instance.GameState.FreeGift;
            reward.Title = "Бесплатный подарок";

            currentReward = reward;
            giftImage.sprite = GameManager.instance.FindItemSpriteSheetIcon(reward.Type);
            instance.body.text = string.Format(reward.Description, reward.Count) + "\n\nПосмотри рекламу и получи\n<b>" + string.Format(reward.Description, reward.Count * 2) + "</b>";
            rectTransform.Show();
        }
    }

    public void OnClaimClicked()
    {
        GameManager.instance.LevelData.LastFreeGift = DateTime.Now.AddHours(4).ToOADate();
        GameManager.instance.GameState.FreeGift = Reward.GetRandomReward(false);
        RewardUI.instance.Show(currentReward);
        OnCloseClick();
    }

    public void DoubleReward()
    {
        currentReward.Count *= 2;
        GameManager.instance.LevelData.LastFreeGift = DateTime.Now.AddHours(4).ToOADate();
        GameManager.instance.GameState.FreeGift = Reward.GetRandomReward(false);
        RewardUI.instance.Show(currentReward);
        OnCloseClick();
    }

    public void OnCloseClick()
    {
        rectTransform.Hide();
    }
}