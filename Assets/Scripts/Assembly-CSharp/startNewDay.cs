using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class startNewDay : MonoBehaviour
{
	public Text AnomalyTimerText;

	public GameObject MoreSpiderwebs;

	public GameObject AbondonedRats;

	public GameObject AbondonedMusicHolder;

	public Shader AbondonedShader;

	public InventoryController InventoryControllerScript;

	public Image PlayerButtonImage;

	public EnemyAIGranny EnemyAIGrannyScript;

	public playerCrawl playerCrawlScript;

	public GameObject GrannyFreezeButton;

	public GameObject ChangeExtraTrapsButton;

	public GameObject OpenBeartrapButton;

	public GameObject Anomaly43CreackingFloors;

	public GameObject Anomaly43CreackingFloorsExtreme;

	public GameObject Anomaly45NewObjects;

	public GameObject Anomaly36NewObjects;

	public GameObject Anomaly36Camera;

	public GameObject Anomaly36SecretItems;

	public GameObject PrimeAnomaly13Grates;

	public GameObject PrimeBearTraps;

	public GameObject NewObjects;

	public GameObject PrimeAnomaly18NewObjects;

	public GameObject PrimeAnomaly18SkeletonHead;

	public GameObject ExtraTrapsDeathScreen;

	public Texture PoisonCanTexture;

	public Texture Anomaly12BomberTexture;

	public Texture STANDOFCHEK;

	public GameObject ShadowSpheres;

	public GameObject AHugeSuccessAchievement;

	public GameObject ShootStoolAchievement;

	public openDoors openDoorsScript;

	public int BookAchievementCount;

	public float fadeBlackSpeed;

	public float fadeTextSpeed;

	public Image blackScreenTexture;

	public Image bloodscreenImage;

	public GameObject bloodscreen;

	public GameObject bloodOnBed;

	public GameObject bloodscreenDay4;

	public Image day1;

	public GameObject day1Text;

	public Image day2;

	public GameObject day2Text;

	public Image day3;

	public GameObject day3Text;

	public Image day4;

	public GameObject day4Text;

	public Image day5;

	public GameObject day5Text;

	public Image day5LastDay;

	public GameObject day5LastDayText;

	public Image day6;

	public GameObject day6Text;

	public GameObject animationHolder;

	public GameObject playerInBed;

	public GameObject Player;

	public Transform playerCam;

	public GameObject clipPlaneHolder;

	public Transform playerHead;

	public GameObject joystick;

	public Image joystickTexture;

	public Image joystickRingTexture;

	public GameObject crouchButton;

	public GameObject optionButton;

	public GameObject allBedButtons;

	public GameObject mittPrick;

	public GameObject Granny;

	public GameObject GrannyEye;

	public GameObject GrannyEyeColor;

	public float daysCounter;

	public GameObject doorRoom1;

	public GameObject doorRoom2;

	public GameObject doorklocka1;

	public GameObject doorklocka2;

	public GameObject gameController;

	public GameObject soundHolder;

	public GameObject soundHolder2;

	public GameObject musicHolder;

	public GameObject musicHolderNightmare;

	public GameObject kliverUrBedLjud;

	public GameObject haveToLeaveText;

	public GameObject KnarrandeGolv;

	public GameObject KnarrandeGolvExtreme;

	public GameObject adsPauseContinueButton;

	public saveSensitivityData scriptC;

	public GameObject savedValue;

	public float RandomNR;

	public GameObject OP1;

	public GameObject OP1_2;

	public GameObject OP1_3;

	public GameObject OP1_4;

	public GameObject OP1_5;

	public GameObject OP1_6;

	public GameObject OP1_7;

	public GameObject OP2;

	public GameObject OP2_2;

	public GameObject OP2_3;

	public GameObject OP2_4;

	public GameObject OP2_5;

	public GameObject OP3;

	public GameObject OP3_2;

	public GameObject OP3_3;

	public GameObject OP3_4;

	public GameObject OP3_5;

	public GameObject OP3_6;

	public GameObject OP4;

	public GameObject OP4_2;

	public GameObject OP4_3;

	public GameObject OP4_4;

	public GameObject OP4_5;

	public GameObject OP4_6;

	public GameObject OP4_7;

	public GameObject OP5;

	public GameObject OP5_2;

	public GameObject OP5_3;

	public GameObject OP5_4;

	public GameObject OP5_5;

	public GameObject OP5_6;

	public GameObject OP5_7;

	public float RandomNRTavelbitar;

	public GameObject tavla;

	public GameObject tavelbitar;

	public bool tavelbit1;

	public bool tavelbit2;

	public bool tavelbit3;

	public bool tavelbit4;

	public bool allaTavelbitarOnPlace;

	public GameObject playerGetExtraDay;

	public GameObject tavelBitPlace1;

	public GameObject tavelBitPlace2;

	public GameObject tavelBitPlace3;

	public GameObject Teddy;

	public Transform TeddyPos;

	public bool slendrinaAppeard;

	public bool slendrinaMomAppeard;

	public GameObject GrannyMessage;

	public GameObject allTexts;

	public GameObject bloodHanging;

	public GameObject rats;

	private GameObject Galler1;

	private GameObject Galler2;

	private GameObject ExtraKnarr1;

	public GameObject ExtraKnarr2;

	private GameObject ExtraKnarr3;

	private GameObject Landing1;

	public GameObject Plankaready;

	private GameObject WallTemplate;

	private GameObject NewWall1;

	private GameObject NewWall2;

	private GameObject NewWall3;

	private GameObject NewWall4;

	private GameObject Landing2;

	private GameObject NewWall5;

	private GameObject NewWall6;

	private GameObject Safezone1;

	private GameObject NewWall7;

	private GameObject NewWall8;

	private GameObject NewWall9;

	private GameObject LiftTemplate;

	private GameObject Lift1;

	private GameObject Lift2;

	private GameObject Lift3;

	private GameObject Lift4;

	private GameObject NewWall10;

	private GameObject Indicator;

	private GameObject Landing3;

	private GameObject Landing4;

	private GameObject NewWall11;

	private GameObject LandCollider;

	private GameObject ExtraKnarr4;

	public int RandomTask;

	public float LiftDoor = 8.882f;

	public GameObject TextObject;

	public TextMesh TextTask;

	public GameObject TextVision;

	public GameObject AnomalyText;

	public Resources c;

	public int AnomalyNR;

	public int AnomalyCarPosition;

	public float AnomalyTimer;

	public bool DiedByAnomaly;

	public int AnomalyBugCounter;

	private GameObject NewWall12;

	private GameObject NewWall13;

	private GameObject NewWall14;

	public GameObject Button;

	private GameObject Landing5;

	public GameObject LiftMessage;

	public GameObject PictureOnPlace;

	public GameObject PictureItem;

	public GameObject newPictureItem;

	public GameObject PictureItemHand;

	public GameObject newPictureTrigger;

	public GameObject NewWall15;

	public Texture OrigPicture;

	public bool PicturePlaced;

	public bool MovinsIsOver;

	public GameObject Hole;

	public GameObject GreenDrawer;

	public GameObject TVText;

	public int channelCount;

	public GameObject TVArea;

	public TextMesh TVTextMesh;

	public GameObject GreenDoor;

	public GameObject CodeWall;

	public GameObject Shelf1;

	public GameObject Shelf2;

	public bool knowPinCode;

	public bool pinCodeIsUsed;

	public bool MovingIsOver2;

	public bool SetPadlockParent;

	public GameObject EscapeLamp1;

	public GameObject EscapeLamp2;

	public GameObject EscapeLamp3;

	public GameObject EscapeLamp4;

	public GameObject Panel;

	public GameObject WirePlace;

	public GameObject Hole2;

	public GameObject NewWall21;

	public GameObject NewWall22;

	public GameObject NewWall23;

	public GameObject NewWall24;

	public GameObject NewWall25;

	public GameObject NewWall26;

	public GameObject NewWall27;

	public bool ButtonIsPressed;

	public bool MovingIsOverLift;

	public int Anomaly13Puzzle;

	public string DiffTV;

	public string NigthmarewallsTV;

	public string NigthmareTV;

	public string PresetTV;

	public string AnomalyTV;

	public bool saveRandomNR;

	public int RandomIndex;

	public GameObject NewWall30;

	public GameObject NewEscapeDoor;

	public GameObject Lift5;

	public GameObject Anomaly9Timer;

	public GameObject Anomaly12Timer;

	public GameObject HoleInTheWall1;

	public GameObject HoleInTheWall2;

	public GameObject HoleInTheWall3;

	public GameObject ExtraKnarrAnomaly1;

	public GameObject ExtraKnarrAnomaly2;

	public GameObject ExtraKnarrAnomaly3;

	public GameObject ExtraKnarrAnomaly4;

	public GameObject ExtraKnarrAnomaly5;

	public GameObject ExtraKnarrAnomaly6;

	public GameObject ExtraKnarrAnomaly7;

	public GameObject GabonBlackScreen;

	public GameObject DropPointScrewdriver;

	public GameObject GrannyTwinAnomaly18;

	public GameObject GallerAnomaly18;

	public GameObject HideCrouchCollider1;

	public GameObject HideCrouchCollider2;

	public GameObject Anomaly18Wall1;

	public GameObject Anomaly18Wall2;

	public GameObject Anomaly18Wall3;

	public GameObject Anomaly18Wall4;

	public GameObject Anomaly18Wall5;

	public GameObject Anomaly18Wall6;

	public GameObject Anomaly18Wall7;

	public GameObject Anomaly18Screw;

	public GameObject Anomaly18Window;

	public GameObject Anomaly18Poison;

	public GameObject Anomaly18CuttingPliers1;

	public GameObject Anomaly18Hammer1;

	public GameObject Anomaly18MasterKey1;

	public GameObject Anomaly18Shotgun1;

	public GameObject Anomaly18Shotgun2;

	public GameObject Anomaly18Shotgun3;

	public GameObject Anomaly18SecretDrawer;

	public GameObject Anomaly18Screwdriver;

	public GameObject Galler3;

	public GameObject Galler3Trigger;

	public bool SewerGallerOpen;

	public bool MovingIsOver3;

	public GameObject BlueKeyArea;

	public int BlueKeyAreaNR;

	public Vector3 BlueKeySpawn;

	public GameObject BlueDrawer;

	public GameObject BlueWall;

	public GameObject BlueDoor;

	public GameObject HideCrouchCollider3;

	public int Anomaly20Doors;

	public GameObject Anomaly23creack;

	public GameObject Anomaly21DropPoint;

	public GameObject Anomaly21VasDropPoint;

	public GameObject Anomaly19Galler1;

	public GameObject Anomaly19Galler2;

	public GameObject Anomaly19Galler3;

	public GameObject Anomaly19Galler4;

	public GameObject Anomaly19Galler5;

	public GameObject Anomaly19Galler6;

	public GameObject Anomaly19Galler7;

	public GameObject Anomaly19Galler8;

	public GameObject Anomaly19Galler9;

	public GameObject Anomaly19Galler10;

	public GameObject Anomaly19Galler11;

	public GameObject Anomaly19Galler12;

	public GameObject Anomaly19Galler13;

	public GameObject Anomaly19Button;

	public bool Anomaly24PlayerInTrap;

	public GameObject PrimeHole;

	public GameObject Legendaa;

	public GameObject HideCrouchCollider4;

	public GameObject NewWall31;

	public GameObject MetalBox;

	public GameObject WaterNewEscape;

	public GameObject BugfixObstacle1;

	public GameObject Galler4;

	public GameObject AllDoors;

	public GameObject MeatDoor;

	private GameObject Landing6;

	public GameObject BoxHand;

	public GameObject NewWall32;

	public GameObject NewWall33;

	public GameObject NewWall34;

	public GameObject NewWall35;

	public GameObject Dit;

	public GameObject DoorHand;

	public GameObject Rat3;

	public GameObject Rat4;

	public GameObject Rat5;

	public GameObject RedDoor;

	public GameObject TableBug;

	public GameObject Klocka;

	public GameObject KlockaDel;

	public GameObject Rat6;

	public GameObject Rat7;

	public GameObject Rat8;

	public GameObject Rat9;

	public GameObject Rat10;

	public int EventBooks;

	public bool hintIsActive;

	public int hintUse;

	public bool Anomaly9End;

	public GameObject UseButton;

	public GameObject HintText;

	public GameObject EventCommentText;

	public float EventFogStart;

	public float EventFogEnd;

	public GameObject PlankaHighlightReady;

	public GameObject GrannyCantSeeCollider;

	public int PrimeAnomalyNR;

	public GameObject EvilChair;

	public GameObject DarkMessage;

	public GameObject Anomaly29Plate;

	public GameObject Anomaly30Text;

	public bool PrimeAnomaly7CantDrop;

	public float PrimeAnomaly7Timer;

	public GameObject Rat1;

	public GameObject Rat2;

	public int LightsOutMaxValue;

	public GameObject PrimeAnomaly9Collider;

	public GameObject PrimeAnomaly9Note;

	public int ProgressValue;

	public int ProgressDoorPreset;

	public GameObject TimerText;

	public GameObject AnomalyCommentText;

	public float TimerPrimeSec;

	public float TimerPrimeMin;

	public float TimerPrimeHour;

	public bool StopTimerCount;

	public int ProgressCar;

	public int ProgressLift;

	public int ProgressBehavior;

	public bool AllProgress;

	public GameObject EventChallenge3Text;

	public GameObject GamblingButton1;

	public GameObject GamblingButton2;

	public GameObject GamblingButton3;

	public bool getProgress;

	public GameObject GrannyCantSeeCollider2;

	public GameObject NewLocationWindow;

	public GameObject Frame1;

	public GameObject Frame2;

	public GameObject Frame3;

	public GameObject Frame4;

	public GameObject TriggerIn;

	public GameObject TriggerOut;

	public GameObject TVHintCollider;

	public GameObject ScreenNewLocation;

	public bool saveInOrder;

	public GameObject DoorToFreeze;

	public GameObject NewWall36;

	public GameObject NewWall37;

	public GameObject NewWall38;

	public GameObject NewWall39;

	public GameObject NewWall40;

	public GameObject ImpossibleDoor;

	public GameObject ImpossibleDoorHand;

	public GameObject NewWall41;

	public GameObject Indicator2;

	public MeshRenderer IndicatorMeshRenderer;

	public MeshRenderer IndicatorMeshRenderer2;

	public int randomTask2;

	public GameObject GrannyCantSeeCollider3;

	public bool Anomaly12Buff;

	public bool deadByLaser;

	public bool activateGreenLaser;

	public bool activateYellowLaser;

	private GameObject BaloonEvilChairExample;

	public float Anomaly46FOV;

	public bool buffCameraAnomaly46;

	public bool EveryBeginAchievement;

	public bool PrisonerOfPrimeAchievement;

	public bool SoCloseAchievement;

	public bool ThisMadeMeThinkAchievementFail;

	public bool SetNerfedPrime;

	public bool SetPrime;

	public bool SetPrimePlus;

	public bool Anomaly36BeginFindingItems;

	public int Anomaly36ItemsCollected;

	public bool Anomaly30Achievement;

	public bool GrannyGauntlet;

	public virtual IEnumerator Start()
	{
		Physics.gravity = new Vector3(0f, -9.81f, 0f);
		QualitySettings.vSyncCount = 0;
		if (PlayerPrefs.GetInt("VSyncOnOff") == 1)
		{
			QualitySettings.vSyncCount = 1;
		}
		else
		{
			QualitySettings.vSyncCount = 0;
			Application.targetFrameRate = PlayerPrefs.GetInt("FPSLimit");
		}
		Physics.IgnoreLayerCollision(8, 12);
		Physics.IgnoreLayerCollision(8, 13);
		Physics.IgnoreLayerCollision(12, 13);
		Physics.IgnoreLayerCollision(12, 15);
		Physics.IgnoreLayerCollision(16, 8);
		Physics.IgnoreLayerCollision(16, 11);
		Physics.IgnoreLayerCollision(16, 12);
		Physics.IgnoreLayerCollision(16, 13);
		Physics.IgnoreLayerCollision(16, 15);
		Physics.IgnoreLayerCollision(17, 12);
		Physics.IgnoreLayerCollision(17, 13);
		Physics.IgnoreLayerCollision(17, 8);
		Physics.IgnoreLayerCollision(0, 18);
		Physics.IgnoreLayerCollision(12, 18);
		Physics.IgnoreLayerCollision(8, 19);
		Physics.IgnoreLayerCollision(12, 19);
		PlayerPrefs.SetInt("Anomaly41Ending", 0);
		PlayerPrefs.SetInt("Anomaly45Ending", 0);
		PlayerPrefs.SetInt("GabonAnomaly16Ending", 0);
		AnomalyText = DefaultControls.CreateText(c);
		AnomalyText.transform.SetParent(GameObject.Find("All days texter").GetComponent<Transform>());
		((Graphic)AnomalyText.GetComponent<Text>()).color = new Color(1f, 1f, 1f, 0f);
		AnomalyText.GetComponent<Text>().resizeTextForBestFit = true;
		AnomalyText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
		AnomalyText.GetComponent<Text>().fontSize = 0;
		AnomalyText.GetComponent<Text>().text = "";
		AnomalyText.GetComponent<Text>().resizeTextMaxSize = 60;
		AnomalyText.GetComponent<Text>().alignment = (TextAnchor)4;
		AnomalyText.GetComponent<RectTransform>().sizeDelta = new Vector2(700f, 30f);
		AnomalyText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		AnomalyText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		AnomalyText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
		if (PlayerPrefs.GetInt("AnomalyNR") == 0 && PlayerPrefs.GetInt("randomNR") == 100 && PlayerPrefs.GetInt("DiffData") == 6)
		{
			GrannyGauntlet = true;
		}
		if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1 && PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0)
		{
			DiffTV = "Nerfed Prime";
			AnomalyText.GetComponent<Text>().text = "Nerfed Prime:\r\nThere is no evil chair\r\n WARNING: this is not the Prime difficulty!";
		}
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && PlayerPrefs.GetInt("DiffData") == 7)
		{
			PrimeAnomalyNR = PlayerPrefs.GetInt("PrimeAnomalyNR");
			if (PrimeAnomalyNR == 1)
			{
				AnomalyTV = "1";
				AnomalyText.GetComponent<Text>().text = " anomaly 1:\r\nGranny walks 800% faster and the farther you are from Granny, the slower you move, but there are no more creaking floors in the house and there is no evil chair";
			}
			if (PrimeAnomalyNR == 2)
			{
				AnomalyTV = "2";
				AnomalyText.GetComponent<Text>().text = " anomaly 2:\r\nThere is MUCH more fog, but you know how far evil chair is from you";
			}
			if (PrimeAnomalyNR == 3)
			{
				AnomalyTV = "3";
				AnomalyText.GetComponent<Text>().text = " anomaly 3:\r\nAll characters move 25% faster and enemies are twice as small";
				Granny.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			}
			if (PrimeAnomalyNR == 4)
			{
				AnomalyTV = "4";
				AnomalyText.GetComponent<Text>().text = " anomaly 4:\r\nThere are new creaking floors, some doors and nightmare walls are removed (grass and concrete can also creack), but Granny is less smarter";
				GameObject.Find("InnerdoorParent (1)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("InnerdoorParent (2)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("InnerdoorParent (3)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("SmallDoorParent (1)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("InnerdoorParentVind2").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("SmallDoorParent (2)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("BackyardDoorParent").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("OldHouseWoodenDoor").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("SmallDoorParent (2)").transform.position = new Vector3(-1000f, -1000f, -1000f);
				GameObject.Find("MeatDoor").transform.position = new Vector3(-1000f, -1000f, -1000f);
			}
			if (PrimeAnomalyNR == 5)
			{
				AnomalyTV = "5";
				AnomalyText.GetComponent<Text>().text = " anomaly 5:\r\nYou have a bell in your left hand that rings every 30 seconds, but you have a nightmare crossbow";
			}
			if (PrimeAnomalyNR == 6)
			{
				AnomalyTV = "6";
				AnomalyText.GetComponent<Text>().text = " anomaly 6:\r\nYou can only crawl, but you have a spray, which you can use up to 50 times, there is no evil chair and you need to open only one escape route";
				GameObject.Find("PepperSpray").SetActive(false);
			}
			if (PrimeAnomalyNR == 7)
			{
				AnomalyTV = "7";
				AnomalyText.GetComponent<Text>().text = " anomaly 7:\r\nYou can drop an item only once per minute, but you have long arms";
			}
			if (PrimeAnomalyNR == 8)
			{
				AnomalyTV = "8";
				AnomalyText.GetComponent<Text>().text = " anomaly 8:\r\nFrom time to time, evil chair may become cursed. When cursed, it kills you only when you crouch, but the padlock and trunk are opened";
			}
			if (PrimeAnomalyNR == 9)
			{
				AnomalyTV = "9";
				AnomalyText.GetComponent<Text>().text = " special anomaly 9:\r\nYou need to find 4 red keys to escape through the new door, but there is no evil chair";
				RedDoor = Object.Instantiate<GameObject>(GameObject.Find("OldHouseWoodenDoor"), new Vector3(-10.8f, 12.381138f, -39.57f), Quaternion.Euler(-90f, -90f, 0f));
				RedDoor.transform.localScale = new Vector3(112.098015f, 5.2115955f, 227.6957f);
				((Object)RedDoor).name = "PrimeRedDoor";
				RedDoor.tag = "Untagged";
				PrimeAnomaly9Collider = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), new Vector3(-0.153f, 13.257f, 18.58f), Quaternion.Euler(90f, 0f, 0f));
				PrimeAnomaly9Collider.transform.localScale = new Vector3(103.870026f, 19.40846f, 0.2256523f);
				PrimeAnomaly9Collider.AddComponent<BoxCollider>();
				((Renderer)PrimeAnomaly9Collider.GetComponent<MeshRenderer>()).material.color = Color.black;
				GameObject val = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), new Vector3(-0.1533f, 15.92f, 14.623f), Quaternion.Euler(0f, 0f, 0f));
				val.transform.localScale = new Vector3(103.870026f, 19.40846f, 0.2256523f);
				val.AddComponent<BoxCollider>();
				((Renderer)val.GetComponent<MeshRenderer>()).material.color = Color.black;
				Object.Instantiate<GameObject>(val, new Vector3(-0.1533f, 19.31f, 18.58f), Quaternion.Euler(90f, 0f, 0f));
				Object.Instantiate<GameObject>(val, new Vector3(-0.1533f, 15.92f, 22.36f), Quaternion.Euler(0f, 0f, 0f));
				Object.Instantiate<GameObject>(val, new Vector3(-6.16f, 15.92f, 35.61f), Quaternion.Euler(0f, 90f, 0f));
				Object.Instantiate<GameObject>(val, new Vector3(5.44f, 15.92f, 35.61f), Quaternion.Euler(0f, 90f, 0f));
				GameObject.Find("ResetFloor").GetComponent<BoxCollider>().size = new Vector3(10f, 0.09f, 21.13f);
				GameObject.Find("playerResetPoint").transform.position = new Vector3(-11.076f, 20.076f, 5.669f);
				PrimeAnomaly9Note = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(7.61f, 22.47f, -3.8f), Quaternion.Euler(90f, 0f, 40f));
				PrimeAnomaly9Note.tag = "Untagged";
				((Object)PrimeAnomaly9Note).name = "HowToGetTheLastRedKey";
			}
			if (PrimeAnomalyNR == 10)
			{
				AnomalyTV = "10";
				AnomalyText.GetComponent<Text>().text = " anomaly 10:\r\nEvil chair loves vases: there are a lot of these in the house and evil chair only goes check these vases";
			}
			if (PrimeAnomalyNR == 11)
			{
				AnomalyTV = "11";
				AnomalyText.GetComponent<Text>().text = " anomaly 11:\r\nEvil chair's clones will fall from the sky every 2 minutes, but the original one moves 50% slower";
			}
			if (PrimeAnomalyNR == 12)
			{
				AnomalyTV = "12";
				AnomalyText.GetComponent<Text>().text = " anomaly 12:\r\nIn 8 minutes evil chair becomes a bomber, but before it hapens you move 25% faster";
				Anomaly12Buff = true;
			}
			if (PrimeAnomalyNR == 13)
			{
				AnomalyTV = "13";
				AnomalyText.GetComponent<Text>().text = " anomaly 13:\r\nSome areas are blocked and evil chair is imprisoned until you collect the painting 3 times, but numeric padlock and battery lock are opened";
				PrimeAnomaly13Grates.SetActive(true);
				tavla.SetActive(true);
				tavelBitPlace1.SetActive(true);
				((Component)tavelBitPlace2.transform.GetChild(1)).transform.localPosition = new Vector3(-32.01f, -12.5f, 12.9f);
				((Component)tavelBitPlace2.transform.GetChild(1)).transform.localRotation = Quaternion.Euler(-90f, 0f, 72f);
				((Component)tavelBitPlace2.transform.GetChild(2)).transform.localPosition = new Vector3(7.41f, -9.613f, 17.318f);
				((Component)tavelBitPlace3.transform.GetChild(3)).transform.localPosition = new Vector3(-14.3f, -12.266f, 11.32f);
				((Component)tavelBitPlace3.transform.GetChild(3)).transform.localRotation = Quaternion.Euler(-29.224f, 26.24f, -0.036f);
			}
			if (PrimeAnomalyNR == 14)
			{
				AnomalyTV = "14";
				AnomalyText.GetComponent<Text>().text = " anomaly 14:\r\nItems slip out of hands every 10 seconds, but you have a second day";
				AnomalyTimer = 15f;
			}
			if (PrimeAnomalyNR == 15)
			{
				AnomalyTV = "15";
				AnomalyText.GetComponent<Text>().text = " anomaly 15:\r\nGranny hears nothing and she is always running, but you have a nightmare book and there is no evil chair";
			}
			if (PrimeAnomalyNR == 16)
			{
				AnomalyTV = "16";
				AnomalyText.GetComponent<Text>().text = " anomaly 16:\r\nGranny hears almost everything, but she has a very poor vision and there is no evil chair";
				AnomalyNR = 16;
				GameObject.Find("MetalLockerDoorParent (1)").transform.position = new Vector3(0f, -100f, 0f);
				((Object)Object.Instantiate<GameObject>(((Component)KnarrandeGolv.transform.GetChild(0)).gameObject, new Vector3(100f, 100f, 100f), Quaternion.identity)).name = "Noise16Anomaly";
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastudoorParent (1)/BastuDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("GrannyHelaHuset/MeatDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("GrannyHelaHuset/OldHouseWoodenDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("StealDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/MetalLockerDoorParent (1)/MetalLockerDoor").AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(0)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(1)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(2)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(3)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(4)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(5)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(6)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(7)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(8)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(9)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(10)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-6.567f, 21.44f, 13.960455f);
				((Component)GameObject.Find("All doors").transform.GetChild(13)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				if (Object.op_Implicit((Object)(object)GameObject.Find("Motorhuv")))
				{
					GameObject.Find("Motorhuv").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("Backlucka")))
				{
					GameObject.Find("Backlucka").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("LekhusDoor")))
				{
					GameObject.Find("LekhusDoor").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("GallerHole")))
				{
					GameObject.Find("GallerHole").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("Window")))
				{
					GameObject.Find("Window").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("KylDoor")))
				{
					GameObject.Find("KylDoor").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("KitchenLuckaOH")))
				{
					GameObject.Find("KitchenLuckaOH").AddComponent<GrannyHearAnomaly16>();
				}
				((Component)GameObject.Find("Loda2Parent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (4)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (5)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (6)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (7)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-9.841107f, 28.749262f, -4.7954473f);
				((Component)GameObject.Find("LodaParent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-11.310104f, 28.749266f, -4.7954473f);
				GameObject.Find("Vind2LockerDoor_**").AddComponent<GrannyHearAnomaly16>();
			}
			if (PrimeAnomalyNR == 17)
			{
				AnomalyTV = "17";
				AnomalyText.GetComponent<Text>().text = " anomaly 17:\r\nBeartraps in the house are replaced by the giant ones, but you have a nightmare remote control";
			}
			if (PrimeAnomalyNR == 18)
			{
				AnomalyTV = "18";
				AnomalyText.GetComponent<Text>().text = " anomaly 18:\r\nYou have returned to 1.7 and almost everything went right...";
				NewObjects.SetActive(false);
				PrimeAnomaly18NewObjects.SetActive(true);
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/Furniture/GameObject"));
				GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent").transform.position = new Vector3(0f, -100f, 0f);
				GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent (1)").transform.position = new Vector3(0f, -100f, 0f);
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorR"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/CellarFurniture/CellarFurniture/Collider"));
				HideCrouchCollider1 = Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (26)"), new Vector3(32.513153f, 118.35948f, -3.24f), Quaternion.Euler(0f, 90f, 0f));
				HideCrouchCollider1.transform.localScale = new Vector3(14.4f, 1.25165f, 6.2f);
				HideCrouchCollider2 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(28.357f, 1117.9f, -3.57f), Quaternion.Euler(0f, 90f, 0f));
				HideCrouchCollider2.transform.localScale = new Vector3(6.67f, 1.25165f, 2.1f);
				Object.Destroy((Object)(object)HideCrouchCollider2.GetComponent<hideCrouchButton>());
				((Collider)HideCrouchCollider2.GetComponent<BoxCollider>()).isTrigger = false;
				HideCrouchCollider3 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(1.2611513f, 20.520481f, -17.90914f), Quaternion.Euler(0f, 90f, 0f));
				HideCrouchCollider3.transform.localScale = new Vector3(0.23f, 6.54f, 5.7f);
				Object.Destroy((Object)(object)HideCrouchCollider3.GetComponent<hideCrouchButton>());
				((Collider)HideCrouchCollider3.GetComponent<BoxCollider>()).isTrigger = false;
				HideCrouchCollider4 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(-0.493f, 10.59f, 5.291f), Quaternion.Euler(0f, 90f, 0f));
				HideCrouchCollider4.transform.localScale = new Vector3(0.49f, 0.1f, 8f);
				Object.Destroy((Object)(object)HideCrouchCollider4.GetComponent<hideCrouchButton>());
				((Collider)HideCrouchCollider4.GetComponent<BoxCollider>()).isTrigger = false;
				GameObject.Find("Lekhus").tag = "Untagged";
				PrimeAnomaly9Note = GameObject.Find("TextMessage");
				PrimeAnomaly9Note.transform.localPosition = new Vector3(11.6f, -1.86f, 0.312f);
				PrimeAnomaly9Note.transform.rotation = Quaternion.Euler(90f, 25.89f, 180f);
				PrimeAnomaly9Note.tag = "Untagged";
				((Object)PrimeAnomaly9Note).name = "PrimeAnomaly18Message";
				OldPresets();
				if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1)
				{
					PrimeAnomaly18SkeletonHead.SetActive(true);
				}
				if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
				{
					((Component)PrimeAnomaly18NewObjects.transform.GetChild(17)).GetComponent<Camera>().backgroundColor = Color.red;
				}
				else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
				{
					((Component)PrimeAnomaly18NewObjects.transform.GetChild(17)).GetComponent<Camera>().backgroundColor = Color.black;
				}
			}
			if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1 && PrimeAnomalyNR != 1 && PrimeAnomalyNR != 6 && PrimeAnomalyNR != 9 && PrimeAnomalyNR != 15 && PrimeAnomalyNR != 16)
			{
				AnomalyText.GetComponent<Text>().text = "Nerfed prime" + AnomalyText.GetComponent<Text>().text;
			}
			else
			{
				AnomalyText.GetComponent<Text>().text = "Prime" + AnomalyText.GetComponent<Text>().text;
			}
		}
		((Graphic)((Component)GameObject.Find("BlackScreenStartHolder").transform.GetChild(0)).gameObject.GetComponent<Image>()).color = Color.black;
		DropPointScrewdriver = Object.Instantiate<GameObject>(GameObject.Find("DropPoint"), GameObject.Find("HandHoldObjects").transform);
		if (PrimeAnomalyNR != 18)
		{
			NewEscapeDoor = Object.Instantiate<GameObject>(GameObject.Find("GrannyHelaHuset/OldHouseWoodenDoor"), new Vector3(39.2f, 11.633f, -0.4277f), Quaternion.Euler(-90f, 0f, 0f));
			NewEscapeDoor.transform.localScale = new Vector3(112.098015f, 5.2115946f, 227.69579f);
			NewEscapeDoor.tag = "Untagged";
			((Object)NewEscapeDoor).name = "EscapeDoor";
			NewEscapeDoor.SetActive(false);
			PictureOnPlace = GameObject.Find("AllaMoveObject/TavlaSR1");
			Object.Destroy((Object)(object)GameObject.Find("AllaMoveObject/TavlaSR1/Trigger").GetComponent<objectFallFloor>());
			PictureOnPlace.transform.SetParent((Transform)null);
			PictureOnPlace.transform.position = new Vector3(27.47f, 25.79f, 4.68f);
			PictureOnPlace.transform.rotation = Quaternion.Euler(0f, -90f, -10f);
			Object.Destroy((Object)(object)PictureOnPlace.GetComponent<rivNerTavla>());
			((Behaviour)((Component)PictureOnPlace.transform.GetChild(0)).GetComponent<objectFallFloor>()).enabled = false;
			((Object)PictureOnPlace).name = "PictureOnPlace";
			PictureItem = Object.Instantiate<GameObject>(PictureOnPlace, new Vector3(-12.35f, 21.209f, 13.58f), Quaternion.Euler(14.957f, 0f, 0f));
			((Object)PictureItem).name = "Picture";
			PictureItem.tag = "vitrindoorRclosed";
			Object.Destroy((Object)(object)PictureItem.GetComponent<rivNerTavla>());
		}
		AllDoors = GameObject.Find("All doors");
		MeatDoor = GameObject.Find("GrannyHelaHuset/MeatDoor");
		GameObject.Find("SmallDoorParentVind").transform.localScale = new Vector3(0.22473012f, 0.22473f, -0.1927065f);
		GameObject.Find("SmallDoorParentVind").transform.localPosition = new Vector3(-7.774f, 0.2f, 17.29f);
		GameObject.Find("SmallDoorParentVind/SmallDoor").GetComponent<BoxCollider>().size = new Vector3(12.7f, 23.8f, 0.71f);
		GameObject.Find("InnerdoorParent (1)/Innerdoor").GetComponent<BoxCollider>().center = new Vector3(5.5f, 11.512108f, 0.17f);
		GameObject.Find("InnerdoorParent (1)/Innerdoor").GetComponent<BoxCollider>().size = new Vector3(18.52f, 23.02784f, 1.13f);
		GameObject.Find("SmallDoorParent (1)/SmallDoor").GetComponent<BoxCollider>().size = new Vector3(12.2f, 23.20185f, 0.71f);
		GameObject.Find("InnerdoorParent (2)/Innerdoor").GetComponent<BoxCollider>().center = new Vector3(7.5323625f, 11.512108f, 0.17f);
		GameObject.Find("InnerdoorParent (2)/Innerdoor").GetComponent<BoxCollider>().size = new Vector3(15.01f, 23.027838f, 1.13f);
		GameObject.Find("InnerdoorParent (3)/Innerdoor").GetComponent<BoxCollider>().size = new Vector3(15.2f, 23.027838f, 0.79f);
		GameObject.Find("InnerdoorParentVind2/InnerdoorVind").GetComponent<BoxCollider>().size = new Vector3(16f, 23.027838f, 0.79f);
		GameObject.Find("OldHouseWoodenDoor").GetComponent<BoxCollider>().size = new Vector3(0.021f, 0.07127297f, 0.02f);
		Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(25.532f, 12.59f, -2.28f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1f, 1f, 1f);
		Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(0.039f, 13.14f, -20.64f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.4f, 1f, 3.5f);
		GrannyCantSeeCollider = Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (26)"), new Vector3(-0.626f, 26.48f, 8.31f), Quaternion.Euler(0f, 90f, 0f));
		GrannyCantSeeCollider.transform.localScale = new Vector3(11.17f, 0.29f, 13.07f);
		((Collider)GrannyCantSeeCollider.GetComponent<BoxCollider>()).isTrigger = false;
		((Behaviour)GrannyCantSeeCollider.GetComponent<hideCrouchButton>()).enabled = false;
		GrannyCantSeeCollider.layer = 0;
		((Object)GrannyCantSeeCollider).name = "GrannyCantSeeCollider";
		GrannyCantSeeCollider2 = Object.Instantiate<GameObject>(GrannyCantSeeCollider, new Vector3(9.52f, 17.18f, -12.74f), Quaternion.Euler(0f, 90f, 0f));
		GrannyCantSeeCollider2.transform.localScale = new Vector3(0.15f, 2.71f, 3.5f);
		((Object)GrannyCantSeeCollider2).name = "GrannyCantSeeCollider2";
		GrannyCantSeeCollider3 = Object.Instantiate<GameObject>(GameObject.Find("ResetBrunn"));
		GrannyCantSeeCollider3.transform.SetParent((Transform)null);
		GrannyCantSeeCollider3.transform.position = new Vector3(6.48f, 13.172f, 1.14f);
		GrannyCantSeeCollider3.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
		GrannyCantSeeCollider3.transform.localScale = new Vector3(21.69f, 0.01f, 27.5f);
		((Object)GrannyCantSeeCollider3).name = "GrannyCantSeeCollider3";
		GrannyCantSeeCollider3.tag = "Untagged";
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), Player.GetComponent<Collider>(), true);
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), ((Component)playerCam).GetComponent<Collider>(), true);
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), GameObject.Find("BrokenP1_NYA").GetComponent<Collider>(), true);
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), GameObject.Find("BrokenP2_NYA").GetComponent<Collider>(), true);
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), GameObject.Find("BrokenP3_NYA").GetComponent<Collider>(), true);
		Physics.IgnoreCollision((Collider)(object)GrannyCantSeeCollider.GetComponent<BoxCollider>(), GameObject.Find("BrokenP4_NYA").GetComponent<Collider>(), true);
		GameObject.Find("BackdoorStair+Pallar/Collider (1)").transform.localPosition = new Vector3(-45.49f, 29.34f, -4.23f);
		GameObject.Find("FanCollider").GetComponent<AudioSource>().volume = 0.3f;
		GameObject.Find("HouseBakedReady/CellarFurniture/CellarFurniture/Collider").SetActive(false);
		GameObject.Find("Vind2").tag = "golv";
		GameObject.Find("TableCollider").tag = "Untagged";
		GameObject.Find("TableCollider (1)").tag = "Untagged";
		GameObject.Find("TableCollider (2)").tag = "Untagged";
		GameObject.Find("TableCollider (3)").tag = "Untagged";
		GameObject.Find("TableCollider (4)").tag = "Untagged";
		GameObject.Find("BordCollider").tag = "Untagged";
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			KnarrandeGolv.SetActive(false);
			DiffTV = "Chill";
			GameObject.Find("KlockdelOutside").SetActive(false);
			GameObject.Find("klockaOutside").SetActive(false);
			KlockaDel = GameObject.Find("Klockdel");
			Klocka = GameObject.Find("klocka");
			KlockaDel.SetActive(false);
			Klocka.SetActive(false);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			KnarrandeGolv.SetActive(true);
			GameObject.Find("KnarrPoints (4)").SetActive(false);
			DiffTV = "Normal";
		}
		else if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			KnarrandeGolv.SetActive(false);
			DiffTV = "Easy";
		}
		else if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			KnarrandeGolv.SetActive(true);
			GameObject.Find("KnarrPoints (4)").SetActive(false);
			DiffTV = "Hard";
		}
		else if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			KnarrandeGolvExtreme.SetActive(true);
			KnarrandeGolv.SetActive(false);
			DiffTV = "Extreme";
		}
		else if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			KnarrandeGolv.SetActive(true);
			GrannyMessage.SetActive(true);
			GameObject.Find("KnarrPoints (4)").SetActive(false);
			DiffTV = "Practice";
		}
		else if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
		{
			KnarrandeGolvExtreme.SetActive(true);
			KnarrandeGolv.SetActive(false);
			Galler1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/HoleGaller"), new Vector3(8.47f, 9.27f, -5.6f), Quaternion.Euler(0f, -90f, 0f));
			ExtraKnarr1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(12.24f, 13.8f, -3.43f), Quaternion.Euler(0f, 0f, 0f));
			ExtraKnarr1.transform.SetParent((Transform)null);
			ExtraKnarr1.transform.localScale = new Vector3(1.33f, 0.84f, 2.630001f);
			ExtraKnarr2 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(30.96f, 12.29f, -8.7419f), Quaternion.Euler(0f, 90f, 0f));
			ExtraKnarr2.transform.localScale = new Vector3(0.31496745f, 0.84f, 6.67f);
			ExtraKnarr3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(10.85f, 20.69f, -7.9f), Quaternion.identity);
			ExtraKnarr3.transform.localScale = new Vector3(6.9f, 0.84f, 2.07f);
			ExtraKnarr4 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (4)"), new Vector3(6.81f, 27.41f, 12.87f), Quaternion.identity);
			GameObject.Find("SecretDoor").tag = "Untagged";
			GameObject.Find("GrannyHouse8Update/SecretDoorParent/SecretDoor/HyllaCollider (1)").tag = "Untagged";
			GameObject.Find("GrannyHouse8Update/SecretDoorParent/SecretDoor/HyllaCollider").tag = "Untagged";
			Galler3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/HoleGaller"), new Vector3(4.23f, 8.908f, -28.63f), Quaternion.Euler(0f, 0f, 0f));
			Galler3Trigger = Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (26)"), new Vector3(4.707f, 8.28f, -25.01f), Quaternion.Euler(0f, 90f, 0f));
			Galler3Trigger.transform.localScale = new Vector3(2f, 1.25165f, 4.65f);
			Object.Destroy((Object)(object)Galler3Trigger.GetComponent<hideCrouchButton>());
			Galler3Trigger.AddComponent<GallerSewerOpen>();
			((Collider)Galler3Trigger.GetComponent<BoxCollider>()).isTrigger = true;
			if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				DiffTV = "Extreme+";
			}
			if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				DiffTV = "Cruel";
			}
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (PlayerPrefs.GetInt("PrimeOn") == 1)
			{
				GameObject.Find("InnerdoorParent/Innerdoor").tag = "innerdoorLocked";
				AHugeSuccessAchievement.SetActive(true);
				if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1 && PrimeAnomalyNR != 1 && PrimeAnomalyNR != 6 && PrimeAnomalyNR != 9 && PrimeAnomalyNR != 15 && PrimeAnomalyNR != 16 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0)
				{
					GlobalSaveManager.InstanceSaveData.SaveAllData("NerfedPrimeAtts", 0);
					SetNerfedPrime = true;
				}
				else if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
				{
					GlobalSaveManager.InstanceSaveData.SaveAllData("PrimePlusAtts", 0);
					SetPrimePlus = true;
				}
				else
				{
					GlobalSaveManager.InstanceSaveData.SaveAllData("PrimeAtts", 0);
					SetPrime = true;
				}
			}
			else
			{
				AnomalyText.GetComponent<Text>().text = "(G) = freeze / unfreeze Granny\r\n(H) = teleport to starting room\r\n(T) = remove a bear trap";
				if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
				{
					ChangeExtraTrapsButton.SetActive(true);
				}
			}
			if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
			{
				((Behaviour)((Component)this).gameObject.GetComponent<SetLaser>()).enabled = true;
			}
			KnarrandeGolvExtreme.SetActive(true);
			KnarrandeGolv.SetActive(false);
			Galler1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/HoleGaller"), new Vector3(8.47f, 9.27f, -5.6f), Quaternion.Euler(0f, -90f, 0f));
			if (PrimeAnomalyNR != 1)
			{
				ExtraKnarr1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(12.24f, 13.8f, -3.43f), Quaternion.Euler(0f, 0f, 0f));
				ExtraKnarr1.transform.SetParent((Transform)null);
				ExtraKnarr1.transform.localScale = new Vector3(1.33f, 0.84f, 2.630001f);
				ExtraKnarr2 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(30.96f, 12.29f, -8.7419f), Quaternion.Euler(0f, 90f, 0f));
				ExtraKnarr2.transform.localScale = new Vector3(0.31496745f, 0.84f, 6.67f);
				ExtraKnarr3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(10.85f, 20.69f, -7.9f), Quaternion.identity);
				ExtraKnarr3.transform.localScale = new Vector3(6.9f, 0.84f, 2.07f);
				ExtraKnarr4 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (4)"), new Vector3(6.81f, 27.41f, 12.87f), Quaternion.identity);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.68f, 12.89f, -24.1051f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.885216f, 0.84f, 2.7631557f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.32f, 8.9f, -1.1582f), Quaternion.Euler(-34.32f, 0f, 0f)).transform.localScale = new Vector3(1.624414f, 1.0563002f, 1.1954908f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.7551f, 13.9077f, 6.09f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3950119f, 0.8652093f, 7.1391144f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-15.5729f, 20.9071f, 3.1251f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.2449087f, 1.446078f, 10.080566f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.63f, 20.78f, 0.46f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(3.57f, 0.7f, 2.03f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(0.3756f, 20.7f, -4.7428f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.0658054f, 1.03163f, 1.0545235f);
				Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(10.392f, 12.4123f, -20.374f), Quaternion.Euler(0f, 68.989f, 0f)).transform.localScale = new Vector3(3.2058403f, 1.0563f, 1.0545235f);
				if (PrimeAnomalyNR == 4)
				{
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(8.6f, 14.1f, 6.56f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.9677436f, 0.84213996f, 4.105008f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(6.21f, 8.12f, -30.04f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.288772f, 0.84213996f, 5.0014257f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(21.0271f, 12.681f, -24.7748f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(4.201458f, 0.84213996f, 1.9341038f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-8.32f, 8.41f, 5.611f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.5137433f, 0.84213996f, 1.9341038f);
				}
			}
			GameObject.Find("SecretDoor").tag = "Untagged";
			GameObject.Find("GrannyHouse8Update/SecretDoorParent/SecretDoor/HyllaCollider (1)").tag = "Untagged";
			GameObject.Find("GrannyHouse8Update/SecretDoorParent/SecretDoor/HyllaCollider").tag = "Untagged";
			Galler3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/HoleGaller"), new Vector3(4.23f, 8.908f, -28.63f), Quaternion.Euler(0f, 0f, 0f));
			Galler3Trigger = Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (26)"), new Vector3(4.707f, 8.28f, -25.01f), Quaternion.Euler(0f, 90f, 0f));
			Galler3Trigger.transform.localScale = new Vector3(2f, 1.25165f, 4.65f);
			Object.Destroy((Object)(object)Galler3Trigger.GetComponent<hideCrouchButton>());
			Galler3Trigger.AddComponent<GallerSewerOpen>();
			((Collider)Galler3Trigger.GetComponent<BoxCollider>()).isTrigger = true;
			DiffTV = "Prime";
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastudoorParent (1)").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("GallerDoor").GetComponent<Rigidbody>().isKinematic = true;
			GameObject.Find("GallerDoor").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("LampaVR").SetActive(false);
			GameObject.Find("RumBVLampa").SetActive(false);
			GameObject.Find("LampaSR2").SetActive(false);
			GameObject.Find("Pedistal").SetActive(false);
			GameObject.Find("ManikinDoll").SetActive(false);
			GameObject.Find("WoodenBox").SetActive(false);
			GameObject.Find("WoodenBox (1)").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("WoodenBox (2)").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("Cowleg").SetActive(false);
			GameObject.Find("LitetBordVR").transform.position = new Vector3(0f, -200f, 0f);
			GameObject.Find("Kartong").SetActive(false);
			GameObject.Find("Kartong (1)").SetActive(false);
			GameObject.Find("Kartong (2)").SetActive(false);
			GameObject.Find("Kartong (3)").SetActive(false);
			GameObject.Find("Kartong (4)").SetActive(false);
			GameObject.Find("Kartong (5)").SetActive(false);
			GameObject.Find("VapenSkopDoor").transform.SetParent((Transform)null);
			GameObject.Find("VapenSkopDoor").transform.position = new Vector3(4.3f, 9.807f, -36.44f);
			GameObject.Find("VapenSkopDoor").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			GameObject.Find("VapenSkopDoor").transform.localScale = new Vector3(0.42f, 0.42f, 0.1633919f);
			GameObject.Find("InnerdoorParent (2)").transform.localPosition = new Vector3(12.54f, -5.020376f, 2.97f);
			GameObject.Find("InnerdoorParent (2)").transform.localRotation = Quaternion.Euler(-12.974f, 0f, 0f);
			GameObject.Find("InnerdoorParent (2)/Innerdoor").GetComponent<NavMeshObstacle>().carving = true;
			GameObject.Find("InnerdoorParent (2)/Innerdoor").tag = "Untagged";
			if (PrimeAnomalyNR != 6)
			{
				PrimeHole = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(10.1f, 6.41f, -6.853f), Quaternion.Euler(0f, 0f, 36f));
				PrimeHole.transform.localScale = new Vector3(0.63f, 0.63f, 0.63f);
				((Renderer)PrimeHole.GetComponent<MeshRenderer>()).material.color = Color.black;
			}
			if (PrimeAnomalyNR != 14)
			{
				day1Text.GetComponent<Image>().sprite = day6Text.GetComponent<Image>().sprite;
				day1Text.GetComponent<RectTransform>().sizeDelta = new Vector2(132.46f, 64.2f);
			}
			else
			{
				day2Text.GetComponent<Image>().sprite = day6Text.GetComponent<Image>().sprite;
				day2Text.GetComponent<RectTransform>().sizeDelta = new Vector2(132.46f, 64.2f);
			}
			((Component)playerCam).GetComponent<Camera>().backgroundColor = Color.white;
			((Component)GameObject.Find("CamOutdoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = Color.white;
			((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = Color.white;
			((Component)GameObject.Find("CoffinBackyard").transform.GetChild(0).GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = Color.white;
			if (PrimeAnomalyNR == 1)
			{
				KnarrandeGolvExtreme.SetActive(false);
			}
			if (PrimeAnomalyNR != 17)
			{
				PrimeBearTraps.SetActive(true);
				if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
				{
					GameObject[] array = GameObject.FindGameObjectsWithTag("beartrap");
					for (int i = 0; i < array.Length; i++)
					{
						((Renderer)((Component)array[i].transform.GetChild(0)).gameObject.GetComponent<MeshRenderer>()).material.color = Color.red;
						((Renderer)((Component)array[i].transform.GetChild(1)).gameObject.GetComponent<MeshRenderer>()).material.color = Color.red;
						((Renderer)((Component)array[i].transform.GetChild(2)).gameObject.GetComponent<MeshRenderer>()).material.color = Color.red;
					}
				}
			}
			if (PrimeAnomalyNR != 18)
			{
				LiftMessage = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(14f, 12.72f, -25.17f), Quaternion.Euler(90f, 180f, 0f));
				LiftMessage.tag = "Untagged";
				((Object)LiftMessage).name = "DarkMessage";
				GameObject.Find("OuthouseDoor").transform.position = new Vector3(34.36f, 14.14f, -25.815f);
				GameObject.Find("OuthouseDoor").transform.rotation = Quaternion.Euler(-23.35f, 0f, 0f);
				GameObject.Find("OuthouseDoor").tag = "Untagged";
			}
		}
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			Object.Instantiate<GameObject>(GameObject.Find("FanCollider"), new Vector3(14.18f, 25.98f, -6.93f), Quaternion.Euler(0f, 0f, 90f)).transform.SetParent(((Component)playerCam).transform);
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
		{
			PlayerPrefs.SetInt("NotFirstEverAnomaly", 1);
			AnomalyNR = PlayerPrefs.GetInt("AnomalyNR");
			if (PlayerPrefs.GetInt("AnomalyNR") == 9191)
			{
				AnomalyNR = 91;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 1405)
			{
				AnomalyNR = 92;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 8841)
			{
				AnomalyNR = 93;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 3991)
			{
				AnomalyNR = 94;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 1793)
			{
				AnomalyNR = 95;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 1000)
			{
				AnomalyNR = 96;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 2134)
			{
				AnomalyNR = 97;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 2025)
			{
				AnomalyNR = 98;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 1954)
			{
				AnomalyNR = 100;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 2202)
			{
				AnomalyNR = 101;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 2311)
			{
				AnomalyNR = 102;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 8228)
			{
				AnomalyNR = 103;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 3103)
			{
				AnomalyNR = 104;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 4542)
			{
				AnomalyNR = 105;
			}
			if (PlayerPrefs.GetInt("AnomalyNR") == 7102)
			{
				AnomalyNR = 106;
			}
			if (PlayerPrefs.GetInt("EventChallenge1") == 1)
			{
				AnomalyNR = 23061;
			}
			if (AnomalyNR == 0)
			{
				AnomalyNR = Random.Range(1, 48);
				if (AnomalyNR == 27)
				{
					AnomalyNR = Random.Range(37, 48);
				}
			}
			if (AnomalyNR == 25)
			{
				AnomalyNR = 2525;
			}
			if (AnomalyNR == 1)
			{
				AnomalyTV = "1";
				AnomalyText.GetComponent<Text>().text = "Anomaly 1:\r\nGranny moves 50% faster, but there are no more creaking floors in the house";
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
				}
				KnarrandeGolvExtreme.SetActive(false);
				KnarrandeGolv.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
			}
			if (AnomalyNR == 2)
			{
				AnomalyTV = "2";
				AnomalyText.GetComponent<Text>().text = "Anomaly 2:\r\nThe house is MUCH darker, but Granny's vision is also very poor";
			}
			if (AnomalyNR == 3)
			{
				AnomalyTV = "3";
				AnomalyText.GetComponent<Text>().text = "Anomaly 3:\r\nAll characters move twice as fast";
			}
			if (AnomalyNR == 4)
			{
				AnomalyTV = "4";
				AnomalyText.GetComponent<Text>().text = "Anomaly 4:\r\nAll the doors in the house are gone";
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastudoorParent (1)").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("GrannyHelaHuset/MeatDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("GrannyHelaHuset/OldHouseWoodenDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("StealDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/MetalLockerDoorParent (1)").transform.position = new Vector3(0f, -1000f, 0f);
			}
			if (AnomalyNR == 5)
			{
				AnomalyTV = "5";
				AnomalyText.GetComponent<Text>().text = "Anomaly 5:\r\nEvery 30 seconds the bell rings, reminding Granny to guard the main exit door";
				if (PlayerPrefs.GetInt("DiffData") != -1)
				{
					GameObject.Find("KlockdelOutside").SetActive(false);
				}
				else
				{
					KlockaDel.SetActive(true);
					Klocka.SetActive(true);
				}
			}
			if (AnomalyNR == 6)
			{
				AnomalyTV = "6";
				AnomalyText.GetComponent<Text>().text = "Anomaly 6:\r\nYou can only crawl, but you have endless spray";
			}
			if (AnomalyNR == 7)
			{
				AnomalyTV = "7";
				AnomalyText.GetComponent<Text>().text = "Anomaly 7:\r\nYou can't use the Drop button, but then you have long arms";
			}
			if (AnomalyNR == 8)
			{
				AnomalyTV = "8";
				AnomalyText.GetComponent<Text>().text = "Anomaly 8:\r\nThere are more creaking floors in the house, but the padlock and trunk have already opened";
				if (PlayerPrefs.GetInt("DiffData") == -1 || PlayerPrefs.GetInt("DiffData") == 1)
				{
					KnarrandeGolv.SetActive(true);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4)
				{
					KnarrandeGolvExtreme.SetActive(true);
					KnarrandeGolv.SetActive(false);
					GameObject.Find("HoleGaller").SetActive(false);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 3)
				{
					KnarrandeGolvExtreme.SetActive(true);
					KnarrandeGolv.SetActive(false);
					ExtraKnarr1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(12.24f, 13.8f, -3.43f), Quaternion.Euler(0f, 0f, 0f));
					ExtraKnarr1.transform.SetParent((Transform)null);
					ExtraKnarr1.transform.localScale = new Vector3(1.33f, 0.84f, 2.630001f);
					ExtraKnarr2 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(30.96f, 12.29f, -8.7419f), Quaternion.Euler(0f, 90f, 0f));
					ExtraKnarr2.transform.localScale = new Vector3(0.31496745f, 0.84f, 6.67f);
					ExtraKnarr3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(10.85f, 20.69f, -7.9f), Quaternion.identity);
					ExtraKnarr3.transform.localScale = new Vector3(6.9f, 0.84f, 2.07f);
					ExtraKnarr4 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (4)"), new Vector3(6.81f, 27.41f, 12.87f), Quaternion.identity);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.68f, 12.89f, -24.1051f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.885216f, 0.84f, 2.7631557f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.32f, 8.9f, -1.1582f), Quaternion.Euler(-34.32f, 0f, 0f)).transform.localScale = new Vector3(1.624414f, 1.0563002f, 1.1954908f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.7551f, 13.9077f, 6.09f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3950119f, 0.8652093f, 7.1391144f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-15.5729f, 20.9071f, 3.1251f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.2449087f, 1.446078f, 10.080566f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.63f, 20.78f, 0.46f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(3.57f, 0.7f, 2.03f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(0.3756f, 20.7f, -4.7428f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.0658054f, 1.03163f, 1.0545235f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(10.392f, 12.4123f, -20.374f), Quaternion.Euler(0f, 68.989f, 0f)).transform.localScale = new Vector3(3.2058403f, 1.0563f, 1.0545235f);
				}
			}
			if (AnomalyNR == 9)
			{
				AnomalyTV = "9";
				AnomalyText.GetComponent<Text>().text = "Special anomaly 9:\r\nThe Crow is terminally ill, it will die in 90 seconds, so you must feed it food to extend its life for another 90 seconds and you have only one day, but you have a bird seed";
				GameObject.Find("Teddy").SetActive(false);
			}
			if (AnomalyNR == 10)
			{
				AnomalyTV = "10";
				AnomalyText.GetComponent<Text>().text = "Anomaly 10:\r\nEvery 30 seconds, a new vase will appear, which will fall in a random place in the house and may make some noise";
			}
			if (AnomalyNR == 11)
			{
				AnomalyTV = "11";
				AnomalyText.GetComponent<Text>().text = "Anomaly 11:\r\nYou need to unlock all escape routes and you only have one day, but items will fall from the sky every 2 minutes";
			}
			if (AnomalyNR == 12)
			{
				AnomalyTV = "12";
				AnomalyText.GetComponent<Text>().text = "Anomaly 12:\r\nYou have only 8 minutes to escape, but you move twice as fast";
			}
			if (AnomalyNR == 13)
			{
				AnomalyTV = "13";
				AnomalyText.GetComponent<Text>().text = "Anomaly 13:\r\nThere are almost no items in the house, only pieces of a painting, and Granny moves 25% faster. But you will escape if you collect the painting 3 times";
				tavla.SetActive(true);
				tavelBitPlace1.SetActive(true);
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").SetActive(false);
			}
			if (AnomalyNR == 14)
			{
				AnomalyTV = "14";
				AnomalyText.GetComponent<Text>().text = "Anomaly 14:\r\nItems slip out of hands every 10 seconds, but there are no more creaking floors in the house";
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
				}
				KnarrandeGolvExtreme.SetActive(false);
				KnarrandeGolv.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
				AnomalyTimer = 15f;
			}
			if (AnomalyNR == 15)
			{
				AnomalyTV = "15";
				AnomalyText.GetComponent<Text>().text = "Anomaly 15:\r\nGranny hears NOTHING\r\n(But she is always running)";
			}
			if (AnomalyNR == 16)
			{
				AnomalyTV = "16";
				AnomalyText.GetComponent<Text>().text = "Anomaly 16:\r\nGranny hears EVERYTHING\r\n(But not your footsteps, picking up items, locked doors and hiding under bed)";
				((Object)Object.Instantiate<GameObject>(((Component)KnarrandeGolv.transform.GetChild(0)).gameObject, new Vector3(100f, 100f, 100f), Quaternion.identity)).name = "Noise16Anomaly";
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastudoorParent (1)/BastuDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("GrannyHelaHuset/MeatDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("GrannyHelaHuset/OldHouseWoodenDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("StealDoor").AddComponent<GrannyHearAnomaly16>();
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/MetalLockerDoorParent (1)/MetalLockerDoor").AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(0)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(1)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(2)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(3)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(4)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(5)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(6)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(7)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(8)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(9)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)((Component)GameObject.Find("All doors").transform.GetChild(10)).transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-6.567f, 21.44f, 13.960455f);
				((Component)GameObject.Find("All doors").transform.GetChild(13)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("KitchenDoor1Parent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				if (Object.op_Implicit((Object)(object)GameObject.Find("Motorhuv")))
				{
					GameObject.Find("Motorhuv").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("Backlucka")))
				{
					GameObject.Find("Backlucka").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("LekhusDoor")))
				{
					GameObject.Find("LekhusDoor").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("GallerHole")))
				{
					GameObject.Find("GallerHole").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("Window")))
				{
					GameObject.Find("Window").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("KylDoor")))
				{
					GameObject.Find("KylDoor").AddComponent<GrannyHearAnomaly16>();
				}
				if (Object.op_Implicit((Object)(object)GameObject.Find("KitchenLuckaOH")))
				{
					GameObject.Find("KitchenLuckaOH").AddComponent<GrannyHearAnomaly16>();
				}
				((Component)GameObject.Find("Loda2Parent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (4)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (5)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (6)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("Loda2Parent (7)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent (1)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16>();
				((Component)GameObject.Find("LodaParent (2)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-9.841107f, 28.749262f, -4.7954473f);
				((Component)GameObject.Find("LodaParent (3)").transform.GetChild(0)).gameObject.AddComponent<GrannyHearAnomaly16Attic>().point = new Vector3(-11.310104f, 28.749266f, -4.7954473f);
				GameObject.Find("Vind2LockerDoor_**").AddComponent<GrannyHearAnomaly16>();
			}
			if (AnomalyNR == 17)
			{
				AnomalyTV = "17";
				AnomalyText.GetComponent<Text>().text = "Anomaly 17:\r\nThere are giant traps, but there are no more creaking floors in the house";
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
				}
				KnarrandeGolvExtreme.SetActive(false);
				KnarrandeGolv.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
			}
			if (AnomalyNR == 19)
			{
				AnomalyTV = "19";
				AnomalyText.GetComponent<Text>().text = "Anomaly 19:\r\nSome obstacles have been placed in the house, but you have a special remote that teleports you around the house";
				KnarrandeGolvExtreme.SetActive(true);
				if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 1 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 4 || PlayerPrefs.GetInt("DiffData") == -1)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
					Galler1 = Object.Instantiate<GameObject>(GameObject.Find("HoleGaller"), new Vector3(8.47f, 9.27f, -5.6f), Quaternion.Euler(0f, -90f, 0f));
					Galler3 = Object.Instantiate<GameObject>(GameObject.Find("HoleGaller"), new Vector3(4.23f, 8.908f, -28.63f), Quaternion.Euler(0f, 0f, 0f));
				}
				Anomaly19Galler1 = Object.Instantiate<GameObject>(GameObject.Find("HoleGaller"), new Vector3(6.186f, 16.0037f, 12.5338f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler1.transform.localScale = new Vector3(0.44947684f, 0.3281436f, 0.16510412f);
				((Renderer)Anomaly19Galler1.GetComponent<MeshRenderer>()).material.SetColor("_Color", new Color(0.25f, 0f, 0.25f));
				Anomaly19Galler2 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(13.254f, 28.946f, 5.1583f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler2.transform.localScale = new Vector3(0.26886177f, 0.25135854f, 0.16510412f);
				Anomaly19Galler3 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(6.7304f, 29.6209f, 14.03f), Quaternion.Euler(0f, 0f, 0f));
				Anomaly19Galler3.transform.localScale = new Vector3(0.32090068f, 0.3299218f, 0.16510412f);
				Anomaly19Galler4 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-11.5086f, 15.9371f, -1.742f), Quaternion.Euler(0f, 0f, 0f));
				Anomaly19Galler4.transform.localScale = new Vector3(0.45031995f, 0.3336733f, 0.16510412f);
				Anomaly19Galler5 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-0.68f, 15.9371f, -2.86f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler5.transform.localScale = new Vector3(0.45031995f, 0.3336733f, 0.16510412f);
				Anomaly19Galler6 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-0.68f, 15.9371f, -5.96f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler6.transform.localScale = new Vector3(0.45031995f, 0.3336733f, 0.16510412f);
				Anomaly19Galler7 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-0.68f, 15.9371f, -9.13f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler7.transform.localScale = new Vector3(0.45031995f, 0.3336733f, 0.16510412f);
				Anomaly19Galler8 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-19.2373f, 22.8189f, -1.764f), Quaternion.Euler(0f, 0f, 0f));
				Anomaly19Galler8.transform.localScale = new Vector3(0.38717195f, 0.33844483f, 0.16510412f);
				Anomaly19Galler9 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-7.943f, 35.7942f, -6.1563f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler9.transform.localScale = new Vector3(0.30647972f, 0.3086468f, 0.16510412f);
				Anomaly19Galler10 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-15.482f, 22.724f, -9.2754f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler10.transform.localScale = new Vector3(0.40024394f, 0.3281436f, 0.16510412f);
				Anomaly19Galler11 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(-7.3298f, 14.595f, -28.74f), Quaternion.Euler(0f, 0f, 0f));
				Anomaly19Galler11.transform.localScale = new Vector3(0.25207338f, 0.2739539f, 0.16510412f);
				Anomaly19Galler12 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(3.57f, 23.4243f, 1.6469f), Quaternion.Euler(0f, 54.173f, 0f));
				Anomaly19Galler12.transform.localScale = new Vector3(0.6354485f, 0.41561657f, 0.45f);
				Anomaly19Galler13 = Object.Instantiate<GameObject>(Anomaly19Galler1, new Vector3(19.65f, 16f, -6.17f), Quaternion.Euler(0f, 90f, 0f));
				Anomaly19Galler13.transform.localScale = new Vector3(0.3936584f, 0.3281436f, 0.16510412f);
				Anomaly19Button = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), new Vector3(-1.749f, 9.5478f, 5.285f), Quaternion.Euler(90f, 0f, 0f));
				Anomaly19Button.transform.SetParent((Transform)null);
				Anomaly19Button.transform.localScale = new Vector3(0.49f, 0.49f, 0.49f);
				Anomaly19Button.AddComponent<BoxCollider>();
				((Renderer)Anomaly19Button.GetComponent<MeshRenderer>()).material.color = Color.magenta;
				((Object)Anomaly19Button).name = "Anomaly19Button";
				GameObject.Find("Window").transform.position = new Vector3(100f, 10000f, 1000f);
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(-1.749f, 9.5478f, 5.285f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(28.504f, 14.256f, -3.655f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(10.847f, 16.017f, 4.802f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(-14.661f, 15.087f, -2.172f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(-15.446f, 22.488f, -13.33f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(-3.215f, 14.351f, -35.625f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(12.803f, 26.992f, 3.72f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(-6.171f, 35.095f, -4.78f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				((Object)Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(12.172f, 22.495f, -4.255f), Quaternion.Euler(90f, 0f, 0f))).name = "Anomaly19Button";
				if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 1 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4 || PlayerPrefs.GetInt("DiffData") == -1)
				{
					KnarrandeGolvExtreme.SetActive(false);
				}
			}
			if (AnomalyNR == 20)
			{
				AnomalyTV = "20";
				AnomalyText.GetComponent<Text>().text = "Anomaly 20:\r\n Something strange is happening with the light in the house";
			}
			if (AnomalyNR == 21)
			{
				AnomalyTV = "21";
				AnomalyText.GetComponent<Text>().text = "Anomaly 21:\r\n When you drop an item, it will fall near the anomaly vase";
				((Renderer)(MeshRenderer)GameObject.Find("Vas").GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.magenta);
				Anomaly21VasDropPoint = Object.Instantiate<GameObject>(GameObject.Find("DropPoint"), GameObject.Find("HandHoldObjects").transform);
				Anomaly21DropPoint = GameObject.Find("DropPoint");
				Anomaly21DropPoint.transform.SetParent((Transform)null);
			}
			if (AnomalyNR == 22)
			{
				AnomalyTV = "22";
				AnomalyText.GetComponent<Text>().text = "Anomaly 22:\r\nGranny moves twice as fast, but she is worse at catching you";
			}
			if (AnomalyNR == 23)
			{
				AnomalyTV = "23";
				AnomalyText.GetComponent<Text>().text = "Anomaly 23:\r\nGranny will set new creacking floors during the game, but there are less creacking floors";
				if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4)
				{
					Anomaly23creack = Object.Instantiate<GameObject>(((Component)KnarrandeGolv.transform.GetChild(0)).gameObject, new Vector3(-63.8f, 127.47f, 10.87f), Quaternion.identity);
				}
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					Anomaly23creack = Object.Instantiate<GameObject>(((Component)KnarrandeGolvExtreme.transform.GetChild(0)).gameObject, new Vector3(-63.8f, 127.47f, 10.87f), Quaternion.identity);
				}
				if (PlayerPrefs.GetInt("DiffData") == 1 || PlayerPrefs.GetInt("DiffData") == -1)
				{
					KnarrandeGolv.SetActive(true);
					Anomaly23creack = Object.Instantiate<GameObject>(((Component)KnarrandeGolv.transform.GetChild(0)).gameObject, new Vector3(-63.8f, 127.47f, 10.87f), Quaternion.identity);
					KnarrandeGolv.SetActive(false);
				}
				if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4)
				{
					KnarrandeGolv.SetActive(false);
				}
				if (PlayerPrefs.GetInt("DiffData") == 3)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
					KnarrandeGolv.SetActive(true);
					KnarrandeGolvExtreme.SetActive(false);
				}
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
			}
			if (AnomalyNR == 24)
			{
				AnomalyTV = "24";
				AnomalyText.GetComponent<Text>().text = "Anomaly 24:\r\nEvery 4 seconds, Granny gains +1% speed (up to a maximum of 300%), but you move twice as fast";
				AnomalyTimer = 15f;
			}
			if (AnomalyNR == 2525)
			{
				AnomalyTV = "25";
				AnomalyText.GetComponent<Text>().text = "Anomaly 25:\r\n Granny is invisible, but you have a freeze trap";
			}
			if (AnomalyNR == 26)
			{
				AnomalyTV = "26";
				AnomalyText.GetComponent<Text>().text = "Anomaly 26:\r\nThere are anomalous rats in the house. When they bite you, Granny charges a secret ability. After every fifth bite, Granny activates it";
				rats.SetActive(true);
				Rat3 = Object.Instantiate<GameObject>(GameObject.Find("Rat1"), new Vector3(5.34f, 13.349f, -7.367f), Quaternion.identity);
				((Component)Rat3.transform.GetChild(0).GetChild(3)).GetComponent<ParticleSystem>().startColor = Color.magenta;
				Rat4 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(-6.2f, 17.45f, -19.58f), Quaternion.identity);
				((Component)Rat4.transform.GetChild(0).GetChild(3)).GetComponent<ParticleSystem>().startColor = Color.magenta;
				Rat5 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(18.47f, 20.1f, -11.077f), Quaternion.identity);
				((Component)Rat5.transform.GetChild(0).GetChild(3)).GetComponent<ParticleSystem>().startColor = Color.magenta;
				((Component)GameObject.Find("Rat1").transform.GetChild(0).GetChild(3)).GetComponent<ParticleSystem>().startColor = Color.magenta;
				((Component)GameObject.Find("Rat2").transform.GetChild(0).GetChild(3)).GetComponent<ParticleSystem>().startColor = Color.magenta;
				GameObject.Find("Teddy").SetActive(false);
			}
			if (AnomalyNR == 27)
			{
				AnomalyTV = "27";
				NewObjects.SetActive(false);
				LiftMessage = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(-1.42f, 8.45f, -40.743f), Quaternion.Euler(-180f, 0f, 0f));
				LiftMessage.tag = "Untagged";
				((Object)LiftMessage).name = "SecretDescription";
				if (PlayerPrefs.GetInt("Anomaly27Levels") == 0)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThere are almost no items in the house, but you can find 7 red keys to escape through the new door";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 1)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThere are almost no items in the house, but you can find 7 red keys to escape\r\n\r\n again";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 2)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nPlease be patient";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 3)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThere are almost no items in the house, but you can find 7 red keys to escape through the new door";
					GameObject.Find("Teddy").transform.SetParent((Transform)null);
					GameObject.Find("Teddy").transform.position = new Vector3(-9.37f, 15.145f, -29.15f);
					GameObject.Find("Vagga").SetActive(false);
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 4)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nPlease accept my gift for your prudence";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 5)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThere are almost no items in the house, but you can find 7 green keys to escape through the new door";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 6)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThere are almost no items in the house, but you can find 7 blue keys to FINALLY END THIS HELL";
				}
				else if (PlayerPrefs.GetInt("Anomaly27Levels") == 7)
				{
					AnomalyText.GetComponent<Text>().text = "Special anomaly 27:\r\nThe hell is over...";
					LiftMessage = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(7.61f, 22.47f, -3.8f), Quaternion.Euler(90f, 0f, 40f));
					LiftMessage.tag = "Untagged";
					((Object)LiftMessage).name = "SecretInvite";
					GameObject.Find("InnerdoorParent/Innerdoor").tag = "innerdoorLocked";
					GameObject.Find("SmallDoorParent (1)/SmallDoor").GetComponent<NavMeshObstacle>().carving = true;
				}
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					Galler3.SetActive(false);
				}
				RedDoor = Object.Instantiate<GameObject>(GameObject.Find("OldHouseWoodenDoor"), new Vector3(-10.8f, 12.381138f, -39.57f), Quaternion.Euler(-90f, -90f, 0f));
				RedDoor.transform.localScale = new Vector3(112.098015f, 5.2115955f, 227.6957f);
				((Object)RedDoor).name = "RedDoor";
				RedDoor.tag = "Untagged";
				GameObject.Find("UsefulObjects/TextMessage").transform.SetParent((Transform)null);
				GameObject.Find("TextMessage").transform.position = new Vector3(-2.4f, -114.317f, -36f);
				GameObject.Find("TextMessage").transform.rotation = Quaternion.Euler(90f, 25f, 180f);
				GameObject.Find("UsefulObjects").SetActive(false);
				GameObject.Find("PepperSpray").SetActive(false);
				GameObject.Find("Vind2Door_**").transform.position = new Vector3(0f, 100f, 0f);
				((Component)GameObject.Find("SpecialKeyLock").transform.GetChild(0)).gameObject.SetActive(true);
				GameObject.Find("PlankaVind").SetActive(false);
				GameObject.Find("PlankaVind2").SetActive(false);
				GameObject.Find("PlankaVind3").SetActive(false);
				GameObject.Find("LekhusDoor").tag = "innerdoorClosed";
				GameObject.Find("LekhusPadlock").SetActive(false);
				PictureItem.SetActive(false);
				GameObject.Find("All doors/SmallDoorParent/SmallDoor").tag = "smalldoorClosed";
				GameObject.Find("RemoteLockDel2").SetActive(false);
				GameObject.Find("RemoteLock").SetActive(false);
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/Furniture/GameObject"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent (1)"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorR"));
				((shootSpiderButton)(object)GameObject.Find("ShootButton").GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
				((Renderer)GameObject.Find("BastuSpak").GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("Tavelspak").GetComponent<MeshRenderer>()).material.mainTexture;
				((Renderer)GameObject.Find("Galge").GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("Tavelspak").GetComponent<MeshRenderer>()).material.mainTexture;
			}
			if (AnomalyNR == 28)
			{
				AnomalyTV = "28";
				AnomalyText.GetComponent<Text>().text = "Anomaly 28:\r\n Granny can create her own clone, which she can use for teleportation";
			}
			if (AnomalyNR == 29)
			{
				AnomalyTV = "29";
				AnomalyText.GetComponent<Text>().text = "Anomaly 29:\r\n There are floor plates in the house that either speed you up or slow you down by 60%";
				Anomaly29Plate = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, (Transform)null);
				Anomaly29Plate.SetActive(true);
				Anomaly29Plate.transform.position = new Vector3(6.296f, 26.93f, 8.53f);
				Anomaly29Plate.transform.rotation = Quaternion.Euler(90f, 0f, 180f);
				Anomaly29Plate.transform.localScale = new Vector3(0.4560123f, 0.08472632f, 0.0415763f);
				((Renderer)Anomaly29Plate.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).material.mainTexture;
				((Collider)Anomaly29Plate.AddComponent<BoxCollider>()).isTrigger = true;
				Anomaly29Plate.GetComponent<BoxCollider>().center = new Vector3(0f, 7f, -52f);
				Anomaly29Plate.GetComponent<BoxCollider>().size = new Vector3(16.70534f, 140.6033f, 101f);
				Anomaly29Plate.AddComponent<SlowDownSpeedUp>();
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-7.271f, 26.93f, 8.3523f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.400242f, 0.08753076f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-2.868f, 33.53f, 2.3103f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.40480542f, 0.049234502f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-4.72f, 20.11f, 2.88f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.11000961f, 0.032956503f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-6.03f, 20.11f, 7.643f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.11000961f, 0.029410385f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-9.254f, 20.11f, 9.7743f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.16709538f, 0.021681488f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-13.39f, 20.11f, 12.52f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.14003442f, 0.049847495f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-13.85f, 20.11f, 2.331f), Quaternion.Euler(90f, 121.62f, 180f)).transform.localScale = new Vector3(0.08317066f, 0.09437347f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-17.88f, 20.11f, -4.11f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.25794291f, 0.028229607f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-15.6853f, 20.11f, -9.7534f), Quaternion.Euler(90f, 121.62f, 180f)).transform.localScale = new Vector3(0.057865135f, 0.07471736f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-7.2445f, 20.11f, -4.9038f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.18516818f, 0.10155383f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-17.9964f, 20.11f, -18.8661f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.3068099f, 0.034071308f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-5.35f, 17.42f, -21.44f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.3068099f, 0.034071308f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(1.6f, 17.42f, -22.59f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.27367443f, 0.05362824f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-0.901f, 12.41f, -22.865f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.27367443f, 0.05362824f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-6.2676f, 12.398f, -31.6043f), Quaternion.Euler(90f, 0f, -141.1f)).transform.localScale = new Vector3(0.09325942f, 0.04674737f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(4.0957f, 12.41f, -36.504f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.48880363f, 0.04907044f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-1.9141f, 12.41f, -32.517f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.13824312f, 0.01851771f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-0.6082f, 20.11f, 0.5773f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.15204585f, 0.02541935f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(8.11f, 20.11f, -6.7566f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.15204585f, 0.03568368f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(8.1979f, 20.11f, -11.985f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.077840954f, 0.053498536f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(15.5503f, 20.11f, 5.4041f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.25705323f, 0.08616113f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(9.8067f, 20.11f, 5.695f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.32848832f, 0.089914985f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(8.5355f, 13.35f, 11.7577f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.24396554f, 0.033407398f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(8.5355f, 13.35f, 6.55f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.24396554f, 0.033407398f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(8.5355f, 13.35f, 1.363f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.24396554f, 0.033407398f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(13.0489f, 13.35f, -11.6157f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.11357743f, 0.09887224f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-7f, 13.35f, -7.2675f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.63412654f, 0.09378643f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-12.3555f, 13.35f, 4.29f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.63412654f, 0.056692585f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-4.8163f, 13.35f, 10.422f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.40211064f, 0.029021261f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(-8.3336f, 7.55f, 2.7532f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.12100731f, 0.061225552f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(27.8572f, 11.84f, -16f), Quaternion.Euler(90f, 180f, -130f)).transform.localScale = new Vector3(0.12089519f, 0.123886146f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(15.8012f, 11.84f, -19.1214f), Quaternion.Euler(90f, 180f, -170f)).transform.localScale = new Vector3(0.34266585f, 0.052722f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(31.4418f, 11.84f, -9.6302f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.1291207f, 0.048921984f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(9.988f, 12.568f, -13.98f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.12251238f, 0.022293197f, 0.0415763f);
				Object.Instantiate<GameObject>(Anomaly29Plate, new Vector3(13.725f, 20.097f, -7.214f), Quaternion.Euler(90f, 90f, 180f)).transform.localScale = new Vector3(0.13674831f, 0.0154298125f, 0.0415763f);
			}
			if (AnomalyNR == 30)
			{
				AnomalyTV = "30";
				AnomalyText.GetComponent<Text>().text = "Anomaly 30:\r\nIf Granny spots you, you will die, but there are no creaking floors in the house and there is can't be darker";
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
				}
				KnarrandeGolvExtreme.SetActive(false);
				KnarrandeGolv.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
			}
			if (AnomalyNR == 31)
			{
				AnomalyTV = "31";
				AnomalyText.GetComponent<Text>().text = "Anomaly 31:\r\n Granny moves 75% faster, but you have 3 mysterious boxes in your room";
			}
			if (AnomalyNR == 32)
			{
				AnomalyTV = "32";
				AnomalyText.GetComponent<Text>().text = "Anomaly 32:\r\n Granny moves ultra fast, you have one day and there are no doors, but she is blind for the rest of the game";
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastudoorParent (1)").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("GrannyHelaHuset/MeatDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("GrannyHelaHuset/OldHouseWoodenDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("StealDoor").transform.position = new Vector3(0f, -1000f, 0f);
				GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/MetalLockerDoorParent (1)").transform.position = new Vector3(0f, -1000f, 0f);
			}
			if (AnomalyNR == 33)
			{
				AnomalyTV = "33";
				AnomalyText.GetComponent<Text>().text = "Anomaly 33:\r\n Items can't make noises";
			}
			if (AnomalyNR == 34)
			{
				AnomalyTV = "34";
				AnomalyText.GetComponent<Text>().text = "Anomaly 34:\r\n If you have an item, you move 30% slower, but if your hands are empty, you move 60% faster";
			}
			if (AnomalyNR == 35)
			{
				AnomalyTV = "35";
				AnomalyText.GetComponent<Text>().text = "Anomaly 35:\r\n You have short hands, but you drop items very hard";
			}
			if (AnomalyNR == 36)
			{
				AnomalyTV = "36";
				AnomalyText.GetComponent<Text>().text = "Special anomaly 36:\r\n Everything is wrong with this house...";
				Anomaly36SetLasers();
				TextObject = Object.Instantiate<GameObject>(GameObject.Find("AllSafeColliders/SafeCollider (1)"), new Vector3(34.325f, 28.11f, 5.93f), Quaternion.Euler(0f, 90f, 0f));
				Object.Destroy((Object)(object)TextObject.GetComponent<BoxCollider>());
				TextObject.transform.SetParent((Transform)null);
				TextObject.transform.localScale = new Vector3(4.06f, 3.37f, 2f);
				TextTask = TextObject.AddComponent<TextMesh>();
				TextTask.text = "";
				TextTask.offsetZ = 0.31f;
				TextTask.characterSize = 0.01f;
				TextTask.fontSize = 199;
				TextTask.richText = true;
				TextObject.SetActive(false);
				TVText = Object.Instantiate<GameObject>(TextObject, new Vector3(-18.028f, 16.355f, -4.577f), Quaternion.Euler(0f, 0f, 0f));
				TVText.transform.localScale = new Vector3(0.77f, 0.67f, 2f);
				TVText.GetComponent<TextMesh>().text = "";
				TVText.GetComponent<TextMesh>().fontSize = 175;
				TVText.GetComponent<TextMesh>().color = Color.white;
				Object.Destroy((Object)(object)TVText.GetComponent<BoxCollider>());
				TVText.SetActive(false);
				TextVision = Object.Instantiate<GameObject>(GameObject.Find("Remotetrigger"), new Vector3(31.13f, 21.95f, -0.82f), Quaternion.Euler(-90f, 0f, 0f));
				TextVision.transform.SetParent((Transform)null);
				TextVision.transform.localScale = new Vector3(6.8f, 18f, 1.2f);
				TVArea = Object.Instantiate<GameObject>(TextVision, new Vector3(-17.1f, 14.33f, -7.59f), Quaternion.Euler(-90f, 0f, 0f));
				((Object)TVArea).name = "TVArea";
				TVArea.transform.SetParent((Transform)null);
				TVArea.transform.localScale = new Vector3(8.07f, 11.42f, 1.2f);
				Granny.SetActive(false);
				Granny.transform.position = new Vector3(-18.878765f, 13.345097f, -7.7548428f);
				Granny.SetActive(true);
				GameObject.Find("GrannyStartPos1").transform.position = new Vector3(-18.878765f, 13.345097f, -7.7548428f);
				GameObject.Find("Nav4").transform.position = GameObject.Find("Nav1").transform.position;
				GameObject.Find("Nav5").transform.position = GameObject.Find("Nav2").transform.position;
				GameObject.Find("Nav7").transform.position = GameObject.Find("Nav3").transform.position;
				GameObject.Find("Nav11").transform.position = GameObject.Find("Nav6").transform.position;
				GameObject.Find("Nav12").transform.position = GameObject.Find("Nav8").transform.position;
				GameObject.Find("Nav13").transform.position = GameObject.Find("Nav9").transform.position;
				GameObject.Find("Nav14").transform.position = GameObject.Find("Nav10").transform.position;
				GameObject.Find("Nav16").transform.position = GameObject.Find("Nav15").transform.position;
				((PlayerWindowController)(object)GameObject.Find("JumpOutWindow").GetComponent(typeof(PlayerWindowController))).camLadder = Anomaly36Camera;
				((PlayerWindowController)(object)GameObject.Find("JumpOutWindow").GetComponent(typeof(PlayerWindowController))).ClimbLadderAnim = Anomaly36Camera.GetComponent<Animation>();
				NewObjects.SetActive(false);
				Anomaly36NewObjects.SetActive(true);
				GameObject.Find("Water").SetActive(false);
				GameObject.Find("Del2Cellar").SetActive(false);
				GameObject.Find("Golv1").SetActive(false);
				GameObject.Find("OldHouseWalls").SetActive(false);
				GameObject.Find("TriggerSoundFadeOutToIn (1)").SetActive(false);
				GameObject.Find("TriggerSoundFadeInToOut (1)").SetActive(false);
				GameObject.Find("Skruvplatta").SetActive(false);
				GameObject.Find("AllHideTriggers").SetActive(false);
				GameObject.Find("FloorCollider").SetActive(false);
				GameObject.Find("StairColliderOldHouse").SetActive(false);
				GameObject.Find("StealDoor").SetActive(false);
				GameObject.Find("TrappaCollider").SetActive(false);
				GameObject.Find("Cowleg").SetActive(false);
				GameObject.Find("StortKugg").SetActive(false);
				GameObject.Find("HelpText").SetActive(false);
				GameObject.Find("HallFurniture/Collider (2)").SetActive(false);
				GameObject.Find("ActivatePlask").SetActive(false);
				GameObject.Find("SmallDoorParent/SmallDoor").tag = "Untagged";
				GameObject.Find("SmallDoorParent (1)/SmallDoor").tag = "Untagged";
				GameObject.Find("OuthouseDoor").tag = "Untagged";
				GameObject.Find("RemotelockCollider").tag = "Untagged";
				GameObject.Find("GallerHole").tag = "Untagged";
				GameObject.Find("KitchenDoor1Parent (3)/KitchenDoor").GetComponent<Renderer>().material.color = new Color(0f, 0.2f, 0f);
				GameObject.Find("KitchenDoor1Parent (3)/KitchenDoor").tag = "Untagged";
				((Object)GameObject.Find("KitchenDoor1Parent (3)/KitchenDoor")).name = "GreenKitchenDoor";
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/Furniture/GameObject"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent (1)"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorL"));
				Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorR"));
				((Component)playerCam).GetComponent<Camera>().useOcclusionCulling = false;
				TVTextMesh = TVText.GetComponent<TextMesh>();
			}
			if (AnomalyNR == 37)
			{
				AnomalyTV = "37";
				AnomalyText.GetComponent<Text>().text = "Anomaly 37:\r\n You have 1 day and if you see Granny, you die, but she is blind";
				((Component)playerCam).gameObject.AddComponent<Anomaly37SeeGranny>().Granny = Granny;
				((Component)playerCam).GetComponent<Anomaly37SeeGranny>().Player = Player;
			}
			if (AnomalyNR == 38)
			{
				AnomalyTV = "38";
				AnomalyText.GetComponent<Text>().text = "Anomaly 38:\r\nGranny moves 75% faster, but you slide on floor instead of walking";
			}
			if (AnomalyNR == 39)
			{
				AnomalyTV = "39";
				AnomalyText.GetComponent<Text>().text = "Anomaly 39:\r\nWhen you drop items, they randomly change their size";
			}
			if (AnomalyNR == 40)
			{
				AnomalyTV = "40";
				AnomalyText.GetComponent<Text>().text = "Anomaly 40:\r\n There are more creacking floors but everytime you step on creacking floor there is a 50% chance that it wouldn't creack";
				if (PlayerPrefs.GetInt("DiffData") == -1 || PlayerPrefs.GetInt("DiffData") == 1)
				{
					KnarrandeGolv.SetActive(true);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4)
				{
					KnarrandeGolvExtreme.SetActive(true);
					KnarrandeGolv.SetActive(false);
					GameObject.Find("HoleGaller").SetActive(false);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 3)
				{
					KnarrandeGolvExtreme.SetActive(true);
					KnarrandeGolv.SetActive(false);
					ExtraKnarr1 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(12.24f, 13.8f, -3.43f), Quaternion.Euler(0f, 0f, 0f));
					ExtraKnarr1.transform.SetParent((Transform)null);
					ExtraKnarr1.transform.localScale = new Vector3(1.33f, 0.84f, 2.630001f);
					ExtraKnarr2 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(30.96f, 12.29f, -8.7419f), Quaternion.Euler(0f, 90f, 0f));
					ExtraKnarr2.transform.localScale = new Vector3(0.31496745f, 0.84f, 6.67f);
					ExtraKnarr3 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (2)"), new Vector3(10.85f, 20.69f, -7.9f), Quaternion.identity);
					ExtraKnarr3.transform.localScale = new Vector3(6.9f, 0.84f, 2.07f);
					ExtraKnarr4 = Object.Instantiate<GameObject>(GameObject.Find("AllNoisePointsExtreme/KnarrPoints (4)"), new Vector3(6.81f, 27.41f, 12.87f), Quaternion.identity);
				}
				else if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.68f, 12.89f, -24.1051f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.885216f, 0.84f, 2.7631557f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-6.32f, 8.9f, -1.1582f), Quaternion.Euler(-34.32f, 0f, 0f)).transform.localScale = new Vector3(1.624414f, 1.0563002f, 1.1954908f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.7551f, 13.9077f, 6.09f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3950119f, 0.8652093f, 7.1391144f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-15.5729f, 20.9071f, 3.1251f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.2449087f, 1.446078f, 10.080566f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(-0.63f, 20.78f, 0.46f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(3.57f, 0.7f, 2.03f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(0.3756f, 20.7f, -4.7428f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.0658054f, 1.03163f, 1.0545235f);
					Object.Instantiate<GameObject>(ExtraKnarr2, new Vector3(10.392f, 12.4123f, -20.374f), Quaternion.Euler(0f, 68.989f, 0f)).transform.localScale = new Vector3(3.2058403f, 1.0563f, 1.0545235f);
				}
			}
			Scene activeScene;
			if (AnomalyNR == 41)
			{
				AnomalyTV = "41";
				AnomalyText.GetComponent<Text>().text = "Anomaly 41:\r\n The house is mirrored";
				PlayerPrefs.SetInt("Anomaly41Ending", 1);
				activeScene = SceneManager.GetActiveScene();
				GameObject[] rootGameObjects = activeScene.GetRootGameObjects();
				for (int j = 0; j < rootGameObjects.Length; j++)
				{
					Camera[] componentsInChildren = rootGameObjects[j].GetComponentsInChildren<Camera>(true);
					foreach (Camera val2 in componentsInChildren)
					{
						if ((Object)(object)((Component)val2).gameObject.GetComponent<Anomaly41MirrorCamera>() == (Object)null && ((Object)((Component)val2).gameObject).name != "CNControlCamera")
						{
							((Component)val2).gameObject.AddComponent<Anomaly41MirrorCamera>();
						}
					}
				}
			}
			if (AnomalyNR == 42)
			{
				AnomalyTV = "42";
				AnomalyText.GetComponent<Text>().text = "Anomaly 42:\r\n Gravity is gone and items can make noice everywhere";
				Physics.gravity = new Vector3(0f, 0f, 0f);
			}
			if (AnomalyNR == 43)
			{
				AnomalyTV = "43";
				AnomalyText.GetComponent<Text>().text = "Anomaly 43:\r\n Floor creaks in different places";
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					GameObject.Find("HoleGaller").transform.SetParent((Transform)null);
				}
				KnarrandeGolvExtreme.SetActive(false);
				KnarrandeGolv.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					ExtraKnarr1.SetActive(false);
					ExtraKnarr2.SetActive(false);
					ExtraKnarr3.SetActive(false);
					ExtraKnarr4.SetActive(false);
				}
				if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 4)
				{
					Anomaly43CreackingFloors.SetActive(true);
				}
				if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
				{
					Anomaly43CreackingFloorsExtreme.SetActive(true);
				}
			}
			if (AnomalyNR == 44)
			{
				AnomalyTV = "44";
				AnomalyText.GetComponent<Text>().text = "Anomaly 44:\r\n Your hand's lenght is constantly changing";
			}
			if (AnomalyNR == 45)
			{
				AnomalyTV = "45";
				Anomaly45NewObjects.SetActive(true);
				AnomalyText.GetComponent<Text>().text = "Special Anomaly 45:\r\n Try to escape from the broken reality";
				PlayerPrefs.SetInt("Anomaly45Ending", 1);
				activeScene = SceneManager.GetActiveScene();
				GameObject[] rootGameObjects = activeScene.GetRootGameObjects();
				for (int j = 0; j < rootGameObjects.Length; j++)
				{
					MeshRenderer[] componentsInChildren2 = rootGameObjects[j].GetComponentsInChildren<MeshRenderer>(true);
					foreach (MeshRenderer obj in componentsInChildren2)
					{
						((Renderer)((Component)obj).GetComponent<MeshRenderer>()).material = new Material(Shader.Find("Legacy Shaders/Transparent/VertexLit"));
						((Renderer)((Component)obj).GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
					}
				}
			}
			if (AnomalyNR == 46)
			{
				AnomalyTV = "46";
				AnomalyText.GetComponent<Text>().text = "Anomaly 46:\r\n Your and Granny's field of view is constantly changing";
				Anomaly46FOV = 10f;
				activeScene = SceneManager.GetActiveScene();
				GameObject[] rootGameObjects = activeScene.GetRootGameObjects();
				for (int j = 0; j < rootGameObjects.Length; j++)
				{
					Camera[] componentsInChildren = rootGameObjects[j].GetComponentsInChildren<Camera>(true);
					foreach (Camera val3 in componentsInChildren)
					{
						if ((Object)(object)((Component)val3).GetComponent<Anomaly46CameraChange>() == (Object)null)
						{
							((Component)val3).gameObject.AddComponent<Anomaly46CameraChange>();
						}
					}
				}
			}
			if (AnomalyNR == 47)
			{
				AnomalyTV = "47";
				AnomalyText.GetComponent<Text>().text = "Anomaly 47:\r\n There are randomly placed dark holes to make you and Granny see less";
				Physics.IgnoreLayerCollision(0, 14);
				Physics.IgnoreLayerCollision(8, 14);
				Physics.IgnoreLayerCollision(12, 14);
				Physics.IgnoreLayerCollision(13, 14);
				ShadowSpheres.SetActive(true);
			}
			if (AnomalyNR == 50)
			{
				AnomalyTV = "50";
				AnomalyText.GetComponent<Text>().text = "Anomaly 50:\r\nGranny moves twice as fast, but you can crawl under tables and railings";
				GameObject.Find("HouseBakedReady/CellarFurniture/CellarFurniture/Collider").SetActive(false);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(9.668f, 20.68f, -3.07f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.48f, 1.0176516f, 5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-14.35f, 20.68f, -15.822f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.23f, 1.0176516f, 2.43f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-8.89f, 20.68f, 5.2f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.23f, 1.0176516f, 2.43f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-10.54f, 27.63f, -4.912f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3f, 1f, 2.8f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-5.285f, 34.14f, -5.211f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.98f, 1f, 2.26f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-18.997f, 14.018f, 13.121f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3f, 1f, 3.68f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(18.63f, 14.018f, 5.71f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(7.37f, 1.0176516f, 2.98f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(14.12f, 14.232f, -0.383f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.71f, 1f, 4.45f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(11.61f, 14.232f, -7.65f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(4.05f, 1.0176516f, 4.97f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(30.916f, 12.604f, -3.4f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 6.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(13.471f, 8.03f, -3.87f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 2.3f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-0.59f, 8.03f, 5.561f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(10.74f, 2.35f, 6.19f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-9.847f, 8.24f, -40.152f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-2.434f, 12.89f, -38f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(4.56f, 1f, 1.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(8.285f, 13.016f, -29.97f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.61f, 1f, 1.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (13)"), new Vector3(-6.73f, 13.016f, -18.517f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.61f, 1f, 1.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(9.668f, 20.68f, -3.07f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.48f, 1.0176516f, 5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-14.35f, 20.68f, -15.822f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.23f, 1.0176516f, 2.43f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-8.89f, 20.68f, 5.2f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(5.23f, 1.0176516f, 2.43f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-10.54f, 27.63f, -4.912f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3f, 1f, 2.8f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-5.285f, 34.14f, -5.211f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(0.98f, 1f, 2.26f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-18.997f, 14.018f, 13.121f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.3f, 1f, 3.68f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(18.63f, 14.018f, 5.71f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(7.37f, 1.0176516f, 2.98f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(14.12f, 14.232f, -0.383f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.71f, 1f, 4.45f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(11.61f, 14.232f, -7.65f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(4.05f, 1.0176516f, 4.97f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(30.916f, 12.604f, -3.4f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 6.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(13.471f, 8.03f, -3.87f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 2.3f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-0.59f, 8.03f, 5.561f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(10.74f, 2.35f, 6.19f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-9.847f, 8.24f, -40.152f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(1.67f, 1f, 7.85f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-2.434f, 12.89f, -38f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(4.56f, 1f, 1.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(8.285f, 13.016f, -29.97f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.61f, 1f, 1.5f);
				Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (22)"), new Vector3(-6.73f, 13.016f, -18.517f), Quaternion.Euler(0f, 90f, 0f)).transform.localScale = new Vector3(2.61f, 1f, 1.5f);
			}
			if (AnomalyNR == 91)
			{
				AnomalyTV = "1 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 1:\r\nBehold the REAL GABON rain!";
			}
			if (AnomalyNR == 92)
			{
				AnomalyTV = "2 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 2:\r\nWATA HEL IS THE DROP BUTOON?";
			}
			if (AnomalyNR == 93)
			{
				AnomalyTV = "3 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 3:\r\nHow normal people see the world";
				GameObject.Find("BlackScreenStartHolder").SetActive(true);
				GabonBlackScreen = Object.Instantiate<GameObject>(GameObject.Find("BlackScreenStartHolder"));
				GabonBlackScreen.transform.SetParent((Transform)null);
				RectTransform component = ((Component)GabonBlackScreen.transform.GetChild(0)).gameObject.GetComponent<RectTransform>();
				((Transform)component).localScale = ((Transform)component).localScale - new Vector3(0f, 0.5f, 0f);
				((Graphic)((Component)GabonBlackScreen.transform.GetChild(0)).gameObject.GetComponent<Image>()).color = Color.white;
				GameObject.Find("BlackScreenStartHolder").SetActive(false);
			}
			if (AnomalyNR == 94)
			{
				AnomalyTV = "4 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 4:\r\nYou have to eat 100 melons";
				GameObject.Find("ObjectResetPoint").transform.position = new Vector3(12.206209f, 17.61501f, 8.231323f);
			}
			if (AnomalyNR == 95)
			{
				AnomalyTV = "5 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 5:\r\nAdded grandpa and his shotgun and slingshot for Granny and slendrina and buck";
			}
			if (AnomalyNR == 96)
			{
				AnomalyTV = "6 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 6:\r\nGrannys speed is 1000f, but acceleration = 1f brooooooooooooooooooooooo what is she doin";
			}
			if (AnomalyNR == 97)
			{
				AnomalyTV = "7 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 7:\r\nLiterally, nothing happens";
			}
			if (AnomalyNR == 98)
			{
				AnomalyTV = "8 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 8:\r\nHECKER";
			}
			if (AnomalyNR == 100)
			{
				AnomalyTV = "10 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 10:\r\nI need my sauce..";
				Legendaa = Object.Instantiate<GameObject>(GameObject.Find("Ammo (2)"), Granny.transform);
				Legendaa.transform.localPosition = new Vector3(0f, 2.51f, 0f);
				Legendaa.transform.localRotation = Quaternion.Euler(-90f, 0f, 22.5f);
				Legendaa.transform.localScale = new Vector3(0.28f, 0.36f, 0.23f);
				((Collider)Legendaa.GetComponent<BoxCollider>()).enabled = false;
				((Renderer)Legendaa.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR").GetComponent<MeshRenderer>()).material.mainTexture;
			}
			if (AnomalyNR == 101)
			{
				AnomalyTV = "11 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 11:\r\nOh no! Melon said Buck is more skilled than Bob, while being in the sewer. You need to jail this shameless criminal!";
			}
			if (AnomalyNR == 102)
			{
				AnomalyTV = "12 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 12:\r\n Drop button is done";
			}
			if (AnomalyNR == 103)
			{
				AnomalyTV = "103";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 13:\r\n Cowleg.";
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
				Object.Instantiate<GameObject>(GameObject.Find("Cowleg"), new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			}
			if (AnomalyNR == 104)
			{
				AnomalyTV = "14 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 14:\r\n Finally! I can play true randomize!!!\r\n\r\n(All items are true randomized in the moon)";
				GameObject.Find("UsefulObjects").SetActive(false);
				GameObject.Find("Ammo_Garage").SetActive(false);
			}
			if (AnomalyNR == 105)
			{
				AnomalyTV = "15 Gabon";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 15:\r\n Vasya Papkin.";
				tavla.SetActive(true);
				Legendaa = Object.Instantiate<GameObject>(GameObject.Find("Tavelram"), Granny.transform);
				Legendaa.transform.position = new Vector3(1.232f, 11.586f, 0.612f);
				Legendaa.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
				Legendaa.transform.localScale = new Vector3(0.01218994f, 0.01218994f, 0.012189941f);
				((Collider)Legendaa.GetComponent<BoxCollider>()).enabled = false;
				Object.Destroy((Object)(object)Legendaa.GetComponent<Rigidbody>());
				tavla.SetActive(false);
			}
			if (AnomalyNR == 106)
			{
				AnomalyTV = "106";
				AnomalyText.GetComponent<Text>().text = "Secret Gabon Anomaly 106:\r\n Finally! A colaboraion with Standoff 2! STANDOFCHEK";
				PlayerPrefs.SetInt("GabonAnomaly16Ending", 1);
				activeScene = SceneManager.GetActiveScene();
				GameObject[] rootGameObjects = activeScene.GetRootGameObjects();
				for (int j = 0; j < rootGameObjects.Length; j++)
				{
					MeshRenderer[] componentsInChildren2 = rootGameObjects[j].GetComponentsInChildren<MeshRenderer>(true);
					foreach (MeshRenderer val4 in componentsInChildren2)
					{
						if (((Component)val4).gameObject.layer != 12)
						{
							((Renderer)((Component)val4).GetComponent<MeshRenderer>()).material.mainTexture = STANDOFCHEK;
						}
					}
				}
			}
			if (AnomalyNR == 1305)
			{
				AnomalyText.GetComponent<Text>().text = "Redirecting to Nightmare Event...";
			}
		}
		else
		{
			AnomalyTV = "No";
		}
		saveSensitivityData val5 = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		if (PlayerPrefs.GetInt("slideData") == 0)
		{
			val5.sliderValue = 150f;
		}
		else
		{
			val5.sliderValue = PlayerPrefs.GetInt("slideData");
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			AnomalyText.GetComponent<Text>().text = "";
			PictureItem.SetActive(false);
			rats.SetActive(true);
			EventBooks = 0;
			Rat1 = GameObject.Find("Rat1");
			Rat2 = GameObject.Find("Rat2");
			Rat3 = Object.Instantiate<GameObject>(GameObject.Find("Rat1"), new Vector3(5.34f, 13.349f, -7.367f), Quaternion.identity);
			Rat4 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(-6.2f, 17.45f, -19.58f), Quaternion.identity);
			Rat5 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(18.47f, 20.1f, -11.077f), Quaternion.identity);
			Rat6 = Object.Instantiate<GameObject>(GameObject.Find("Rat1"), new Vector3(5.34f, 13.349f, -7.367f), Quaternion.identity);
			Rat7 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(-6.2f, 17.45f, -19.58f), Quaternion.identity);
			Rat8 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(18.47f, 20.1f, -11.077f), Quaternion.identity);
			Rat9 = Object.Instantiate<GameObject>(GameObject.Find("Rat1"), new Vector3(5.34f, 13.349f, -7.367f), Quaternion.identity);
			Rat10 = Object.Instantiate<GameObject>(GameObject.Find("Rat2"), new Vector3(-6.2f, 17.45f, -19.58f), Quaternion.identity);
			Rat1.SetActive(false);
			Rat2.SetActive(false);
			Rat3.SetActive(false);
			Rat4.SetActive(false);
			Rat5.SetActive(false);
			Rat6.SetActive(false);
			Rat7.SetActive(false);
			Rat8.SetActive(false);
			Rat9.SetActive(false);
			Rat10.SetActive(false);
			gameController.GetComponent<InventoryController>().Event2BookSpawn();
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").transform.position = new Vector3(-2.4f, -1014.317f, -36f);
			GameObject.Find("UsefulObjects").transform.position = new Vector3(-2.4f, -1014.317f, -36f);
			UseButton = ((Component)GameObject.Find("Pepperspray/RemoteButtonParent").transform.GetChild(1)).gameObject;
			((Behaviour)UseButton.GetComponent<Image>()).enabled = false;
			UseButton.SetActive(true);
			HintText = DefaultControls.CreateText(c);
			HintText.transform.SetParent(UseButton.transform);
			((Graphic)HintText.GetComponent<Text>()).color = Color.white;
			HintText.GetComponent<Text>().resizeTextForBestFit = true;
			HintText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			HintText.GetComponent<Text>().fontSize = 0;
			HintText.GetComponent<Text>().text = "(LMB) = Get a hint (3/3)";
			HintText.GetComponent<Text>().resizeTextMaxSize = 25;
			HintText.GetComponent<Text>().alignment = (TextAnchor)4;
			HintText.GetComponent<RectTransform>().sizeDelta = new Vector2(956f, 30f);
			HintText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			HintText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			HintText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
			EventCommentText = DefaultControls.CreateText(c);
			EventCommentText.transform.SetParent(GameObject.Find("AllaTexter").transform);
			EventCommentText.GetComponent<Text>().text = "";
			((Graphic)EventCommentText.GetComponent<Text>()).color = Color.white;
			EventCommentText.GetComponent<Text>().fontStyle = (FontStyle)2;
			EventCommentText.GetComponent<Text>().alignment = (TextAnchor)4;
			EventCommentText.GetComponent<Text>().resizeTextForBestFit = true;
			EventCommentText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EventCommentText.GetComponent<Text>().fontSize = 0;
			EventCommentText.GetComponent<Text>().resizeTextMaxSize = 50;
			EventCommentText.GetComponent<RectTransform>().sizeDelta = new Vector2(556f, 30f);
			EventCommentText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			EventCommentText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			EventCommentText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 90f);
			EventChallenge3Text = DefaultControls.CreateText(c);
			EventChallenge3Text.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 0/8";
			((Graphic)EventChallenge3Text.GetComponent<Text>()).color = Color.white;
			EventChallenge3Text.GetComponent<Text>().alignment = (TextAnchor)1;
			EventChallenge3Text.GetComponent<Text>().resizeTextForBestFit = true;
			EventChallenge3Text.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EventChallenge3Text.GetComponent<Text>().fontSize = 0;
			EventChallenge3Text.GetComponent<Text>().resizeTextMaxSize = 50;
			EventChallenge3Text.GetComponent<RectTransform>().sizeDelta = new Vector2(356f, 30f);
			EventChallenge3Text.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 1f);
			EventChallenge3Text.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 1f);
			EventChallenge3Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -10f);
			LightsOutMaxValue = 8;
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			AnomalyText.GetComponent<Text>().text = "";
			GameObject.Find("ObjectResetPoint").transform.position = new Vector3(12.206209f, 17.61501f, 8.231323f);
			PictureItem.SetActive(false);
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/BastuSwitch_Bom (1)").SetActive(false);
			GameObject.Find("UsefulObjects").transform.position = new Vector3(-2.4f, -1014.317f, -36f);
			((shootSpiderButton)(object)GameObject.Find("ShootButton").GetComponent(typeof(shootSpiderButton))).closeSpiderlucka();
			((Object)Object.Instantiate<GameObject>(((Component)KnarrandeGolv.transform.GetChild(0)).gameObject, new Vector3(100f, 100f, 100f), Quaternion.identity)).name = "Noise16Anomaly";
			EventChallenge3Text = DefaultControls.CreateText(c);
			EventChallenge3Text.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
			EventChallenge3Text.GetComponent<Text>().text = "";
			((Graphic)EventChallenge3Text.GetComponent<Text>()).color = Color.green;
			EventChallenge3Text.GetComponent<Text>().alignment = (TextAnchor)1;
			EventChallenge3Text.GetComponent<Text>().resizeTextForBestFit = true;
			EventChallenge3Text.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EventChallenge3Text.GetComponent<Text>().fontSize = 0;
			EventChallenge3Text.GetComponent<Text>().resizeTextMaxSize = 50;
			EventChallenge3Text.GetComponent<RectTransform>().sizeDelta = new Vector2(356f, 30f);
			EventChallenge3Text.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 1f);
			EventChallenge3Text.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 1f);
			EventChallenge3Text.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -10f);
			Anomaly19Button = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), new Vector3(10.847f, 16.017f, 4.8f), Quaternion.Euler(90f, 0f, 0f));
			Anomaly19Button.transform.SetParent((Transform)null);
			Anomaly19Button.transform.localScale = new Vector3(0.49f, 0.49f, 0.49f);
			Anomaly19Button.AddComponent<BoxCollider>();
			Anomaly19Button.AddComponent<Event3GamblingButton>().GamblingMode = 4;
			((Object)Anomaly19Button).name = "GamblingButtonUnavailable";
			GamblingButton3 = Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(10.847f, 16.017f, 5.3f), Quaternion.Euler(90f, 0f, 0f));
			GamblingButton3.GetComponent<Event3GamblingButton>().GamblingMode = 3;
			GamblingButton2 = Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(10.847f, 16.017f, 5.8f), Quaternion.Euler(90f, 0f, 0f));
			GamblingButton2.GetComponent<Event3GamblingButton>().GamblingMode = 2;
			GamblingButton1 = Object.Instantiate<GameObject>(Anomaly19Button, new Vector3(10.847f, 16.017f, 6.3f), Quaternion.Euler(90f, 0f, 0f));
			GamblingButton1.GetComponent<Event3GamblingButton>().GamblingMode = 1;
		}
		if (PlayerPrefs.GetInt("randomNR") == 100 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			PlayerPrefs.SetInt("randomNR", Random.Range(1, 10));
			saveRandomNR = true;
		}
		if (PlayerPrefs.GetInt("randomNR") == 99 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			PlayerPrefs.SetInt("PresetInOrder", PlayerPrefs.GetInt("PresetInOrder") + 1);
			if (PlayerPrefs.GetInt("PresetInOrder") == 10)
			{
				PlayerPrefs.SetInt("PresetInOrder", 1);
			}
			PlayerPrefs.SetInt("randomNR", PlayerPrefs.GetInt("PresetInOrder"));
			saveInOrder = true;
		}
		if (PlayerPrefs.GetInt("randomNR") == 1 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.position = new Vector3(34.43f, 23.96f, -10.33f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.rotation = Quaternion.Euler(39f, -167f, -80f);
			GameObject.Find("UsefulObjects/RandomPlace1/Meat_PL1").transform.position = new Vector3(33.4f, 21.067f, 9.7f);
			GameObject.Find("UsefulObjects/RandomPlace1/MelonPickUpPL1").transform.position = new Vector3(17.77f, 13.78f, 8.44f);
			PictureItem.transform.position = new Vector3(-2.68f, 14.45f, -1.14f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 180f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 4;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 5;
			}
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				randomTask2 = 3;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 6;
			}
			GameObject.Find("UsefulObjects/RandomPlace1/BirdSeedBoxPL1").transform.position = new Vector3(3.198f, 19.26f, -17.419f);
			GameObject.Find("UsefulObjects/RandomPlace1/HanglockKeyPL1").transform.position = new Vector3(-14.452f, 23.1741f, -0.746f);
			GameObject.Find("UsefulObjects/RandomPlace1/HanglockKeyPL1").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/HanglockKeyPL1").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.position = new Vector3(-15.42f, 14.32f, -3.48f);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(0f, 316f, 270f);
			PresetTV = "1";
			GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(8.017f, 15.018f, -39.98f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -43.6f);
			GameObject.Find("HouseKeyPL1").transform.localScale = new Vector3(0.004036642f, 0.004884825f, 0.003686334f);
			GameObject.Find("BirdSeedBoxPL1").transform.position = new Vector3(7.174f, 7.791f, 0.558f);
			GameObject.Find("CarkeyPL1").transform.position = new Vector3(18.373f, 16.09f, 1.986f);
			GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(-17.948f, 15.153f, 13.43f);
			GameObject.Find("Kugg2ObjectPL1").transform.SetParent(GameObject.Find("LodaParent (1)").transform.GetChild(0));
			GameObject.Find("RemoteControl_PL1").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("RemoteControl_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, -46.91f);
			GameObject.Find("RemoteControl_PL1").AddComponent<Rigidbody>();
			GameObject.Find("RemoteControl_PL1").transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(0).SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL1").transform.position = new Vector3(33.57f, 11.8582f, -14.04f);
			GameObject.Find("playHouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -170f);
			GameObject.Find("playHouseKeyPL1").GetComponent<Rigidbody>().isKinematic = true;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP2.SetActive(true);
			OP2_2.SetActive(true);
			OP2_3.SetActive(true);
			OP2_4.SetActive(true);
			OP2_5.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace2/MelonPickUpPL2").transform.position = new Vector3(33.13f, 21.24f, 9.47f);
			GameObject.Find("UsefulObjects/RandomPlace2/MelonPickUpPL2").transform.rotation = Quaternion.Euler(180f, 90f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace2/CarBattery_PL2").transform.position = new Vector3(21.68f, 21.03f, -1.68f);
			GameObject.Find("UsefulObjects/RandomPlace2/HammerPL2").transform.position = new Vector3(-14.539f, 23.279f, -0.637f);
			GameObject.Find("UsefulObjects/RandomPlace2/HammerPL2").transform.rotation = Quaternion.Euler(0f, 90f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace2/HammerPL2").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			PictureItem.transform.position = new Vector3(-4.73f, 18.55f, -26.47f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 180f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 1;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 2;
			}
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				randomTask2 = 3;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 5;
			}
			GameObject.Find("UsefulObjects/RandomPlace2/BirdSeedBoxPL2").transform.position = new Vector3(2.765f, 9.494f, 5.158f);
			GameObject.Find("UsefulObjects/RandomPlace2/BirdSeedBoxPL2").transform.rotation = Quaternion.Euler(-90f, -42f, -23f);
			GameObject.Find("UsefulObjects/RandomPlace2/Shotgun3_PL2").transform.position = new Vector3(-15.557f, 15.711f, -2.2f);
			PresetTV = "2";
			GameObject.Find("CarBattery_PL2").transform.position = new Vector3(18.11f, 14.584f, 12.75f);
			GameObject.Find("RemoteControl_PL2").transform.position = new Vector3(34.514725f, 23.419281f, -9.911029f);
			GameObject.Find("AvbitarePL2").transform.position = new Vector3(2.2107248f, 20.47228f, -19.248028f);
			GameObject.Find("AvbitarePL2").transform.rotation = Quaternion.Euler(-90f, 0f, -40f);
			GameObject.Find("AvbitarePL2").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				GameObject.Find("SparkPlug_PL2").transform.SetParent((Transform)null);
				GameObject.Find("SparkPlug_PL2").transform.position = new Vector3(-10.23f, 9.327f, -39.32f);
				GameObject.Find("SparkPlug_PL2").transform.rotation = Quaternion.Euler(-180f, -38f, 180f);
			}
			else
			{
				GameObject.Find("HanglockKeyPL2").transform.position = new Vector3(-10.125f, 9.2967f, -39.267f);
				GameObject.Find("HanglockKeyPL2").transform.rotation = Quaternion.Euler(90f, 0f, 33f);
				GameObject.Find("HanglockKeyPL2").transform.localScale = new Vector3(0.003f, 0.003f, 0.003f);
				TableBug = GameObject.Find("LitetBordVR");
				TableBug.SetActive(false);
			}
			GameObject.Find("Meat_PL2").transform.position = new Vector3(-15.284f, 22.46f, -18.114f);
			GameObject.Find("Shotgun1_PL2").transform.position = new Vector3(18.297f, 16.1307f, 2.078f);
			if (AnomalyNR == 35)
			{
				GameObject.Find("CarkeyPL2").transform.position = new Vector3(9.07f, 21.83f, 11.99f);
			}
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP3.SetActive(true);
			OP3_2.SetActive(true);
			OP3_3.SetActive(true);
			OP3_4.SetActive(true);
			OP3_5.SetActive(true);
			OP3_6.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace3/VapennyckelPL3").transform.position = new Vector3(33.8f, 21.04f, 9.36f);
			GameObject.Find("UsefulObjects/RandomPlace3/Shotgun3_PL3").transform.position = new Vector3(33.66f, 24.09f, -10.52f);
			PictureItem.transform.position = new Vector3(10f, 23.6f, -2.2f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 0f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 5;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 6;
			}
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				randomTask2 = 2;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 4;
			}
			GameObject.Find("UsefulObjects/RandomPlace3/SpecialKey_PL3").transform.position = new Vector3(-14.503f, 23.27f, -0.671f);
			GameObject.Find("UsefulObjects/RandomPlace3/SpecialKey_PL3").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("UsefulObjects/RandomPlace3/SparkPlug_PL3").transform.position = new Vector3(7.867f, 15.055f, -39.927f);
			GameObject.Find("UsefulObjects/RandomPlace3/AvbitarePL3").transform.position = new Vector3(5.657f, 35.514f, 9.34f);
			GameObject.Find("UsefulObjects/RandomPlace3/SafeKeyPL3").transform.position = new Vector3(18.149f, 16.084f, 12.687f);
			GameObject.Find("UsefulObjects/RandomPlace3/SafeKeyPL3").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			PresetTV = "3";
			PictureItem.transform.position = new Vector3(-7.7f, 10.389f, -40.38f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 180f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace3/RemoteControl_PL3").transform.position = new Vector3(4.0863f, 3.3575f, -0.8f);
			GameObject.Find("UsefulObjects/RandomPlace3/RemoteControl_PL3").transform.rotation = Quaternion.Euler(0f, 0f, -27f);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP4.SetActive(true);
			OP4_2.SetActive(true);
			OP4_3.SetActive(true);
			OP4_4.SetActive(true);
			OP4_5.SetActive(true);
			OP4_6.SetActive(true);
			OP4_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace4/CarBattery_PL4").transform.position = new Vector3(33.24f, 21.04f, 9.54f);
			GameObject.Find("UsefulObjects/RandomPlace4/CarBattery_PL4").transform.rotation = Quaternion.Euler(-90f, 0f, -80.2f);
			PictureItem.transform.position = new Vector3(3.7f, 28.1f, 13.62f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 0f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 4;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 6;
			}
			randomTask2 = 1;
			GameObject.Find("UsefulObjects/RandomPlace4/HammerPL4").transform.position = new Vector3(5.668f, 35.537f, 9.079f);
			GameObject.Find("UsefulObjects/RandomPlace4/Meat_PL4").transform.position = new Vector3(9.624724f, 21.32428f, 12.356971f);
			GameObject.Find("UsefulObjects/RandomPlace4/HanglockKeyPL4").transform.position = new Vector3(-10.13f, 14.691f, -29.8f);
			PresetTV = "4";
			GameObject.Find("VapennyckelPl4").transform.SetParent((Transform)null);
			GameObject.Find("VapennyckelPl4").transform.position = new Vector3(33.789f, 23.422f, -5.879f);
			GameObject.Find("VapennyckelPl4").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("SafeKeyPL4").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("SafeKeyPL4").transform.localPosition = new Vector3(-0.455f, 0.609f, 0.18f);
			GameObject.Find("SafeKeyPL4").transform.localRotation = Quaternion.Euler(166.05f, -90f, -90f);
			GameObject.Find("SafeKeyPL4").transform.localScale = new Vector3(0.015302636f, 0.007665404f, 0.013956124f);
			GameObject.Find("HouseKeyPL4").transform.position = new Vector3(2.127f, 20.513f, -19.112f);
			GameObject.Find("HouseKeyPL4").transform.rotation = Quaternion.Euler(90f, 42f, 260f);
			GameObject.Find("HouseKeyPL4").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("HouseKeyPL4").transform.localScale = new Vector3(0.017039135f, 0.020723375f, 0.0077162883f);
			GameObject.Find("RemoteControl_PL4").transform.position = new Vector3(0.396f, 8.601f, -18.329f);
			GameObject.Find("RemoteControl_PL4").transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				GameObject.Find("SpecialKey_PL4").transform.position = new Vector3(4.186f, 16.2507f, -12.028f);
				GameObject.Find("SpecialKey_PL4").transform.rotation = Quaternion.Euler(-90f, 36f, 0f);
			}
			if (AnomalyNR == 35)
			{
				GameObject.Find("Meat_PL4").transform.localPosition = new Vector3(8.871f, 10.42f, 16.5f);
			}
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP5.SetActive(true);
			OP5_2.SetActive(true);
			OP5_3.SetActive(true);
			OP5_4.SetActive(true);
			OP5_5.SetActive(true);
			OP5_6.SetActive(true);
			OP5_7.SetActive(true);
			GameObject.Find("HouseBakedReady/Vind2_2/LodaParent (2)/Loda/AvbitarePL5").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL5").transform.position = new Vector3(32.8f, 21.1f, 9.71f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 3;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 4;
			}
			randomTask2 = 2;
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.position = new Vector3(33.789f, 23.422f, -5.879f);
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("BirdSeedBoxPL5").transform.position = new Vector3(16.085f, 17.217f, -0.344f);
			GameObject.Find("BirdSeedBoxPL5").transform.rotation = Quaternion.Euler(-90f, 0f, 39f);
			GameObject.Find("BirdSeedBoxPL5").transform.SetParent((Transform)null);
			GameObject.Find("UsefulObjects/RandomPlace5/SpecialKey_PL5").transform.position = new Vector3(-0.85f, 2.3641f, 0.15f);
			GameObject.Find("UsefulObjects/RandomPlace5/SpecialKey_PL5").transform.SetParent(GameObject.Find("HouseUpdate4Test11Garage").transform.Find("Car"));
			GameObject.Find("UsefulObjects/RandomPlace5/Bensindunk_PL5").transform.position = new Vector3(-9.94f, 14.73f, -29.76f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.position = new Vector3(-11.288f, 29.26f, -5.256f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.rotation = Quaternion.Euler(90f, 0f, -12.43f);
			PresetTV = "5";
			GameObject.Find("CarBattery_PL5").transform.position = new Vector3(-16.226274f, 30.19028f, 7.5119715f);
			GameObject.Find("CarBattery_PL5").transform.rotation = Quaternion.Euler(-90f, 0f, -46.25f);
			GameObject.Find("Kugg2ObjectPL5").transform.position = new Vector3(2.2107248f, 20.47228f, -19.248028f);
			GameObject.Find("Kugg2ObjectPL5").transform.rotation = Quaternion.Euler(-90f, 0f, -10f);
			GameObject.Find("Kugg2ObjectPL5").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("Shotgun3_PL5").transform.position = new Vector3(-5.795f, 19.187f, -16.127f);
			GameObject.Find("Shotgun3_PL5").transform.rotation = Quaternion.Euler(90f, 0f, 79f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				GameObject.Find("MelonPickUpPL5").transform.position = new Vector3(5.248f, 15.907f, 3.19f);
				GameObject.Find("MelonPickUpPL5").transform.rotation = Quaternion.Euler(180f, -36.5f, 0f);
				GameObject.Find("Shotgun2_PL5").transform.position = new Vector3(8.26f, 22.815f, -1.996f);
				GameObject.Find("Shotgun2_PL5").transform.rotation = Quaternion.Euler(-205.452f, 180f, 88.541f);
				GameObject.Find("Book_PL5").transform.position = new Vector3(17.942f, 13.562f, 8.21f);
				GameObject.Find("Book_PL5").transform.rotation = Quaternion.Euler(-90f, 0f, 180f);
			}
		}
		else if (PlayerPrefs.GetInt("randomNR") == 6 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace1/Kugg2ObjectPL1").transform.position = new Vector3(-14.586f, 23.183f, -0.618f);
			GameObject.Find("UsefulObjects/RandomPlace1/Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/Kugg2ObjectPL1").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.position = new Vector3(5.78f, 35.6f, 9.28f);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(90f, -90f, 180f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.position = new Vector3(-10f, 28.79f, -5.3f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.rotation = Quaternion.Euler(-180f, -90f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.SetParent((Transform)null);
			GameObject.Find("RemoteControl_PL1").transform.SetParent(GameObject.Find("Vind2_2/LodaParent (2)").transform.Find("Loda"));
			GameObject.Find("Vind2_2/LodaParent (3)/Loda/Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(-0.9f, 10.76f, -8.2f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/MelonPickUpPL1").transform.position = new Vector3(-5.844f, 19.374f, -16.07f);
			GameObject.Find("UsefulObjects/RandomPlace1/MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.position = new Vector3(30.46f, 5.64f, -23.14f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.rotation = Quaternion.Euler(39.014f, -104.141f, -80.18f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("UsefulObjects/RandomPlace1/SafeKeyPL1").transform.position = new Vector3(-15.16f, 15.04f, -3.57f);
			GameObject.Find("UsefulObjects/RandomPlace1/SafeKeyPL1").transform.rotation = Quaternion.Euler(-180f, -45f, -180f);
			GameObject.Find("UsefulObjects/RandomPlace1/SpecialKey_PL1").transform.position = new Vector3(6.923f, 7.874f, 1.101f);
			GameObject.Find("UsefulObjects/RandomPlace1/SpecialKey_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 73f);
			GameObject.Find("UsefulObjects/RandomPlace1/CarkeyPL1").transform.position = new Vector3(-6.734f, 9.286f, -39.528f);
			GameObject.Find("UsefulObjects/RandomPlace1/CarkeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("UsefulObjects/RandomPlace1/Book_PL1").transform.position = new Vector3(-2.3f, 14.3f, -40f);
			GameObject.Find("UsefulObjects/RandomPlace1/Book_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 140f);
			GameObject.Find("UsefulObjects/RandomPlace1/Meat_PL1").transform.position = new Vector3(8.026f, 15.048f, -40.054f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.position = new Vector3(-2.632f, 9.542f, 4.98f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.rotation = Quaternion.Euler(87.54f, 2.72f, -65f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.localScale = new Vector3(0.003046056f, 0.00370037f, 0.002786894f);
			GameObject.Find("UsefulObjects/RandomPlace1/Wrench_PL1").transform.SetParent((Transform)null);
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(-8.746f, 23.154f, -2.5f);
			GameObject.Find("Wrench_PL1").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (3)/ByroLoda").transform);
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(14.45f, 10.09f, -3.2f);
			GameObject.Find("UsefulObjects/RandomPlace1/BirdSeedBoxPL1").transform.position = new Vector3(34.465f, 23.414f, -10.582f);
			GameObject.Find("UsefulObjects/RandomPlace1/BirdSeedBoxPL1").transform.rotation = Quaternion.Euler(-104.4f, 0f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace1/CarBattery_PL1").transform.position = new Vector3(-10.21f, 14.688f, -29.5f);
			GameObject.Find("HouseUpdate4Test11Garage/Car/HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(6.9f, 13.51f, -22.06f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(0f, 67.5f, -90f);
			GameObject.Find("HouseKeyPL1").transform.localScale = new Vector3(0.002142245f, 0.002592376f, 0.001956337f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun1_PL1").transform.position = new Vector3(7.84f, 12.49f, -29.5f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun2_PL1").transform.position = new Vector3(18.36f, 14.64f, 12.86f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun2_PL1").transform.rotation = Quaternion.Euler(-90f, -180f, 56f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun3_PL1").transform.position = new Vector3(7.54f, 12.56f, -22.94f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent/ByroLoda/AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(-0.85f, 2.267f, 0.12f);
			GameObject.Find("AvbitarePL1").transform.SetParent(GameObject.Find("HouseUpdate4Test11Garage").transform.Find("Car"));
			GameObject.Find("GrannyHouse8Update/Loda2Parent (7)/ByroLoda/SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(17.48f, 13.63f, 3.37f);
			PictureItem.transform.position = new Vector3(2.45f, 2.71f, 6.3f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 0f, 0f);
			RandomIndex = Random.Range(1, 4);
			if (RandomIndex == 1)
			{
				RandomTask = 1;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 3;
			}
			if (RandomIndex == 3)
			{
				RandomTask = 4;
			}
			RandomIndex = Random.Range(1, 4);
			if (RandomIndex == 1)
			{
				randomTask2 = 2;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 5;
			}
			if (RandomIndex == 3)
			{
				randomTask2 = 6;
			}
			PresetTV = "6";
			if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				GameObject.Find("CarkeyPL1").transform.position = new Vector3(12.3f, 9.544f, -3.2f);
				GameObject.Find("CarkeyPL1").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL1").transform.position = new Vector3(-7.2002754f, 9.295279f, -40.06203f);
				GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(180f, -28f, 90f);
			}
			else
			{
				GameObject.Find("HammerPL1").transform.position = new Vector3(34.287f, 12.397f, -14.398f);
				GameObject.Find("CarkeyPL1").transform.position = new Vector3(-6.734f, 9.286f, -39.528f);
				GameObject.Find("CarkeyPL1").transform.SetParent((Transform)null);
			}
		}
		else if (PlayerPrefs.GetInt("randomNR") == 7 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP5.SetActive(true);
			OP5_2.SetActive(true);
			OP5_3.SetActive(true);
			OP5_4.SetActive(true);
			OP5_5.SetActive(true);
			OP5_6.SetActive(true);
			OP5_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace5/RemoteControl_PL5").transform.position = new Vector3(18f, 16.11f, 12.82f);
			GameObject.Find("UsefulObjects/RandomPlace5/Bensindunk_PL5").transform.position = new Vector3(-7.3f, 9.33f, -40.2f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.position = new Vector3(11.406f, 13.958f, 0.573f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.rotation = Quaternion.Euler(25.811f, 90f, -268.933f);
			GameObject.Find("UsefulObjects/RandomPlace5/CarBattery_PL5").transform.position = new Vector3(18.672f, 20.23f, 1.76f);
			GameObject.Find("UsefulObjects/RandomPlace5/Wrench_PL5").transform.position = new Vector3(5.25f, 15.7f, 3.21f);
			GameObject.Find("UsefulObjects/RandomPlace5/Meat_PL5").transform.position = new Vector3(-9.73f, 14.705f, -29.824f);
			GameObject.Find("UsefulObjects/RandomPlace5/SpecialKey_PL5").transform.position = new Vector3(-16.03f, 30.237f, 7.56f);
			GameObject.Find("UsefulObjects/RandomPlace5/Book_PL5").transform.position = new Vector3(0.549f, 7.752f, -36.596f);
			GameObject.Find("UsefulObjects/RandomPlace5/Shotgun3_PL5").transform.position = new Vector3(-17.739f, 15.112f, 0.211f);
			GameObject.Find("UsefulObjects/RandomPlace5/Shotgun2_PL5").transform.position = new Vector3(18.305f, 16.126f, 2.065f);
			GameObject.Find("UsefulObjects/RandomPlace5/Shotgun2_PL5").transform.rotation = Quaternion.Euler(90f, 90f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace5/SparkPlug_PL5").transform.position = new Vector3(0.39f, 8.578f, -18.291f);
			GameObject.Find("UsefulObjects/RandomPlace5/SparkPlug_PL5").transform.rotation = Quaternion.Euler(-70.71f, -131.942f, -62.83f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.position = new Vector3(12.45f, 23.18f, -12f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (4)").transform.Find("ByroLoda"));
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.position = new Vector3(4.02f, 3.38f, -0.76f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.rotation = Quaternion.Euler(36.923f, 90f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.SetParent(GameObject.Find("HouseUpdate4Test11Garage").transform.Find("Car"));
			GameObject.Find("UsefulObjects/RandomPlace5/MelonPickUpPL5").transform.position = new Vector3(-9.12f, 27.13f, -4.9f);
			GameObject.Find("UsefulObjects/RandomPlace5/MelonPickUpPL5").transform.rotation = Quaternion.Euler(0f, -38.4f, -90f);
			GameObject.Find("UsefulObjects/RandomPlace5/HouseKeyPL5").transform.position = new Vector3(6.8f, 7.81f, 0.84f);
			GameObject.Find("UsefulObjects/RandomPlace5/SafeKeyPL5").transform.position = new Vector3(5.662f, 35.525f, 9.242f);
			GameObject.Find("UsefulObjects/RandomPlace5/BrunnsVevPickupPL5").transform.position = new Vector3(33.1f, 21.14f, 10f);
			GameObject.Find("UsefulObjects/RandomPlace5/BrunnsVevPickupPL5").transform.rotation = Quaternion.Euler(171.777f, 38.586f, 90f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.position = new Vector3(30.622f, 5.1521f, -23.164f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.rotation = Quaternion.Euler(90f, -90f, 69.468f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL5").transform.position = new Vector3(-16.12f, 20.55f, 13.67f);
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL5").transform.SetParent((Transform)null);
			GameObject.Find("HouseBakedReady/Vind2_2/LodaParent (2)/Loda/AvbitarePL5").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL5").transform.position = new Vector3(33.64f, 23.44f, -5.87f);
			PictureItem.transform.position = new Vector3(-7.7f, 13.5f, -40.38f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 180f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 2;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 5;
			}
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				randomTask2 = 4;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 6;
			}
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.position = new Vector3(-6.024f, 20.92f, -17.461f);
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.rotation = Quaternion.Euler(349.1f, 78.101f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace5/playHouseKeyPL5").transform.position = new Vector3(-0.85f, 2.267f, 0.12f);
			GameObject.Find("BirdSeedBoxPL5").transform.position = new Vector3(-8.5f, 22.42f, 3.2f);
			GameObject.Find("BirdSeedBoxPL5").transform.rotation = Quaternion.Euler(-90f, 0f, 39f);
			GameObject.Find("BirdSeedBoxPL5").transform.SetParent((Transform)null);
			PresetTV = "7";
			GameObject.Find("BirdSeedBoxPL5").transform.position = new Vector3(5.853f, 22.968f, 11.071f);
			GameObject.Find("BirdSeedBoxPL5").transform.rotation = Quaternion.Euler(-90f, 0f, -39f);
			GameObject.Find("BirdSeedBoxPL5").AddComponent<Rigidbody>();
			GameObject.Find("HouseKeyPL5").transform.position = new Vector3(4.0734124f, 3.367815f, -0.8150506f);
			GameObject.Find("HouseKeyPL5").transform.rotation = Quaternion.Euler(17.803f, 90f, 0f);
			GameObject.Find("HouseKeyPL5").transform.SetParent(GameObject.Find("Car").transform);
			GameObject.Find("Shotgun1_PL5").transform.position = new Vector3(-16.279f, 30.316f, 7.208f);
			GameObject.Find("Shotgun1_PL5").transform.rotation = Quaternion.Euler(125f, 0f, -90f);
			GameObject.Find("Shotgun1_PL5").transform.SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL5").transform.position = new Vector3(-5.79f, 19.16f, -16.2f);
			GameObject.Find("Kugg1ObjectPL5").transform.position = new Vector3(0.401f, 8.6126f, -18.3545f);
			GameObject.Find("Kugg1ObjectPL5").transform.rotation = Quaternion.Euler(36.923f, 180f, 90f);
			GameObject.Find("Kugg1ObjectPL5").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL5").transform.position = new Vector3(-14.597f, 23.216f, -0.619f);
			GameObject.Find("SparkPlug_PL5").transform.rotation = Quaternion.Euler(0f, 118f, 0f);
			GameObject.Find("SparkPlug_PL5").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("Meat_PL5").transform.position = new Vector3(2.134f, 20.506f, -19.303f);
			GameObject.Find("Meat_PL5").transform.rotation = Quaternion.Euler(-90f, 0f, -118f);
			GameObject.Find("Meat_PL5").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("MelonPickUpPL5").transform.position = new Vector3(-10.154f, 14.881f, -29.893f);
			GameObject.Find("CarkeyPL5").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("CarkeyPL5").transform.rotation = Quaternion.Euler(0f, 47.563f, -266.17f);
			GameObject.Find("CarkeyPL5").AddComponent<Rigidbody>();
			GameObject.Find("CarkeyPL5").transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(4).SetParent((Transform)null);
			GameObject.Find("HanglockKeyPL5").transform.position = new Vector3(-11.534f, 29.1244f, -5.23f);
			GameObject.Find("HanglockKeyPL5").transform.rotation = Quaternion.Euler(-90f, 0f, -130f);
			GameObject.Find("CarBattery_PL5").transform.position = new Vector3(15.679f, 20.595f, 12.03f);
			GameObject.Find("Shotgun3_PL5").transform.position = new Vector3(-8.043f, 14.66f, 4.55f);
			GameObject.Find("Shotgun3_PL5").transform.rotation = Quaternion.Euler(-90f, -90f, 0f);
			GameObject.Find("Wrench_PL5").transform.position = new Vector3(6.86f, 7.79f, 0.86f);
			GameObject.Find("CarBattery_PL5").transform.position = new Vector3(-6.06f, 35.05f, -5.37f);
		}
		else if (PlayerPrefs.GetInt("randomNR") == 8 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(-8.093f, 16.192f, 3.896f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(90f, 0f, 30f);
			GameObject.Find("BrunnsVevPickupPL1").transform.position = new Vector3(-1f, 2.326f, 0.3f);
			GameObject.Find("BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(-2.207f, 31.41f, 86.07f);
			GameObject.Find("BrunnsVevPickupPL1").transform.SetParent(GameObject.Find("Car").transform);
			GameObject.Find("RemoteControl_PL1").transform.position = new Vector3(30.6159f, 5.1966f, -22.8177f);
			GameObject.Find("RemoteControl_PL1").transform.rotation = Quaternion.Euler(-56.35f, -13.192f, -90f);
			GameObject.Find("RemoteControl_PL1").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(31.347f, 14.24f, -2.986f);
			GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("MelonPickUpPL1").transform.position = new Vector3(5.775f, 35.7f, 9.29f);
			GameObject.Find("MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, -68f, 0f);
			GameObject.Find("Topplock_PL1").transform.position = new Vector3(33.223f, 21.175f, 9.544f);
			GameObject.Find("Topplock_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -22.5f);
			GameObject.Find("SafeKeyPL1").transform.position = new Vector3(2.098f, 20.464f, -19.256f);
			GameObject.Find("SafeKeyPL1").transform.rotation = Quaternion.Euler(0f, 63f, 0f);
			GameObject.Find("SafeKeyPL1").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("SpecialKey_PL1").transform.position = new Vector3(0.39736894f, 8.5683f, -18.316507f);
			GameObject.Find("SpecialKey_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
			GameObject.Find("CarkeyPL1").transform.position = new Vector3(6.8703f, 13.5045f, -22.0546f);
			GameObject.Find("CarkeyPL1").transform.rotation = Quaternion.Euler(-13.907f, 257.212f, -46.637f);
			GameObject.Find("CarkeyPL1").transform.localScale = new Vector3(0.0029f, 0.0029f, 0.0029f);
			GameObject.Find("Book_PL1").transform.position = new Vector3(33.647f, 23.399f, -5.9f);
			GameObject.Find("Book_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 180f);
			GameObject.Find("Meat_PL1").transform.position = new Vector3(-3.8f, 19.427f, -15.122f);
			GameObject.Find("Meat_PL1").transform.rotation = Quaternion.Euler(-150f, 0f, 90f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(18.353447f, 16.088f, 2.023007f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 78f);
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(8.402f, 12.902f, -34.799f);
			GameObject.Find("Wrench_PL1").transform.rotation = Quaternion.Euler(-21.037f, -87.9f, 84.168f);
			GameObject.Find("HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(-9.22657f, 36.11f, -2.141078f);
			GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(-67.1f, -129.108f, 90f);
			GameObject.Find("BirdSeedBoxPL1").transform.position = new Vector3(-10f, 14.68f, -29.7f);
			GameObject.Find("BirdSeedBoxPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -46f);
			GameObject.Find("CarBattery_PL1").transform.position = new Vector3(34.04f, 17.380262f, -3.14f);
			GameObject.Find("CarBattery_PL1").transform.rotation = Quaternion.Euler(-90f, -57.29f, 0f);
			GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(-10.072f, 28.773855f, -5.234f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 23.503f);
			GameObject.Find("HouseKeyPL1").transform.SetParent(GameObject.Find("LodaParent (2)/Loda").transform);
			GameObject.Find("Shotgun1_PL1").transform.position = new Vector3(6.58f, 23.39f, 8.198f);
			GameObject.Find("Shotgun1_PL1").transform.rotation = Quaternion.Euler(90f, 0f, 63f);
			GameObject.Find("Shotgun2_PL1").transform.position = new Vector3(-23.21f, 20.47f, -1.85f);
			GameObject.Find("Shotgun2_PL1").transform.rotation = Quaternion.Euler(-20.166f, 0f, -90f);
			GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(-7.2f, 14.235f, -19.04f);
			GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -34.071f);
			GameObject.Find("AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(-6.128f, 9.283f, -40.213f);
			GameObject.Find("AvbitarePL1").transform.rotation = Quaternion.Euler(-90f, 0f, 35f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(-10.1f, 23.19f, -2.45f);
			GameObject.Find("SparkPlug_PL1").transform.rotation = Quaternion.Euler(-180f, -136f, 180f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent(GameObject.Find("Loda2Parent (2)/ByroLoda").transform);
			GameObject.Find("HanglockKeyPL1").transform.position = new Vector3(8.0184f, 15.0127f, -40.06069f);
			GameObject.Find("HanglockKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -30f);
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(0).SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL1").transform.position = new Vector3(-14.5f, 23.1552f, -0.78f);
			GameObject.Find("playHouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -170f);
			Object.Destroy((Object)(object)GameObject.Find("playHouseKeyPL1").GetComponent<Rigidbody>());
			GameObject.Find("playHouseKeyPL1").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("Bensindunk_PL1").transform.position = new Vector3(1.894f, 17.98f, -19.6f);
			GameObject.Find("Bensindunk_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
			PictureItem.transform.position = new Vector3(-8.652f, 28.046f, 13.624f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 0f, 0f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(-14.951f, 24.8f, -7.391f);
				GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(20.6f, -90f, -90f);
			}
			RandomIndex = Random.Range(1, 4);
			if (RandomIndex == 1)
			{
				RandomTask = 6;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 3;
			}
			if (RandomIndex == 3)
			{
				RandomTask = 5;
			}
			randomTask2 = 1;
			PresetTV = "8";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 9 && AnomalyNR != 13 && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && AnomalyNR != 101 && AnomalyNR != 104 && PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(33.39f, 21.0377f, 9.802f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(-90f, 180f, 180f);
			GameObject.Find("BrunnsVevPickupPL1").transform.position = new Vector3(-14.7447f, 23.242f, -0.571f);
			GameObject.Find("BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(0f, -137.5f, -90f);
			GameObject.Find("BrunnsVevPickupPL1").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("RemoteControl_PL1").transform.position = new Vector3(-1.1f, 2.272f, 0.23f);
			GameObject.Find("RemoteControl_PL1").transform.rotation = Quaternion.Euler(0f, 402f, -90f);
			GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(-7.750528f, 30.495f, 13.893f);
			GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(30.6f, 0f, 0f);
			GameObject.Find("Topplock_PL1").transform.position = new Vector3(17.773f, 14.097f, 2.837f);
			GameObject.Find("Topplock_PL1").transform.rotation = Quaternion.Euler(141f, 13f, 100f);
			GameObject.Find("SafeKeyPL1").transform.position = new Vector3(8.03f, 15f, -40f);
			GameObject.Find("SafeKeyPL1").transform.rotation = Quaternion.Euler(0f, 47f, 0f);
			GameObject.Find("SpecialKey_PL1").transform.position = new Vector3(2.1193f, 20.588f, -19.353f);
			GameObject.Find("SpecialKey_PL1").transform.rotation = Quaternion.Euler(0f, -131f, 0f);
			GameObject.Find("SpecialKey_PL1").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("CarkeyPL1").transform.position = new Vector3(-4.901f, 19.16f, -15.242f);
			GameObject.Find("CarkeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -16.08f);
			GameObject.Find("Book_PL1").transform.position = new Vector3(5.815f, 16.057f, 3.27f);
			GameObject.Find("Meat_PL1").transform.position = new Vector3(12.17f, 16.025f, 0.78f);
			GameObject.Find("Meat_PL1").transform.rotation = Quaternion.Euler(-90f, -54.4f, 0f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -46.91f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(0f, 47.563f, -266.17f);
			GameObject.Find("VapennyckelPL1").GetComponent<BoxCollider>().size = new Vector3(218.2f, 117.4f, 26f);
			GameObject.Find("VapennyckelPL1").AddComponent<Rigidbody>();
			GameObject.Find("VapennyckelPL1").transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(-10.085f, 14.6791f, -29.792f);
			GameObject.Find("Wrench_PL1").transform.rotation = Quaternion.Euler(-90f, -14.5f, 0f);
			GameObject.Find("HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(7.595f, 8.338f, 0.774f);
			GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(-246.18f, 90f, 278.742f);
			GameObject.Find("BirdSeedBoxPL1").transform.position = new Vector3(-6.3f, 9.284f, -39.6f);
			GameObject.Find("BirdSeedBoxPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -52f);
			GameObject.Find("CarBattery_PL1").transform.localPosition = new Vector3(-27.267f, 8.67f, 7.086f);
			GameObject.Find("CarBattery_PL1").transform.localRotation = Quaternion.Euler(-90f, 0f, -140.5f);
			GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(30.888f, 5.285f, -23.097f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(39.532f, 90f, -90f);
			GameObject.Find("HouseKeyPL1").transform.SetParent(GameObject.Find("BrunnsHink").transform);
			GameObject.Find("Shotgun1_PL1").transform.position = new Vector3(33.707f, 11.9f, -13.975f);
			GameObject.Find("Shotgun1_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -70f);
			GameObject.Find("Shotgun2_PL1").transform.position = new Vector3(11.53f, 27.295f, 3.638f);
			GameObject.Find("Shotgun2_PL1").transform.rotation = Quaternion.Euler(-160f, 170f, 90f);
			GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(15.964f, 20.138f, -0.986f);
			GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(90f, 0f, 16.5f);
			GameObject.Find("AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(18.03f, 16.084f, 12.8f);
			GameObject.Find("AvbitarePL1").transform.rotation = Quaternion.Euler(-90f, 0f, -40f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(-10.1f, 28.81f, -5.3f);
			GameObject.Find("SparkPlug_PL1").transform.rotation = Quaternion.Euler(-180f, -136f, 180f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent(GameObject.Find("LodaParent (2)/Loda").transform);
			GameObject.Find("HanglockKeyPL1").transform.position = new Vector3(-7.6346684f, 14.223713f, -19.585274f);
			GameObject.Find("HanglockKeyPL1").transform.rotation = Quaternion.Euler(90f, -180f, -137.3f);
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(0).SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL1").transform.position = new Vector3(18.375f, 16.085f, 2.016f);
			GameObject.Find("playHouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 140f);
			((Component)GameObject.Find("playHouseKeyPL1").transform.GetChild(0)).gameObject.SetActive(false);
			Object.Destroy((Object)(object)GameObject.Find("playHouseKeyPL1").GetComponent<Rigidbody>());
			GameObject.Find("Bensindunk_PL1").transform.position = new Vector3(-16.189f, 30.191f, 7.525f);
			GameObject.Find("Bensindunk_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 33.908f);
			((Component)GameObject.Find("Bensindunk_PL1").transform.GetChild(0)).gameObject.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				GameObject.Find("MelonPickUpPL1").transform.position = new Vector3(-8f, 14.83f, 4.1f);
				GameObject.Find("MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, 28f, 0f);
				GameObject.Find("Shotgun3_PL1").transform.localPosition = new Vector3(-3.67f, 2.883f, -34.57f);
				GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(9.55f, 21.26f, 12.3f);
				GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(-90f, 120f, 0f);
			}
			else
			{
				GameObject.Find("MelonPickUpPL1").transform.position = new Vector3(5.844f, 23.285f, 11.111f);
				GameObject.Find("MelonPickUpPL1").transform.rotation = Quaternion.Euler(106.59f, 90f, 0f);
				((Collider)GameObject.Find("MelonPickUpPL1").GetComponent<CapsuleCollider>()).enabled = false;
				GameObject.Find("MelonPickUpPL1").AddComponent<MeshCollider>().convex = true;
				GameObject.Find("MelonPickUpPL1").AddComponent<Rigidbody>();
			}
			if (AnomalyNR == 35)
			{
				GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(13.03f, 22.13f, 11.21f);
			}
			PictureItem.transform.position = new Vector3(-15.85f, 21.35f, -4.82f);
			PictureItem.transform.rotation = Quaternion.Euler(14.957f, 90f, 0f);
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				RandomTask = 2;
			}
			if (RandomIndex == 2)
			{
				RandomTask = 3;
			}
			RandomIndex = Random.Range(1, 3);
			if (RandomIndex == 1)
			{
				randomTask2 = 4;
			}
			if (RandomIndex == 2)
			{
				randomTask2 = 5;
			}
			PresetTV = "9";
		}
		if (daysCounter == 0f)
		{
			daysCounter = 1f;
		}
		if (PlayerPrefs.GetInt("fogOnExtreme") == 1 || AnomalyNR == 2 || AnomalyNR == 20 || AnomalyNR == 36 || PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			RenderSettings.fog = true;
			if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				RenderSettings.fogColor = Color.white;
				RenderSettings.skybox.color = Color.white;
			}
			if (AnomalyNR == 2)
			{
				RenderSettings.fogMode = (FogMode)1;
				RenderSettings.fogStartDistance /= 2.15f;
				RenderSettings.fogEndDistance /= 2.15f;
			}
			if (PrimeAnomalyNR == 2)
			{
				RenderSettings.fogMode = (FogMode)1;
				RenderSettings.fogStartDistance /= 2.8f;
				RenderSettings.fogEndDistance /= 2.8f;
			}
			if (AnomalyNR == 20)
			{
				RenderSettings.fogMode = (FogMode)1;
				RenderSettings.fogEndDistance = 4.7f;
			}
			if (AnomalyNR == 36)
			{
				RenderSettings.fogMode = (FogMode)1;
				RenderSettings.fogStartDistance = 1f;
				RenderSettings.fogEndDistance = 20f;
			}
			if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
			{
				RenderSettings.fog = true;
				RenderSettings.fogStartDistance /= 3.6f;
				RenderSettings.fogEndDistance /= 3.6f;
				RenderSettings.fogColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
				((Component)playerCam).GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
				((Component)GameObject.Find("CamOutdoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
				((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
			}
		}
		else if (PlayerPrefs.GetInt("fogOnOff") == 1)
		{
			RenderSettings.fog = true;
		}
		else if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			RenderSettings.fog = true;
			EventFogStart = RenderSettings.fogStartDistance;
			EventFogEnd = RenderSettings.fogEndDistance;
			RenderSettings.fogStartDistance *= 4f;
			RenderSettings.fogEndDistance *= 4f;
		}
		else
		{
			RenderSettings.fog = false;
		}
		if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			MoreSpiderwebs.SetActive(true);
			if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				AbondonedRats.SetActive(true);
			}
			if (AnomalyNR != 36)
			{
				RenderSettings.fog = true;
				RenderSettings.fogColor = Color.black;
				RenderSettings.fogStartDistance = 5f;
				RenderSettings.fogEndDistance = 10f;
				if (AnomalyNR == 2)
				{
					RenderSettings.fogMode = (FogMode)1;
					RenderSettings.fogStartDistance = 3.34f;
					RenderSettings.fogEndDistance = 6.46f;
				}
				if (PrimeAnomalyNR == 2)
				{
					RenderSettings.fogMode = (FogMode)1;
					RenderSettings.fogStartDistance = 2.57f;
					RenderSettings.fogEndDistance = 4.96f;
				}
				if (AnomalyNR == 20)
				{
					RenderSettings.fogMode = (FogMode)1;
					RenderSettings.fogEndDistance = 4.7f;
				}
				((Renderer)GameObject.Find("HouseNy").GetComponent<MeshRenderer>()).materials[1].color = new Color(0.75f, 0.6f, 0.3f);
				((Renderer)GameObject.Find("Water").GetComponent<MeshRenderer>()).material.color = new Color(0.25f, 0.2f, 0.1f, 0.3f);
				((Renderer)GameObject.Find("Water2").GetComponent<MeshRenderer>()).material.color = new Color(0.25f, 0.2f, 0.1f, 0.3f);
				((Component)GameObject.Find("CamOutdoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = Color.black;
				((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = Color.black;
				((Component)playerCam).GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
			}
		}
		if (AnomalyNR == 30)
		{
			RenderSettings.fog = false;
		}
		yield return (object)new WaitForSeconds(5f);
		if (PrimeAnomalyNR != 18)
		{
			newPictureItem = Object.Instantiate<GameObject>(PictureItem, new Vector3(28.85f, -532.4f, 4.68f), Quaternion.identity);
			newPictureItem.GetComponent<Rigidbody>().isKinematic = false;
			AudioClip objectLjud = ((Component)newPictureItem.transform.GetChild(0)).GetComponent<objectFallFloor>().ObjectLjud;
			((Behaviour)((Component)newPictureItem.transform.GetChild(0)).GetComponent<objectFallFloor>()).enabled = false;
			((Component)newPictureItem.transform.GetChild(0)).gameObject.AddComponent<HandObjectFalls>();
			((Component)newPictureItem.transform.GetChild(0)).GetComponent<HandObjectFalls>().Granny = ((Component)((Component)gameController.GetComponent<InventoryController>().newbattery).transform.GetChild(1)).GetComponent<HandObjectFalls>().Granny;
			((Component)newPictureItem.transform.GetChild(0)).GetComponent<HandObjectFalls>().spawnObject = ((Component)((Component)gameController.GetComponent<InventoryController>().newbattery).transform.GetChild(1)).GetComponent<HandObjectFalls>().spawnObject;
			((Component)newPictureItem.transform.GetChild(0)).GetComponent<HandObjectFalls>().ParentObject = newPictureItem;
			((Component)newPictureItem.transform.GetChild(0)).GetComponent<HandObjectFalls>().ObjectLjud = objectLjud;
			((Component)newPictureItem.transform.GetChild(0)).GetComponent<HandObjectFalls>().objectResetPos = ((Component)((Component)gameController.GetComponent<InventoryController>().newbattery).transform.GetChild(1)).GetComponent<HandObjectFalls>().objectResetPos;
			((Object)newPictureItem).name = "newPicture";
			newPictureItem.tag = "vitrindoorRclosed";
			PictureItemHand = Object.Instantiate<GameObject>(PictureOnPlace, new Vector3(13.738f, 23.5961f, -6.58f), Quaternion.Euler(0f, -59.6f, -10f));
			PictureItemHand.transform.localScale = new Vector3(0.07f, 0.098191366f, 0.08615021f);
			PictureItemHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			Object.Destroy((Object)(object)PictureItemHand.GetComponent<Rigidbody>());
			((Collider)PictureItemHand.GetComponents<BoxCollider>()[0]).enabled = false;
			((Collider)PictureItemHand.GetComponents<BoxCollider>()[1]).enabled = false;
			Object.Destroy((Object)(object)((Component)PictureItemHand.transform.GetChild(0)).GetComponent<objectFallFloor>());
			Object.Destroy((Object)(object)PictureItemHand.transform.GetChild(0));
			OrigPicture = ((Renderer)PictureOnPlace.GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)PictureOnPlace.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa").GetComponent<MeshRenderer>()).material.mainTexture;
			PictureItemHand.SetActive(false);
		}
		((SoundEffectsPlayerInBed)(object)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
		yield return ((MonoBehaviour)this).StartCoroutine(FadeText1(0f, 1f, 2f));
		fadeTextSpeed = 1f;
		((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		yield return (object)new WaitForSeconds(2f);
		if (AnomalyNR == 25)
		{
			PictureItemHand.transform.position = new Vector3(13.738f, 23.5961f, -7f);
			GameObject.FindWithTag("playhousekey").tag = "teddy";
		}
		if (AnomalyNR == 95)
		{
			yield return (object)new WaitForSeconds(7f);
			Application.Quit();
		}
		if (AnomalyNR == 1305)
		{
			yield return (object)new WaitForSeconds(4f);
			Application.OpenURL("https://discord.gg/5WWwUF5btf");
			yield return (object)new WaitForSeconds(1f);
			Application.Quit();
		}
		yield return ((MonoBehaviour)this).StartCoroutine(FadeText1(1f, 0f, 2f));
		day1Text.SetActive(false);
		AnomalyText.SetActive(false);
		animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed");
		kliverUrBedLjud.SetActive(true);
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
		{
			bloodHanging.SetActive(true);
			rats.SetActive(true);
			NigthmareTV = "Yes";
			((Renderer)GameObject.Find("HouseNy").GetComponent<MeshRenderer>()).materials[1].mainTexture = ((Renderer)GameObject.Find("HouseNy").GetComponent<MeshRenderer>()).material.mainTexture;
			if (AnomalyNR == 20)
			{
				RenderSettings.fogColor = new Color(0.6f, 0f, 0.1f);
			}
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") == 7)
		{
			bloodHanging.SetActive(true);
			NigthmareTV = "Yes";
			((Renderer)GameObject.Find("HouseNy").GetComponent<MeshRenderer>()).materials[1].mainTexture = ((Renderer)GameObject.Find("HouseNy").GetComponent<MeshRenderer>()).material.mainTexture;
			RenderSettings.fogColor = new Color(0.6f, 0f, 0.1f);
			((Component)playerCam).GetComponent<Camera>().backgroundColor = new Color(0.6f, 0f, 0.1f);
			((Component)GameObject.Find("CamOutdoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = new Color(0.6f, 0f, 0.1f);
			((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = new Color(0.6f, 0f, 0.1f);
			((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = new Color(0.6f, 0f, 0.1f);
			((Component)GameObject.Find("CoffinBackyard").transform.GetChild(0).GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = new Color(0.6f, 0f, 0.1f);
			((Renderer)GameObject.Find("Water").GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0f, 0.3f);
			((Renderer)GameObject.Find("Water2").GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0f, 0.3f);
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 0 && PlayerPrefs.GetInt("EventChallenge2") == 0)
		{
			bloodHanging.SetActive(false);
			rats.SetActive(false);
			NigthmareTV = "No";
		}
		if (PlayerPrefs.GetInt("LaserOnOffOnOff") == 1)
		{
			NigthmarewallsTV = "Yes";
		}
		else
		{
			NigthmarewallsTV = "No";
		}
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				musicHolderNightmare.SetActive(true);
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
			{
				AbondonedMusicHolder.SetActive(true);
			}
			else
			{
				musicHolder.SetActive(true);
			}
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (PrimeAnomalyNR != 1 && PrimeAnomalyNR != 6 && PrimeAnomalyNR != 9 && PrimeAnomalyNR != 15 && PlayerPrefs.GetInt("NerfedPrimeOnOff") != 1 && PlayerPrefs.GetInt("ExtraTrapsOnOff") != 1)
			{
				if (PrimeAnomalyNR == 11)
				{
					BaloonEvilChairExample = Object.Instantiate<GameObject>(GameObject.Find("ChairSR1"), new Vector3(0f, -100f, 0f), Quaternion.Euler(-90f, 0f, 0f));
					Object.Destroy((Object)(object)((Component)BaloonEvilChairExample.transform.GetChild(0)).gameObject);
					((Object)BaloonEvilChairExample).name = "EvilChairExample";
					((Collider)BaloonEvilChairExample.GetComponent<MeshCollider>()).isTrigger = true;
					BaloonEvilChairExample.AddComponent<PrimeAnomaly11BaloonEvilChairAppearence>();
				}
				rats.SetActive(true);
				GameObject.Find("ChairSR1").GetComponent<Rigidbody>().isKinematic = true;
				GameObject.Find("Rat1").GetComponent<NavMeshAgent>().speed = 20f;
				GameObject.Find("Rat1").GetComponent<NavMeshAgent>().acceleration = 100f;
				((Collider)GameObject.Find("Rat1").GetComponent<BoxCollider>()).isTrigger = true;
				GameObject.Find("Rat1").transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
				EvilChair = GameObject.Find("ChairSR1");
				EvilChair.transform.SetParent(GameObject.Find("Rat1").transform);
				Object.Destroy((Object)(object)((Component)EvilChair.transform.GetChild(0)).gameObject);
				Object.Destroy((Object)(object)EvilChair.GetComponent<MeshCollider>());
				EvilChair.transform.localPosition = new Vector3(0f, 0f, 0f);
				EvilChair.transform.localRotation = Quaternion.Euler(-90f, 0f, 0f);
				((Renderer)EvilChair.GetComponent<MeshRenderer>()).material.shader = ((Renderer)GameObject.Find("Larmlampa2").GetComponent<MeshRenderer>()).material.shader;
				((Renderer)EvilChair.GetComponent<MeshRenderer>()).material.color = Color.white;
				((Object)EvilChair).name = "StoolPrime";
				ShootStoolAchievement.transform.SetParent(GameObject.Find("Rat1").transform);
				if (PrimeAnomalyNR == 10)
				{
					((Renderer)EvilChair.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)gameController.GetComponent<InventoryController>().vas.GetComponent<MeshRenderer>()).material.mainTexture;
				}
				((Component)GameObject.Find("Rat1").transform.GetChild(0)).gameObject.SetActive(false);
				GameObject.Find("Rat2").SetActive(false);
				if (PrimeAnomalyNR == 3)
				{
					GameObject.Find("Rat1").transform.localScale = new Vector3(0.375f, 0.375f, 0.375f);
				}
				if (PrimeAnomalyNR == 11)
				{
					BaloonEvilChairExample.GetComponent<PrimeAnomaly11BaloonEvilChairAppearence>().BaloonEvilChair = GameObject.Find("Rat1");
				}
			}
			else
			{
				GameObject.Find("ChairSR1").GetComponent<Rigidbody>().isKinematic = true;
				GameObject.Find("ChairSR1").transform.position = new Vector3(-1.13f, 13.25f, 17.83f);
			}
		}
		if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
		{
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 5.5f;
			((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
			yield return (object)new WaitForSeconds(2f);
		}
		else
		{
			((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
			yield return (object)new WaitForSeconds(11f);
		}
		playerInBed.SetActive(false);
		Player.SetActive(true);
		if (PlayerPrefs.GetInt("DiffData") != 7 && PlayerPrefs.GetInt("fogOnOff") == 1 && PlayerPrefs.GetInt("UltraFlaslight") != 1 && AnomalyNR != 20 && AnomalyNR != 30)
		{
			clipPlaneHolder.GetComponent<Camera>().farClipPlane = 18f;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("LowDetailOnOff") == 1)
		{
			clipPlaneHolder.GetComponent<Camera>().farClipPlane = 18f;
		}
		else
		{
			clipPlaneHolder.GetComponent<Camera>().farClipPlane = 45f;
		}
		joystick.SetActive(true);
		crouchButton.SetActive(true);
		optionButton.SetActive(true);
		((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
		mittPrick.SetActive(true);
		kliverUrBedLjud.SetActive(false);
		if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1)
		{
			TimerText = DefaultControls.CreateText(c);
			TimerText.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
			TimerText.GetComponent<Text>().text = "";
			((Graphic)TimerText.GetComponent<Text>()).color = Color.white;
			TimerText.GetComponent<Text>().fontStyle = (FontStyle)2;
			TimerText.GetComponent<Text>().alignment = (TextAnchor)0;
			TimerText.GetComponent<Text>().resizeTextForBestFit = true;
			TimerText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			TimerText.GetComponent<Text>().fontSize = 0;
			TimerText.GetComponent<Text>().resizeTextMaxSize = 50;
			TimerText.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 30f);
			TimerText.GetComponent<RectTransform>().anchorMin = new Vector2(0f, 1f);
			TimerText.GetComponent<RectTransform>().anchorMax = new Vector2(0f, 1f);
			TimerText.GetComponent<RectTransform>().anchoredPosition = new Vector2(50f, -10f);
			TimerPrimeSec = 0f;
			TimerPrimeMin = 0f;
			TimerPrimeHour = 0f;
		}
		if (PlayerPrefs.GetInt("PrimeOn") == 0 || PlayerPrefs.GetInt("ShowProgressOnOff") == 1)
		{
			AnomalyCommentText = DefaultControls.CreateText(c);
			AnomalyCommentText.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
			AnomalyCommentText.GetComponent<Text>().text = "";
			((Graphic)AnomalyCommentText.GetComponent<Text>()).color = Color.white;
			AnomalyCommentText.GetComponent<Text>().fontStyle = (FontStyle)2;
			AnomalyCommentText.GetComponent<Text>().alignment = (TextAnchor)2;
			AnomalyCommentText.GetComponent<Text>().resizeTextForBestFit = true;
			AnomalyCommentText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			AnomalyCommentText.GetComponent<Text>().fontSize = 0;
			AnomalyCommentText.GetComponent<Text>().resizeTextMaxSize = 50;
			AnomalyCommentText.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, 30f);
			AnomalyCommentText.GetComponent<RectTransform>().anchorMin = new Vector2(1f, 1f);
			AnomalyCommentText.GetComponent<RectTransform>().anchorMax = new Vector2(1f, 1f);
			AnomalyCommentText.GetComponent<RectTransform>().anchoredPosition = new Vector2(-100f, -10f);
			ProgressValue = 0;
			ProgressCar = 0;
			ProgressLift = 0;
			ProgressBehavior = 0;
			if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
			{
				ProgressDoorPreset = 50;
			}
			else if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				ProgressDoorPreset = 30;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				ProgressDoorPreset = 40;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				ProgressDoorPreset = 60;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				ProgressDoorPreset = 70;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6)
			{
				ProgressDoorPreset = 80;
			}
			if (PlayerPrefs.GetInt("twoLocksOnOff") == 1)
			{
				ProgressDoorPreset = 80;
			}
		}
		if (AnomalyNR == 18)
		{
			AnomalyTV = "18";
			AnomalyText.GetComponent<Text>().text = "Special anomaly 18:\r\n You have returned to 1.0, but something went wrong...";
			Anomaly18Wall1 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/Vind2_2/Vind2Door_**"), new Vector3(3.73f, 14.87f, -20.49f), Quaternion.Euler(0f, 0f, -180f));
			Anomaly18Wall1.transform.localScale = new Vector3(0.33667323f, 0.2256523f, 0.06917591f);
			((Renderer)(MeshRenderer)Anomaly18Wall1.GetComponent(typeof(MeshRenderer))).materials = ((Renderer)GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa").GetComponent<MeshRenderer>()).materials;
			((Renderer)(MeshRenderer)Anomaly18Wall1.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.black);
			((Renderer)(MeshRenderer)Anomaly18Wall1.GetComponent(typeof(MeshRenderer))).material.SetColor("_EmissionColor", Color.black);
			Object.Destroy((Object)(object)Anomaly18Wall1.GetComponent<Animation>());
			Object.Destroy((Object)(object)Anomaly18Wall1.GetComponent<AudioSource>());
			Anomaly18Wall1.AddComponent<NavMeshObstacle>();
			Anomaly18Wall1.GetComponent<NavMeshObstacle>().carving = true;
			((Object)Anomaly18Wall1).name = "Anomaly18SecretEscape1";
			Anomaly18Wall2 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(8.46f, 9.19f, -5.21f), Quaternion.Euler(0f, -90f, -180f));
			Anomaly18Wall2.transform.localScale = new Vector3(0.33667323f, 0.2256523f, 0.06917591f);
			((Object)Anomaly18Wall2).name = "Anomaly18SecretEscape2";
			Anomaly18Wall3 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(-5.33f, 10.106f, 6.5f), Quaternion.Euler(0f, 0f, -180f));
			((Object)Anomaly18Wall3).name = "Anomaly18SecretEscape3";
			Anomaly18Wall4 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(19.7f, 15.9f, -6.9f), Quaternion.Euler(0f, -90f, -180f));
			Anomaly18Wall4.transform.localScale = new Vector3(0.73965174f, 0.3512259f, 0.06917591f);
			((Object)Anomaly18Wall4).name = "Anomaly18SecretEscape4";
			Anomaly18Wall5 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(-18.87f, 22.88f, -12.829999f), Quaternion.Euler(0f, 0f, -180f));
			Anomaly18Wall5.transform.localScale = new Vector3(0.73965174f, 0.3512259f, 0.06917591f);
			((Object)Anomaly18Wall5).name = "Anomaly18SecretEscape5";
			Anomaly18Wall6 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(-3.94f, 22.88f, 14.06f), Quaternion.Euler(0f, 180f, -180f));
			Anomaly18Wall6.transform.localScale = new Vector3(0.73965174f, 0.3512259f, 0.06917591f);
			((Object)Anomaly18Wall6).name = "Anomaly18SecretEscape6";
			Anomaly18Wall7 = Object.Instantiate<GameObject>(Anomaly18Wall1, new Vector3(-20.92f, 22.717f, 0.4085f), Quaternion.Euler(0f, 90f, -180f));
			Anomaly18Wall7.transform.localScale = new Vector3(0.2676743f, 0.2506724f, 0.06917591f);
			((Object)Anomaly18Wall7).name = "Anomaly18SecretEscape7";
			if (Object.op_Implicit((Object)(object)GameObject.Find("SmallDoorParentVind")))
			{
				Object.Destroy((Object)(object)GameObject.Find("SmallDoorParentVind"));
			}
			if (Object.op_Implicit((Object)(object)GameObject.Find("BackyardDoorParent")))
			{
				Object.Destroy((Object)(object)GameObject.Find("BackyardDoorParent"));
			}
			if (Object.op_Implicit((Object)(object)GameObject.Find("All doors/SmallDoorParent/SmallDoor")))
			{
				GameObject.Find("All doors/SmallDoorParent/SmallDoor").tag = "smalldoorClosed";
			}
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/Furniture/GameObject"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent (1)"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorL"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorL"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorR"));
			Object.Destroy((Object)(object)GameObject.Find("Kartong"));
			Object.Destroy((Object)(object)GameObject.Find("Kartong (1)"));
			Object.Destroy((Object)(object)GameObject.Find("Kartong (2)"));
			Object.Destroy((Object)(object)GameObject.Find("Planka_Hole"));
			Object.Destroy((Object)(object)GameObject.Find("HouseUpdate5_Secrethole_MomPlace"));
			GameObject.Find("Remotetrigger").transform.SetParent((Transform)null);
			Object.Destroy((Object)(object)GameObject.Find("RemoteLockDel2"));
			Object.Destroy((Object)(object)GameObject.Find("HyllaUnderTrapp"));
			Object.Destroy((Object)(object)GameObject.Find("PepperSpray"));
			Object.Destroy((Object)(object)GameObject.Find("HyllaHall"));
			Object.Destroy((Object)(object)GameObject.Find("Burk"));
			Object.Destroy((Object)(object)GameObject.Find("FanCollider"));
			Object.Destroy((Object)(object)GameObject.Find("GrannyCantSeeCollider15"));
			GameObject.Find("Window").transform.position = new Vector3(7.691531f, 17.199251f, -12.730149f);
			GameObject.Find("Window").transform.rotation = Quaternion.Euler(-90f, 90f, 90f);
			GameObject.Find("Window").tag = "Untagged";
			Anomaly18Screwdriver = GameObject.Find("Screwdriver");
			Anomaly18Screwdriver.transform.SetParent((Transform)null);
			Anomaly18Screwdriver.transform.position = new Vector3(-12.481f, 24.113f, 14.216f);
			Anomaly18Screwdriver.transform.rotation = Quaternion.Euler(77.39f, 180f, 90f);
			Object.Destroy((Object)(object)Anomaly18Screwdriver.GetComponent<Rigidbody>());
			Anomaly18Screwdriver.SetActive(false);
			KnarrandeGolvExtreme.SetActive(true);
			Anomaly18Screw = GameObject.Find("HoleGaller");
			Anomaly18Screw.transform.SetParent((Transform)null);
			Anomaly18SecretDrawer = Object.Instantiate<GameObject>(GameObject.Find("Loda2Parent/ByroLoda"), new Vector3(-12.47f, 24.191086f, 14.388744f), Quaternion.Euler(-180f, 0f, 0f));
			Anomaly18SecretDrawer.transform.SetParent((Transform)null);
			Anomaly18SecretDrawer.transform.localScale = new Vector3(0.2786806f, 0.24189928f, 0.45047557f);
			Anomaly18SecretDrawer.tag = "Untagged";
			((Renderer)Anomaly18SecretDrawer.GetComponent<MeshRenderer>()).material.color = new Color(0.08f, 0.3f, 0.64f);
			if (PlayerPrefs.GetInt("DiffData") != 3 && PlayerPrefs.GetInt("DiffData") != 5 && PlayerPrefs.GetInt("DiffData") != 6)
			{
				KnarrandeGolvExtreme.SetActive(false);
			}
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/DeliverShotgunParts (1)").transform.position = new Vector3(-1.5286224f, 8.210388f, -16.516596f);
			GameObject.Find("ShotgunInPiecesBord").transform.position = new Vector3(-1.813f, 7.61f, -16.746f);
			GameObject.Find("Ammo").transform.position = new Vector3(0.4045f, 8.577f, -18.316f);
			TextObject = Object.Instantiate<GameObject>(GameObject.Find("AllSafeColliders/SafeCollider (1)"), new Vector3(34.325f, 28.11f, 5.93f), Quaternion.Euler(0f, 90f, 0f));
			Object.Destroy((Object)(object)TextObject.GetComponent<BoxCollider>());
			TextObject.transform.SetParent((Transform)null);
			TextObject.transform.localScale = new Vector3(4.06f, 3.37f, 2f);
			TextTask = TextObject.AddComponent<TextMesh>();
			TextTask.text = "";
			TextTask.offsetZ = 0.31f;
			TextTask.characterSize = 0.01f;
			TextTask.fontSize = 199;
			TextTask.richText = true;
			TextObject.SetActive(false);
			TVText = Object.Instantiate<GameObject>(TextObject, new Vector3(-18.028f, 16.355f, -4.577f), Quaternion.Euler(0f, 0f, 0f));
			TVText.transform.localScale = new Vector3(0.77f, 0.67f, 2f);
			TVText.GetComponent<TextMesh>().text = "";
			TVText.GetComponent<TextMesh>().fontSize = 175;
			TVText.GetComponent<TextMesh>().color = Color.white;
			Object.Destroy((Object)(object)TVText.GetComponent<BoxCollider>());
			TVText.SetActive(false);
			TextVision = Object.Instantiate<GameObject>(GameObject.Find("Remotetrigger"), new Vector3(31.13f, 21.95f, -0.82f), Quaternion.Euler(-90f, 0f, 0f));
			TextVision.transform.SetParent((Transform)null);
			TextVision.transform.localScale = new Vector3(6.8f, 18f, 1.2f);
			TVArea = Object.Instantiate<GameObject>(TextVision, new Vector3(-17.1f, 14.33f, -7.59f), Quaternion.Euler(-90f, 0f, 0f));
			((Object)TVArea).name = "TVArea";
			TVArea.transform.SetParent((Transform)null);
			TVArea.transform.localScale = new Vector3(8.07f, 11.42f, 1.2f);
			GameObject.Find("LitetBordVR").transform.localPosition = new Vector3(2.189971f, 3.817828f, -11.22479f);
			GameObject.Find("WoodenBox (1)").SetActive(false);
			GameObject.Find("WoodenBox (2)").SetActive(false);
			((Renderer)(MeshRenderer)Anomaly18Wall1.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.green);
			PictureItem.transform.position = new Vector3(-12.411585f, 24.220592f, 13.807792f);
			PictureItem.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			GameObject.Find("UsefulObjects/TextMessage").transform.position = new Vector3(33.7f, 23.41f, -4.9f);
			LiftMessage = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(5.325f, 15.868f, -19.175f), Quaternion.Euler(-180f, -90f, 29.5f));
			LiftMessage.tag = "Untagged";
			((Object)LiftMessage).name = "SecretMessage";
			Button = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(14.425f, 26.746f, 5.748f), Quaternion.Euler(90f, 0f, 0f));
			Button.transform.SetParent((Transform)null);
			Button.transform.localScale = new Vector3(0.49f, 0.49f, 0.49f);
			Button.AddComponent<BoxCollider>();
			((Renderer)Button.GetComponent<MeshRenderer>()).material.color = Color.black;
			((Object)Button).name = "SecretButtonAnomaly18";
			GameObject.Find("RemoteLock").SetActive(false);
			GameObject.Find("GallerDoor").transform.localPosition = new Vector3(0.53f, -2.04f, -5.47f);
			GameObject.Find("GallerDoor").transform.localRotation = Quaternion.Euler(260.835f, 90f, -177.92f);
			if (PlayerPrefs.GetInt("randomNR") == 100)
			{
				PlayerPrefs.SetInt("randomNR", Random.Range(1, 10));
				gameController.GetComponent<InventoryController>().RandomPresetAnomaly18();
				saveRandomNR = true;
			}
			if (PlayerPrefs.GetInt("randomNR") == 99)
			{
				PlayerPrefs.SetInt("PresetInOrder", PlayerPrefs.GetInt("PresetInOrder") + 1);
				if (PlayerPrefs.GetInt("PresetInOrder") == 10)
				{
					PlayerPrefs.SetInt("PresetInOrder", 1);
				}
				PlayerPrefs.SetInt("randomNR", PlayerPrefs.GetInt("PresetInOrder"));
				gameController.GetComponent<InventoryController>().RandomPresetAnomaly18();
				saveInOrder = true;
			}
			if (PlayerPrefs.GetInt("randomNR") == 1)
			{
				OP1.SetActive(true);
				OP1_2.SetActive(true);
				OP1_3.SetActive(true);
				OP1_4.SetActive(true);
				OP1_5.SetActive(true);
				OP1_6.SetActive(true);
				OP1_7.SetActive(true);
				GameObject.Find("HammerPL1").transform.SetParent((Transform)null);
				Anomaly18Hammer1 = GameObject.Find("HammerPL1");
				GameObject.Find("HammerPL1").transform.position = new Vector3(17.739725f, 13.61328f, 3.3799706f);
				GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(-180f, -28.09f, 90f);
				GameObject.Find("HanglockKeyPL1").transform.SetParent((Transform)null);
				GameObject.Find("HanglockKeyPL1").transform.position = new Vector3(-1.682275f, 10.543281f, 6.1159706f);
				GameObject.Find("HanglockKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -18f);
				GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
				GameObject.Find("HouseKeyPL1").transform.position = new Vector3(6.7307253f, 7.792f, 0.7499709f);
				GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -78f);
				Anomaly18MasterKey1 = GameObject.Find("HouseKeyPL1");
				GameObject.Find("SafeKeyPL1").transform.SetParent(GameObject.Find("LodaParent (1)/Loda").transform);
				GameObject.Find("SafeKeyPL1").transform.position = new Vector3(-17.737226f, 15.1318445f, 13.469555f);
				GameObject.Find("SafeKeyPL1").transform.rotation = Quaternion.Euler(0f, 75f, 0f);
				GameObject.Find("Shotgun1_PL1").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL1").transform.position = new Vector3(18.277f, 16.13f, 12.511f);
				GameObject.Find("Shotgun1_PL1").transform.rotation = Quaternion.Euler(-90f, -45f, 0f);
				GameObject.Find("Shotgun2_PL1").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL1").transform.position = new Vector3(6.818f, 22.396f, 5.524f);
				GameObject.Find("Shotgun2_PL1").transform.rotation = Quaternion.Euler(47.8f, 0f, -90f);
				GameObject.Find("Shotgun3_PL1").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(-4.359f, 8.233f, 6.88f);
				GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(-17.77f, 0f, -90f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL1");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL1");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL1");
				Anomaly18CuttingPliers1 = GameObject.Find("AvbitarePL1");
				OP1.SetActive(false);
				OP1_2.SetActive(false);
				OP1_3.SetActive(false);
				OP1_4.SetActive(false);
				OP1_5.SetActive(false);
				OP1_6.SetActive(false);
				OP1_7.SetActive(false);
				Anomaly18CuttingPliers1.SetActive(true);
				Anomaly18Hammer1.SetActive(true);
				Anomaly18MasterKey1.SetActive(true);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 2)
			{
				OP2.SetActive(true);
				OP2_2.SetActive(true);
				OP2_3.SetActive(true);
				OP2_4.SetActive(true);
				OP2_5.SetActive(true);
				GameObject.Find("HammerPL2").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL2").transform.position = new Vector3(2.370725f, 11.116281f, 6.187971f);
				GameObject.Find("HammerPL2").transform.rotation = Quaternion.Euler(-259.8f, 0f, 90f);
				GameObject.Find("HanglockKeyPL2").transform.SetParent(GameObject.Find("Loda2Parent (3)/ByroLoda").transform);
				GameObject.Find("HanglockKeyPL2").transform.position = new Vector3(-8.849932f, 23.160156f, -2.3232923f);
				GameObject.Find("HanglockKeyPL2").transform.rotation = Quaternion.Euler(-90f, 0f, 52.21f);
				GameObject.Find("HanglockKeyPL2").transform.localScale = new Vector3(0.01487357f, 0.0143192f, 0.007172777f);
				GameObject.Find("SafeKeyPL2").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL2").transform.position = new Vector3(9.5707245f, 21.42828f, 12.35097f);
				GameObject.Find("SafeKeyPL2").transform.rotation = Quaternion.Euler(-180f, 0f, 180f);
				GameObject.Find("AvbitarePL2").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL2").transform.position = new Vector3(2.570725f, 16.18528f, -12.121029f);
				GameObject.Find("AvbitarePL2").transform.rotation = Quaternion.Euler(-90f, 0f, -84.92f);
				GameObject.Find("Shotgun1_PL2").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL2").transform.position = new Vector3(-19.595f, 15.522f, 13.39f);
				GameObject.Find("Shotgun1_PL2").transform.rotation = Quaternion.Euler(90f, 0f, 36.53f);
				GameObject.Find("Shotgun2_PL2").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL2").transform.position = new Vector3(13.13f, 13.594f, 0.06f);
				GameObject.Find("Shotgun2_PL2").transform.rotation = Quaternion.Euler(-90f, 0f, 40f);
				GameObject.Find("Shotgun3_PL2").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL2").transform.position = new Vector3(-15.557f, 15.711f, -2.2f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL2");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL2");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL2");
				OP2.SetActive(false);
				OP2_2.SetActive(false);
				OP2_3.SetActive(false);
				OP2_4.SetActive(false);
				OP2_5.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 3)
			{
				OP3.SetActive(true);
				OP3_2.SetActive(true);
				OP3_3.SetActive(true);
				OP3_4.SetActive(true);
				OP3_5.SetActive(true);
				OP3_6.SetActive(true);
				GameObject.Find("HouseKeyPL3").transform.SetParent((Transform)null);
				GameObject.Find("HouseKeyPL3").transform.position = new Vector3(-8.005276f, 14.63928f, 6.1419706f);
				GameObject.Find("HouseKeyPL3").transform.rotation = Quaternion.Euler(-90f, 0f, -24.5f);
				GameObject.Find("SafeKeyPL3").transform.SetParent(GameObject.Find("Loda2Parent (4)/ByroLoda").transform);
				GameObject.Find("SafeKeyPL3").transform.localPosition = new Vector3(-0.455f, 0.609f, 0.18f);
				GameObject.Find("SafeKeyPL3").transform.localRotation = Quaternion.Euler(166.05f, -90f, -90f);
				GameObject.Find("AvbitarePL3").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL3").transform.position = new Vector3(18.156725f, 16.11528f, 12.46197f);
				GameObject.Find("AvbitarePL3").transform.rotation = Quaternion.Euler(-90f, 0f, -4.547f);
				GameObject.Find("Shotgun1_PL3").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL3").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL3").transform.SetParent((Transform)null);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL3");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL3");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL3");
				OP3.SetActive(false);
				OP3_2.SetActive(false);
				OP3_3.SetActive(false);
				OP3_4.SetActive(false);
				OP3_5.SetActive(false);
				OP3_6.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 4)
			{
				OP4.SetActive(true);
				OP4_2.SetActive(true);
				OP4_3.SetActive(true);
				OP4_4.SetActive(true);
				OP4_5.SetActive(true);
				OP4_6.SetActive(true);
				OP4_7.SetActive(true);
				GameObject.Find("HammerPL4").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL4").transform.position = new Vector3(-18.701275f, 25.61628f, -11.494029f);
				GameObject.Find("HammerPL4").transform.rotation = Quaternion.Euler(-180f, -28.4f, 90f);
				GameObject.Find("HouseKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("HouseKeyPL4").transform.position = new Vector3(6.8887253f, 22.44228f, 7.071971f);
				GameObject.Find("HouseKeyPL4").transform.rotation = Quaternion.Euler(-90f, 0f, -77.41f);
				GameObject.Find("HanglockKeyPL4").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
				GameObject.Find("HanglockKeyPL4").transform.localPosition = new Vector3(0f, 0.982f, 0.171f);
				GameObject.Find("HanglockKeyPL4").transform.localRotation = Quaternion.Euler(0f, 0f, 33.3f);
				GameObject.Find("HanglockKeyPL4").transform.localScale = new Vector3(0.01468455f, 0.01431921f, 0.007172781f);
				GameObject.Find("SafeKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL4").transform.position = new Vector3(18.320724f, 16.09328f, 2.031971f);
				GameObject.Find("SafeKeyPL4").transform.rotation = Quaternion.Euler(0f, 13.52f, 0f);
				GameObject.Find("AvbitarePL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL4").transform.position = new Vector3(14.043066f, 21.55f, -11.810143f);
				GameObject.Find("Shotgun1_PL4").transform.rotation = Quaternion.Euler(-90f, -45f, 0f);
				GameObject.Find("Shotgun2_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL4").transform.SetParent((Transform)null);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL4");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL4");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL4");
				OP4.SetActive(false);
				OP4_2.SetActive(false);
				OP4_3.SetActive(false);
				OP4_4.SetActive(false);
				OP4_5.SetActive(false);
				OP4_6.SetActive(false);
				OP4_7.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 5)
			{
				OP5.SetActive(true);
				OP5_2.SetActive(true);
				OP5_3.SetActive(true);
				OP5_4.SetActive(true);
				OP5_5.SetActive(true);
				OP5_6.SetActive(true);
				OP5_7.SetActive(true);
				GameObject.Find("HouseKeyPL5").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL5").transform.SetParent(GameObject.Find("Loda2Parent (2)/ByroLoda").transform);
				GameObject.Find("SafeKeyPL5").transform.localPosition = new Vector3(-0.455f, 0.609f, 0.18f);
				GameObject.Find("SafeKeyPL5").transform.localRotation = Quaternion.Euler(166.05f, -90f, -90f);
				GameObject.Find("AvbitarePL5").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL5").transform.SetParent(GameObject.Find("LodaParent/Loda").transform);
				GameObject.Find("AvbitarePL5").transform.position = new Vector3(-19.1f, 15.13092f, 13.405f);
				GameObject.Find("AvbitarePL5").transform.rotation = Quaternion.Euler(-90f, 0f, -97f);
				GameObject.Find("Shotgun1_PL5").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL5").transform.position = new Vector3(1.118f, 9.893f, 6.116f);
				GameObject.Find("Shotgun1_PL5").transform.rotation = Quaternion.Euler(-90f, 0f, -8.76f);
				GameObject.Find("Shotgun2_PL5").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL5").transform.position = new Vector3(-8.053f, 14.649f, 6.11f);
				GameObject.Find("Shotgun2_PL5").transform.rotation = Quaternion.Euler(90f, 0f, -120f);
				GameObject.Find("Shotgun3_PL5").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL5").transform.position = new Vector3(5.642f, 13.957f, -1.0253f);
				GameObject.Find("Shotgun3_PL5").transform.rotation = Quaternion.Euler(0f, 0f, -118.5f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL5");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL5");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL5");
				Anomaly18CuttingPliers1 = GameObject.Find("AvbitarePL5");
				OP5.SetActive(false);
				OP5_2.SetActive(false);
				OP5_3.SetActive(false);
				OP5_4.SetActive(false);
				OP5_5.SetActive(false);
				OP5_6.SetActive(false);
				OP5_7.SetActive(false);
				Anomaly18CuttingPliers1.SetActive(true);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 6)
			{
				OP4.SetActive(true);
				OP4_2.SetActive(true);
				OP4_3.SetActive(true);
				OP4_4.SetActive(true);
				OP4_5.SetActive(true);
				OP4_6.SetActive(true);
				OP4_7.SetActive(true);
				GameObject.Find("HammerPL4").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL4").transform.position = new Vector3(15.707804f, 20.637f, 12.134f);
				GameObject.Find("HammerPL4").transform.rotation = Quaternion.Euler(-180f, -90f, 90f);
				GameObject.Find("HouseKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("HouseKeyPL4").transform.position = new Vector3(18.279905f, 13.566756f, 8.57247f);
				GameObject.Find("HouseKeyPL4").transform.rotation = Quaternion.Euler(-90f, 0f, -53f);
				GameObject.Find("HanglockKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("HanglockKeyPL4").transform.position = new Vector3(-12.89f, 22.304f, -0.592f);
				GameObject.Find("HanglockKeyPL4").transform.rotation = Quaternion.Euler(-90f, 0f, 41.2f);
				GameObject.Find("SafeKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL4").transform.position = new Vector3(-15.16f, 15.04f, -3.57f);
				GameObject.Find("SafeKeyPL4").transform.rotation = Quaternion.Euler(-180f, -45f, -180f);
				GameObject.Find("AvbitarePL4").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL4").transform.position = new Vector3(7.2421637f, 7.7900147f, 1.1264616f);
				GameObject.Find("AvbitarePL4").transform.rotation = Quaternion.Euler(-90f, 0f, 41.2f);
				GameObject.Find("Shotgun1_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL4").transform.position = new Vector3(12.437f, 16.048f, 0.767f);
				GameObject.Find("Shotgun1_PL4").transform.rotation = Quaternion.Euler(90f, 0f, 43.45f);
				GameObject.Find("Shotgun2_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL4").transform.position = new Vector3(18.36f, 14.64f, 12.86f);
				GameObject.Find("Shotgun2_PL4").transform.rotation = Quaternion.Euler(-90f, -180f, 56f);
				GameObject.Find("Shotgun3_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL4").transform.position = new Vector3(2.543f, 18.339f, -2.024f);
				GameObject.Find("Shotgun3_PL4").transform.rotation = Quaternion.Euler(14.28f, -0.9f, -87.88f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL4");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL4");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL4");
				OP4.SetActive(false);
				OP4_2.SetActive(false);
				OP4_3.SetActive(false);
				OP4_4.SetActive(false);
				OP4_5.SetActive(false);
				OP4_6.SetActive(false);
				OP4_7.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 7)
			{
				OP4.SetActive(true);
				OP4_2.SetActive(true);
				OP4_3.SetActive(true);
				OP4_4.SetActive(true);
				OP4_5.SetActive(true);
				OP4_6.SetActive(true);
				OP4_7.SetActive(true);
				GameObject.Find("HammerPL4").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL4").transform.position = new Vector3(-16.12f, 20.55f, 13.67f);
				GameObject.Find("HammerPL4").transform.rotation = Quaternion.Euler(120f, 7.6f, 96.72f);
				GameObject.Find("HouseKeyPL4").transform.SetParent(GameObject.Find("Loda2Parent (4)/ByroLoda").transform);
				GameObject.Find("HouseKeyPL4").transform.localPosition = new Vector3(0.112449415f, -0.53f, 0.21f);
				GameObject.Find("HouseKeyPL4").transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
				GameObject.Find("HouseKeyPL4").transform.localScale = new Vector3(0.018581487f, 0.021647798f, 0.00818329f);
				GameObject.Find("HanglockKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("HanglockKeyPL4").transform.position = new Vector3(7.0095706f, 7.7900143f, 0.6784824f);
				GameObject.Find("HanglockKeyPL4").transform.rotation = Quaternion.Euler(-90f, 0f, -35f);
				GameObject.Find("SafeKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL4").transform.position = new Vector3(-8.203f, 16.166f, 4.757f);
				GameObject.Find("SafeKeyPL4").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				GameObject.Find("AvbitarePL4").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL4").transform.position = new Vector3(15.981f, 13.779f, 0.238f);
				GameObject.Find("AvbitarePL4").transform.rotation = Quaternion.Euler(-38f, -90f, 0f);
				GameObject.Find("Shotgun1_PL4").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
				GameObject.Find("Shotgun1_PL4").transform.position = new Vector3(-14.627f, 23.195f, -0.64f);
				GameObject.Find("Shotgun1_PL4").transform.rotation = Quaternion.Euler(-90f, 0f, -45f);
				GameObject.Find("Shotgun2_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL4").transform.position = new Vector3(18.305f, 16.126f, 2.065f);
				GameObject.Find("Shotgun2_PL4").transform.rotation = Quaternion.Euler(90f, 90f, 0f);
				GameObject.Find("Shotgun3_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL4").transform.position = new Vector3(-8.043f, 14.66f, 4.55f);
				GameObject.Find("Shotgun3_PL4").transform.rotation = Quaternion.Euler(-90f, -90f, 0f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL4");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL4");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL4");
				OP4.SetActive(false);
				OP4_2.SetActive(false);
				OP4_3.SetActive(false);
				OP4_4.SetActive(false);
				OP4_5.SetActive(false);
				OP4_6.SetActive(false);
				OP4_7.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 8)
			{
				OP4.SetActive(true);
				OP4_2.SetActive(true);
				OP4_3.SetActive(true);
				OP4_4.SetActive(true);
				OP4_5.SetActive(true);
				OP4_6.SetActive(true);
				OP4_7.SetActive(true);
				GameObject.Find("HammerPL4").transform.SetParent((Transform)null);
				GameObject.Find("HammerPL4").transform.position = new Vector3(7.078f, 7.798f, 0.838f);
				GameObject.Find("HammerPL4").transform.rotation = Quaternion.Euler(-177.5f, -54.7f, 90f);
				GameObject.Find("HouseKeyPL4").transform.SetParent(GameObject.Find("LodaParent (1)/Loda").transform);
				GameObject.Find("HouseKeyPL4").transform.localPosition = new Vector3(0.112449415f, -0.53f, 0.21f);
				GameObject.Find("HouseKeyPL4").transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
				GameObject.Find("HouseKeyPL4").transform.localScale = new Vector3(0.018581487f, 0.021647798f, 0.00818329f);
				GameObject.Find("HanglockKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("HanglockKeyPL4").transform.position = new Vector3(2.51f, 14.63f, -12.01f);
				GameObject.Find("HanglockKeyPL4").transform.rotation = Quaternion.Euler(-90f, 0f, -35f);
				GameObject.Find("SafeKeyPL4").transform.SetParent((Transform)null);
				GameObject.Find("SafeKeyPL4").transform.position = new Vector3(-13.11f, 21.5f, -0.505f);
				GameObject.Find("SafeKeyPL4").transform.rotation = Quaternion.Euler(0f, 52.5f, 0f);
				GameObject.Find("AvbitarePL4").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL4").transform.position = new Vector3(9.6f, 21.26f, 12.334f);
				GameObject.Find("AvbitarePL4").transform.rotation = Quaternion.Euler(-90f, 180f, 0f);
				GameObject.Find("Shotgun1_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun1_PL4").transform.position = new Vector3(6.58f, 23.39f, 8.198f);
				GameObject.Find("Shotgun1_PL4").transform.rotation = Quaternion.Euler(90f, 0f, 63f);
				GameObject.Find("Shotgun2_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL4").transform.position = new Vector3(4.462f, 13.685f, -1.301f);
				GameObject.Find("Shotgun2_PL4").transform.rotation = Quaternion.Euler(-20.166f, 0f, -90f);
				GameObject.Find("Shotgun3_PL4").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL4").transform.position = new Vector3(17.581f, 14.29f, 2.565f);
				GameObject.Find("Shotgun3_PL4").transform.rotation = Quaternion.Euler(-14.959f, 0f, -89.025f);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL4");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL4");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL4");
				OP4.SetActive(false);
				OP4_2.SetActive(false);
				OP4_3.SetActive(false);
				OP4_4.SetActive(false);
				OP4_5.SetActive(false);
				OP4_6.SetActive(false);
				OP4_7.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (PlayerPrefs.GetInt("randomNR") == 9)
			{
				OP3.SetActive(true);
				OP3_2.SetActive(true);
				OP3_3.SetActive(true);
				OP3_4.SetActive(true);
				OP3_5.SetActive(true);
				OP3_6.SetActive(true);
				GameObject.Find("HouseKeyPL3").transform.SetParent((Transform)null);
				GameObject.Find("HouseKeyPL3").transform.position = new Vector3(-8.005276f, 14.63928f, 6.1419706f);
				GameObject.Find("HouseKeyPL3").transform.rotation = Quaternion.Euler(-90f, 0f, -24.5f);
				GameObject.Find("SafeKeyPL3").transform.SetParent(GameObject.Find("Loda2Parent (4)/ByroLoda").transform);
				GameObject.Find("SafeKeyPL3").transform.localPosition = new Vector3(-0.455f, 0.609f, 0.18f);
				GameObject.Find("SafeKeyPL3").transform.localRotation = Quaternion.Euler(166.05f, -90f, -90f);
				GameObject.Find("AvbitarePL3").transform.SetParent((Transform)null);
				GameObject.Find("AvbitarePL3").transform.position = new Vector3(18.156725f, 16.11528f, 12.46197f);
				GameObject.Find("AvbitarePL3").transform.rotation = Quaternion.Euler(-90f, 0f, -4.547f);
				GameObject.Find("Shotgun1_PL3").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun2_PL3").transform.SetParent((Transform)null);
				GameObject.Find("Shotgun3_PL3").transform.SetParent((Transform)null);
				Anomaly18Shotgun1 = GameObject.Find("Shotgun1_PL3");
				Anomaly18Shotgun2 = GameObject.Find("Shotgun2_PL3");
				Anomaly18Shotgun3 = GameObject.Find("Shotgun3_PL3");
				OP3.SetActive(false);
				OP3_2.SetActive(false);
				OP3_3.SetActive(false);
				OP3_4.SetActive(false);
				OP3_5.SetActive(false);
				OP3_6.SetActive(false);
				Anomaly18Shotgun1.SetActive(false);
				Anomaly18Shotgun2.SetActive(false);
				Anomaly18Shotgun3.SetActive(false);
			}
			if (saveRandomNR)
			{
				PlayerPrefs.SetInt("randomNR", 100);
			}
			if (saveInOrder)
			{
				PlayerPrefs.SetInt("randomNR", 99);
			}
			TVTextMesh = TVText.GetComponent<TextMesh>();
		}
		if (AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && PrimeAnomalyNR != 18)
		{
			Plankaready = Object.Instantiate<GameObject>(GameObject.Find("GrannyHelaHuset/PlankaOH1"), new Vector3(33.241f, 15.994f, -12.4515f), Quaternion.Euler(-133.626f, 0f, 0f));
			((Object)Plankaready).name = "PlankaPlacedNewEscape";
			Plankaready.tag = "Untagged";
			Plankaready.transform.SetParent((Transform)null);
			Plankaready.transform.localScale = new Vector3(0.0415763f, 0.0331852f, 0.0415763f);
			((Component)Plankaready.transform.GetChild(0)).gameObject.SetActive(false);
			Object.Destroy((Object)(object)Plankaready.GetComponent<BoxCollider>());
			Plankaready.AddComponent<MeshCollider>();
			Plankaready.SetActive(false);
			Safezone1 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/DeliverShotgunParts (1)"), new Vector3(34.58f, 14.01f, -15.27f), Quaternion.identity);
			Safezone1.transform.SetParent((Transform)null);
			Safezone1.transform.localScale = new Vector3(3.6f, 1.59f, 2.54f);
			((Object)Safezone1).name = "PlankPlace";
			Landing1 = Object.Instantiate<GameObject>(GameObject.Find("HouseUpdateVind4/CoffinLock"), new Vector3(32.76f, 13.026f, -15.487f), Quaternion.Euler(-224f, -180f, -90f));
			Landing1.transform.SetParent((Transform)null);
			Landing1.transform.localScale = new Vector3(0.2256523f, 0.2256523f, 0.2256523f);
			Object.Destroy((Object)(object)Landing1.GetComponent<BoxCollider>());
			Landing1.AddComponent<MeshCollider>();
			Landing2 = Object.Instantiate<GameObject>(Landing1, new Vector3(27.443f, 19.27f, -6.75f), Quaternion.Euler(-237f, -180f, -90f));
			Landing2.transform.localScale = new Vector3(0.3858376f, 0.2030577f, 0.2256523f);
			Landing3 = Object.Instantiate<GameObject>(Landing2, new Vector3(33.018f, 23.4f, -7.36f), Quaternion.Euler(90f, -180f, -90f));
			Landing4 = Object.Instantiate<GameObject>(Landing3, new Vector3(23.925f, 23.76141f, 8.734955f), Quaternion.Euler(67.5f, 0f, 0f));
			Landing5 = Object.Instantiate<GameObject>(Landing4, new Vector3(24.7408f, 22.98f, 6.94f), Quaternion.Euler(0f, 0f, 0f));
			Landing5.transform.localScale = new Vector3(0.29508865f, 0.20305766f, 0.22565232f);
			Landing2.transform.localScale = new Vector3(0.355f, 0.2030577f, 0.2256523f);
			Landing6 = Object.Instantiate<GameObject>(Landing4, new Vector3(22.09f, 22.9149f, 9.1875f), Quaternion.Euler(0f, 90f, 0f));
			Landing6.transform.localScale = new Vector3(0.23676343f, 0.196193f, 0.22565232f);
			NewLocationWindow = Object.Instantiate<GameObject>(GameObject.Find("Window"), new Vector3(20.61f, 24.948f, 1.13f), Quaternion.Euler(-89.701f, 0f, 90f));
			((Component)NewLocationWindow.transform.GetChild(0)).gameObject.SetActive(false);
			NewLocationWindow.tag = "Untagged";
			NewLocationWindow.transform.localScale = new Vector3(0.22565001f, 0.69672f, 0.22565f);
			TriggerIn = Object.Instantiate<GameObject>(GameObject.Find("TriggerSoundFadeOutToIn2"), new Vector3(29.72f, 18.5f, -6.74f), Quaternion.Euler(0f, 0f, 0f));
			TriggerIn.transform.localScale = new Vector3(0.67f, 0.86271995f, 7.93f);
			TriggerOut = Object.Instantiate<GameObject>(GameObject.Find("TriggerSoundFadeInToOut2"), new Vector3(33.118f, 18.13f, -9.612f), Quaternion.Euler(0f, 0f, 0f));
			TriggerOut.transform.localScale = new Vector3(2.76f, 1.05845f, 2.24f);
			WallTemplate = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/MeatBoxLock"), new Vector3(35.012f, 20.98f, -6.5981f), Quaternion.Euler(90f, 90f, 0f));
			Object.Destroy((Object)(object)WallTemplate.GetComponent<BoxCollider>());
			WallTemplate.AddComponent<MeshCollider>();
			WallTemplate.transform.SetParent((Transform)null);
			WallTemplate.transform.localScale = new Vector3(0.4247897f, 2.773236f, 0.2256523f);
			NewWall1 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(29.56401f, 29.5454f, -10.82339f), Quaternion.Euler(0f, -180f, 0f));
			NewWall1.transform.localScale = new Vector3(0.2256523f, 5.977657f, 0.2256523f);
			NewWall2 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.399f, 29.5642f, -6.5981f), Quaternion.Euler(0f, -90f, 0f));
			NewWall2.transform.localScale = new Vector3(0.4247897f, 5.987034f, 0.2256523f);
			NewWall3 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(25.63f, 29.64f, 8.72f), Quaternion.Euler(0f, 0f, 0f));
			NewWall3.transform.localScale = new Vector3(0.5972057f, 4.240109f, 0.2256523f);
			NewWall4 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35.01f, 29.64f, -6.6f), Quaternion.Euler(0f, 90f, 0f));
			NewWall4.transform.localScale = new Vector3(0.428291f, 4.240109f, 0.2256523f);
			NewWall39 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35.01f, 29.64f, 6.1415f), Quaternion.Euler(0f, 90f, 0f));
			NewWall39.transform.localScale = new Vector3(0.5243995f, 4.240109f, 0.2256523f);
			NewWall5 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(29.36f, 20.98f, -3.2103f), Quaternion.Euler(90f, 90f, 0f));
			NewWall5.transform.localScale = new Vector3(0.08610487f, 0.9988078f, 0.2256523f);
			NewWall6 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(33.44f, 29.55f, -10.82f), Quaternion.Euler(0f, 0f, 0f));
			NewWall6.transform.localScale = new Vector3(0.1626502f, 4.217835f, 0.2256523f);
			NewWall7 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35f, 20.98f, 3.1956f), Quaternion.Euler(90f, 90f, 0f));
			NewWall7.transform.localScale = new Vector3(0.553324f, 3.78f, 0.2256523f);
			NewWall7 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.44f, 21f, 3.1956f), Quaternion.Euler(90f, 90f, 0f));
			NewWall7.transform.localScale = new Vector3(0.553324f, 3.78f, 0.2256523f);
			NewWall8 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(23.614f, 29.64f, -2.35f), Quaternion.Euler(0f, -180f, 0f));
			NewWall8.transform.localScale = new Vector3(0.3836082f, 4.217835f, 0.2256523f);
			NewWall41 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(39.83f, 29.64f, -2.35f), Quaternion.Euler(0f, -180f, 0f));
			NewWall41.transform.localScale = new Vector3(0.4726436f, 4.217835f, 0.2256523f);
			NewWall9 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(33.3204f, 29.6698f, 8.72f), Quaternion.Euler(0f, 0f, 0f));
			NewWall9.transform.localScale = new Vector3(0.1721452f, 1.483542f, 0.2256523f);
			NewWall10 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(20.7f, 29.64f, 3.161f), Quaternion.Euler(0f, -90f, 0f));
			NewWall10.transform.localScale = new Vector3(0.5557364f, 4.240109f, 0.2256523f);
			NewWall11 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.36f, 29.64f, 4.8385f), Quaternion.Euler(0f, -90f, 0f));
			NewWall11.transform.localScale = new Vector3(0.3880104f, 4.240109f, 0.2256523f);
			NewWall12 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(20.72f, 28.3f, 3.2218f), Quaternion.Euler(-90f, 0f, 90f));
			NewWall12.transform.localScale = new Vector3(0.5559369f, 7.470623f, 0.2256523f);
			NewWall13 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.455f, 28.3f, -6.5657f), Quaternion.Euler(-90f, 0f, 90f));
			NewWall13.transform.localScale = new Vector3(0.42550254f, 3.7230446f, 0.2256523f);
			NewWall14 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.36f, 29.5f, -0.6955f), Quaternion.Euler(0f, -90f, 0f));
			NewWall14.transform.localScale = new Vector3(0.165886f, 1.146f, 0.2256523f);
			NewWall40 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35.02f, 29.5f, -0.6955f), Quaternion.Euler(0f, 90f, 0f));
			NewWall40.transform.localScale = new Vector3(0.165886f, 1.146f, 0.2256523f);
			NewWall15 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(27.29f, 29.2502f, -0.6203f), Quaternion.Euler(0f, -90f, 0f));
			NewWall15.transform.localScale = new Vector3(0.1730138f, 4.048881f, 0.2256523f);
			NewWall21 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(28.74f, 17.3145f, 4.1194f), Quaternion.Euler(0f, -90f, 0f));
			NewWall21.transform.localScale = new Vector3(0.4599087f, 3.7840984f, 0.2256523f);
			NewWall22 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(28.02f, 17.406f, 8.68f), Quaternion.Euler(0f, 0f, 0f));
			NewWall22.transform.localScale = new Vector3(0.37816483f, 3.7957041f, 0.2256523f);
			NewWall23 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(39.2958f, 17.4061f, 8.68f), Quaternion.Euler(0f, 0f, 0f));
			NewWall23.transform.localScale = new Vector3(0.4471799f, 3.7957041f, 0.2256523f);
			NewWall24 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35.991f, 20.9835f, 8.72f), Quaternion.Euler(0f, -180f, 0f));
			NewWall24.transform.localScale = new Vector3(0.77762043f, 1.813976f, 0.2256523f);
			NewWall25 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(35.991f, 17.2586f, -0.4f), Quaternion.Euler(0f, -180f, 0f));
			NewWall25.transform.localScale = new Vector3(0.7776204f, 3.198535f, 0.2256523f);
			NewWall26 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(43.73f, 17.3f, 4.11323f), Quaternion.Euler(-90f, -180f, 90f));
			NewWall26.transform.localScale = new Vector3(0.46682018f, 7.4706225f, 0.2256523f);
			NewWall27 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(43.73f, 11.68f, 4.11323f), Quaternion.Euler(90f, 90f, 0f));
			NewWall27.transform.localScale = new Vector3(0.46682018f, 7.4706225f, 0.2256523f);
			NewWall30 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(42.89f, 17.577f, 4.1735f), Quaternion.Euler(0f, 90f, 0f));
			NewWall30.transform.localScale = new Vector3(0.49164042f, 2.9776084f, 0.2256523f);
			DoorToFreeze = Object.Instantiate<GameObject>(GameObject.Find("GarderobDoorParent (1)/GarderobDoor"), new Vector3(24.82f, 23.27f, -1.87f), Quaternion.Euler(-10f, 0f, 0f));
			DoorToFreeze.tag = "Untagged";
			DoorToFreeze.transform.localScale = new Vector3(0.22894f, 0.22565f, 0.22565f);
			DoorToFreeze.transform.SetParent((Transform)null);
			((Collider)DoorToFreeze.GetComponent<BoxCollider>()).enabled = false;
			DoorToFreeze.AddComponent<MeshCollider>().convex = true;
			LiftTemplate = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/CellarFurniture/SafeDoor"), new Vector3(34.9947f, 21.02f, 8.882f), Quaternion.Euler(-90f, 0f, 0f));
			LiftTemplate.transform.SetParent((Transform)null);
			LiftTemplate.tag = "Untagged";
			LiftTemplate.transform.localScale = new Vector3(0.07987331f, 0.03751124f, 0.10595f);
			Lift1 = Object.Instantiate<GameObject>(LiftTemplate, new Vector3(31.58f, 21.02f, 11.2287f), Quaternion.Euler(-90f, 0f, -90f));
			Lift1.transform.localScale = new Vector3(0.06010428f, 0.03751124f, 0.1060783f);
			Lift2 = Object.Instantiate<GameObject>(LiftTemplate, new Vector3(31.571f, 26.73f, 11.0955f), Quaternion.Euler(0f, 90f, 180f));
			Lift2.transform.localScale = new Vector3(0.05696044f, 0.03751124f, 0.06862244f);
			Lift3 = Object.Instantiate<GameObject>(LiftTemplate, new Vector3(35.03f, 21.02f, 8.7126f), Quaternion.Euler(-90f, 0f, 90f));
			Lift3.transform.localScale = new Vector3(0.06010428f, 0.03751124f, 0.1056769f);
			Lift4 = Object.Instantiate<GameObject>(LiftTemplate, new Vector3(35.169f, 20.795f, 11.0955f), Quaternion.Euler(180f, 90f, 180f));
			Lift4.transform.localScale = new Vector3(0.05696044f, 0.03751124f, 0.06862244f);
			Lift5 = Object.Instantiate<GameObject>(LiftTemplate, new Vector3(34.9947f, 26.55f, 8.93f), Quaternion.Euler(-90f, 0f, 0f));
			Lift5.transform.localScale = new Vector3(0.07987331f, 0.037511252f, 0.17194632f);
			LiftTemplate.transform.SetParent(Lift4.transform);
			Lift1.transform.SetParent(Lift4.transform);
			Lift2.transform.SetParent(Lift4.transform);
			Lift3.transform.SetParent(Lift4.transform);
			Lift5.transform.SetParent(Lift4.transform);
			Indicator = Object.Instantiate<GameObject>(GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa"), new Vector3(32.8f, 27.4f, 8.68f), Quaternion.Euler(0f, -90f, 0f));
			Indicator.transform.SetParent((Transform)null);
			Indicator.transform.localScale = new Vector3(50f, 133f, 86f);
			Indicator.AddComponent<MeshCollider>().convex = true;
			((Object)Indicator).name = "TaskIndicator";
			IndicatorMeshRenderer = Indicator.GetComponent<MeshRenderer>();
			Indicator2 = Object.Instantiate<GameObject>(GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa"), new Vector3(33.8f, 27.4f, 8.68f), Quaternion.Euler(0f, -90f, 0f));
			Indicator2.transform.SetParent((Transform)null);
			Indicator2.transform.localScale = new Vector3(50f, 133f, 86f);
			Indicator2.AddComponent<MeshCollider>().convex = true;
			((Object)Indicator2).name = "TaskIndicator2";
			IndicatorMeshRenderer2 = Indicator2.GetComponent<MeshRenderer>();
			Button = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(34.784f, 24.162f, 9.69f), Quaternion.Euler(0f, 90f, 0f));
			Button.transform.SetParent((Transform)null);
			Button.transform.localScale = new Vector3(0.49f, 0.49f, 0.49f);
			Button.AddComponent<BoxCollider>();
			((Renderer)Button.GetComponent<MeshRenderer>()).material.color = Color.black;
			((Object)Button).name = "ButtonHole";
			Button.transform.SetParent(Lift4.transform);
			Hole = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(6.0614f, 23.4893f, 9.6515f), Quaternion.Euler(0f, 90f, 12.7f));
			Hole.transform.localScale = new Vector3(1.61478f, 1.5212116f, 2.6176345f);
			Hole.AddComponent<BoxCollider>();
			Hole.GetComponent<BoxCollider>().center = new Vector3(0f, 0f, 0.07162992f);
			((Renderer)Hole.GetComponent<MeshRenderer>()).material.color = Color.black;
			((Object)Hole).name = "HoleInWall";
			HoleInTheWall1 = Object.Instantiate<GameObject>(Hole, Hole.transform.position, Quaternion.Euler(0f, 90f, 55f));
			HoleInTheWall2 = Object.Instantiate<GameObject>(Hole, Hole.transform.position, Quaternion.Euler(0f, 90f, -46f));
			HoleInTheWall3 = Object.Instantiate<GameObject>(Hole, Hole.transform.position, Quaternion.Euler(0f, 90f, 128f));
			((Collider)HoleInTheWall1.GetComponent<BoxCollider>()).enabled = false;
			((Collider)HoleInTheWall2.GetComponent<BoxCollider>()).enabled = false;
			((Collider)HoleInTheWall3.GetComponent<BoxCollider>()).enabled = false;
			Hole2 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(24.048f, 23.816f, 8.659f), Quaternion.Euler(0f, 0f, 0f));
			Hole2.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
			((Renderer)Hole2.GetComponent<MeshRenderer>()).material.color = Color.black;
			TextObject = Object.Instantiate<GameObject>(GameObject.Find("AllSafeColliders/SafeCollider (1)"), new Vector3(34.325f, 28.11f, 5.93f), Quaternion.Euler(0f, 90f, 0f));
			Object.Destroy((Object)(object)TextObject.GetComponent<BoxCollider>());
			TextObject.transform.SetParent((Transform)null);
			TextObject.transform.localScale = new Vector3(4.06f, 3.37f, 2f);
			TextTask = TextObject.AddComponent<TextMesh>();
			TextTask.text = "Light blue - freeze yourself\r\nBlack - break the camera\r\nWhite - put the book on a pedestal\r\nPink - unlock the garage door\r\nYellow - use pepper spray 5 times\r\nOrange - put a cogwheel in the playhouse";
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				TextTask.text = "\r\nTo get a teleport conrol you need to\r\n\r\nfix the elevator\r\nOR\r\nfix the car";
			}
			TextTask.offsetZ = 0.31f;
			TextTask.characterSize = 0.01f;
			TextTask.fontSize = 199;
			TextTask.richText = true;
			TextObject.SetActive(false);
			TVText = Object.Instantiate<GameObject>(TextObject, new Vector3(-18.028f, 16.355f, -4.577f), Quaternion.Euler(0f, 0f, 0f));
			TVText.transform.localScale = new Vector3(0.77f, 0.67f, 2f);
			TVText.GetComponent<TextMesh>().text = "";
			TVText.GetComponent<TextMesh>().fontSize = 175;
			TVText.GetComponent<TextMesh>().color = Color.white;
			Object.Destroy((Object)(object)TVText.GetComponent<BoxCollider>());
			TVText.SetActive(false);
			TextVision = Object.Instantiate<GameObject>(GameObject.Find("Remotetrigger"), new Vector3(31.13f, 921.95f, -0.82f), Quaternion.Euler(-90f, 0f, 0f));
			TextVision.transform.SetParent((Transform)null);
			((Object)TextVision).name = "TasksText";
			TextVision.transform.localScale = new Vector3(6.8f, 18f, 1.2f);
			TVArea = Object.Instantiate<GameObject>(TextVision, new Vector3(-17.1f, 14.33f, -7.59f), Quaternion.Euler(-90f, 0f, 0f));
			((Object)TVArea).name = "TVArea";
			TVArea.transform.SetParent((Transform)null);
			TVArea.transform.localScale = new Vector3(8.07f, 11.42f, 1.2f);
			if (RandomTask == 1)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.cyan);
			}
			else if (RandomTask == 2)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.black);
			}
			else if (RandomTask == 3)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.white);
			}
			else if (RandomTask == 4)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.magenta);
			}
			else if (RandomTask == 5)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.yellow);
			}
			else if (RandomTask == 6)
			{
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", new Color(1f, 0.5f, 0f));
			}
			if (randomTask2 == 1)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.cyan);
			}
			else if (randomTask2 == 2)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.black);
			}
			else if (randomTask2 == 3)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.white);
			}
			else if (randomTask2 == 4)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.magenta);
			}
			else if (randomTask2 == 5)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.yellow);
			}
			else if (randomTask2 == 6)
			{
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", new Color(1f, 0.5f, 0f));
			}
			GameObject.Find("UsefulObjects/TextMessage").transform.position = new Vector3(33.7f, 23.41f, -4.9f);
			LiftMessage = Object.Instantiate<GameObject>(GameObject.Find("UsefulObjects/TextMessage"), new Vector3(32.577f, 25.205f, 10.743f), Quaternion.Euler(0f, 0f, 29.5f));
			LiftMessage.tag = "Untagged";
			((Object)LiftMessage).name = "LiftMessage";
			LiftMessage.transform.SetParent(Lift4.transform);
			GreenDrawer = GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda");
			((Renderer)GreenDrawer.GetComponent<MeshRenderer>()).material.color = new Color(0.2f, 1f, 0f);
			GreenDrawer.tag = "Untagged";
			((Object)GreenDrawer).name = "GreenDrawer";
			GreenDoor = GameObject.Find("All doors/GarderobDoorParent (2)/GarderobDoor");
			((Renderer)(MeshRenderer)GreenDoor.GetComponent(typeof(MeshRenderer))).material.shader = AbondonedShader;
			((Renderer)GreenDoor.GetComponent<MeshRenderer>()).material.color = new Color(0.2f, 1f, 0f);
			GreenDoor.tag = "Untagged";
			((Object)GreenDoor).name = "GreenDoor";
			CodeWall = Object.Instantiate<GameObject>(Lift1, new Vector3(-19.1f, 20.02f, -12.707f), Quaternion.Euler(-90f, 0f, -58.38f));
			((Behaviour)CodeWall.GetComponent<changeTextureNightmare>()).enabled = false;
			CodeWall.transform.localScale = new Vector3(0.08794458f, 0.037511244f, 0.098386124f);
			CodeWall.tag = "Untagged";
			Shelf1 = Object.Instantiate<GameObject>(Landing3, new Vector3(-19.9278f, 23.29f, -12.935f), Quaternion.Euler(90f, -90f, -90f));
			Shelf1.transform.localScale = new Vector3(-0.05f, 0.046459593f, 0.14198044f);
			Shelf2 = Object.Instantiate<GameObject>(Shelf1, new Vector3(-19.9278f, 24.15f, -12.935f), Quaternion.Euler(-90f, -90f, -90f));
			EscapeLamp1 = Object.Instantiate<GameObject>(GameObject.Find("HouseBakedReady/DoorLocks/LarmDosa/Larmlampa2"), new Vector3(26.7f, 23.3679f, 7.7403f), Quaternion.Euler(67.5f, 0f, 0f));
			EscapeLamp1.transform.SetParent((Transform)null);
			EscapeLamp1.transform.localScale = new Vector3(0.53199786f, 3.9838567f, 0.2256523f);
			EscapeLamp2 = Object.Instantiate<GameObject>(EscapeLamp1, new Vector3(26.1f, 23.3679f, 7.7403f), Quaternion.Euler(67.5f, 0f, 0f));
			EscapeLamp3 = Object.Instantiate<GameObject>(EscapeLamp1, new Vector3(25.5f, 23.3679f, 7.7403f), Quaternion.Euler(67.5f, 0f, 0f));
			EscapeLamp4 = Object.Instantiate<GameObject>(EscapeLamp1, new Vector3(24.9f, 23.3679f, 7.7403f), Quaternion.Euler(67.5f, 0f, 0f));
			Panel = Object.Instantiate<GameObject>(Lift3, new Vector3(27.2852f, 22.7994f, 7.0285f), Quaternion.Euler(-22.5f, 0f, 0f));
			Panel.transform.localScale = new Vector3(0.08375144f, 0.03671544f, 0.039442267f);
			((Object)Panel).name = "LiftPanel";
			((Collider)Panel.GetComponent<BoxCollider>()).enabled = false;
			Panel.AddComponent<MeshCollider>().convex = true;
			ImpossibleDoor = Object.Instantiate<GameObject>(Panel, new Vector3(35.1073f, 27.4408f, -2.4516f), Quaternion.Euler(0f, 0f, 90f));
			ImpossibleDoor.transform.localScale = new Vector3(0.15037468f, 0.010243609f, 0.104123116f);
			((Object)ImpossibleDoor).name = "ImpossibleDoor";
			ImpossibleDoorHand = Object.Instantiate<GameObject>(GameObject.Find("BloodyHand"), ImpossibleDoor.transform);
			ImpossibleDoorHand.transform.localPosition = new Vector3(-10.5f, 9.1f, 5.17f);
			ImpossibleDoorHand.transform.localRotation = Quaternion.Euler(0f, -55f, 0f);
			ImpossibleDoorHand.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			Object.Instantiate<GameObject>(ImpossibleDoorHand, ImpossibleDoor.transform).transform.localPosition = new Vector3(-16.35f, 9.1f, 8.48f);
			Object.Instantiate<GameObject>(ImpossibleDoorHand, ImpossibleDoor.transform).transform.localPosition = new Vector3(-20.54f, 9.1f, 4.82f);
			Object.Instantiate<GameObject>(ImpossibleDoorHand, ImpossibleDoor.transform).transform.localPosition = new Vector3(-5.21f, 9f, 7.47f);
			Object.Instantiate<GameObject>(ImpossibleDoorHand, ImpossibleDoor.transform).transform.localPosition = new Vector3(-26.57f, 9f, 5.7f);
			WirePlace = Object.Instantiate<GameObject>(Panel, new Vector3(24.53f, 23f, 7.148f), Quaternion.Euler(-22.5f, 0f, 0f));
			WirePlace.transform.localScale = new Vector3(0.012227038f, 0.03671544f, 0.017912477f);
			((Renderer)WirePlace.GetComponent<MeshRenderer>()).material.color = new Color(0.75f, 0.75f, 0.75f);
			((Object)WirePlace).name = "WirePlace";
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/Furniture/GameObject"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/KitchenFurniture/KitchenDoor2Parent (1)"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorL"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/VardagsrumFurniture/VitrinDoorR"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorL"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/HallFurniture/VitrinDoorR"));
			Object.Destroy((Object)(object)GameObject.Find("HouseBakedReady/CellarFurniture/CellarFurniture/Collider"));
			HideCrouchCollider1 = Object.Instantiate<GameObject>(GameObject.Find("HideTrigger (26)"), new Vector3(32.513153f, 18.35948f, -3.24f), Quaternion.Euler(0f, 90f, 0f));
			HideCrouchCollider1.transform.localScale = new Vector3(14.4f, 1.25165f, 6.2f);
			((Renderer)PictureOnPlace.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("All doors/SmallDoorParent/SmallDoor/RemoteLock/Lampa").GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)PictureOnPlace.GetComponent<MeshRenderer>()).material.color = new Color(1f, 1f, 1f);
			HideCrouchCollider2 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(28.357f, 1117.9f, -3.57f), Quaternion.Euler(0f, 90f, 0f));
			HideCrouchCollider2.transform.localScale = new Vector3(6.67f, 1.25165f, 2.1f);
			Object.Destroy((Object)(object)HideCrouchCollider2.GetComponent<hideCrouchButton>());
			((Collider)HideCrouchCollider2.GetComponent<BoxCollider>()).isTrigger = false;
			HideCrouchCollider3 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(1.2611513f, 20.520481f, -17.90914f), Quaternion.Euler(0f, 90f, 0f));
			HideCrouchCollider3.transform.localScale = new Vector3(0.23f, 6.54f, 5.7f);
			Object.Destroy((Object)(object)HideCrouchCollider3.GetComponent<hideCrouchButton>());
			((Collider)HideCrouchCollider3.GetComponent<BoxCollider>()).isTrigger = false;
			HideCrouchCollider4 = Object.Instantiate<GameObject>(HideCrouchCollider1, new Vector3(-0.493f, 10.59f, 5.291f), Quaternion.Euler(0f, 90f, 0f));
			HideCrouchCollider4.transform.localScale = new Vector3(0.49f, 0.1f, 8f);
			Object.Destroy((Object)(object)HideCrouchCollider4.GetComponent<hideCrouchButton>());
			((Collider)HideCrouchCollider4.GetComponent<BoxCollider>()).isTrigger = false;
			BlueDrawer = GameObject.Find("Loda2Parent (7)/ByroLoda");
			((Renderer)BlueDrawer.GetComponent<MeshRenderer>()).material.color = new Color(0f, 0.25f, 1f);
			BlueDrawer.tag = "Untagged";
			((Object)BlueDrawer).name = "BlueDrawer";
			BlueWall = Object.Instantiate<GameObject>(WallTemplate, new Vector3(-8.05373f, 19.031f, 4.823f), Quaternion.Euler(0f, -180f, 0f));
			BlueWall.transform.localScale = new Vector3(0.044771444f, 0.68800366f, 0.2256523f);
			((Renderer)BlueWall.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("GallerDoor").GetComponent<MeshRenderer>()).materials;
			BlueDoor = Object.Instantiate<GameObject>(GameObject.Find("KitchenLuckaOH"), new Vector3(-8.47f, 17.6417f, 3.508f), Quaternion.Euler(-90f, 0f, 0f));
			BlueDoor.transform.SetParent((Transform)null);
			BlueDoor.transform.localScale = new Vector3(1.5850912f, 65.521416f, 69.116005f);
			((Renderer)(MeshRenderer)BlueDoor.GetComponent(typeof(MeshRenderer))).material.color = new Color(0f, 0.15f, 1f);
			BlueDoor.tag = "Untagged";
			((Object)BlueDoor).name = "BlueDoor";
			GameObject.Find("Lekhus").tag = "Untagged";
			GameObject.Find("MeatBoxLock").transform.position = new Vector3(14.119f, 13.673f, -26.447f);
			GameObject.Find("MeatBoxLock").transform.localRotation = Quaternion.Euler(111.571f, 0f, 180f);
			GameObject.Find("CoffinBackyard").transform.localPosition = new Vector3(143.3f, -1.69f, -119.99f);
			GameObject.Find("PlayerOutsideCoffinPos").transform.localPosition = new Vector3(0.545f, -2.14f, -0.087f);
			NewWall31 = Object.Instantiate<GameObject>(WallTemplate, new Vector3(31.79f, 12.95f, -27f), Quaternion.Euler(0f, 70f, -90f));
			NewWall31.transform.localScale = new Vector3(0.11365516f, 0.6675702f, 0.22565235f);
			GameObject.Find("OuthouseDoor").transform.position = new Vector3(34.36f, 14.14f, -25.815f);
			GameObject.Find("OuthouseDoor").transform.rotation = Quaternion.Euler(-23.35f, 0f, 0f);
			GameObject.Find("OuthouseDoor").tag = "Untagged";
			GameObject.Find("OuthouseDoor").GetComponent<NavMeshObstacle>().carving = true;
			GameObject.Find("OuthouseDoor").GetComponent<NavMeshObstacle>().center = new Vector3(-6.62f, -2.13f, -0.45f);
			BoxHand = Object.Instantiate<GameObject>(GameObject.Find("BloodyHand"), new Vector3(12.16f, 13.525f, -25.82f), Quaternion.Euler(-197.3f, 143.5f, 165.3f));
			BoxHand.transform.localScale = new Vector3(0.04061742f, 0.12540483f, 0.040617038f);
			((Renderer)BoxHand.GetComponent<MeshRenderer>()).material.color = new Color(0.8181724f, 0.9433962f, 0.2091492f, 1f);
			GameObject.Find("GrannyHelaHuset/PlankaOH2").transform.localScale = new Vector3(0.4f, 0.1160192f, 0.1202292f);
			GameObject.Find("GrannyHelaHuset/PlankaOH2").tag = "Untagged";
			GameObject.Find("GrannyHelaHuset/PlankaOH1").SetActive(false);
			GameObject.Find("GrannyHelaHuset/PlankaOH3").SetActive(false);
			DoorHand = Object.Instantiate<GameObject>(GameObject.Find("BloodyHand"), new Vector3(-8.706f, 15.71f, -33.175f), Quaternion.Euler(90f, 0f, -90f));
			DoorHand.transform.localScale = new Vector3(0.055235166f, 0.17053667f, 0.055234656f);
			((Renderer)DoorHand.GetComponent<MeshRenderer>()).material.color = new Color(0.2f, 0.1f, 0f, 1f);
			DoorHand.transform.SetParent(GameObject.Find("PlankaOH2").transform);
			Dit = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"), new Vector3(14.1315f, 12.7f, -27.1373f), Quaternion.Euler(90f, 0f, 0f));
			Dit.transform.localScale = new Vector3(10.875681f, 11.997717f, 0.49f);
			((Renderer)Dit.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("EscapeTunnel").GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)Dit.GetComponent<MeshRenderer>()).material.color = new Color(0.3f, 0.3f, 0.3f);
			Dit.AddComponent<BoxCollider>();
			PlankaHighlightReady = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, new Vector3(33.241f, 16.1026f, -12.3376f), Quaternion.Euler(-133.626f, 0f, 0f));
			PlankaHighlightReady.transform.localScale = new Vector3(0.0415763f, 0.030697452f, 0.0415763f);
			PlankaHighlightReady.transform.SetParent((Transform)null);
			PlankaHighlightReady.SetActive(false);
			TVTextMesh = TVText.GetComponent<TextMesh>();
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				Object.Instantiate<GameObject>(WallTemplate, new Vector3(11.1631f, 3.9316f, -3.7335f), Quaternion.Euler(0f, 0f, 180f)).transform.localScale = new Vector3(0.035295457f, 0.4666402f, 0.11106609f);
				Object.Instantiate<GameObject>(WallTemplate, new Vector3(11.1631f, 3.9316f, -4.513f), Quaternion.Euler(0f, 180f, 180f)).transform.localScale = new Vector3(0.035295457f, 0.4666402f, 0.11106609f);
				Object.Instantiate<GameObject>(WallTemplate, new Vector3(11.167f, 3.9433f, -4.5209f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.034917794f, 0.38366973f, 0.12909621f);
				Object.Instantiate<GameObject>(WallTemplate, new Vector3(11.167f, 4.8493f, -4.5175f), Quaternion.Euler(90f, 0f, 180f)).transform.localScale = new Vector3(0.034917794f, 0.38366973f, 0.12909621f);
				GameObject val6 = Object.Instantiate<GameObject>(GameObject.Find("KitchenLuckaOH"), new Vector3(10.86f, 3.9721f, -4.51f), Quaternion.Euler(-90f, 0f, 0f));
				val6.transform.SetParent((Transform)null);
				val6.transform.localScale = new Vector3(1.5850911f, 37.555958f, 43.08361f);
				((Renderer)(MeshRenderer)val6.GetComponent(typeof(MeshRenderer))).material.color = new Color(0.45f, 0f, 0f);
				val6.tag = "Untagged";
				((Object)val6).name = "DarkDoor";
			}
			if (AnomalyNR == 4 || AnomalyNR == 32)
			{
				GameObject.Find("All doors").transform.position = new Vector3(0f, -1000f, 0f);
			}
			if (AnomalyNR == 5 || AnomalyNR == 9 || AnomalyNR == 12 || AnomalyNR == 14 || AnomalyNR == 24 || PrimeAnomalyNR == 7 || PrimeAnomalyNR == 12 || PrimeAnomalyNR == 14)
			{
				AnomalyTimer = Time.timeSinceLevelLoad;
			}
			if (PlayerPrefs.GetInt("randomNR") == 1)
			{
				GameObject.Find("UsefulObjects/RandomPlace1/Meat_PL1").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 2)
			{
				GameObject.Find("UsefulObjects/RandomPlace2/MelonPickUpPL2").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 3)
			{
				GameObject.Find("UsefulObjects/RandomPlace3/VapennyckelPL3").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 4)
			{
				GameObject.Find("UsefulObjects/RandomPlace4/CarBattery_PL4").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 5)
			{
				GameObject.Find("AvbitarePL5").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 6)
			{
				GameObject.Find("UsefulObjects/RandomPlace1/Bensindunk_PL1").transform.position = new Vector3(32.86f, 21.04f, 9.69f);
				GameObject.Find("UsefulObjects/RandomPlace1/Bensindunk_PL1").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 7)
			{
				GameObject.Find("UsefulObjects/RandomPlace5/BrunnsVevPickupPL5").transform.SetParent(Lift4.transform);
			}
			if (PlayerPrefs.GetInt("randomNR") == 8)
			{
				GameObject.Find("Topplock_PL1").transform.SetParent(Lift4.transform);
			}
		}
	}

	public virtual void Update()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_125b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1275: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Unknown result type (might be due to invalid IL or missing references)
		//IL_171b: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1744: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Unknown result type (might be due to invalid IL or missing references)
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1795: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17be: Unknown result type (might be due to invalid IL or missing references)
		//IL_1896: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1902: Unknown result type (might be due to invalid IL or missing references)
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_194c: Unknown result type (might be due to invalid IL or missing references)
		//IL_195c: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1add: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1648: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1684: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
		if (Input.GetKeyDown((KeyCode)98) && PlayerPrefs.GetInt("BRestartOnOff") == 1)
		{
			if (GrannyGauntlet)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 0);
			}
			Time.timeScale = 1f;
			SceneManager.LoadScene("Scene");
		}
		if (Input.GetKey((KeyCode)104) && PlayerPrefs.GetInt("PrimeOn") == 0)
		{
			Player.transform.position = new Vector3(15.33f, 20.41f, -7.16f);
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			float num = 0f;
			if (PrimeAnomalyNR != 6 && PrimeAnomalyNR != 8 && PrimeAnomalyNR != 9 && PrimeAnomalyNR != 13 && PrimeAnomalyNR != 18)
			{
				float num2 = (float)ProgressValue / 87f * 50f;
				if (num2 > 50f)
				{
					num2 = 50f;
				}
				float val = (float)ProgressCar / 36f * 48f;
				float val2 = (float)ProgressLift / 48f * 48f;
				float num3 = Math.Max(val, val2);
				if (num3 > 48f)
				{
					num3 = 48f;
				}
				num = (float)Math.Round(num2 + num3, 0);
			}
			else if (PrimeAnomalyNR == 6)
			{
				float num4 = (float)ProgressValue / 91f * 99f;
				if (num4 > 99f)
				{
					num4 = 99f;
				}
				float val3 = (float)ProgressCar / 42f * 99f;
				float val4 = (float)ProgressLift / 48f * 99f;
				float num5 = Math.Max(val3, Math.Max(val4, num4));
				if (num5 > 99f)
				{
					num5 = 99f;
				}
				num = (float)Math.Round(num5, 0);
			}
			else if (PrimeAnomalyNR == 8)
			{
				float num6 = (float)ProgressValue / 81f * 48f;
				if (num6 > 48f)
				{
					num6 = 49f;
				}
				float val5 = (float)ProgressCar / 30f * 48f;
				float val6 = (float)ProgressLift / 48f * 48f;
				float num7 = Math.Max(val5, val6);
				if (num7 > 48f)
				{
					num7 = 48f;
				}
				num = (float)Math.Round(num6 + num7, 0);
			}
			else if (PrimeAnomalyNR == 9)
			{
				float num8 = (float)ProgressValue / 91f * 30f;
				if (num8 > 30f)
				{
					num8 = 30f;
				}
				float num9 = (float)ProgressCar / 36f * 30f;
				float num10 = (float)ProgressLift / 48f * 30f;
				float num11 = num9 + num10 + (float)ProgressBehavior;
				if (num11 > 69f)
				{
					num11 = 69f;
				}
				num = (float)Math.Round(num8 + num11, 0);
			}
			else if (PrimeAnomalyNR == 13)
			{
				float num12 = (float)ProgressValue / 67f * 43f;
				if (num12 > 43f)
				{
					num12 = 43f;
				}
				float val7 = (float)ProgressCar / 36f * 43f;
				float val8 = (float)ProgressLift / 48f * 43f;
				float num13 = Math.Max(val7, val8);
				if (num13 > 43f)
				{
					num13 = 43f;
				}
				num = (float)Math.Round(num12 + num13 + (float)ProgressBehavior, 0);
			}
			else if (PrimeAnomalyNR == 18)
			{
				float num14 = (float)ProgressValue / 95f * 48f;
				if (num14 > 48f)
				{
					num14 = 49f;
				}
				float val9 = (float)ProgressCar / 36f * 48f;
				float val10 = (float)ProgressLift / 48f * 48f;
				float num15 = Math.Max(val9, val10);
				if (num15 > 48f)
				{
					num15 = 48f;
				}
				num = (float)Math.Round(num14 + num15, 0);
			}
			if (num > 99f)
			{
				num = 99f;
			}
			if (!EveryBeginAchievement && num >= 25f)
			{
				EveryBeginAchievement = true;
				AchievementSaveManager.Instance.UnlockAchievement("EveryBegin");
			}
			if (!PrisonerOfPrimeAchievement && num >= 60f)
			{
				PrisonerOfPrimeAchievement = true;
				AchievementSaveManager.Instance.UnlockAchievement("PrionerOfPrime");
			}
			if (!SoCloseAchievement && num >= 90f)
			{
				SoCloseAchievement = true;
			}
			string text = "";
			string text2 = "";
			if (PlayerPrefs.GetInt("ShowProgressOnOff") == 1)
			{
				text = (AllProgress ? "100%" : (num + "%"));
			}
			if (PlayerPrefs.GetInt("PrimeOn") == 0)
			{
				text2 = "Training mode is on\r\n";
			}
			AnomalyCommentText.GetComponent<Text>().text = text2 + text;
		}
		if (PlayerPrefs.GetInt("ShowProgressOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
		{
			if (AnomalyNR == 11)
			{
				float num16 = (float)ProgressValue / (float)ProgressDoorPreset * 33f;
				if (num16 > 33f)
				{
					num16 = 33f;
				}
				float num17 = (float)ProgressCar / 42f * 33f;
				float num18 = (float)ProgressLift / 48f * 33f;
				float num19 = num17 + num18;
				if (num19 > 66f)
				{
					num19 = 66f;
				}
				Math.Round(num16 + num19, 0);
			}
			else if (AnomalyNR == 18)
			{
				float num20 = 0f;
				string text3 = "";
				string text4 = "";
				float val11 = (float)ProgressValue / 50f * 100f;
				float num21 = Math.Max((float)ProgressLift / 30f * 100f, val11);
				if (num21 > 99f)
				{
					num21 = 99f;
				}
				num20 = (float)Math.Round(num21, 0);
				text3 = (AllProgress ? "100%" : (num20 + "%"));
				AnomalyCommentText.GetComponent<Text>().text = text4 + text3;
			}
			else if (AnomalyNR == 13 || AnomalyNR == 27 || AnomalyNR == 36 || PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1)
			{
				AnomalyCommentText.GetComponent<Text>().text = "???%";
			}
			else
			{
				float num22 = 0f;
				string text5 = "";
				string text6 = "";
				float num23 = (float)ProgressValue / (float)ProgressDoorPreset * 100f;
				if (num23 > 99f)
				{
					num23 = 99f;
				}
				float val12 = (float)ProgressCar / 42f * 100f;
				float val13 = (float)ProgressLift / 48f * 100f;
				float num24 = Math.Max(val12, Math.Max(val13, num23));
				if (num24 > 99f)
				{
					num24 = 99f;
				}
				num22 = (float)Math.Round(num24, 0);
				text5 = (AllProgress ? "100%" : (num22 + "%"));
				AnomalyCommentText.GetComponent<Text>().text = text6 + text5;
			}
		}
		if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1 && !StopTimerCount && !AllProgress)
		{
			TimerPrimeSec += Time.deltaTime;
			if (TimerPrimeSec >= 60f)
			{
				TimerPrimeSec = 0f;
				TimerPrimeMin++;
			}
			if (TimerPrimeMin >= 60f)
			{
				TimerPrimeMin = 0f;
				TimerPrimeHour++;
			}
			string text7 = TimerPrimeHour + ":";
			if (TimerPrimeHour < 10f)
			{
				text7 = "0" + TimerPrimeHour + ":";
			}
			string text8 = TimerPrimeMin + ":";
			if (TimerPrimeMin < 10f)
			{
				text8 = "0" + TimerPrimeMin + ":";
			}
			string text9 = string.Concat((float)Math.Floor(TimerPrimeSec));
			if (TimerPrimeSec < 10f)
			{
				text9 = "0" + (float)Math.Floor(TimerPrimeSec);
			}
			string text10 = "";
			if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1)
			{
				text10 = text7 + text8 + text9 + "\r\n";
			}
			string text11 = "";
			TimerText.GetComponent<Text>().text = text10 + text11;
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			if (hintIsActive && hintUse < 4)
			{
				HintText.GetComponent<Text>().text = "Get a hint (" + (3 - hintUse) + "/3)";
				if (EventBooks == 8)
				{
					EventCommentText.GetComponent<Text>().text = string.Concat((float)Math.Round(Vector3.Distance(Player.transform.position, gameController.GetComponent<InventoryController>().LostKeyItem.transform.position) / 2.64f, 2));
				}
				else
				{
					EventCommentText.GetComponent<Text>().text = string.Concat((float)Math.Round(Vector3.Distance(Player.transform.position, GameObject.FindGameObjectWithTag("book").transform.position) / 2.64f, 2));
				}
			}
			else if (hintIsActive && hintUse == 4)
			{
				HintText.GetComponent<Text>().text = "Get a hint (0/3)";
				EventCommentText.GetComponent<Text>().text = "You have no more hints!";
			}
			else
			{
				EventCommentText.GetComponent<Text>().text = "";
			}
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			EventChallenge3Text.GetComponent<Text>().text = string.Concat(InventoryControllerScript.EatingCounter);
		}
		if (!SetPadlockParent && AnomalyNR != 18 && AnomalyNR != 27 && AnomalyNR != 36 && PlayerPrefs.GetInt("EventChallenge1") != 1 && PlayerPrefs.GetInt("EventChallenge2") != 1 && PlayerPrefs.GetInt("EventChallenge3") != 1 && PrimeAnomalyNR != 18)
		{
			GameObject.Find("NewPadlock").transform.SetParent(CodeWall.transform);
			if (saveRandomNR)
			{
				PlayerPrefs.SetInt("randomNR", 100);
			}
			if (saveInOrder)
			{
				PlayerPrefs.SetInt("randomNR", 99);
			}
			SetPadlockParent = true;
		}
		if (!allaTavelbitarOnPlace && tavelbit1 && tavelbit2 && tavelbit3 && tavelbit4 && AnomalyNR == 13)
		{
			Anomaly13Puzzle++;
			GameObject.Find("TB1OnPlace").SetActive(false);
			GameObject.Find("TB2OnPlace").SetActive(false);
			GameObject.Find("TB3OnPlace").SetActive(false);
			GameObject.Find("TB4OnPlace").SetActive(false);
			tavelbit1 = false;
			tavelbit2 = false;
			tavelbit3 = false;
			tavelbit4 = false;
			if (Anomaly13Puzzle == 1)
			{
				AchievementSaveManager.Instance.UnlockAchievement("BonusDayEnjoyer");
				tavelBitPlace2.SetActive(true);
			}
			if (Anomaly13Puzzle == 2)
			{
				tavelBitPlace3.SetActive(true);
			}
			if (Anomaly13Puzzle == 3)
			{
				PlayerPrefs.SetInt("Anomaly13Escape", 1);
				SceneManager.LoadScene("EndScene");
			}
		}
		else if (!allaTavelbitarOnPlace && tavelbit1 && tavelbit2 && tavelbit3 && tavelbit4 && PrimeAnomalyNR == 13)
		{
			Anomaly13Puzzle++;
			GameObject.Find("TB1OnPlace").SetActive(false);
			GameObject.Find("TB2OnPlace").SetActive(false);
			GameObject.Find("TB3OnPlace").SetActive(false);
			GameObject.Find("TB4OnPlace").SetActive(false);
			tavelbit1 = false;
			tavelbit2 = false;
			tavelbit3 = false;
			tavelbit4 = false;
			if (Anomaly13Puzzle == 1)
			{
				AchievementSaveManager.Instance.UnlockAchievement("BonusDayEnjoyer");
				tavelBitPlace2.SetActive(true);
				ThisMadeMeThinkAchievementFail = true;
			}
			if (Anomaly13Puzzle == 2)
			{
				tavelBitPlace3.SetActive(true);
			}
			if (Anomaly13Puzzle == 3)
			{
				PrimeAnomaly13Grates.SetActive(false);
			}
		}
		if (LiftDoor == 11f && !ButtonIsPressed)
		{
			LiftTemplate.transform.position = new Vector3(34.9947f, 21.02f, LiftDoor);
			((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.green);
			((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.green);
			if (!getProgress)
			{
				ProgressLift += 6;
				getProgress = true;
			}
		}
		if (AnomalyNR == 9)
		{
			if (!DiedByAnomaly)
			{
				AnomalyTimerText.text = "You have " + (float)Math.Ceiling(90f - Time.timeSinceLevelLoad + AnomalyTimer) + " seconds to feed the crow!";
			}
			else
			{
				AnomalyTimerText.text = "";
			}
		}
		if (AnomalyNR == 12)
		{
			if (Time.timeSinceLevelLoad - AnomalyTimer < 480f)
			{
				AnomalyTimerText.text = "You have " + (float)Math.Ceiling(480f - Time.timeSinceLevelLoad + AnomalyTimer) + " seconds to escape!";
			}
			else
			{
				AnomalyTimerText.text = "";
			}
		}
		if (AnomalyNR == 14 || PrimeAnomalyNR == 14)
		{
			AnomalyTimerText.text = "An item will slip from your hand in " + (float)Math.Ceiling(10f - Time.timeSinceLevelLoad + AnomalyTimer) + " seconds!";
		}
		if (AnomalyNR == 24)
		{
			if (EnemyAIGrannyScript.Anomaly24Kef < 3f)
			{
				AnomalyTimerText.text = "Granny will be faster by 1% in " + (float)Math.Ceiling(4f - Time.timeSinceLevelLoad + AnomalyTimer) + " seconds!";
			}
			else
			{
				AnomalyTimerText.text = "";
			}
		}
		if (AnomalyNR == 36)
		{
			if (Anomaly36BeginFindingItems)
			{
				AnomalyTimerText.text = "You have collected " + Anomaly36ItemsCollected + "/6 items!";
			}
			else
			{
				AnomalyTimerText.text = "";
			}
		}
		if (AnomalyNR == 98 && Time.timeScale == 1f)
		{
			Time.timeScale = 3f;
		}
		if (AnomalyNR == 9 && Time.timeSinceLevelLoad - AnomalyTimer > 90f)
		{
			if (!DiedByAnomaly)
			{
				GameObject.Find("CrowParent").SetActive(false);
			}
			EnemyAIGrannyScript.playerHaveTeddy = true;
			EnemyAIGrannyScript.spiderIsDead = true;
			DiedByAnomaly = true;
		}
		if (AnomalyNR == 12 && Time.timeSinceLevelLoad - AnomalyTimer > 480f && Object.op_Implicit((Object)(object)GameObject.Find("Player")))
		{
			((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).gameOverNoGranny());
			joystick.SetActive(false);
		}
		if ((AnomalyNR == 14 || PrimeAnomalyNR == 14) && Time.timeSinceLevelLoad - AnomalyTimer > 10f)
		{
			AnomalyTimer += 10f;
			InventoryControllerScript.CheckInventory();
		}
		if (AnomalyNR == 24 && Time.timeSinceLevelLoad - AnomalyTimer > 4f && !Anomaly24PlayerInTrap)
		{
			AnomalyTimer += 4f;
			EnemyAIGrannyScript.Anomaly24Trap();
		}
		if (PicturePlaced && !MovinsIsOver)
		{
			NewWall15.transform.Translate(2f * Time.deltaTime, 0f, 0f);
			((Renderer)PictureOnPlace.GetComponent<MeshRenderer>()).material.mainTexture = OrigPicture;
			if (NewWall15.transform.position.z >= 2.8f)
			{
				MovinsIsOver = true;
			}
		}
		if (pinCodeIsUsed && !MovingIsOver2)
		{
			CodeWall.transform.Translate(-2f * Time.deltaTime, 0f, 0f);
			if (CodeWall.transform.position.x <= -62f)
			{
				MovingIsOver2 = true;
			}
		}
		if (SewerGallerOpen && !MovingIsOver3)
		{
			Galler3.transform.Translate(0f, 2f * Time.deltaTime, 0f);
			if (Galler3.transform.position.y >= 12.55f)
			{
				MovingIsOver3 = true;
			}
		}
		if (ButtonIsPressed && !MovingIsOverLift)
		{
			Lift4.transform.Translate(0f, -0.9f * Time.deltaTime, 0f);
			if (Lift4.transform.position.y <= 11.5f)
			{
				MovingIsOverLift = true;
				TextTask.text = "You missed an opportunity to escape :/";
				((Renderer)IndicatorMeshRenderer).material.SetColor("_Color", Color.red);
				((Renderer)IndicatorMeshRenderer2).material.SetColor("_Color", Color.red);
				if (PlayerPrefs.GetInt("DiffData") == 7 && PrimeAnomalyNR != 6)
				{
					Object.Instantiate<GameObject>(InventoryControllerScript.newTeleportRemote, new Vector3(33.32f, 26.48f, 8.58f), Quaternion.Euler(0f, 90f, -90f));
					if (PrimeAnomalyNR == 9)
					{
						Object.Instantiate<GameObject>(InventoryControllerScript.newPrimeRedKey, new Vector3(31f, 26.48f, 8.58f), Quaternion.Euler(-90f, 0f, 0f));
					}
				}
			}
		}
		if (knowPinCode && AnomalyNR == 18)
		{
			Anomaly18Screw.SetActive(false);
			knowPinCode = false;
		}
		if (channelCount == 1)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 1: Traveling\r\nSummer is coming\r\nsoon, and that means\r\nyou can visit the\r\nmagnificent country of\r\nGabon. Exciting coastal\r\ntours with the best service\r\nawait you. Hurry up and\r\nbuy our tours!";
			TVTextMesh.color = Color.white;
		}
		else if (channelCount == 2)
		{
			TVTextMesh.fontSize = 175;
			TVTextMesh.text = "Channel 2: Q&A\r\nQ: Where is a green\r\nkey?\r\nA: The green key was\r\nin Granny's pocket,\r\nbut one day she\r\naccidentally dropped it\r\non the floor";
			if (AnomalyNR == 18)
			{
				TVTextMesh.text = "Channel 2: Q&A\r\nQ: Where is a green\r\nkey?\r\nA: The green key is\r\nin Granny's pocket";
			}
			if (AnomalyNR == 36)
			{
				TVTextMesh.text = "Channel 2: Q&A\r\nQ: Where is a green\r\nkey?\r\nA: The green key is\r\nin the playhouse";
			}
		}
		else if (channelCount == 3)
		{
			TVTextMesh.text = "Channel 3: News\r\nAn unidentified elderly\r\nman stole a helicopter\r\nfrom a military base\r\nand fled in an unknown\r\ndirection. He is wanted\r\nby the police.";
		}
		else if (channelCount == 4)
		{
			TVTextMesh.text = "Channel 4:\r\nThe pin code is\r\n2134";
			if (AnomalyNR == 18)
			{
				TVTextMesh.text = "Channel 4:\r\nThe bar is\r\nremoved and new\r\nitems have appeared!";
				Anomaly18Shotgun1.SetActive(true);
				Anomaly18Shotgun2.SetActive(true);
				Anomaly18Shotgun3.SetActive(true);
				Anomaly18Screwdriver.SetActive(true);
			}
			if (AnomalyNR == 36)
			{
				TVTextMesh.text = "Channel 4: New\r\nitems have appeared!";
				Anomaly36SecretItems.SetActive(true);
			}
			knowPinCode = true;
		}
		else if (channelCount == 5)
		{
			TVTextMesh.text = "Channel 5: Q&A\r\nQ: Where is a blue\r\nkey?\r\nA: The blue key is\r\nmagnetized to one of\r\nthe ceilings in the\r\nhouse. To get the key,\r\nyou need to disable the\r\nmagnet using the\r\nremote control.";
			TVTextMesh.fontSize = 150;
			if (AnomalyNR == 18 || AnomalyNR == 36)
			{
				TVTextMesh.text = "Channel 5: Secret\r\nanomaly?\r\nError_1405\r\nError_1405\r\nError_1405\r\nError_1405\r\nError_1405\r\nError_1405";
				TVTextMesh.fontSize = 175;
			}
		}
		else if (channelCount == 6)
		{
			TVTextMesh.fontSize = 175;
			TVTextMesh.text = "Channel ###: Settings\r\nDifficulty:" + DiffTV + "\r\nNightmare walls: " + NigthmarewallsTV + "\r\nNightmare: " + NigthmareTV + "\r\nPreset: " + PresetTV + "\r\nAnomaly: " + AnomalyTV;
		}
		else if (channelCount == 7)
		{
			channelCount = 1;
		}
		else if (channelCount == 10)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 0:\r\nGranny, your victim\r\nescaped through\r\nan unknown passage!\r\n\r\nIt's time to look for a new\r\nvictim...";
			TVTextMesh.color = Color.red;
		}
		else if (channelCount == 11)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 0:\r\nGranny, while you were\r\naway from home,\r\nthe victim seized\r\nthe moment and ran away\r\nthrough a passage\r\nunknown to you!";
			TVTextMesh.color = Color.red;
		}
		else if (channelCount == 18)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 0: Granny, the\r\nperson who came to you\r\nfrom the future, has\r\nescaped through one of the\r\nalternative exits. You can\r\ncontinue building the house\r\nfor new victims...";
			TVTextMesh.color = Color.magenta;
		}
		else if (channelCount == 19)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 0:\r\nGranny, everything is fine.\r\nThe crow is now alive and\r\nwell. The victim is still in\r\nthe house, you just need\r\nto find him...";
			TVTextMesh.color = Color.magenta;
		}
		else if (channelCount == 12)
		{
			TVTextMesh.fontSize = 150;
			TVTextMesh.text = "Channel 0:\r\nGranny, your victim not\r\nonly escaped, but also\r\ntook Teddy with them!\r\n\r\nYou need to go outside\r\nand look for him as soon\r\nas possible to take your\r\nrevenge!!!";
			TVTextMesh.color = Color.red;
		}
		if (AnomalyNR == 21)
		{
			if (Object.op_Implicit((Object)(object)GameObject.Find("Vas")))
			{
				Anomaly21DropPoint.transform.position = new Vector3(GameObject.Find("Vas").transform.position.x, GameObject.Find("Vas").transform.position.y + 1f, GameObject.Find("Vas").transform.position.z);
			}
			if (Object.op_Implicit((Object)(object)GameObject.Find("Vas(Clone)")))
			{
				Anomaly21DropPoint.transform.position = new Vector3(GameObject.Find("Vas(Clone)").transform.position.x, GameObject.Find("Vas(Clone)").transform.position.y + 1f, GameObject.Find("Vas(Clone)").transform.position.z);
			}
		}
		else if (AnomalyNR == 30)
		{
			Anomaly30Text.transform.LookAt(((Component)playerCam).transform);
			Anomaly30Text.transform.Rotate(0f, 180f, 0f);
		}
		else if (AnomalyNR == 46)
		{
			if (buffCameraAnomaly46)
			{
				Anomaly46FOV += 0.5f * Time.deltaTime;
			}
			else
			{
				Anomaly46FOV -= 0.5f * Time.deltaTime;
			}
			if (Anomaly46FOV >= 140f)
			{
				buffCameraAnomaly46 = false;
			}
			if (Anomaly46FOV <= 10f)
			{
				buffCameraAnomaly46 = true;
			}
		}
		if (PrimeAnomalyNR == 1)
		{
			if ((float)Math.Round(Vector3.Distance(Player.transform.position, Granny.transform.position) / 2.64f - 1f, 2) < 4f)
			{
				playerCrawlScript.SpeedStandUp = 5f;
				playerCrawlScript.SpeedCrouch = 2.5f;
			}
			else
			{
				playerCrawlScript.SpeedStandUp = 20f / (float)Math.Round(Vector3.Distance(Player.transform.position, Granny.transform.position) / 2.64f - 1f, 2);
				playerCrawlScript.SpeedCrouch = 10f / (float)Math.Round(Vector3.Distance(Player.transform.position, Granny.transform.position) / 2.64f - 1f, 2);
			}
		}
		else if (PrimeAnomalyNR == 2)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				if ((float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) < 5f)
				{
					RenderSettings.fogColor = new Color((float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f, (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f, (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f);
				}
				else
				{
					RenderSettings.fogColor = Color.white;
				}
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				if ((float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) < 5f)
				{
					RenderSettings.fogColor = new Color((float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f * 0.6f, 0f, (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f * 0.1f);
				}
				else
				{
					RenderSettings.fogColor = new Color(0.6f, 0f, 0.1f);
				}
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
			{
				if ((float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) < 5f)
				{
					RenderSettings.fogColor = new Color(1f - (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f, 1f - (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f, 1f - (float)Math.Round(Vector3.Distance(Player.transform.position, EvilChair.transform.position) / 2.64f - 1f, 2) / 5f);
				}
				else
				{
					RenderSettings.fogColor = Color.black;
				}
			}
		}
		else if (PrimeAnomalyNR == 7)
		{
			PrimeAnomaly7Timer += Time.deltaTime;
			if (PrimeAnomaly7Timer >= 60f)
			{
				AnomalyTimerText.text = "";
				PrimeAnomaly7CantDrop = false;
			}
			else
			{
				AnomalyTimerText.text = "You can drop an item in " + (float)Math.Round(60f - PrimeAnomaly7Timer, 0) + " seconds!";
				PrimeAnomaly7CantDrop = true;
			}
		}
		else if (PrimeAnomalyNR == 11)
		{
			PrimeAnomaly7Timer += Time.deltaTime;
			if (PrimeAnomaly7Timer >= 120f)
			{
				((Renderer)Object.Instantiate<GameObject>(BaloonEvilChairExample, new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
				((Renderer)Object.Instantiate<GameObject>(BaloonEvilChairExample, new Vector3(Random.Range(7.15f, 33.59f), 30f, Random.Range(-26.3f, -13.83f)), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
				((Renderer)Object.Instantiate<GameObject>(BaloonEvilChairExample, new Vector3(Random.Range(7.15f, 33.59f), 40f, Random.Range(-26.3f, -13.83f)), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
				PrimeAnomaly7Timer = 0f;
			}
		}
		else if (PrimeAnomalyNR == 12)
		{
			PrimeAnomaly7Timer += Time.deltaTime;
			if (PrimeAnomaly7Timer < 480f)
			{
				AnomalyTimerText.text = "Evil chair will become a bomber in " + (float)Math.Round(480f - PrimeAnomaly7Timer, 0) + " seconds!";
			}
			else
			{
				AnomalyTimerText.text = "";
			}
			if (PrimeAnomaly7Timer >= 480f && Anomaly12Buff)
			{
				GameObject.Find("Rat1").GetComponent<ratController>().Anomaly12 = true;
				((Component)crouchButton.transform.GetChild(0)).GetComponent<playerCrawl>().Anomaly12Buff = false;
				((Renderer)EvilChair.GetComponent<MeshRenderer>()).material.mainTexture = Anomaly12BomberTexture;
				Anomaly12Buff = false;
			}
		}
	}

	public virtual IEnumerator FadeText1(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day1).color;
			color.a = a;
			((Graphic)day1).color = color;
			((Graphic)AnomalyText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText2(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day2).color;
			color.a = a;
			((Graphic)day2).color = color;
			((Graphic)AnomalyText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText3(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day3).color;
			color.a = a;
			((Graphic)day3).color = color;
			((Graphic)AnomalyText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText4(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day4).color;
			color.a = a;
			((Graphic)day4).color = color;
			((Graphic)AnomalyText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText5(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day5).color;
			color.a = a;
			((Graphic)day5).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText5LD(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day5LastDay).color;
			color.a = a;
			((Graphic)day5LastDay).color = color;
			((Graphic)AnomalyText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeText6(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)day6).color;
			color.a = a;
			((Graphic)day6).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator FadeJoy(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)joystickTexture).color;
			color.a = a;
			((Graphic)joystickTexture).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator newDay()
	{
		Player.GetComponent<FPSControllerNEW>().playerIsDying = false;
		openDoorsScript.canJumpIn = false;
		openDoorsScript.canJumpOut = true;
		if (AnomalyNR == 9 || AnomalyNR == 11 || AnomalyNR == 12 || ((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyAbility || AnomalyNR == 30 || AnomalyNR == 32 || AnomalyNR == 37)
		{
			StopTimerCount = true;
			if (GrannyGauntlet)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 0);
			}
			if (AnomalyNR == 18)
			{
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
			else if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).gameOverNoGranny());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 0)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene4();
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 1)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 2);
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene3());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 2)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 3);
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene2());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 3)
			{
				if (PlayerPrefs.GetInt("NoScreamersOnOff") == 0)
				{
					PlayerPrefs.SetInt("DiffGOsceneData", 0);
					((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene());
				}
				else
				{
					PlayerPrefs.SetInt("DiffGOsceneData", 1);
					((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene4();
				}
			}
			yield break;
		}
		daysCounter++;
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			RenderSettings.fogColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			((Component)playerCam).GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
			((Component)GameObject.Find("CamOutdoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
			((Component)GameObject.Find("CamIndoorParent").transform.GetChild(0)).gameObject.GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
		}
		if (daysCounter == 2f)
		{
			if (PlayerPrefs.GetInt("DiffData") == 7 && PrimeAnomalyNR != 14)
			{
				if (SoCloseAchievement)
				{
					AchievementSaveManager.Instance.UnlockAchievement("SoClose");
				}
				CheckNewBest();
				SceneManager.LoadScene("Scene");
				yield break;
			}
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)(object)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			AnomalyText.SetActive(true);
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText2(0f, 1f, 2f));
			yield return (object)new WaitForSeconds(2f);
			if (!slendrinaAppeard && Object.op_Implicit((Object)(object)GameObject.Find("Teddy(Clone)")))
			{
				Object.Destroy((Object)(object)GameObject.Find("Teddy(Clone)"));
				Object.Instantiate<GameObject>(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("Teddy(Clone)").transform).name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText2(1f, 0f, 2f));
			day2Text.SetActive(false);
			AnomalyText.SetActive(false);
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed2");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
			{
				animationHolder.GetComponent<Animation>()["PlayerInBed2"].speed = 5.5f;
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
				yield return (object)new WaitForSeconds(2f);
			}
			else
			{
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
				yield return (object)new WaitForSeconds(11f);
			}
			playerInBed.SetActive(false);
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).seePlayerTimer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSee = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).safeTimer = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).newNav();
			Player.SetActive(true);
			haveToLeaveText.SetActive(true);
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).day2 = true;
			((Footsteps)(object)((Component)playerCam).GetComponent(typeof(Footsteps))).day2 = true;
			joystick.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.588f, 0.588f, 0.588f);
			if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
			{
				GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			}
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (AnomalyNR == 3 || AnomalyNR == 24)
			{
				((playerCrawl)(object)GameObject.Find("OHCrouchButtonParent/CrouchButtonParent/PlayerHukarSigButton").GetComponent(typeof(playerCrawl))).standUp();
			}
			if (PrimeAnomalyNR == 14)
			{
				GameObject.Find("Rat1").GetComponent<ratBite>().PrimeKill = false;
			}
			if (PlayerPrefs.GetInt("EventChallenge2") == 1)
			{
				UseButton.SetActive(true);
			}
		}
		else if (daysCounter == 3f)
		{
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				if (SoCloseAchievement)
				{
					AchievementSaveManager.Instance.UnlockAchievement("SoClose");
				}
				SceneManager.LoadScene("Scene");
				yield break;
			}
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)(object)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			AnomalyText.SetActive(true);
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText3(0f, 1f, 2f));
			yield return (object)new WaitForSeconds(2f);
			if (!slendrinaAppeard && Object.op_Implicit((Object)(object)GameObject.Find("Teddy(Clone)")))
			{
				Object.Destroy((Object)(object)GameObject.Find("Teddy(Clone)"));
				Object.Instantiate<GameObject>(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("Teddy(Clone)").transform).name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText3(1f, 0f, 2f));
			day3Text.SetActive(false);
			AnomalyText.SetActive(false);
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed3");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
			{
				animationHolder.GetComponent<Animation>()["PlayerInBed3"].speed = 5.5f;
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
				yield return (object)new WaitForSeconds(2f);
			}
			else
			{
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
				yield return (object)new WaitForSeconds(11f);
			}
			playerInBed.SetActive(false);
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).seePlayerTimer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSee = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).safeTimer = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).newNav();
			Player.SetActive(true);
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).day2 = false;
			((Footsteps)(object)((Component)playerCam).GetComponent(typeof(Footsteps))).day2 = false;
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).day3 = true;
			((Footsteps)(object)((Component)playerCam).GetComponent(typeof(Footsteps))).day3 = true;
			joystick.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.588f, 0.588f, 0.588f);
			if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
			{
				GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			}
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (AnomalyNR == 3 || AnomalyNR == 24)
			{
				((playerCrawl)(object)GameObject.Find("OHCrouchButtonParent/CrouchButtonParent/PlayerHukarSigButton").GetComponent(typeof(playerCrawl))).standUp();
			}
			if (PlayerPrefs.GetInt("EventChallenge2") == 1)
			{
				UseButton.SetActive(true);
			}
		}
		else if (daysCounter == 4f)
		{
			if (PlayerPrefs.GetInt("ADSon") == 0)
			{
				IronSource.Agent.loadInterstitial();
			}
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)(object)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			AnomalyText.SetActive(true);
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText4(0f, 1f, 2f));
			yield return (object)new WaitForSeconds(2f);
			if (!slendrinaAppeard && Object.op_Implicit((Object)(object)GameObject.Find("Teddy(Clone)")))
			{
				Object.Destroy((Object)(object)GameObject.Find("Teddy(Clone)"));
				Object.Instantiate<GameObject>(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("Teddy(Clone)").transform).name = "Teddy";
			}
			fadeTextSpeed = 1f;
			((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText4(1f, 0f, 2f));
			day4Text.SetActive(false);
			AnomalyText.SetActive(false);
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed2");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			bloodscreenDay4.SetActive(true);
			bloodOnBed.SetActive(true);
			if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
			{
				animationHolder.GetComponent<Animation>()["PlayerInBed2"].speed = 5.5f;
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
				yield return (object)new WaitForSeconds(2f);
			}
			else
			{
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
				yield return (object)new WaitForSeconds(11f);
			}
			playerInBed.SetActive(false);
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).seePlayerTimer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSee = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).safeTimer = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).newNav();
			Player.SetActive(true);
			joystick.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.588f, 0.588f, 0.588f);
			if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
			{
				GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			}
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (AnomalyNR == 3 || AnomalyNR == 24)
			{
				((playerCrawl)(object)GameObject.Find("OHCrouchButtonParent/CrouchButtonParent/PlayerHukarSigButton").GetComponent(typeof(playerCrawl))).standUp();
			}
			if (PlayerPrefs.GetInt("EventChallenge2") == 1)
			{
				UseButton.SetActive(true);
			}
		}
		else if (daysCounter == 5f)
		{
			fadeTextSpeed = 3f;
			((SoundEffectsPlayerInBed)(object)soundHolder.GetComponent(typeof(SoundEffectsPlayerInBed))).startTextSound();
			AnomalyText.SetActive(true);
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText5LD(0f, 1f, 2f));
			yield return (object)new WaitForSeconds(2f);
			fadeTextSpeed = 1f;
			((backgroundSound)(object)soundHolder2.GetComponent(typeof(backgroundSound))).fadeUp = true;
			yield return ((MonoBehaviour)this).StartCoroutine(FadeText5LD(1f, 0f, 2f));
			day5LastDayText.SetActive(false);
			AnomalyText.SetActive(false);
			if (!slendrinaAppeard && Object.op_Implicit((Object)(object)GameObject.Find("Teddy(Clone)")))
			{
				Object.Destroy((Object)(object)GameObject.Find("Teddy(Clone)"));
				Object.Instantiate<GameObject>(Teddy, TeddyPos.position, TeddyPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("Teddy(Clone)").transform).name = "Teddy";
			}
			animationHolder.GetComponent<Animation>().CrossFade("PlayerInBed");
			animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 1f;
			kliverUrBedLjud.SetActive(true);
			if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
			{
				animationHolder.GetComponent<Animation>()["PlayerInBed"].speed = 5.5f;
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 1f, false);
				yield return (object)new WaitForSeconds(2f);
			}
			else
			{
				((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
				yield return (object)new WaitForSeconds(11f);
			}
			playerInBed.SetActive(false);
			((Behaviour)(EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).enabled = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).seePlayerTimer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSee = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).safeTimer = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).newNav();
			Player.SetActive(true);
			joystick.SetActive(true);
			crouchButton.SetActive(true);
			optionButton.SetActive(true);
			allBedButtons.SetActive(true);
			((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerBed = 0f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.588f, 0.588f, 0.588f);
			if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
			{
				GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			}
			mittPrick.SetActive(true);
			kliverUrBedLjud.SetActive(false);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
			if (AnomalyNR == 3 || AnomalyNR == 24)
			{
				((playerCrawl)(object)GameObject.Find("OHCrouchButtonParent/CrouchButtonParent/PlayerHukarSigButton").GetComponent(typeof(playerCrawl))).standUp();
			}
			if (PlayerPrefs.GetInt("EventChallenge2") == 1)
			{
				UseButton.SetActive(true);
			}
		}
		else
		{
			if (daysCounter != 6f)
			{
				yield break;
			}
			StopTimerCount = true;
			if (GrannyGauntlet)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 0);
			}
			if (AnomalyNR == 18)
			{
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene());
			}
			else if (AnomalyNR == 36)
			{
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene2());
			}
			else if (PlayerPrefs.GetInt("DiffData") == 4)
			{
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).gameOverNoGranny());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 0)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 1);
				((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene4();
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 1)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 2);
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene3());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 2)
			{
				PlayerPrefs.SetInt("DiffGOsceneData", 3);
				((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene2());
			}
			else if (PlayerPrefs.GetInt("DiffGOsceneData") == 3)
			{
				if (PlayerPrefs.GetInt("NoScreamersOnOff") == 0)
				{
					PlayerPrefs.SetInt("DiffGOsceneData", 0);
					((MonoBehaviour)this).StartCoroutine(((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene());
				}
				else
				{
					PlayerPrefs.SetInt("DiffGOsceneData", 1);
					((playerDead)(object)gameController.GetComponent(typeof(playerDead))).startEndScene4();
				}
			}
		}
	}

	public virtual IEnumerator DoorFix()
	{
		if (AnomalyNR != 4 && AnomalyNR != 18)
		{
			((Behaviour)GameObject.Find("SmallDoorParent (1)/SmallDoor").GetComponent<NavMeshObstacle>()).enabled = false;
			((Behaviour)GameObject.Find("Backdoor").GetComponent<NavMeshObstacle>()).enabled = false;
			((Behaviour)GameObject.Find("InnerdoorParent (1)/Innerdoor").GetComponent<NavMeshObstacle>()).enabled = false;
			((Behaviour)GameObject.Find("SmallDoorParentVind/SmallDoor").GetComponent<NavMeshObstacle>()).enabled = false;
			((Behaviour)GameObject.Find("MeatDoor").GetComponent<NavMeshObstacle>()).enabled = false;
			yield return (object)new WaitForSeconds(1f);
			((Behaviour)GameObject.Find("SmallDoorParent (1)/SmallDoor").GetComponent<NavMeshObstacle>()).enabled = true;
			((Behaviour)GameObject.Find("Backdoor").GetComponent<NavMeshObstacle>()).enabled = true;
			((Behaviour)GameObject.Find("InnerdoorParent (1)/Innerdoor").GetComponent<NavMeshObstacle>()).enabled = true;
			((Behaviour)GameObject.Find("SmallDoorParentVind/SmallDoor").GetComponent<NavMeshObstacle>()).enabled = true;
			((Behaviour)GameObject.Find("MeatDoor").GetComponent<NavMeshObstacle>()).enabled = true;
		}
	}

	public virtual void GetBook()
	{
		EventBooks++;
		hintIsActive = false;
		Granny.GetComponent<EnemyAIGranny>().Event2Buff();
		if (EventBooks == 1)
		{
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart * 2.75f, EventFogStart * 2.25f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd * 2.75f, EventFogEnd * 2.25f, 3f));
			Rat3.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 1/8";
		}
		if (EventBooks == 2)
		{
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart * 2.25f, EventFogStart * 1.75f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd * 2.25f, EventFogEnd * 1.75f, 3f));
			Rat4.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 2/8";
		}
		if (EventBooks == 3)
		{
			Rat5.SetActive(true);
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart * 1.75f, EventFogStart, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd * 1.75f, EventFogEnd, 3f));
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 3/8";
		}
		if (EventBooks == 4)
		{
			AchievementSaveManager.Instance.UnlockAchievement("FourBooks");
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart, EventFogStart / 1.25f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd, EventFogEnd / 1.25f, 3f));
			Rat6.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 4/8";
		}
		if (EventBooks == 5)
		{
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart / 1.25f, EventFogStart / 1.65f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd / 1.25f, EventFogEnd / 1.65f, 3f));
			Rat7.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 5/8";
		}
		if (EventBooks == 6)
		{
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart / 1.65f, EventFogStart / 2.15f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd / 1.65f, EventFogEnd / 2.15f, 3f));
			Rat8.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 6/8";
		}
		if (EventBooks == 7)
		{
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart / 2.15f, EventFogStart / 2.8f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd / 2.15f, EventFogEnd / 2.8f, 3f));
			Rat9.SetActive(true);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 7/8";
		}
		if (EventBooks == 8)
		{
			AchievementSaveManager.Instance.UnlockAchievement("EightBooks");
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueStart(EventFogStart / 2.8f, EventFogStart / 3.6f, 3f));
			((MonoBehaviour)this).StartCoroutine(ChangeFogValueEnd(EventFogEnd / 2.8f, EventFogEnd / 3.6f, 3f));
			gameController.GetComponent<InventoryController>().LostKeyItem.SetActive(true);
			rats.SetActive(false);
			Rat3.SetActive(false);
			Rat4.SetActive(false);
			Rat5.SetActive(false);
			Rat6.SetActive(false);
			Rat7.SetActive(false);
			Rat8.SetActive(false);
			Rat9.SetActive(false);
			EventChallenge3Text.GetComponent<Text>().text = "Books found: 8/8\r\nNow run away!";
		}
		else
		{
			gameController.GetComponent<InventoryController>().Event2BookSpawn();
		}
	}

	public IEnumerator ChangeFogValueStart(float start, float end, float duration)
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			RenderSettings.fogStartDistance = Mathf.Lerp(start, end, elapsed / duration);
			yield return null;
		}
		RenderSettings.fogStartDistance = end;
	}

	public IEnumerator ChangeFogValueEnd(float start, float end, float duration)
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			RenderSettings.fogEndDistance = Mathf.Lerp(start, end, elapsed / duration);
			yield return null;
		}
		RenderSettings.fogEndDistance = end;
	}

	public virtual IEnumerator FadeTimerText(float startLevel, float endLevel, float duration, float delay)
	{
		yield return (object)new WaitForSeconds(delay);
		for (float t = 0f; t < 1f; t += Time.deltaTime)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)TimerText.GetComponent<Text>()).color;
			color.a = a;
			((Graphic)TimerText.GetComponent<Text>()).color = color;
			yield return null;
		}
	}

	public virtual IEnumerator Anomaly42ChangeGravity()
	{
		while (true)
		{
			Physics.gravity = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
			yield return (object)new WaitForSeconds(30f);
		}
	}

	public virtual void OldPresets()
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_106a: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1121: Unknown result type (might be due to invalid IL or missing references)
		//IL_1149: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_130a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1332: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_141d: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_1591: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1609: Unknown result type (might be due to invalid IL or missing references)
		//IL_1631: Unknown result type (might be due to invalid IL or missing references)
		//IL_1659: Unknown result type (might be due to invalid IL or missing references)
		//IL_1681: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1721: Unknown result type (might be due to invalid IL or missing references)
		//IL_1749: Unknown result type (might be due to invalid IL or missing references)
		//IL_1771: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1826: Unknown result type (might be due to invalid IL or missing references)
		//IL_184e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1876: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1908: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Unknown result type (might be due to invalid IL or missing references)
		//IL_197b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a58: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ebf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2022: Unknown result type (might be due to invalid IL or missing references)
		//IL_204a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2072: Unknown result type (might be due to invalid IL or missing references)
		//IL_209a: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2123: Unknown result type (might be due to invalid IL or missing references)
		//IL_214b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2200: Unknown result type (might be due to invalid IL or missing references)
		//IL_2228: Unknown result type (might be due to invalid IL or missing references)
		//IL_2250: Unknown result type (might be due to invalid IL or missing references)
		//IL_228d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2300: Unknown result type (might be due to invalid IL or missing references)
		//IL_2328: Unknown result type (might be due to invalid IL or missing references)
		//IL_2350: Unknown result type (might be due to invalid IL or missing references)
		//IL_2378: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2405: Unknown result type (might be due to invalid IL or missing references)
		//IL_242d: Unknown result type (might be due to invalid IL or missing references)
		//IL_246a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2492: Unknown result type (might be due to invalid IL or missing references)
		//IL_2503: Unknown result type (might be due to invalid IL or missing references)
		//IL_252b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2587: Unknown result type (might be due to invalid IL or missing references)
		//IL_25af: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_261f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2647: Unknown result type (might be due to invalid IL or missing references)
		//IL_266f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2697: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("randomNR") == 100)
		{
			PlayerPrefs.SetInt("randomNR", Random.Range(1, 10));
			saveRandomNR = true;
		}
		if (PlayerPrefs.GetInt("randomNR") == 99)
		{
			PlayerPrefs.SetInt("PresetInOrder", PlayerPrefs.GetInt("PresetInOrder") + 1);
			if (PlayerPrefs.GetInt("PresetInOrder") == 10)
			{
				PlayerPrefs.SetInt("PresetInOrder", 1);
			}
			PlayerPrefs.SetInt("randomNR", PlayerPrefs.GetInt("PresetInOrder"));
			saveInOrder = true;
		}
		if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("PlankaVind3").transform.position = new Vector3(0f, -100f, 0f);
			GameObject.Find("PlankaOH2").transform.position = new Vector3(0f, -100f, 0f);
			GameObject.Find("PlankaOH3").transform.position = new Vector3(0f, -100f, 0f);
			PresetTV = "1";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			OP2.SetActive(true);
			OP2_2.SetActive(true);
			OP2_3.SetActive(true);
			OP2_4.SetActive(true);
			OP2_5.SetActive(true);
			PresetTV = "2";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			OP3.SetActive(true);
			OP3_2.SetActive(true);
			OP3_3.SetActive(true);
			OP3_4.SetActive(true);
			OP3_5.SetActive(true);
			OP3_6.SetActive(true);
			PresetTV = "3";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			OP4.SetActive(true);
			OP4_2.SetActive(true);
			OP4_3.SetActive(true);
			OP4_4.SetActive(true);
			OP4_5.SetActive(true);
			OP4_6.SetActive(true);
			OP4_7.SetActive(true);
			PresetTV = "4";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			OP5.SetActive(true);
			OP5_2.SetActive(true);
			OP5_3.SetActive(true);
			OP5_4.SetActive(true);
			OP5_5.SetActive(true);
			OP5_6.SetActive(true);
			OP5_7.SetActive(true);
			PresetTV = "5";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 6)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace1/Kugg2ObjectPL1").transform.localPosition = new Vector3(-4.7f, 11.4482f, 10.24f);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.position = new Vector3(5.78f, 35.6f, 9.28f);
			GameObject.Find("UsefulObjects/RandomPlace1/BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(90f, -90f, 180f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.position = new Vector3(-10f, 28.79f, -5.3f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.rotation = Quaternion.Euler(-180f, -90f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace1/RemoteControl_PL1").transform.SetParent((Transform)null);
			GameObject.Find("RemoteControl_PL1").transform.SetParent(GameObject.Find("Vind2_2/LodaParent (2)").transform.Find("Loda"));
			GameObject.Find("Vind2_2/LodaParent (3)/Loda/Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(-0.9f, 10.76f, -8.2f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/MelonPickUpPL1").transform.position = new Vector3(-3.33f, 13.61f, 4.177f);
			GameObject.Find("UsefulObjects/RandomPlace1/MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.position = new Vector3(30.46f, 5.64f, -23.14f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.rotation = Quaternion.Euler(39.014f, -104.141f, -80.18f);
			GameObject.Find("UsefulObjects/RandomPlace1/Topplock_PL1").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("UsefulObjects/RandomPlace1/SafeKeyPL1").transform.position = new Vector3(-15.16f, 15.04f, -3.57f);
			GameObject.Find("UsefulObjects/RandomPlace1/SafeKeyPL1").transform.rotation = Quaternion.Euler(-180f, -45f, -180f);
			GameObject.Find("UsefulObjects/RandomPlace1/SpecialKey_PL1").transform.position = new Vector3(0.411f, 8.57f, -18.35f);
			GameObject.Find("UsefulObjects/RandomPlace1/SpecialKey_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 73f);
			GameObject.Find("UsefulObjects/RandomPlace1/CarkeyPL1").transform.position = new Vector3(7.97f, 15.02f, -40f);
			GameObject.Find("UsefulObjects/RandomPlace1/Book_PL1").transform.position = new Vector3(-2.3f, 14.3f, -40f);
			GameObject.Find("UsefulObjects/RandomPlace1/Book_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 140f);
			GameObject.Find("UsefulObjects/RandomPlace1/Meat_PL1").transform.position = new Vector3(1.57f, 4.075f, 11f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.position = new Vector3(-2.632f, 9.542f, 4.98f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.rotation = Quaternion.Euler(87.54f, 2.72f, -65f);
			GameObject.Find("UsefulObjects/RandomPlace1/VapennyckelPL1").transform.localScale = new Vector3(0.003046056f, 0.00370037f, 0.002786894f);
			GameObject.Find("UsefulObjects/RandomPlace1/Wrench_PL1").transform.SetParent((Transform)null);
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(-10.27f, 9.29f, -39.82f);
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(14.45f, 10.09f, -3.2f);
			GameObject.Find("UsefulObjects/RandomPlace1/BirdSeedBoxPL1").transform.position = new Vector3(6.62f, 7.82f, 0.84f);
			GameObject.Find("UsefulObjects/RandomPlace1/CarBattery_PL1").transform.position = new Vector3(-10.21f, 14.688f, -29.5f);
			GameObject.Find("UsefulObjects/RandomPlace1/HanglockKeyPL1").transform.position = new Vector3(-16.73f, 30.34f, 7.18f);
			GameObject.Find("UsefulObjects/RandomPlace1/HanglockKeyPL1").transform.rotation = Quaternion.Euler(0f, 68.5f, 45f);
			GameObject.Find("HouseUpdate4Test11Garage/Car/HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(6.9f, 13.51f, -22.06f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(0f, 67.5f, -90f);
			GameObject.Find("HouseKeyPL1").transform.localScale = new Vector3(0.002142245f, 0.002592376f, 0.001956337f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun1_PL1").transform.position = new Vector3(7.84f, 12.49f, -29.5f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun2_PL1").transform.position = new Vector3(18.36f, 14.64f, 12.86f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun2_PL1").transform.rotation = Quaternion.Euler(-90f, -180f, 56f);
			GameObject.Find("UsefulObjects/RandomPlace1/Shotgun3_PL1").transform.position = new Vector3(7.54f, 12.56f, -22.94f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent/ByroLoda/AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(-0.85f, 2.267f, 0.12f);
			GameObject.Find("AvbitarePL1").transform.SetParent(GameObject.Find("HouseUpdate4Test11Garage").transform.Find("Car"));
			GameObject.Find("GrannyHouse8Update/Loda2Parent (7)/ByroLoda/SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(17.48f, 13.63f, 3.37f);
			GameObject.Find("Bensindunk_PL1").transform.localPosition = new Vector3(2.08f, 7.82f, -12.14f);
			PresetTV = "6";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 7)
		{
			OP5.SetActive(true);
			OP5_2.SetActive(true);
			OP5_3.SetActive(true);
			OP5_4.SetActive(true);
			OP5_5.SetActive(true);
			OP5_6.SetActive(true);
			OP5_7.SetActive(true);
			GameObject.Find("UsefulObjects/RandomPlace5/RemoteControl_PL5").transform.position = new Vector3(18f, 16.11f, 12.82f);
			GameObject.Find("UsefulObjects/RandomPlace5/Bensindunk_PL5").transform.position = new Vector3(-7.3f, 9.33f, -40.2f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.position = new Vector3(11.406f, 13.958f, 0.573f);
			GameObject.Find("UsefulObjects/RandomPlace5/Topplock_PL5").transform.rotation = Quaternion.Euler(25.811f, 90f, -268.933f);
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.position = new Vector3(-6.024f, 20.92f, -17.461f);
			GameObject.Find("UsefulObjects/RandomPlace5/CarkeyPL5").transform.rotation = Quaternion.Euler(349.1f, 78.101f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace5/Wrench_PL5").transform.position = new Vector3(7.95f, 15.01f, -40f);
			GameObject.Find("UsefulObjects/RandomPlace5/Meat_PL5").transform.position = new Vector3(-9.73f, 14.705f, -29.824f);
			GameObject.Find("UsefulObjects/RandomPlace5/SpecialKey_PL5").transform.position = new Vector3(-16.03f, 30.237f, 7.56f);
			GameObject.Find("UsefulObjects/RandomPlace5/Book_PL5").transform.position = new Vector3(0.549f, 7.752f, -36.596f);
			GameObject.Find("Shotgun3_PL5").transform.position = new Vector3(-8.043f, 14.66f, 4.55f);
			GameObject.Find("Shotgun3_PL5").transform.rotation = Quaternion.Euler(-90f, -90f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace5/Shotgun2_PL5").transform.position = new Vector3(18.305f, 16.126f, 2.065f);
			GameObject.Find("UsefulObjects/RandomPlace5/Shotgun2_PL5").transform.rotation = Quaternion.Euler(90f, 90f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace5/SparkPlug_PL5").transform.position = new Vector3(0.39f, 8.578f, -18.291f);
			GameObject.Find("UsefulObjects/RandomPlace5/SparkPlug_PL5").transform.rotation = Quaternion.Euler(-70.71f, -131.942f, -62.83f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.position = new Vector3(12.45f, 23.18f, -12f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.rotation = Quaternion.Euler(90f, 0f, 0f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg2ObjectPL5").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (4)").transform.Find("ByroLoda"));
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.position = new Vector3(4.02f, 3.38f, -0.76f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.rotation = Quaternion.Euler(36.923f, 90f, 90f);
			GameObject.Find("UsefulObjects/RandomPlace5/Kugg1ObjectPL5").transform.SetParent(GameObject.Find("HouseUpdate4Test11Garage").transform.Find("Car"));
			GameObject.Find("UsefulObjects/RandomPlace5/MelonPickUpPL5").transform.position = new Vector3(-9.12f, 27.13f, -4.9f);
			GameObject.Find("UsefulObjects/RandomPlace5/MelonPickUpPL5").transform.rotation = Quaternion.Euler(0f, -38.4f, -90f);
			GameObject.Find("UsefulObjects/RandomPlace5/HouseKeyPL5").transform.position = new Vector3(6.8f, 7.81f, 0.84f);
			GameObject.Find("UsefulObjects/RandomPlace5/SafeKeyPL5").transform.position = new Vector3(5.662f, 35.525f, 9.242f);
			GameObject.Find("UsefulObjects/RandomPlace5/playHouseKeyPL5").transform.localPosition = new Vector3(-2.31f, -9.16f, 4.9f);
			GameObject.Find("UsefulObjects/RandomPlace5/BrunnsVevPickupPL5").transform.localPosition = new Vector3(-3.918f, 2.948f, -34.96f);
			GameObject.Find("UsefulObjects/RandomPlace5/BrunnsVevPickupPL5").transform.localRotation = Quaternion.Euler(185.079f, 45f, 90f);
			GameObject.Find("CarBattery_PL5").transform.position = new Vector3(15.679f, 20.595f, 12.03f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.position = new Vector3(30.622f, 5.1521f, -23.164f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.rotation = Quaternion.Euler(90f, -90f, 69.468f);
			GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda/VapennyckelPl5").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/Car/Shotgun1_PL5").transform.position = new Vector3(7.905f, 15.057f, -40f);
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/Car/Shotgun1_PL5").transform.rotation = Quaternion.Euler(90f, 0f, -45.2f);
			GameObject.Find("HouseBakedReady/HouseUpdate4Test11Garage/Car/Shotgun1_PL5").transform.SetParent((Transform)null);
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL5").transform.position = new Vector3(-16.12f, 20.55f, 13.67f);
			GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep/BrunnsHink/HammerPL5").transform.SetParent((Transform)null);
			GameObject.Find("HouseBakedReady/Vind2_2/LodaParent (2)/Loda/AvbitarePL5").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL5").transform.position = new Vector3(6.84f, 13.5191f, -22.0717f);
			GameObject.Find("AvbitarePL5").transform.rotation = Quaternion.Euler(-179.823f, -112.194f, -228.97f);
			GameObject.Find("AvbitarePL5").transform.localScale = new Vector3(0.0026905357f, 0.0037417905f, 0.0021612572f);
			GameObject.Find("BirdSeedBoxPL5").transform.SetParent((Transform)null);
			GameObject.Find("BirdSeedBoxPL5").transform.position = new Vector3(5.853f, 22.968f, 11.071f);
			GameObject.Find("BirdSeedBoxPL5").transform.rotation = Quaternion.Euler(-90f, 0f, -39f);
			GameObject.Find("BirdSeedBoxPL5").AddComponent<Rigidbody>();
			GameObject.Find("Shotgun1_PL5").transform.SetParent(GameObject.Find("HouseBakedReady/Sovrum1Furniture/Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("Shotgun1_PL5").transform.position = new Vector3(-14.627f, 23.195f, -0.64f);
			GameObject.Find("Shotgun1_PL5").transform.rotation = Quaternion.Euler(-90f, 0f, -45f);
			PresetTV = "7";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 8)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(-8.093f, 16.192f, 3.896f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(90f, 0f, 30f);
			GameObject.Find("BrunnsVevPickupPL1").transform.position = new Vector3(-1f, 2.326f, 0.3f);
			GameObject.Find("BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(-2.207f, 31.41f, 86.07f);
			GameObject.Find("BrunnsVevPickupPL1").transform.SetParent(GameObject.Find("Car").transform);
			GameObject.Find("RemoteControl_PL1").transform.position = new Vector3(32.724f, 14.229f, -3.362f);
			GameObject.Find("RemoteControl_PL1").transform.rotation = Quaternion.Euler(180f, 212.5f, 90f);
			GameObject.Find("Kugg2ObjectPL1").transform.localPosition = new Vector3(22f, 2.13f, -14.23f);
			GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(0f, 45f, 0f);
			GameObject.Find("Kugg2ObjectPL1").AddComponent<Rigidbody>();
			GameObject.Find("Kugg2ObjectPL1").transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			GameObject.Find("MelonPickUpPL1").transform.position = new Vector3(5.775f, 35.7f, 9.29f);
			GameObject.Find("MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, -68f, 0f);
			GameObject.Find("Topplock_PL1").transform.localPosition = new Vector3(17.163f, 4.788f, 17.4f);
			GameObject.Find("Topplock_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -71.1f);
			GameObject.Find("SafeKeyPL1").transform.position = new Vector3(2.098f, 20.464f, -19.256f);
			GameObject.Find("SafeKeyPL1").transform.rotation = Quaternion.Euler(0f, 63f, 0f);
			GameObject.Find("SafeKeyPL1").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("SpecialKey_PL1").transform.position = new Vector3(0.39736894f, 8.5683f, -18.316507f);
			GameObject.Find("SpecialKey_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
			GameObject.Find("CarkeyPL1").transform.position = new Vector3(6.8703f, 13.5045f, -22.0546f);
			GameObject.Find("CarkeyPL1").transform.rotation = Quaternion.Euler(-13.907f, 257.212f, -46.637f);
			GameObject.Find("CarkeyPL1").transform.localScale = new Vector3(0.0029f, 0.0029f, 0.0029f);
			GameObject.Find("Book_PL1").transform.localPosition = new Vector3(-10.28f, 19.306f, 18.626f);
			GameObject.Find("Book_PL1").transform.rotation = Quaternion.Euler(-162.863f, 0f, 90f);
			GameObject.Find("Meat_PL1").transform.position = new Vector3(-3.8f, 19.427f, -15.122f);
			GameObject.Find("Meat_PL1").transform.rotation = Quaternion.Euler(-150f, 0f, 90f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(18.353447f, 16.088f, 2.023007f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 78f);
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(8.402f, 12.902f, -34.799f);
			GameObject.Find("Wrench_PL1").transform.rotation = Quaternion.Euler(-21.037f, -87.9f, 84.168f);
			GameObject.Find("HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(-9.22657f, 36.11f, -2.141078f);
			GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(-67.1f, -129.108f, 90f);
			GameObject.Find("BirdSeedBoxPL1").transform.position = new Vector3(-10f, 14.68f, -29.7f);
			GameObject.Find("BirdSeedBoxPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -46f);
			GameObject.Find("CarBattery_PL1").transform.position = new Vector3(30.65f, 5.08f, -23.1f);
			GameObject.Find("CarBattery_PL1").transform.rotation = Quaternion.Euler(-90f, 180f, 122f);
			GameObject.Find("CarBattery_PL1").transform.SetParent(GameObject.Find("HouseBakedReady/Update3HouseBackyard2/BrunnRep").transform.Find("BrunnsHink"));
			GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(-10.072f, 28.773855f, -5.234f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 23.503f);
			GameObject.Find("HouseKeyPL1").transform.SetParent(GameObject.Find("LodaParent (2)/Loda").transform);
			GameObject.Find("Shotgun1_PL1").transform.position = new Vector3(6.58f, 23.39f, 8.198f);
			GameObject.Find("Shotgun1_PL1").transform.rotation = Quaternion.Euler(90f, 0f, 63f);
			GameObject.Find("Shotgun2_PL1").transform.position = new Vector3(-23.21f, 20.47f, -1.85f);
			GameObject.Find("Shotgun2_PL1").transform.rotation = Quaternion.Euler(-20.166f, 0f, -90f);
			GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(-7.2f, 14.235f, -19.04f);
			GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -34.071f);
			GameObject.Find("AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(-6.128f, 9.283f, -40.213f);
			GameObject.Find("AvbitarePL1").transform.rotation = Quaternion.Euler(-90f, 0f, 35f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(-16.26f, 30.175f, 7.47f);
			GameObject.Find("SparkPlug_PL1").transform.rotation = Quaternion.Euler(0f, 44f, 0f);
			GameObject.Find("HanglockKeyPL1").transform.position = new Vector3(8.0184f, 15.0127f, -40.06069f);
			GameObject.Find("HanglockKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -30f);
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(0).SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL1").transform.position = new Vector3(-14.5f, 23.1552f, -0.78f);
			GameObject.Find("playHouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -170f);
			Object.Destroy((Object)(object)GameObject.Find("playHouseKeyPL1").GetComponent<Rigidbody>());
			GameObject.Find("playHouseKeyPL1").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("Bensindunk_PL1").transform.position = new Vector3(6.91f, 7.79f, 0.8f);
			GameObject.Find("Bensindunk_PL1").transform.rotation = Quaternion.Euler(-90f, 70.48f, 0f);
			PresetTV = "8";
		}
		else if (PlayerPrefs.GetInt("randomNR") == 9)
		{
			OP1.SetActive(true);
			OP1_2.SetActive(true);
			OP1_3.SetActive(true);
			OP1_4.SetActive(true);
			OP1_5.SetActive(true);
			OP1_6.SetActive(true);
			OP1_7.SetActive(true);
			GameObject.Find("Kugg1ObjectPL1").transform.SetParent((Transform)null);
			GameObject.Find("Kugg1ObjectPL1").transform.position = new Vector3(5.623f, 35.497f, 8.948f);
			GameObject.Find("Kugg1ObjectPL1").transform.rotation = Quaternion.Euler(-90f, 180f, 180f);
			GameObject.Find("BrunnsVevPickupPL1").transform.position = new Vector3(-14.7447f, 23.242f, -0.571f);
			GameObject.Find("BrunnsVevPickupPL1").transform.rotation = Quaternion.Euler(0f, -137.5f, -90f);
			GameObject.Find("BrunnsVevPickupPL1").transform.SetParent(GameObject.Find("Loda2Parent (1)/ByroLoda").transform);
			GameObject.Find("RemoteControl_PL1").transform.position = new Vector3(-1.1f, 2.272f, 0.23f);
			GameObject.Find("RemoteControl_PL1").transform.rotation = Quaternion.Euler(0f, 402f, -90f);
			GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(-7.750528f, 30.495f, 13.893f);
			GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(30.6f, 0f, 0f);
			GameObject.Find("Topplock_PL1").transform.position = new Vector3(17.773f, 14.097f, 2.837f);
			GameObject.Find("Topplock_PL1").transform.rotation = Quaternion.Euler(141f, 13f, 100f);
			GameObject.Find("SafeKeyPL1").transform.position = new Vector3(8.03f, 15f, -40f);
			GameObject.Find("SafeKeyPL1").transform.rotation = Quaternion.Euler(0f, 47f, 0f);
			GameObject.Find("SpecialKey_PL1").transform.position = new Vector3(2.1193f, 20.588f, -19.353f);
			GameObject.Find("SpecialKey_PL1").transform.rotation = Quaternion.Euler(0f, -131f, 0f);
			GameObject.Find("SpecialKey_PL1").transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			GameObject.Find("CarkeyPL1").transform.position = new Vector3(-4.901f, 19.16f, -15.242f);
			GameObject.Find("CarkeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -16.08f);
			GameObject.Find("Book_PL1").transform.position = new Vector3(5.815f, 16.057f, 3.27f);
			GameObject.Find("Meat_PL1").transform.position = new Vector3(12.17f, 16.025f, 0.78f);
			GameObject.Find("Meat_PL1").transform.rotation = Quaternion.Euler(-90f, -54.4f, 0f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -46.91f);
			GameObject.Find("VapennyckelPL1").transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			GameObject.Find("VapennyckelPL1").transform.rotation = Quaternion.Euler(0f, 47.563f, -266.17f);
			GameObject.Find("VapennyckelPL1").GetComponent<BoxCollider>().size = new Vector3(218.2f, 117.4f, 26f);
			GameObject.Find("VapennyckelPL1").AddComponent<Rigidbody>();
			GameObject.Find("VapennyckelPL1").transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			GameObject.Find("Wrench_PL1").transform.position = new Vector3(-10.085f, 14.6791f, -29.792f);
			GameObject.Find("Wrench_PL1").transform.rotation = Quaternion.Euler(-90f, -14.5f, 0f);
			GameObject.Find("HammerPL1").transform.SetParent((Transform)null);
			GameObject.Find("HammerPL1").transform.position = new Vector3(7.595f, 8.338f, 0.774f);
			GameObject.Find("HammerPL1").transform.rotation = Quaternion.Euler(-246.18f, 90f, 278.742f);
			GameObject.Find("BirdSeedBoxPL1").transform.position = new Vector3(-6.3f, 9.284f, -39.6f);
			GameObject.Find("BirdSeedBoxPL1").transform.rotation = Quaternion.Euler(-90f, 0f, -52f);
			GameObject.Find("CarBattery_PL1").transform.localPosition = new Vector3(-27.267f, 8.67f, 7.086f);
			GameObject.Find("CarBattery_PL1").transform.localRotation = Quaternion.Euler(-90f, 0f, -140.5f);
			GameObject.Find("HouseKeyPL1").transform.SetParent((Transform)null);
			GameObject.Find("HouseKeyPL1").transform.position = new Vector3(30.888f, 5.285f, -23.097f);
			GameObject.Find("HouseKeyPL1").transform.rotation = Quaternion.Euler(39.532f, 90f, -90f);
			GameObject.Find("HouseKeyPL1").transform.SetParent(GameObject.Find("BrunnsHink").transform);
			GameObject.Find("Shotgun1_PL1").transform.position = new Vector3(33.707f, 11.9f, -13.975f);
			GameObject.Find("Shotgun1_PL1").transform.rotation = Quaternion.Euler(90f, 0f, -70f);
			GameObject.Find("Shotgun2_PL1").transform.position = new Vector3(11.53f, 27.295f, 3.638f);
			GameObject.Find("Shotgun2_PL1").transform.rotation = Quaternion.Euler(-160f, 170f, 90f);
			GameObject.Find("Shotgun3_PL1").transform.position = new Vector3(15.964f, 20.138f, -0.986f);
			GameObject.Find("Shotgun3_PL1").transform.rotation = Quaternion.Euler(90f, 0f, 16.5f);
			GameObject.Find("AvbitarePL1").transform.SetParent((Transform)null);
			GameObject.Find("AvbitarePL1").transform.position = new Vector3(18.03f, 16.084f, 12.8f);
			GameObject.Find("AvbitarePL1").transform.rotation = Quaternion.Euler(-90f, 0f, -40f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent((Transform)null);
			GameObject.Find("SparkPlug_PL1").transform.position = new Vector3(-10.1f, 28.81f, -5.3f);
			GameObject.Find("SparkPlug_PL1").transform.rotation = Quaternion.Euler(-180f, -136f, 180f);
			GameObject.Find("SparkPlug_PL1").transform.SetParent(GameObject.Find("LodaParent (2)/Loda").transform);
			((Component)GameObject.Find("GiljotinParent2").transform.GetChild(6)).transform.GetChild(0).SetParent((Transform)null);
			GameObject.Find("playHouseKeyPL1").transform.position = new Vector3(18.375f, 16.085f, 2.016f);
			GameObject.Find("playHouseKeyPL1").transform.rotation = Quaternion.Euler(-90f, 0f, 140f);
			((Component)GameObject.Find("playHouseKeyPL1").transform.GetChild(0)).gameObject.SetActive(false);
			Object.Destroy((Object)(object)GameObject.Find("playHouseKeyPL1").GetComponent<Rigidbody>());
			GameObject.Find("Bensindunk_PL1").transform.position = new Vector3(-16.189f, 30.191f, 7.525f);
			GameObject.Find("Bensindunk_PL1").transform.rotation = Quaternion.Euler(-90f, 0f, 33.908f);
			((Component)GameObject.Find("Bensindunk_PL1").transform.GetChild(0)).gameObject.SetActive(false);
			GameObject.Find("MelonPickUpPL1").transform.position = new Vector3(-8f, 14.83f, 4.1f);
			GameObject.Find("MelonPickUpPL1").transform.rotation = Quaternion.Euler(180f, 28f, 0f);
			GameObject.Find("Shotgun3_PL1").transform.localPosition = new Vector3(-3.67f, 2.883f, -34.57f);
			GameObject.Find("Kugg2ObjectPL1").transform.position = new Vector3(9.55f, 21.26f, 12.3f);
			GameObject.Find("Kugg2ObjectPL1").transform.rotation = Quaternion.Euler(-90f, 120f, 0f);
			PresetTV = "9";
		}
		if (saveRandomNR)
		{
			PlayerPrefs.SetInt("randomNR", 100);
		}
		if (saveInOrder)
		{
			PlayerPrefs.SetInt("randomNR", 99);
		}
	}

	public IEnumerator VignetteEffect(GameObject Laser, Color LaserColor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		deadByLaser = true;
		ExtraTrapsDeathScreen.SetActive(true);
		allBedButtons.SetActive(false);
		((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color = LaserColor;
		float duration = 0.5f;
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			float num = elapsed / duration;
			((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color = new Color(((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.r, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.g, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.b, Mathf.Lerp(0f, 0.65f, num));
			yield return null;
		}
		((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color = new Color(((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.r, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.g, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.b, 0.65f);
		if (PlayerPrefs.GetInt("PrimeOn") == 1)
		{
			((soundEffects)(object)GameObject.Find("SoundEffects").GetComponent(typeof(soundEffects))).playerLandSound();
			((MonoBehaviour)this).StartCoroutine(((playerCaught)(object)Player.GetComponent(typeof(playerCaught))).fallingDead());
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
			((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
			yield break;
		}
		float duration2 = 0.5f;
		float elapsed2 = 0f;
		while (elapsed2 < duration2)
		{
			elapsed2 += Time.deltaTime;
			float num2 = elapsed2 / duration2;
			((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color = new Color(((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.r, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.g, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.b, Mathf.Lerp(0.65f, 0f, num2));
			yield return null;
		}
		((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color = new Color(((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.r, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.g, ((Graphic)ExtraTrapsDeathScreen.GetComponent<Image>()).color.b, 0f);
		deadByLaser = false;
		allBedButtons.SetActive(true);
	}

	public void CheckAchievementsGoodEnding()
	{
		if (GrannyGauntlet)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 1);
		}
		AchievementSaveManager.Instance.UnlockAchievement("Freedom");
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			AchievementSaveManager.Instance.UnlockAchievement("NightmareEscape");
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			AchievementSaveManager.Instance.UnlockAchievement("AbandonedEscape");
		}
		if (AnomalyNR == 9 && Object.op_Implicit((Object)(object)GameObject.Find("CrowParent")))
		{
			AchievementSaveManager.Instance.UnlockAchievement("AnomalousAnomaly");
		}
		if (AnomalyNR == 30 && Anomaly30Achievement)
		{
			AchievementSaveManager.Instance.UnlockAchievement("BreakRules");
		}
		if (AnomalyNR == 41)
		{
			AchievementSaveManager.Instance.UnlockAchievement("MirrorPortal");
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1 && daysCounter == 1f)
		{
			AchievementSaveManager.Instance.UnlockAchievement("LightsOutEscapeOneDay");
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			AchievementSaveManager.Instance.UnlockAchievement("LightsOutEscape");
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			AchievementSaveManager.Instance.UnlockAchievement("ExtremeBeat");
		}
		else if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			AchievementSaveManager.Instance.UnlockAchievement("ExtremePlusBeat");
		}
		else if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			AchievementSaveManager.Instance.UnlockAchievement("CruelBeat");
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (SetNerfedPrime)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("NerfedPrimeBest", 100);
				AchievementSaveManager.Instance.UnlockAchievement("NerfedPrimeFan");
			}
			else if (SetPrime)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("PrimeBest", 100);
			}
			else if (SetPrimePlus)
			{
				GlobalSaveManager.InstanceSaveData.SaveAllData("PrimePlusBest", 100);
			}
			if (PrimeAnomalyNR != 0 && SetPrime)
			{
				AchievementSaveManager.Instance.UnlockAchievement("AnomalousPrimeEnjoyer");
			}
			else if (PrimeAnomalyNR == 0 && SetPrime)
			{
				AchievementSaveManager.Instance.UnlockAchievement("PrimeEnjoyer");
			}
		}
	}

	public void CheckNewBest()
	{
		float num = 0f;
		if (PrimeAnomalyNR != 6 && PrimeAnomalyNR != 8 && PrimeAnomalyNR != 9 && PrimeAnomalyNR != 13 && PrimeAnomalyNR != 18)
		{
			float num2 = (float)ProgressValue / 87f * 50f;
			if (num2 > 50f)
			{
				num2 = 50f;
			}
			float val = (float)ProgressCar / 36f * 48f;
			float val2 = (float)ProgressLift / 48f * 48f;
			float num3 = Math.Max(val, val2);
			if (num3 > 48f)
			{
				num3 = 48f;
			}
			num = (float)Math.Round(num2 + num3, 0);
		}
		else if (PrimeAnomalyNR == 6)
		{
			float num4 = (float)ProgressValue / 91f * 99f;
			if (num4 > 99f)
			{
				num4 = 99f;
			}
			float val3 = (float)ProgressCar / 42f * 99f;
			float val4 = (float)ProgressLift / 48f * 99f;
			float num5 = Math.Max(val3, Math.Max(val4, num4));
			if (num5 > 99f)
			{
				num5 = 99f;
			}
			num = (float)Math.Round(num5, 0);
		}
		else if (PrimeAnomalyNR == 8)
		{
			float num6 = (float)ProgressValue / 81f * 48f;
			if (num6 > 48f)
			{
				num6 = 49f;
			}
			float val5 = (float)ProgressCar / 30f * 48f;
			float val6 = (float)ProgressLift / 48f * 48f;
			float num7 = Math.Max(val5, val6);
			if (num7 > 48f)
			{
				num7 = 48f;
			}
			num = (float)Math.Round(num6 + num7, 0);
		}
		else if (PrimeAnomalyNR == 9)
		{
			float num8 = (float)ProgressValue / 91f * 30f;
			if (num8 > 30f)
			{
				num8 = 30f;
			}
			float num9 = (float)ProgressCar / 36f * 30f;
			float num10 = (float)ProgressLift / 48f * 30f;
			float num11 = num9 + num10 + (float)ProgressBehavior;
			if (num11 > 69f)
			{
				num11 = 69f;
			}
			num = (float)Math.Round(num8 + num11, 0);
		}
		else if (PrimeAnomalyNR == 13)
		{
			float num12 = (float)ProgressValue / 67f * 43f;
			if (num12 > 43f)
			{
				num12 = 43f;
			}
			float val7 = (float)ProgressCar / 36f * 43f;
			float val8 = (float)ProgressLift / 48f * 43f;
			float num13 = Math.Max(val7, val8);
			if (num13 > 43f)
			{
				num13 = 43f;
			}
			num = (float)Math.Round(num12 + num13 + (float)ProgressBehavior, 0);
		}
		else if (PrimeAnomalyNR == 18)
		{
			float num14 = (float)ProgressValue / 95f * 48f;
			if (num14 > 48f)
			{
				num14 = 49f;
			}
			float val9 = (float)ProgressCar / 36f * 48f;
			float val10 = (float)ProgressLift / 48f * 48f;
			float num15 = Math.Max(val9, val10);
			if (num15 > 48f)
			{
				num15 = 48f;
			}
			num = (float)Math.Round(num14 + num15, 0);
		}
		if (SetNerfedPrime)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("NerfedPrimeBest", (int)num);
		}
		else if (SetPrime)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("PrimeBest", (int)num);
		}
		else if (SetPrime)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("PrimePlusBest", (int)num);
		}
	}

	public void Anomaly36SetLasers()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(29.76f, 7.1f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		val.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("GallerHole").GetComponent<MeshRenderer>()).materials;
		((Renderer)val.GetComponent<MeshRenderer>()).material.color = Color.grey;
		val.AddComponent<LineRenderer>();
		val.AddComponent<LaserBeam>();
		GameObject val2 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(34.4f, 7.5f, -30.5f), Quaternion.Euler(0f, -90f, 0f));
		val2.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val2.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("GallerHole").GetComponent<MeshRenderer>()).materials;
		((Renderer)val2.GetComponent<MeshRenderer>()).material.color = Color.green;
		val2.AddComponent<LineRenderer>();
		val2.AddComponent<LaserBeamGreen>();
		Object.Instantiate<GameObject>(val2, new Vector3(34.4f, 7.5f, -30f), Quaternion.Euler(0f, -90f, 0f));
		Object.Instantiate<GameObject>(val2, new Vector3(34.4f, 7.5f, -29.5f), Quaternion.Euler(0f, -90f, 0f));
		Object.Instantiate<GameObject>(val2, new Vector3(34.4f, 7.5f, -29f), Quaternion.Euler(0f, -90f, 0f));
		GameObject val3 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(27.825f, 9.5f, -35f), Quaternion.Euler(0f, 90f, 0f));
		val3.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val3.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		((Renderer)val3.GetComponent<MeshRenderer>()).material.color = Color.gray;
		val3.AddComponent<LineRenderer>();
		val3.AddComponent<LaserBeamPurple>();
		GameObject val4 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(28.756f, 8.77f, -28.314f), Quaternion.Euler(0f, 180f, 0f));
		val4.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val4.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		((Renderer)val4.GetComponent<MeshRenderer>()).material.color = Color.gray;
		val4.AddComponent<LineRenderer>();
		val4.AddComponent<LaserBeamYellow>();
		GameObject val5 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(34f, 7f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		((Renderer)val5.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("LitetBordSR3").GetComponent<MeshRenderer>()).materials;
		val5.transform.localScale = new Vector3(1f, 1f, 1f);
		val5.AddComponent<LineRenderer>();
		val5.AddComponent<LaserBeamBlue>();
		Object.Instantiate<GameObject>(val5, new Vector3(34f, 7.5f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		Object.Instantiate<GameObject>(val5, new Vector3(34f, 8f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		Object.Instantiate<GameObject>(val5, new Vector3(34f, 8.5f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		Object.Instantiate<GameObject>(val5, new Vector3(34f, 9f, -36.025f), Quaternion.Euler(0f, 0f, 0f));
		GameObject val6 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(34.4f, 9f, -32.5f), Quaternion.Euler(0f, -90f, 0f));
		((Renderer)val6.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Burk").GetComponent<MeshRenderer>()).materials;
		val6.transform.localScale = new Vector3(1f, 1f, 1f);
		val6.AddComponent<LineRenderer>();
		val6.AddComponent<LaserBeamCyan>().LaserDistance = 5f;
		GameObject val7 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(33.05f, 10f, -28.314f), Quaternion.Euler(0f, 180f, 0f));
		((Renderer)val7.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		val7.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val7.GetComponent<MeshRenderer>()).material.color = new Color(0.8f, 0f, 0.4f);
		val7.AddComponent<LineRenderer>();
		val7.AddComponent<LaserBeamMarrow>().LaserDistanceMax = 10f;
		GameObject val8 = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, (Transform)null);
		val8.SetActive(true);
		val8.transform.position = new Vector3(31.3892f, 5.89f, -32.212f);
		val8.transform.localScale = new Vector3(0.4021194f, 0.04195138f, 0.0415763f);
		((Renderer)val8.GetComponent<MeshRenderer>()).material.color = Color.red;
		GameObject val9 = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(34.4f, 7.5f, -34.91f), Quaternion.Euler(0f, -90f, 0f));
		((Renderer)val9.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		val9.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)val9.GetComponent<MeshRenderer>()).material.color = new Color(1f, 0.5f, 0f);
		val9.AddComponent<LineRenderer>();
		val9.AddComponent<LaserBeamGray>();
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(29.442f, 5.885f, -33.651f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeNotClose";
		Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(29.196f, 5.885f, -30.476f), Quaternion.Euler(0f, 180f, 0f)).GetComponent<BearTrap>().timerInvisible2 = 1f;
		Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(30.406f, 5.885f, -32.197f), Quaternion.Euler(0f, 180f, 0f)).GetComponent<BearTrap>().timerInvisible2 = 2f;
		Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(31.74f, 5.885f, -30.404f), Quaternion.Euler(0f, 180f, 0f)).GetComponent<BearTrap>().timerInvisible2 = 3f;
		Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(32.62f, 5.885f, -33.97f), Quaternion.Euler(0f, 180f, 0f)).GetComponent<BearTrap>().timerInvisible2 = 4f;
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(26.532f, 5.885f, -29.93f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(24.09f, 5.885f, -32.13f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(22.69f, 5.885f, -34.643f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(20.979f, 5.885f, -32.202f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(26.02f, 5.885f, -32.88f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(22.532f, 5.885f, -30.42f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(20.477f, 5.885f, -34.189f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
		((Object)Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(24.6f, 5.885f, -29.673f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapPrimeYellow";
	}
}
