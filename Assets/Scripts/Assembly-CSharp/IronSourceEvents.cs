using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using IronSourceJSON;
using UnityEngine;

public class IronSourceEvents : MonoBehaviour
{
	private const string ERROR_CODE = "error_code";

	private const string ERROR_DESCRIPTION = "error_description";

	private const string INSTANCE_ID_KEY = "instanceId";

	private const string PLACEMENT_KEY = "placement";

	private static event Action<IronSourceError> _onRewardedVideoAdShowFailedEvent;

	public static event Action<IronSourceError> onRewardedVideoAdShowFailedEvent
	{
		add
		{
			if (_onRewardedVideoAdShowFailedEvent == null || !_onRewardedVideoAdShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdShowFailedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdShowFailedEvent -= value;
			}
		}
	}

	private static event Action _onRewardedVideoAdOpenedEvent;

	public static event Action onRewardedVideoAdOpenedEvent
	{
		add
		{
			if (_onRewardedVideoAdOpenedEvent == null || !_onRewardedVideoAdOpenedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdOpenedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdOpenedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdOpenedEvent -= value;
			}
		}
	}

	private static event Action _onRewardedVideoAdClosedEvent;

	public static event Action onRewardedVideoAdClosedEvent
	{
		add
		{
			if (_onRewardedVideoAdClosedEvent == null || !_onRewardedVideoAdClosedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClosedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdClosedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClosedEvent -= value;
			}
		}
	}

	private static event Action _onRewardedVideoAdStartedEvent;

	public static event Action onRewardedVideoAdStartedEvent
	{
		add
		{
			if (_onRewardedVideoAdStartedEvent == null || !_onRewardedVideoAdStartedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdStartedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdStartedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdStartedEvent -= value;
			}
		}
	}

	private static event Action _onRewardedVideoAdEndedEvent;

	public static event Action onRewardedVideoAdEndedEvent
	{
		add
		{
			if (_onRewardedVideoAdEndedEvent == null || !_onRewardedVideoAdEndedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdEndedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdEndedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdEndedEvent -= value;
			}
		}
	}

	private static event Action<IronSourcePlacement> _onRewardedVideoAdRewardedEvent;

	public static event Action<IronSourcePlacement> onRewardedVideoAdRewardedEvent
	{
		add
		{
			if (_onRewardedVideoAdRewardedEvent == null || !_onRewardedVideoAdRewardedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdRewardedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdRewardedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdRewardedEvent -= value;
			}
		}
	}

	private static event Action<IronSourcePlacement> _onRewardedVideoAdClickedEvent;

	public static event Action<IronSourcePlacement> onRewardedVideoAdClickedEvent
	{
		add
		{
			if (_onRewardedVideoAdClickedEvent == null || !_onRewardedVideoAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClickedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClickedEvent -= value;
			}
		}
	}

	private static event Action<bool> _onRewardedVideoAvailabilityChangedEvent;

	public static event Action<bool> onRewardedVideoAvailabilityChangedEvent
	{
		add
		{
			if (_onRewardedVideoAvailabilityChangedEvent == null || !_onRewardedVideoAvailabilityChangedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAvailabilityChangedEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAvailabilityChangedEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAvailabilityChangedEvent -= value;
			}
		}
	}

	private static event Action<string, bool> _onRewardedVideoAvailabilityChangedDemandOnlyEvent;

	public static event Action<string, bool> onRewardedVideoAvailabilityChangedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAvailabilityChangedDemandOnlyEvent == null || !_onRewardedVideoAvailabilityChangedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAvailabilityChangedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAvailabilityChangedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAvailabilityChangedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onRewardedVideoAdOpenedDemandOnlyEvent;

	public static event Action<string> onRewardedVideoAdOpenedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAdOpenedDemandOnlyEvent == null || !_onRewardedVideoAdOpenedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdOpenedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdOpenedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdOpenedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onRewardedVideoAdClosedDemandOnlyEvent;

	public static event Action<string> onRewardedVideoAdClosedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAdClosedDemandOnlyEvent == null || !_onRewardedVideoAdClosedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClosedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdClosedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClosedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string, IronSourcePlacement> _onRewardedVideoAdRewardedDemandOnlyEvent;

	public static event Action<string, IronSourcePlacement> onRewardedVideoAdRewardedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAdRewardedDemandOnlyEvent == null || !_onRewardedVideoAdRewardedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdRewardedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdRewardedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdRewardedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string, IronSourceError> _onRewardedVideoAdShowFailedDemandOnlyEvent;

