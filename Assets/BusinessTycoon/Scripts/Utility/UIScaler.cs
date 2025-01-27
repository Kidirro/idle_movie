using System;
using UnityEngine;

[ExecuteInEditMode]
public class UIScaler : MonoBehaviour
{
    [SerializeField]
    private Axis axis;

    [SerializeField]
    private RectTransform scaleObject;

    [SerializeField] 
    private RectTransform targetObject;

    [SerializeField]
    private Vector2 nativeSize;
    

    private void Update()
    {
        if (scaleObject == null) return;
        if (targetObject == null) return;
        
        if ((axis & Axis.Vertical) == Axis.Vertical)
        {
            scaleObject.sizeDelta = new Vector2(scaleObject.sizeDelta.x, nativeSize.y *  Mathf.Max(targetObject.localScale.y,1));
        }
        if ((axis & Axis.Horizontal) == Axis.Horizontal)
        {
            scaleObject.sizeDelta = new Vector2(nativeSize.x *  Mathf.Max(targetObject.localScale.x,1), scaleObject.sizeDelta.y);
        }
    }

    [Flags]
    private enum Axis 
    {
        Horizontal = 1,
        Vertical = 2
    }
}
