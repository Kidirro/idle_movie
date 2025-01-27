using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResizeScript : MonoBehaviour
{
    private float originalAspect = 0.5625f;

    private void Awake()
    {
        var aspect = Camera.main.aspect;
        var num = originalAspect / aspect;
        if (num >= 1)
        {
            num = 1;
        }
        var transform = this.transform;
        if ((Object)transform != (Object)null)
        {
            var transform2 = transform;
            var localScale = transform.localScale;
            var x = localScale.x * num;
            var localScale2 = transform.localScale;
            transform2.localScale = new Vector3(x, localScale2.y * num, 1f);
        }
    }
}