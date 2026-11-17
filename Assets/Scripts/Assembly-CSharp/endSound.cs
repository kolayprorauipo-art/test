using System;
using UnityEngine;

[Serializable]
public class endSound : MonoBehaviour
{
	public AudioClip playerEnd;

	public virtual void Start()
	{
		RenderSettings.fog = false;
	}

	public virtual void startEndSound()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(playerEnd, ((Component)this).transform.position);
	}
}
