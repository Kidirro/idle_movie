using System;
using UnityEngine;
//using YG;

namespace Example.CloudSaves.Scripts
{
    public class CloudSaveExample : MonoBehaviour
    {
        private void Awake()
        {
            /*
            YandexGame.LoadCloud();
            YandexGame.GetDataEvent += SaveDataEvent;
            */
        }

        private void OnDestroy()
        {
            //YandexGame.GetDataEvent -= SaveDataEvent;
        }

        private void SaveDataEvent()
        {
        }
    }
}