using System;
using System.Collections.Generic;
using IronSourceJSON;
using UnityEngine;

public class IronSourceConfig
{
	private const string unsupportedPlatformStr = "Unsupported Platform";

	private static IronSourceConfig _instance;

	private static AndroidJavaObject _androidBridge;

	private static readonly string AndroidBridge = "com.ironsource.unity.androidbridge.AndroidBridge";

	public static IronSourceConfig Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new IronSourceConfig();
			}
			return _instance;
		}
	}

	public IronSourceConfig()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
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

	public void setLanguage(string language)
	{
		_androidBridge.Call("setLanguage", new object[1] { language });
	}

	public void setClientSideCallbacks(bool status)
	{
		_androidBridge.Call("setClientSideCallbacks", new object[1] { status });
	}

	public void setRewardedVideoCustomParams(Dictionary<string, string> rewardedVideoCustomParams)
	{
		string text = Json.Serialize(rewardedVideoCustomParams);
		_androidBridge.Call("setRewardedVideoCustomParams", new object[1] { text });
	}

	public void setOfferwallCustomParams(Dictionary<string, string> offerwallCustomParams)
	{
		string text = Json.Serialize(offerwallCustomParams);
		_androidBridge.Call("setOfferwallCustomParams", new object[1] { text });
	}
}
