using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSave : MonoBehaviour
{
#if YANDEX_GAMES
    private void Awake()
    {
        Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.SavedCoins = JsonUtility.FromJson<Coins>(data).Coin);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.StrongWallExtra = JsonUtility.FromJson<Fortres>(data).Level);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.isNewGame = System.Convert.ToBoolean(JsonUtility.FromJson<IsNewGame>(data).NewGame)) ;
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.LevelPass = JsonUtility.FromJson<LevelPass>(data).LevelPassed);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.ItemDoubleArrow = JsonUtility.FromJson<DoubleArrow>(data).Count);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.ItemTripleArrow = JsonUtility.FromJson<TripleArrow>(data).Count);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.ItemFreeze = JsonUtility.FromJson<Freeze>(data).Count);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.ItemPoison = JsonUtility.FromJson<Poison>(data).Count);
        //Agava.YandexGames.PlayerAccount.GetPlayerData((data) => GlobalValue.UpgradeStrongWall = JsonUtility.FromJson<Wall>(data).Level);
    }
#endif
}
