using System;
using UnityEngine;

[Serializable]
public class floor1Trigger : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((checkMapFloor)(object)gameController.GetComponent(typeof(checkMapFloor))).playerFloor1 = true;
			((checkMapFloor)(object)gameController.GetComponent(typeof(checkMapFloor))).playerFloor2 = false;
			((checkMapFloor)(object)gameController.GetComponent(typeof(checkMapFloor))).playerFloor3 = false;
		}
	}
}
