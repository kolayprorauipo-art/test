using System;
using UnityEngine;

[Serializable]
public class PlayVideoAds : MonoBehaviour
{
	public virtual void OnLevelWasLoaded(int level)
	{
		if (level == 0)
		{
			Time.timeScale = 1f;
			AudioListener.volume = 1f;
			AudioListener.pause = false;
		}
	}
}
