using System;
using UnityEngine;

[Serializable]
public class bedTrigger : MonoBehaviour
{
	public GameObject button;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			button.SetActive(true);
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			button.SetActive(false);
		}
	}
}
