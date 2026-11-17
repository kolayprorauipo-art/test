using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UseRemote : MonoBehaviour
{
	public GameObject SeeRay;

	public GameObject doorLock;

	public Renderer lamp;

	public GameObject doorLockCollider;

	public GameObject lockSound;

	public GameObject door;

	public GameObject doorLockOpen;

	public GameObject doorLockClosed;

	public GameObject soundHolder;

	public GameObject GameController;

	public GameObject NoicePoint;

	public CharacterController PlayerController;

	public bool doorUnlocked;

	public Button btn1;

	public int RandomTeleport;

	public bool GasCanExploded;

	public virtual void Start()
	{
		PlayerController = GameObject.Find("Player").GetComponent<CharacterController>();
	}

	public virtual void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f && PlayerPrefs.GetInt("EventChallenge3") == 0)
		{
			UseRemoteButton();
		}
	}

	public void UseRemoteButton()
	{
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, GameObject.Find("Player").transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, GameObject.Find("Player").transform.position, ((Component)this).transform.rotation);
			}
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			if (!((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).hintIsActive)
			{
				((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).hintIsActive = true;
				((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).hintUse++;
			}
			return;
		}
		if (((remoteLocktrigger)(object)doorLock.GetComponent(typeof(remoteLocktrigger))).playerNearDoorLock && GameController.GetComponent<InventoryController>().haveremote)
		{
			if (!doorUnlocked)
			{
				doorUnlocked = true;
				door.gameObject.tag = "smalldoorClosed";
				doorLockOpen.SetActive(true);
				doorLockClosed.SetActive(false);
				doorLockCollider.SetActive(false);
				lockSound.SetActive(true);
				lamp.enabled = false;
			}
		}
		else if (((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveTVRemote && ((remoteLocktrigger)(object)GameObject.Find("TVArea").GetComponent(typeof(remoteLocktrigger))).playerNearDoorLock)
		{
			((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).channelCount++;
		}
		else if (((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveremote && ((remoteLocktrigger)(object)GameObject.Find("BlueKeyArea").GetComponent(typeof(remoteLocktrigger))).playerNearDoorLock)
		{
			((MonoBehaviour)this).StartCoroutine(GetBlueKey());
		}
		else if (((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveTeleportRemote && PlayerController.height != 2.31f)
		{
			if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 19)
			{
				RandomTeleport++;
				if (RandomTeleport == 10)
				{
					RandomTeleport = 1;
				}
				if (RandomTeleport == 1)
				{
					GameObject.Find("Player").transform.position = new Vector3(5.43f, 8.2f, 8.57f);
				}
				if (RandomTeleport == 2)
				{
					GameObject.Find("Player").transform.position = new Vector3(25.75f, 12.7f, -25.13f);
					GameObject.Find("OutsideSound").GetComponent<backgroundSound>().fadeUp = true;
					GameObject.Find("BackgroundNoise").GetComponent<backgroundSound>().fadeDown = true;
				}
				if (RandomTeleport == 3)
				{
					GameObject.Find("Player").transform.position = new Vector3(9.59f, 14.22f, 6.09f);
					GameObject.Find("OutsideSound").GetComponent<backgroundSound>().fadeDown = true;
					GameObject.Find("BackgroundNoise").GetComponent<backgroundSound>().fadeUp = true;
				}
				if (RandomTeleport == 4)
				{
					GameObject.Find("Player").transform.position = new Vector3(-19.8f, 14.22f, -3.1f);
				}
				if (RandomTeleport == 5)
				{
					GameObject.Find("Player").transform.position = new Vector3(0.085f, 7.9f, -16.26f);
				}
				if (RandomTeleport == 6)
				{
					GameObject.Find("Player").transform.position = new Vector3(7.95f, 7.9f, -29.66f);
				}
				if (RandomTeleport == 7)
				{
					GameObject.Find("Player").transform.position = new Vector3(9.63f, 27.65f, -4.31f);
					GameObject.Find("VindSound").GetComponent<backgroundSound>().fadeUp = true;
					GameObject.Find("BackgroundNoise").GetComponent<backgroundSound>().fadeDown = true;
				}
				if (RandomTeleport == 8)
				{
					GameObject.Find("Player").transform.position = new Vector3(-9.36f, 34.25f, -6.82f);
				}
				if (RandomTeleport == 9)
				{
					GameObject.Find("Player").transform.position = new Vector3(-19.11f, 20.79f, 4.84f);
					GameObject.Find("VindSound").GetComponent<backgroundSound>().fadeDown = true;
					GameObject.Find("BackgroundNoise").GetComponent<backgroundSound>().fadeUp = true;
				}
			}
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				RandomTeleport++;
				if (RandomTeleport == 3)
				{
					RandomTeleport = 1;
				}
				if (RandomTeleport == 1)
				{
					GameObject.Find("Player").transform.position = new Vector3(-13.35f, 14.22f, 0.59f);
				}
				if (RandomTeleport == 2)
				{
					GameObject.Find("Player").transform.position = new Vector3(15.33f, 20.41f, -7.16f);
				}
			}
		}
		else if (((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveNightmareCan)
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<GameObject>(NoicePoint, GameObject.FindGameObjectWithTag("gascan").transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<GameObject>(NoicePoint, GameObject.FindGameObjectWithTag("gascan").transform.position, ((Component)this).transform.rotation);
			}
			((explode)(object)GameObject.FindGameObjectWithTag("gascan").GetComponent(typeof(explode))).NightmareCanExplode();
		}
		else if (((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveNightmareRemote)
		{
			NightmareRemoteUse();
		}
		else
		{
			SeeRay.GetComponent<PickUp>().ShowText2("I need to get closer");
		}
		if (!((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).haveNightmareCan)
		{
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).clickRemote();
		}
	}

	public IEnumerator GetBlueKey()
	{
		((Object)GameObject.Find("BlueKey")).name = "BlueKeyisFalling";
		GameObject.Find("BlueKeyisFalling").GetComponent<Rigidbody>().isKinematic = false;
		yield return (object)new WaitForSeconds(0.3f);
		if (Object.op_Implicit((Object)(object)GameObject.Find("BlueKeyisFalling")))
		{
			((Object)GameObject.Find("BlueKeyisFalling")).name = "newBlueKey(Clone)";
		}
	}

	public void NightmareRemoteUse()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = SeeRay.transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(SeeRay.transform.position, val2, ref val, 26f) && PlayerController.height != 2.31f)
		{
			if (((Component)val.collider).gameObject.tag == "golv" || ((Component)val.collider).gameObject.tag == "grus" || ((Component)val.collider).gameObject.tag == "water" || ((Object)((Component)val.collider).gameObject).name == "Lekhus" || ((Object)((Component)val.collider).gameObject).name == "BearTrapAnomaly17" || ((Object)((Component)val.collider).gameObject).name == "OldHouseWalls")
			{
				RaycastHit val3 = default;
				if (!Physics.Raycast(new Vector3(val.point.x, val.point.y + 0.1f, val.point.z), Vector3.down, ref val3, 0.3f))
				{
					((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).NoText();
					SeeRay.GetComponent<PickUp>().textTimer = 0f;
					SeeRay.GetComponent<PickUp>().ShowText2("I can't teleport to this place");
					SeeRay.GetComponent<PickUp>().textTimerOnOff = true;
					return;
				}
				RaycastHit val4 = default;
				if (!Physics.Raycast(val.point, Vector3.up, ref val4, 4f))
				{
					GameObject.Find("Player").transform.position = val.point;
					return;
				}
				((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).NoText();
				SeeRay.GetComponent<PickUp>().textTimer = 0f;
				SeeRay.GetComponent<PickUp>().ShowText2("I can't teleport to this place");
				SeeRay.GetComponent<PickUp>().textTimerOnOff = true;
			}
			else
			{
				((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).NoText();
				SeeRay.GetComponent<PickUp>().textTimer = 0f;
				SeeRay.GetComponent<PickUp>().ShowText2("I can't teleport to this place");
				SeeRay.GetComponent<PickUp>().textTimerOnOff = true;
			}
		}
		else
		{
			((InventoryController)(object)GameController.GetComponent(typeof(InventoryController))).NoText();
			SeeRay.GetComponent<PickUp>().textTimer = 0f;
			SeeRay.GetComponent<PickUp>().ShowText2("I can't teleport to this place");
			SeeRay.GetComponent<PickUp>().textTimerOnOff = true;
		}
	}
}
