using System;
using UnityEngine;

[Serializable]
public class TeleportMonster : MonoBehaviour
{
	public GameObject monster;

	public Transform teleportPoint;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !((AIfollow)(object)monster.GetComponent(typeof(AIfollow))).seePlayer)
		{
			monster.SetActive(false);
			monster.transform.position = teleportPoint.position;
			monster.SetActive(true);
		}
	}
}
