using System;
using UnityEngine;

[Serializable]
public class playEndMusic : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void play()
	{
		((Component)this).GetComponent<AudioSource>().Play();
	}
}
