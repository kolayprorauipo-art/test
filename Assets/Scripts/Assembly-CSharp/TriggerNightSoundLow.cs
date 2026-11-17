using System;
using UnityEngine;

[Serializable]
public class TriggerNightSoundLow : MonoBehaviour
{
	public GameObject nightSoundHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((FadeNightSound)(object)nightSoundHolder.GetComponent(typeof(FadeNightSound))).fadeDown();
		}
	}
}
