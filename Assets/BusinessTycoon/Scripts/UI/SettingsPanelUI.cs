using System;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class SettingsPanelUI : MonoBehaviour
{
    [SerializeField]
    private Toggle music;
    [SerializeField]
    private Toggle soundFx;

    void Start()
    {
        music.isOn = GameManager.instance.GameState.Music;
        soundFx.isOn = GameManager.instance.GameState.SoundFx;
    }

    public void OnMusicToggle()
    {
        GameManager.instance.GameState.Music = music.isOn;
        AudioManager.instance.ToggleBackgroundMusic();
    }

    public void OnSoundFxToggle()
    {
        GameManager.instance.GameState.SoundFx = soundFx.isOn;
        AudioManager.instance.ToggleSoundFx();
    }
}