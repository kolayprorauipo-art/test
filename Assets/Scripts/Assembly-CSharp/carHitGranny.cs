using System;
using UnityEngine;

[Serializable]
public class carHitGranny : MonoBehaviour
{
	public bool noMoreHit;

	public GameObject Granny;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "granny" && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar && !noMoreHit)
		{
			noMoreHit = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar = true;
		}
	}
}
