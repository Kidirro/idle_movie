// using System;
// using System.Collections;
// using System.Collections.Generic;
// using TMPro;
// using UnityEngine;
// using UnityEngine.Serialization;
// //using YG;
//
// public class YG_FullscreenAds : MonoBehaviour
// {
//     [SerializeField] 
//     private GameObject fullscreenHolder;
//
//     [SerializeField] 
//     private TMP_Text timerText;
//
//     private bool isShow = false;
//     
//     private void Awake()
//     {
// #if !YG_PLUGIN_YANDEX_GAME
//         Destroy(this.gameObject);
// #endif
//         
//         //YandexGame.CloseFullAdEvent += CloseFullAdEvent;
//     }
//
//     private void OnDestroy()
//     {
//         //YandexGame.CloseFullAdEvent -= CloseFullAdEvent;
//     }
//
//     private void Start()
//     {
//         fullscreenHolder.SetActive(false);
//     }
//
//     private void Update()
//     {
//         if (YandexGame.timerShowAd >= YandexGame.Instance.infoYG.fullscreenAdInterval && Time.timeScale != 0 && isShow ==false)
//         {
//             StartCoroutine(IShowAd());
//         }
//     }
//
//     private IEnumerator IShowAd()
//     {
//         isShow = true;
//         fullscreenHolder.SetActive(true);
//         for (int i = 3; i > 0; i--)
//         {
//             timerText.text = "Реклама через " + i;
//             yield return new WaitForSecondsRealtime(1);
//         }
//         
//         fullscreenHolder.SetActive(false);
//         YandexGame.FullscreenShow();
//     }
//
//     private void CloseFullAdEvent()
//     {
//         isShow = false;
//     }
// }
