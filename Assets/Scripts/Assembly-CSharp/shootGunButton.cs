using System;
using UnityEngine;

[Serializable]
public class shootGunButton : MonoBehaviour
{
	public GameObject shootHolder;

	public void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f)
		{
			((shootGun)(object)shootHolder.GetComponent(typeof(shootGun))).shooting = true;
		}
	}
}
