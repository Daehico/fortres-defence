using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Social : MonoBehaviour
{
    [SerializeField] private int _rewardedCoins;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _button;

    private Action _onRevarded;

    private void Awake()
    {
#if YANDEX_GAMES
        _panel.SetActive(false);
        _button.SetActive(false);
#endif
#if VK_GAMES
        _panel.SetActive(true);
        _button.SetActive(true);
#endif
    }

    private void OnEnable()
    {
        _onRevarded += OnRevarded;
    }

    private void OnDisable()
    {
        _onRevarded -= OnRevarded;
    }

    public void OnJoinGroopButtonClick()
    {
        DungeonGames.VKGames.Community.InviteToDungeonGamesGroup(_onRevarded);
    }

    public void OnInviteButtonClick()
    {
        DungeonGames.VKGames.SocialInteraction.InviteFriends(_onRevarded);
    }

    private void OnRevarded()
    {
        GlobalValue.SavedCoins += _rewardedCoins;
    }
}
