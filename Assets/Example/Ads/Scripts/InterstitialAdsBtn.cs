using UnityEngine;
using UnityEngine.UI;
//using YG;

namespace Example.Ads.Scripts
{
   public class InterstitialAdsBtn : MonoBehaviour
   {
      [SerializeField]
      private Button button;

      private void Awake()
      {
         button.onClick.AddListener(OnButtonClick);
      }

      private void OnButtonClick()
      {
#if YG_PLUGIN_YANDEX_GAME
         //YandexGame.FullscreenShow();
#elif UNITY_ANDROID || UNITY_IOS
         //AdManager.instance.ShowInterstitial("");
#endif
      }
   }
}
