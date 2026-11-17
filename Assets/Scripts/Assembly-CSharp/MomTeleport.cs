using System;
using UnityEngine;

[Serializable]
public class MomTeleport : MonoBehaviour
{
	public GameObject mom;

	public Transform teleportPoint;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !((AIfollow)(object)mom.GetComponent(typeof(AIfollow))).seePlayer)
		{
			mom.SetActive(false);
			mom.transform.position = teleportPoint.position;
			mom.SetActive(true);
		}
	}
}
