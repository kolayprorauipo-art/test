using System;
using UnityEngine;

[Serializable]
public class DeliverShotgunParts : MonoBehaviour
{
	public GameObject gameController;

	public bool shotgunPart1;

	public bool shotgunPart2;

	public bool shotgunPart3;

	public GameObject shotgunPart1Table;

	public GameObject shotgunPart2Table;

	public GameObject shotgunPart3Table;

	public GameObject shotgunPart1Hand;

	public GameObject shotgunPart2Hand;

	public GameObject shotgunPart3Hand;

	public GameObject dropObjectButton;

	public GameObject Shotgun;

	public GameObject moreAmmo;

	public AudioClip placeObjectSound;

	public GameObject PlaceButton;

	public bool plankaSet;

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			if ((((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel1 || ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel2 || ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel3) && ((Object)((Component)this).gameObject).name != "PlankPlace")
			{
				PlaceButton.SetActive(true);
			}
			else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplanka && ((Object)((Component)this).gameObject).name == "PlankPlace" && !plankaSet)
			{
				PlaceButton.SetActive(true);
				gameController.GetComponent<startNewDay>().PlankaHighlightReady.SetActive(true);
			}
			else
			{
				PlaceButton.SetActive(false);
			}
		}
	}

	public virtual void PlaceShotgunParts()
	{
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel1)
		{
			shotgunPart1Table.SetActive(true);
			shotgunPart1Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel1 = false;
			shotgunPart1 = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart2 && shotgunPart3)
			{
				if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 18)
				{
					Shotgun.SetActive(true);
					Shotgun.transform.position = new Vector3(-1.846f, 7.644f, -16.803f);
					shotgunPart1Table.SetActive(false);
					shotgunPart2Table.SetActive(false);
					shotgunPart3Table.SetActive(false);
				}
				else
				{
					Shotgun.SetActive(true);
					moreAmmo.SetActive(true);
					shotgunPart1Table.SetActive(false);
					shotgunPart2Table.SetActive(false);
					shotgunPart3Table.SetActive(false);
				}
			}
		}
		if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel2)
		{
			shotgunPart2Table.SetActive(true);
			shotgunPart2Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel2 = false;
			shotgunPart2 = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart3)
			{
				if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 18)
				{
					Shotgun.SetActive(true);
					Shotgun.transform.position = new Vector3(-1.846f, 7.644f, -16.803f);
					shotgunPart1Table.SetActive(false);
					shotgunPart2Table.SetActive(false);
					shotgunPart3Table.SetActive(false);
				}
				else
				{
					Shotgun.SetActive(true);
					moreAmmo.SetActive(true);
					shotgunPart1Table.SetActive(false);
					shotgunPart2Table.SetActive(false);
					shotgunPart3Table.SetActive(false);
				}
			}
		}
		if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel3)
		{
			shotgunPart3Table.SetActive(true);
			shotgunPart3Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegunDel3 = false;
			shotgunPart3 = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
			if (shotgunPart1 && shotgunPart2)
			{
				if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 18)
				{
					Shotgun.SetActive(true);
					Shotgun.transform.position = new Vector3(-1.846f, 7.644f, -16.803f);
					shotgunPart1Table.SetActive(false);
					shotgunPart2Table.SetActive(false);
					shotgunPart3Table.SetActive(false);
					return;
				}
				Shotgun.SetActive(true);
				moreAmmo.SetActive(true);
				shotgunPart1Table.SetActive(false);
				shotgunPart2Table.SetActive(false);
				shotgunPart3Table.SetActive(false);
			}
		}
		if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 16)
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
	}

	public virtual void PlacePlanka()
	{
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).Plankaready.SetActive(true);
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).planka.SetActive(false);
		dropObjectButton.SetActive(false);
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplanka = false;
		((Component)this).GetComponent<AudioSource>().PlayOneShot(placeObjectSound);
		plankaSet = true;
		if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 16)
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
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			PlaceButton.SetActive(false);
			gameController.GetComponent<startNewDay>().PlankaHighlightReady.SetActive(false);
		}
	}

	public virtual void Start()
	{
		PlaceButton = GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().PlaceButton;
		plankaSet = false;
	}
}
