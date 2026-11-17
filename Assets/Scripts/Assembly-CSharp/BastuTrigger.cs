using System;
using UnityEngine;

[Serializable]
public class BastuTrigger : MonoBehaviour
{
	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
		}
		if (((Component)other).gameObject.tag == "granny")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
		}
		if (((Component)other).gameObject.tag == "granny")
		{
			if (!((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere)
			{
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			}
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
		}
	}
}
