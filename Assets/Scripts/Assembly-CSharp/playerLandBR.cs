using System;
using UnityEngine;

[Serializable]
public class playerLandBR : MonoBehaviour
{
	public GameObject soundHolder;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).playerLandBRSound();
			((Component)this).gameObject.SetActive(false);
		}
	}
}
