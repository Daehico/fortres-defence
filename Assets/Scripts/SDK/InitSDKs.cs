using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSDKs : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(InitSdk());
    }

    private IEnumerator InitSdk()
    {
#if !UNITY_WEBGL || UNITY_EDITOR
        yield return new WaitForSeconds(0.1f);
#elif YANDEX_GAMES
        while(Agava.YandexGames.YandexGamesSdk.IsInitialized == false)
        {
            yield return Agava.YandexGames.YandexGamesSdk.Initialize();
        }
#elif VK_GAMES
        while (DungeonGames.VKGames.VKGamesSdk.Initialized == false)
        {     
            yield return DungeonGames.VKGames.VKGamesSdk.Initialize();
        }

        GameAnalyticsSDK.GameAnalytics.Initialize();
#endif
        SceneManager.LoadScene(1);
    }
}

