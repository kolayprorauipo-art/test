using System;
using UnityEngine;

[Serializable]
public class backgroundSound : MonoBehaviour
{
	public bool fadeUp;

	public bool fadeDown;

	public AudioClip knappLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (fadeUp)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + Time.deltaTime * 0.3f;
			if (((Component)this).GetComponent<AudioSource>().volume > 0.1f)
			{
				fadeUp = false;
				((Component)this).GetComponent<AudioSource>().volume = 0.1f;
			}
		}
		if (fadeDown)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - Time.deltaTime * 0.3f;
			if (((Component)this).GetComponent<AudioSource>().volume == 0f)
			{
				fadeDown = false;
				((Component)this).GetComponent<AudioSource>().volume = 0f;
			}
		}
		if (fadeUp)
		{
			fadeDown = false;
		}
		else if (fadeDown)
		{
			fadeUp = false;
		}
	}

	public virtual void buttonClick()
	{
		((Component)this).GetComponent<AudioSource>().PlayOneShot(knappLjud);
	}
}
