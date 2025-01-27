using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PrestigeClaimUI : MonoBehaviour
{
    public static PrestigeClaimUI instance;

    [HideInInspector]
    private RectTransform rectTransform;

    [SerializeField]
    private Text titleText;

    [SerializeField]
    private Text bodyText;

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

    public void Show(double count, float timeToShow = 3.5f)
    {
        titleText.text = "Привлечено";
        bodyText.text = string.Format("{0} продюссеров", NumberUtility.Convert(count, 1000000.0));

        rectTransform.Show();
        //AudioManager.instance.Playsound("reward");
        StartCoroutine(ShowReward(timeToShow));
    }

    private IEnumerator ShowReward(float time)
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
