using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class explodeTrigger : MonoBehaviour
{
	public GameObject Granny;

	public GameObject gameController;

	public bool grannyHit;

	public bool Achievement;

	public virtual IEnumerator Start()
	{
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		yield return (object)new WaitForSeconds(1f);
		grannyHit = true;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (grannyHit)
		{
			return;
		}
		if (((Component)other).gameObject.tag == "granny" && PlayerPrefs.GetInt("DiffData") != 7)
		{
			if (Achievement)
			{
				AchievementSaveManager.Instance.UnlockAchievement("TheBigRedItem");
			}
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			grannyHit = true;
		}
		else if (((Component)other).gameObject.tag == "Player")
		{
			((playerCaught)(object)((Component)other).GetComponent(typeof(playerCaught))).explodingPlayer = true;
			((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).playerIsDying = true;
			((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).stuckTimer();
			grannyHit = true;
		}
	}
}
