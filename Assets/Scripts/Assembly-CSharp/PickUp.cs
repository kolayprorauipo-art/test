using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PickUp : MonoBehaviour
{
	public GameObject gameController;

	public InventoryController InventoryControllerScript;

	public startNewDay startNewDayScript;

	public AudioSource AudioSourceScript;

	public GameObject interactionTextObject;

	public Text interactionText;

	public GameObject interactionTextObject2;

	public Text interactionText2;

	public GameObject interactionTextObject3;

	public Text interactionText3;

	public GameObject Granny;

	public Transform GrannyStartPos;

	public GameObject SeeRay;

	public GameObject GrassAchievement;

	public GameObject kugg3inPlace;

	public GameObject HandKlocka;

	public LayerMask layerMask;

	public bool playerTaken;

	public bool pickUp;

	public bool dropObject;

	public bool placeObject;

	public GameObject pickUpButton;

	public GameObject dropPoint;

	public GameObject dropPointPlanka;

	public GameObject dropObjectButton;

	public GameObject placeObjectButton;

	public GameObject soundHolder;

	public GameObject SpraysoundHolder;

	public GameObject mittenRing;

	public GameObject avklipptKabelCellar;

	public GameObject avklipptKabelVind;

	public GameObject KabelVind;

	public GameObject avklipptKabel;

	public GameObject fan;

	public GameObject fanCollider;

	public bool playSound;

	public AudioClip PrimeAnomaly11PopUp;

	public AudioClip klippKabel;

	public AudioClip taBortPlanka;

	public AudioClip doorLocked;

	public AudioClip safeDoordoorLocked;

	public AudioClip safeDoorOpen;

	public AudioClip vapenDoorOpen;

	public AudioClip hitCam;

	public AudioClip plockaUppObject;

	public AudioClip plockaUppNyckel;

	public AudioClip plockaUppCrossbow;

	public AudioClip placeBattery;

	public AudioClip pickUpTeddy;

	public AudioClip placebrunnsvev;

	public AudioClip placeMelon;

	public AudioClip drarIspak;

	public AudioClip meatPlate;

	public AudioClip vind2Dooropen;

	public AudioClip vind2Lockopen;

	public AudioClip pickUpGascan;

	public AudioClip skruva;

	public AudioClip fillSeed;

	public GameObject LampaDoor1;

	public GameObject LampaDoor2;

	public GameObject doorRayHolder;

	public GameObject Bom;

	public GameObject DdoorLock;

	public GameObject arrowButton;

	public GameObject arrowArmborst;

	public GameObject Armborstladdad;

	public GameObject ArmborstOladdad;

	public GameObject avbitare;

	public Transform newAvbitare;

	public GameObject hammare;

	public Transform newHammare;

	public GameObject vas;

	public Transform newvas;

	public GameObject vas2;

	public Transform newvas2;

	public GameObject safeKey;

	public Transform newsafeKey;

	public GameObject exitKey;

	public Transform newexitKey;

	public GameObject hanglockKey;

	public Transform newhanglockKey;

	public GameObject padlockCode;

	public Transform newpadlockCode;

	public GameObject armborst;

	public Transform newarmborst;

	public Transform newArrow;

	public GameObject shootArrowRay;

	public GameObject weaponKey;

	public Transform newweaponKey;

	public GameObject screwdriver;

	public Transform newscrewdriver;

	public GameObject planka;

	public Transform newplanka;

	public GameObject battery;

	public Transform newbattery;

	public GameObject playhouseKey;

	public Transform newplayhouseKey;

	public GameObject carKey;

	public Transform newcarKey;

	public GameObject melon;

	public Transform newmelon;

	public GameObject teddy;

	public Transform newteddy;

	public GameObject kugg1;

	public Transform newkugg1;

	public GameObject kugg2;

	public Transform newkugg2;

	public GameObject message;

	public Transform newmessage;

	public GameObject brunnsvev;

	public Transform newbrunnsvev;

	public GameObject oldShotgun;

	public GameObject oldShotgunAnim;

	public Transform newoldShotgun;

	public bool oldShotgunLoaded;

	public GameObject shootButton;

	public GameObject shootRay;

	public GameObject ammo;

	public GameObject gunDel1;

	public Transform newgunDel1;

	public GameObject gunDel2;

	public Transform newgunDel2;

	public GameObject gunDel3;

	public Transform newgunDel3;

	public GameObject topplock;

	public Transform newtopplock;

	public GameObject topplockInPlace;

	public GameObject carbattery;

	public Transform newcarbattery;

	public GameObject carbatteryInPlace;

	public GameObject gascan;

	public Transform newgascan;

	public GameObject wrench;

	public Transform newwrench;

	public GameObject sparkplug;

	public Transform newsparkplug;

	public GameObject sparkPlugInPlace;

	public GameObject sparkPlugCable;

	public GameObject meat;

	public Transform newmeat;

	public GameObject spider;

	public GameObject meatOnPlate;

	public GameObject spiderTrigger;

	public GameObject specialkey;

	public Transform newspecialkey;

	public GameObject specialkeyLock;

	public GameObject specialkeyDoor;

	public GameObject specialkeyInPlace;

	public GameObject book;

	public Transform newbook;

	public GameObject pepperspray;

	public Transform newpepperspray;

	public GameObject remote;

	public Transform newremote;

	public GameObject birdSeed;

	public Transform newbirdSeed;

	public GameObject freezeTrap;

	public Transform newfreezeTrap;

	public GameObject sprayButton;

	public GameObject sprayParticle;

	public GameObject useRemoteButton;

	public GameObject secretWall;

	public GameObject bookInPlace;

	public bool plankaHighlighted;

	public GameObject highlightedPlanka;

	public GameObject highlightedPlankaTrigger;

	public GameObject plankaHole;

	public GameObject skruvPlatta;

	public GameObject skruvPlattaOutside;

	public GameObject kamera;

	public GameObject kameraBroken;

	public GameObject kameraSeeTrigger;

	public GameObject galler;

	public GameObject gallerColliders;

	public bool playerInPrison;

	public GameObject prisonDoor;

	public GameObject batteryOnPlace;

	public GameObject batterySpak;

	public GameObject tb1;

	public Transform newtb1;

	public GameObject tb2;

	public Transform newtb2;

	public GameObject tb3;

	public Transform newtb3;

	public GameObject tb4;

	public Transform newtb4;

	public GameObject playhouseDoor;

	public GameObject giljoCutArea;

	public GameObject melonInPlace;

	public GameObject giljotin;

	public bool haveSeenMelonText;

	public bool kugg1OK;

	public bool kugg2OK;

	public bool kugg3OK;

	public GameObject playHouseLucka;

	public GameObject kugg1inPlace;

	public GameObject kugg2inPlace;

	public GameObject brunnsvevInPlace;

	public GameObject brunnsvevsHolder;

	public GameObject extremeLockOn;

	public GameObject extremeLockOff;

	public GameObject crow;

	public bool textTimerOnOff;

	public float textTimer;

	public float RayDistance;

	public Resources c;

	public bool wireSet;

	public bool TeddyArrived;

	public bool CrowPoisoned;

	public bool haveSeenNBookText;

	public bool haveSeenNMelonText;

	public bool haveSeenNHammerText;

	public bool haveSeenNBatteryText;

	public bool haveSeenNTrapText;

	public bool haveSeenNCanText;

	public bool haveSeenNMeatText;

	public bool CaramelDoorOpened;

	public float CaramelDoorAnim;

	public GameObject CaramelDoor;

	public bool haveSeenNWeaponKeyText;

	public bool ChocolateDoorOpened;

	public float ChocolateDoorAnim;

	public GameObject ChocolateDoor;

	public float ChocolateHandAnim;

	public int RedDoorCount;

	public bool haveSeenBoxOfSweetsText;

	public int haveSeenNVaseText;

	public int event3GiveSpecialKey;

	private bool buffhandAnomaly44;

	public bool haveSeenNRemoteText;

	public bool haveSeenNWrenchText;

	public int PrimeAnomaly18LadderCount;

	public Transform allHints;

	public bool IrrationalEscapeFailed;

	public GameObject[] allHintsList;

	public virtual void Start()
	{
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		RayDistance = 5f;
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 6 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havepepperspray = true;
			pepperspray.SetActive(true);
			dropObjectButton.SetActive(true);
			sprayButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 7 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 7)
		{
			RayDistance = 10f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 8 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 8 || (PlayerPrefs.GetInt("DiffData") == -1 && PlayerPrefs.GetInt("twoLocksOnOff") == 0 && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 18))
		{
			playSound = true;
			((Rigidbody)Bom.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).hangLockBort = true;
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
			GameObject.Find("DoorLock").SetActive(false);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 9)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebirdSeed = true;
			birdSeed.SetActive(true);
			dropObjectButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 19)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveTeleportRemote = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TeleportRemoteHand.SetActive(true);
			dropObjectButton.SetActive(true);
			useRemoteButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 2525)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havefreezeTrap = true;
			freezeTrap.SetActive(true);
			dropObjectButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 35)
		{
			RayDistance = 2.5f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 44)
		{
			RayDistance = 5f;
			buffhandAnomaly44 = true;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 101)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveRedKey = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).RedKeyHand.SetActive(true);
			dropObjectButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 13)
		{
			((Rigidbody)GameObject.Find("DigitalPadlock").GetComponent(typeof(Rigidbody))).isKinematic = false;
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).DpadlockBort = true;
			GameObject.Find("DigitalPadlock").tag = "Untagged";
			((Component)GameObject.Find("DigitalPadlock").transform.GetChild(0)).gameObject.SetActive(false);
			GameObject.Find("HardBatteryDoorLocker").GetComponent<Animation>().Play("BatteryLockOpen");
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).batteryLockOk = true;
			batterySpak.GetComponent<Animation>().Play("BattSpakOK");
			((Component)batteryOnPlace.transform.GetChild(0)).gameObject.SetActive(false);
			batteryOnPlace.SetActive(true);
			GameObject.Find("HardBatteryDoorLocker").tag = "Untagged";
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 5)
		{
			HandKlocka.SetActive(true);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareCrossbow = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareCrossbowHand.SetActive(true);
			arrowButton.SetActive(true);
			shootArrowRay.SetActive(true);
			dropObjectButton.SetActive(true);
			InventoryControllerScript.AntiNightmareCrossbow.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 15)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareBook = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareBookHand.SetActive(true);
			dropObjectButton.SetActive(true);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 17)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveNightmareRemote = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareRemoteHand.SetActive(true);
			dropObjectButton.SetActive(true);
			useRemoteButton.SetActive(true);
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			pepperspray.SetActive(true);
			pepperspray.transform.localPosition = new Vector3(0.05f, -0.05f, 0.15f);
			((Renderer)pepperspray.GetComponent<MeshRenderer>()).enabled = false;
			sprayButton.SetActive(true);
			((Behaviour)sprayButton.GetComponent<Image>()).enabled = false;
			event3GiveSpecialKey = 0;
		}
	}

	public virtual void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_b456: Unknown result type (might be due to invalid IL or missing references)
		//IL_b46a: Unknown result type (might be due to invalid IL or missing references)
		//IL_b475: Unknown result type (might be due to invalid IL or missing references)
		//IL_b551: Unknown result type (might be due to invalid IL or missing references)
		//IL_b4cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_b581: Unknown result type (might be due to invalid IL or missing references)
		//IL_b596: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_232b: Unknown result type (might be due to invalid IL or missing references)
		//IL_234a: Unknown result type (might be due to invalid IL or missing references)
		//IL_236f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2379: Unknown result type (might be due to invalid IL or missing references)
		//IL_237e: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_23e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2226: Unknown result type (might be due to invalid IL or missing references)
		//IL_222b: Unknown result type (might be due to invalid IL or missing references)
		//IL_225f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2264: Unknown result type (might be due to invalid IL or missing references)
		//IL_2298: Unknown result type (might be due to invalid IL or missing references)
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f35: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_24cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_250d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2512: Unknown result type (might be due to invalid IL or missing references)
		//IL_2550: Unknown result type (might be due to invalid IL or missing references)
		//IL_2555: Unknown result type (might be due to invalid IL or missing references)
		//IL_2593: Unknown result type (might be due to invalid IL or missing references)
		//IL_2598: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_25db: Unknown result type (might be due to invalid IL or missing references)
		//IL_2619: Unknown result type (might be due to invalid IL or missing references)
		//IL_261e: Unknown result type (might be due to invalid IL or missing references)
		//IL_265c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2661: Unknown result type (might be due to invalid IL or missing references)
		//IL_269f: Unknown result type (might be due to invalid IL or missing references)
		//IL_26a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2725: Unknown result type (might be due to invalid IL or missing references)
		//IL_272a: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_3211: Unknown result type (might be due to invalid IL or missing references)
		//IL_321c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3888: Unknown result type (might be due to invalid IL or missing references)
		//IL_38d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_35c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_35ca: Expected Obj, but got Unknown
		//IL_3461: Unknown result type (might be due to invalid IL or missing references)
		//IL_346c: Unknown result type (might be due to invalid IL or missing references)
		//IL_327b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3286: Unknown result type (might be due to invalid IL or missing references)
		//IL_34cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_4068: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bae: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_416e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_475a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4765: Unknown result type (might be due to invalid IL or missing references)
		//IL_454f: Unknown result type (might be due to invalid IL or missing references)
		//IL_455a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ca5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_45bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_495f: Unknown result type (might be due to invalid IL or missing references)
		//IL_496a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_4fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_49cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_49da: Unknown result type (might be due to invalid IL or missing references)
		//IL_525d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5268: Unknown result type (might be due to invalid IL or missing references)
		//IL_5037: Unknown result type (might be due to invalid IL or missing references)
		//IL_5042: Unknown result type (might be due to invalid IL or missing references)
		//IL_52cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_52d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5686: Unknown result type (might be due to invalid IL or missing references)
		//IL_5691: Unknown result type (might be due to invalid IL or missing references)
		//IL_56f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5701: Unknown result type (might be due to invalid IL or missing references)
		//IL_62cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_62d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_655b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6566: Unknown result type (might be due to invalid IL or missing references)
		//IL_633b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6346: Unknown result type (might be due to invalid IL or missing references)
		//IL_67e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_67f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_65c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_65d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_59c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_59d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_684f: Unknown result type (might be due to invalid IL or missing references)
		//IL_685a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ca4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d14: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7261: Unknown result type (might be due to invalid IL or missing references)
		//IL_726c: Unknown result type (might be due to invalid IL or missing references)
		//IL_700a: Unknown result type (might be due to invalid IL or missing references)
		//IL_7015: Unknown result type (might be due to invalid IL or missing references)
		//IL_7528: Unknown result type (might be due to invalid IL or missing references)
		//IL_7533: Unknown result type (might be due to invalid IL or missing references)
		//IL_72d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_72dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_7598: Unknown result type (might be due to invalid IL or missing references)
		//IL_75a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_7875: Unknown result type (might be due to invalid IL or missing references)
		//IL_7880: Unknown result type (might be due to invalid IL or missing references)
		//IL_78e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_78f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_83bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_83ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_8429: Unknown result type (might be due to invalid IL or missing references)
		//IL_8434: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_818c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8974: Unknown result type (might be due to invalid IL or missing references)
		//IL_897f: Unknown result type (might be due to invalid IL or missing references)
		//IL_89e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_89ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_8dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_8dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_8be9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_8728: Unknown result type (might be due to invalid IL or missing references)
		//IL_8733: Unknown result type (might be due to invalid IL or missing references)
		//IL_929b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_8798: Unknown result type (might be due to invalid IL or missing references)
		//IL_87a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_96c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_96f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_99a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_99d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_984e: Unknown result type (might be due to invalid IL or missing references)
		//IL_9859: Unknown result type (might be due to invalid IL or missing references)
		//IL_9c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_98be: Unknown result type (might be due to invalid IL or missing references)
		//IL_98c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_9ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_a26d: Unknown result type (might be due to invalid IL or missing references)
		//IL_a2a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_a0bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_a0ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e77: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e82: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_a129: Unknown result type (might be due to invalid IL or missing references)
		//IL_a134: Unknown result type (might be due to invalid IL or missing references)
		//IL_a446: Unknown result type (might be due to invalid IL or missing references)
		//IL_a451: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit raycastHit = default;
		Vector3 val = SeeRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (Physics.Raycast(SeeRay.transform.position, val, ref raycastHit, RayDistance, layerMask.value))
			{
				if (((Component)raycastHit.collider).CompareTag("avbitare"))
				{
					if (startNewDayScript.PresetTV == "6" && startNewDayScript.PrimeAnomalyNR != 18 && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.AnomalyNR != 18)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, avbitare, "Cutting pliers", () =>
					{
						InventoryControllerScript.haveAvbitare = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("hammer"))
				{
					if (startNewDayScript.PresetTV == "3" && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.AnomalyNR != 18)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, hammare, "Hammer", () =>
					{
						InventoryControllerScript.haveHammare = true;
						IrrationalEscapeFailed = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("vas"))
				{
					if (startNewDayScript.AnomalyNR == 21)
					{
						ShowText("Anomaly vase");
					}
					else
					{
						ShowText("");
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, vas, "", () =>
					{
						InventoryControllerScript.havevas = true;
						if (startNewDayScript.AnomalyNR == 21)
						{
							AchievementSaveManager.Instance.UnlockAchievement("TrulyAHiddenVase");
						}
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("vas2"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, vas2, "", () =>
					{
						InventoryControllerScript.havevas2 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("safekey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, safeKey, "Safe key", () =>
					{
						InventoryControllerScript.havesafeKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("exitkey"))
				{
					if (!InventoryControllerScript.OpenedCarEscape && !InventoryControllerScript.OpenedLift && startNewDayScript.AnomalyNR == 11)
					{
						ShowText2("I need to unlock another escape routes");
						return;
					}
					if (startNewDayScript.AnomalyNR == 94)
					{
						ShowText2("I can't eat this");
						return;
					}
					if (InventoryControllerScript.EatingCounter < 200 && PlayerPrefs.GetInt("EventChallenge3") == 1)
					{
						ShowText2("I need to have 200 melons to pick up this");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, exitKey, "Master key", () =>
					{
						InventoryControllerScript.haveexitKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("hanglockkey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, hanglockKey, "Padlock key", () =>
					{
						InventoryControllerScript.havehanglockKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("dpadlockCode"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, padlockCode, "Padlock code", () =>
					{
						InventoryControllerScript.havepadlockCode = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("armborst"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, armborst, "Crossbow", () =>
					{
						InventoryControllerScript.havearmborst = true;
						arrowButton.SetActive(false);
						arrowArmborst.SetActive(false);
						Armborstladdad.SetActive(false);
						ArmborstOladdad.SetActive(true);
					}, plockaUppCrossbow);
				}
				else if (((Component)raycastHit.collider).CompareTag("nightmareCrossbow"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareCrossbowHand, "Nightmare crossbow", () =>
					{
						InventoryControllerScript.haveNightmareCrossbow = true;
						arrowButton.SetActive(true);
						shootArrowRay.SetActive(true);
						InventoryControllerScript.AntiNightmareCrossbow.SetActive(true);
					}, plockaUppCrossbow);
				}
				else if (((Component)raycastHit.collider).CompareTag("arrow"))
				{
					IntercactWithItem("Tranquilizer dart", () =>
					{
						//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
						//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havearmborst)
						{
							if (!InventoryControllerScript.haveArrow)
							{
								InventoryControllerScript.haveArrow = true;
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								arrowButton.SetActive(true);
								shootArrowRay.SetActive(true);
								arrowArmborst.SetActive(true);
								Armborstladdad.SetActive(true);
								ArmborstOladdad.SetActive(false);
								InventoryControllerScript.armborstArrowOK = true;
								((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).CrossbowLoad();
							}
							else
							{
								InventoryControllerScript.haveArrow = true;
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								arrowButton.SetActive(true);
								shootArrowRay.SetActive(true);
								arrowArmborst.SetActive(true);
								Armborstladdad.SetActive(true);
								ArmborstOladdad.SetActive(false);
								InventoryControllerScript.armborstArrowOK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								Object.Instantiate<Transform>(newArrow, dropPoint.transform.position, dropPoint.transform.rotation);
							}
						}
						else
						{
							ShowText2("I need a crossbow");
						}
					});
				}
				else if (((Component)raycastHit.collider).CompareTag("weaponkey"))
				{
					if (startNewDayScript.PresetTV == "2" && !InventoryControllerScript.OpenedCarTrunk)
					{
						ShowText2("");
						return;
					}
					if (PlayerPrefs.GetInt("DiffData") != 7)
					{
						PickUpItem(((Component)raycastHit.collider).gameObject, weaponKey, "Weapon key", () =>
						{
							InventoryControllerScript.haveweaponKey = true;
						}, plockaUppNyckel);
					}
					else
					{
						PickUpItem(((Component)raycastHit.collider).gameObject, weaponKey, "Gabon key", () =>
						{
							InventoryControllerScript.haveweaponKey = true;
						}, plockaUppNyckel);
					}
				}
				else if (((Component)raycastHit.collider).CompareTag("screwdriver"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, screwdriver, "Screwdriver", () =>
					{
						InventoryControllerScript.havescrewdriver = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("plankawalk"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, planka, "Plank", () =>
					{
						InventoryControllerScript.haveplanka = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("battery"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, battery, "Battery", () =>
					{
						InventoryControllerScript.havebattery = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("tb1"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, tb1, "A piece of the picture", () =>
					{
						InventoryControllerScript.havetb1 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("tb2"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, tb2, "A piece of the picture", () =>
					{
						InventoryControllerScript.havetb2 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("tb3"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, tb3, "A piece of the picture", () =>
					{
						InventoryControllerScript.havetb3 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("tb4"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, tb4, "A piece of the picture", () =>
					{
						InventoryControllerScript.havetb4 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("playhousekey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, playhouseKey, "Playhouse key", () =>
					{
						InventoryControllerScript.haveplayhouseKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("melon"))
				{
					if (startNewDayScript.PresetTV == "4" && !InventoryControllerScript.OpenedCarTrunk)
					{
						ShowText2("");
						return;
					}
					if (startNewDayScript.AnomalyNR == 101)
					{
						ShowText2("You can't use your hands HE-HE-HE");
						return;
					}
					if (startNewDayScript.AnomalyNR == 94 || PlayerPrefs.GetInt("EventChallenge3") == 1)
					{
						EatMelon(((Component)raycastHit.collider).gameObject, melon, "Melon", plockaUppObject);
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, melon, "Melon", () =>
					{
						InventoryControllerScript.havemelon = true;
						if (!haveSeenMelonText)
						{
							haveSeenMelonText = true;
							ShowText2("Something is inside this melon");
						}
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("teddy"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, teddy, "Teddy", () =>
					{
						InventoryControllerScript.haveteddy = true;
						((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					}, pickUpTeddy);
				}
				else if (((Component)raycastHit.collider).CompareTag("kugg1"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, kugg1, "Cogwheel", () =>
					{
						InventoryControllerScript.havekugg1 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("kugg2"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, kugg2, "Cogwheel", () =>
					{
						InventoryControllerScript.havekugg2 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("message"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, message, "", () =>
					{
						InventoryControllerScript.havemessage = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("brunnsvevpickup"))
				{
					if (startNewDayScript.PresetTV == "8" && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.PrimeAnomalyNR != 18)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, brunnsvev, "Winch handle", () =>
					{
						InventoryControllerScript.havebrunnsvev = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("shotgun"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, oldShotgun, "Shotgun", () =>
					{
						InventoryControllerScript.haveoldShotgun = true;
						if (oldShotgunLoaded)
						{
							ammo.SetActive(true);
							oldShotgunAnim.GetComponent<Animation>().Play("Load");
							shootButton.SetActive(true);
							shootRay.SetActive(true);
							((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).loadedPickup();
						}
						else
						{
							oldShotgunAnim.GetComponent<Animation>().Play("OpenEmpty");
							shootButton.SetActive(false);
							shootRay.SetActive(false);
							ammo.SetActive(false);
							((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).emptyShotgun();
						}
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("ammo"))
				{
					IntercactWithItem("Ammo", () =>
					{
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveoldShotgun)
						{
							if (!oldShotgunLoaded)
							{
								oldShotgunLoaded = true;
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								shootButton.SetActive(true);
								shootRay.SetActive(true);
								ammo.SetActive(true);
								oldShotgunAnim.GetComponent<Animation>().Play("Load");
								AudioSourceScript.PlayOneShot(plockaUppObject);
								((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).loadShotgun();
							}
							else
							{
								ShowText2("Shotgun is already loaded!");
							}
						}
						else
						{
							ShowText2("I need a shotgun");
						}
					});
				}
				else if (((Component)raycastHit.collider).CompareTag("shotgunp1"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, gunDel1, "A part of shotgun", () =>
					{
						InventoryControllerScript.havegunDel1 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("shotgunp2"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, gunDel2, "A part of shotgun", () =>
					{
						InventoryControllerScript.havegunDel2 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("shotgunp3"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, gunDel3, "A part of shotgun", () =>
					{
						InventoryControllerScript.havegunDel3 = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("carkey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, carKey, "Car key", () =>
					{
						InventoryControllerScript.havecarKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("topplock"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, topplock, "Engine part", () =>
					{
						InventoryControllerScript.havetopplock = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("carbattery"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, carbattery, "Car battery", () =>
					{
						InventoryControllerScript.havecarbattery = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("gascan"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, gascan, "Gasoline can", () =>
					{
						InventoryControllerScript.havegascan = true;
					}, pickUpGascan);
					if (startNewDayScript.AnomalyNR == 18)
					{
						ShowText("Poison can");
					}
				}
				else if (((Component)raycastHit.collider).CompareTag("wrench"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, wrench, "Wrench", () =>
					{
						InventoryControllerScript.havewrench = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("sparkplug"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, sparkplug, "Spark plug", () =>
					{
						InventoryControllerScript.havesparkplug = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("meat"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, meat, "Meat", () =>
					{
						InventoryControllerScript.havemeat = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("specialkey"))
				{
					if (startNewDayScript.PresetTV == "5" && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, specialkey, "Special key", () =>
					{
						InventoryControllerScript.havespecialkey = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("book"))
				{
					if (PlayerPrefs.GetInt("EventChallenge2") == 1)
					{
						EventChalenge2PickUp(((Component)raycastHit.collider).gameObject, book, "Book", plockaUppObject);
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, book, "Book", () =>
					{
						InventoryControllerScript.havebook = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("pepperspray"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, pepperspray, "Pepper spray", () =>
					{
						InventoryControllerScript.havepepperspray = true;
						((sprayPepper)(object)sprayButton.GetComponent(typeof(sprayPepper))).sprayTime = false;
						sprayParticle.SetActive(false);
						sprayButton.SetActive(true);
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("remotecontrol"))
				{
					if (startNewDayScript.PresetTV == "9" && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.PrimeAnomalyNR != 18 && PlayerPrefs.GetInt("EventChallenge1") != 1)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, remote, "Remote control", () =>
					{
						InventoryControllerScript.haveremote = true;
						useRemoteButton.SetActive(true);
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("birdseed"))
				{
					if (startNewDayScript.AnomalyNR == 18)
					{
						Anomaly18BirdSeedPickUp(((Component)raycastHit.collider).gameObject, birdSeed, "Bird seed", plockaUppObject);
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, birdSeed, "Bird seed", () =>
					{
						InventoryControllerScript.havebirdSeed = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("freezetrap"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, freezeTrap, "Freeze trap", () =>
					{
						InventoryControllerScript.havefreezeTrap = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("vitrindoorRclosed"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, startNewDayScript.PictureItemHand, "Picture", () =>
					{
						InventoryControllerScript.havePicture = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("vitrindoorLclosed"))
				{
					if (startNewDayScript.PresetTV == "7" && !InventoryControllerScript.OpenedCarTrunk && startNewDayScript.PrimeAnomalyNR != 18)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.StickHand, "Metal stick", () =>
					{
						InventoryControllerScript.haveStick = true;
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("vitrindoorLopen"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.LostKeyHand, "Green key", () =>
					{
						InventoryControllerScript.haveLostKey = true;
					}, plockaUppNyckel);
				}
				else if (((Component)raycastHit.collider).CompareTag("vitrindoorRopen"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.TVRemoteHand, "TV remote control", () =>
					{
						InventoryControllerScript.haveTVRemote = true;
						useRemoteButton.SetActive(true);
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).CompareTag("spak"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.WireHand, "Cable", () =>
					{
						InventoryControllerScript.haveWire = true;
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareBook"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7 && startNewDayScript.PrimeAnomalyNR != 15)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareBookHand, "Nightmare book", () =>
					{
						InventoryControllerScript.haveNightmareBook = true;
						if (!haveSeenNBookText)
						{
							haveSeenNBookText = true;
							ShowText2("I can throw this to Granny to kill her");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareVase"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareVaseHand, "Nightmare vase", () =>
					{
						InventoryControllerScript.haveNightmareVase = true;
						if (haveSeenNVaseText == 0)
						{
							haveSeenNVaseText++;
							ShowText2("I can drop this item through nightmare walls");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareMelon"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareMelonHand, "Nightmare melon", () =>
					{
						InventoryControllerScript.haveNightmareMelon = true;
						if (!haveSeenNMelonText)
						{
							haveSeenNMelonText = true;
							ShowText2("I can drop this item to the nightmare wall to get a random item");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareHammer"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareHammerHand, "Nightmare hammer", () =>
					{
						InventoryControllerScript.haveNightmareHammer = true;
						if (!haveSeenNHammerText)
						{
							haveSeenNHammerText = true;
							ShowText2("I can break a nightmare wall with this item");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BlueKey")
				{
					IntercactWithItem("Blue key", () =>
					{
						ShowText2("The key is magnetized to the ceiling. I think I need a remote control");
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BlueKey(Clone)" || ((Object)((Component)raycastHit.collider).gameObject).name == "newBlueKey(Clone)" || ((Object)((Component)raycastHit.collider).gameObject).name == "BlueKeyisFalling")
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.BlueKeyHand, "Blue key", () =>
					{
						InventoryControllerScript.haveBlueKey = true;
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("DoorUnlock"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.DoorUnlockHand, "«Door unlock»", () =>
					{
						InventoryControllerScript.haveDoorUnlock = true;
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("ButtonLiftEscape"))
				{
					if (startNewDayScript.PresetTV == "1" && !InventoryControllerScript.OpenedCarTrunk)
					{
						ShowText2("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.ButtonNewEscapeHand, "Button", () =>
					{
						InventoryControllerScript.haveButtonNewEscape = true;
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("TeleportRemote"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.TeleportRemoteHand, "Teleport control", () =>
					{
						InventoryControllerScript.haveTeleportRemote = true;
						useRemoteButton.SetActive(true);
						if (PlayerPrefs.GetInt("DiffData") == 7)
						{
							AchievementSaveManager.Instance.UnlockAchievement("Unstoppable");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("Anomaly19Button"))
				{
					IntercactWithItem("Get a teleport control", () =>
					{
						if (!InventoryControllerScript.haveTeleportRemote)
						{
							InventoryControllerScript.CheckInventory();
							InventoryControllerScript.haveTeleportRemote = true;
							Object.Destroy((Object)(object)GameObject.Find("newTeleportRemote(Clone)"));
							InventoryControllerScript.TeleportRemoteHand.SetActive(true);
							InventoryControllerScript.dropObjectButton.SetActive(true);
							useRemoteButton.SetActive(true);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						}
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BlueKey")
				{
					if (!((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveTeleportRemote)
					{
						IntercactWithItem("Get a teleport control", () =>
						{
							InventoryControllerScript.CheckInventory();
							InventoryControllerScript.haveTeleportRemote = true;
							Object.Destroy((Object)(object)GameObject.Find("newTeleportRemote(Clone)"));
							InventoryControllerScript.TeleportRemoteHand.SetActive(true);
							useRemoteButton.SetActive(true);
							dropObjectButton.SetActive(true);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						});
					}
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareBattery"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareBatteryHand, "Nightmare battery", () =>
					{
						InventoryControllerScript.haveNightmareBattery = true;
						if (!haveSeenNBatteryText)
						{
							haveSeenNBatteryText = true;
							ShowText2("I can drop this item very hard to break planks");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareTrap"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareTrapHand, "Nightmare trap", () =>
					{
						InventoryControllerScript.haveNightmareTrap = true;
						if (!haveSeenNTrapText)
						{
							haveSeenNTrapText = true;
							ShowText2("Granny can't walk over this trap, but it will stop working after 1 minute");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareCan"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareCanHand, "Nightmare gasoline can", () =>
					{
						InventoryControllerScript.haveNightmareCan = true;
						useRemoteButton.SetActive(true);
						PlayerPrefs.SetInt("NGasCanExplode", 1);
						if (!haveSeenNCanText)
						{
							haveSeenNCanText = true;
							ShowText2("I can use this item to explode a gasoline can without destroying it!");
						}
					}, pickUpGascan);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareWeaponKey"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareWeaponKeyHand, "Nightmare weapon key", () =>
					{
						InventoryControllerScript.haveNightmareWeaponKey = true;
						if (!haveSeenNWeaponKeyText)
						{
							haveSeenNWeaponKeyText = true;
							ShowText2("I can use this to open the wall next to the weapon safe");
						}
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("CaramelKey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.RedKeyHand, "Caramel key", () =>
					{
						InventoryControllerScript.haveRedKey = true;
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("ChocolateKey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.ChocolateKeyHand, "Chocolate key", () =>
					{
						InventoryControllerScript.haveChocolateKey = true;
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("BoxOfSweets"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.BoxOfSweetsHand, "Box of sweets", () =>
					{
						InventoryControllerScript.haveBoxOfSweets = true;
						if (!haveSeenBoxOfSweetsText)
						{
							haveSeenBoxOfSweetsText = true;
							ShowText2("I can drop this from a height");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("RedKeyAnomaly27"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.RedKeyHand, "Red key", () =>
					{
						InventoryControllerScript.haveRedKey = true;
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("PrimeRedKey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.PrimeRedKeyHand, "Red key", () =>
					{
						InventoryControllerScript.havePrimeRedKey = true;
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("FakeTeddyPrime1"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, teddy, "Teddy", () =>
					{
						InventoryControllerScript.haveteddy = true;
						InventoryControllerScript.PrimeTeddyItem.GetComponent<Rigidbody>().isKinematic = false;
						((Collider)InventoryControllerScript.PrimeTeddyItem.GetComponent<MeshCollider>()).enabled = false;
						GameObject.Find("FakeTeddyPrime2").GetComponent<Rigidbody>().isKinematic = false;
						((Collider)GameObject.Find("FakeTeddyPrime2").GetComponent<MeshCollider>()).enabled = false;
						((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					}, pickUpTeddy);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("FakeTeddyPrime2"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, teddy, "Teddy", () =>
					{
						InventoryControllerScript.haveteddy = true;
						InventoryControllerScript.PrimeTeddyItem.GetComponent<Rigidbody>().isKinematic = false;
						((Collider)InventoryControllerScript.PrimeTeddyItem.GetComponent<MeshCollider>()).enabled = false;
						GameObject.Find("FakeTeddyPrime1").GetComponent<Rigidbody>().isKinematic = false;
						((Collider)GameObject.Find("FakeTeddyPrime1").GetComponent<MeshCollider>()).enabled = false;
						((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = true;
					}, pickUpTeddy);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("TruePrimeTeddy"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.PrimeTeddyHand, "Teddy", () =>
					{
						InventoryControllerScript.havePrimeTeddy = true;
						if (((Object)((Component)raycastHit.collider).gameObject).name == "TruePrimeTeddy")
						{
							GameObject.Find("FakeTeddyPrime1").GetComponent<Rigidbody>().isKinematic = false;
							((Collider)GameObject.Find("FakeTeddyPrime1").GetComponent<MeshCollider>()).enabled = false;
							GameObject.Find("FakeTeddyPrime2").GetComponent<Rigidbody>().isKinematic = false;
							((Collider)GameObject.Find("FakeTeddyPrime2").GetComponent<MeshCollider>()).enabled = false;
						}
					}, pickUpTeddy);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("DarkKey"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.DarkKeyHand, "Dark key", () =>
					{
						InventoryControllerScript.haveDarkKey = true;
						AchievementSaveManager.Instance.UnlockAchievement("DarkestHour");
					}, plockaUppNyckel);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareRemote"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareRemoteHand, "Nightmare remote", () =>
					{
						InventoryControllerScript.haveNightmareRemote = true;
						useRemoteButton.SetActive(true);
						if (!haveSeenNRemoteText)
						{
							haveSeenNRemoteText = true;
							ShowText2("I can use this item to teleport to a place where I look");
						}
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("NightmareWrench"))
				{
					if (PlayerPrefs.GetInt("DiffData") == 7)
					{
						ShowText("");
						return;
					}
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.NightmareWrenchHand, "Nightmare wrench", () =>
					{
						InventoryControllerScript.haveNightmareWrench = true;
						if (!haveSeenNWrenchText)
						{
							haveSeenNWrenchText = true;
							ShowText2("I can drop this item to break two random nightmare walls");
						}
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).gameObject.CompareTag("victimcard"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.VictimCardHand, "Victim card", () =>
					{
						InventoryControllerScript.haveVictimCard = true;
						AchievementSaveManager.Instance.UnlockAchievement("VictimCard");
					}, plockaUppObject);
				}
				else if (((Component)raycastHit.collider).gameObject.CompareTag("touchgrass"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.SmallPlantHand, "A small plant", () =>
					{
						InventoryControllerScript.haveSmallPlant = true;
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name.Contains("Cogwheel3"))
				{
					PickUpItem(((Component)raycastHit.collider).gameObject, InventoryControllerScript.kugg3Hand, "Cogwheel", () =>
					{
						InventoryControllerScript.havekugg3 = true;
					}, plockaUppObject);
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GamblingButtonUnavailable")
				{
					Intercact(() =>
					{
						ShowText2("I can't gamble now");
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GamblingButton1")
				{
					Intercact(() =>
					{
						//IL_0035: Unknown result type (might be due to invalid IL or missing references)
						//IL_003a: Unknown result type (might be due to invalid IL or missing references)
						if (gameController.GetComponent<InventoryController>().EatingCounter >= 3 && ((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color != Color.red)
						{
							((Component)raycastHit.collider).gameObject.GetComponent<Event3GamblingButton>().GamblingTimer = 0f;
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<InventoryController>().Event3MelonGamblingNew(Mathf.RoundToInt(Random.Range((float)gameController.GetComponent<InventoryController>().EatingCounter * 0.75f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 1.25f)), (float)gameController.GetComponent<InventoryController>().EatingCounter * 0.75f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 1.25f));
						}
						else
						{
							ShowText2("I need at least 3 melons");
						}
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GamblingButton2")
				{
					Intercact(() =>
					{
						//IL_0036: Unknown result type (might be due to invalid IL or missing references)
						//IL_003b: Unknown result type (might be due to invalid IL or missing references)
						if (gameController.GetComponent<InventoryController>().EatingCounter >= 10 && ((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color != Color.red)
						{
							((Component)raycastHit.collider).gameObject.GetComponent<Event3GamblingButton>().GamblingTimer = 0f;
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<InventoryController>().Event3MelonGamblingNew(Mathf.RoundToInt(Random.Range((float)gameController.GetComponent<InventoryController>().EatingCounter * 0.5f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 1.5f)), (float)gameController.GetComponent<InventoryController>().EatingCounter * 0.5f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 1.5f));
						}
						else
						{
							ShowText2("I need at least 10 melons");
						}
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GamblingButton3")
				{
					Intercact(() =>
					{
						//IL_0036: Unknown result type (might be due to invalid IL or missing references)
						//IL_003b: Unknown result type (might be due to invalid IL or missing references)
						if (gameController.GetComponent<InventoryController>().EatingCounter >= 20 && ((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color != Color.red)
						{
							((Component)raycastHit.collider).gameObject.GetComponent<Event3GamblingButton>().GamblingTimer = 0f;
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<InventoryController>().Event3MelonGamblingNew(Mathf.RoundToInt(Random.Range(0f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 1.75f)), 0f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 2f));
						}
						else
						{
							ShowText2("I need at least 20 melons");
						}
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GamblingButton4")
				{
					Intercact(() =>
					{
						//IL_0036: Unknown result type (might be due to invalid IL or missing references)
						//IL_003b: Unknown result type (might be due to invalid IL or missing references)
						if (gameController.GetComponent<InventoryController>().EatingCounter >= 50 && ((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color != Color.red)
						{
							((Component)raycastHit.collider).gameObject.GetComponent<Event3GamblingButton>().oncePerGame = true;
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<InventoryController>().Event3MelonGamblingNew(Mathf.RoundToInt(Random.Range(0f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 2.5f)), 0f, (float)gameController.GetComponent<InventoryController>().EatingCounter * 4f));
							Granny.GetComponent<EnemyAIGranny>().grannysVarSpeed = 12.6f;
							Granny.GetComponent<EnemyAIGranny>().grannysAnimSpeed = 6.8f;
							Granny.GetComponent<EnemyAIGranny>().Event2GrannySpeed = 5;
						}
						else
						{
							ShowText2("I need at least 50 melons");
						}
					});
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "EventChallenge3Gift")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						int num = Random.Range(1, 16);
						if (num == 1)
						{
							if (event3GiveSpecialKey == 0)
							{
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havespecialkey = true;
								specialkey.SetActive(true);
								dropObjectButton.SetActive(true);
								mittenRing.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								event3GiveSpecialKey++;
							}
							else if (event3GiveSpecialKey == 1)
							{
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveHammare = true;
								hammare.SetActive(true);
								dropObjectButton.SetActive(true);
								mittenRing.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
								event3GiveSpecialKey++;
							}
							else
							{
								ShowText2("Some melons have appeared in the special room");
								Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-11.11f, 6.08f), 39f, Random.Range(-4.89f, 9.6f)), Quaternion.identity);
								Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-11.11f, 6.08f), 39f, Random.Range(-4.89f, 9.6f)), Quaternion.identity);
								Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-11.11f, 6.08f), 39f, Random.Range(-4.89f, 9.6f)), Quaternion.identity);
								Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-11.11f, 6.08f), 39f, Random.Range(-4.89f, 9.6f)), Quaternion.identity);
								Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-11.11f, 6.08f), 39f, Random.Range(-4.89f, 9.6f)), Quaternion.identity);
							}
						}
						if (num == 2)
						{
							if (Random.Range(1, 31) == 1)
							{
								ShowText2("Jackpot! You have 150 more melons now!");
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter += 150;
								AchievementSaveManager.Instance.UnlockAchievement("Jackpot");
							}
							else
							{
								ShowText2("Nothing happens");
							}
						}
						if (num == 3)
						{
							Object.Instantiate<Transform>(newmelon, new Vector3(((Component)raycastHit.collider).gameObject.transform.position.x, ((Component)raycastHit.collider).gameObject.transform.position.y + 1f, ((Component)raycastHit.collider).gameObject.transform.position.z), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(((Component)raycastHit.collider).gameObject.transform.position.x, ((Component)raycastHit.collider).gameObject.transform.position.y + 2f, ((Component)raycastHit.collider).gameObject.transform.position.z), Quaternion.identity);
						}
						if (num == 4)
						{
							ShowText2("You have melon vase. It can make noises");
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havevas = true;
							vas.SetActive(true);
							dropObjectButton.SetActive(true);
							mittenRing.SetActive(false);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(plockaUppObject);
						}
						if (num == 5)
						{
							ShowText2("Some melons have appeared in the house");
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
							Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
						}
						if (num == 6)
						{
							ShowText2("Now you move a bit faster");
							GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().SpeedCrouch += 0.5f;
							GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().SpeedStandUp++;
						}
						if (num == 7)
						{
							ShowText2("Now you move a bit slower");
							GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().SpeedCrouch -= 0.5f;
							GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().SpeedStandUp--;
							if (GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().SpeedStandUp <= 3f)
							{
								AchievementSaveManager.Instance.UnlockAchievement("IShowSlowness");
							}
						}
						if (num == 8)
						{
							ShowText2("Now house is 25% darker");
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<startNewDay>().ChangeFogValueStart(RenderSettings.fogStartDistance, RenderSettings.fogStartDistance * 0.75f, 3f));
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<startNewDay>().ChangeFogValueEnd(RenderSettings.fogEndDistance, RenderSettings.fogEndDistance * 0.75f, 3f));
						}
						if (num == 9)
						{
							ShowText2("You can gamble RIGHT NOW");
							gameController.GetComponent<startNewDay>().GamblingButton1.GetComponent<Event3GamblingButton>().GamblingTimer = 180f;
							gameController.GetComponent<startNewDay>().GamblingButton2.GetComponent<Event3GamblingButton>().GamblingTimer = 180f;
							gameController.GetComponent<startNewDay>().GamblingButton3.GetComponent<Event3GamblingButton>().GamblingTimer = 180f;
						}
						if (num == 10)
						{
							ShowText2("You can breath flame for about 30 seconds");
							((MonoBehaviour)this).StartCoroutine(sprayButton.GetComponent<sprayPepper>().Event3Breath());
						}
						if (num == 11)
						{
							ShowText2("You made some noice");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(placeBattery);
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, gameController.GetComponent<startNewDay>().Player.transform.position, ((Component)this).transform.rotation);
							}
							else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
							}
							else
							{
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, gameController.GetComponent<startNewDay>().Player.transform.position, ((Component)this).transform.rotation);
							}
						}
						if (num == 12)
						{
							ShowText2("You have 5 melons less");
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter -= 5;
							if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter < 0)
							{
								ShowText2("You have 5 melons less. You are in debt now");
							}
						}
						if (num == 13)
						{
							ShowText2("You have 5 melons more");
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter += 5;
						}
						if (num == 14)
						{
							ShowText2("Now house is 25% brighter");
							textTimerOnOff = true;
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<startNewDay>().ChangeFogValueStart(RenderSettings.fogStartDistance, RenderSettings.fogStartDistance * 1.25f, 3f));
							((MonoBehaviour)this).StartCoroutine(gameController.GetComponent<startNewDay>().ChangeFogValueEnd(RenderSettings.fogEndDistance, RenderSettings.fogEndDistance * 1.25f, 3f));
						}
						if (num == 15)
						{
							if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter < 25)
							{
								ShowText2("You took out a loan for 15 watermelons, in a minute you must pay back 25 melons");
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter += 15;
								((MonoBehaviour)this).StartCoroutine(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Event3LoanNew(25));
							}
							else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter < 50)
							{
								ShowText2("You took out a loan for 30 watermelons, in a minute you must pay back 70 melons");
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter += 30;
								((MonoBehaviour)this).StartCoroutine(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Event3LoanNew(70));
							}
							else
							{
								ShowText2("You took out a loan for 50 watermelons, in a minute you must pay back 125 melons");
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).EatingCounter += 50;
								((MonoBehaviour)this).StartCoroutine(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Event3LoanNew(125));
							}
						}
						Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
					}
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "bluekabel")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (InventoryControllerScript.haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor1.gameObject.SetActive(false);
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).DoorLockLamp4.SetActive(true);
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).lampa1ok = true;
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
							avklipptKabel.SetActive(true);
							startNewDayScript.ProgressValue += 5;
							if (startNewDayScript.AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
						else
						{
							ShowText2("I need cutting pliers");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "bluekabelcellar")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								LampaDoor2.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 1f, 0f);
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).lampa2ok = true;
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
							}
							Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
							avklipptKabelCellar.SetActive(true);
							startNewDayScript.ProgressValue += 5;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-0.522f, 8.12f, -7.913f), ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-0.522f, 8.12f, -7.913f), ((Component)this).transform.rotation);
							}
						}
						else
						{
							ShowText2("I need cutting pliers");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "bluekabelvind")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveAvbitare)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								fan.GetComponent<Animation>().Stop("FanSpinn");
								fanCollider.SetActive(false);
							}
							Object.Destroy((Object)(object)KabelVind);
							avklipptKabelVind.SetActive(true);
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-15f, 28.2f, 7f), ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(-15f, 28.2f, 7f), ((Component)this).transform.rotation);
							}
						}
						else
						{
							ShowText2("I need cutting pliers");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "planka")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							if (!playSound)
							{
								if (((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort)
								{
									playSound = true;
									Object.Destroy((Object)(HingeJoint)((Component)raycastHit.collider).gameObject.GetComponent(typeof(HingeJoint)));
									((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka2Bort = true;
									((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
									startNewDayScript.ProgressValue += 5;
									((MonoBehaviour)this).StartCoroutine(PlankaDisappear(((Component)raycastHit.collider).gameObject));
								}
								else
								{
									((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
									playSound = true;
									((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
									((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort = true;
									startNewDayScript.ProgressValue += 5;
								}
							}
						}
						else
						{
							ShowText2("I need a hammer");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "plankavind")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
							((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
							((Component)raycastHit.collider).gameObject.tag = "plankawalk";
						}
						else
						{
							ShowText2("I need a hammer");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "PlankaOH2")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
							((Object)((Component)raycastHit.collider).gameObject).name = "PlankBroken";
							((Component)raycastHit.collider).gameObject.transform.rotation = Quaternion.Euler(5f, 90f, 0f);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
							((MonoBehaviour)this).StartCoroutine(PlankaDisappear(((Component)raycastHit.collider).gameObject));
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveChocolateKey)
						{
							((Object)((Component)raycastHit.collider).gameObject).name = "PlankOpen";
							ChocolateDoor = ((Component)raycastHit.collider).gameObject;
							ChocolateDoorOpened = true;
						}
						else
						{
							ShowText2("I need a chocolate key or I can break this door with a hammer");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "exitdoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveexitKey || (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey && PlayerPrefs.GetInt("EventChallenge2") == 1))
						{
							if (!playSound)
							{
								playSound = true;
								((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).openExitdoor());
							}
						}
						else if (PlayerPrefs.GetInt("EventChallenge2") == 1 && !((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey)
						{
							ShowText2("I need a green key");
						}
						else
						{
							ShowText2("I need a master key");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLocked);
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "hanglock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havehanglockKey || (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havepadlockCode && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 25))
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((Rigidbody)Bom.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).hangLockBort = true;
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								startNewDayScript.ProgressValue += 10;
							}
						}
						else
						{
							ShowText2("I need a padlock key");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "hanglockgarage")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havehanglockKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								((openDoors)(object)doorRayHolder.GetComponent(typeof(openDoors))).garageportLock = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 4 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 4)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
								}
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
								}
							}
						}
						else
						{
							ShowText2("I need a padlock key");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "phpadlock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplayhouseKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								playhouseDoor.gameObject.tag = "innerdoorClosed";
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
							}
						}
						else
						{
							ShowText2("I need a playhouse key");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "dpadlock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havepadlockCode)
						{
							if (!playSound)
							{
								playSound = true;
								((Rigidbody)((Component)raycastHit.collider).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
								DdoorLock.GetComponent<Animation>().Play("DlockAnim");
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).DpadlockBort = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								startNewDayScript.ProgressValue += 10;
							}
						}
						else
						{
							ShowText2("I need a padlock code");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "batteryholder")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebattery)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).GetComponent<Animation>().Play("BatteryLockOpen");
								((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).batteryLockOk = true;
								batterySpak.GetComponent<Animation>().Play("BattSpakOK");
								battery.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebattery = false;
								batteryOnPlace.SetActive(true);
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placeBattery);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								startNewDayScript.ProgressValue += 10;
							}
						}
						else
						{
							ShowText2("I need a battery");
							batterySpak.GetComponent<Animation>().Play("BattSpakNotOK");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "safedoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havesafeKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("safeDoorOpen");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((Component)this).GetComponent<AudioSource>().PlayOneShot(safeDoorOpen);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a safe key");
							((Component)this).GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "vapenskopdoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveweaponKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("VapenDoorOpen");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((Component)this).GetComponent<AudioSource>().PlayOneShot(vapenDoorOpen);
								if (PlayerPrefs.GetInt("DiffData") == 7)
								{
									startNewDayScript.ProgressValue += 10;
								}
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else if (PlayerPrefs.GetInt("DiffData") == 7)
						{
							((Component)this).GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							ShowText2("I need a Gabon key");
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
						else
						{
							((Component)this).GetComponent<AudioSource>().PlayOneShot(safeDoordoorLocked);
							ShowText2("I need a weapon key");
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "tavelbitar")
				{
					if (!((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).allaTavelbitarOnPlace)
					{
						pickUpButton.SetActive(true);
						mittenRing.SetActive(true);
						if (pickUp)
						{
							pickUp = false;
							ShowText2("Something is missing here");
						}
					}
					else
					{
						pickUpButton.SetActive(false);
						mittenRing.SetActive(false);
					}
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screw1")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Screw1Open");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplatta)(object)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv1 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplatta)(object)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw1Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screw2")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Screw2Open");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplatta)(object)skruvPlatta.GetComponent(typeof(skruvplatta))).skruv2 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplatta)(object)skruvPlatta.GetComponent(typeof(skruvplatta))).Screw2Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "camera")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveHammare)
						{
							if (!playSound)
							{
								playSound = true;
								kamera.SetActive(false);
								kameraBroken.SetActive(true);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 2 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 2)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
								}
								if (!playerInPrison)
								{
									kameraSeeTrigger.SetActive(false);
									galler.GetComponent<Collider>().enabled = true;
									gallerColliders.SetActive(false);
								}
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((Component)this).GetComponent<AudioSource>().PlayOneShot(hitCam);
							}
						}
						else
						{
							ShowText2("I need a hammer");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "giljocutarea")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havemelon)
						{
							if (!playSound)
							{
								playSound = true;
								giljoCutArea.SetActive(false);
								melonInPlace.SetActive(true);
								((giljotinTrigger)(object)giljotin.GetComponent(typeof(giljotinTrigger))).meloninPlace = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placeMelon);
								melon.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havemelon = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("This is a dangerous cutting tool. I hope I don't end up here");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "stortkugg" && startNewDayScript.AnomalyNR != 36)
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg1)
						{
							if (!playSound)
							{
								playSound = true;
								kugg1inPlace.SetActive(true);
								kugg1OK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 6 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 6)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
								}
								kugg1.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg1 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg2OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
								}
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg2)
						{
							if (!playSound)
							{
								playSound = true;
								kugg2inPlace.SetActive(true);
								kugg2OK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 6 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 6)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
								}
								kugg2.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg2 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg1OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
								}
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("Something is missing here");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "stortkugg" && startNewDayScript.AnomalyNR == 36)
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg1)
						{
							if (!playSound)
							{
								playSound = true;
								kugg1inPlace.SetActive(true);
								kugg1OK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg1.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg1 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg2OK && kugg3OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
								}
							}
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg2)
						{
							if (!playSound)
							{
								playSound = true;
								kugg2inPlace.SetActive(true);
								kugg2OK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								kugg2.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg2 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg1OK && kugg3OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
								}
							}
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg3)
						{
							if (!playSound)
							{
								playSound = true;
								kugg3inPlace.SetActive(true);
								kugg3OK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								InventoryControllerScript.kugg3Hand.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havekugg3 = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (kugg1OK && kugg2OK)
								{
									playHouseLucka.gameObject.GetComponent<Animation>().Play("openToyLock");
									((Component)raycastHit.collider).gameObject.tag = "Untagged";
								}
							}
						}
						else
						{
							ShowText2("Something is missing here");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "brunn")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebrunnsvev)
						{
							if (!playSound)
							{
								playSound = true;
								brunnsvevInPlace.SetActive(true);
								pickUpButton.SetActive(false);
								((playerVevar)(object)brunnsvevsHolder.GetComponent(typeof(playerVevar))).vevInPlace = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Collider>().enabled = false;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								brunnsvev.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebrunnsvev = false;
								pickUp = false;
								dropObject = false;
								dropObjectButton.SetActive(false);
								mittenRing.SetActive(false);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a winch handle");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screwout1")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("ELscrew");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv1 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw1Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screwout2")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("ELscrew");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv2 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw2Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screwout3")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("ELscrew");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv3 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw3Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "screwout4")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havescrewdriver)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("ELscrew");
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).skruv4 = true;
								((MonoBehaviour)this).StartCoroutine(((skruvplattaOutside)(object)skruvPlattaOutside.GetComponent(typeof(skruvplattaOutside))).Screw4Bort());
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a screwdriver");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "topplocksskruv")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havewrench)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar = ((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).topplocksskruvar + 1f;
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(skruva);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar++;
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a wrench");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "topplockPlace")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetopplock)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).topplockOK = true;
								topplockInPlace.SetActive(true);
								topplock.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetopplock = false;
								dropObjectButton.SetActive(false);
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need an engine part");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "carbatteryPlace")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havecarbattery)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).batteryOK = true;
								carbatteryInPlace.SetActive(true);
								carbattery.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havecarbattery = false;
								Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a car battery");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "fueltankPlace")
				{
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegascan && InventoryControllerScript.OpenedCarTrunk && !playSound)
						{
							playSound = true;
							ShowText2("I need a gasoline can");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "sparkplugPlace")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havesparkplug)
						{
							if (!playSound)
							{
								playSound = true;
								((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).sparkplugOK = true;
								sparkPlugInPlace.SetActive(true);
								sparkPlugCable.SetActive(false);
								sparkplug.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havesparkplug = false;
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a spark plug");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "platevind")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havemeat)
						{
							if (!playSound)
							{
								playSound = true;
								if (startNewDayScript.PrimeAnomalyNR == 13 && !startNewDayScript.ThisMadeMeThinkAchievementFail)
								{
									AchievementSaveManager.Instance.UnlockAchievement("ThisMadeMeThink");
								}
								if (spider.activeSelf)
								{
									((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).foodTime = true;
									((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).spiderEatTimer = 0f;
								}
								((Component)this).GetComponent<AudioSource>().PlayOneShot(meatPlate);
								meatOnPlate.SetActive(true);
								spiderTrigger.SetActive(false);
								meat.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havemeat = false;
								dropObjectButton.SetActive(false);
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NightmareMeatItem.SetActive(true);
							}
						}
						else if (InventoryControllerScript.haveSmallPlant)
						{
							if (!playSound)
							{
								playSound = true;
								GrassAchievement.SetActive(true);
								spiderTrigger.SetActive(false);
								InventoryControllerScript.SmallPlantHand.SetActive(false);
								InventoryControllerScript.havemeat = false;
								dropObjectButton.SetActive(false);
								if (spider.activeSelf)
								{
									((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
									((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).VeganAchievement = true;
								}
							}
						}
						else
						{
							ShowText2("I need something to feed a spider with");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "vind2lock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havespecialkey)
						{
							if (!playSound)
							{
								playSound = true;
								specialkeyLock.GetComponent<Animation>().Play("vind2LockOpen");
								specialkeyDoor.GetComponent<Animation>().Play("vind2DoorOpen");
								specialkeyLock.GetComponent<AudioSource>().PlayOneShot(vind2Lockopen);
								specialkeyDoor.GetComponent<AudioSource>().PlayOneShot(vind2Dooropen);
								specialkeyInPlace.SetActive(true);
								specialkey.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havespecialkey = false;
								dropObjectButton.SetActive(false);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a special key");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "bookplace")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebook)
						{
							if (!playSound)
							{
								playSound = true;
								secretWall.GetComponent<Animation>().Play("fakeWallMove");
								bookInPlace.SetActive(true);
								book.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebook = false;
								dropObjectButton.SetActive(false);
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 3 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 3)
								{
									((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
								}
								if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).freeze)
								{
									Granny.SetActive(false);
									Granny.transform.position = GrannyStartPos.position;
									Granny.SetActive(true);
								}
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).slendrinaMomAppeard = true;
							}
						}
						else
						{
							ShowText2("Maybe I need to put something here");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "Spak")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Spak");
							((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
							((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).extremeLockOk = true;
							extremeLockOn.SetActive(false);
							extremeLockOff.SetActive(true);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
							startNewDayScript.ProgressValue += 10;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, new Vector3(25f, 13f, -4f), ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "lockmotor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						ShowText2("Maybe there is a way to turn this electric lock off");
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "remoteLock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp && !((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveremote)
					{
						pickUp = false;
						ShowText2("I need a remote control");
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "birdseedplate")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havebirdSeed && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 25)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								((CrowControl)(object)crow.GetComponent(typeof(CrowControl))).CrowStartEat = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(fillSeed);
								if (startNewDayScript.AnomalyNR == 9 && !startNewDayScript.DiedByAnomaly)
								{
									startNewDayScript.AnomalyTimer = Time.timeSinceLevelLoad;
								}
								if (startNewDayScript.AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else
						{
							ShowText2("I need a bird seed");
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "sprint1")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("sprintAnim");
							((Component)raycastHit.collider).gameObject.tag = "Untagged";
							((prisonDoorOpenClose)(object)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint1Bort = true;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "prisondoorlocked")
				{
					mittenRing.SetActive(false);
					pickUp = false;
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "sprint2")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("sprintAnim");
							((Component)raycastHit.collider).gameObject.tag = "Untagged";
							((prisonDoorOpenClose)(object)prisonDoor.GetComponent(typeof(prisonDoorOpenClose))).sprint2Bort = true;
						}
						if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
						{
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
							((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
							{
								((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								return;
							}
							if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
							{
								Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
								return;
							}
							Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "LeverEscape")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveStick || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 7 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 7 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 35)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Spak");
								((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
								((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
								((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).EscapeLamp1.GetComponent<MeshRenderer>()).material.color = Color.green;
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever1isOK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
								if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
								{
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
									((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
									{
										((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
										Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
										return;
									}
									if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
									{
										Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
										return;
									}
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
								}
							}
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplanka)
						{
							ShowText2("This thing is long but too heavy to use it there");
						}
						else
						{
							ShowText2("I need something long");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "HoleInWall")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveStick)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
								Object.Destroy((Object)(object)GameObject.Find("HyllaHall").GetComponent<BoxCollider>());
							}
						}
						else
						{
							ShowText2("This is a hole in the wall");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GreenDrawer")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "ByroLoda";
								((Component)raycastHit.collider).gameObject.tag = "loda2Closed";
							}
						}
						else
						{
							ShowText2("I need a green key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BlueDrawer")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveBlueKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "ByroLoda";
								((Component)raycastHit.collider).gameObject.tag = "loda2Closed";
							}
						}
						else
						{
							ShowText2("I need a blue key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GreenDoor" && ((Component)this).gameObject.transform.position.y < 18.5f)
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey || ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveDoorUnlock)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "GarderobDoor";
								((Component)raycastHit.collider).gameObject.tag = "garde1Closed";
							}
						}
						else
						{
							ShowText2("I need a green key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "GreenKitchenDoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "KitchenDoor";
								((Component)raycastHit.collider).gameObject.tag = "kitchenDoor1Closed";
							}
						}
						else
						{
							ShowText2("I need something green");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BlueDoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveBlueKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "Unnamed";
								((Component)raycastHit.collider).gameObject.tag = "kitchenDoor1Closed";
							}
						}
						else
						{
							ShowText2("I need a blue key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "DarkDoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveDarkKey)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("KitchenDoor1Open");
								((Object)((Component)raycastHit.collider).gameObject).name = "Unnamed";
								((Component)raycastHit.collider).gameObject.tag = "Untagged";
								startNewDayScript.ProgressValue += 10;
							}
						}
						else
						{
							ShowText2("I need a dark key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "LeverEscape2")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Spak");
							((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
							((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp2.GetComponent<MeshRenderer>()).material.color = Color.green;
							((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).EscapeLamp2.GetComponent<MeshRenderer>()).material.color = Color.green;
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever2isOK = true;
							((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
							((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "LeverEscape3")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (!playSound)
						{
							playSound = true;
							((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Spak");
							((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
							((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp3.GetComponent<MeshRenderer>()).material.color = Color.green;
							((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).EscapeLamp3.GetComponent<MeshRenderer>()).material.color = Color.green;
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever3isOK = true;
							((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
							((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
							if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
							{
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
								((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
								{
									((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
									Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
									return;
								}
								if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
								{
									Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
									return;
								}
								Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)raycastHit.collider).gameObject.transform.position, ((Component)this).transform.rotation);
							}
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "LeverEscape4")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (wireSet)
						{
							if (!playSound)
							{
								playSound = true;
								((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("Spak");
								((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
								((Renderer)((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).LeverLamp4.GetComponent<MeshRenderer>()).material.color = Color.green;
								((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).EscapeLamp4.GetComponent<MeshRenderer>()).material.color = Color.green;
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Lever4isOK = true;
								((Component)this).GetComponent<AudioSource>().PlayOneShot(drarIspak);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
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
						}
						else
						{
							ShowText2("This lever has no power");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "WirePlace")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveWire)
						{
							if (!playSound)
							{
								playSound = true;
								wireSet = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "Untagged";
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).WireOnPlace.SetActive(true);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).WireHand.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveWire = false;
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
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
						}
						else
						{
							ShowText2("I need a cable");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "ButtonHole")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveButtonNewEscape)
						{
							if (!playSound)
							{
								playSound = true;
								((Object)((Component)raycastHit.collider).gameObject).name = "LiftButton";
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).ButtonNewEscapeHand.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveButtonNewEscape = false;
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).Button.transform.position = new Vector3(34.733f, 24.162f, 9.69f);
								((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).Button.GetComponent<MeshRenderer>()).material.color = Color.red;
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
								((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
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
						}
						else
						{
							ShowText2("I need a button");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape1" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape2" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape3" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape4" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape5" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape6" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape7")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey && ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly18SecretEscape" + ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Anomaly18TVRemoteRandom)
						{
							((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).Anomaly18Escape());
						}
						else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey && ((Object)((Component)raycastHit.collider).gameObject).name != "Anomaly18SecretEscape" + ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).Anomaly18TVRemoteRandom)
						{
							ShowText2("This is a fake door");
						}
						else if (!((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey)
						{
							ShowText2("I need something green");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "MeatBoxLock")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (InventoryControllerScript.haveRedKey && startNewDayScript.AnomalyNR != 27 && startNewDayScript.AnomalyNR != 36 && startNewDayScript.PrimeAnomalyNR != 18)
						{
							if (!playSound)
							{
								playSound = true;
								CaramelDoorAnim = -1f;
								((Object)((Component)raycastHit.collider).gameObject).name = "MeatBoxLockOpen";
								CaramelDoor = ((Component)raycastHit.collider).gameObject;
								CaramelDoorOpened = true;
							}
						}
						else
						{
							ShowText2("I need a caramel key");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "LiftPanel")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						ShowText2("This seems to be an elevator engine");
					}
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "RedDoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveRedKey || (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey && startNewDayScript.AnomalyNR != 36) || ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveBlueKey)
						{
							if (!playSound)
							{
								playSound = true;
								RedDoorCount++;
								if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveRedKey)
								{
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).RedKeyHand.SetActive(false);
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveRedKey = false;
								}
								if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey)
								{
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).LostKeyHand.SetActive(false);
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveLostKey = false;
								}
								if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveBlueKey)
								{
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).BlueKeyHand.SetActive(false);
									((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveBlueKey = false;
								}
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								if (RedDoorCount == 7)
								{
									if (startNewDayScript.AnomalyNR == 27)
									{
										((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).Anomaly27Escape());
									}
									else if (startNewDayScript.AnomalyNR == 36)
									{
										((Component)raycastHit.collider).gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
										((Object)raycastHit.collider).name = "Unnamed";
									}
								}
								else if (RedDoorCount == 6)
								{
									ShowText2("1 key left to open this door");
								}
								else
								{
									ShowText2(7 - RedDoorCount + " keys left to open this door");
								}
							}
						}
						else if (RedDoorCount == 6)
						{
							ShowText2("1 key left to open this door");
						}
						else
						{
							ShowText2(7 - RedDoorCount + " keys left to open this door");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "PrimeRedDoor")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havePrimeRedKey)
						{
							if (!playSound)
							{
								playSound = true;
								RedDoorCount++;
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).PrimeRedKeyHand.SetActive(false);
								((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havePrimeRedKey = false;
								dropObjectButton.SetActive(false);
								((Component)this).GetComponent<AudioSource>().PlayOneShot(klippKabel);
								gameController.GetComponent<startNewDay>().ProgressBehavior += 3;
								if (RedDoorCount == 4)
								{
									((MonoBehaviour)this).StartCoroutine(((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).PrimeAnomaly9Escape());
								}
								else if (RedDoorCount == 3)
								{
									ShowText2("1 key left to open this door");
								}
								else
								{
									ShowText2(4 - RedDoorCount + " keys left to open this door");
								}
							}
						}
						else if (RedDoorCount == 3)
						{
							ShowText2("1 key left to open this door");
						}
						else
						{
							ShowText2(4 - RedDoorCount + " keys left to open this door");
						}
					}
					audio();
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "BaloonEvilChair")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						Object.Destroy((Object)(object)((Component)((Component)raycastHit.collider).gameObject.transform.parent).gameObject);
						((Component)this).GetComponent<AudioSource>().PlayOneShot(PrimeAnomaly11PopUp);
						ShowText2("I just have destroyed an evil chair's clone!");
						PrimeAnomaly18LadderCount++;
						if (PrimeAnomaly18LadderCount == 15)
						{
							AchievementSaveManager.Instance.UnlockAchievement("BaloonParty");
						}
					}
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "PrimeAnomaly18Ladder")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveStick)
						{
							PrimeAnomaly18LadderCount++;
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).StickHand.SetActive(false);
							((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveStick = false;
							dropObjectButton.SetActive(false);
							((Component)this).GetComponent<AudioSource>().PlayOneShot(placebrunnsvev);
							gameController.GetComponent<startNewDay>().ProgressValue += 3;
							if (startNewDayScript.PrimeAnomalyNR == 18)
							{
								if (PrimeAnomaly18LadderCount == 1)
								{
									((Component)GameObject.Find("PrimeAnomaly18NewObjects").transform.GetChild(0)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 2)
								{
									((Component)GameObject.Find("PrimeAnomaly18NewObjects").transform.GetChild(1)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 3)
								{
									((Component)GameObject.Find("PrimeAnomaly18NewObjects").transform.GetChild(2)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 4)
								{
									((Component)GameObject.Find("PrimeAnomaly18NewObjects").transform.GetChild(3)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 5)
								{
									((Object)((Component)raycastHit.collider).gameObject).name = "PrimeAnomaly18LadderIsReady";
									((Component)GameObject.Find("PrimeAnomaly18NewObjects").transform.GetChild(4)).gameObject.SetActive(true);
								}
							}
							else if (startNewDayScript.AnomalyNR == 36)
							{
								if (PrimeAnomaly18LadderCount == 1)
								{
									((Component)GameObject.Find("Anomaly36NewObjects").transform.GetChild(0)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 2)
								{
									((Component)GameObject.Find("Anomaly36NewObjects").transform.GetChild(1)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 3)
								{
									((Component)GameObject.Find("Anomaly36NewObjects").transform.GetChild(2)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 4)
								{
									((Component)GameObject.Find("Anomaly36NewObjects").transform.GetChild(3)).gameObject.SetActive(true);
								}
								else if (PrimeAnomaly18LadderCount == 5)
								{
									((Object)((Component)raycastHit.collider).gameObject).name = "PrimeAnomaly18LadderIsReady";
									((Component)GameObject.Find("Anomaly36NewObjects").transform.GetChild(4)).gameObject.SetActive(true);
								}
							}
						}
						else
						{
							ShowText2("Something is missing here");
						}
					}
				}
				else if (((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly36Collectible")
				{
					pickUpButton.SetActive(true);
					mittenRing.SetActive(true);
					if (pickUp)
					{
						pickUp = false;
						startNewDayScript.Anomaly36ItemsCollected++;
						AudioSourceScript.PlayOneShot(plockaUppObject);
						Object.Destroy((Object)(object)((Component)raycastHit.collider).gameObject);
						mittenRing.SetActive(false);
					}
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "Untagged")
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "golv")
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "grus")
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "car")
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
				else if (((Component)raycastHit.collider).gameObject.tag == "smalldoorLocked")
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
				else
				{
					pickUpButton.SetActive(false);
					mittenRing.SetActive(false);
					HideText();
				}
			}
			else
			{
				pickUpButton.SetActive(false);
				mittenRing.SetActive(false);
				HideText();
			}
			if (startNewDayScript.AnomalyNR == 31 && (((Component)raycastHit.collider).gameObject.tag == "Untagged" || ((Object)((Component)raycastHit.collider).gameObject).name == "Anomaly31Gift"))
			{
				HideText();
			}
		}
		else
		{
			pickUpButton.SetActive(false);
		}
		if (startNewDayScript.AnomalyNR == 25)
		{
			RayDistance = ((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).handRangePickUp;
		}
		if (startNewDayScript.AnomalyNR == 44)
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
		if (CaramelDoorOpened)
		{
			CaramelDoor.transform.rotation = Quaternion.Slerp(Quaternion.Euler(111.571f, 0f, 180f), Quaternion.Euler(13.673f, 0f, 180f), CaramelDoorAnim);
			if (CaramelDoorAnim <= 0f)
			{
				((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).BoxHand.GetComponent<MeshRenderer>()).material.color = new Color(0.8181724f, 0.9433962f, 0.2091492f, Mathf.Abs(CaramelDoorAnim));
			}
			CaramelDoorAnim += Time.deltaTime;
		}
		if (!ChocolateDoorOpened)
		{
			return;
		}
		ChocolateHandAnim += Time.deltaTime;
		((Renderer)((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).DoorHand.GetComponent<MeshRenderer>()).material.color = new Color(0.2f, 0.1f, 0f, 1f - Mathf.Abs(ChocolateHandAnim));
		if (ChocolateHandAnim > 1f)
		{
			ChocolateDoor.transform.position = new Vector3(ChocolateDoor.transform.position.x, ChocolateDoor.transform.position.y, ChocolateDoor.transform.position.z + 1.4f * Time.deltaTime);
			if (ChocolateDoor.transform.position.z >= -32f)
			{
				ChocolateDoorOpened = false;
			}
		}
	}

	public virtual void audio()
	{
		playSound = false;
	}

	public virtual IEnumerator PlankaDisappear(GameObject plankaBroken)
	{
		Physics.IgnoreCollision(gameController.GetComponent<startNewDay>().Player.GetComponent<Collider>(), plankaBroken.GetComponent<Collider>(), true);
		Physics.IgnoreCollision(((Component)gameController.GetComponent<startNewDay>().playerCam).GetComponent<Collider>(), plankaBroken.GetComponent<Collider>(), true);
		yield return (object)new WaitForSeconds(8f);
		plankaBroken.SetActive(false);
	}

	public void pressPickUp()
	{
		if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			pickUp = true;
		}
	}

	private void ShowText(string text)
	{
		interactionTextObject.SetActive(true);
		interactionText.text = text;
	}

	private void HideText()
	{
		interactionTextObject.SetActive(false);
	}

	public void ShowText2(string text)
	{
		interactionTextObject2.SetActive(true);
		interactionText2.text = text;
		((MonoBehaviour)this).StartCoroutine(ShowText2ForSomeTime(3f));
	}

	private IEnumerator ShowText2ForSomeTime(float time)
	{
		yield return (object)new WaitForSeconds(time);
		HideText2();
	}

	private void HideText2()
	{
		interactionTextObject2.SetActive(false);
	}

	public void ShowText3(string text)
	{
		interactionTextObject3.SetActive(true);
		interactionText3.text = text;
		((MonoBehaviour)this).StartCoroutine(ShowText3ForSomeTime(5f));
	}

	private IEnumerator ShowText3ForSomeTime(float time)
	{
		yield return (object)new WaitForSeconds(time);
		HideText3();
	}

	private void HideText3()
	{
		interactionTextObject3.SetActive(false);
	}

	private void PickUpItem(GameObject worldObject, GameObject handObject, string hoverText, Action onPickup = null, AudioClip sound = null)
	{
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		ShowText(hoverText);
		if (pickUp)
		{
			pickUp = false;
			InventoryControllerScript.CheckInventory();
			Object.Destroy((Object)(object)worldObject);
			handObject.SetActive(true);
			dropObjectButton.SetActive(true);
			mittenRing.SetActive(false);
			HideText();
			if ((Object)(object)sound != (Object)null)
			{
				AudioSourceScript.PlayOneShot(sound);
			}
			onPickup?.Invoke();
		}
	}

	private void IntercactWithItem(string hoverText, Action onPickup = null)
	{
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		ShowText(hoverText);
		if (pickUp)
		{
			pickUp = false;
			onPickup?.Invoke();
		}
	}

	private void Intercact(Action onPickup = null)
	{
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		if (pickUp)
		{
			pickUp = false;
			onPickup?.Invoke();
		}
	}

	private void EatMelon(GameObject worldObject, GameObject handObject, string hoverText, AudioClip sound = null)
	{
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		ShowText(hoverText);
		if (pickUp)
		{
			pickUp = false;
			Object.Destroy((Object)(object)worldObject);
			mittenRing.SetActive(false);
			InventoryControllerScript.EatingCounter++;
			HideText();
			if ((Object)(object)sound != (Object)null)
			{
				AudioSourceScript.PlayOneShot(sound);
			}
		}
	}

	private void EventChalenge2PickUp(GameObject worldObject, GameObject handObject, string hoverText, AudioClip sound = null)
	{
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		ShowText(hoverText);
		if (pickUp)
		{
			pickUp = false;
			gameController.GetComponent<startNewDay>().GetBook();
			ShowText2(8 - gameController.GetComponent<startNewDay>().EventBooks + " books left");
			if (startNewDayScript.EventBooks == 7)
			{
				ShowText2("1 book left");
			}
			if (startNewDayScript.EventBooks == 8)
			{
				ShowText2("All rats are destroyed! I just need to find a green key");
			}
			Object.Destroy((Object)(object)worldObject);
			mittenRing.SetActive(false);
			HideText();
			if ((Object)(object)sound != (Object)null)
			{
				AudioSourceScript.PlayOneShot(sound);
			}
		}
	}

	private void Anomaly18BirdSeedPickUp(GameObject worldObject, GameObject handObject, string hoverText, AudioClip sound = null)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		pickUpButton.SetActive(true);
		mittenRing.SetActive(true);
		ShowText(hoverText);
		if (pickUp)
		{
			pickUp = false;
			if (startNewDayScript.AnomalyNR == 18 && !InventoryControllerScript.havegascan)
			{
				ShowText2("But there are no birds...");
			}
			else if (startNewDayScript.AnomalyNR == 18 && InventoryControllerScript.havegascan)
			{
				((Renderer)worldObject.GetComponent<MeshRenderer>()).material.color = new Color(0.7f, 1f, 0.6f);
				worldObject.tag = "Untagged";
				CrowPoisoned = true;
				AchievementSaveManager.Instance.UnlockAchievement("PoisonSeedEscape");
				ShowText2("I've poisoned bird seed...");
			}
			mittenRing.SetActive(false);
			HideText();
			if ((Object)(object)sound != (Object)null)
			{
				AudioSourceScript.PlayOneShot(sound);
			}
		}
	}

	private void OnEnable()
	{
		HideText();
		HideText2();
		HideText3();
	}
}
