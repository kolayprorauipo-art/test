using System;
using UnityEngine;

[Serializable]
public class soundEffectsMenu : MonoBehaviour
{
	public AudioClip knappLjud;

	public virtual void Start()
	{
		Time.timeScale = 1f;
		AudioListener.pause = false;
		AudioListener.volume = 1f;
	}

	public virtual void buttonClick()
	{
		((Component)this).GetComponent<AudioSource>().PlayOneShot(knappLjud);
	}
}
