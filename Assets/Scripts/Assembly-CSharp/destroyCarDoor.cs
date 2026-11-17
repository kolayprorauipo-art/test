using System;
using UnityEngine;

[Serializable]
public class destroyCarDoor : MonoBehaviour
{
	public float brokenCardoorTimer;

	public bool destroyBrokenCardorr;

	public destroyCarDoor()
	{
		brokenCardoorTimer = 20f;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (destroyBrokenCardorr)
		{
			brokenCardoorTimer -= Time.deltaTime;
			if (brokenCardoorTimer <= 0f)
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
		}
	}
}
