using System;
using UnityEngine;

[Serializable]
public class boxFall : MonoBehaviour
{
	public AudioClip boxLjud;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Terrain")
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(boxLjud);
		}
	}
}
