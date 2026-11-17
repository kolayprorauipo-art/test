using System;
using UnityEngine;

[Serializable]
public class TriggerBats : MonoBehaviour
{
	public GameObject bats;

	public GameObject triggerHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "floor")
		{
			bats.SetActive(true);
			Object.Destroy((Object)(object)triggerHolder);
		}
	}
}
