using System;
using UnityEngine;

[Serializable]
public class GallerSewerOpen : MonoBehaviour
{
	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			GameController.GetComponent<startNewDay>().SewerGallerOpen = true;
		}
	}
}
