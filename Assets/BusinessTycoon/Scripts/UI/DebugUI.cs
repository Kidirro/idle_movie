using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugUI : MonoBehaviour
{
    public static DebugUI instance;

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

    public void SpinWheel()
    {
        MainUIController.instance.SpinWheelShow();
        Hide();
    }

    public void ResetGame()
    {
        GameManager.instance.GameState = new GameState();
        GameManager.instance.LevelData = LevelHandler.CreateGameData();
        GameManager.instance.Save();
        MessageBoxUI.instance.Show("Restart", "Restart the game to see changes", null, MessageBoxUI.ButtonOptions.None);
        Hide();
    }

    // Use this for initialization
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        rectTransform.Hide();
    }

    public void Show()
    {
        instance.rectTransform.Show();
    }

    public void Hide()
    {
        instance.rectTransform.Hide();
    }

    // Update is called once per frame
    void Update()
    {

    }
}