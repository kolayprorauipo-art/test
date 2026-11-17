using System;
using UnityEngine;

[Serializable]
public class soundEffects2 : MonoBehaviour
{
	public AudioClip sword;

	public AudioClip pain;

	public AudioClip die;

	public virtual void Start()
	{
		((Component)this).GetComponent<AudioSource>().clip = sword;
	}

	public virtual void swordSwing()
	{
		((Component)this).GetComponent<AudioSource>().clip = sword;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void slendrinaPain()
	{
		((Component)this).GetComponent<AudioSource>().clip = pain;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void slendrinaDie()
	{
		((Component)this).GetComponent<AudioSource>().clip = die;
		((Component)this).GetComponent<AudioSource>().Play();
	}
}
