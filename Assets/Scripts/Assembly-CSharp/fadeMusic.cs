using System;
using UnityEngine;

[Serializable]
public class fadeMusic : MonoBehaviour
{
	public AudioClip Music;

	public AudioClip BookMusic;

	public float volume;

	public bool fading;

	public bool playMusic;

	public bool musicOn;

	public bool momHunting;

	public bool stopFade;

	public virtual void Update()
	{
		if (playMusic)
		{
			if (!musicOn)
			{
				musicOn = true;
				((Component)this).GetComponent<AudioSource>().Play();
			}
		}
		else if (!playMusic && musicOn)
		{
			musicOn = false;
			((Component)this).GetComponent<AudioSource>().Stop();
		}
		if (momHunting)
		{
			if (!stopFade)
			{
				((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.2f * Time.deltaTime;
				if (((Component)this).GetComponent<AudioSource>().volume <= 0f)
				{
					stopFade = true;
					((Component)this).GetComponent<AudioSource>().volume = 0f;
					playMusic = false;
				}
			}
		}
		else if (!momHunting && stopFade)
		{
			playMusic = true;
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume > 0.3f)
			{
				stopFade = false;
				((Component)this).GetComponent<AudioSource>().volume = 0.3f;
			}
		}
	}
}
