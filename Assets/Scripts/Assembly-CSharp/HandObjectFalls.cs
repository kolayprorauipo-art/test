using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class HandObjectFalls : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public Transform objectResetPos;

	public GameObject GameController;

	public int Anomaly19RandomTime;

	public bool floor3trick;

	public bool TwoNighmarevases;

	public bool CowlegFell;

	public bool checkSewer;

	public bool Anomaly42;

	public virtual void Start()
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		Granny = GameObject.Find("GrannyParent");
		objectResetPos = GameObject.Find("ObjectResetPoint").transform;
		GameController = GameObject.Find("GameController");
		CowlegFell = false;
		if (ParentObject.tag != "plankawalk" && ParentObject.tag != "plankavind" && ((Object)ParentObject).name != "PlankaPlacedNewEscape")
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameController.GetComponent<startNewDay>().Player.GetComponent<Collider>(), true);
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), ((Component)GameController.GetComponent<startNewDay>().playerCam).GetComponent<Collider>(), true);
		}
		if (ParentObject.tag != "plankawalk")
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameObject.Find("GrannyCantSeeCollider").GetComponent<Collider>(), true);
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameObject.Find("GrannyCantSeeCollider2").GetComponent<Collider>(), true);
		}
		if (ParentObject.tag == "hammer")
		{
			((Component)this).gameObject.GetComponent<AudioSource>().volume = 0.3f;
		}
		if (ParentObject.tag == "plankawalk")
		{
			((Component)this).gameObject.GetComponent<BoxCollider>().size = new Vector3(1.8f, 1f, 143f);
		}
		if (ParentObject.tag == "vas" && (PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1))
		{
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)((Component)GameController.GetComponent<InventoryController>().newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
		}
		if (ParentObject.tag == "melon" && PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			((MonoBehaviour)this).StartCoroutine(MelonGamblingDestroy(300f));
		}
		if (ParentObject.tag == "vas" && GameController.GetComponent<startNewDay>().AnomalyNR == 21)
		{
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.color = Color.magenta;
		}
		if (ParentObject.tag == "gascan" && GameController.GetComponent<startNewDay>().AnomalyNR == 18)
		{
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.mainTexture = GameController.GetComponent<startNewDay>().PoisonCanTexture;
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.color = new Color(0.35f, 1f, 0.5f);
		}
		GameObject[] array = GameObject.FindGameObjectsWithTag("granny");
		for (int i = 0; i < array.Length; i++)
		{
			Collider component = array[i].GetComponent<Collider>();
			if ((Object)(object)component != (Object)null)
			{
				Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), component, true);
			}
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 39 && Time.timeSinceLevelLoad > 5f)
		{
			ParentObject.transform.localScale = new Vector3(ParentObject.transform.localScale.x * Random.Range(0.3f, 4f), ParentObject.transform.localScale.x * Random.Range(0.3f, 4f), ParentObject.transform.localScale.x * Random.Range(0.3f, 4f));
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 42)
		{
			Anomaly42 = true;
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 45)
		{
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material = new Material(Shader.Find("Legacy Shaders/Transparent/VertexLit"));
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 106)
		{
			((Renderer)ParentObject.GetComponent<MeshRenderer>()).material.mainTexture = GameController.GetComponent<startNewDay>().STANDOFCHEK;
		}
		if (((Object)ParentObject).name == "newNightmareVase(Clone)" && GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 5)
		{
			((MonoBehaviour)this).StartCoroutine(MelonGamblingDestroy(5f));
		}
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Object)ParentObject.gameObject).name == "newNightmareWrench(Clone)" && (((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name == "HyllaPrison" || ((Object)((Component)other).gameObject).name == "OldHouseWalls" || ((Object)((Component)other).gameObject).name == "Lekhus"))
		{
			GameObject[] array = GameObject.FindGameObjectsWithTag("kitchenDoor2Open");
			int num = array.Length;
			array[Random.Range(0, num)].SetActive(false);
			int num2 = GameObject.FindGameObjectsWithTag("kitchenDoor2Open").Length;
			array[Random.Range(0, num2)].SetActive(false);
			GameObject.Find("DoorRay").GetComponent<openDoors>().NightmareWrenchBreak();
			ParentObject.SetActive(false);
		}
		if (((Object)ParentObject.gameObject).name == "Cowleg")
		{
			if (((Component)other).gameObject.tag == "granny")
			{
				CowlegFell = true;
			}
			if (((Component)other).gameObject.tag == "golv" && !CowlegFell)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					yield return (object)new WaitForSeconds(0.5f);
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				}
				CowlegFell = true;
			}
		}
		else
		{
			if (Time.timeSinceLevelLoad < 5f || (ParentObject.gameObject.tag == "book" && PlayerPrefs.GetInt("EventChallenge2") == 1) || (ParentObject.gameObject.tag != "vas" && PlayerPrefs.GetInt("EventChallenge3") == 1) || ((Object)ParentObject.gameObject).name == "BlueKeyisFalling")
			{
				yield break;
			}
			if (((Object)((Component)other).gameObject).name == "GrannyCantSeeCollider" && (((Object)ParentObject).name == "newButtonLiftEscape(Clone)" || ParentObject.tag == "armborst"))
			{
				ParentObject.transform.position = new Vector3(ParentObject.transform.position.x, ParentObject.transform.position.y - 0.5f, ParentObject.transform.position.z);
			}
			if (!(((Component)other).gameObject.tag == "Player") && ((Component)other).gameObject.tag == "resetfloor" && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire" && ParentObject.tag != "vas2")
			{
				ParentObject.transform.position = objectResetPos.position;
				if (ParentObject.tag == "vitrindoorRclosed")
				{
					ParentObject.transform.position = new Vector3(29.44f, 14.88f, -16.45f);
				}
			}
			if (GameController.GetComponent<startNewDay>().AnomalyNR == 33)
			{
				yield break;
			}
			if (((Object)((Component)other).gameObject).name == "HyllaPrison" && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire")
			{
				floor3trick = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(spawnObject, new Vector3(-8.361276f, 27.39428f, 12.463971f), ((Component)this).transform.rotation);
					yield return (object)new WaitForSeconds(0.5f);
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, new Vector3(-8.361276f, 27.39428f, 12.463971f), ((Component)this).transform.rotation);
				}
			}
			if ((((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name.Contains("HoleGaller") || (Anomaly42 && ((Component)other).gameObject.tag == "Untagged")) && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire" && ((Object)ParentObject).name != "BlueKey" && ((Object)ParentObject).name != "BlueKey(Clone)" && ((Object)ParentObject).name != "PlankOpen" && ((Object)ParentObject).name != "NightmareHammer" && ((Object)ParentObject).name != "NightmareWeaponKey" && ((Object)ParentObject).name != "NightmareVase" && ((Object)ParentObject).name != "NightmareMelon" && ((Object)ParentObject).name != "RedKeyAnomaly27" && ((Object)ParentObject).name != "RedKey" && !floor3trick)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					yield return (object)new WaitForSeconds(0.5f);
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				}
				if (ParentObject.gameObject.tag == "arrow")
				{
					floor3trick = true;
				}
			}
			else if (((Object)((Component)other).gameObject).name == "OldHouseWalls" && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire" && ((Object)ParentObject).name != "BlueKey" && ((Object)ParentObject).name != "BlueKey(Clone)" && ((Object)ParentObject).name != "PlankOpen" && ((Object)ParentObject).name != "NightmareHammer" && ((Object)ParentObject).name != "NightmareWeaponKey" && ((Object)ParentObject).name != "NightmareVase" && ((Object)ParentObject).name != "NightmareMelon" && ((Object)ParentObject).name != "RedKeyAnomaly27" && ((Object)ParentObject).name != "RedKey" && !floor3trick)
			{
				if (ParentObject.transform.position.y < 13.8f || ((Object)ParentObject).name.Contains("Picture") || ParentObject.gameObject.tag == "plankawalk")
				{
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
					((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
					if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
					{
						((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
						Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
						yield return (object)new WaitForSeconds(0.5f);
						Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
					{
						Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else
					{
						Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					}
					if (ParentObject.gameObject.tag == "arrow")
					{
						floor3trick = true;
					}
				}
				else
				{
					checkSewer = true;
				}
			}
			else if (((Object)((Component)other).gameObject).name == "Lekhus" && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire" && !floor3trick)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(spawnObject, new Vector3(11.571735f, 13.417449f, -20.998903f), ((Component)this).transform.rotation);
					yield return (object)new WaitForSeconds(0.5f);
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, new Vector3(11.571735f, 13.417449f, -20.998903f), ((Component)this).transform.rotation);
				}
			}
		}
	}

	public void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		if (checkSewer && ParentObject.transform.position.y < 13.8f && !floor3trick)
		{
			((MonoBehaviour)this).StartCoroutine(GrannyHear(((Component)this).transform.position));
		}
		if (Anomaly42 && ParentObject.transform.position.y > 50f && ((Object)ParentObject).name != "MetalStick" && ((Object)ParentObject).name != "LostKey" && ((Object)ParentObject).name != "TVRemote" && ((Object)ParentObject).name != "Wire")
		{
			ParentObject.transform.position = objectResetPos.position;
			ParentObject.GetComponent<Rigidbody>().isKinematic = true;
		}
	}

	public IEnumerator GrannyHear(Vector3 noicePoint)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
		((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
		floor3trick = true;
		if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
		{
			((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
			Object.Instantiate<Transform>(spawnObject, noicePoint, ((Component)this).transform.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
		}
		else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
		}
		else
		{
			Object.Instantiate<Transform>(spawnObject, noicePoint, ((Component)this).transform.rotation);
		}
	}

	public IEnumerator DontMakeNoice()
	{
		yield return (object)new WaitForSeconds(5f);
		floor3trick = true;
	}

	public IEnumerator MelonGamblingDestroy(float timer)
	{
		yield return (object)new WaitForSeconds(timer);
		Object.Destroy((Object)(object)ParentObject);
	}
}
