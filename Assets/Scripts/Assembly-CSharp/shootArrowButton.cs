using System;
using UnityEngine;

[Serializable]
public class shootArrowButton : MonoBehaviour
{
	public GameObject shootHolder;

	public void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			((ShootArrow)(object)shootHolder.GetComponent(typeof(ShootArrow))).shooting = true;
		}
	}
}
