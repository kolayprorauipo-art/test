using System;
using UnityEngine;

[Serializable]
public class PlayMusic : MonoBehaviour
{
	public AudioClip screenSound;

	public float volume;

	public bool fading;

	public virtual void Start()
	{
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void fadeUp()
	{
		((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
	}

	public virtual void fadeDown()
	{
		((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.2f * Time.deltaTime;
	}

	public virtual void stopAudio()
	{
		((Component)this).GetComponent<AudioSource>().Stop();
	}
}
