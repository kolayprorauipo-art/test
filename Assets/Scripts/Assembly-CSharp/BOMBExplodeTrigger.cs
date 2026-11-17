using System.Collections;
using UnityEngine;

public class BOMBExplodeTrigger : MonoBehaviour
{
	public GameObject gameController;

	public bool playerHit;

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		yield return (object)new WaitForSeconds(1f);
		playerHit = true;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (!playerHit && ((Component)other).gameObject.tag == "Player" && PlayerPrefs.GetInt("PrimeOn") == 1 && ((Component)this).transform.position.y < ((Component)other).transform.GetChild(1).GetChild(0).GetChild(0)
			.position.y)
		{
			AchievementSaveManager.Instance.UnlockAchievement("AuraLoss");
			((playerCaught)(object)((Component)other).GetComponent(typeof(playerCaught))).explodingPlayer = true;
			((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).stuckTimer();
			playerHit = true;
			((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
			((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		}
	}
}
