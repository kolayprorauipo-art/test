using System;
using UnityEngine;

[Serializable]
public class plankaHitSpot : MonoBehaviour
{
	public virtual void Start()
	{
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), GameObject.Find("GrannyCantSeeCollider").GetComponent<Collider>(), true);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), GameObject.Find("Player").GetComponent<Collider>(), true);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), GameObject.Find("Main Camera").GetComponent<Collider>(), true);
	}

	public virtual void OnTriggerEnter(Collider other)
	{
	}
}
