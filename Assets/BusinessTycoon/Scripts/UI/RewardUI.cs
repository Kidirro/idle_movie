using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Game;

public class RewardUI : MonoBehaviour
{
    public static RewardUI instance;

    [HideInInspector]
    private RectTransform rectTransform;
    [SerializeField]
    private Text titleText;
    [SerializeField]
    private Text bodyText;
    [SerializeField]
    private Text moreText;
    [SerializeField]
    private Image rewardImage;

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

    public void Show(Reward reward, float timeToShow = 3.5f)
    {
        titleText.text = reward.Title;
        bodyText.text = string.Format(reward.LongDescription, reward.Count);

        switch (reward.Type)
        {
            case "Золото":
                GameManager.instance.GameState.Gold += reward.Count;
                moreText.text = ""; //"+" + reward.ShortDescription;
                break;
            case "Пропуск времени":
                var totalAmount = GameManager.instance.TimeJumpHours(reward.Count);
                moreText.text = "+ $" + NumberUtility.Convert(totalAmount);
                break;
            default:
                moreText.text = "";
                break;
        }

        rewardImage.sprite = GameManager.instance.FindItemSpriteSheetIcon(reward.Type);

        rectTransform.Show();
        StartCoroutine(ShowReward(timeToShow));
    }

    IEnumerator ShowReward(float time)
    {
        var timer = 0.0f;
        while (timer < time)
        {
            timer += Time.deltaTime;
            yield return 0;
        }

        rectTransform.Hide();
    }

    // Update is called once per frame
    void Update()
    {

    }
}