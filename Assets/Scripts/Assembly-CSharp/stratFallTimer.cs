using System;
using UnityEngine;

[Serializable]
public class stratFallTimer : MonoBehaviour
{
	public GameObject player;

	public GameObject Sound1;

	public GameObject Sound2;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && PlayerPrefs.GetInt("PrimeOn") == 1)
		{
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).fallTimerStarted = true;
			((backgroundSound)(object)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
			((backgroundSound)(object)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		}
		if (((Object)((Component)other).gameObject).name == "newBoxOfSweets(Clone)")
		{
			((Component)other).GetComponent<BoxOfSweetsFall>().StartFall = true;
		}
	}
}
