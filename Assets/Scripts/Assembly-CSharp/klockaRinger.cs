using System;
using UnityEngine;

[Serializable]
public class klockaRinger : MonoBehaviour
{
	public bool startKlock;

	public AudioClip klockljud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startKlock)
		{
			startKlock = false;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(klockljud);
			((Component)this).gameObject.GetComponent<Animation>().Play("Klocka");
		}
	}
}
