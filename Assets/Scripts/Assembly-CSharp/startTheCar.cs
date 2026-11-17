using System;
using UnityEngine;

[Serializable]
public class startTheCar : MonoBehaviour
{
	public GameObject gameController;

	public virtual void Update()
	{
		if (Input.GetKeyDown((KeyCode)101))
		{
			((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).startCar();
		}
	}
}
