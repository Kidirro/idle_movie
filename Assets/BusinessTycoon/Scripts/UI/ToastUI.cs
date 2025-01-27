using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ToastUI : MonoBehaviour
{
    public static ToastUI instance;
    public Text NotificationName;
    public Text NotificationDescription;
    private bool isActive = false;
    private float displayEndTime;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }

    void Start()
    {

    }

    public void FlashToast(string title, string description, float secondsToDisplay)
    {
        displayEndTime = secondsToDisplay + Time.time;
        NotificationName.text = title;
        NotificationDescription.text = description;
        if (!isActive)
        {
            isActive = true;
            gameObject.SetActive(true);
            StartCoroutine(DisplayToast());
        }
    }

    public void OnClickToast()
    {
        if (isActive)
        {
            displayEndTime = Time.time;
        }
    }

    private IEnumerator DisplayToast()
    {
        while (Time.time < displayEndTime)
        {
            yield return 0;
        }

        HideToast();
    }

    private void HideToast()
    {
        isActive = false;
        gameObject.SetActive(false);
    }
}