using System;
using UnityEngine;

[Serializable]
public class LoadVideos : MonoBehaviour
{
	public virtual void Start()
	{
		AudioListener.volume = 1f;
		AudioListener.pause = false;
	}
}
