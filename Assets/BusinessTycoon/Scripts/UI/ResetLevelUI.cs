using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResetLevelUI : MonoBehaviour
{
    public static ResetLevelUI instance;
    public Text resetLevelBody;

    [HideInInspector]
    private RectTransform rectTransform;

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
        var text = "You completed the game!\r\n\r\n";
        text += "But your journey to the top is not over.\r\n";

        if (GameManager.instance.LevelData.Completed == true)
        {
            text += "Reset the game and earn 100 gold for completing the game again!\r\n\r\n" + "Well done!";
        }
        else
        {
            text += "Reset the game and earn 500 gold for completing the game.\r\n\r\n" + "Good work!";
        }

        resetLevelBody.text = text;

        rectTransform = GetComponent<RectTransform>();
        rectTransform.Hide();
    }

    public void Show()
    {
        instance.rectTransform.Show();
    }

    // Update is called once per frame
    void Update()
    {

    }
}