	public static event Action<string, IronSourceError> onRewardedVideoAdShowFailedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAdShowFailedDemandOnlyEvent == null || !_onRewardedVideoAdShowFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdShowFailedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdShowFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdShowFailedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string, IronSourcePlacement> _onRewardedVideoAdClickedDemandOnlyEvent;

	public static event Action<string, IronSourcePlacement> onRewardedVideoAdClickedDemandOnlyEvent
	{
		add
		{
			if (_onRewardedVideoAdClickedDemandOnlyEvent == null || !_onRewardedVideoAdClickedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClickedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onRewardedVideoAdClickedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onRewardedVideoAdClickedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdReadyEvent;

	public static event Action onInterstitialAdReadyEvent
	{
		add
		{
			if (_onInterstitialAdReadyEvent == null || !_onInterstitialAdReadyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdReadyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdReadyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdReadyEvent -= value;
			}
		}
	}

	private static event Action<IronSourceError> _onInterstitialAdLoadFailedEvent;

	public static event Action<IronSourceError> onInterstitialAdLoadFailedEvent
	{
		add
		{
			if (_onInterstitialAdLoadFailedEvent == null || !_onInterstitialAdLoadFailedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdLoadFailedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdLoadFailedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdLoadFailedEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdOpenedEvent;

	public static event Action onInterstitialAdOpenedEvent
	{
		add
		{
			if (_onInterstitialAdOpenedEvent == null || !_onInterstitialAdOpenedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdOpenedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdOpenedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdOpenedEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdClosedEvent;

	public static event Action onInterstitialAdClosedEvent
	{
		add
		{
			if (_onInterstitialAdClosedEvent == null || !_onInterstitialAdClosedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClosedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdClosedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClosedEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdShowSucceededEvent;

	public static event Action onInterstitialAdShowSucceededEvent
	{
		add
		{
			if (_onInterstitialAdShowSucceededEvent == null || !_onInterstitialAdShowSucceededEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowSucceededEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdShowSucceededEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowSucceededEvent -= value;
			}
		}
	}

	private static event Action<IronSourceError> _onInterstitialAdShowFailedEvent;

	public static event Action<IronSourceError> onInterstitialAdShowFailedEvent
	{
		add
		{
			if (_onInterstitialAdShowFailedEvent == null || !_onInterstitialAdShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowFailedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowFailedEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdClickedEvent;

	public static event Action onInterstitialAdClickedEvent
	{
		add
		{
			if (_onInterstitialAdClickedEvent == null || !_onInterstitialAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClickedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClickedEvent -= value;
			}
		}
	}

	private static event Action<string> _onInterstitialAdReadyDemandOnlyEvent;

	public static event Action<string> onInterstitialAdReadyDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdReadyDemandOnlyEvent == null || !_onInterstitialAdReadyDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdReadyDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdReadyDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdReadyDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string, IronSourceError> _onInterstitialAdLoadFailedDemandOnlyEvent;

	public static event Action<string, IronSourceError> onInterstitialAdLoadFailedDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdLoadFailedDemandOnlyEvent == null || !_onInterstitialAdLoadFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdLoadFailedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdLoadFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdLoadFailedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onInterstitialAdOpenedDemandOnlyEvent;

	public static event Action<string> onInterstitialAdOpenedDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdOpenedDemandOnlyEvent == null || !_onInterstitialAdOpenedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdOpenedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdOpenedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdOpenedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onInterstitialAdClosedDemandOnlyEvent;

	public static event Action<string> onInterstitialAdClosedDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdClosedDemandOnlyEvent == null || !_onInterstitialAdClosedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClosedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdClosedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClosedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onInterstitialAdShowSucceededDemandOnlyEvent;

	public static event Action<string> onInterstitialAdShowSucceededDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdShowSucceededDemandOnlyEvent == null || !_onInterstitialAdShowSucceededDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowSucceededDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdShowSucceededDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowSucceededDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string, IronSourceError> _onInterstitialAdShowFailedDemandOnlyEvent;

	public static event Action<string, IronSourceError> onInterstitialAdShowFailedDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdShowFailedDemandOnlyEvent == null || !_onInterstitialAdShowFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowFailedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdShowFailedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdShowFailedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action<string> _onInterstitialAdClickedDemandOnlyEvent;

	public static event Action<string> onInterstitialAdClickedDemandOnlyEvent
	{
		add
		{
			if (_onInterstitialAdClickedDemandOnlyEvent == null || !_onInterstitialAdClickedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClickedDemandOnlyEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdClickedDemandOnlyEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdClickedDemandOnlyEvent -= value;
			}
		}
	}

	private static event Action _onInterstitialAdRewardedEvent;

	public static event Action onInterstitialAdRewardedEvent
	{
		add
		{
			if (_onInterstitialAdRewardedEvent == null || !_onInterstitialAdRewardedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdRewardedEvent += value;
			}
		}
		remove
		{
			if (_onInterstitialAdRewardedEvent.GetInvocationList().Contains(value))
			{
				_onInterstitialAdRewardedEvent -= value;
			}
		}
	}

	private static event Action _onOfferwallOpenedEvent;

	public static event Action onOfferwallOpenedEvent
	{
		add
		{
			if (_onOfferwallOpenedEvent == null || !_onOfferwallOpenedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallOpenedEvent += value;
			}
		}
		remove
		{
			if (_onOfferwallOpenedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallOpenedEvent -= value;
			}
		}
	}

	private static event Action<IronSourceError> _onOfferwallShowFailedEvent;

	public static event Action<IronSourceError> onOfferwallShowFailedEvent
	{
		add
		{
			if (_onOfferwallShowFailedEvent == null || !_onOfferwallShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallShowFailedEvent += value;
			}
		}
		remove
		{
			if (_onOfferwallShowFailedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallShowFailedEvent -= value;
			}
		}
	}

	private static event Action _onOfferwallClosedEvent;

	public static event Action onOfferwallClosedEvent
	{
		add
		{
			if (_onOfferwallClosedEvent == null || !_onOfferwallClosedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallClosedEvent += value;
			}
		}
		remove
		{
			if (_onOfferwallClosedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallClosedEvent -= value;
			}
		}
	}

	private static event Action<IronSourceError> _onGetOfferwallCreditsFailedEvent;

	public static event Action<IronSourceError> onGetOfferwallCreditsFailedEvent
	{
		add
		{
			if (_onGetOfferwallCreditsFailedEvent == null || !_onGetOfferwallCreditsFailedEvent.GetInvocationList().Contains(value))
			{
				_onGetOfferwallCreditsFailedEvent += value;
			}
		}
		remove
		{
			if (_onGetOfferwallCreditsFailedEvent.GetInvocationList().Contains(value))
			{
				_onGetOfferwallCreditsFailedEvent -= value;
			}
		}
	}

	private static event Action<Dictionary<string, object>> _onOfferwallAdCreditedEvent;

	public static event Action<Dictionary<string, object>> onOfferwallAdCreditedEvent
	{
		add
		{
			if (_onOfferwallAdCreditedEvent == null || !_onOfferwallAdCreditedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallAdCreditedEvent += value;
			}
		}
		remove
		{
			if (_onOfferwallAdCreditedEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallAdCreditedEvent -= value;
			}
		}
	}

	private static event Action<bool> _onOfferwallAvailableEvent;

	public static event Action<bool> onOfferwallAvailableEvent
	{
		add
		{
			if (_onOfferwallAvailableEvent == null || !_onOfferwallAvailableEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallAvailableEvent += value;
			}
		}
		remove
		{
			if (_onOfferwallAvailableEvent.GetInvocationList().Contains(value))
			{
				_onOfferwallAvailableEvent -= value;
			}
		}
	}

	private static event Action _onBannerAdLoadedEvent;

	public static event Action onBannerAdLoadedEvent
	{
		add
		{
			if (_onBannerAdLoadedEvent == null || !_onBannerAdLoadedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLoadedEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdLoadedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLoadedEvent -= value;
			}
		}
	}

	private static event Action<IronSourceError> _onBannerAdLoadFailedEvent;

	public static event Action<IronSourceError> onBannerAdLoadFailedEvent
	{
		add
		{
			if (_onBannerAdLoadFailedEvent == null || !_onBannerAdLoadFailedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLoadFailedEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdLoadFailedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLoadFailedEvent -= value;
			}
		}
	}

	private static event Action _onBannerAdClickedEvent;

	public static event Action onBannerAdClickedEvent
	{
		add
		{
			if (_onBannerAdClickedEvent == null || !_onBannerAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdClickedEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdClickedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdClickedEvent -= value;
			}
		}
	}

	private static event Action _onBannerAdScreenPresentedEvent;

	public static event Action onBannerAdScreenPresentedEvent
	{
		add
		{
			if (_onBannerAdScreenPresentedEvent == null || !_onBannerAdScreenPresentedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdScreenPresentedEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdScreenPresentedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdScreenPresentedEvent -= value;
			}
		}
	}

	private static event Action _onBannerAdScreenDismissedEvent;

	public static event Action onBannerAdScreenDismissedEvent
	{
		add
		{
			if (_onBannerAdScreenDismissedEvent == null || !_onBannerAdScreenDismissedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdScreenDismissedEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdScreenDismissedEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdScreenDismissedEvent -= value;
			}
		}
	}

	private static event Action _onBannerAdLeftApplicationEvent;

	public static event Action onBannerAdLeftApplicationEvent
	{
		add
		{
			if (_onBannerAdLeftApplicationEvent == null || !_onBannerAdLeftApplicationEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLeftApplicationEvent += value;
			}
		}
		remove
		{
			if (_onBannerAdLeftApplicationEvent.GetInvocationList().Contains(value))
			{
				_onBannerAdLeftApplicationEvent -= value;
			}
		}
	}

	private static event Action<string> _onSegmentReceivedEvent;

	public static event Action<string> onSegmentReceivedEvent
	{
		add
		{
			if (_onSegmentReceivedEvent == null || !_onSegmentReceivedEvent.GetInvocationList().Contains(value))
			{
				_onSegmentReceivedEvent += value;
			}
		}
		remove
		{
			if (_onSegmentReceivedEvent.GetInvocationList().Contains(value))
			{
				_onSegmentReceivedEvent -= value;
			}
		}
	}

	private void Awake()
	{
		((Object)((Component)this).gameObject).name = "IronSourceEvents";
		Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
	}

	public void onRewardedVideoAdShowFailed(string description)
	{
		if (_onRewardedVideoAdShowFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onRewardedVideoAdShowFailedEvent(errorFromErrorObject);
		}
	}

	public void onRewardedVideoAdOpened(string empty)
	{
		if (_onRewardedVideoAdOpenedEvent != null)
		{
			_onRewardedVideoAdOpenedEvent();
		}
	}

	public void onRewardedVideoAdClosed(string empty)
	{
		if (_onRewardedVideoAdClosedEvent != null)
		{
			_onRewardedVideoAdClosedEvent();
		}
	}

	public void onRewardedVideoAdStarted(string empty)
	{
		if (_onRewardedVideoAdStartedEvent != null)
		{
			_onRewardedVideoAdStartedEvent();
		}
	}

	public void onRewardedVideoAdEnded(string empty)
	{
		if (_onRewardedVideoAdEndedEvent != null)
		{
			_onRewardedVideoAdEndedEvent();
		}
	}

	public void onRewardedVideoAdRewarded(string description)
	{
		if (_onRewardedVideoAdRewardedEvent != null)
		{
			IronSourcePlacement placementFromObject = getPlacementFromObject(description);
			_onRewardedVideoAdRewardedEvent(placementFromObject);
		}
	}

	public void onRewardedVideoAdClicked(string description)
	{
		if (_onRewardedVideoAdClickedEvent != null)
		{
			IronSourcePlacement placementFromObject = getPlacementFromObject(description);
			_onRewardedVideoAdClickedEvent(placementFromObject);
		}
	}

	public void onRewardedVideoAvailabilityChanged(string stringAvailable)
	{
		bool obj = stringAvailable == "true";
		if (_onRewardedVideoAvailabilityChangedEvent != null)
		{
			_onRewardedVideoAvailabilityChangedEvent(obj);
		}
	}

	public void onRewardedVideoAvailabilityChangedDemandOnly(string args)
	{
		if (_onRewardedVideoAvailabilityChangedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> obj = Json.Deserialize(args) as List<object>;
			bool arg = obj[1].ToString().ToLower() == "true";
			string arg2 = obj[0].ToString();
			_onRewardedVideoAvailabilityChangedDemandOnlyEvent(arg2, arg);
		}
	}

	public void onRewardedVideoAdOpenedDemandOnly(string instanceId)
	{
		if (_onRewardedVideoAdOpenedDemandOnlyEvent != null)
		{
			_onRewardedVideoAdOpenedDemandOnlyEvent(instanceId);
		}
	}

	public void onRewardedVideoAdClosedDemandOnly(string instanceId)
	{
		if (_onRewardedVideoAdClosedDemandOnlyEvent != null)
		{
			_onRewardedVideoAdClosedDemandOnlyEvent(instanceId);
		}
	}

	public void onRewardedVideoAdRewardedDemandOnly(string args)
	{
		if (_onRewardedVideoAdRewardedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> list = Json.Deserialize(args) as List<object>;
			string arg = list[0].ToString();
			IronSourcePlacement placementFromObject = getPlacementFromObject(list[1]);
			_onRewardedVideoAdRewardedDemandOnlyEvent(arg, placementFromObject);
		}
	}

	public void onRewardedVideoAdShowFailedDemandOnly(string args)
	{
		if (_onRewardedVideoAdShowFailedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> list = Json.Deserialize(args) as List<object>;
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(list[1]);
			string arg = list[0].ToString();
			_onRewardedVideoAdShowFailedDemandOnlyEvent(arg, errorFromErrorObject);
		}
	}

	public void onRewardedVideoAdClickedDemandOnly(string args)
	{
		if (_onRewardedVideoAdClickedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> list = Json.Deserialize(args) as List<object>;
			string arg = list[0].ToString();
			IronSourcePlacement placementFromObject = getPlacementFromObject(list[1]);
			_onRewardedVideoAdClickedDemandOnlyEvent(arg, placementFromObject);
		}
	}

	public void onInterstitialAdReady()
	{
		if (_onInterstitialAdReadyEvent != null)
		{
			_onInterstitialAdReadyEvent();
		}
	}

	public void onInterstitialAdLoadFailed(string description)
	{
		if (_onInterstitialAdLoadFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onInterstitialAdLoadFailedEvent(errorFromErrorObject);
		}
	}

	public void onInterstitialAdOpened(string empty)
	{
		if (_onInterstitialAdOpenedEvent != null)
		{
			_onInterstitialAdOpenedEvent();
		}
	}

	public void onInterstitialAdClosed(string empty)
	{
		if (_onInterstitialAdClosedEvent != null)
		{
			_onInterstitialAdClosedEvent();
		}
	}

	public void onInterstitialAdShowSucceeded(string empty)
	{
		if (_onInterstitialAdShowSucceededEvent != null)
		{
			_onInterstitialAdShowSucceededEvent();
		}
	}

	public void onInterstitialAdShowFailed(string description)
	{
		if (_onInterstitialAdShowFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onInterstitialAdShowFailedEvent(errorFromErrorObject);
		}
	}

	public void onInterstitialAdClicked(string empty)
	{
		if (_onInterstitialAdClickedEvent != null)
		{
			_onInterstitialAdClickedEvent();
		}
	}

	public void onInterstitialAdReadyDemandOnly(string instanceId)
	{
		if (_onInterstitialAdReadyDemandOnlyEvent != null)
		{
			_onInterstitialAdReadyDemandOnlyEvent(instanceId);
		}
	}

	public void onInterstitialAdLoadFailedDemandOnly(string args)
	{
		if (_onInterstitialAdLoadFailedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> list = Json.Deserialize(args) as List<object>;
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(list[1]);
			string arg = list[0].ToString();
			_onInterstitialAdLoadFailedDemandOnlyEvent(arg, errorFromErrorObject);
		}
	}

	public void onInterstitialAdOpenedDemandOnly(string instanceId)
	{
		if (_onInterstitialAdOpenedDemandOnlyEvent != null)
		{
			_onInterstitialAdOpenedDemandOnlyEvent(instanceId);
		}
	}

	public void onInterstitialAdClosedDemandOnly(string instanceId)
	{
		if (_onInterstitialAdClosedDemandOnlyEvent != null)
		{
			_onInterstitialAdClosedDemandOnlyEvent(instanceId);
		}
	}

	public void onInterstitialAdShowSucceededDemandOnly(string instanceId)
	{
		if (_onInterstitialAdShowSucceededDemandOnlyEvent != null)
		{
			_onInterstitialAdShowSucceededDemandOnlyEvent(instanceId);
		}
	}

	public void onInterstitialAdShowFailedDemandOnly(string args)
	{
		if (_onInterstitialAdLoadFailedDemandOnlyEvent != null && !string.IsNullOrEmpty(args))
		{
			List<object> list = Json.Deserialize(args) as List<object>;
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(list[1]);
			string arg = list[0].ToString();
			_onInterstitialAdShowFailedDemandOnlyEvent(arg, errorFromErrorObject);
		}
	}

	public void onInterstitialAdClickedDemandOnly(string instanceId)
	{
		if (_onInterstitialAdClickedDemandOnlyEvent != null)
		{
			_onInterstitialAdClickedDemandOnlyEvent(instanceId);
		}
	}

	public void onInterstitialAdRewarded(string empty)
	{
		if (_onInterstitialAdRewardedEvent != null)
		{
			_onInterstitialAdRewardedEvent();
		}
	}

	public void onOfferwallOpened(string empty)
	{
		if (_onOfferwallOpenedEvent != null)
		{
			_onOfferwallOpenedEvent();
		}
	}

	public void onOfferwallShowFailed(string description)
	{
		if (_onOfferwallShowFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onOfferwallShowFailedEvent(errorFromErrorObject);
		}
	}

	public void onOfferwallClosed(string empty)
	{
		if (_onOfferwallClosedEvent != null)
		{
			_onOfferwallClosedEvent();
		}
	}

	public void onGetOfferwallCreditsFailed(string description)
	{
		if (_onGetOfferwallCreditsFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onGetOfferwallCreditsFailedEvent(errorFromErrorObject);
		}
	}

	public void onOfferwallAdCredited(string json)
	{
		if (_onOfferwallAdCreditedEvent != null)
		{
			_onOfferwallAdCreditedEvent(Json.Deserialize(json) as Dictionary<string, object>);
		}
	}

	public void onOfferwallAvailable(string stringAvailable)
	{
		bool obj = stringAvailable == "true";
		if (_onOfferwallAvailableEvent != null)
		{
			_onOfferwallAvailableEvent(obj);
		}
	}

	public void onBannerAdLoaded()
	{
		if (_onBannerAdLoadedEvent != null)
		{
			_onBannerAdLoadedEvent();
		}
	}

	public void onBannerAdLoadFailed(string description)
	{
		if (_onBannerAdLoadFailedEvent != null)
		{
			IronSourceError errorFromErrorObject = getErrorFromErrorObject(description);
			_onBannerAdLoadFailedEvent(errorFromErrorObject);
		}
	}

	public void onBannerAdClicked()
	{
		if (_onBannerAdClickedEvent != null)
		{
			_onBannerAdClickedEvent();
		}
	}

	public void onBannerAdScreenPresented()
	{
		if (_onBannerAdScreenPresentedEvent != null)
		{
			_onBannerAdScreenPresentedEvent();
		}
	}

	public void onBannerAdScreenDismissed()
	{
		if (_onBannerAdScreenDismissedEvent != null)
		{
			_onBannerAdScreenDismissedEvent();
		}
	}

	public void onBannerAdLeftApplication()
	{
		if (_onBannerAdLeftApplicationEvent != null)
		{
			_onBannerAdLeftApplicationEvent();
		}
	}

	public void onSegmentReceived(string segmentName)
	{
		if (_onSegmentReceivedEvent != null)
		{
			_onSegmentReceivedEvent(segmentName);
		}
	}

	private IronSourceError getErrorFromErrorObject(object descriptionObject)
	{
		Dictionary<string, object> dictionary = null;
		if (descriptionObject is IDictionary)
		{
			dictionary = descriptionObject as Dictionary<string, object>;
		}
		else if (descriptionObject is string && !string.IsNullOrEmpty(descriptionObject.ToString()))
		{
			dictionary = Json.Deserialize(descriptionObject.ToString()) as Dictionary<string, object>;
		}
		IronSourceError result = new IronSourceError(-1, string.Empty);
		if (dictionary != null && dictionary.Count > 0)
		{
			int errorCode = Convert.ToInt32(dictionary["error_code"].ToString());
			string errorDescription = dictionary["error_description"].ToString();
			result = new IronSourceError(errorCode, errorDescription);
		}
		return result;
	}

	private IronSourcePlacement getPlacementFromObject(object placementObject)
	{
		Dictionary<string, object> dictionary = null;
		if (placementObject is IDictionary)
		{
			dictionary = placementObject as Dictionary<string, object>;
		}
		else if (placementObject is string)
		{
			dictionary = Json.Deserialize(placementObject.ToString()) as Dictionary<string, object>;
		}
		IronSourcePlacement result = null;
		if (dictionary != null && dictionary.Count > 0)
		{
			int rewardAmount = Convert.ToInt32(dictionary["placement_reward_amount"].ToString());
			string rewardName = dictionary["placement_reward_name"].ToString();
			result = new IronSourcePlacement(dictionary["placement_name"].ToString(), rewardName, rewardAmount);
		}
		return result;
	}
}
