using System;
using UnityEngine;

[Serializable]
public class crawlHoleTrigger : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEyes;

	public GameObject crouchButton;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = true;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
			crouchButton.SetActive(false);
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			crouchButton.SetActive(true);
		}
	}
}
