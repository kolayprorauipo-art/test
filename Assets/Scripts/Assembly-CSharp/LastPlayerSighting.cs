using System;
using UnityEngine;

[Serializable]
public class LastPlayerSighting : MonoBehaviour
{
	public Vector3 position;

	public Vector3 resetPosition;

	public float lightHighIntensity;

	public float lightLowIntensity;

	public float fadeSpeed;

	public float musicFadeSpeed;

	private Light mainLight;

	private AudioSource panicAudio;

	private AudioSource[] sirens;

	public LastPlayerSighting()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		position = new Vector3(1000f, 1000f, 1000f);
		resetPosition = new Vector3(1000f, 1000f, 1000f);
		lightHighIntensity = 0.25f;
		fadeSpeed = 7f;
		musicFadeSpeed = 1f;
	}

	public virtual void Awake()
	{
	}

	public virtual void Update()
	{
		SwitchAlarms();
		MusicFading();
	}

	public virtual void SwitchAlarms()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (position != resetPosition)
		{
			_ = lightLowIntensity;
		}
		else
		{
			_ = lightHighIntensity;
		}
	}

	public virtual void MusicFading()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ = position != resetPosition;
	}
}
