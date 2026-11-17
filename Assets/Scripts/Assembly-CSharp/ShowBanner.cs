using UnityEngine;

public class ShowBanner : MonoBehaviour
{
	private void Start()
	{
	}

	public virtual void OnLevelWasLoaded(int level)
	{
		if (level == 1 && PlayerPrefs.GetInt("ADSon") == 0)
		{
			IronSource.Agent.loadBanner(IronSourceBannerSize.SMART, IronSourceBannerPosition.TOP);
			IronSourceEvents.onBannerAdLoadedEvent += BannerAdLoadedEvent;
		}
	}

	private void BannerAdLoadedEvent()
	{
		if (PlayerPrefs.GetInt("ADSon") == 0)
		{
			IronSource.Agent.displayBanner();
		}
	}
}
