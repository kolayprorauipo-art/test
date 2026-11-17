using System;
using UnityEngine;

[Serializable]
public class batsTrigger : MonoBehaviour
{
	public GameObject NOS;

	public GameObject nextTrigger;

	public GameObject bats;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((AIfollow)(object)NOS.GetComponent(typeof(AIfollow))).seePlayer = true;
			((AIfollow)(object)NOS.GetComponent(typeof(AIfollow))).FollowPlayer = true;
			bats.SetActive(true);
			nextTrigger.SetActive(true);
			((Component)this).gameObject.SetActive(false);
		}
	}
}
