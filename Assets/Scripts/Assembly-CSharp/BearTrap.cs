using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BearTrap : MonoBehaviour
{
	public bool beartrapOn;

	public bool beartrapShot;

	public GameObject Granny;

	public startNewDay startNewDayScript;

	public Transform spawnObject;

	public GameObject joystick;

	public AudioClip ObjectLjud;

	public AudioClip BeartrapOnFloor;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject playerHead;

	public GameObject GrannyEye;

	public GameObject crawlButtonParent;

	public GameObject crawlButton;

	public GameObject allBedButtons;

	public float timer;

	public bool timerStart;

	public bool playerStuck;

	public bool yellowBeartTrap;

	public GameObject gameController;

	public float timerAnomaly24;

	public List<GameObject> Anomaly17Items;

	public float timerInvisible;

	public float timerInvisible2;

	public float interval;

	public BearTrap()
	{
		timer = 120f;
	}

	public virtual void Start()
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		startNewDayScript = gameController.GetComponent<startNewDay>();
		timerStart = true;
		timerAnomaly24 = 0f;
		player = startNewDayScript.Player;
		joystick = ((Component)GameObject.Find("OHJoystickParent").transform.GetChild(0)).gameObject;
		footstepScriptHolder = ((Component)gameController.GetComponent<startNewDay>().Player.transform.GetChild(1).GetChild(0).GetChild(0)).gameObject;
		playerHead = ((Component)gameController.GetComponent<startNewDay>().Player.transform.GetChild(1)).gameObject;
		GrannyEye = GameObject.Find("GrannyEyes");
		crawlButtonParent = ((Component)GameObject.Find("OHCrouchButtonParent").transform.GetChild(0)).gameObject;
		crawlButton = ((Component)GameObject.Find("OHCrouchButtonParent").transform.GetChild(0).GetChild(0)).gameObject;
		allBedButtons = GameObject.Find("AllBedButtons");
		if (startNewDayScript.AnomalyNR == 17 || startNewDayScript.PrimeAnomalyNR == 17)
		{
			((MonoBehaviour)this).StartCoroutine(CheckAnomaly17());
		}
		if (((Object)((Component)this).gameObject).name == "BearTrapPrime" || ((Object)((Component)this).gameObject).name == "BearTrapPrimeNotClose" || ((Object)((Component)this).gameObject).name == "BearTrapPrimeDangerZone" || ((Object)((Component)this).gameObject).name == "BearTrapPrimeYellow")
		{
			((MonoBehaviour)this).StartCoroutine(TrapPlace());
		}
		if (((Object)((Component)this).gameObject).name == "BearTrapAnomaly17")
		{
			Physics.IgnoreCollision((Collider)(object)((Component)this).gameObject.GetComponent<BoxCollider>(), player.GetComponent<Collider>(), true);
		}
		if (((Object)((Component)this).gameObject).name == "BearTrapPrimeNotClose")
		{
			if (PlayerPrefs.GetInt("UnknownOnOff") == 0)
			{
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).material.color = Color.blue;
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).material.color = Color.blue;
			}
			else
			{
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).material.color = new Color(0.7f, 0f, 0f);
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).material.color = new Color(0.7f, 0f, 0f);
			}
		}
		if (timerInvisible != 0f)
		{
			((Object)((Component)this).gameObject).name = "BearTrapPrimeDangerZone";
			interval = 7f;
		}
		if (timerInvisible2 != 0f)
		{
			((Object)((Component)this).gameObject).name = "BearTrapPrimeDangerZone";
			interval = 3f;
		}
		if (((Object)((Component)this).gameObject).name == "BearTrapPrimeDangerZone")
		{
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).material.color = Color.red;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).material.color = Color.red;
			((MonoBehaviour)this).StartCoroutine(BeforeInvisible());
		}
		if (((Object)((Component)this).gameObject).name == "BearTrapPrimeYellow")
		{
			yellowBeartTrap = true;
			((Component)this).gameObject.GetComponent<Rigidbody>().constraints = (RigidbodyConstraints)2;
			((Component)this).gameObject.GetComponent<Rigidbody>().constraints = (RigidbodyConstraints)8;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<MeshRenderer>()).material.color = Color.yellow;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).material.color = Color.yellow;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).material.color = Color.yellow;
		}
	}

	public virtual void Update()
	{
		if (yellowBeartTrap)
		{
			if (!startNewDayScript.activateYellowLaser)
			{
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).enabled = false;
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).enabled = false;
			}
			else
			{
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).enabled = true;
				((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).enabled = true;
			}
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && (startNewDayScript.activateYellowLaser || !(((Object)((Component)this).gameObject).name == "BearTrapPrimeYellow")))
		{
			if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInHole)
			{
				if (timerStart && !beartrapOn)
				{
					beartrapOn = true;
					playerStuck = true;
					((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
					((Component)this).gameObject.GetComponent<Animation>().Play("Beartrap");
					((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					player.GetComponent<CharacterController>().height = 2.31f;
					((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
					if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuKilled && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).freeze && GrannyEye.activeSelf)
					{
						((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
					}
					((playerCrawl)(object)crawlButton.GetComponent(typeof(playerCrawl))).PlayerHukarSig = false;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					joystick.SetActive(false);
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					crawlButtonParent.SetActive(false);
					allBedButtons.SetActive(false);
					if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
					{
						((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
						Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					}
					else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
					{
						Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else
					{
						Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					}
					((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
					((Component)((Component)this).gameObject.transform).tag = "BearTrapActivated";
					if (gameController.GetComponent<startNewDay>().AnomalyNR == 24)
					{
						gameController.GetComponent<startNewDay>().Anomaly24PlayerInTrap = true;
					}
					if (((Object)((Component)this).gameObject).name == "BearTrapPrimeDangerZone")
					{
						((Renderer)((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<MeshRenderer>()).enabled = true;
						((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).enabled = true;
						((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).enabled = true;
					}
				}
			}
			else if (!beartrapOn)
			{
				((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
				((Component)this).gameObject.GetComponent<Animation>().Play("Beartrap");
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				beartrapShot = true;
			}
		}
		else if (Time.timeSinceLevelLoad > 10f && !beartrapOn && ((Component)other).gameObject.layer == 12 && !((Object)((Component)other).gameObject).name.Contains("BOMB") && ((Object)((Component)this).gameObject).name != "BearTrapAnomaly17" && ((Object)((Component)this).gameObject).name != "BearTrapPrimeNotClose" && (gameController.GetComponent<startNewDay>().activateYellowLaser || !(((Object)((Component)this).gameObject).name == "BearTrapPrimeYellow")))
		{
			beartrapOn = true;
			timer = 20f;
			((MonoBehaviour)this).StartCoroutine(TrapClose());
		}
	}

	public virtual void beartrapDestroyed()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		if (!beartrapOn && ((Object)((Component)this).gameObject).name != "BearTrapAnomaly17")
		{
			beartrapOn = true;
			timer = 10f;
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			((Component)this).gameObject.GetComponent<Animation>().Play("Beartrap");
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Object)((Component)this).gameObject).name == "BearTrapAnomaly17")
		{
			string[] array = new string[46]
			{
				"vas", "vas2", "hammer", "hanglockkey", "exitkey", "avbitare", "safekey", "weaponkey", "armborst", "arrow",
				"screwdriver", "plankawalk", "battery", "kugg1", "kugg2", "melon", "playhousekey", "shotgun", "book", "specialkey",
				"meat", "wrench", "gascan", "carbattery", "topplock", "sparkplug", "dpadlockCode", "message", "teddy", "brunnsvevpickup",
				"shotgunp1", "shotgunp2", "shotgunp3", "carkey", "pepperspray", "remotecontrol", "birdseed", "vitrindoorLclosed", "vitrindoorLopen", "vitrindoorRclosed",
				"vitrindoorRopen", "spak", "tb1", "tb2", "tb3", "tb4"
			};
			string[] array2 = new string[16]
			{
				"newNightmareBook(Clone)", "newNightmareVase(Clone)", "newNightmareMelon(Clone)", "newNightmareHammer(Clone)", "newBlueKey(Clone)", "newDoorUnlock(Clone)", "newButtonLiftEscape(Clone)", "newNightmareBattery(Clone)", "newNightmareTrap(Clone)", "newNightmareCan(Clone)",
				"newNightmareWeaponKey(Clone)", "newCaramelKey(Clone)", "newChocolateKey(Clone)", "newBoxOfSweets(Clone)", "newNightmareRemote(Clone)", "newTeleportRemote(Clone)"
			};
			bool flag = Array.Exists(array, (string tag) => ((Component)other).gameObject.tag == tag);
			bool flag2 = Array.Exists(array2, (string name) => ((Object)((Component)other).gameObject).name == name);
			if ((flag | flag2) && !Anomaly17Items.Contains(((Component)other).gameObject))
			{
				Anomaly17Items.Add(((Component)other).gameObject);
			}
		}
	}

	public IEnumerator CheckAnomaly17()
	{
		while (true)
		{
			yield return (object)new WaitForSeconds(0.2f);
			if (Anomaly17Items.Count > 2 && !beartrapOn)
			{
				beartrapOn = true;
				((MonoBehaviour)this).StartCoroutine(TrapClose());
				((MonoBehaviour)this).StartCoroutine(Anomaly17TrapDestroy());
			}
			Anomaly17Items.Clear();
		}
	}

	public IEnumerator Anomaly17TrapDestroy()
	{
		yield return (object)new WaitForSeconds(1f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	public IEnumerator TrapPlace()
	{
		yield return (object)new WaitForSeconds(5f);
		((Component)this).GetComponent<Rigidbody>().isKinematic = true;
	}

	public IEnumerator TrapClose()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
		((Component)this).gameObject.GetComponent<Animation>().Play("Beartrap");
		((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
		if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
		{
			((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
			Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
		else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
		}
		else
		{
			Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
		}
	}

	public IEnumerator BeforeInvisible()
	{
		yield return (object)new WaitForSeconds(timerInvisible);
		yield return (object)new WaitForSeconds(timerInvisible2);
		((MonoBehaviour)this).StartCoroutine(DangerZone());
	}

	public IEnumerator DangerZone()
	{
		while (!beartrapOn)
		{
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).enabled = false;
			yield return (object)new WaitForSeconds(interval);
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<MeshRenderer>()).enabled = true;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(1)).GetComponent<MeshRenderer>()).enabled = true;
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).GetComponent<MeshRenderer>()).enabled = true;
			yield return (object)new WaitForSeconds(1f);
		}
	}
}
