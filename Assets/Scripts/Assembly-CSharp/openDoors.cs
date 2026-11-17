using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

[Serializable]
public class openDoors : MonoBehaviour
{
	public GameObject Anomaly36Collectibles;

	public GameObject mittenRing;

	public PickUp PickUpScript;

	public AudioClip Micro18Anomaly;

	public LayerMask layerMask;

	public GameObject granny;

	public GameObject gameController;

	public GameObject openDoorButton;

	public GameObject removeBTButton;

	public bool resetBTbutton;

	public GameObject doorRay;

	public bool openTheDoor;

	public bool playerTaken;

	public bool removeBeartrap;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject joystick;

	public GameObject microSparks;

	public AudioClip doorLocked;

	public AudioClip microDoor;

	public AudioClip fingerFan;

	public AudioClip giljotinLjud;

	public AudioClip doorLockedLjud;

	public AudioClip secretDoorButton;

	public AudioClip garagePortSound;

	public AudioClip bakluckaLocked;

	public AudioClip brokenCarDoor;

	public AudioClip switchOnOff;

	public AudioClip bastuBomNer;

	public AudioClip bokhyllaLjud;

	public AudioClip crowAttack;

	public AudioClip burDoor;

	public AudioClip moveGaller;

	public AudioClip readNote;

	public bool playSound;

	public GameObject bloodScreenHolder;

	public bool playerFanHurt;

	public bool garageportLock;

	public GameObject garageportAnimHolder;

	public GameObject carSensorFront;

	public GameObject needCarkeyText;

	public GameObject garageportLockedText;

	public bool textTimerOnOff;

	public float textTimer;

	public bool canJumpOut;

	public bool canJumpIn;

	public GameObject camOutToIn;

	public GameObject camInToOut;

	public GameObject winController;

	public GameObject checkPcrouch;

	public GameObject giljotin;

	public GameObject secretDoor;

	public GameObject secretDoorTrigger;

	public GameObject bastuSpak;

	public GameObject bastuSteam;

	public GameObject bastuBom;

	public GameObject bastuDoor;

	public NavMeshObstacle bastuDoorCarv;

	public GameObject noiceObjectBastu;

	public bool droppedNoiceObj;

	public GameObject tavelspak;

	public GameObject bokhylla;

	public bool playerTrySteal;

	public GameObject Crow;

	public GameObject Button1;

	public GameObject Button2;

	public GameObject Button3;

	public GameObject Button4;

	public GameObject Button5;

	public GameObject Button1T;

	public GameObject Button2T;

	public GameObject Button3T;

	public GameObject Button4T;

	public GameObject Button5T;

	public GameObject Lamp1T;

	public GameObject Lamp2T;

	public GameObject Lamp3T;

	public GameObject Lamp4T;

	public GameObject Lamp5T;

	public int CountButtons;

	public GameObject Door1;

	public GameObject Door2;

	public GameObject Door3;

	public GameObject Door4;

	public GameObject Door5;

	public GameObject Door6;

	public GameObject Door7;

	public GameObject Door8;

	public GameObject Door9;

	public int Lives;

	public Resources canvas;

	public GameObject NewText;

	public GameObject C;

	public float RayDistance;

	public GameObject CommentText;

	public GameObject Door10;

	public GameObject Door11;

	public GameObject Door12;

	public GameObject Door13;

	public GameObject EatingText;

	public int EatingScore;

	public int SecretLetter;

	public GameObject Door14;

	public GameObject Door15;

	public GameObject Door16;

	public GameObject Door17;

	public GameObject Door18;

	public GameObject Door19;

	public GameObject Door20;

	public GameObject Door21;

	public int WeaponWallCount;

	public int RedKeyLetterCount;

	public int AnomalyLetterCount;

	private bool buffhandAnomaly44;

	public bool closeSpiderAchievement;

	public void PressOpenDoors()
	{
		openTheDoor = true;
		playSound = false;
	}

