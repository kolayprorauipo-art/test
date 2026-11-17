using System;
using UnityEngine;

[Serializable]
public class pressOpenDoor : MonoBehaviour
{
	public openDoors ray;

	private void Update()
	{
		if (Input.GetKeyDown((KeyCode)101))
		{
			ray.PressOpenDoors();
		}
	}
}
