using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveAd : MonoBehaviour
{
    [SerializeField] private int _price;

    public Text priceTxt;
    public Text rewardedTxt;
    // Start is called before the first frame update
    void Start()
    {
#if YANDEX_GAMES
        gameObject.SetActive(false);
#endif
        gameObject.SetActive(GameMode.Instance && !GlobalValue.RemoveAds);
  
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalValue.RemoveAds)
        {

            priceTxt.text = _price + "голосов";
            Debug.LogWarning("Ads Remove");
            gameObject.SetActive(false);
        }
    }

    public void Buy()
    {
        SoundManager.Click();
        GameMode.Instance.BuyRemoveAds();
    }
}
