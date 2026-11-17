using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerCaught : MonoBehaviour
{
	public bool grannyTakePlayer;

	public bool spiderBitePlayer;

	public bool explodingPlayer;

	public Transform granny;

	public Transform grannyEye;

	public Transform spiderPos;

	public Transform playerEye;

	public float speed;

	public GameObject joystick;

	public GameObject swipe;

	public GameObject duckaKnapp;

	public GameObject playerHukaKnapp;

	public GameObject optionButton;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject dooropener;

	public GameObject seeHolder;

	public Image removeBar;

	public GameObject trapButton;

	public GameObject trapBar;

	public GameObject playerStop;

	public GameObject MainCam;

	public MonoBehaviour playerStopscript;

	public bool stopFOV;

	public bool startFOV;

	public float timer;

	public GameObject soundHolder;

	public bool soundPlaying;

	public GameObject gameController;

	public GameObject bedButton1;

	public GameObject bedButton2;

	public GameObject bedButton3;

	public GameObject CoffinButton1;

	public GameObject CoffinButton2;

	public GameObject CarButton;

	public virtual void Start()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
	}

	public virtual void Update()
	{
		if (player.activeSelf)
		{
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffin = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffinBackyard = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerHidingInCar = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingUnderBed2 = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingUnderBed3 = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingInCoffin4 = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingInCoffinBY = false;
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).hidingInCar = false;
		}
		if (grannyTakePlayer && !spiderBitePlayer && !explodingPlayer)
		{
			((MonoBehaviour)this).StartCoroutine(faceGranny());
		}
		if (spiderBitePlayer && !grannyTakePlayer && !explodingPlayer)
		{
			((MonoBehaviour)this).StartCoroutine(faceSpider());
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = true;
		}
		if (explodingPlayer && !grannyTakePlayer && !spiderBitePlayer)
		{
			((MonoBehaviour)this).StartCoroutine(playerExplode());
			((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).dontHitPlayer = true;
		}
		if (startFOV)
		{
			if (playerStop.GetComponent<Camera>().fieldOfView <= 30f)
			{
				stopFOV = true;
				startFOV = false;
			}
			if (!stopFOV)
			{
				playerStop.GetComponent<Camera>().fieldOfView = playerStop.GetComponent<Camera>().fieldOfView - 100f * Time.deltaTime;
			}
		}
	}

	public virtual IEnumerator faceGranny()
	{
		Vector3 val = grannyEye.position - playerEye.position;
		float num = speed * Time.deltaTime;
		Vector3 val2 = Vector3.RotateTowards(playerEye.forward, val, num, 0f);
		Debug.DrawRay(((Component)this).transform.position, val2, Color.red);
		playerEye.rotation = Quaternion.LookRotation(val2);
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
		joystick.SetActive(false);
		swipe.SetActive(false);
		duckaKnapp.SetActive(false);
		((Behaviour)playerStopscript).enabled = false;
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		CoffinButton1.SetActive(false);
		CoffinButton2.SetActive(false);
		CarButton.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
		if (!soundPlaying)
		{
			soundPlaying = true;
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).playerCaughtNightmare();
			}
			else
			{
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).playerCaught();
			}
		}
		if (((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerCaughtLastTime)
		{
			yield return (object)new WaitForSeconds(0.8f);
			playerStop.GetComponent<Camera>().fieldOfView = 60f;
			MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
			MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		}
		yield return (object)new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		((MonoBehaviour)this).StartCoroutine(((endDay)(object)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator fallingDead()
	{
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
		((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
		joystick.SetActive(false);
		swipe.SetActive(false);
		duckaKnapp.SetActive(false);
		((Behaviour)playerStopscript).enabled = false;
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
		MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
		MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		if (((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
		{
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
		}
		yield return (object)new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		((MonoBehaviour)this).StartCoroutine(((endDay)(object)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator playerExplode()
	{
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
		((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
		joystick.SetActive(false);
		swipe.SetActive(false);
		duckaKnapp.SetActive(false);
		((Behaviour)playerStopscript).enabled = false;
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
		MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
		MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		if (((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).ragdollSpawn)
		{
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).playerFallDead = true;
		}
		yield return (object)new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		((MonoBehaviour)this).StartCoroutine(((endDay)(object)gameController.GetComponent(typeof(endDay))).EndDay());
	}

	public virtual IEnumerator faceSpider()
	{
		Vector3 val = spiderPos.position - playerEye.position;
		float num = speed * Time.deltaTime;
		Vector3 val2 = Vector3.RotateTowards(playerEye.forward, val, num, 0f);
		Debug.DrawRay(((Component)this).transform.position, val2, Color.red);
		playerEye.rotation = Quaternion.LookRotation(val2);
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		joystick.SetActive(false);
		swipe.SetActive(false);
		duckaKnapp.SetActive(false);
		((Behaviour)playerStopscript).enabled = false;
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		bedButton1.SetActive(false);
		bedButton2.SetActive(false);
		bedButton3.SetActive(false);
		CoffinButton1.SetActive(false);
		CoffinButton2.SetActive(false);
		CarButton.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
		if (!soundPlaying)
		{
			soundPlaying = true;
		}
		if (((EnemyAIGranny)(object)((Component)granny).GetComponent(typeof(EnemyAIGranny))).playerCaughtLastTime)
		{
			MainCam.GetComponent<Animation>()["PlayerDie"].speed = 1f;
			MainCam.GetComponent<Animation>().CrossFade("PlayerDie");
		}
		yield return (object)new WaitForSeconds(0.2f);
		grannyTakePlayer = false;
		spiderBitePlayer = false;
		explodingPlayer = false;
		((MonoBehaviour)this).StartCoroutine(((endDay)(object)gameController.GetComponent(typeof(endDay))).EndDay());
	}
}
