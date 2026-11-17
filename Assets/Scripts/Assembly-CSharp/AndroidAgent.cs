using System;
using System.Collections.Generic;
using IronSourceJSON;
using UnityEngine;

public class AndroidAgent : IronSourceIAgent
{
	private static AndroidJavaObject _androidBridge;

	private static readonly string AndroidBridge = "com.ironsource.unity.androidbridge.AndroidBridge";

	private const string REWARD_AMOUNT = "reward_amount";

	private const string REWARD_NAME = "reward_name";

	private const string PLACEMENT_NAME = "placement_name";

	private AndroidJavaObject getBridge()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		if (_androidBridge == null)
		{
			AndroidJavaClass val = new AndroidJavaClass(AndroidBridge);
			try
			{
				_androidBridge = ((AndroidJavaObject)val).CallStatic<AndroidJavaObject>("getInstance", new object[0]);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		return _androidBridge;
	}

	public void onApplicationPause(bool pause)
	{
		if (pause)
		{
			getBridge().Call("onPause", Array.Empty<object>());
		}
		else
		{
			getBridge().Call("onResume", Array.Empty<object>());
		}
	}

	public void setAge(int age)
	{
		getBridge().Call("setAge", new object[1] { age });
	}

	public void setGender(string gender)
	{
		getBridge().Call("setGender", new object[1] { gender });
	}

	public void setMediationSegment(string segment)
	{
		getBridge().Call("setMediationSegment", new object[1] { segment });
	}

	public string getAdvertiserId()
	{
		return getBridge().Call<string>("getAdvertiserId", new object[0]);
	}

	public void validateIntegration()
	{
		getBridge().Call("validateIntegration", Array.Empty<object>());
	}

	public void shouldTrackNetworkState(bool track)
	{
		getBridge().Call("shouldTrackNetworkState", new object[1] { track });
	}

	public bool setDynamicUserId(string dynamicUserId)
	{
		return getBridge().Call<bool>("setDynamicUserId", new object[1] { dynamicUserId });
	}

	public void setAdaptersDebug(bool enabled)
	{
		getBridge().Call("setAdaptersDebug", new object[1] { enabled });
	}

	public void setUserId(string userId)
	{
		getBridge().Call("setUserId", new object[1] { userId });
	}

	public void init(string appKey)
	{
		getBridge().Call("setPluginData", new object[3]
		{
			"Unity",
			IronSource.pluginVersion(),
			IronSource.unityVersion()
		});
		getBridge().Call("init", new object[1] { appKey });
	}

	public void init(string appKey, params string[] adUnits)
	{
		getBridge().Call("setPluginData", new object[3]
		{
			"Unity",
			IronSource.pluginVersion(),
			IronSource.unityVersion()
		});
		getBridge().Call("init", new object[2] { appKey, adUnits });
	}

	public void initISDemandOnly(string appKey, params string[] adUnits)
	{
		getBridge().Call("setPluginData", new object[3]
		{
			"Unity",
			IronSource.pluginVersion(),
			IronSource.unityVersion()
		});
		getBridge().Call("initISDemandOnly", new object[2] { appKey, adUnits });
	}

	public void showRewardedVideo()
	{
		getBridge().Call("showRewardedVideo", Array.Empty<object>());
	}

	public void showRewardedVideo(string placementName)
	{
		getBridge().Call("showRewardedVideo", new object[1] { placementName });
	}

	public bool isRewardedVideoAvailable()
	{
		return getBridge().Call<bool>("isRewardedVideoAvailable", new object[0]);
	}

	public bool isRewardedVideoPlacementCapped(string placementName)
	{
		return getBridge().Call<bool>("isRewardedVideoPlacementCapped", new object[1] { placementName });
	}

	public IronSourcePlacement getPlacementInfo(string placementName)
	{
		string text = getBridge().Call<string>("getPlacementInfo", new object[1] { placementName });
		IronSourcePlacement result = null;
		if (text != null)
		{
			Dictionary<string, object> obj = Json.Deserialize(text) as Dictionary<string, object>;
			string placementName2 = obj["placement_name"].ToString();
			string rewardName = obj["reward_name"].ToString();
			int rewardAmount = Convert.ToInt32(obj["reward_amount"].ToString());
			result = new IronSourcePlacement(placementName2, rewardName, rewardAmount);
		}
		return result;
	}

	public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
	{
		string text = Json.Serialize(parameters);
		getBridge().Call("setRewardedVideoServerParams", new object[1] { text });
	}

	public void clearRewardedVideoServerParams()
	{
		getBridge().Call("clearRewardedVideoServerParams", Array.Empty<object>());
	}

	public void showISDemandOnlyRewardedVideo(string instanceId)
	{
		getBridge().Call("showISDemandOnlyRewardedVideo", new object[1] { instanceId });
	}

	public void showISDemandOnlyRewardedVideo(string instanceId, string placementName)
	{
		getBridge().Call("showISDemandOnlyRewardedVideo", new object[2] { instanceId, placementName });
	}

	public bool isISDemandOnlyRewardedVideoAvailable(string instanceId)
	{
		return getBridge().Call<bool>("isISDemandOnlyRewardedVideoAvailable", new object[1] { instanceId });
	}

	public void loadInterstitial()
	{
	}

	public void showInterstitial()
	{
		getBridge().Call("showInterstitial", Array.Empty<object>());
	}

	public void showInterstitial(string placementName)
	{
		getBridge().Call("showInterstitial", new object[1] { placementName });
	}

	public bool isInterstitialReady()
	{
		return getBridge().Call<bool>("isInterstitialReady", new object[0]);
	}

	public bool isInterstitialPlacementCapped(string placementName)
	{
		return getBridge().Call<bool>("isInterstitialPlacementCapped", new object[1] { placementName });
	}

	public void loadISDemandOnlyInterstitial(string instanceId)
	{
		getBridge().Call("loadISDemandOnlyInterstitial", new object[1] { instanceId });
	}

	public void showISDemandOnlyInterstitial(string instanceId)
	{
		getBridge().Call("showISDemandOnlyInterstitial", new object[1] { instanceId });
	}

	public void showISDemandOnlyInterstitial(string instanceId, string placementName)
	{
		getBridge().Call("showISDemandOnlyInterstitial", new object[2] { instanceId, placementName });
	}

	public bool isISDemandOnlyInterstitialReady(string instanceId)
	{
		return getBridge().Call<bool>("isISDemandOnlyInterstitialReady", new object[1] { instanceId });
	}

	public void showOfferwall()
	{
		getBridge().Call("showOfferwall", Array.Empty<object>());
	}

	public void showOfferwall(string placementName)
	{
		getBridge().Call("showOfferwall", new object[1] { placementName });
	}

	public void getOfferwallCredits()
	{
		getBridge().Call("getOfferwallCredits", Array.Empty<object>());
	}

	public bool isOfferwallAvailable()
	{
		return getBridge().Call<bool>("isOfferwallAvailable", new object[0]);
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
	{
		loadBanner(size, position, string.Empty);
	}

	public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position, string placementName)
	{
		getBridge().Call("loadBanner", new object[5]
		{
			size.Description,
			size.Width,
			size.Height,
			(int)position,
			placementName
		});
	}

	public void destroyBanner()
	{
		getBridge().Call("destroyBanner", Array.Empty<object>());
	}

	public void displayBanner()
	{
		getBridge().Call("displayBanner", Array.Empty<object>());
	}

	public void hideBanner()
	{
		getBridge().Call("hideBanner", Array.Empty<object>());
	}

	public bool isBannerPlacementCapped(string placementName)
	{
		return getBridge().Call<bool>("isBannerPlacementCapped", new object[1] { placementName });
	}

	public void setSegment(IronSourceSegment segment)
	{
		string text = Json.Serialize(segment.getSegmentAsDict());
		getBridge().Call("setSegment", new object[1] { text });
	}

	public void setConsent(bool consent)
	{
	}
}