	public virtual void Start()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0add: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		RayDistance = 4f;
		CommentText = DefaultControls.CreateText(canvas);
		CommentText.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
		CommentText.GetComponent<Text>().text = "";
		((Graphic)CommentText.GetComponent<Text>()).color = Color.white;
		CommentText.GetComponent<Text>().fontStyle = (FontStyle)0;
		CommentText.GetComponent<Text>().alignment = (TextAnchor)4;
		CommentText.GetComponent<Text>().resizeTextForBestFit = true;
		CommentText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
		CommentText.GetComponent<Text>().fontSize = 0;
		CommentText.GetComponent<Text>().resizeTextMaxSize = 50;
		CommentText.GetComponent<RectTransform>().sizeDelta = new Vector2(800f, 30f);
		CommentText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		CommentText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		CommentText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -52f);
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 7 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 7)
		{
			RayDistance = 10f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 35)
		{
			RayDistance = 2f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 44)
		{
			RayDistance = 5f;
			buffhandAnomaly44 = true;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 8 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 8)
		{
			GameObject.Find("Baklucka").GetComponent<Animation>().Play("bakluckaOpen");
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).OpenedCarTrunk = true;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 94)
		{
			EatingText = DefaultControls.CreateText(canvas);
			C = GameObject.Find("All days texter");
			EatingText.transform.SetParent(C.GetComponent<Transform>());
			EatingText.GetComponent<Text>().text = "Gabon";
			((Graphic)EatingText.GetComponent<Text>()).color = Color.green;
			EatingText.GetComponent<Text>().fontStyle = (FontStyle)1;
			EatingText.GetComponent<Text>().alignment = (TextAnchor)5;
			EatingText.GetComponent<Text>().resizeTextForBestFit = true;
			EatingText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EatingText.GetComponent<Text>().fontSize = 0;
			EatingText.GetComponent<Text>().resizeTextMaxSize = 88;
			EatingText.GetComponent<RectTransform>().sizeDelta = new Vector2(556f, 30f);
			EatingText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			EatingText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			EatingText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 200f);
		}
		if ((PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("twoLocksOnOff") == 1 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7 || PlayerPrefs.GetInt("EventChallenge1") == 1) && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 18 && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 27 && PlayerPrefs.GetInt("EventChallenge3") == 0 && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 36)
		{
			Button1 = Object.Instantiate<GameObject>(GameObject.Find("GrannyHouse8Update/SecretDoorParent/SecretDoorButton"), new Vector3(-7.668f, 16.82f, 1.643f), Quaternion.Euler(0f, 90f, 0f));
			Button1.transform.SetParent((Transform)null);
			Button1.tag = "kitchenDoor2Closed";
			Button1.transform.localScale = new Vector3(0.2256523f, 0.2256523f, 0.2256523f);
			Button1T = Object.Instantiate<GameObject>(GameObject.Find("GrannyHouse8Update/SecretDoorParent/KnappSecretDoor"), new Vector3(-7.54f, 16.827f, 1.635f), Quaternion.Euler(-180f, 90f, 0f));
			Button1T.transform.SetParent((Transform)null);
			Button1T.transform.localScale = new Vector3(0.01008094f, 0.01028205f, 0.01028205f);
			Lamp1T = Object.Instantiate<GameObject>(GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa"), new Vector3(-0.5f, 20f, 13.96f), Quaternion.Euler(0f, -90f, 0f));
			Lamp1T.transform.SetParent((Transform)null);
			Lamp1T.transform.localScale = new Vector3(27.07f, 72.39619f, 46.78562f);
			Button2 = Object.Instantiate<GameObject>(Button1, new Vector3(11.077f, 4.44f, -4.14f), Quaternion.Euler(0f, 90f, 0f));
			Button2.tag = "vitrindoorVRLclosed";
			Button2T = Object.Instantiate<GameObject>(Button1T, new Vector3(11.205f, 4.447f, -4.148f), Quaternion.Euler(-180f, 90f, 0f));
			Lamp2T = Object.Instantiate<GameObject>(Lamp1T, new Vector3(0f, 20f, 13.96f), Quaternion.Euler(0f, -90f, 0f));
			Button3 = Object.Instantiate<GameObject>(Button1, new Vector3(19.532f, 23.54f, 8.903f), Quaternion.Euler(0f, 90f, 0f));
			Button3.tag = "vitrindoorVRLopen";
			Button3T = Object.Instantiate<GameObject>(Button1T, new Vector3(19.66f, 23.547f, 8.895f), Quaternion.Euler(-180f, 90f, 0f));
			Lamp3T = Object.Instantiate<GameObject>(Lamp1T, new Vector3(0.5f, 20f, 13.96f), Quaternion.Euler(0f, -90f, 0f));
			Button4 = Object.Instantiate<GameObject>(Button1, new Vector3(5.51f, 10.204f, -40.673f), Quaternion.Euler(0f, 0f, 0f));
			Button4.tag = "vitrindoorVRRclosed";
			Button4T = Object.Instantiate<GameObject>(Button1T, new Vector3(5.55f, 10.211f, -40.55f), Quaternion.Euler(-180f, 0f, 0f));
			Lamp4T = Object.Instantiate<GameObject>(Lamp1T, new Vector3(-1f, 20f, 13.96f), Quaternion.Euler(0f, -90f, 0f));
			Button5 = Object.Instantiate<GameObject>(Button1, new Vector3(31.86f, 18.82f, -2.411f), Quaternion.Euler(0f, 0f, 0f));
			Button5.tag = "vitrindoorVRRopen";
			Button5T = Object.Instantiate<GameObject>(Button1T, new Vector3(31.9f, 18.827f, -2.288f), Quaternion.Euler(-180f, 0f, 0f));
			Lamp5T = Object.Instantiate<GameObject>(Lamp1T, new Vector3(-1.5f, 20f, 13.96f), Quaternion.Euler(0f, -90f, 0f));
		}
		if ((PlayerPrefs.GetInt("LaserOnOffOnOff") != 1 && PlayerPrefs.GetInt("DiffData") != 6 && PlayerPrefs.GetInt("DiffData") != 7) || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 36)
		{
			return;
		}
		Door1 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/Vind2_2/Vind2Door_**"), new Vector3(-10.25f, 15.98f, -1.7f), Quaternion.identity);
		Door1.transform.localScale = new Vector3(0.3366732f, 0.2256523f, 0.06917591f);
		((Renderer)(MeshRenderer)Door1.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", new Color(1f, 0f, 0f));
		((Renderer)(MeshRenderer)Door1.GetComponent(typeof(MeshRenderer))).material.SetColor("_EmissionColor", new Color(0.7f, 0f, 0f));
		Door1.tag = "kitchenDoor2Open";
		Object.Destroy((Object)(object)Door1.GetComponent<Animation>());
		Object.Destroy((Object)(object)Door1.GetComponent<AudioSource>());
		Object.Destroy((Object)(object)Door1.GetComponent<changeTextureNightmare>());
		Door1.AddComponent<NavMeshObstacle>();
		Door1.GetComponent<NavMeshObstacle>().carving = true;
		Door2 = Object.Instantiate<GameObject>(Door1, new Vector3(-18.11f, 22.74f, -1.7f), Quaternion.identity);
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 27)
		{
			Door3 = Object.Instantiate<GameObject>(Door1, new Vector3(-2.9f, 4.34f, 6.8f), Quaternion.Euler(0f, 180f, -180f));
			Door4 = Object.Instantiate<GameObject>(Door1, new Vector3(6.3f, 11.55f, -16.74f), Quaternion.Euler(-90f, 0f, -180f));
			Door4.transform.localScale = new Vector3(0.24399528f, 0.113207154f, 0.06917591f);
		}
		Door5 = Object.Instantiate<GameObject>(Door1, new Vector3(6.46f, 10.29f, 6.33f), Quaternion.Euler(0f, 180f, -180f));
		Door5.transform.localScale = new Vector3(0.36921424f, 0.2415414f, 0.06917591f);
		Door6 = Object.Instantiate<GameObject>(Door1, new Vector3(-5.22f, 8.91f, -12.38f), Quaternion.Euler(0f, 180f, -180f));
		Door7 = Object.Instantiate<GameObject>(Door1, new Vector3(4.82f, 14.7f, -25.3f), Quaternion.identity);
		Door7.transform.localScale = new Vector3(0.11679194f, 0.2256523f, 0.06917591f);
		Door8 = Object.Instantiate<GameObject>(Door1, new Vector3(-5.41f, 20.04f, -24.71f), Quaternion.Euler(0f, 8.6378f, -180f));
		Door8.transform.localScale = new Vector3(0.54333496f, 0.2256523f, 0.06917591f);
		((Object)Door8).name = "WeaponWall";
		Door9 = Object.Instantiate<GameObject>(Door1, new Vector3(10.77f, 16.59f, 1.54f), Quaternion.Euler(0f, 90f, -180f));
		Door9.transform.localScale = new Vector3(0.5594293f, 0.27622098f, 0.0691759f);
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 18)
		{
			Door11 = Object.Instantiate<GameObject>(Door1, new Vector3(6.7865f, 16.59f, -4.5488f), Quaternion.Euler(0f, 75.189f, -180f));
			Door11.transform.localScale = new Vector3(0.5424387f, 0.27622098f, 0.0691759f);
			Door12 = Object.Instantiate<GameObject>(Door1, new Vector3(25.4753f, 14.72f, -14.5976f), Quaternion.Euler(0f, -52.05f, -180f));
			Door12.transform.localScale = new Vector3(0.88489944f, 0.27f, 0.06917591f);
			Door13 = Object.Instantiate<GameObject>(Door1, new Vector3(0.587f, 4.3914f, -3.5661f), Quaternion.Euler(0f, 90f, -180f));
			Door13.transform.localScale = new Vector3(0.3817401f, 0.25315723f, 0.0691759f);
			Door14 = Object.Instantiate<GameObject>(Door1, new Vector3(4.61f, 14.474f, 2.954f), Quaternion.Euler(0f, 180f, -180f));
			Door14.transform.localScale = new Vector3(0.25228292f, 0.09769589f, 0.06917591f);
			((Object)Door14).name = "NightmareWall14";
			Door17 = Object.Instantiate<GameObject>(Door1, new Vector3(-8.37f, 18.3233f, 5.8992f), Quaternion.Euler(0f, -90f, -180f));
			Door17.transform.localScale = new Vector3(0.19621503f, 0.05887203f, 0.06917591f);
			Door18 = Object.Instantiate<GameObject>(Door1, new Vector3(21.41f, 21.9688f, 7.056f), Quaternion.Euler(0f, 180f, -180f));
			Door18.transform.localScale = new Vector3(0.13139191f, 0.08530138f, 0.06917591f);
			Door19 = Object.Instantiate<GameObject>(Door1, new Vector3(5.323f, 34.4774f, 8.8592f), Quaternion.Euler(0f, 224.82f, -180f));
			Door19.transform.localScale = new Vector3(0.14621292f, 0.085552365f, 0.08237904f);
			Door20 = Object.Instantiate<GameObject>(Door1, new Vector3(-16.78f, 13.8f, -3.9f), Quaternion.Euler(0f, 180f, 180f));
			Door20.transform.localScale = new Vector3(0.4228669f, 0.03116169f, 0.06917591f);
			Door21 = Object.Instantiate<GameObject>(Door1, new Vector3(-9.47f, 21.07f, -2.93f), Quaternion.Euler(0f, 180f, 180f));
			Door21.transform.localScale = new Vector3(0.2631072f, 0.03400987f, 0.06917591f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR != 6)
				{
					Door15 = Object.Instantiate<GameObject>(Door1, new Vector3(-14.19f, 16.58f, 2.13f), Quaternion.Euler(0f, 0f, -180f));
					Door15.transform.localScale = new Vector3(1.2532862f, 0.28201512f, 0.069175914f);
					Door15.GetComponent<NavMeshObstacle>().carving = false;
				}
				Door16 = Object.Instantiate<GameObject>(Door1, new Vector3(6.57f, 9.86f, -36.49f), Quaternion.Euler(0f, 0f, -180f));
				Door16.transform.localScale = new Vector3(0.42741585f, 0.19837266f, 0.069175914f);
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 4)
				{
					Door2.SetActive(false);
					Door4.SetActive(false);
					Door5.SetActive(false);
					Door9.SetActive(false);
					Door11.SetActive(false);
					Door12.SetActive(false);
				}
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 18)
				{
					Door12.SetActive(false);
				}
			}
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 19)
		{
			Door1.SetActive(false);
			Door2.SetActive(false);
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			Door3.SetActive(false);
			Door7.SetActive(false);
			Door11.SetActive(false);
			Door14.SetActive(false);
		}
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1358: Unknown result type (might be due to invalid IL or missing references)
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_186b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_225a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2265: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_282a: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_27fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2600: Unknown result type (might be due to invalid IL or missing references)
		//IL_2616: Unknown result type (might be due to invalid IL or missing references)
		//IL_2620: Unknown result type (might be due to invalid IL or missing references)
		//IL_262b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2681: Unknown result type (might be due to invalid IL or missing references)
		//IL_2691: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_29be: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_31f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_31fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_3024: Unknown result type (might be due to invalid IL or missing references)
		//IL_302f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3450: Unknown result type (might be due to invalid IL or missing references)
		//IL_345b: Unknown result type (might be due to invalid IL or missing references)
		//IL_325e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3269: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_34bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_398d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3998: Unknown result type (might be due to invalid IL or missing references)
		//IL_39f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_3715: Unknown result type (might be due to invalid IL or missing references)
		//IL_3720: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_377f: Unknown result type (might be due to invalid IL or missing references)
		//IL_378a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fec: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_444d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4238: Unknown result type (might be due to invalid IL or missing references)
		//IL_4243: Unknown result type (might be due to invalid IL or missing references)
		//IL_4056: Unknown result type (might be due to invalid IL or missing references)
		//IL_4061: Unknown result type (might be due to invalid IL or missing references)
		//IL_42a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_42af: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_4df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_46a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_46b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_4711: Unknown result type (might be due to invalid IL or missing references)
		//IL_471c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_5cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ecc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fff: Unknown result type (might be due to invalid IL or missing references)
		//IL_606e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6082: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(doorRay.transform.position, val2, ref val, RayDistance, layerMask.value))
			{
				if (((Component)val.collider).gameObject.tag == "innerdoorClosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "innerdoorOpen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorClose");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "steeldoorLocked" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 25)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((SkjutplattaDoor)(object)GameObject.Find("SkjutplattaCollider").GetComponent(typeof(SkjutplattaDoor))).doorUnlocked = true;
					}
				}
				else if (((Component)val.collider).gameObject.tag == "steeldoorLocked" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveDoorUnlock)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((SkjutplattaDoor)(object)GameObject.Find("SkjutplattaCollider").GetComponent(typeof(SkjutplattaDoor))).doorUnlocked = true;
					}
				}
				else if (((Component)val.collider).gameObject.tag == "innerdoorLocked" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveDoorUnlock && ((Object)((Component)val.collider).gameObject).name != "LekhusDoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "innerdoorLocked" || ((Component)val.collider).gameObject.tag == "steeldoorLocked" || ((Component)val.collider).gameObject.tag == "lekhusDoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "smalldoorClosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("SmallDoorOpen");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "smalldoorOpen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("SmallDoorClose");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "smalldoorLocked")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("SmallDoorLocked");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "vitrindoorVRLclosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						playSound = true;
						CountButtons++;
						((Renderer)(MeshRenderer)Lamp2T.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
						Object.Destroy((Object)(object)Button2T);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressValue += 2;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "vitrindoorVRLopen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						playSound = true;
						CountButtons++;
						((Renderer)(MeshRenderer)Lamp3T.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
						Object.Destroy((Object)(object)Button3T);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressValue += 2;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "vitrindoorVRRclosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						playSound = true;
						CountButtons++;
						((Renderer)(MeshRenderer)Lamp4T.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
						Object.Destroy((Object)(object)Button4T);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressValue += 2;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "vitrindoorVRRopen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						playSound = true;
						CountButtons++;
						((Renderer)(MeshRenderer)Lamp5T.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
						Object.Destroy((Object)(object)Button5T);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressValue += 2;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kylClosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("KylOpen");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kylOpen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("KylClose");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kitchenDoor1Closed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("KitchenDoor1Open");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kitchenDoor1Open")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("KitchenDoor1Close");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kitchenDoor2Closed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						playSound = true;
						CountButtons++;
						((Renderer)(MeshRenderer)Lamp1T.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
						Object.Destroy((Object)(object)Button1T);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressValue += 2;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "loda1Closed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Loda1Open");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "loda1Open")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Loda1Close");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "loda2Closed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Loda2Open");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "loda2Open")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						openTheDoor = false;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Loda2Close");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "garde1Closed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Garde1Open");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "garde1Open")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("Garde1Close");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bakluckaLocked")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havecarKey)
						{
							((Component)val.collider).gameObject.GetComponent<Animation>().Play("bakluckaOpen");
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).OpenedCarTrunk = true;
							((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
						}
						else
						{
							PickUpScript.ShowText2("I need a car key");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(bakluckaLocked);
						}
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bakluckaClosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("bakluckaOpen");
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bakluckaOpen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("bakluckaClose");
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.65f, 2.66f, 0.37f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "motorhuvClosed")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("motorhuvOpen");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "motorhuvOpen")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("motorhuvClose");
					}
				}
				else if (((Component)val.collider).gameObject.tag == "garageport")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if (garageportLock)
						{
							garageportAnimHolder.GetComponent<Animation>().Play("garageportOpen");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(garagePortSound);
							Object.Destroy((Object)(object)((Component)val.collider).gameObject);
							((carFrontSensor)(object)carSensorFront.GetComponent(typeof(carFrontSensor))).garagedoorOpen = true;
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).OpenedGarageDoor = true;
							if (PlayerPrefs.GetInt("DiffData") != 7)
							{
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
							}
						}
						else if (!playSound)
						{
							playSound = true;
							PickUpScript.ShowText2("This door is locked");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(brokenCarDoor);
						}
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(10f, 4f, 0f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(10f, 4f, 0f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "microdoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if (gameController.GetComponent<startNewDay>().AnomalyNR == 18)
						{
							((Component)val.collider).gameObject.GetComponent<Animation>().Play("MicroDoorOpen");
							((Component)val.collider).gameObject.tag = "Untagged";
							((Component)this).GetComponent<AudioSource>().PlayOneShot(Micro18Anomaly);
						}
						else
						{
							((Component)val.collider).gameObject.GetComponent<Animation>().Play("MicroDoorOpen");
							((Component)val.collider).gameObject.tag = "Untagged";
							((Component)this).GetComponent<AudioSource>().PlayOneShot(microDoor);
							microSparks.SetActive(true);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "prisondoorlocked")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("prisondoorLocked");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "fanhurt")
				{
					if (!playerFanHurt)
					{
						openDoorButton.SetActive(true);
						mittenRing.SetActive(true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
							((playerInBeartrap)(object)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
							playerFanHurt = true;
							openDoorButton.SetActive(false);
							mittenRing.SetActive(false);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(fingerFan);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "kitchenDoor2Open" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareHammer)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
						((playerInBeartrap)(object)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
						((Component)val.collider).gameObject.SetActive(false);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(fingerFan);
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareHammer = false;
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareHammerHand.SetActive(false);
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).dropObjectButton.SetActive(false);
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "WeaponWall" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareWeaponKey)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
						((playerInBeartrap)(object)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
						WeaponWallCount++;
						if (WeaponWallCount < 3)
						{
							((Component)val.collider).gameObject.transform.position = new Vector3(((Component)val.collider).gameObject.transform.position.x, ((Component)val.collider).gameObject.transform.position.y + 1f, ((Component)val.collider).gameObject.transform.position.z);
						}
						else
						{
							((Component)val.collider).gameObject.transform.position = new Vector3(5.41f, -26f, -24.71f);
							AchievementSaveManager.Instance.UnlockAchievement("ShotGunHater");
						}
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(fingerFan);
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareWeaponKey = false;
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareWeaponKeyHand.SetActive(false);
						((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).dropObjectButton.SetActive(false);
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "window" || (gameController.GetComponent<startNewDay>().AnomalyNR != 18 && gameController.GetComponent<startNewDay>().AnomalyNR != 19 && ((Object)((Component)val.collider).gameObject).name == "GrannyCantSeeCollider2"))
				{
					if (!((playerCrawl)(object)checkPcrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && !gameController.GetComponent<startNewDay>().deadByLaser)
					{
						if (canJumpOut)
						{
							openDoorButton.SetActive(true);
							mittenRing.SetActive(true);
							if (openTheDoor && !playSound)
							{
								playSound = true;
								((PlayerWindowController)(object)winController.GetComponent(typeof(PlayerWindowController))).jumpOut();
								openDoorButton.SetActive(false);
								mittenRing.SetActive(false);
								canJumpOut = false;
								checkPcrouch.SetActive(false);
							}
						}
						else if (canJumpIn)
						{
							openDoorButton.SetActive(true);
							mittenRing.SetActive(true);
							if (openTheDoor && !playSound)
							{
								playSound = true;
								((PlayerWindowController)(object)winController.GetComponent(typeof(PlayerWindowController))).jumpIn();
								openDoorButton.SetActive(false);
								mittenRing.SetActive(false);
								canJumpIn = false;
								checkPcrouch.SetActive(false);
							}
						}
						else
						{
							openDoorButton.SetActive(false);
							mittenRing.SetActive(false);
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "PrimeAnomaly18LadderIsReady")
				{
					if (!((playerCrawl)(object)checkPcrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && ((Component)this).gameObject.transform.position.y < 17.5f)
					{
						openDoorButton.SetActive(true);
						mittenRing.SetActive(true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							((PlayerWindowController)(object)winController.GetComponent(typeof(PlayerWindowController))).ClimbLadder();
							openDoorButton.SetActive(false);
							mittenRing.SetActive(false);
							checkPcrouch.SetActive(false);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "giljotinspak")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						giljotin.gameObject.GetComponent<Animation>().Play("giljotinOn");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(giljotinLjud);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
					}
				}
				else if (((Component)val.collider).gameObject.tag == "secretdoorbutton")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						secretDoor.gameObject.GetComponent<Animation>().Play("SecretDoorOpenLittle");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						secretDoorTrigger.SetActive(true);
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						((Component)val.collider).gameObject.tag = "Untagged";
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bastuspakOff")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuSpak.GetComponent<Animation>().Play("BastuSpakOn");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(switchOnOff);
						((Component)val.collider).gameObject.tag = "bastuspakOn";
						bastuSteam.GetComponent<ParticleSystem>().enableEmission = true;
						((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuswitchOn = true;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bastuspakOn")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuSpak.GetComponent<Animation>().Play("BastuSpakOff");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(switchOnOff);
						((Component)val.collider).gameObject.tag = "bastuspakOff";
						bastuSteam.GetComponent<ParticleSystem>().enableEmission = false;
						((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuswitchOn = false;
						((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 20f;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bastubomUppe")
				{
					if (bastuDoor.gameObject.tag == "innerdoorClosed")
					{
						openDoorButton.SetActive(true);
						mittenRing.SetActive(true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							bastuBom.GetComponent<Animation>().Play("BastuBomNer");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(bastuBomNer);
							((Component)val.collider).gameObject.tag = "Untagged";
							bastuDoor.gameObject.tag = "bastudoorLocked";
							if (((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu)
							{
								bastuDoorCarv.carving = ((Behaviour)this).enabled;
								noiceObjectBastu.SetActive(true);
							}
							((MonoBehaviour)this).StartCoroutine(bastuBommenNere());
							((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = true;
							openDoorButton.SetActive(false);
							mittenRing.SetActive(false);
							openTheDoor = false;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.7474883f, 4.1302137f, 5.47f), ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.7474883f, 4.1302137f, 5.47f), ((Component)this).transform.rotation);
							}
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "bastubomNere")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						bastuBom.GetComponent<Animation>().Play("BastuBomUpp");
						((Component)val.collider).gameObject.tag = "Untagged";
						bastuDoorCarv.carving = !((Behaviour)this).enabled;
						((MonoBehaviour)this).StartCoroutine(bastuBommenUppe());
						((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = false;
						((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuSafeTimer = 0f;
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.7474883f, 4.1302137f, 5.47f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-1.7474883f, 4.1302137f, 5.47f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "brokencardoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(brokenCarDoor);
						((Rigidbody)((Component)val.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
						((Component)val.collider).gameObject.tag = "Untagged";
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
						((destroyCarDoor)(object)((Component)val.collider).gameObject.GetComponent(typeof(destroyCarDoor))).destroyBrokenCardorr = true;
					}
				}
				else if (((Component)val.collider).gameObject.tag == "handskfack")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("handskfackOpen");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(secretDoorButton);
						((Component)val.collider).gameObject.tag = "Untagged";
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "playersteal")
				{
					if (!playerTrySteal)
					{
						openDoorButton.SetActive(true);
						mittenRing.SetActive(true);
						if (openTheDoor && !playSound)
						{
							playSound = true;
							((CrowControl)(object)Crow.GetComponent(typeof(CrowControl))).playerSteal = true;
							footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
							((playerInBeartrap)(object)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
							playerTrySteal = true;
							openDoorButton.SetActive(false);
							mittenRing.SetActive(false);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(crowAttack);
							((MonoBehaviour)this).StartCoroutine(crowAttackPlayer());
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "tavelspak")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						tavelspak.gameObject.GetComponent<Animation>().Play("Tavelspak");
						bokhylla.gameObject.GetComponent<Animation>().Play("BookShelfMove");
						bokhylla.GetComponent<AudioSource>().PlayOneShot(bokhyllaLjud);
						((Component)val.collider).gameObject.tag = "Untagged";
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-19.065f, 22.65f, 3.172f), ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-19.065f, 22.65f, 3.172f), ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "burdoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("BurDoorOpen");
						((CrowControl)(object)Crow.GetComponent(typeof(CrowControl))).burdoorIsOpen = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(burDoor);
						((Component)val.collider).gameObject.tag = "Untagged";
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
				}
				else if (((Component)val.collider).gameObject.tag == "gallerhole" && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 19)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)val.collider).gameObject.GetComponent<Animation>().Play("GallerHole");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(moveGaller);
						((Component)val.collider).gameObject.tag = "Untagged";
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "OpenWhiteRoomsButton")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						GameObject.Find("GallerHole").GetComponent<Animation>().Play("GallerHole");
						((Component)this).GetComponent<AudioSource>().PlayOneShot(moveGaller);
						((Object)((Component)val.collider).gameObject).name = "Untagged";
						((Component)val.collider).gameObject.GetComponent<Renderer>().material.color = Color.green;
						openDoorButton.SetActive(false);
						mittenRing.SetActive(false);
						openTheDoor = false;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "LiftButton")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever1isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever2isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever3isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever4isOK && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 11)
						{
							((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ButtonIsPressed = true;
							((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).NewEscapeDoor.SetActive(true);
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(32.565f, 13.471f, -18.104f), ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(32.565f, 13.471f, -18.104f), ((Component)this).transform.rotation);
							}
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever1isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever2isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever3isOK && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever4isOK && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 11)
						{
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).OpenedLift = true;
							PickUpScript.ShowText2("I have unlocked the elevator escape. Good Job!");
						}
						else
						{
							PickUpScript.ShowText2("I need to fix the elevator first!");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "LiftMessage")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						PickUpScript.ShowText2("This elevator has an absolutely silent engine");
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 11)
						{
							PickUpScript.ShowText2("When you escape, try this secret anomaly: 9191");
						}
						if (PlayerPrefs.GetInt("DiffData") == 7)
						{
							PickUpScript.ShowText2("There's nothing good waiting for you down there");
						}
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
						{
							PickUpScript.ShowText2("There's something good waiting for you down there");
						}
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						openTheDoor = false;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "PictureOnPlace")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havePicture)
						{
							if (!playSound)
							{
								playSound = true;
								bokhylla.GetComponent<AudioSource>().PlayOneShot(bokhyllaLjud);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PictureItemHand.SetActive(false);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PicturePlaced = true;
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havePicture = false;
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).dropObjectButton.SetActive(false);
								((Object)((Component)val.collider).gameObject).name = "Untagged";
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(32.565f, 13.471f, -18.104f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(32.565f, 13.471f, -18.104f), ((Component)this).transform.rotation);
								}
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
							}
						}
						else
						{
							PickUpScript.ShowText2("I need a picture");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "NewPadlock")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).knowPinCode || (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 25 && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebattery))
						{
							if (!playSound)
							{
								playSound = true;
								bokhylla.GetComponent<AudioSource>().PlayOneShot(bokhyllaLjud);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).pinCodeIsUsed = true;
								((Object)((Component)val.collider).gameObject).name = "Untagged";
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-18.722f, 21.1f, -14.9f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-18.722f, 21.1f, -14.9f), ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							PickUpScript.ShowText2("I don't know the pin code");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "EscapeDoor")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						if ((PlayerPrefs.GetInt("DiffData") == 7 && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR != 6) || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift < 40 || PlayerPrefs.GetInt("PrimeOn") == 0)
						{
							PickUpScript.ShowText2("Locked");
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveteddy)
						{
							((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LiftEscapeTeddy());
						}
						else
						{
							((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LiftEscape());
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "TaskIndicator" && gameController.GetComponent<startNewDay>().LiftDoor != 11f)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (gameController.GetComponent<startNewDay>().RandomTask == 1)
						{
							PickUpScript.ShowText2("It's light blue");
						}
						if (gameController.GetComponent<startNewDay>().RandomTask == 2)
						{
							PickUpScript.ShowText2("It's black");
						}
						if (gameController.GetComponent<startNewDay>().RandomTask == 3)
						{
							PickUpScript.ShowText2("It's white");
						}
						if (gameController.GetComponent<startNewDay>().RandomTask == 4)
						{
							PickUpScript.ShowText2("It's pink");
						}
						if (gameController.GetComponent<startNewDay>().RandomTask == 5)
						{
							PickUpScript.ShowText2("It's yellow");
						}
						if (gameController.GetComponent<startNewDay>().RandomTask == 6)
						{
							PickUpScript.ShowText2("It's orange");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "TaskIndicator2" && gameController.GetComponent<startNewDay>().LiftDoor != 11f)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (gameController.GetComponent<startNewDay>().randomTask2 == 1)
						{
							PickUpScript.ShowText2("It's light blue");
						}
						if (gameController.GetComponent<startNewDay>().randomTask2 == 2)
						{
							PickUpScript.ShowText2("It's black");
						}
						if (gameController.GetComponent<startNewDay>().randomTask2 == 3)
						{
							PickUpScript.ShowText2("It's white");
						}
						if (gameController.GetComponent<startNewDay>().randomTask2 == 4)
						{
							PickUpScript.ShowText2("It's pink");
						}
						if (gameController.GetComponent<startNewDay>().randomTask2 == 5)
						{
							PickUpScript.ShowText2("It's yellow");
						}
						if (gameController.GetComponent<startNewDay>().randomTask2 == 6)
						{
							PickUpScript.ShowText2("It's orange");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "TVHintCollider" && !((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveTVRemote)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						PickUpScript.ShowText2("I need a TV remote control");
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "SecretMessage")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						if (SecretLetter == 0)
						{
							SecretLetter = 1;
						}
						if (SecretLetter == 1)
						{
							CommentText.GetComponent<Text>().text = "You are on the path to gaining incredible power. 1/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 2)
						{
							CommentText.GetComponent<Text>().text = "Unfortunately, most will use it to inflict pain and pursue personal gain, rather than to save hundreds of future victims. 2/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 3)
						{
							CommentText.GetComponent<Text>().text = "No one knows me, but I am ready to sacrifice myself to help innocent people escape their fate. 3/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 4)
						{
							CommentText.GetComponent<Text>().text = "If a soul has found a way to read this, it means it is capable of carrying out my plan. 4/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 5)
						{
							CommentText.GetComponent<Text>().text = "There is a black button in this house. It will unlock a long and challenging path of life. 5/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 6)
						{
							CommentText.GetComponent<Text>().text = "Will there be a soul brave enough to defy death, resist fear, and endure pain? 6/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 7)
						{
							CommentText.GetComponent<Text>().text = "Just trust me and poison the bird food! 7/7";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						SecretLetter++;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "SecretDescription")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						if (SecretLetter == 0)
						{
							SecretLetter = 1;
						}
						if (SecretLetter == 1)
						{
							CommentText.GetComponent<Text>().text = "This is Jan Markov. 1/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 2)
						{
							CommentText.GetComponent<Text>().text = "He is a strange character who claims to have come from the future. 2/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 3)
						{
							CommentText.GetComponent<Text>().text = "He had a special device that allowed him to communicate with people from the future. 3/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 4)
						{
							CommentText.GetComponent<Text>().text = "He ended up in this house in version 1.2, explored it, and decided to escape. 4/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 5)
						{
							CommentText.GetComponent<Text>().text = "He unlocked almost all the locks but couldn't find the battery. 5/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 6)
						{
							CommentText.GetComponent<Text>().text = "He asked his friends from the future to tell him where the battery might be located. 6/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 7)
						{
							CommentText.GetComponent<Text>().text = "Unfortunately, his friends couldn't help him. 7/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 8)
						{
							CommentText.GetComponent<Text>().text = "But now there are 8 batteries in his room, and he can use them as much as he wants. 8/9";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 9)
						{
							CommentText.GetComponent<Text>().text = "Ha-ha-ha! 9/9";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						SecretLetter++;
					}
				}
				else if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 9 && ((Object)((Component)val.collider).gameObject).name == "ChairSR1" && ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havePrimeRedKey)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (SecretLetter == 0)
						{
							SecretLetter = 1;
						}
						if (SecretLetter == 1)
						{
							CommentText.GetComponent<Text>().text = "Oh, how is your escape going? How did you even manage to get here alive?";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 2)
						{
							CommentText.GetComponent<Text>().text = "This escape seems impossible... Oh, are you mad at me?";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 3)
						{
							CommentText.GetComponent<Text>().text = "Come on, I won't hurt you. Did I ever kill you in this insane house?";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 4)
						{
							CommentText.GetComponent<Text>().text = "Are you sure it was you who kept dying all this time, and not 5999 victims who ended up here before you?";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 5)
						{
							CommentText.GetComponent<Text>().text = "Yes, yes, every one of those 5999 deaths that wasn't you, but OTHER PEOPLE.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 6)
						{
							CommentText.GetComponent<Text>().text = "You see the fates of all the people who came here in your dreams. The next victims will see you, too.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 7)
						{
							CommentText.GetComponent<Text>().text = "Where are they? They fall unconscious into the void... and disappear forever.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 8)
						{
							CommentText.GetComponent<Text>().text = "By the way, you've learned to read my thoughts. Let me tell you a bit about myself.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 9)
						{
							CommentText.GetComponent<Text>().text = "My name is Stool. I'm nothing more than a creation of @(#@&!).";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 10)
						{
							CommentText.GetComponent<Text>().text = "...";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 11)
						{
							CommentText.GetComponent<Text>().text = "Why am I a chair? Why can't I see, hear, or speak, but know everything that happens in this house? Why I kill people? I have no idea.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 12)
						{
							CommentText.GetComponent<Text>().text = "And now I'm starting to fall apart, no longer good for anything. I can finally allow myself to rest.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 13)
						{
							CommentText.GetComponent<Text>().text = "@(#@&!) say a new enemy will soon appear in this house, and everyone will forget about me. Maybe that's for the best. After all, they feared me more than Granny.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 14)
						{
							CommentText.GetComponent<Text>().text = "I've found a quiet corner in this house where I can live out the last five days of my long life.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 15)
						{
							CommentText.GetComponent<Text>().text = "How about the idea of saving all the victims? It seems impossible, but if you truly wish it, you could even become a crow.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 16)
						{
							CommentText.GetComponent<Text>().text = "Think about it. I really want to see you alive!";
							textTimer = -5f;
							textTimerOnOff = true;
							gameController.GetComponent<startNewDay>().PrimeAnomaly9Collider.SetActive(false);
							AchievementSaveManager.Instance.UnlockAchievement("MyTalkingStool");
						}
						SecretLetter++;
					}
				}
				else if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 9 && ((Object)((Component)val.collider).gameObject).name == "HowToGetTheLastRedKey")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						if (RedKeyLetterCount == 0)
						{
							RedKeyLetterCount = 1;
						}
						if (RedKeyLetterCount == 1)
						{
							CommentText.GetComponent<Text>().text = "Once there was a terrible killer. She was aging and, because of that, could no longer catch her victims. But then someone told her to throw a coin into THE WELL to make her deepest wish come true.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(29.48f, 11.85f, -24.88f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, -45f);
						}
						if (RedKeyLetterCount == 2)
						{
							CommentText.GetComponent<Text>().text = "After she threw the coin into the well, she really did become faster. She could catch most victims, but some still escaped her house. So she wished for THE FRONT DOOR to be hung with dozens of locks.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(2.017f, 13.345f, 11.278f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 37.9f);
						}
						if (RedKeyLetterCount == 3)
						{
							CommentText.GetComponent<Text>().text = "Even that wasn't enough. It turned out some victims fought back using weapon created in THE GARAGE. After she wished for immortality.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(5.89f, 1.65f, 5.83f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, -28f);
						}
						if (RedKeyLetterCount == 4)
						{
							CommentText.GetComponent<Text>().text = "That didn't help either. In THE STAIR CLOSET was a pepper spray that helped victims defend themselves. Then she wanted a partner.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(5.057f, 13.345f, -0.8f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, -162f);
						}
						if (RedKeyLetterCount == 5)
						{
							CommentText.GetComponent<Text>().text = "On TV in THE LIVING ROOM she saw some grandpa stole a helicopter, and she wished for him to hunt victims alongside her.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(-15.56f, 13.345f, -8.04f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 118f);
						}
						if (RedKeyLetterCount == 6)
						{
							CommentText.GetComponent<Text>().text = "The wish was granted and he appeared in her house. But they constantly argued in THE KITCHEN or somewhere else and still couldn't kill everyone they wanted. The grandpa had to be kicked out.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(17.84f, 13.345f, 10.82f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 69f);
						}
						if (RedKeyLetterCount == 7)
						{
							CommentText.GetComponent<Text>().text = "Then she wished for another partner, and the well gave her a crow and settled it in THE OLD HOUSE.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(6.58f, 12.41f, -39.8f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 69f);
						}
						if (RedKeyLetterCount == 8)
						{
							CommentText.GetComponent<Text>().text = "She was furious and went on to wish the well destroyed so she could make wishes without it. After that there was a huge explosion, but it damaged nothing except the floor in THE ATTIC.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(2.942f, 26.989f, 7.574f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 139f);
						}
						if (RedKeyLetterCount == 9)
						{
							CommentText.GetComponent<Text>().text = "She became a slave to the well and acted only according to the new rules of that madness. Her legs wouldn't obey her. They ran at incredible speed toward the last sound another victim made in THE SHED.";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.transform.position = new Vector3(33.62f, 11.85f, -9.54f);
							((Component)val.collider).gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 139f);
						}
						if (RedKeyLetterCount == 10)
						{
							CommentText.GetComponent<Text>().text = "This story sounds too unreal, but I have seen a lot in this house and I will say it could very well be true. To be honest, I have gone mad. Everyone has gone mad. Every victim goes insane as soon as they appear in THE BEDROOM";
							textTimer = -10f;
							textTimerOnOff = true;
							((Component)val.collider).gameObject.SetActive(false);
							Object.Instantiate<GameObject>(gameController.GetComponent<InventoryController>().PrimeRedKeyItem, new Vector3(17.66f, 22.09f, -3.32f), Quaternion.Euler(-90f, 0f, -142f));
							AchievementSaveManager.Instance.UnlockAchievement("UnbelievableStory");
						}
						RedKeyLetterCount++;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "SecretInvite")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						CommentText.GetComponent<Text>().text = "Hello! I just want to say thank you for saving crows life. Let's meet in anomaly 36!";
						AchievementSaveManager.Instance.UnlockAchievement("MysteriousLetter");
						((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<CheckExitDoor>().GabonAnomaly11Ending());
						textTimer = -10f;
						textTimerOnOff = true;
					}
				}
				else if (((Component)val.collider).gameObject.tag == "shootbutton" && !((shootSpiderButton)(object)((Component)val.collider).gameObject.GetComponent(typeof(shootSpiderButton))).buttonShot)
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						closeSpiderAchievement = true;
						((shootSpiderButton)(object)((Component)val.collider).gameObject.GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "DarkMessage")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						openTheDoor = false;
						CommentText.GetComponent<Text>().text = "One of these teddy bears is special. If you pick it up, Granny won't be furious. There's a note somewhere in the house that tells you which one is special: the left, the middle or the right one";
						textTimer = 0f;
						textTimerOnOff = true;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "TeddyMessage")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						openTheDoor = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TrueTeddyNR == 1)
						{
							CommentText.GetComponent<Text>().text = "The special teddy is the left one";
						}
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TrueTeddyNR == 2)
						{
							CommentText.GetComponent<Text>().text = "The special teddy is the right one";
						}
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TrueTeddyNR == 3)
						{
							CommentText.GetComponent<Text>().text = "The special teddy is the middle one";
						}
						textTimer = 0f;
						textTimerOnOff = true;
					}
				}
				else if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 18 && ((Object)((Component)val.collider).gameObject).name == "PrimeAnomaly18Message")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						if (SecretLetter == 0)
						{
							SecretLetter = 1;
						}
						if (SecretLetter == 1)
						{
							CommentText.GetComponent<Text>().text = "I woke up. Today is a very hard test at school. I really don't want to go. But then I opened my eyes and saw this. White fog, traps, and a floor that just creaked. I got so scared and hid in the nearest closet. Turns out, it saved my life. 1/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 2)
						{
							CommentText.GetComponent<Text>().text = "Just a second later, a very old woman ran into the room. She ran toward the creak sound with demonic speed. It was obvious she wanted to kill me. I ran as fast as I could to the bathroom without making any noise. And then... the floor creaked again... 2/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 3)
						{
							CommentText.GetComponent<Text>().text = "She instantly ran to the creak sound, but I hid behind the door. I understood she is not very smart and I can use it. But she is very fast and strong. I am very scared... 3/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 4)
						{
							CommentText.GetComponent<Text>().text = "I explored the whole house. My favorite rooms are the ones where BLOOD SMELLS UNBEARABLE, where I SAW A GHOST, where I HID BEHIND THE DOOR, where PEOPLE CAN HANG CLOTHES, and where THE FLOOR IS VERY STICKY AND DIRTY. 4/7";
							textTimer = -10f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 5)
						{
							CommentText.GetComponent<Text>().text = "I found a TV remote control, and when I turned TV on, I saw that someone stole a helicopter. And I got a genius idea: climb onto the shed roof the backyard and write HELP with my blood so he can see it and save me. 5/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 6)
						{
							CommentText.GetComponent<Text>().text = "I really hope he sees it and saves me... it's my only chance... 6/7";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (SecretLetter == 7)
						{
							CommentText.GetComponent<Text>().text = "*Missing* 7/7";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						SecretLetter++;
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "Anomaly45Note")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						AnomalyLetterCount++;
						if (AnomalyLetterCount == 10)
						{
							AchievementSaveManager.Instance.UnlockAchievement("Anomaly45AllMessages");
						}
						int num = Random.Range(1, 29);
						if (num == 1)
						{
							CommentText.GetComponent<Text>().text = "EVIL CHAIR IS OUR GOD";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 2)
						{
							CommentText.GetComponent<Text>().text = "WHEN EVIL CHAIR WILL RETURN TO US?";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 3)
						{
							CommentText.GetComponent<Text>().text = "WE CAN'T WAIT LONGER! WE NEED EVIL CHAIR!";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 4)
						{
							CommentText.GetComponent<Text>().text = "Crow is she worst pet ever existed!";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 5)
						{
							CommentText.GetComponent<Text>().text = "Granny alone killed more than 5999 people";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 6)
						{
							CommentText.GetComponent<Text>().text = "Keys instead of brains";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 7)
						{
							CommentText.GetComponent<Text>().text = "@(#@&!) is the GOAT";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						if (num == 8)
						{
							CommentText.GetComponent<Text>().text = "HATETHEPLAYERHATETHEPLAYER";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 9)
						{
							CommentText.GetComponent<Text>().text = "The locks on the main door are so pointless...";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 10)
						{
							CommentText.GetComponent<Text>().text = "The glorious country of Gabon!";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 11)
						{
							CommentText.GetComponent<Text>().text = "1954";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 12)
						{
							CommentText.GetComponent<Text>().text = "4542";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 13)
						{
							CommentText.GetComponent<Text>().text = "We love being victims";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 14)
						{
							CommentText.GetComponent<Text>().text = "@(#@&!) is our creator!";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						if (num == 15)
						{
							CommentText.GetComponent<Text>().text = "The time when evil chair was alive >>>";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 16)
						{
							CommentText.GetComponent<Text>().text = "EVIL CHAIR PLEASE BE WITH US!";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 17)
						{
							CommentText.GetComponent<Text>().text = "Master key is not a master but noob";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 18)
						{
							CommentText.GetComponent<Text>().text = "Ketchup is the coolest sauce";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 19)
						{
							CommentText.GetComponent<Text>().text = "WHYUSWHYUS";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 20)
						{
							CommentText.GetComponent<Text>().text = "We DON'T want to be rescued!";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 21)
						{
							CommentText.GetComponent<Text>().text = "Only @(#@&!) can stop this";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						if (num == 22)
						{
							CommentText.GetComponent<Text>().text = "Granny is an actor";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 23)
						{
							CommentText.GetComponent<Text>().text = "//////////////////////////////////////////";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 24)
						{
							CommentText.GetComponent<Text>().text = "H1! C4n yo6 7ry...";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 25)
						{
							CommentText.GetComponent<Text>().text = "@(#@&!) is hiding something...";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 26)
						{
							CommentText.GetComponent<Text>().text = "Extra traps were trash! We glad that they were COMPLETELY DESTROYED";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 27)
						{
							CommentText.GetComponent<Text>().text = "Just imagine you were wrong all the time...";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (num == 28)
						{
							CommentText.GetComponent<Text>().text = "The right reality...";
							textTimer = -5f;
							textTimerOnOff = true;
							SecretLetter = 0;
						}
						((Component)val.collider).gameObject.SetActive(false);
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "PrimeAnomaly18DeathMessage")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor)
					{
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						openTheDoor = false;
						CommentText.GetComponent<Text>().text = "And he saw me! He saw me! I will escape this madness! I will finally go home! I see the helicopter is coming to rescue me! 7/7";
						textTimer = -5f;
						textTimerOnOff = true;
						AchievementSaveManager.Instance.UnlockAchievement("FullOfHope");
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name.Contains("Form_"))
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((Component)this).GetComponent<AudioSource>().PlayOneShot(readNote);
						if (((Object)((Component)val.collider).gameObject).name == "Form_RandomGuy")
						{
							CommentText.GetComponent<Text>().text = "From: Just a random guy\r\nIDK what I can do, but I guess it would be fun to replace Evil Chair. Why not?\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Grandpa")
						{
							CommentText.GetComponent<Text>().text = "From: Grandpa\r\nI'm...(OH NO! NOT HIM! REJECTED! REJECTED! REJECTED! REJECTED! REJECTED!)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Fortune-teller")
						{
							CommentText.GetComponent<Text>().text = "From: Super Fortune-Teller\r\nMy superpower is that I can predict the past.\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_EvilTable")
						{
							CommentText.GetComponent<Text>().text = "From: Evil Table\r\nI would be super-duper-mega original replacement for Evil Chair\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_AlphaWolf")
						{
							CommentText.GetComponent<Text>().text = "From: Alpha Wolf\r\nI can fly (but only downwards)\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_VozDuKhan")
						{
							CommentText.GetComponent<Text>().text = "From: Voz Du Khan\r\nI am a chieftain from the Mongol Empire. I am very strong, 2 meters tall, and can beat anyone.\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_InvisibleThing")
						{
							CommentText.GetComponent<Text>().text = "From: Invisible Thing\r\nI can be invisible, if no one sees me.\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Frog")
						{
							CommentText.GetComponent<Text>().text = "From: Frog\r\nI actually look like Evil Chair, but green and I can jump. Sadly, I'm not that fast, but I think I can replace Evil Chair well.\r\n(Well... I like you, but... REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Svellii")
						{
							CommentText.GetComponent<Text>().text = "From: Svelii\r\nWell, I'm a super cool guy... (NO, YOU ARE A FRAUD! REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Buck")
						{
							CommentText.GetComponent<Text>().text = "From: Buck\r\nYou actually remember me. Once you were visiting my giant house with prison. You know I'd be the best replacement for Evil Chair.\r\n(No, I like Bob way more! REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_TheVoid")
						{
							CommentText.GetComponent<Text>().text = "From: The Void\r\nI'm very smart and fast. Often victims know your weak spots, Granny. But I'm the mystery, no one will understand how to deal with me.";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Visitor1")
						{
							CommentText.GetComponent<Text>().text = "From: Visitor\r\nI can shoot lasers and I can repair your stupid chair, and that's only 1% of my true power. I'm the superhero. I am the Legend.\r\n(REJECTED)";
							textTimer = -5f;
							textTimerOnOff = true;
						}
						if (((Object)((Component)val.collider).gameObject).name == "Form_Visitor2")
						{
							((Object)((Component)val.collider).gameObject).name = "Unnamed";
							CommentText.GetComponent<Text>().text = "From: Visitor\r\nIt seems that you don't understand how powerful I am. If so, let me send these little things to you. Don't understand how to set them around your house? No problem, just invite me.\r\n(ACCEPTED)";
							textTimer = -10f;
							textTimerOnOff = true;
							AchievementSaveManager.Instance.UnlockAchievement("TheReality");
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<CheckExitDoor>().GabonAnomaly11Ending());
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "Adviser")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						if (gameController.GetComponent<startNewDay>().Anomaly36ItemsCollected < 6)
						{
							if (SecretLetter == 0)
							{
								SecretLetter = 1;
							}
							if (SecretLetter == 1)
							{
								CommentText.GetComponent<Text>().text = "Oh, we have finally meet! I was the person who was writing to you. I'm glad you have found this place. Granny doesn't know about me, so I need to hide";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 2)
							{
								CommentText.GetComponent<Text>().text = "You have shown your courage, but at the same time, your kindness...";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 3)
							{
								CommentText.GetComponent<Text>().text = "I need exactly this, because Granny is going to kill many people with her Prime Mode project";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 4)
							{
								CommentText.GetComponent<Text>().text = "After Evil Chair had passed away, Granny began to search for those who can replace it. As you can see, she is not doing well with this";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 5)
							{
								CommentText.GetComponent<Text>().text = "So this is our chance to save people from this Prime Mode. Here is my plan:";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 6)
							{
								CommentText.GetComponent<Text>().text = "From this moment you are The Void, a super clever and powerful villain that will suit perfectly in the role of Evil Chair's replacement";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 7)
							{
								CommentText.GetComponent<Text>().text = "I'm 100% sure that Granny will accept the letter behind me, because everyone else is much worse than the Void. So you will be a new Extra Enemy";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter == 8)
							{
								CommentText.GetComponent<Text>().text = "Once a victim wakes up in this hell, you instantly give all the items you have to help them escape. You will act as an enemy, but will not harm anybody";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							if (SecretLetter >= 9)
							{
								Anomaly36Collectibles.SetActive(true);
								gameController.GetComponent<startNewDay>().Anomaly36BeginFindingItems = true;
								CommentText.GetComponent<Text>().text = "So what a genius plan I have! Now collect all the items in the house. This is your first step of becoming the true hero!";
								textTimer = -5f;
								textTimerOnOff = true;
							}
							SecretLetter++;
						}
						else
						{
							((Object)((Component)val.collider).gameObject).name = "Unnamed";
							CommentText.GetComponent<Text>().text = "Good! You need to have some rest. Let's wait until Granny will accept our letter!";
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<CheckExitDoor>().GabonAnomaly11Ending());
							textTimer = -10f;
							textTimerOnOff = true;
							AchievementSaveManager.Instance.UnlockAchievement("TheUtopia");
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "LaserYellowActivation(Clone)")
				{
					openDoorButton.SetActive(true);
					mittenRing.SetActive(true);
					if (openTheDoor && !playSound)
					{
						playSound = true;
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).activateYellowLaser = !((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).activateYellowLaser;
					}
				}
				else if (((Component)val.collider).gameObject.tag == "golv")
				{
					openDoorButton.SetActive(false);
					mittenRing.SetActive(false);
					openTheDoor = false;
				}
				else if (((Component)val.collider).gameObject.tag == "Untagged")
				{
					openDoorButton.SetActive(false);
					mittenRing.SetActive(false);
					openTheDoor = false;
				}
				else if (((Component)val.collider).gameObject.tag == "remoteLock")
				{
					openDoorButton.SetActive(false);
					mittenRing.SetActive(false);
					openTheDoor = false;
				}
			}
			else
			{
				openDoorButton.SetActive(false);
				mittenRing.SetActive(false);
				openTheDoor = false;
			}
		}
		else
		{
			openDoorButton.SetActive(true);
			mittenRing.SetActive(false);
		}
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				CommentText.GetComponent<Text>().text = "";
			}
		}
		if (CountButtons > 4)
		{
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).ButtonsLockOk = true;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 44)
		{
			if (buffhandAnomaly44)
			{
				RayDistance += 0.5f * Time.deltaTime;
			}
			else
			{
				RayDistance -= 0.5f * Time.deltaTime;
			}
			if (RayDistance >= 10f)
			{
				buffhandAnomaly44 = false;
			}
			if (RayDistance <= 1f)
			{
				buffhandAnomaly44 = true;
			}
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 94)
		{
			EatingScore = ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter;
			EatingText.GetComponent<Text>().text = string.Concat(EatingScore);
		}
	}

	public virtual IEnumerator bastuBommenNere()
	{
		yield return (object)new WaitForSeconds(1f);
		bastuBom.gameObject.tag = "bastubomNere";
		noiceObjectBastu.SetActive(false);
	}

	public virtual IEnumerator bastuBommenUppe()
	{
		yield return (object)new WaitForSeconds(1f);
		bastuBom.gameObject.tag = "bastubomUppe";
		bastuDoor.gameObject.tag = "innerdoorClosed";
	}

	public virtual IEnumerator crowAttackPlayer()
	{
		yield return (object)new WaitForSeconds(2f);
		playerTrySteal = false;
	}

	public void NightmareWrenchBreak()
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		footstepScriptHolder.gameObject.GetComponent<Animation>().Play("playerHurt");
		((playerInBeartrap)(object)bloodScreenHolder.GetComponent(typeof(playerInBeartrap))).playerStuck();
		((Component)this).GetComponent<AudioSource>().PlayOneShot(fingerFan);
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.6f, ((Component)this).transform.position.z), ((Component)this).transform.rotation);
			}
		}
	}
}
