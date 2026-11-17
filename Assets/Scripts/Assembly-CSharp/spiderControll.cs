using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class spiderControll : MonoBehaviour
{
	public GameObject gameController;

	public bool playerCaught;

	public bool spiderDead;

	public GameObject spiderParent;

	public Transform spiderStartPosition;

	public Transform spiderPlayerPosition;

	public bool huntPlayer;

	public bool foodTime;

	public float spiderDeadTimer;

	public float spiderEatTimer;

	public float beforeBackToNestTimer;

	public bool spiderStartEat;

	public bool SpiderBitePlayer;

	public Transform PlayerPos;

	public GameObject Player;

	public GameObject Granny;

	public Transform FoodPlate;

	public float spiderSpeed;

	public Animator spider2AnimHolder;

	public GameObject foodCollider;

	public GameObject playerCollider;

	public float damping;

	public bool soundSeePlayed;

	public bool soundAttackPlayed;

	public bool spiderResetNow;

	public bool spiderRunToNest;

	public bool spiderBackoff;

	public bool spiderInNest;

	public GameObject soundEffectHolder;

	public GameObject playerHukaKnapp;

	public GameObject playerHukaKnappParent;

	public GameObject inactivateSpider;

	public GameObject inactivateSpiderTrigger;

	public GameObject spiderTrigger2;

	public GameObject meatOnPlate;

	public GameObject leavetrigger;

	public Transform spiderNestPosition;

	public Transform spiderNotHuntPosition;

	public bool VeganAchievement;

	public spiderControll()
	{
		spiderDeadTimer = 8f;
		spiderInNest = true;
	}

	public virtual void Start()
	{
		spider2AnimHolder = ((Component)spider2AnimHolder).gameObject.GetComponent<Animator>();
		spider2AnimHolder.Play("idle");
	}

	public virtual void Update()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		if (!spiderDead)
		{
			if (!spiderResetNow)
			{
				if (huntPlayer && !playerCaught)
				{
					spiderInNest = false;
					((Component)this).transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
					Vector3 val = PlayerPos.position - ((Component)this).transform.position;
					val.y = 0f;
					Quaternion val2 = Quaternion.LookRotation(val);
					((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, val2, Time.deltaTime * damping);
					foodCollider.SetActive(false);
					playerCollider.SetActive(true);
					running();
					if (!soundSeePlayed)
					{
						soundSeePlayed = true;
						((spiderSoundEffects)(object)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderSeePlayer();
					}
				}
				if (foodTime)
				{
					spiderInNest = false;
					((Component)this).transform.Translate(Vector3.forward * Time.deltaTime * 10f);
					((Component)this).transform.LookAt(FoodPlate);
					foodCollider.SetActive(true);
					playerCollider.SetActive(false);
					running();
				}
			}
			if (spiderResetNow && !spiderStartEat && !huntPlayer)
			{
				((Component)this).transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
				Vector3 val3 = spiderNotHuntPosition.position - ((Component)this).transform.position;
				val3.y = 0f;
				Quaternion val4 = Quaternion.LookRotation(val3);
				((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, val4, Time.deltaTime * damping);
				foodCollider.SetActive(true);
				playerCollider.SetActive(false);
				running();
			}
			if (spiderRunToNest && !spiderStartEat && !huntPlayer)
			{
				((Component)this).transform.Translate(Vector3.forward * Time.deltaTime * spiderSpeed);
				Vector3 val5 = spiderNestPosition.position - ((Component)this).transform.position;
				val5.y = 0f;
				Quaternion val6 = Quaternion.LookRotation(val5);
				((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, val6, Time.deltaTime * damping);
				foodCollider.SetActive(true);
				playerCollider.SetActive(false);
				running();
			}
		}
		if (spiderDead)
		{
			spiderDeadTimer -= Time.deltaTime;
			if (spiderDeadTimer <= 0f)
			{
				inactivateSpider.SetActive(false);
				inactivateSpiderTrigger.SetActive(false);
			}
		}
		if (spiderStartEat)
		{
			spiderEatTimer += Time.deltaTime;
			if (spiderEatTimer >= 10f)
			{
				spiderStartEat = false;
				spiderTrigger2.SetActive(true);
				meatOnPlate.SetActive(false);
				spiderRunToNest = true;
			}
		}
		if (spiderBackoff)
		{
			beforeBackToNestTimer += Time.deltaTime;
			if (beforeBackToNestTimer >= 7f)
			{
				spiderBackoff = false;
				beforeBackToNestTimer = 0f;
				spiderRunToNest = true;
			}
		}
	}

	public virtual void running()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("Walk");
		}
	}

	public virtual void attack()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("attack");
			playerDead();
		}
	}

	public virtual void idle()
	{
		if (!spiderDead)
		{
			spider2AnimHolder.Play("idle");
		}
	}

	public virtual void playerDead()
	{
		if (!spiderDead && !SpiderBitePlayer)
		{
			if (VeganAchievement)
			{
				AchievementSaveManager.Instance.UnlockAchievement("VeganActivist");
			}
			foodCollider.SetActive(false);
			SpiderBitePlayer = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
			huntPlayer = false;
			spider2AnimHolder.Play("attack");
			((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
			playerHukaKnappParent.SetActive(false);
			if (!soundAttackPlayed)
			{
				soundAttackPlayed = true;
				((spiderSoundEffects)(object)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderAttackPlayer();
				((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerBiten();
			}
			((MonoBehaviour)this).StartCoroutine(spiderToStartPos());
		}
	}

	public virtual IEnumerator spiderToStartPos()
	{
		if (!spiderDead)
		{
			yield return (object)new WaitForSeconds(1f);
			spiderParent.transform.position = spiderPlayerPosition.position;
			spiderParent.transform.rotation = spiderPlayerPosition.rotation;
			yield return (object)new WaitForSeconds(7f);
			spiderParent.transform.position = spiderStartPosition.position;
			spiderParent.transform.rotation = spiderStartPosition.rotation;
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(false);
			inactivateSpiderTrigger.SetActive(true);
			spider2AnimHolder.Play("idle");
		}
	}

	public virtual void grannyCaughtPlayer()
	{
		if (!spiderDead)
		{
			playerCaught = true;
			spider2AnimHolder.Play("idle");
			spiderInNest = true;
			SpiderBitePlayer = false;
			soundSeePlayed = false;
			soundAttackPlayed = false;
			spiderTrigger2.SetActive(false);
			inactivateSpiderTrigger.SetActive(true);
		}
	}

	public virtual void grannyCaughtPlayerReset()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		spiderParent.transform.position = spiderStartPosition.position;
		spiderParent.transform.rotation = spiderStartPosition.rotation;
		playerCaught = false;
		huntPlayer = false;
		spider2AnimHolder.Play("idle");
	}

	public virtual void spiderIsDead()
	{
		spiderDead = true;
		spider2AnimHolder.Play("die");
		SpiderBitePlayer = false;
		soundSeePlayed = false;
		soundAttackPlayed = false;
		foodCollider.SetActive(false);
		playerCollider.SetActive(false);
		spiderTrigger2.SetActive(false);
		if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn && PlayerPrefs.GetInt("PrimeOn") == 1)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
		}
		leavetrigger.SetActive(false);
		((spiderSoundEffects)(object)soundEffectHolder.GetComponent(typeof(spiderSoundEffects))).spiderDie();
	}
}
