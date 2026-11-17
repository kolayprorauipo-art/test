using System;
using UnityEngine;

[Serializable]
public class FadeHuntMusic : MonoBehaviour
{
	public AudioClip huntingMusic;

	public AudioClip fightSlendrinaMusic;

	public AudioClip headHuntMusic;

	public AudioClip bookMusic;

	public float volume;

	public bool fading;

	public bool playMusic;

	public bool musicOn;

	public bool momHunt;

	public bool stopFade;

	public GameObject musicHolder;

	public virtual void Start()
	{
		((Component)this).GetComponent<AudioSource>().clip = huntingMusic;
	}

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
		if (momHunt)
		{
			if (!stopFade)
			{
				playMusic = true;
				((fadeMusic)(object)musicHolder.GetComponent(typeof(fadeMusic))).momHunting = true;
				((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.3f * Time.deltaTime;
				if (((Component)this).GetComponent<AudioSource>().volume > 0.5f)
				{
					stopFade = true;
					((Component)this).GetComponent<AudioSource>().volume = 0.5f;
				}
			}
		}
		else if (!momHunt && stopFade)
		{
			((fadeMusic)(object)musicHolder.GetComponent(typeof(fadeMusic))).momHunting = false;
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume <= 0f)
			{
				stopFade = false;
				((Component)this).GetComponent<AudioSource>().volume = 0f;
				playMusic = false;
			}
		}
	}

	public virtual void fightSlendrina()
	{
		((Component)this).GetComponent<AudioSource>().clip = fightSlendrinaMusic;
	}

	public virtual void NotfightSlendrina()
	{
		((Component)this).GetComponent<AudioSource>().clip = huntingMusic;
	}

	public virtual void headHuntStarts()
	{
		((Component)this).GetComponent<AudioSource>().clip = headHuntMusic;
	}

	public virtual void bookMusicStarts()
	{
		((Component)this).GetComponent<AudioSource>().clip = bookMusic;
		((Component)this).GetComponent<AudioSource>().loop = false;
	}
}
