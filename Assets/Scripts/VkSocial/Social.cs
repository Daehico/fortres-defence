using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Social : MonoBehaviour
{
    [SerializeField] private int _rewardedCoins;

    private Action _onRevarded;

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
