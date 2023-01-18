using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevardedCoins : MonoBehaviour
{
    [SerializeField] private int _rewardedCoins;

    private Action _adOpen;
    private Action _adRewarded;
    private Action _adClose;
    private Action<string> _adError;

    private void OnEnable()
    {
        _adOpen += OnAdOpened;
        _adRewarded += OnAdRewarded;
        _adClose += OnAdClose;
        _adError += OnAdError;
    }

    private void OnDisable()
    {
        _adOpen -= OnAdOpened;
        _adRewarded -= OnAdRewarded;
        _adClose -= OnAdClose;
        _adError -= OnAdError;
    }

    public void ShowRewarded()
    {
#if YANDEX_GAMES
        Agava.YandexGames.VideoAd.Show(_adOpen, _adRewarded, _adClose, _adError);
#endif
#if VK_GAMES
 DungeonGames.VKGames.VideoAd.Show(_adRewarded);
#endif
    }

    private void OnAdError(string obj)
    {
        AudioListener.pause = false;
        AudioListener.volume = 1f;
    }

    private void OnAdClose()
    {
        AudioListener.pause = false;
        AudioListener.volume = 1f;
    }

    private void OnAdRewarded()
    {
        GlobalValue.SavedCoins += _rewardedCoins;
    }

    private void OnAdOpened()
    {
        AudioListener.pause = true;
        AudioListener.volume = 0f;
    }
}
