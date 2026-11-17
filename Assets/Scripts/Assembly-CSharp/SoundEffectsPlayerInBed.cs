using System;
using UnityEngine;

[Serializable]
public class SoundEffectsPlayerInBed : MonoBehaviour
{
	public AudioClip startText;

	public virtual void Start()
	{
	}

	public virtual void startTextSound()
	{
		((Component)this).GetComponent<AudioSource>().clip = startText;
		((Component)this).GetComponent<AudioSource>().Play();
	}
}
