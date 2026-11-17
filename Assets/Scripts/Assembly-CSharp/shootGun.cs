using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class shootGun : MonoBehaviour
{
	public GameObject SeeRay1;

	public GameObject Granny;

	public GameObject playerShootAnim;

	public bool shooting;

	public GameObject shootButton;

	public int power;

	public GameObject ammoCheckHolder;

	public GameObject shotgunAnim;

	public GameObject soundHolder;

	public Transform grannyHearSound;

	public GameObject noiceDP;

	public Vector3 velocity;

	public GameObject Spider;

	public bool shootingOnGascan;

	public GameObject rat1;

	public GameObject rat2;

	public GameObject crow;

	public GameObject crowBurDead;

	public GameObject crowEatDead;

	public GameObject Skjutplatta;

	public int Anomaly20NR;

	public GameObject gameController;

	public shootGun()
	{
		power = 500;
	}

	public virtual void ShootButton()
	{
		shooting = true;
	}

	public virtual void Start()
	{
		gameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = SeeRay1.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(SeeRay1.transform.position, SeeRay1.transform.forward, Color.green);
		if (shooting)
		{
			shooting = false;
			shotgunAnim.GetComponent<Animation>().Play("Shoot");
			playerShootAnim.GetComponent<Animation>().Play("shootGun");
			shootButton.SetActive(false);
			((PickUp)(object)ammoCheckHolder.GetComponent(typeof(PickUp))).oldShotgunLoaded = false;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).GunShoot();
			Object.Instantiate<Transform>(grannyHearSound, noiceDP.transform.position, noiceDP.transform.rotation);
			if (!Physics.Raycast(SeeRay1.transform.position, val2, ref val, 26f))
			{
				return;
			}
			if (Object.op_Implicit((Object)(object)val.rigidbody))
			{
				val.rigidbody.AddForceAtPosition(val2 * (float)power, val.point);
			}
			if (((Component)val.collider).gameObject.tag == "granny" && PlayerPrefs.GetInt("DiffData") != 7)
			{
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18)
				{
					((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).GreenKeyDropAnomaly18();
				}
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			}
			else if (((Component)val.collider).gameObject.tag == "beartrap")
			{
				((BearTrap)(object)((Component)val.collider).gameObject.GetComponent(typeof(BearTrap))).beartrapDestroyed();
			}
			else if (((Component)val.collider).gameObject.tag == "shootbutton")
			{
				((shootSpiderButton)(object)((Component)val.collider).gameObject.GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
			}
			else if (((Component)val.collider).gameObject.tag == "spidernest" && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
			}
			else if (((Component)val.collider).gameObject.tag == "Spider")
			{
				((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderIsDead();
			}
			else if (((Component)val.collider).gameObject.tag == "gascan" && PlayerPrefs.GetInt("PrimeOn") == 1 && gameController.GetComponent<startNewDay>().PrimeAnomalyNR != 18)
			{
				if (!shootingOnGascan)
				{
					shootingOnGascan = true;
					((explode)(object)((Component)val.collider).gameObject.GetComponent(typeof(explode))).explodeNow();
				}
			}
			else if (((Component)val.collider).gameObject.tag == "rat1")
			{
				((ratController)(object)rat1.GetComponent(typeof(ratController))).Waittimer = 100f;
			}
			else if (((Object)((Component)val.collider).gameObject).name == "ShootStoolAchievement")
			{
				AchievementSaveManager.Instance.UnlockAchievement("ShootStool");
			}
			else if (((Component)val.collider).gameObject.tag == "rat2")
			{
				((ratController)(object)rat2.GetComponent(typeof(ratController))).Waittimer = 100f;
			}
			else if (((Component)val.collider).gameObject.tag == "burdoor")
			{
				((CrowControl)(object)crow.GetComponent(typeof(CrowControl))).shootInBur = true;
			}
			else if (((Component)val.collider).gameObject.tag == "crowbur")
			{
				crow.SetActive(false);
				crowBurDead.SetActive(true);
				if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
				{
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
				}
			}
			else if (((Component)val.collider).gameObject.tag == "croweat")
			{
				crow.SetActive(false);
				crowEatDead.SetActive(true);
				if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
				{
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = true;
				}
			}
			else if (((Component)val.collider).gameObject.tag == "skjutplatta")
			{
				((SkjutplattaDoor)(object)Skjutplatta.GetComponent(typeof(SkjutplattaDoor))).doorUnlocked = true;
			}
			else if (((Object)((Component)val.collider).gameObject).name == "SecretButtonAnomaly18")
			{
				GameObject.Find("Galler").GetComponent<Rigidbody>().isKinematic = false;
				((Behaviour)GameObject.Find("Galler").GetComponent<disableKinematic>()).enabled = false;
			}
		}
		else
		{
			shooting = false;
		}
	}

	public virtual void Anomaly20DoorDestroy()
	{
	}

	public virtual IEnumerator Blink()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.red;
		yield return (object)new WaitForSeconds(0.2f);
		((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
	}
}
