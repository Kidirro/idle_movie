using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
//using YG;

namespace Example.Ads.Scripts
{
    public class RewardedAdsBtn : MonoBehaviour
    {
        [SerializeField]
        private Button button;

        [SerializeField]
        private int yg_id;

        [SerializeField]
        private string android_ios_reward;

        private void Awake()
        {
            button.onClick.AddListener(OnButtonClick);
            
#if YG_PLUGIN_YANDEX_GAME
            //YandexGame.RewardVideoEvent += RewardVideoEvent;
#endif
        }

        private void OnButtonClick()
        {
#if YG_PLUGIN_YANDEX_GAME
            //YandexGame.RewVideoShow(yg_id);
#elif UNITY_ANDROID || UNITY_IOS
            AdManager.instance.ShowAd(android_ios_reward);
#endif
        }

        private void RewardVideoEvent(int id)
        {
            Debug.Log($"Rewarded :{id}");
        }
    }
}
