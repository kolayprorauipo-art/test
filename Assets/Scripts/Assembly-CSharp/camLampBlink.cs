using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class camLampBlink : MonoBehaviour
{
	public bool startBlink;

	public bool soundOff;

	public Texture red;

	public Texture grey;

	public AudioClip pipljud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startBlink)
		{
			startBlink = false;
			((MonoBehaviour)this).StartCoroutine(blinking());
		}
	}

	public virtual IEnumerator blinking()
	{
		if (!soundOff)
		{
			((Component)this).gameObject.GetComponent<Renderer>().material.mainTexture = grey;
			yield return (object)new WaitForSeconds(0.5f);
			((Component)this).gameObject.GetComponent<Renderer>().material.mainTexture = red;
			if (!soundOff)
			{
				((Component)this).GetComponent<AudioSource>().PlayOneShot(pipljud);
			}
			yield return (object)new WaitForSeconds(0.5f);
			startBlink = true;
		}
		else
		{
			((Component)this).gameObject.GetComponent<Renderer>().material.mainTexture = grey;
		}
	}
}
