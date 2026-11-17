using System;
using UnityEngine;

[Serializable]
public class TriggerBastuOff : MonoBehaviour
{
	public GameObject bastuSteam;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			bastuSteam.SetActive(false);
		}
	}
}
