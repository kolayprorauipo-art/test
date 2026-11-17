using System;
using UnityEngine;

[Serializable]
public class grannySeePlayerTrigger : MonoBehaviour
{
	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny)
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny)
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = true;
		}
	}
}
