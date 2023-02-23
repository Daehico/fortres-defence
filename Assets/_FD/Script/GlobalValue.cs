using UnityEngine;
using System.Collections;
using System;

public class GlobalValue : MonoBehaviour
{
    public static bool isFirstOpenMainMenu = true;
    public static int worldPlaying = 1;
    public static int levelPlaying = 1;
    //public static int finishGameAtLevel = 50;

    public static string WorldReached = "WorldReached";
    public static bool isSound = true;
    public static bool isMusic = true;

    public static bool isNewGame
    {
        get { return PlayerPrefs.GetInt("isNewGame", 0) == 0; }
        set { SetNewGame(value); }
    }

    public static int lastDayShowNativeAd1
    {
        get { return PlayerPrefs.GetInt("lastDayShowNativeAd1", 0); }
        set { PlayerPrefs.SetInt("lastDayShowNativeAd1", value); }
    }

    public static int lastDayShowNativeAd2
    {
        get { return PlayerPrefs.GetInt("lastDayShowNativeAd2", 0); }
        set { PlayerPrefs.SetInt("lastDayShowNativeAd2", value); }
    }

    public static int lastDayShowNativeAd3
    {
        get { return PlayerPrefs.GetInt("lastDayShowNativeAd3", 0); }
        set { PlayerPrefs.SetInt("lastDayShowNativeAd3", value); }
    }

    public static int SavedCoins
    {
        get { return PlayerPrefs.GetInt("Coins", 200); }
        set { SetCoins(value); }
    }

    public static int LevelPass
    {
        get { return PlayerPrefs.GetInt("LevelReached", 0); }
        set { SetLevelPass(value); }
    }

    public static void LevelStar(int level, int stars)
    {
        PlayerPrefs.SetInt("LevelStars" + level, stars);
    }

    public static int LevelStar(int level)
    {
        return PlayerPrefs.GetInt("LevelStars" + level, 0);
    }

    public static bool RemoveAds
    {
        get { return PlayerPrefs.GetInt("RemoveAds", 0) == 1 ? true : false; }
        set { PlayerPrefs.SetInt("RemoveAds", value ? 1 : 0); }
    }

    public static int ItemDoubleArrow
    {
        get { return PlayerPrefs.GetInt("ItemDoubleArrow", 3); }
        set { SetDoubleArrow(value); }
    }

    public static int ItemTripleArrow
    {
        get { return PlayerPrefs.GetInt("ItemTripleArrow", 1); }
        set { SetTripleArrow(value); }
    }

    public static int ItemPoison
    {
        get { return PlayerPrefs.GetInt("ItemPoison", 3); }
        set { SetPoison(value); }
    }

    public static int ItemFreeze
    {
        get { return PlayerPrefs.GetInt("ItemFreeze", 3); }
        set { SetFreeze(value); }
    }

    public static int UpgradeStrongWall
    {
        get { return PlayerPrefs.GetInt("UpgradeStrongWall", 0); }
        set { SetWall(value); }
    }
    public static float StrongWallExtra
    {
        get { return PlayerPrefs.GetFloat("StrongWallExtra", 0); }
        set { SetStrongWallExtra(value); }
    }

    private static void SetStrongWallExtra(float value)
    {
        PlayerPrefs.SetFloat("StrongWallExtra", value);
#if YANDEX_GAMES
        //Fortres fortres = new Fortres(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(fortres));
#endif
    }

    private static void SetCoins(int value)
    {
        PlayerPrefs.SetInt("Coins", value);
#if YANDEX_GAMES
        Coins coins = new Coins(value);
        Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(coins));
#endif
    }

    private static void SetNewGame(bool value)
    {
        PlayerPrefs.SetInt("isNewGame", value ? 0 : 1);
#if YANDEX_GAMES
        //IsNewGame isNewGame = new IsNewGame(value ? 0 : 1);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(isNewGame));
#endif
    }

    private static void SetLevelPass(int value)
    {
        PlayerPrefs.SetInt("LevelReached", value);
#if YANDEX_GAMES
        //LevelPass levelPass = new LevelPass(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(levelPass));
#endif
    }

    private static void SetDoubleArrow(int value)
    {
        PlayerPrefs.SetInt("ItemDoubleArrow", value);
//#if YANDEX_GAMES
//        DoubleArrow doubleArrow = new DoubleArrow(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(doubleArrow));
//#endif
    }

    private static void SetTripleArrow(int value)
    {
        PlayerPrefs.SetInt("ItemTripleArrow", value);
#if YANDEX_GAMES
        //TripleArrow tripleArrow = new TripleArrow(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(tripleArrow));
#endif
    }

    private static void SetPoison(int value)
    {
        PlayerPrefs.SetInt("ItemPoison", value);
#if YANDEX_GAMES
        //Poison poison = new Poison(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(poison));
#endif
    }

    private static void SetFreeze(int value)
    {
        PlayerPrefs.SetInt("ItemFreeze", value);
#if YANDEX_GAMES
        //Freeze freeze = new Freeze(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(freeze));
#endif
    }

    private static void SetWall(int value)
    {
        PlayerPrefs.SetInt("UpgradeStrongWall", value);
#if YANDEX_GAMES
        //Wall wall = new Wall(value);
        //Agava.YandexGames.PlayerAccount.SetPlayerData(JsonUtility.ToJson(wall));
#endif
    }
}

#if YANDEX_GAMES
[Serializable]
public class Coins
{
    public int Coin;

    public Coins(int coins)
    {
        Coin = coins;
    }
}

[Serializable]
public class Fortres
{
    public float Level;

    public Fortres(float level)
    {
        Level = level;
    }
}

[Serializable]
public class IsNewGame
{
    public int NewGame;

    public IsNewGame(int newGame)
    {
        NewGame = newGame;
    }
}

[Serializable]
public class LevelPass
{
    public int LevelPassed;

    public LevelPass(int levelPased)
    {
        LevelPassed = levelPased;
    }
}

[Serializable]
public class DoubleArrow
{
    public int Count;

    public DoubleArrow(int count)
    {
        Count = count;
    }
}

[Serializable]
public class TripleArrow
{
    public int Count;

    public TripleArrow(int count)
    {
        Count = count;
    }
}

[Serializable]
public class Poison
{
    public int Count;

    public Poison(int count)
    {
        Count = count;
    }
}

[Serializable]
public class Freeze
{
    public int Count;

    public Freeze(int count)
    {
        Count = count;
    }
}

[Serializable]
public class Wall
{
    public int Level;

    public Wall(int level)
    {
        Level = level;
    }
}
#endif