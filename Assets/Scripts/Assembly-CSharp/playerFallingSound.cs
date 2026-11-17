using System;
using UnityEngine;

[Serializable]
public class playerFallingSound : MonoBehaviour
{
	public AudioClip fallWindSound;

	public bool soundPlaying;

	public bool fadingSound;

	public virtual void Update()
	{
		if (!soundPlaying)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 2f * Time.deltaTime;
		}
		if (soundPlaying && fadingSound)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 2.2f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume >= 1f)
			{
				fadingSound = false;
			}
		}
	}

	public virtual void playerFalling()
	{
		if (!soundPlaying)
		{
			((Component)this).GetComponent<AudioSource>().clip = fallWindSound;
			((Component)this).GetComponent<AudioSource>().Play();
			soundPlaying = true;
			fadingSound = true;
		}
	}

	public virtual void playerFallingNot()
	{
		if (soundPlaying)
		{
			soundPlaying = false;
		}
	}
}
