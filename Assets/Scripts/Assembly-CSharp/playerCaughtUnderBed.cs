using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerCaughtUnderBed : MonoBehaviour
{
	public Image blackScreenTexture;

	public float fadeBlackSpeed2;

	public GameObject daysCountHolder;

	public GameObject playerBedAnim;

	public GameObject playerInBedCam;

	public GameObject Granny;

	public GameObject Player;

	public Transform PlayerStartPos;

	public Transform GrannyStartPos;

	public Transform playerCam;

	public Transform playerHead;

	public GameObject joystick;

	public Image joystickTexture;

	public Image joystickRingTexture;

	public GameObject crouchButton;

	public GameObject optionButton;

	public GameObject mittPrick;

	public GameObject furnitureHolder;

	public GameObject[] beartraps;

	public GameObject allBedButtons;

	public GameObject bedCam1Holder;

	public GameObject bedCam2Holder;

	public GameObject bedCam3Holder;

	public GameObject bedCam1;

	public GameObject bedCam2;

	public GameObject bedCam3;

	public GameObject bedButton1;

	public GameObject bedButton2;

	public GameObject bedButton3;

	public MonoBehaviour playerStopscript;

	public GameObject playerStop;

	public GameObject DoorHolder;

	public GameObject PickUpHolder;

	public GameObject dropButtonHolder;

	public GameObject shootButtonHolder;

	public GameObject dropButton;

	public GameObject soundHolder2;

	public GameObject teddyMusicHolder;

	public GameObject grannyHuntMusicHolder;

	public GameObject bastuSteamHolder;

	public GameObject spraySoundholder;

	public GameObject remoteAndSprayButtonParent;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator EndDayUnderBed()
	{
		mittPrick.SetActive(false);
		yield return (object)new WaitForSeconds(1.7f);
		((fadeUpDownTeddyMusic)(object)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).playerCaught = true;
		((fadeUpDownGrannyHunt)(object)grannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.2f, false);
		yield return (object)new WaitForSeconds(2f);
		((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeDown = true;
		yield return (object)new WaitForSeconds(3f);
		allBedButtons.SetActive(true);
		if (bedCam1Holder.activeSelf)
		{
			bedCam1.GetComponent<bedEyes>().lookAtGranny = false;
			((Behaviour)bedCam1.GetComponent<bedEyes>().playerStopscript).enabled = true;
			bedCam1.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			bedCam1Holder.SetActive(false);
		}
		if (bedCam2Holder.activeSelf)
		{
			bedCam2.GetComponent<bedEyes2>().lookAtGranny = false;
			((Behaviour)bedCam2.GetComponent<bedEyes2>().playerStopscript).enabled = true;
			bedCam2.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
			bedCam2Holder.SetActive(false);
		}
		if (bedCam3Holder.activeSelf)
		{
			bedCam3.GetComponent<bedEyes3>().lookAtGranny = false;
			((Behaviour)bedCam3.GetComponent<bedEyes3>().playerStopscript).enabled = true;
			bedCam3.transform.localEulerAngles = new Vector3(0f, 270f, 0f);
			bedCam3Holder.SetActive(false);
		}
		if (bedButton1.activeSelf)
		{
			bedButton1.GetComponent<bedButton>().PlayerHiding = false;
			bedButton1.SetActive(false);
		}
		if (bedButton2.activeSelf)
		{
			bedButton2.GetComponent<bedButton2>().PlayerHiding = false;
			bedButton2.SetActive(false);
		}
		if (bedButton3.activeSelf)
		{
			bedButton3.GetComponent<bedButton3>().PlayerHiding = false;
			bedButton3.SetActive(false);
		}
		Player.SetActive(true);
		((openDoors)(object)DoorHolder.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)PickUpHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((CameraFollowExample)(object)playerStop.GetComponent(typeof(CameraFollowExample))).rotationx = 0f;
		((Component)playerCam).transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		((PickUp)(object)PickUpHolder.GetComponent(typeof(PickUp))).dropObject = true;
		yield return (object)new WaitForSeconds(0.1f);
		((openDoors)(object)DoorHolder.GetComponent(typeof(openDoors))).playerTaken = false;
		((PickUp)(object)PickUpHolder.GetComponent(typeof(PickUp))).playerTaken = false;
		Player.SetActive(false);
		dropButtonHolder.SetActive(true);
		shootButtonHolder.SetActive(true);
		dropButton.SetActive(false);
		playerInBedCam.SetActive(true);
		Player.transform.position = PlayerStartPos.position;
		Player.transform.rotation = PlayerStartPos.rotation;
		Granny.SetActive(false);
		Granny.transform.position = GrannyStartPos.position;
		Granny.SetActive(true);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		spraySoundholder.SetActive(false);
		remoteAndSprayButtonParent.SetActive(true);
		allBedButtons.SetActive(true);
		bastuSteamHolder.SetActive(false);
		if (bedCam1Holder.activeSelf)
		{
			bedCam1.GetComponent<bedEyes>().lookAtGranny = false;
			((Behaviour)bedCam1.GetComponent<bedEyes>().playerStopscript).enabled = true;
			bedCam1.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
			bedCam1Holder.SetActive(false);
		}
		if (bedCam2Holder.activeSelf)
		{
			bedCam2.GetComponent<bedEyes2>().lookAtGranny = false;
			((Behaviour)bedCam2.GetComponent<bedEyes2>().playerStopscript).enabled = true;
			bedCam2.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
			bedCam2Holder.SetActive(false);
		}
		if (bedCam3Holder.activeSelf)
		{
			bedCam3.GetComponent<bedEyes3>().lookAtGranny = false;
			((Behaviour)bedCam3.GetComponent<bedEyes3>().playerStopscript).enabled = true;
			bedCam3.transform.localEulerAngles = new Vector3(0f, 270f, 0f);
			bedCam3Holder.SetActive(false);
		}
		if (bedButton1.activeSelf)
		{
			bedButton1.GetComponent<bedButton>().PlayerHiding = false;
			bedButton1.SetActive(false);
		}
		if (bedButton2.activeSelf)
		{
			bedButton2.GetComponent<bedButton2>().PlayerHiding = false;
			bedButton2.SetActive(false);
		}
		if (bedButton3.activeSelf)
		{
			bedButton3.GetComponent<bedButton3>().PlayerHiding = false;
			bedButton3.SetActive(false);
		}
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).attackingPlayer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
		((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyLookUnderBed = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed2 = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed3 = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		mittPrick.SetActive(false);
		playerBedAnim.GetComponent<Animation>().Play("PlayerInBed");
		playerBedAnim.GetComponent<Animation>()["PlayerInBed"].speed = -50f;
		((MonoBehaviour)this).StartCoroutine(((furnitureControlls)(object)furnitureHolder.GetComponent(typeof(furnitureControlls))).cleanUp());
		((MonoBehaviour)this).StartCoroutine(((startNewDay)(object)daysCountHolder.GetComponent(typeof(startNewDay))).newDay());
		((resetDay)(object)daysCountHolder.GetComponent(typeof(resetDay))).resetDays();
		beartrapDestroy();
	}

	public virtual void beartrapDestroy()
	{
		beartraps = GameObject.FindGameObjectsWithTag("BearTrapActivated");
		for (int i = 0; i < beartraps.Length; i++)
		{
			Object.Destroy((Object)(object)beartraps[i]);
		}
	}
}
