using System;
using UnityEngine;

[Serializable]
public class hideCrouchButton : MonoBehaviour
{
	public GameObject crouchButton;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			crouchButton.SetActive(false);
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			crouchButton.SetActive(true);
		}
	}
}
