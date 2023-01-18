using Lean.Localization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageChanger : MonoBehaviour
{
    [SerializeField] private LeanLocalization _leanLocalization;

    private void Start()
    {
#if YANDEX_GAMES

        switch (Agava.YandexGames.YandexGamesSdk.Environment.i18n.lang)
        {
            case "en":
                _leanLocalization.SetCurrentLanguage("English");
                break;
            case "tr":
                _leanLocalization.SetCurrentLanguage("Turkish");
                break;
            case "ru":
                _leanLocalization.SetCurrentLanguage("Russian");
                break;
            default:
                _leanLocalization.SetCurrentLanguage("English");
                break;
        }
#endif
#if VK_GAMES
        _leanLocalization.SetCurrentLanguage("Russian");
#endif
    }
}
