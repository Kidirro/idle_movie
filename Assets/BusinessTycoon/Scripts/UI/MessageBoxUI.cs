using System;
using UnityEngine;
using UnityEngine.UI;

public class MessageBoxUI : MonoBehaviour
{
    public enum ButtonOptions
    {
        OK,
        OK_Cancel,
        None
    }

    public static MessageBoxUI instance;

    [SerializeField]
    private Button confirmButton;
    [SerializeField]
    private Button cancelButton;
    [SerializeField]
    private Text confirmButtonText;
    [SerializeField]
    private Text cancelButtonText;
    [SerializeField]
    private GameObject closeButton;
    [SerializeField]
    private Text title;
    [SerializeField]
    private Text body;
    [HideInInspector]
    public RectTransform rectTransform;
    private Action okCallback;
    private Action cancelCallback;

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

    public void Show(string title, string body, Action method = null, ButtonOptions options = ButtonOptions.OK_Cancel, string confirmButtonText = "Yes", string cancelButtonText = "No!", bool showClose = true)
    {
        if (instance != null)
        {
            instance.title.text = title;
            instance.body.text = body;
            instance.okCallback = null;
            instance.cancelCallback = null;
            instance.okCallback = method;
            instance.SetupButtons(options, confirmButtonText, cancelButtonText, showClose);

            instance.rectTransform.Show();
        }
    }

    private void SetupButtons(ButtonOptions options, string confirmText, string cancelText, bool showClose)
    {
        switch (options)
        {
            case ButtonOptions.OK:
                confirmButton.gameObject.SetActive(true);
                cancelButton.gameObject.SetActive(false);
                break;
            case ButtonOptions.OK_Cancel:
                confirmButton.gameObject.SetActive(true);
                cancelButton.gameObject.SetActive(true);
                break;
            case ButtonOptions.None:
                confirmButton.gameObject.SetActive(false);
                cancelButton.gameObject.SetActive(false);
                break;
        }
        confirmButtonText.text = confirmText;
        cancelButtonText.text = cancelText;
        closeButton.SetActive(showClose);
    }

    public void OnConfirmClicked()
    {
        if (okCallback != null)
        {
            okCallback();
        }
        OnCancelClicked();
    }

    public void OnCancelClicked()
    {
        rectTransform.Hide();
    }
}