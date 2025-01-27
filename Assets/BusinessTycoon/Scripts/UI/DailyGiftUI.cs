using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Game;

public class DailyGiftUI : MonoBehaviour
{
    public static DailyGiftUI instance;

    [SerializeField]
    private Image giftImage;

    [SerializeField]
    private Text body;

    private RectTransform rectTransform;

    private Reward[] rewards;

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

        rewards = new Reward[11];
        rewards[0] = Reward.RewardGold(1);
        rewards[1] = Reward.RewardGold(2);
        rewards[2] = Reward.RewardGold(3);
        rewards[3] = Reward.RewardGold(4);
        rewards[4] = Reward.RewardGold(5);
        rewards[5] = Reward.RewardGold(6);
        rewards[6] = Reward.RewardGold(7);
        rewards[7] = Reward.RewardGold(8);
        rewards[8] = Reward.RewardGold(9);
        rewards[9] = Reward.RewardGold(10);
        rewards[10] = Reward.RewardGold(15);
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
            if ((DateTime.FromOADate(GameManager.instance.GameState.DailyGift) - DateTime.Today.AddHours(-24)).TotalSeconds <= 0)
            {
                GameManager.instance.GameState.DailyGiftCount = 0;
            }

            var reward = rewards[GameManager.instance.GameState.DailyGiftCount];
            reward.Title = "Daily gift";

            giftImage.sprite = GameManager.instance.FindItemSpriteSheetIcon(reward.Type);
            instance.body.text = string.Format(reward.Description, reward.Count);
            rectTransform.Show();
        }
    }

    public void OnCollectClicked()
    {
        var reward = rewards[GameManager.instance.GameState.DailyGiftCount];
        reward.Title = "Daily gift";
        GameManager.instance.GameState.DailyGift = DateTime.Today.AddHours(24).ToOADate();
        GameManager.instance.GameState.DailyGiftCount++;
        if (GameManager.instance.GameState.DailyGiftCount >= rewards.Length)
        {
            GameManager.instance.GameState.DailyGiftCount -= 3;
        }
        RewardUI.instance.Show(reward);
        OnCloseClick();
    }

    public void OnCloseClick()
    {
        rectTransform.Hide();
    }
}