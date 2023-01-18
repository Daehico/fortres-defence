using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IapHandler : MonoBehaviour
{
    [SerializeField] private Image _yanIcon;
    [SerializeField] private string _idName;
    [SerializeField] private int _rewardedCoins;

    private Action _onRewardedCallback;

    private void OnEnable()
    {
        _onRewardedCallback += OnRewardedCallback;
    }

    private void Awake()
    {
#if YANDEX_GAMES
        _yanIcon.gameObject.SetActive(true);
       Agava.YandexGames.InAppPurchases.InitPayments();
#endif
#if VK_GAMES
_yanIcon.gameObject.SetActive(false);
#endif
    }

    public void BuyItem()
    {
#if YANDEX_GAMES
        Agava.YandexGames.InAppPurchases.BuyItem(_idName, _onRewardedCallback);
#endif
#if VK_GAMES
        DungeonGames.VKGames.InAppPurchase.BuyItem(_idName, _onRewardedCallback);
#endif
    }

    private void OnRewardedCallback()
    {
        GlobalValue.SavedCoins += _rewardedCoins;
    }
}
