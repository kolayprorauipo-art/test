using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class CheckExitDoor : MonoBehaviour
{
	public PickUp PickUpScript;

	public Image blackScreenTexture;

	public GameObject Granny;

	public GameObject GrannySkin;

	public GameObject GrannyBone;

	public GameObject player;

	public GameObject playerStop;

	public MonoBehaviour playerStopscript;

	public GameObject swipe;

	public GameObject footstepScriptHolder;

	public GameObject joystick;

	public GameObject crouchButton;

	public Image removeBar;

	public GameObject trapButton;

	public GameObject trapBar;

	public GameObject dooropener;

	public GameObject seeHolder;

	public GameObject soundHolder;

	public float fadeBlackSpeed;

	public bool lampa1ok;

	public bool lampa2ok;

	public bool planka1Bort;

	public bool planka2Bort;

	public bool hangLockBort;

	public bool DpadlockBort;

	public bool batteryLockOk;

	public bool extremeLockOk;

	public GameObject CantopenDoorYetText;

	public GameObject gameController;

	public float counter;

	public float ELtimer;

	public bool startTimer;

	public GameObject extraLock;

	public GameObject extraLockHard;

	public GameObject extraLockExtreme;

	public bool extraLockOK;

	public bool extraLockPlaced;

	public GameObject padlockCodePL1;

	public GameObject padlockCodePL2;

	public GameObject padlockCodePL3;

	public GameObject padlockCodePL4;

	public GameObject padlockCodePL5;

	public GameObject battery1;

	public GameObject battery2;

	public GameObject battery3;

	public GameObject battery4;

	public GameObject battery5;

	public bool easyDiff;

	public bool normalDiff;

	public bool hardDiff;

	public bool extremeDiff;

	public bool practiseDiff;

	public GameObject ExtraLockOnDoorText;

	public bool ButtonsLockOk;

	public GameObject newLever;

	public GameObject LeverLamp;

	public GameObject newLever2;

	public GameObject LeverLamp2;

	public GameObject newLever3;

	public GameObject LeverLamp3;

	public GameObject CyanPadLock;

	public GameObject newLever4;

	public GameObject LeverLamp4;

	public GameObject CommentText;

	public Resources c;

	public bool EndingStarted;

	public bool EndingStarted2;

	public float EndingTimeCount;

	public bool Anomaly18Locks;

	public float Anomaly18PadlockCode;

	public GameObject DoorLockLamp4;

	public bool Anomaly27Locks;

	public bool IrrationalEscapeFailed;

	public virtual void Start()
	{
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		if (gameController.GetComponent<startNewDay>().AnomalyNR != 18 && gameController.GetComponent<startNewDay>().AnomalyNR != 27 && gameController.GetComponent<startNewDay>().AnomalyNR != 36 && gameController.GetComponent<startNewDay>().PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			extraLockExtreme.SetActive(true);
			newLever = Object.Instantiate<GameObject>(GameObject.Find("Spak"), new Vector3(-4.536f, 27.9f, 16.53f), Quaternion.Euler(180f, -90f, -115f));
			newLever.transform.localScale = new Vector3(0.096632876f, 0.09663287f, 0.70853585f);
			newLever.tag = "Untagged";
			((Object)newLever).name = "LeverEscape";
			LeverLamp = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(-4.385f, 27.9f, 16.5f), Quaternion.Euler(0f, 0f, 0f));
			LeverLamp.transform.SetParent((Transform)null);
			LeverLamp.transform.localScale = new Vector3(0.6243234f, 0.4822549f, 0.7320695f);
			LeverLamp.AddComponent<MeshCollider>().convex = true;
			((Object)LeverLamp).name = "LeverNewEscape1";
			newLever2 = Object.Instantiate<GameObject>(GameObject.Find("Spak"), new Vector3(-3.883f, 16.934f, 4.906f), Quaternion.Euler(180f, -90f, -115f));
			newLever2.transform.localScale = new Vector3(0.096632876f, 0.09663287f, 0.70853585f);
			newLever2.tag = "Untagged";
			((Object)newLever2).name = "LeverEscape2";
			LeverLamp2 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(-3.7347f, 16.931f, 4.849f), Quaternion.Euler(0f, 0f, 0f));
			LeverLamp2.transform.SetParent((Transform)null);
			LeverLamp2.transform.localScale = new Vector3(0.6243234f, 0.4822549f, 0.7320695f);
			newLever3 = Object.Instantiate<GameObject>(GameObject.Find("Spak"), new Vector3(-20.0763f, 23.632f, -12.9736f), Quaternion.Euler(180f, -90f, -115f));
			newLever3.transform.localScale = new Vector3(0.096632876f, 0.09663287f, 0.70853585f);
			newLever3.tag = "Untagged";
			((Object)newLever3).name = "LeverEscape3";
			LeverLamp3 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(-19.928f, 23.629f, -13.0306f), Quaternion.Euler(0f, 0f, 0f));
			LeverLamp3.transform.SetParent((Transform)null);
			LeverLamp3.transform.localScale = new Vector3(0.6243234f, 0.4822549f, 0.7320695f);
			newLever4 = Object.Instantiate<GameObject>(GameObject.Find("Spak"), new Vector3(24.105f, 24.3f, 8.666f), Quaternion.Euler(180f, -90f, -115f));
			newLever4.transform.localScale = new Vector3(0.096632876f, 0.09663287f, 0.70853585f);
			newLever4.tag = "Untagged";
			((Object)newLever4).name = "LeverEscape4";
			LeverLamp4 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(24.254f, 24.286f, 8.613f), Quaternion.Euler(0f, 0f, 0f));
			LeverLamp4.transform.SetParent((Transform)null);
			LeverLamp4.transform.localScale = new Vector3(0.6243234f, 0.4822549f, 0.7320695f);
			extraLockExtreme.SetActive(false);
			extraLock.SetActive(true);
			CyanPadLock = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DdoorLock/DigitalPadlock"), new Vector3(-19.887f, 23.9408f, -14.3914f), Quaternion.Euler(0f, -58.38f, 0f));
			CyanPadLock.transform.localScale = new Vector3(0.42016575f, 0.42148846f, 0.7847048f);
			CyanPadLock.tag = "Untagged";
			Object.Destroy((Object)(object)CyanPadLock.transform.GetChild(0));
			((Object)CyanPadLock).name = "NewPadlock";
			extraLock.SetActive(false);
			if (gameController.GetComponent<startNewDay>().AnomalyNR == 35)
			{
				newLever.transform.position = new Vector3(-4.536f, 23.7f, 16.53f);
				LeverLamp.transform.position = new Vector3(-4.385f, 23.7f, 16.5f);
			}
		}
		DoorLockLamp4 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), GameObject.Find("Larmlampa2").transform.position, Quaternion.identity);
		((Renderer)DoorLockLamp4.GetComponent<MeshRenderer>()).material.color = Color.green;
		DoorLockLamp4.transform.SetParent(GameObject.Find("LarmDosa").transform);
		DoorLockLamp4.transform.localScale = new Vector3(1f, 1f, 1f);
		DoorLockLamp4.SetActive(false);
	}

	public virtual void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		if (EndingStarted && playerStop.transform.position.z < -7.2f)
		{
			playerStop.transform.Translate(0f, 0f, 0.4f * Time.deltaTime);
		}
		if (EndingStarted2)
		{
			playerStop.transform.rotation = Quaternion.Slerp(Quaternion.Euler(12f, 0f, 0f), Quaternion.Euler(-90f, 0f, 0f), EndingTimeCount);
			EndingTimeCount += Time.deltaTime;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18 && !Anomaly18Locks)
		{
			Anomaly18Locks = true;
			ExtralockTimer();
			if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				((Collider)Granny.gameObject.GetComponent(typeof(Collider))).enabled = false;
				((Renderer)GrannySkin.gameObject.GetComponent(typeof(Renderer))).enabled = false;
				GrannyBone.SetActive(false);
			}
		}
		if ((((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 27 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 36) && !Anomaly27Locks)
		{
			Anomaly27Locks = true;
			lampa1ok = true;
			lampa2ok = true;
			planka1Bort = true;
			planka2Bort = true;
			hangLockBort = true;
			extraLockPlaced = true;
			DpadlockBort = true;
			batteryLockOk = true;
			extremeLockOk = true;
			ButtonsLockOk = true;
			GameObject.Find("PlankaOH1").transform.position = new Vector3(11.04f, -100f, 11.31f);
			GameObject.Find("PlankaOH2").transform.position = new Vector3(11.04f, -100f, 11.31f);
			GameObject.Find("PlankaOH3").transform.position = new Vector3(11.04f, -100f, 11.31f);
			GameObject.Find("Ammo_Garage").transform.position = new Vector3(11.04f, 10.387691f, 11.31f);
			GameObject.Find("planka").SetActive(false);
			GameObject.Find("LarmDosa").SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") != -1)
			{
				GameObject.Find("DoorLock").SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				((Collider)Granny.gameObject.GetComponent(typeof(Collider))).enabled = false;
				((Renderer)GrannySkin.gameObject.GetComponent(typeof(Renderer))).enabled = false;
				GrannyBone.SetActive(false);
			}
		}
		if ((PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1) && !Anomaly27Locks)
		{
			Anomaly27Locks = true;
			lampa1ok = true;
			lampa2ok = true;
			planka1Bort = true;
			planka2Bort = true;
			hangLockBort = true;
			extraLockPlaced = true;
			DpadlockBort = true;
			batteryLockOk = true;
			extremeLockOk = true;
			ButtonsLockOk = true;
			GameObject.Find("Ammo_Garage").transform.position = new Vector3(11.04f, 10.387691f, 11.31f);
			GameObject.Find("planka").SetActive(false);
			GameObject.Find("LarmDosa").SetActive(false);
			GameObject.Find("DoorLock").SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				((Collider)Granny.gameObject.GetComponent(typeof(Collider))).enabled = false;
				((Renderer)GrannySkin.gameObject.GetComponent(typeof(Renderer))).enabled = false;
				GrannyBone.SetActive(false);
			}
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 27 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 36 || PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			return;
		}
		if (PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			if (!extremeDiff)
			{
				extremeDiff = true;
				ExtralockTimer();
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
				GameObject.Find("Spak").tag = "Untagged";
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == -1 && !easyDiff && PlayerPrefs.GetInt("twoLocksOnOff") == 1)
		{
			ExtralockTimerHard();
			extraLockExtreme.SetActive(true);
			ExtralockTimer();
			easyDiff = true;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			if (!easyDiff && PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
				ExtralockTimer();
				easyDiff = true;
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			if (!normalDiff)
			{
				normalDiff = true;
				if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
				{
					ExtralockTimerHard();
					extraLockExtreme.SetActive(true);
				}
				ExtralockTimer();
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			if (!hardDiff)
			{
				hardDiff = true;
				if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
				{
					extraLockExtreme.SetActive(true);
				}
				ExtralockTimer();
				ExtralockTimerHard();
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (!extremeDiff)
			{
				extremeDiff = true;
				ExtralockTimer();
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4 && !practiseDiff)
		{
			practiseDiff = true;
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				ExtralockTimerHard();
				extraLockExtreme.SetActive(true);
			}
			ExtralockTimer();
			((Collider)Granny.gameObject.GetComponent(typeof(Collider))).enabled = false;
			((Renderer)GrannySkin.gameObject.GetComponent(typeof(Renderer))).enabled = false;
			GrannyBone.SetActive(false);
		}
	}

	public virtual IEnumerator openExitdoor()
	{
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18)
		{
			if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && !((PickUp)(object)GameObject.Find("PickUp").GetComponent(typeof(PickUp))).CrowPoisoned)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				PlayerPrefs.SetInt("Anomaly18Escape", 1);
				CheckDoorEscapeAchievements();
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && ((PickUp)(object)GameObject.Find("PickUp").GetComponent(typeof(PickUp))).CrowPoisoned)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				PlayerPrefs.SetInt("Anomaly18CrowEscape", 1);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).textTimerOnOff = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).textTimer = 0f;
			}
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 27)
		{
			AchievementSaveManager.Instance.UnlockAchievement("AnEasierPath");
			playerStop = GameObject.Find("Main Camera");
			playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
			((Behaviour)playerStopscript).enabled = false;
			swipe.SetActive(false);
			joystick.SetActive(false);
			crouchButton.SetActive(false);
			trapButton.SetActive(false);
			removeBar.fillAmount = 0f;
			trapBar.SetActive(false);
			((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
			((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
			((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
			yield return (object)new WaitForSeconds(5f);
			PlayerPrefs.SetInt("Anomaly27DoorEscape", 1);
			CheckDoorEscapeAchievements();
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			playerStop = GameObject.Find("Main Camera");
			playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
			((Behaviour)playerStopscript).enabled = false;
			swipe.SetActive(false);
			joystick.SetActive(false);
			crouchButton.SetActive(false);
			trapButton.SetActive(false);
			removeBar.fillAmount = 0f;
			trapBar.SetActive(false);
			((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
			((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
			((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
			yield return (object)new WaitForSeconds(5f);
			PlayerPrefs.SetInt("EventChallenge2Completed", 1);
			gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
			SceneManager.LoadScene("EndScene");
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			playerStop = GameObject.Find("Main Camera");
			playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
			((Behaviour)playerStopscript).enabled = false;
			swipe.SetActive(false);
			joystick.SetActive(false);
			crouchButton.SetActive(false);
			trapButton.SetActive(false);
			removeBar.fillAmount = 0f;
			trapBar.SetActive(false);
			((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
			((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
			((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
			yield return (object)new WaitForSeconds(5f);
			PlayerPrefs.SetInt("EventChallenge3Completed", 1);
			SceneManager.LoadScene("EndScene");
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 27 || PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			yield break;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
				{
					playerStop = GameObject.Find("Main Camera");
					playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
					((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					((Behaviour)playerStopscript).enabled = false;
					swipe.SetActive(false);
					joystick.SetActive(false);
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
					yield return (object)new WaitForSeconds(5f);
					CheckDoorEscapeAchievements();
				}
				else
				{
					PickUpScript.ShowText2("I can't open the door yet.");
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
				{
					playerStop = GameObject.Find("Main Camera");
					playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
					((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					((Behaviour)playerStopscript).enabled = false;
					swipe.SetActive(false);
					joystick.SetActive(false);
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
					yield return (object)new WaitForSeconds(5f);
					CheckDoorEscapeAchievements();
				}
				else
				{
					PickUpScript.ShowText2("I can't open the door yet.");
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
		{
			if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				if (PlayerPrefs.GetInt("EventTrap") == 1)
				{
					PlayerPrefs.SetInt("EventCompleted", 1);
				}
				if (PlayerPrefs.GetInt("DiffData") == 7)
				{
					PlayerPrefs.SetInt("PrimeEnjoyer", 1);
				}
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
			{
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 9)
				{
					player.transform.position = new Vector3(-3.35f, 14.7f, 20.9f);
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveexitKey = false;
					((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).exitKey.SetActive(false);
					((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).dropObjectButton.SetActive(false);
					yield break;
				}
				if (PlayerPrefs.GetInt("PrimeOn") == 0)
				{
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).attackDistance = 800f;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).PrimeNowIsOn = true;
					yield break;
				}
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("NerfedPrimeOnOff") != 1)
				{
					PlayerPrefs.SetInt("PrimeEnjoyer", 1);
				}
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
				{
					playerStop = GameObject.Find("Main Camera");
					playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
					((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					((Behaviour)playerStopscript).enabled = false;
					swipe.SetActive(false);
					joystick.SetActive(false);
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
					yield return (object)new WaitForSeconds(5f);
					CheckDoorEscapeAchievements();
				}
				else
				{
					PickUpScript.ShowText2("I can't open the door yet.");
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && !extraLockPlaced)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
		{
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
				{
					playerStop = GameObject.Find("Main Camera");
					playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
					((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					((Behaviour)playerStopscript).enabled = false;
					swipe.SetActive(false);
					joystick.SetActive(false);
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
					yield return (object)new WaitForSeconds(5f);
					CheckDoorEscapeAchievements();
				}
				else
				{
					PickUpScript.ShowText2("I can't open the door yet.");
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && !extraLockPlaced)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
			else
			{
				PickUpScript.ShowText2("I can't open the door yet.");
			}
		}
		else
		{
			if (PlayerPrefs.GetInt("DiffData") != -1)
			{
				yield break;
			}
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				if (lampa1ok && lampa2ok && planka1Bort && planka2Bort && hangLockBort && extraLockPlaced && DpadlockBort && batteryLockOk && extremeLockOk && ButtonsLockOk)
				{
					playerStop = GameObject.Find("Main Camera");
					playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
					((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
					((Behaviour)playerStopscript).enabled = false;
					swipe.SetActive(false);
					joystick.SetActive(false);
					crouchButton.SetActive(false);
					trapButton.SetActive(false);
					removeBar.fillAmount = 0f;
					trapBar.SetActive(false);
					((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
					((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
					((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
					((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
					yield return (object)new WaitForSeconds(5f);
					CheckDoorEscapeAchievements();
				}
				else
				{
					PickUpScript.ShowText2("I can't open the door yet.");
				}
			}
			else if (lampa1ok && lampa2ok && planka1Bort && planka2Bort)
			{
				playerStop = GameObject.Find("Main Camera");
				playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
				((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((Behaviour)playerStopscript).enabled = false;
				swipe.SetActive(false);
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				trapButton.SetActive(false);
				removeBar.fillAmount = 0f;
				trapBar.SetActive(false);
				((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
				((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
				((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
				yield return (object)new WaitForSeconds(5f);
				CheckDoorEscapeAchievements();
			}
		}
	}

	public virtual void ExtralockTimer()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		extraLockPlaced = true;
		extraLock.SetActive(true);
		if (PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			padlockCodePL2.SetActive(true);
			padlockCodePL2.transform.position = new Vector3(-6.09f, 9.3f, -10.07f);
			padlockCodePL2.transform.rotation = Quaternion.Euler(-180f, -90f, -172f);
		}
		if ((float)gameController.GetComponent<startNewDay>().AnomalyNR != 13f && (float)gameController.GetComponent<startNewDay>().AnomalyNR != 18f && PlayerPrefs.GetInt("EventChallenge1") != 1)
		{
			if (gameController.GetComponent<startNewDay>().PresetTV == "1" || gameController.GetComponent<startNewDay>().PresetTV == "6")
			{
				padlockCodePL2.SetActive(true);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "2")
			{
				padlockCodePL3.SetActive(true);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "3")
			{
				padlockCodePL4.SetActive(true);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "4")
			{
				padlockCodePL5.SetActive(true);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "5")
			{
				padlockCodePL1.SetActive(true);
				padlockCodePL1.transform.SetParent((Transform)null);
				padlockCodePL1.transform.position = new Vector3(-8.9984f, 29.39f, -5.276f);
				padlockCodePL1.transform.rotation = Quaternion.Euler(0f, 90f, -13.3f);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "6")
			{
				padlockCodePL2.SetActive(true);
				padlockCodePL2.transform.position = new Vector3(-8.05f, 23.185f, -2.504f);
				padlockCodePL2.transform.rotation = Quaternion.Euler(0f, 90f, 14.2f);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "7")
			{
				padlockCodePL1.SetActive(true);
				padlockCodePL1.transform.SetParent((Transform)null);
				padlockCodePL1.transform.position = new Vector3(-16.471317f, 16.002163f, -3.7627263f);
				padlockCodePL1.transform.rotation = Quaternion.Euler(180f, -90f, -159.8975f);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "8")
			{
				padlockCodePL2.SetActive(true);
				padlockCodePL2.transform.SetParent((Transform)null);
				padlockCodePL2.transform.position = new Vector3(-6.441f, 5.678f, -6.732f);
				padlockCodePL2.transform.rotation = Quaternion.Euler(0f, 0f, -20f);
			}
			if (gameController.GetComponent<startNewDay>().PresetTV == "9")
			{
				padlockCodePL2.SetActive(true);
				padlockCodePL2.transform.SetParent((Transform)null);
				padlockCodePL2.transform.position = new Vector3(-14.57f, 21.505f, -0.5f);
				padlockCodePL2.transform.rotation = Quaternion.Euler(-90f, 0f, 31f);
			}
		}
		if ((float)GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 18f)
		{
			Anomaly18PadlockCode = Random.Range(1, 5);
			if (Anomaly18PadlockCode == 1f)
			{
				padlockCodePL3.SetActive(true);
			}
			if (Anomaly18PadlockCode == 2f)
			{
				padlockCodePL3.SetActive(true);
				padlockCodePL3.transform.position = new Vector3(-2.6881402f, 9.521259f, 5.1609573f);
				padlockCodePL3.transform.rotation = Quaternion.Euler(271.5f, -99.37f, 5.16f);
			}
			if (Anomaly18PadlockCode == 3f)
			{
				padlockCodePL3.SetActive(true);
				padlockCodePL3.transform.position = new Vector3(16.7071f, 17.83f, -0.58f);
				padlockCodePL3.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
			}
			if (Anomaly18PadlockCode == 4f)
			{
				padlockCodePL3.SetActive(true);
				padlockCodePL3.transform.position = new Vector3(19.013731f, 23.85128f, 0.9509721f);
				padlockCodePL3.transform.rotation = Quaternion.Euler(0f, 0f, 7.2f);
			}
			if (Anomaly18PadlockCode == 5f)
			{
				padlockCodePL3.SetActive(true);
				padlockCodePL3.transform.position = new Vector3(-8.05f, 23.185f, -2.504f);
				padlockCodePL3.transform.rotation = Quaternion.Euler(0f, 90f, 14.2f);
			}
			if (Anomaly18PadlockCode == 6f)
			{
				padlockCodePL5.SetActive(true);
			}
			if (Anomaly18PadlockCode == 7f)
			{
				padlockCodePL3.SetActive(true);
				padlockCodePL3.transform.SetParent((Transform)null);
				padlockCodePL3.transform.position = new Vector3(-1.9f, 17.12f, -1.83f);
			}
		}
	}

	public virtual void ExtralockTimerHard()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		extraLockHard.SetActive(true);
		if (PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			battery1.SetActive(true);
			battery1.transform.position = new Vector3(34.1f, 14.28f, -6.24f);
			battery1.transform.rotation = Quaternion.Euler(-90f, 0f, 130f);
		}
		if ((float)GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 13f || (float)GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 18f || PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			return;
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "1")
		{
			battery2.SetActive(true);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "2")
		{
			battery3.SetActive(true);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "3")
		{
			battery4.SetActive(true);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "4")
		{
			battery5.SetActive(true);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "5")
		{
			battery1.SetActive(true);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "6")
		{
			battery2.SetActive(true);
			battery2.transform.position = new Vector3(34.1f, 14.28f, -6.24f);
			battery2.transform.rotation = Quaternion.Euler(-90f, 0f, 130f);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "7")
		{
			battery1.SetActive(true);
			battery1.transform.SetParent((Transform)null);
			battery1.transform.position = new Vector3(12.477f, 22.152f, 11.707f);
			battery1.transform.rotation = Quaternion.Euler(-90f, 0f, 115.5f);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "8")
		{
			battery2.SetActive(true);
			battery2.transform.position = new Vector3(15.033f, 13.563f, 0.671f);
			battery2.transform.rotation = Quaternion.Euler(-90f, 0f, -134f);
		}
		if (gameController.GetComponent<startNewDay>().PresetTV == "9")
		{
			battery2.SetActive(true);
			battery2.transform.position = new Vector3(33.28f, 23.4f, -10.293f);
			battery2.transform.rotation = Quaternion.Euler(-90f, 37.9f, 180f);
			if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR == 18)
			{
				battery2.transform.position = new Vector3(6.8325f, 13.51f, -22.0682f);
				battery2.transform.rotation = Quaternion.Euler(-180f, -110.308f, 129.314f);
				battery2.transform.localScale = new Vector3(0.15f, 0.15f, 0.2334165f);
			}
		}
	}

	public virtual IEnumerator LiftEscape()
	{
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((Behaviour)playerStopscript).enabled = false;
		swipe.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(5f);
		gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
		AchievementSaveManager.Instance.UnlockAchievement("TheBrokenElevator");
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AllProgress = true;
		playerStop.transform.SetParent((Transform)null);
		playerStop.transform.position = new Vector3(-17.6f, 17f, -11.2f);
		((Collider)playerStop.GetComponent<CharacterController>()).enabled = false;
		playerStop.transform.localRotation = Quaternion.Euler(12f, 0f, 0f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
		GameObject.Find("HandHoldObjects").SetActive(false);
		if (Object.op_Implicit((Object)(object)GameObject.Find("DifferentSpritesAndButtons")))
		{
			GameObject.Find("DifferentSpritesAndButtons").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootArrowButtonParent")))
		{
			GameObject.Find("ShootArrowButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("DropButtonParent")))
		{
			GameObject.Find("DropButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootGunButtonParent")))
		{
			GameObject.Find("ShootGunButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("OptionButtonParent")))
		{
			GameObject.Find("OptionButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("BloodScreens")))
		{
			GameObject.Find("BloodScreens").SetActive(false);
		}
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TVText.SetActive(true);
		EndingStarted = true;
		yield return (object)new WaitForSeconds(5f);
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).clickRemote();
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).channelCount = 10;
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).channelCount = 11;
			PlayerPrefs.SetInt("Anomaly9Escape", 0);
		}
		else if (PlayerPrefs.GetInt("Anomaly9Escape") == 1)
		{
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).channelCount = 19;
			PlayerPrefs.SetInt("Anomaly9Escape", 0);
		}
		yield return (object)new WaitForSeconds(8f);
		EndingStarted2 = true;
		yield return (object)new WaitForSeconds(1f);
		((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).gameObject.SetActive(true);
		yield return (object)new WaitForSeconds(5f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 1f, false);
		yield return (object)new WaitForSeconds(3f);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual IEnumerator LiftEscapeTeddy()
	{
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((Behaviour)playerStopscript).enabled = false;
		swipe.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(5f);
		gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
		AchievementSaveManager.Instance.UnlockAchievement("RageBaitEnding");
		AchievementSaveManager.Instance.UnlockAchievement("TheBrokenElevator");
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AllProgress = true;
		playerStop.transform.SetParent((Transform)null);
		playerStop.transform.position = new Vector3(-17.6f, 17f, -11.2f);
		((Collider)playerStop.GetComponent<CharacterController>()).enabled = false;
		playerStop.transform.localRotation = Quaternion.Euler(12f, 0f, 0f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
		GameObject.Find("HandHoldObjects").SetActive(false);
		if (Object.op_Implicit((Object)(object)GameObject.Find("DifferentSpritesAndButtons")))
		{
			GameObject.Find("DifferentSpritesAndButtons").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootArrowButtonParent")))
		{
			GameObject.Find("ShootArrowButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("DropButtonParent")))
		{
			GameObject.Find("DropButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootGunButtonParent")))
		{
			GameObject.Find("ShootGunButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("OptionButtonParent")))
		{
			GameObject.Find("OptionButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("BloodScreens")))
		{
			GameObject.Find("BloodScreens").SetActive(false);
		}
		gameController.GetComponent<startNewDay>().TVText.SetActive(true);
		EndingStarted = true;
		yield return (object)new WaitForSeconds(5f);
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).clickRemote();
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).channelCount = 12;
		PlayerPrefs.SetInt("Anomaly9Escape", 0);
		yield return (object)new WaitForSeconds(12f);
		EndingStarted2 = true;
		yield return (object)new WaitForSeconds(1f);
		((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).gameObject.SetActive(true);
		yield return (object)new WaitForSeconds(5f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 1f, false);
		yield return (object)new WaitForSeconds(3f);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual IEnumerator Anomaly18Escape()
	{
		AchievementSaveManager.Instance.UnlockAchievement("GreenDoorEscape");
		gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((Behaviour)playerStopscript).enabled = false;
		swipe.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(5f);
		playerStop.transform.SetParent((Transform)null);
		playerStop.transform.position = new Vector3(-17.6f, 17f, -11.2f);
		((Collider)playerStop.GetComponent<CharacterController>()).enabled = false;
		playerStop.transform.localRotation = Quaternion.Euler(12f, 0f, 0f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
		GameObject.Find("HandHoldObjects").SetActive(false);
		if (Object.op_Implicit((Object)(object)GameObject.Find("DifferentSpritesAndButtons")))
		{
			GameObject.Find("DifferentSpritesAndButtons").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootArrowButtonParent")))
		{
			GameObject.Find("ShootArrowButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("DropButtonParent")))
		{
			GameObject.Find("DropButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ShootGunButtonParent")))
		{
			GameObject.Find("ShootGunButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("OptionButtonParent")))
		{
			GameObject.Find("OptionButtonParent").SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("BloodScreens")))
		{
			GameObject.Find("BloodScreens").SetActive(false);
		}
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TVText.SetActive(true);
		EndingStarted = true;
		yield return (object)new WaitForSeconds(5f);
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).clickRemote();
		((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).channelCount = 18;
		yield return (object)new WaitForSeconds(8f);
		EndingStarted2 = true;
		yield return (object)new WaitForSeconds(1f);
		((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).gameObject.SetActive(true);
		yield return (object)new WaitForSeconds(5f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 1f, false);
		yield return (object)new WaitForSeconds(3f);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual IEnumerator Anomaly18BadEnding()
	{
		CommentText.GetComponent<Text>().text = "You failed the exploration of the past: you were eaten in Granny's basement./r/n/r/nEnding 1/4";
		yield return (object)new WaitForSeconds(25f);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual IEnumerator GabonAnomaly11Ending()
	{
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		if (gameController.GetComponent<startNewDay>().GrannyGauntlet)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 1);
		}
		yield return (object)new WaitForSeconds(5f);
		((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).gameObject.SetActive(true);
		((Graphic)((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).GetComponent<Image>()).color = Color.magenta;
		((Component)GameObject.Find("TheEndTexts").transform.GetChild(0)).GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 100f);
		yield return (object)new WaitForSeconds(5f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 1f, false);
		yield return (object)new WaitForSeconds(3f);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual IEnumerator Anomaly27Escape()
	{
		PlayerPrefs.SetInt("Anomaly27Levels", PlayerPrefs.GetInt("Anomaly27Levels") + 1);
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((Behaviour)playerStopscript).enabled = false;
		swipe.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(5f);
		SceneManager.LoadScene("Scene");
	}

	public virtual IEnumerator PrimeAnomaly9Escape()
	{
		if (PlayerPrefs.GetInt("PrimeOn") == 0)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).attackDistance = 800f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).PrimeNowIsOn = true;
			yield break;
		}
		playerStop = GameObject.Find("Main Camera");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((Behaviour)playerStopscript).enabled = false;
		swipe.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		trapButton.SetActive(false);
		removeBar.fillAmount = 0f;
		trapBar.SetActive(false);
		((openDoors)(object)dooropener.GetComponent(typeof(openDoors))).playerTaken = true;
		((PickUp)(object)seeHolder.GetComponent(typeof(PickUp))).playerTaken = true;
		((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).openExitDoor();
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(5f);
		gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
		SceneManager.LoadScene("EndScene");
	}

	public void CheckDoorEscapeAchievements()
	{
		gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
		if (!PickUpScript.IrrationalEscapeFailed && gameController.GetComponent<startNewDay>().AnomalyNR != 27)
		{
			AchievementSaveManager.Instance.UnlockAchievement("IrrationalCruelBeat");
		}
		SceneManager.LoadScene("EndScene");
	}
}
