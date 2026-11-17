using System;
using UnityEngine;

[Serializable]
public class TriggerU : MonoBehaviour
{
	public GameObject plattaU;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "platta")
		{
			((plattaflyttas)(object)plattaU.GetComponent(typeof(plattaflyttas))).Upp = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "platta")
		{
			((plattaflyttas)(object)plattaU.GetComponent(typeof(plattaflyttas))).Upp = true;
		}
	}
}
