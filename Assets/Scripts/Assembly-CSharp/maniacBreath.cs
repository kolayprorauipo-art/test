using System;
using UnityEngine;

[Serializable]
public class maniacBreath : MonoBehaviour
{
	public AudioClip breathSlow;

	public AudioClip breathFast;

	public AudioClip hurt;

	public AudioClip freezed;

	public virtual void Start()
	{
		AudioSource component = ((Component)this).GetComponent<AudioSource>();
		((Component)this).GetComponent<AudioSource>().Play();
		component.clip = breathSlow;
	}

	public virtual void stopAudio()
	{
	}

	public virtual void maniacBreathSlow()
	{
		((Component)this).GetComponent<AudioSource>().clip = breathSlow;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void maniacBreathFast()
	{
		((Component)this).GetComponent<AudioSource>().clip = breathFast;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void maniachurt()
	{
		((Component)this).GetComponent<AudioSource>().clip = hurt;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void maniafreezed()
	{
		((Component)this).GetComponent<AudioSource>().clip = freezed;
		((Component)this).GetComponent<AudioSource>().Play();
	}
}
