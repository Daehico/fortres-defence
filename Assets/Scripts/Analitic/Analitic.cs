using GameAnalyticsSDK;
using System.Collections.Generic;

public static class Analitic
{
    private const string ResourceGold = "Gold";
    private const string ResourceExp = "Exp";

    public static void StartGame(int count)
    {
        Dictionary<string, object> countText = new Dictionary<string, object> { { "count", count } };
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "game_start", countText);
    }

    public static void StartLevel(int index)
    {
        Dictionary<string, object> level = new Dictionary<string, object> { { "level", index } };
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "level_start", level);
    }

    public static void EndLevel(int index, int time)
    {
        Dictionary<string, object> userInfo = new Dictionary<string, object> { { "level ", index }, { "time_spent", time } };
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "level_complete", userInfo);
    }

    public static void RestartLevel(int index, int time)
    {
        Dictionary<string, object> userInfo = new Dictionary<string, object> { { "level", index }, { "time_spent", time } };
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "fail", userInfo);
    }

    public static void LoseMoney(float money,string source, string itemName)
    {
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, ResourceGold, money, source, itemName);
    }

    public static void AddMoney(float money, string source, string itemId)
    {
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, ResourceGold, money, source, itemId);
    }

    public static void LoseExp(float exp,string source ,string itemName)
    {
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, ResourceExp, exp,source , itemName);
    }

    public static void AddExp(float exp, string source, string itemId)
    {
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, ResourceExp, exp, source, itemId);
    }

    public static void TotalPlayedTime(float time)
    {
        GameAnalytics.NewDesignEvent("total_playtime", time);
    }

    public static void AddsStart(GAAdType type)
    {
        GameAnalytics.NewAdEvent(GAAdAction.Clicked, type, "VKSdk", "placement");
    }

    public static void AdsComplete(GAAdType type)
    {
        GameAnalytics.NewAdEvent(GAAdAction.Show, type, "VKSdk", "placement");
    }

    public static void BuyIap(string iapname)
    {
        Dictionary<string, object> sendData = new Dictionary<string, object>();
        sendData.Add(iapname, "iap");
        GameAnalytics.NewDesignEvent("iap_buy", sendData);
    }
}
