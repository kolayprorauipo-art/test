using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class endDay : MonoBehaviour
{
	public GameObject gameController;

	public Image blackScreenTexture;

	public float fadeBlackSpeed;

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

	public MonoBehaviour playerStopscript;

	public GameObject playerStop;

	public GameObject swipe;

	public GameObject furnitureHolder;

	public GameObject DoorHolder;

	public GameObject PickUpHolder;

	public GameObject[] beartraps;

	public GameObject bedButton1;

	public GameObject bedButton2;

	public GameObject bedButton3;

	public GameObject dropButtonHolder;

	public GameObject shootButtonHolder;

	public GameObject coffinButton1;

	public GameObject coffinButton2;

	public GameObject carButton;

	public Image trapButtonUI;

	public GameObject trapButton;

	public GameObject trapBar;

	public bool enDayStart;

	public GameObject soundHolder2;

	public GameObject Sound1;

	public GameObject Sound2;

	public GameObject Sound3;

	public GameObject cameraSee;

	public GameObject prisonDoorTrigger;

	public GameObject prisonDoor;

	public GameObject prisonGaller;

	public GameObject prisonGallerColliders;

	public GameObject teddyMusicHolder;

	public GameObject grannyHuntMusicHolder;

	public GameObject brunnsvevButton;

	public GameObject bastuSteamHolder;

	public GameObject Spider;

	public GameObject GrannyEyeLock;

	public GameObject GrannyBlindSensor;

	public GameObject spraySoundHolder;

	public GameObject sprayButton;

	public GameObject remoteButton;

	public GameObject remoteAndSprayButtonParent;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual IEnumerator EndDay()
	{
		if (enDayStart)
		{
			yield break;
		}
		((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeDown = true;
		enDayStart = true;
		yield return (object)new WaitForSeconds(2f);
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		CameraFollowExample cameraFollowExample = (CameraFollowExample)(object)playerStop.GetComponent(typeof(CameraFollowExample));
		((fadeUpDownTeddyMusic)(object)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).playerCaught = true;
		((fadeUpDownGrannyHunt)(object)grannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
		cameraFollowExample.rotationx = 0f;
		((PlayerFreeze)(object)gameController.GetComponent(typeof(PlayerFreeze))).freezeON = false;
		((PlayerFreeze)(object)gameController.GetComponent(typeof(PlayerFreeze))).freezeOFF = true;
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.8f, false);
		yield return (object)new WaitForSeconds(2f);
		((Component)playerCam).GetComponent<Animation>().Play("PlayerDie");
		((Component)playerCam).GetComponent<Animation>()["PlayerDie"].speed = -50f;
		yield return (object)new WaitForSeconds(3f);
		playerInBedCam.SetActive(true);
		((Behaviour)playerStopscript).enabled = true;
		((Component)playerCam).GetComponent<Camera>().fieldOfView = 60f;
		swipe.SetActive(true);
		((Component)playerCam).transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 5f;
		((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 4f;
		((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 5f;
		((Component)playerHead).transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		((openDoors)(object)DoorHolder.GetComponent(typeof(openDoors))).playerTaken = false;
		((PickUp)(object)PickUpHolder.GetComponent(typeof(PickUp))).playerTaken = false;
		((PickUp)(object)PickUpHolder.GetComponent(typeof(PickUp))).dropObject = false;
		((playerCaught)(object)Player.GetComponent(typeof(playerCaught))).soundPlaying = false;
		Player.SetActive(false);
		Player.transform.position = PlayerStartPos.position;
		Player.transform.rotation = PlayerStartPos.rotation;
		Granny.SetActive(false);
		Granny.transform.position = GrannyStartPos.position;
		Granny.SetActive(true);
		float a = 0f;
		Color color = ((Graphic)joystickTexture).color;
		color.a = a;
		((Graphic)joystickTexture).color = color;
		float a2 = 0f;
		Color color2 = ((Graphic)joystickRingTexture).color;
		color2.a = a2;
		((Graphic)joystickRingTexture).color = color2;
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		brunnsvevButton.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		dropButtonHolder.SetActive(true);
		shootButtonHolder.SetActive(true);
		bastuSteamHolder.SetActive(false);
		spraySoundHolder.SetActive(false);
		sprayButton.SetActive(false);
		remoteAndSprayButtonParent.SetActive(true);
		remoteButton.SetActive(false);
		((coffinButton)(object)coffinButton1.GetComponent(typeof(coffinButton))).PlayerHiding = false;
		coffinButton1.SetActive(false);
		((coffinButtonBackyard)(object)coffinButton2.GetComponent(typeof(coffinButtonBackyard))).PlayerHiding = false;
		coffinButton2.SetActive(false);
		((insideCarButton)(object)carButton.GetComponent(typeof(insideCarButton))).PlayerHiding = false;
		carButton.SetActive(false);
		trapButton.SetActive(true);
		trapBar.SetActive(true);
		((Behaviour)trapButtonUI).enabled = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).attackingPlayer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
		((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepperStart = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyPepperReact = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannyGonnaSmack = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = false;
		GrannyEyeLock.SetActive(false);
		GrannyBlindSensor.SetActive(false);
		if (Spider.activeSelf)
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).grannyCaughtPlayerReset();
		}
		if (((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).prisondoorClosed = false;
			cameraSee.SetActive(false);
			prisonDoorTrigger.SetActive(false);
			prisonGaller.GetComponent<Collider>().enabled = true;
			prisonGallerColliders.SetActive(false);
			if ((Object)(object)GameObject.Find("prisonDoor") != (Object)null)
			{
				prisonDoor.tag = "Untagged";
			}
		}
		mittPrick.SetActive(false);
		playerBedAnim.GetComponent<Animation>().Play("PlayerInBed");
		playerBedAnim.GetComponent<Animation>()["PlayerInBed"].speed = -50f;
		((MonoBehaviour)this).StartCoroutine(((furnitureControlls)(object)furnitureHolder.GetComponent(typeof(furnitureControlls))).cleanUp());
		((MonoBehaviour)this).StartCoroutine(((startNewDay)(object)daysCountHolder.GetComponent(typeof(startNewDay))).newDay());
		enDayStart = false;
		((backgroundSound)(object)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)(object)Sound3.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)(object)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		beartrapDestroy();
		((resetDay)(object)daysCountHolder.GetComponent(typeof(resetDay))).resetDays();
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
