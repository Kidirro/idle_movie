using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Game;

public class SpinWheel : MonoBehaviour
{
    [SerializeField]
    private Text logText;
    [SerializeField]
    private Button startSpinButton;
    [SerializeField]
    private RectTransform spinWheelPanel;
    [SerializeField]
    private AnimationCurve animationCurve;

    [SerializeField]
    private Image[] images;
    [SerializeField]
    private Text[] texts;

    private int time;
    private List<Reward> rewards;

    private bool spinning;
    private float anglePerItem;
    private int randomTime;
    private int itemNumber;

    void OnEnable()
    {
        if (GameManager.instance != null)
        {
            spinning = false;
            startSpinButton.gameObject.SetActive(true);
            transform.eulerAngles = Vector3.zero;
            rewards = new List<Reward>();
            for (var i = 0; i < 8; i++)
            {
                rewards.Add(Reward.GetRandomReward(true));
                images[i].sprite = GameManager.instance.FindItemSpriteSheetIcon(rewards[i].Type);
                texts[i].text = string.Format(rewards[i].ShortDescription, rewards[i].Count);
            }
        }
    }

    void Awake()
    {
        anglePerItem = 45; // (360/8); // 8 items
    }

    void Start()
    {
        var rectTransform = GetComponent<RectTransform>();
    }

    public void StartSpin()
    {
        startSpinButton.gameObject.SetActive(false);
        if (!spinning)
        {
            randomTime = Random.Range(6, 10);

            if (time != 0)
            {
                randomTime = time;
            }

            itemNumber = Random.Range(0, rewards.Count);
            var maxAngle = 360 * randomTime - (itemNumber * anglePerItem);

            StartCoroutine(SpinTheWheel(randomTime, maxAngle));
        }
    }

    IEnumerator SpinTheWheel(float time, float maxAngle)
    {
        spinning = true;

        var timer = 0.0f;
        var startAngle = transform.eulerAngles.z;
        startAngle = 360 - startAngle;
        maxAngle -= startAngle;

        logText.text = "Prize: " + rewards[itemNumber].Title + "\n" + "Time: " + time;

        while (timer < time)
        {
            //to calculate rotation
            var angle = maxAngle * animationCurve.Evaluate(timer / time);
            transform.eulerAngles = new Vector3(0.0f, 0.0f, -(angle + startAngle));
            timer += Time.deltaTime;
            yield return 0;
        }

        transform.eulerAngles = new Vector3(0.0f, 0.0f, -(maxAngle + startAngle));

        // Wait 2 sec
        timer = 0.0f;
        while (timer < 2)
        {
            timer += Time.deltaTime;
            yield return 0;
        }

        spinWheelPanel.Hide();
        rewards[itemNumber].Title = "Spin & win";
        RewardUI.instance.Show(rewards[itemNumber]);

        spinning = false;
    }
}