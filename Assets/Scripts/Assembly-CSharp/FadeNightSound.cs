using System;
using UnityEngine;

[Serializable]
public class FadeNightSound : MonoBehaviour
{
	public AudioClip nightSound;

	public float volume;

	public bool fading;

	public bool soundLow;

	public bool soundHigh;

	public bool gameStart;

	public virtual void Start()
	{
		gameStart = true;
	}

	public virtual void Update()
	{
		if (soundHigh && ((Component)this).GetComponent<AudioSource>().volume < 0.4f)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.4f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume > 0.4f)
			{
				soundHigh = false;
				((Component)this).GetComponent<AudioSource>().volume = 0.4f;
			}
		}
		if (soundLow && ((Component)this).GetComponent<AudioSource>().volume <= 0.4f)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.4f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume < 0.15f)
			{
				soundLow = false;
				((Component)this).GetComponent<AudioSource>().volume = 0.15f;
			}
		}
		if (soundLow)
		{
			soundHigh = false;
		}
		if (soundHigh)
		{
			soundLow = false;
		}
		if (gameStart)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.05f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume >= 0.4f)
			{
				gameStart = false;
				((Component)this).GetComponent<AudioSource>().volume = 0.4f;
			}
		}
	}

	public virtual void fadeUp()
	{
		soundHigh = true;
	}

	public virtual void fadeDown()
	{
		soundLow = true;
	}

	public virtual void stopAudio()
	{
		((Component)this).GetComponent<AudioSource>().Stop();
	}
}
