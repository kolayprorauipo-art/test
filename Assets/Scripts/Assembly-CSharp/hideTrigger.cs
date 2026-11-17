using System;
using UnityEngine;

[Serializable]
public class hideTrigger : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEye;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
		}
	}
}
