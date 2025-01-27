using System.Collections.Generic;
using UnityEngine;

public static class ModalDialog
{
    public static void Show(this RectTransform value)
    {
        value.anchoredPosition = Vector2.zero;
        value.gameObject.SetActive(true);
    }

    public static void Hide(this RectTransform value)
    {
        value.anchoredPosition = Vector2.zero;
        value.gameObject.SetActive(false);
    }
}