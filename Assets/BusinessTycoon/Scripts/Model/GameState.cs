using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using UnityEngine;
using Game;

[Serializable]
public class GameState
{
    public double Gold = 0;
    public bool Music = true;
    public bool SoundFx = true;
    public Reward FreeGift = Reward.RewardGold(2);
    public double DailyGift = DateTime.Today.AddHours(-24).ToOADate();
    public int DailyGiftCount = 0;
    public float Version = 1.0f;

    public GameState()
    {

    }

    public string ToJsonString()
    {
        return Encrypt.EncryptString(JsonUtility.ToJson(this));
    }

    public void FromJsonFile(string file)
    {
        var json = Encrypt.DecryptString(file);
        var loadedState = JsonUtility.FromJson<GameState>(json);
        if (Math.Abs(loadedState.Version - Version) > 0.1)
        {
            Gold = loadedState.Gold;
            Music = loadedState.Music;
            SoundFx = loadedState.SoundFx;
            FreeGift = loadedState.FreeGift;
            DailyGift = loadedState.DailyGift;
            DailyGiftCount = loadedState.DailyGiftCount;
            Version = loadedState.Version; // This will be updated later, must be old version
        }
        else
        {
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}