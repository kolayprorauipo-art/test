using System;
using UnityEngine;

[Serializable]
public class teleportAwayTrigger : MonoBehaviour
{
	public Transform teleportPointNOS;

	public GameObject NOS;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Maniac")
		{
			NOS.transform.position = teleportPointNOS.position;
		}
	}
}
