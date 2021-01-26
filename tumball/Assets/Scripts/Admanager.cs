using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;
using GoogleMobileAds;
using System;
using UnityEngine.UI;

public class Admanager : MonoBehaviour {

    public static Admanager Instance { set; get; }
    InterstitialAd interstitial;
    private BannerView bannerView;

    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

#if UNITY_ANDROID
        string appId = "ca-app-pub-3616010880631434~1459884235";
#elif UNITY_IPHONE
            string appId = "unused";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
    }

    private void Update()
    {

    }

  public void GetLifeAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }

    private void HandleAdResult (ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                SaveManager.Instance.state.levelLife += 5;
                Debug.Log("....");
                SaveManager.Instance.Save();
                Pause.Instance.closeAd();
                break;
            case ShowResult.Skipped:
                Debug.Log("Player did not fully watch the ad");
                break;
            case ShowResult.Failed:
                Debug.Log("Player failed to launch ad.");
                break;
        }
    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }

    public void RequestBanner()
    {

#if UNITY_ANDROID
			string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the bottom of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

    public void DestroyBanner()
    {
        bannerView.Destroy();
    }

    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3616010880631434/2919595124";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

}