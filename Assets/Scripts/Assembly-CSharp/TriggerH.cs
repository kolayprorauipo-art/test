using System;
using UnityEngine;

[Serializable]
public class TriggerH : MonoBehaviour
{
	public GameObject plattaH;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "platta")
		{
			((plattaflyttas)(object)plattaH.GetComponent(typeof(plattaflyttas))).H = false;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "platta")
		{
			((plattaflyttas)(object)plattaH.GetComponent(typeof(plattaflyttas))).H = true;
		}
	}
}
