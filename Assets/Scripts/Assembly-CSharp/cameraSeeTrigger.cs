using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class cameraSeeTrigger : MonoBehaviour
{
	public GameObject noiceObject1;

	public GameObject noiceObject2;

	public GameObject noiceObject3;

	public GameObject noiceObject4;

	public bool camSee;

	public bool camActivated;

	public bool doorClosed;

	public GameObject Granny;

	public GameObject player;

	public GameObject doorTrigger;

	public GameObject planka1;

	public GameObject planka2;

	public GameObject planka3;

	public GameObject cameraAlarm;

	public GameObject galler;

	public GameObject gallerColliders;

	public GameObject prisonDoor;

	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !camSee)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = true;
			((PickUp)(object)player.GetComponent(typeof(PickUp))).playerInPrison = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			doorTrigger.SetActive(true);
			if (!camActivated)
			{
				camActivated = true;
				((camLampBlink)(object)cameraAlarm.GetComponent(typeof(camLampBlink))).startBlink = true;
			}
			if (!doorClosed)
			{
				doorClosed = true;
				prisonDoor.GetComponent<Animation>().Play("prisondoorClose");
				((prisonDoorOpenClose)(object)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).doorLocked = true;
			}
			if ((Object)(object)GameObject.Find("PlankaVind") != (Object)null)
			{
				planka1.SetActive(false);
			}
			if ((Object)(object)GameObject.Find("PlankaVind2") != (Object)null)
			{
				planka2.SetActive(false);
			}
			if ((Object)(object)GameObject.Find("PlankaVind3") != (Object)null)
			{
				planka3.SetActive(false);
			}
			camSee = true;
			noiceObject1.SetActive(true);
			yield return (object)new WaitForSeconds(15f);
			noiceObject2.SetActive(true);
			yield return (object)new WaitForSeconds(15f);
			noiceObject3.SetActive(true);
			yield return (object)new WaitForSeconds(15f);
			noiceObject4.SetActive(true);
			((camLampBlink)(object)cameraAlarm.GetComponent(typeof(camLampBlink))).soundOff = true;
		}
		if (((Component)other).gameObject.tag == "melon" && GameController.GetComponent<startNewDay>().AnomalyNR == 101)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = true;
			((PickUp)(object)player.GetComponent(typeof(PickUp))).playerInPrison = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			doorTrigger.SetActive(true);
			if (!camActivated)
			{
				camActivated = true;
				((camLampBlink)(object)cameraAlarm.GetComponent(typeof(camLampBlink))).startBlink = true;
			}
			if (!doorClosed)
			{
				doorClosed = true;
				prisonDoor.GetComponent<Animation>().Play("prisondoorClose");
				((prisonDoorOpenClose)(object)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).doorLocked = true;
			}
			if ((Object)(object)GameObject.Find("PlankaVind") != (Object)null)
			{
				planka1.SetActive(false);
			}
			if ((Object)(object)GameObject.Find("PlankaVind2") != (Object)null)
			{
				planka2.SetActive(false);
			}
			if ((Object)(object)GameObject.Find("PlankaVind3") != (Object)null)
			{
				planka3.SetActive(false);
			}
			camSee = true;
			noiceObject1.SetActive(true);
			((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<CheckExitDoor>().GabonAnomaly11Ending());
			yield return (object)new WaitForSeconds(15f);
			noiceObject2.SetActive(true);
			yield return (object)new WaitForSeconds(15f);
			noiceObject3.SetActive(true);
			yield return (object)new WaitForSeconds(15f);
			noiceObject4.SetActive(true);
			((camLampBlink)(object)cameraAlarm.GetComponent(typeof(camLampBlink))).soundOff = true;
		}
		if (((Component)other).gameObject.tag == "granny")
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
		}
	}
}
