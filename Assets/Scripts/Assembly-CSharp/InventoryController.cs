using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
	public PickUp PickUpScript;

	public startNewDay startNewDayScript;

	public GameObject DropPointOriginal;

	public GameObject DropPointBugCounter;

	public GameObject SeeRay;

	public GameObject PlayerCamera;

	public Texture BoxOfSweetsTexture;

	public Texture MysteryBoxTexture;

	public GameObject Granny;

	public GameObject gameController;

	public GameObject mittenRing;

	public GameObject pickUpButton;

	public GameObject dropPoint;

	public GameObject dropPointFreezeTrap;

	public GameObject dropObjectButton;

	public GameObject newVictimCard;

	public bool haveVictimCard;

	public GameObject VictimCardHand;

	public GameObject newSmallPlant;

	public bool haveSmallPlant;

	public GameObject SmallPlantHand;

	public GameObject newkugg3;

	public bool havekugg3;

	public GameObject kugg3Hand;

	public GameObject newNightmareCrossbow;

	public bool haveNightmareCrossbow;

	public GameObject NightmareCrossbowHand;

	public GameObject AntiNightmareCrossbow;

	public GameObject arrowButton;

	public GameObject sprayButton;

	public GameObject useRemoteButton;

	public bool placeObject;

	public GameObject placeObjectButton;

	public bool plankaHighlighted;

	public GameObject highlightedPlanka;

	public GameObject highlightedPlankaTrigger;

	public GameObject plankaHole;

	public GameObject tb1;

	public Transform newtb1;

	public bool havetb1;

	public GameObject tb2;

	public Transform newtb2;

	public bool havetb2;

	public GameObject tb3;

	public Transform newtb3;

	public bool havetb3;

	public GameObject tb4;

	public Transform newtb4;

	public bool havetb4;

	public GameObject avbitare;

	public Transform newAvbitare;

	public bool haveAvbitare;

	public GameObject hammare;

	public Transform newHammare;

	public bool haveHammare;

	public GameObject vas;

	public Transform newvas;

	public bool havevas;

	public GameObject vas2;

	public Transform newvas2;

	public bool havevas2;

	public GameObject safeKey;

	public Transform newsafeKey;

	public bool havesafeKey;

	public GameObject exitKey;

	public Transform newexitKey;

	public bool haveexitKey;

	public GameObject hanglockKey;

	public Transform newhanglockKey;

	public bool havehanglockKey;

	public GameObject padlockCode;

	public Transform newpadlockCode;

	public bool havepadlockCode;

	public GameObject armborst;

	public Transform newarmborst;

	public bool havearmborst;

	public Transform newArrow;

	public bool haveArrow;

	public bool armborstArrowOK;

	public GameObject shootArrowRay;

	public GameObject weaponKey;

	public Transform newweaponKey;

	public bool haveweaponKey;

	public GameObject screwdriver;

	public Transform newscrewdriver;

	public bool havescrewdriver;

	public GameObject planka;

	public Transform newplanka;

	public bool haveplanka;

	public GameObject battery;

	public Transform newbattery;

	public bool havebattery;

	public GameObject playhouseKey;

	public Transform newplayhouseKey;

	public bool haveplayhouseKey;

	public GameObject carKey;

	public Transform newcarKey;

	public bool havecarKey;

	public GameObject melon;

	public Transform newmelon;

	public bool havemelon;

	public GameObject teddy;

	public Transform newteddy;

	public bool haveteddy;

	public GameObject kugg1;

	public Transform newkugg1;

	public bool havekugg1;

	public GameObject kugg2;

	public Transform newkugg2;

	public bool havekugg2;

	public GameObject message;

	public Transform newmessage;

	public bool havemessage;

	public GameObject brunnsvev;

	public Transform newbrunnsvev;

	public bool havebrunnsvev;

	public GameObject oldShotgun;

	public GameObject oldShotgunAnim;

	public Transform newoldShotgun;

	public bool haveoldShotgun;

	public bool oldShotgunLoaded;

	public GameObject shootButton;

	public GameObject shootRay;

	public GameObject ammo;

	public GameObject gunDel1;

	public Transform newgunDel1;

	public bool havegunDel1;

	public GameObject gunDel2;

	public Transform newgunDel2;

	public bool havegunDel2;

	public GameObject gunDel3;

	public Transform newgunDel3;

	public bool havegunDel3;

	public GameObject topplock;

	public Transform newtopplock;

	public bool havetopplock;

	public GameObject carbattery;

	public Transform newcarbattery;

	public bool havecarbattery;

	public GameObject gascan;

	public Transform newgascan;

	public bool havegascan;

	public GameObject wrench;

	public Transform newwrench;

	public bool havewrench;

	public GameObject sparkplug;

	public Transform newsparkplug;

	public bool havesparkplug;

	public GameObject meat;

	public Transform newmeat;

	public bool havemeat;

	public GameObject specialkey;

	public Transform newspecialkey;

	public bool havespecialkey;

	public GameObject book;

	public Transform newbook;

	public bool havebook;

	public GameObject pepperspray;

	public Transform newpepperspray;

	public bool havepepperspray;

	public GameObject remote;

	public Transform newremote;

	public bool haveremote;

	public GameObject birdSeed;

	public Transform newbirdSeed;

	public bool havebirdSeed;

	public GameObject freezeTrap;

	public Transform newfreezeTrap;

	public bool havefreezeTrap;

	public GameObject NeedShotgunText;

	public GameObject NeedhangLockKeyText;

	public GameObject NeedpadlockCodeText;

	public GameObject NeedhammerText;

	public GameObject NeedsafeKeyText;

	public GameObject NeedAvbitarTongText;

	public GameObject NeedHusnyckelText;

	public GameObject NeedCrossbowText;

	public GameObject NeedweaponKeyText;

	public GameObject NeedscrewdriverText;

	public GameObject NeedbatteryText;

	public GameObject NeedplayhouseKeyText;

	public GameObject cutThingsHereText;

	public GameObject NeedWinchhandleText;

	public GameObject NeedFindSwitchText;

	public GameObject missinTavelbitarText;

	public GameObject NeedcarKeyText;

	public GameObject NeedCarBatteryText;

	public GameObject NeedSparkPlugText;

	public GameObject emptyPlateText;

	public GameObject emptyBowlText;

	public GameObject NeedEnginePartText;

	public GameObject NeedWrenchText;

	public GameObject NeedGasolineText;

	public GameObject NeedSpecialKeyText;

	public GameObject NeedRemoteControlText;

	public GameObject CantopenDoorYetText;

	public GameObject SomethingMissingHereText;

	public GameObject somethingInsideMelonText;

	public GameObject ShotgunLoadedText;

	public GameObject MaybePutSomethingHereText;

	public GameObject MaybeUsePlanksText;

	public GameObject hangLockKeyText;

	public GameObject padlockCodeText;

	public GameObject hammerText;

	public GameObject safeKeyText;

	public GameObject AvbitarTongText;

	public GameObject HusnyckelText;

	public GameObject CrossbowText;

	public GameObject TranquilizerDartText;

	public GameObject weaponKeyText;

	public GameObject screwdriverText;

	public GameObject plankText;

	public GameObject batteryText;

	public GameObject tavelbitText;

	public GameObject playhouseKeyText;

	public GameObject melonText;

	public GameObject teddyText;

	public GameObject cogwheelText;

	public GameObject winchhandleText;

	public GameObject PartOfShotgunText;

	public GameObject ShotgunText;

	public GameObject AmmoText;

	public GameObject carKeyText;

	public GameObject EnginePartText;

	public GameObject SparkPlugText;

	public GameObject GasolineCanText;

	public GameObject CarBatteryText;

	public GameObject WrenchText;

	public GameObject MeatText;

	public GameObject specialKeyText;

	public GameObject bookText;

	public GameObject peppersprayText;

	public GameObject RemoteControlText;

	public GameObject BirdSeedText;

	public GameObject freezeTrapText;

	public bool textTimerOnOff;

	public float textTimer;

	public bool havePicture;

	public GameObject StickItem;

	public GameObject newStick;

	public bool haveStick;

	public GameObject StickHand;

	public Transform Stick;

	public GameObject LostKeyItem;

	public GameObject newLostKey;

	public bool haveLostKey;

	public GameObject LostKeyHand;

	public GameObject TVRemoteItem;

	public GameObject newTVRemote;

	public bool haveTVRemote;

	public GameObject TVRemoteHand;

	public GameObject WireItem;

	public GameObject newWire;

	public bool haveWire;

	public GameObject WireHand;

	public GameObject WireOnPlace;

	public bool TV4;

	public bool Lever1isOK;

	public bool Lever2isOK;

	public bool Lever3isOK;

	public bool Lever4isOK;

	public float AnomalyTimer10 = 30f;

	public float AnomalyTimer11 = 120f;

	public Transform[] itemsRain;

	public bool OpenedLift;

	public bool OpenedGarageDoor;

	public bool OpenedCarEscape;

	public bool OpenedCarTrunk;

	public int GabonAnomalyCounter;

	public int EatingCounter;

	public int Anomaly18TVRemoteRandom;

	public GameObject NightmareBookItem;

	public GameObject newNightmareBook;

	public bool haveNightmareBook;

	public GameObject NightmareBookHand;

	public GameObject NightmareVaseItem;

	public GameObject newNightmareVase;

	public bool haveNightmareVase;

	public GameObject NightmareVaseHand;

	public GameObject BlueKeyItem;

	public GameObject newBlueKey;

	public bool haveBlueKey;

	public GameObject BlueKeyHand;

	public bool BlueKeySpawned;

	public GameObject BlueKeyArea;

	public int BlueKeyAreaNR;

	public GameObject DoorUnlockItem;

	public GameObject newDoorUnlock;

	public bool haveDoorUnlock;

	public GameObject DoorUnlockHand;

	public GameObject DoorUnlockLamp;

	public GameObject ButtonNewEscapeItem;

	public GameObject newButtonNewEscape;

	public bool haveButtonNewEscape;

	public GameObject ButtonNewEscapeHand;

	public GameObject NightmareMelonItem;

	public GameObject newNightmareMelon;

	public bool haveNightmareMelon;

	public GameObject NightmareMelonHand;

	public GameObject NightmareHammerItem;

	public GameObject newNightmareHammer;

	public bool haveNightmareHammer;

	public GameObject NightmareHammerHand;

	public GameObject NightmareHammerItem2;

	public GameObject NightmareHammerItem3;

	public GameObject NightmareHammerItem4;

	public GameObject NightmareHammerItem5;

	public GameObject NightmareHammerItem6;

	public GameObject NightmareHammerItem7;

	public Resources c;

	public GameObject CommentTextCurse;

	public bool dontCreack;

	public bool UltraDark;

	public bool Curse5;

	public bool Curse6;

	public bool Curse7long;

	public bool Curse7short;

	public bool Curse10;

	public bool Curse14;

	public bool Curse15;

	public bool Curse16;

	public bool Curse17;

	public bool Curse19;

	public GameObject TeleportRemoteItem;

	public GameObject newTeleportRemote;

	public bool haveTeleportRemote;

	public GameObject TeleportRemoteHand;

	public float handRangePickUp;

	public float handRangeDoors;

	public float dropPower;

	public GameObject DropPointStick;

	public Texture PlankaNightmare;

	public GameObject NightmareBatteryItem;

	public GameObject newNightmareBattery;

	public bool haveNightmareBattery;

	public GameObject NightmareBatteryHand;

	public GameObject NightmareTrapItem;

	public GameObject newNightmareTrap;

	public bool haveNightmareTrap;

	public GameObject NightmareTrapHand;

	public GameObject NightmareCanItem;

	public GameObject newNightmareCan;

	public bool haveNightmareCan;

	public GameObject NightmareCanHand;

	public GameObject NightmareMeatItem;

	public GameObject RedKeyItem;

	public GameObject newRedKey;

	public bool haveRedKey;

	public GameObject RedKeyHand;

	public GameObject ChocolateKeyItem;

	public GameObject newChocolateKey;

	public bool haveChocolateKey;

	public GameObject ChocolateKeyHand;

	public GameObject NightmareWeaponKeyItem;

	public GameObject newNightmareWeaponKey;

	public bool haveNightmareWeaponKey;

	public GameObject NightmareWeaponKeyHand;

	public GameObject BoxOfSweetsItem;

	public GameObject newBoxOfSweets;

	public bool haveBoxOfSweets;

	public GameObject BoxOfSweetsHand;

	public GameObject CaramelPlank;

	public int BookRandom;

	public int BookPlaceRandom;

	public GameObject PrimeTeddyItem;

	public GameObject newPrimeTeddy;

	public bool havePrimeTeddy;

	public GameObject PrimeTeddyHand;

	public int TrueTeddyNR;

	public GameObject DarkKeyItem;

	public GameObject newDarkKey;

	public bool haveDarkKey;

	public GameObject DarkKeyHand;

	public GameObject DarkMessage;

	public GameObject Anomaly31Gift;

	public GameObject PrimeRedKeyItem;

	public GameObject newPrimeRedKey;

	public bool havePrimeRedKey;

	public GameObject PrimeRedKeyHand;

	public bool isActive;

	public float isActiveTimer;

	public Vector3[] spawnPositions;

	public GameObject NightmareRemoteItem;

	public GameObject newNightmareRemote;

	public bool haveNightmareRemote;

	public GameObject NightmareRemoteHand;

	public GameObject NightmareWrenchItem;

	public GameObject newNightmareWrench;

	public bool haveNightmareWrench;

	public GameObject NightmareWrenchHand;

	public bool Anomaly21;

	private void Update()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		if (startNewDayScript.AnomalyNR == 10 && Time.timeSinceLevelLoad > AnomalyTimer10)
		{
			Object.Instantiate<Transform>(newvas2, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			AnomalyTimer10 += 30f;
		}
		if (startNewDayScript.AnomalyNR == 11 && Time.timeSinceLevelLoad > AnomalyTimer11)
		{
			((Component)((Component)Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.identity)).transform.GetChild(0)).GetComponent<HandObjectFalls>().floor3trick = true;
			((Component)((Component)Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 30f, Random.Range(-26.3f, -13.83f)), Quaternion.identity)).transform.GetChild(0)).GetComponent<HandObjectFalls>().floor3trick = true;
			((Component)((Component)Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 40f, Random.Range(-26.3f, -13.83f)), Quaternion.identity)).transform.GetChild(0)).GetComponent<HandObjectFalls>().floor3trick = true;
			AnomalyTimer11 += 120f;
		}
		if (startNewDayScript.AnomalyNR == 91)
		{
			Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.identity);
			Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 30f, Random.Range(-26.3f, -13.83f)), Quaternion.identity);
			Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 40f, Random.Range(-26.3f, -13.83f)), Quaternion.identity);
		}
		if (startNewDayScript.AnomalyNR == 94 && GabonAnomalyCounter < 120)
		{
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			GabonAnomalyCounter++;
		}
		if (startNewDayScript.AnomalyNR == 94 && EatingCounter >= 100)
		{
			PlayerPrefs.SetInt("Anomaly94Escape", 1);
			SceneManager.LoadScene("EndScene");
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1 && Time.timeSinceLevelLoad > AnomalyTimer10)
		{
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			Object.Instantiate<Transform>(newmelon, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.identity);
			AnomalyTimer10 += 30f;
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1 && Time.timeSinceLevelLoad > AnomalyTimer11)
		{
			((Object)Object.Instantiate<GameObject>(Anomaly31Gift, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.Euler(180f, -90f, 90f))).name = "EventChallenge3Gift";
			((Object)Object.Instantiate<GameObject>(Anomaly31Gift, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.Euler(180f, -90f, 90f))).name = "EventChallenge3Gift";
			((Object)Object.Instantiate<GameObject>(Anomaly31Gift, new Vector3(Random.Range(-18f, 14f), Random.Range(3f, 40f), Random.Range(-39f, 13f)), Quaternion.Euler(180f, -90f, 90f))).name = "EventChallenge3Gift";
			AnomalyTimer11 += 30f;
		}
	}

	public virtual void CheckInventory()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Unknown result type (might be due to invalid IL or missing references)
		//IL_104a: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Unknown result type (might be due to invalid IL or missing references)
		//IL_1120: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Unknown result type (might be due to invalid IL or missing references)
		//IL_116b: Unknown result type (might be due to invalid IL or missing references)
		//IL_117b: Unknown result type (might be due to invalid IL or missing references)
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_124d: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Unknown result type (might be due to invalid IL or missing references)
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Unknown result type (might be due to invalid IL or missing references)
		//IL_133f: Unknown result type (might be due to invalid IL or missing references)
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1461: Unknown result type (might be due to invalid IL or missing references)
		//IL_1471: Unknown result type (might be due to invalid IL or missing references)
		//IL_1481: Unknown result type (might be due to invalid IL or missing references)
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_140d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501: Unknown result type (might be due to invalid IL or missing references)
		//IL_1541: Unknown result type (might be due to invalid IL or missing references)
		//IL_1551: Unknown result type (might be due to invalid IL or missing references)
		//IL_1561: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_1571: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_162d: Unknown result type (might be due to invalid IL or missing references)
		//IL_163d: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1652: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Unknown result type (might be due to invalid IL or missing references)
		//IL_169d: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_170d: Unknown result type (might be due to invalid IL or missing references)
		//IL_171d: Unknown result type (might be due to invalid IL or missing references)
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1732: Unknown result type (might be due to invalid IL or missing references)
		//IL_173d: Unknown result type (might be due to invalid IL or missing references)
		//IL_177d: Unknown result type (might be due to invalid IL or missing references)
		//IL_178d: Unknown result type (might be due to invalid IL or missing references)
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_180d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1812: Unknown result type (might be due to invalid IL or missing references)
		//IL_181d: Unknown result type (might be due to invalid IL or missing references)
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_186d: Unknown result type (might be due to invalid IL or missing references)
		//IL_187d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1882: Unknown result type (might be due to invalid IL or missing references)
		//IL_188d: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_193d: Unknown result type (might be due to invalid IL or missing references)
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_195d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19de: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ff9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2009: Unknown result type (might be due to invalid IL or missing references)
		//IL_204c: Unknown result type (might be due to invalid IL or missing references)
		//IL_205c: Unknown result type (might be due to invalid IL or missing references)
		//IL_206c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2071: Unknown result type (might be due to invalid IL or missing references)
		//IL_207c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2122: Unknown result type (might be due to invalid IL or missing references)
		//IL_2132: Unknown result type (might be due to invalid IL or missing references)
		//IL_2142: Unknown result type (might be due to invalid IL or missing references)
		//IL_2147: Unknown result type (might be due to invalid IL or missing references)
		//IL_2152: Unknown result type (might be due to invalid IL or missing references)
		//IL_218f: Unknown result type (might be due to invalid IL or missing references)
		//IL_219f: Unknown result type (might be due to invalid IL or missing references)
		//IL_21af: Unknown result type (might be due to invalid IL or missing references)
		//IL_21b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_20bf: Unknown result type (might be due to invalid IL or missing references)
		Transform transform = PlayerCamera.transform;
		RaycastHit val = default;
		Vector3 val2 = SeeRay.transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(SeeRay.transform.position, val2, ref val, 1f) && !Anomaly21)
		{
			dropPoint = DropPointBugCounter;
		}
		else
		{
			dropPoint = DropPointOriginal;
		}
		if (startNewDayScript.AnomalyNR != 92)
		{
			dropObjectButton.SetActive(false);
			if (haveAvbitare)
			{
				avbitare.SetActive(false);
				haveAvbitare = false;
				((Component)Object.Instantiate<Transform>(newAvbitare, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveHammare)
			{
				hammare.SetActive(false);
				haveHammare = false;
				((Component)Object.Instantiate<Transform>(newHammare, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havevas)
			{
				vas.SetActive(false);
				havevas = false;
				if (startNewDayScript.AnomalyNR == 21)
				{
					((Component)Object.Instantiate<Transform>(newvas, startNewDayScript.Anomaly21VasDropPoint.transform.position, startNewDayScript.Anomaly21VasDropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				}
				else
				{
					((Component)Object.Instantiate<Transform>(newvas, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				}
			}
			else if (havesafeKey)
			{
				safeKey.SetActive(false);
				havesafeKey = false;
				((Component)Object.Instantiate<Transform>(newsafeKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveexitKey)
			{
				exitKey.SetActive(false);
				haveexitKey = false;
				((Component)Object.Instantiate<Transform>(newexitKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havehanglockKey)
			{
				hanglockKey.SetActive(false);
				havehanglockKey = false;
				((Component)Object.Instantiate<Transform>(newhanglockKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havepadlockCode)
			{
				padlockCode.SetActive(false);
				havepadlockCode = false;
				((Component)Object.Instantiate<Transform>(newpadlockCode, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havearmborst)
			{
				armborst.SetActive(false);
				havearmborst = false;
				arrowButton.SetActive(false);
				shootArrowRay.SetActive(false);
				((Component)Object.Instantiate<Transform>(newarmborst, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				if (armborstArrowOK)
				{
					((Component)Object.Instantiate<Transform>(newArrow, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
					haveArrow = false;
					armborstArrowOK = false;
				}
			}
			else if (haveweaponKey)
			{
				weaponKey.SetActive(false);
				haveweaponKey = false;
				((Component)Object.Instantiate<Transform>(newweaponKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havescrewdriver)
			{
				screwdriver.SetActive(false);
				havescrewdriver = false;
				((Component)Object.Instantiate<Transform>(newscrewdriver, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveplanka)
			{
				planka.SetActive(false);
				haveplanka = false;
				((Component)Object.Instantiate<Transform>(newplanka, DropPointStick.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * 240f);
				placeObject = false;
				placeObjectButton.SetActive(false);
			}
			else if (havebattery)
			{
				battery.SetActive(false);
				havebattery = false;
				((Component)Object.Instantiate<Transform>(newbattery, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havetb1)
			{
				tb1.SetActive(false);
				havetb1 = false;
				((Component)Object.Instantiate<Transform>(newtb1, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havetb2)
			{
				tb2.SetActive(false);
				havetb2 = false;
				((Component)Object.Instantiate<Transform>(newtb2, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havetb3)
			{
				tb3.SetActive(false);
				havetb3 = false;
				((Component)Object.Instantiate<Transform>(newtb3, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havetb4)
			{
				tb4.SetActive(false);
				havetb4 = false;
				((Component)Object.Instantiate<Transform>(newtb4, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havevas2)
			{
				vas2.SetActive(false);
				havevas2 = false;
				((Component)Object.Instantiate<Transform>(newvas2, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveplayhouseKey)
			{
				playhouseKey.SetActive(false);
				haveplayhouseKey = false;
				((Component)Object.Instantiate<Transform>(newplayhouseKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havemelon)
			{
				if (startNewDayScript.AnomalyNR != 101)
				{
					melon.SetActive(false);
					havemelon = false;
					((Component)Object.Instantiate<Transform>(newmelon, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				}
				else
				{
					melon.SetActive(false);
					havemelon = false;
					Object.Instantiate<Transform>(newmelon, new Vector3(-6f, 8f, -33f), Quaternion.identity);
				}
			}
			else if (haveteddy)
			{
				teddy.SetActive(false);
				haveteddy = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
				((Component)Object.Instantiate<Transform>(newteddy, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havekugg1)
			{
				kugg1.SetActive(false);
				havekugg1 = false;
				((Component)Object.Instantiate<Transform>(newkugg1, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havekugg2)
			{
				kugg2.SetActive(false);
				havekugg2 = false;
				((Component)Object.Instantiate<Transform>(newkugg2, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havekugg3)
			{
				kugg3Hand.SetActive(false);
				havekugg3 = false;
				Object.Instantiate<GameObject>(newkugg3, dropPoint.transform.position, dropPoint.transform.rotation).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havemessage)
			{
				message.SetActive(false);
				havemessage = false;
				((Component)Object.Instantiate<Transform>(newmessage, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havebrunnsvev)
			{
				brunnsvev.SetActive(false);
				havebrunnsvev = false;
				((Component)Object.Instantiate<Transform>(newbrunnsvev, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveoldShotgun)
			{
				oldShotgun.SetActive(false);
				haveoldShotgun = false;
				shootButton.SetActive(false);
				shootRay.SetActive(false);
				((Component)Object.Instantiate<Transform>(newoldShotgun, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havegunDel1)
			{
				gunDel1.SetActive(false);
				havegunDel1 = false;
				((Component)Object.Instantiate<Transform>(newgunDel1, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havegunDel2)
			{
				gunDel2.SetActive(false);
				havegunDel2 = false;
				((Component)Object.Instantiate<Transform>(newgunDel2, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havegunDel3)
			{
				gunDel3.SetActive(false);
				havegunDel3 = false;
				((Component)Object.Instantiate<Transform>(newgunDel3, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havecarKey)
			{
				carKey.SetActive(false);
				havecarKey = false;
				((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).playerHaveCarKey = false;
				((Component)Object.Instantiate<Transform>(newcarKey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havetopplock)
			{
				topplock.SetActive(false);
				havetopplock = false;
				((Component)Object.Instantiate<Transform>(newtopplock, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havecarbattery)
			{
				carbattery.SetActive(false);
				havecarbattery = false;
				((Component)Object.Instantiate<Transform>(newcarbattery, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havegascan)
			{
				gascan.SetActive(false);
				havegascan = false;
				((Component)Object.Instantiate<Transform>(newgascan, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havewrench)
			{
				wrench.SetActive(false);
				havewrench = false;
				((Component)Object.Instantiate<Transform>(newwrench, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havesparkplug)
			{
				sparkplug.SetActive(false);
				havesparkplug = false;
				((Component)Object.Instantiate<Transform>(newsparkplug, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havemeat)
			{
				meat.SetActive(false);
				havemeat = false;
				((Component)Object.Instantiate<Transform>(newmeat, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havespecialkey)
			{
				specialkey.SetActive(false);
				havespecialkey = false;
				((Component)Object.Instantiate<Transform>(newspecialkey, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havebook)
			{
				book.SetActive(false);
				havebook = false;
				((Component)Object.Instantiate<Transform>(newbook, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havepepperspray)
			{
				pepperspray.SetActive(false);
				havepepperspray = false;
				sprayButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newpepperspray, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveremote)
			{
				remote.SetActive(false);
				haveremote = false;
				useRemoteButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newremote, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havebirdSeed)
			{
				birdSeed.SetActive(false);
				havebirdSeed = false;
				((Component)Object.Instantiate<Transform>(newbirdSeed, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havefreezeTrap)
			{
				freezeTrap.SetActive(false);
				havefreezeTrap = false;
				if (startNewDayScript.AnomalyNR == 21)
				{
					Object.Instantiate<Transform>(newfreezeTrap, dropPoint.transform.position, dropPoint.transform.rotation);
				}
				else
				{
					((Component)Object.Instantiate<Transform>(newfreezeTrap, dropPointFreezeTrap.transform.position, dropPointFreezeTrap.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				}
			}
			else if (havePicture)
			{
				gameController.GetComponent<startNewDay>().PictureItemHand.SetActive(false);
				havePicture = false;
				((Component)Object.Instantiate<Transform>(gameController.GetComponent<startNewDay>().newPictureItem.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveStick)
			{
				StickHand.SetActive(false);
				haveStick = false;
				((Component)Object.Instantiate<Transform>(newStick.transform, DropPointStick.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveLostKey)
			{
				LostKeyHand.SetActive(false);
				haveLostKey = false;
				((Component)Object.Instantiate<Transform>(newLostKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveTVRemote)
			{
				TVRemoteHand.SetActive(false);
				haveTVRemote = false;
				useRemoteButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newTVRemote.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveWire)
			{
				WireHand.SetActive(false);
				haveWire = false;
				((Component)Object.Instantiate<Transform>(newWire.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareBook)
			{
				NightmareBookHand.SetActive(false);
				haveNightmareBook = false;
				((Component)Object.Instantiate<Transform>(newNightmareBook.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareVase)
			{
				NightmareVaseHand.SetActive(false);
				haveNightmareVase = false;
				((Component)Object.Instantiate<Transform>(newNightmareVase.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareMelon)
			{
				NightmareMelonHand.SetActive(false);
				haveNightmareMelon = false;
				((Component)Object.Instantiate<Transform>(newNightmareMelon.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareHammer)
			{
				NightmareHammerHand.SetActive(false);
				haveNightmareHammer = false;
				((Component)Object.Instantiate<Transform>(newNightmareHammer.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveBlueKey)
			{
				BlueKeyHand.SetActive(false);
				haveBlueKey = false;
				((Component)Object.Instantiate<Transform>(newBlueKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveDoorUnlock)
			{
				DoorUnlockHand.SetActive(false);
				haveDoorUnlock = false;
				((Component)Object.Instantiate<Transform>(newDoorUnlock.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveButtonNewEscape)
			{
				ButtonNewEscapeHand.SetActive(false);
				haveButtonNewEscape = false;
				((Component)Object.Instantiate<Transform>(newButtonNewEscape.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveTeleportRemote)
			{
				TeleportRemoteHand.SetActive(false);
				haveTeleportRemote = false;
				useRemoteButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newTeleportRemote.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareBattery)
			{
				NightmareBatteryHand.SetActive(false);
				haveNightmareBattery = false;
				((Component)Object.Instantiate<Transform>(newNightmareBattery.transform, startNewDayScript.DropPointScrewdriver.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower * 5f);
			}
			else if (haveNightmareTrap)
			{
				NightmareTrapHand.SetActive(false);
				haveNightmareTrap = false;
				if (startNewDayScript.AnomalyNR == 21)
				{
					Object.Instantiate<GameObject>(newNightmareTrap, dropPoint.transform.position, dropPoint.transform.rotation);
				}
				else
				{
					Object.Instantiate<GameObject>(newNightmareTrap, dropPointFreezeTrap.transform.position, dropPointFreezeTrap.transform.rotation).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				}
			}
			else if (haveNightmareCan)
			{
				NightmareCanHand.SetActive(false);
				haveNightmareCan = false;
				useRemoteButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newNightmareCan.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				PlayerPrefs.SetInt("NGasCanExplode", 0);
			}
			else if (haveRedKey)
			{
				RedKeyHand.SetActive(false);
				haveRedKey = false;
				((Component)Object.Instantiate<Transform>(newRedKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveChocolateKey)
			{
				ChocolateKeyHand.SetActive(false);
				haveChocolateKey = false;
				((Component)Object.Instantiate<Transform>(newChocolateKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareWeaponKey)
			{
				NightmareWeaponKeyHand.SetActive(false);
				haveNightmareWeaponKey = false;
				((Component)Object.Instantiate<Transform>(newNightmareWeaponKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveBoxOfSweets)
			{
				BoxOfSweetsHand.SetActive(false);
				haveBoxOfSweets = false;
				((Component)Object.Instantiate<Transform>(newBoxOfSweets.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havePrimeTeddy)
			{
				PrimeTeddyHand.SetActive(false);
				havePrimeTeddy = false;
				((Component)Object.Instantiate<Transform>(newPrimeTeddy.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveDarkKey)
			{
				DarkKeyHand.SetActive(false);
				haveDarkKey = false;
				((Component)Object.Instantiate<Transform>(newDarkKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (havePrimeRedKey)
			{
				PrimeRedKeyHand.SetActive(false);
				havePrimeRedKey = false;
				((Component)Object.Instantiate<Transform>(newPrimeRedKey.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareRemote)
			{
				NightmareRemoteHand.SetActive(false);
				haveNightmareRemote = false;
				useRemoteButton.SetActive(false);
				((Component)Object.Instantiate<Transform>(newNightmareRemote.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareWrench)
			{
				NightmareWrenchHand.SetActive(false);
				haveNightmareWrench = false;
				((Component)Object.Instantiate<Transform>(newNightmareWrench.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareWrench)
			{
				NightmareWrenchHand.SetActive(false);
				haveNightmareWrench = false;
				((Component)Object.Instantiate<Transform>(newNightmareWrench.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveNightmareCrossbow)
			{
				NightmareCrossbowHand.SetActive(false);
				haveNightmareCrossbow = false;
				((Component)Object.Instantiate<Transform>(newNightmareCrossbow.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
				arrowButton.SetActive(false);
				shootArrowRay.SetActive(false);
				AntiNightmareCrossbow.SetActive(false);
				NightmareVase[] array = Object.FindObjectsByType<NightmareVase>((FindObjectsSortMode)0);
				for (int i = 0; i < array.Length; i++)
				{
					if (((Component)array[i]).transform.position.y > 0f)
					{
						((Component)array[i]).gameObject.SetActive(false);
					}
				}
			}
			else if (haveVictimCard)
			{
				VictimCardHand.SetActive(false);
				haveVictimCard = false;
				((Component)Object.Instantiate<Transform>(newVictimCard.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
			else if (haveSmallPlant)
			{
				SmallPlantHand.SetActive(false);
				haveSmallPlant = false;
				((Component)Object.Instantiate<Transform>(newSmallPlant.transform, dropPoint.transform.position, dropPoint.transform.rotation)).GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * dropPower);
			}
		}
		textTimerOnOff = true;
	}

	public virtual void placePlankaHole()
	{
		if (plankaHighlighted)
		{
			plankaHighlighted = false;
			highlightedPlanka.SetActive(false);
			highlightedPlankaTrigger.SetActive(false);
			plankaHole.SetActive(true);
			planka.SetActive(false);
			haveplanka = false;
			placeObject = false;
			placeObjectButton.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
		}
	}

	public virtual void NoText()
	{
	}

	public virtual void NoObjectText()
	{
	}

	public virtual void PlanktextTimer()
	{
		if (startNewDayScript.daysCounter != 6f)
		{
			PickUpScript.ShowText2("Maybe I can use one of the planks");
		}
	}

	public virtual void Start()
	{
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0871: Unknown result type (might be due to invalid IL or missing references)
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1000: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_1146: Unknown result type (might be due to invalid IL or missing references)
		//IL_1170: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_130b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1360: Unknown result type (might be due to invalid IL or missing references)
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_1476: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1623: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_1680: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1710: Unknown result type (might be due to invalid IL or missing references)
		//IL_1735: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Unknown result type (might be due to invalid IL or missing references)
		//IL_1809: Unknown result type (might be due to invalid IL or missing references)
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Unknown result type (might be due to invalid IL or missing references)
		//IL_1866: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1914: Unknown result type (might be due to invalid IL or missing references)
		//IL_1946: Unknown result type (might be due to invalid IL or missing references)
		//IL_195a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e33: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3021: Unknown result type (might be due to invalid IL or missing references)
		//IL_3070: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3103: Unknown result type (might be due to invalid IL or missing references)
		//IL_311d: Unknown result type (might be due to invalid IL or missing references)
		//IL_313d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3142: Unknown result type (might be due to invalid IL or missing references)
		//IL_318f: Unknown result type (might be due to invalid IL or missing references)
		//IL_319f: Unknown result type (might be due to invalid IL or missing references)
		//IL_31ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_325e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3272: Unknown result type (might be due to invalid IL or missing references)
		//IL_32c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_32da: Unknown result type (might be due to invalid IL or missing references)
		//IL_32fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_334c: Unknown result type (might be due to invalid IL or missing references)
		//IL_335c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3387: Unknown result type (might be due to invalid IL or missing references)
		//IL_33e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_33f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3416: Unknown result type (might be due to invalid IL or missing references)
		//IL_342a: Unknown result type (might be due to invalid IL or missing references)
		//IL_344a: Unknown result type (might be due to invalid IL or missing references)
		//IL_345e: Unknown result type (might be due to invalid IL or missing references)
		//IL_347e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3492: Unknown result type (might be due to invalid IL or missing references)
		//IL_34b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_351a: Unknown result type (might be due to invalid IL or missing references)
		//IL_352e: Unknown result type (might be due to invalid IL or missing references)
		//IL_354f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3563: Unknown result type (might be due to invalid IL or missing references)
		//IL_35e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_36ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_373f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3753: Unknown result type (might be due to invalid IL or missing references)
		//IL_377c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_3832: Unknown result type (might be due to invalid IL or missing references)
		//IL_3837: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ed5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_201d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2031: Unknown result type (might be due to invalid IL or missing references)
		//IL_2051: Unknown result type (might be due to invalid IL or missing references)
		//IL_2065: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Unknown result type (might be due to invalid IL or missing references)
		//IL_2099: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2101: Unknown result type (might be due to invalid IL or missing references)
		//IL_212b: Unknown result type (might be due to invalid IL or missing references)
		//IL_213f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2174: Unknown result type (might be due to invalid IL or missing references)
		//IL_2188: Unknown result type (might be due to invalid IL or missing references)
		//IL_21bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2206: Unknown result type (might be due to invalid IL or missing references)
		//IL_221a: Unknown result type (might be due to invalid IL or missing references)
		//IL_224f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2263: Unknown result type (might be due to invalid IL or missing references)
		//IL_2298: Unknown result type (might be due to invalid IL or missing references)
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3883: Unknown result type (might be due to invalid IL or missing references)
		//IL_3897: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_391a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3934: Unknown result type (might be due to invalid IL or missing references)
		//IL_3954: Unknown result type (might be due to invalid IL or missing references)
		//IL_3959: Unknown result type (might be due to invalid IL or missing references)
		//IL_39a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_39ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_233b: Unknown result type (might be due to invalid IL or missing references)
		//IL_234f: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2412: Unknown result type (might be due to invalid IL or missing references)
		//IL_2417: Unknown result type (might be due to invalid IL or missing references)
		//IL_2464: Unknown result type (might be due to invalid IL or missing references)
		//IL_2478: Unknown result type (might be due to invalid IL or missing references)
		//IL_4812: Unknown result type (might be due to invalid IL or missing references)
		//IL_4826: Unknown result type (might be due to invalid IL or missing references)
		//IL_48a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_49a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_49ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_253e: Unknown result type (might be due to invalid IL or missing references)
		//IL_258c: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25da: Unknown result type (might be due to invalid IL or missing references)
		//IL_2627: Unknown result type (might be due to invalid IL or missing references)
		//IL_2637: Unknown result type (might be due to invalid IL or missing references)
		//IL_2671: Unknown result type (might be due to invalid IL or missing references)
		//IL_26bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_26cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_270c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2735: Unknown result type (might be due to invalid IL or missing references)
		//IL_2749: Unknown result type (might be due to invalid IL or missing references)
		//IL_2772: Unknown result type (might be due to invalid IL or missing references)
		//IL_2786: Unknown result type (might be due to invalid IL or missing references)
		//IL_27af: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2800: Unknown result type (might be due to invalid IL or missing references)
		//IL_2829: Unknown result type (might be due to invalid IL or missing references)
		//IL_283d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2866: Unknown result type (might be due to invalid IL or missing references)
		//IL_287a: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_28e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_28f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_291d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2931: Unknown result type (might be due to invalid IL or missing references)
		//IL_295a: Unknown result type (might be due to invalid IL or missing references)
		//IL_296e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2997: Unknown result type (might be due to invalid IL or missing references)
		//IL_29ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_29e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_4ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_4def: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e03: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_4edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_4eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_501e: Unknown result type (might be due to invalid IL or missing references)
		//IL_5042: Unknown result type (might be due to invalid IL or missing references)
		//IL_509d: Unknown result type (might be due to invalid IL or missing references)
		//IL_50d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_50f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_50f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_514b: Unknown result type (might be due to invalid IL or missing references)
		//IL_515f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5188: Unknown result type (might be due to invalid IL or missing references)
		//IL_5231: Unknown result type (might be due to invalid IL or missing references)
		//IL_5245: Unknown result type (might be due to invalid IL or missing references)
		//IL_526e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ae6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_67e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_67fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6850: Unknown result type (might be due to invalid IL or missing references)
		//IL_6870: Unknown result type (might be due to invalid IL or missing references)
		//IL_6875: Unknown result type (might be due to invalid IL or missing references)
		//IL_68c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_68d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_690c: Unknown result type (might be due to invalid IL or missing references)
		//IL_696c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6980: Unknown result type (might be due to invalid IL or missing references)
		//IL_69ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_533d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5351: Unknown result type (might be due to invalid IL or missing references)
		//IL_539f: Unknown result type (might be due to invalid IL or missing references)
		//IL_53b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_53e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_53ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_5437: Unknown result type (might be due to invalid IL or missing references)
		//IL_544b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5476: Unknown result type (might be due to invalid IL or missing references)
		//IL_54d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_54e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_5534: Unknown result type (might be due to invalid IL or missing references)
		//IL_554e: Unknown result type (might be due to invalid IL or missing references)
		//IL_557a: Unknown result type (might be due to invalid IL or missing references)
		//IL_557f: Unknown result type (might be due to invalid IL or missing references)
		//IL_55cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_55e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_560b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5666: Unknown result type (might be due to invalid IL or missing references)
		//IL_567a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_4be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c36: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_3aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ab4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_572b: Unknown result type (might be due to invalid IL or missing references)
		//IL_573f: Unknown result type (might be due to invalid IL or missing references)
		//IL_578d: Unknown result type (might be due to invalid IL or missing references)
		//IL_57a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_57c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_57cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5825: Unknown result type (might be due to invalid IL or missing references)
		//IL_5839: Unknown result type (might be due to invalid IL or missing references)
		//IL_5864: Unknown result type (might be due to invalid IL or missing references)
		//IL_58c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_58d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5922: Unknown result type (might be due to invalid IL or missing references)
		//IL_594b: Unknown result type (might be due to invalid IL or missing references)
		//IL_596b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5970: Unknown result type (might be due to invalid IL or missing references)
		//IL_59bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_59d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5af9: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b42: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_5be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_56b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_56c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_56ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_5701: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_3be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3da6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3dca: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e99: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_5dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e44: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f48: Unknown result type (might be due to invalid IL or missing references)
		//IL_5f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_5fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_601a: Unknown result type (might be due to invalid IL or missing references)
		//IL_602a: Unknown result type (might be due to invalid IL or missing references)
		//IL_6055: Unknown result type (might be due to invalid IL or missing references)
		//IL_60b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_60c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_6118: Unknown result type (might be due to invalid IL or missing references)
		//IL_6138: Unknown result type (might be due to invalid IL or missing references)
		//IL_613d: Unknown result type (might be due to invalid IL or missing references)
		//IL_618a: Unknown result type (might be due to invalid IL or missing references)
		//IL_619a: Unknown result type (might be due to invalid IL or missing references)
		//IL_61d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6230: Unknown result type (might be due to invalid IL or missing references)
		//IL_6244: Unknown result type (might be due to invalid IL or missing references)
		//IL_6297: Unknown result type (might be due to invalid IL or missing references)
		//IL_62b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_62bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6309: Unknown result type (might be due to invalid IL or missing references)
		//IL_6319: Unknown result type (might be due to invalid IL or missing references)
		//IL_6353: Unknown result type (might be due to invalid IL or missing references)
		//IL_63cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_63df: Unknown result type (might be due to invalid IL or missing references)
		//IL_6432: Unknown result type (might be due to invalid IL or missing references)
		//IL_6452: Unknown result type (might be due to invalid IL or missing references)
		//IL_6457: Unknown result type (might be due to invalid IL or missing references)
		//IL_64a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_64b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_64ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eea: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_6da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_6dec: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e70: Unknown result type (might be due to invalid IL or missing references)
		//IL_6e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f07: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_7022: Unknown result type (might be due to invalid IL or missing references)
		//IL_7046: Unknown result type (might be due to invalid IL or missing references)
		//IL_70b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_70e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7106: Unknown result type (might be due to invalid IL or missing references)
		//IL_710b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7150: Unknown result type (might be due to invalid IL or missing references)
		//IL_7164: Unknown result type (might be due to invalid IL or missing references)
		//IL_718d: Unknown result type (might be due to invalid IL or missing references)
		//IL_724f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7263: Unknown result type (might be due to invalid IL or missing references)
		//IL_72b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_72cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_72eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_72f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_733d: Unknown result type (might be due to invalid IL or missing references)
		//IL_734d: Unknown result type (might be due to invalid IL or missing references)
		//IL_7378: Unknown result type (might be due to invalid IL or missing references)
		//IL_73d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_73e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7436: Unknown result type (might be due to invalid IL or missing references)
		//IL_745f: Unknown result type (might be due to invalid IL or missing references)
		//IL_747f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7484: Unknown result type (might be due to invalid IL or missing references)
		//IL_74d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_74e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_751b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7577: Unknown result type (might be due to invalid IL or missing references)
		//IL_758b: Unknown result type (might be due to invalid IL or missing references)
		//IL_75e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7620: Unknown result type (might be due to invalid IL or missing references)
		//IL_7625: Unknown result type (might be due to invalid IL or missing references)
		//IL_7672: Unknown result type (might be due to invalid IL or missing references)
		//IL_7686: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_6c7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_6576: Unknown result type (might be due to invalid IL or missing references)
		//IL_658a: Unknown result type (might be due to invalid IL or missing references)
		//IL_65dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_65fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_6602: Unknown result type (might be due to invalid IL or missing references)
		//IL_664f: Unknown result type (might be due to invalid IL or missing references)
		//IL_665f: Unknown result type (might be due to invalid IL or missing references)
		//IL_6699: Unknown result type (might be due to invalid IL or missing references)
		//IL_66f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_6708: Unknown result type (might be due to invalid IL or missing references)
		//IL_6731: Unknown result type (might be due to invalid IL or missing references)
		//IL_6745: Unknown result type (might be due to invalid IL or missing references)
		//IL_676e: Unknown result type (might be due to invalid IL or missing references)
		//IL_6782: Unknown result type (might be due to invalid IL or missing references)
		//IL_67ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_67bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f93: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_401f: Unknown result type (might be due to invalid IL or missing references)
		//IL_403f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4044: Unknown result type (might be due to invalid IL or missing references)
		//IL_4091: Unknown result type (might be due to invalid IL or missing references)
		//IL_40a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_40db: Unknown result type (might be due to invalid IL or missing references)
		//IL_4131: Unknown result type (might be due to invalid IL or missing references)
		//IL_4145: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_41cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_41df: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_771e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7732: Unknown result type (might be due to invalid IL or missing references)
		//IL_7776: Unknown result type (might be due to invalid IL or missing references)
		//IL_7796: Unknown result type (might be due to invalid IL or missing references)
		//IL_779b: Unknown result type (might be due to invalid IL or missing references)
		//IL_77e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_77f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_7823: Unknown result type (might be due to invalid IL or missing references)
		//IL_787f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7893: Unknown result type (might be due to invalid IL or missing references)
		//IL_78ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_78f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_7940: Unknown result type (might be due to invalid IL or missing references)
		//IL_7950: Unknown result type (might be due to invalid IL or missing references)
		//IL_79b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_79cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_4210: Unknown result type (might be due to invalid IL or missing references)
		//IL_4224: Unknown result type (might be due to invalid IL or missing references)
		//IL_4272: Unknown result type (might be due to invalid IL or missing references)
		//IL_428c: Unknown result type (might be due to invalid IL or missing references)
		//IL_42b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_42bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_430a: Unknown result type (might be due to invalid IL or missing references)
		//IL_431e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4349: Unknown result type (might be due to invalid IL or missing references)
		//IL_43a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_43b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_4407: Unknown result type (might be due to invalid IL or missing references)
		//IL_4421: Unknown result type (might be due to invalid IL or missing references)
		//IL_444d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4452: Unknown result type (might be due to invalid IL or missing references)
		//IL_449f: Unknown result type (might be due to invalid IL or missing references)
		//IL_44b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_44de: Unknown result type (might be due to invalid IL or missing references)
		//IL_453a: Unknown result type (might be due to invalid IL or missing references)
		//IL_454e: Unknown result type (might be due to invalid IL or missing references)
		//IL_459c: Unknown result type (might be due to invalid IL or missing references)
		//IL_45c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_45e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_4643: Unknown result type (might be due to invalid IL or missing references)
		//IL_4657: Unknown result type (might be due to invalid IL or missing references)
		//IL_4691: Unknown result type (might be due to invalid IL or missing references)
		//IL_46ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_4701: Unknown result type (might be due to invalid IL or missing references)
		//IL_4736: Unknown result type (might be due to invalid IL or missing references)
		//IL_474a: Unknown result type (might be due to invalid IL or missing references)
		//IL_477f: Unknown result type (might be due to invalid IL or missing references)
		//IL_4793: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_47dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_80f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8115: Unknown result type (might be due to invalid IL or missing references)
		//IL_8139: Unknown result type (might be due to invalid IL or missing references)
		//IL_815d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8181: Unknown result type (might be due to invalid IL or missing references)
		//IL_81a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_81c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_81ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_8211: Unknown result type (might be due to invalid IL or missing references)
		//IL_8235: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_7a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_8269: Unknown result type (might be due to invalid IL or missing references)
		//IL_828d: Unknown result type (might be due to invalid IL or missing references)
		//IL_82b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_82d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_82f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_831d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8341: Unknown result type (might be due to invalid IL or missing references)
		//IL_8365: Unknown result type (might be due to invalid IL or missing references)
		//IL_8389: Unknown result type (might be due to invalid IL or missing references)
		//IL_83ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_7adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_847c: Unknown result type (might be due to invalid IL or missing references)
		//IL_84a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_84d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_84f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_851d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8541: Unknown result type (might be due to invalid IL or missing references)
		//IL_8565: Unknown result type (might be due to invalid IL or missing references)
		//IL_8589: Unknown result type (might be due to invalid IL or missing references)
		//IL_83e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8405: Unknown result type (might be due to invalid IL or missing references)
		//IL_8448: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_85bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_85e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_8605: Unknown result type (might be due to invalid IL or missing references)
		//IL_8629: Unknown result type (might be due to invalid IL or missing references)
		//IL_864d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8671: Unknown result type (might be due to invalid IL or missing references)
		//IL_86b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_86d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_86fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_8720: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_8754: Unknown result type (might be due to invalid IL or missing references)
		//IL_8778: Unknown result type (might be due to invalid IL or missing references)
		//IL_879c: Unknown result type (might be due to invalid IL or missing references)
		//IL_87c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_87e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_8808: Unknown result type (might be due to invalid IL or missing references)
		//IL_882c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8850: Unknown result type (might be due to invalid IL or missing references)
		//IL_8874: Unknown result type (might be due to invalid IL or missing references)
		//IL_8898: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_8921: Unknown result type (might be due to invalid IL or missing references)
		//IL_8945: Unknown result type (might be due to invalid IL or missing references)
		//IL_8969: Unknown result type (might be due to invalid IL or missing references)
		//IL_898d: Unknown result type (might be due to invalid IL or missing references)
		//IL_89b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_89d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_89f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_8a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_88c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_88ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_8adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_8b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_8bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c63: Unknown result type (might be due to invalid IL or missing references)
		//IL_8c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_8cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_8cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_8d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_8da5: Unknown result type (might be due to invalid IL or missing references)
		//IL_8dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ded: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_8e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8eb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_8ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_8efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f42: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f66: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fae: Unknown result type (might be due to invalid IL or missing references)
		//IL_8fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_7dcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e79: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_7fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_7fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_8037: Unknown result type (might be due to invalid IL or missing references)
		//IL_8047: Unknown result type (might be due to invalid IL or missing references)
		//IL_8081: Unknown result type (might be due to invalid IL or missing references)
		//IL_7eb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f23: Unknown result type (might be due to invalid IL or missing references)
		if (startNewDayScript.AnomalyNR == 34)
		{
			dropPower = 0f;
		}
		else if (startNewDayScript.AnomalyNR == 35)
		{
			dropPower = 600f;
		}
		else
		{
			dropPower = 230f;
		}
		if (PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 1)
		{
			((Renderer)vas.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)((Component)newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
			if (Object.op_Implicit((Object)(object)GameObject.Find("Vas")))
			{
				((Renderer)GameObject.Find("Vas").GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)((Component)newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
			}
			((Renderer)GameObject.Find("Granny").GetComponent<SkinnedMeshRenderer>()).sharedMaterial.mainTexture = ((Renderer)((Component)newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
			if (startNewDayScript.AnomalyNR != 2525)
			{
				GameObject gameObject = ((Component)Object.Instantiate<Transform>(newmelon)).gameObject;
				gameObject.transform.SetParent(GameObject.Find("Bip01 Head").transform);
				gameObject.GetComponent<Rigidbody>().isKinematic = true;
				((Collider)gameObject.GetComponent<MeshCollider>()).enabled = false;
				((Component)gameObject.transform.GetChild(0)).gameObject.SetActive(false);
				gameObject.transform.localPosition = new Vector3(-14.7382145f, -0.070414856f, 0.08072912f);
				gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
				gameObject.transform.localScale = new Vector3(3.4362848f, 3.4362953f, 5.617115f);
				GameObject gameObject2 = ((Component)Object.Instantiate<Transform>(newmelon)).gameObject;
				gameObject2.transform.SetParent(GameObject.Find("BatBloody").transform);
				gameObject2.GetComponent<Rigidbody>().isKinematic = true;
				((Collider)gameObject2.GetComponent<MeshCollider>()).enabled = false;
				((Component)gameObject2.transform.GetChild(0)).gameObject.SetActive(false);
				gameObject2.transform.localPosition = new Vector3(-2.9f, -0.6f, 72f);
				gameObject2.transform.localRotation = Quaternion.Euler(4.372f, 0.536f, -88.33f);
				gameObject2.transform.localScale = new Vector3(4.44f, 4.44f, 13.22f);
			}
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			LostKeyItem = ((Component)Object.Instantiate<Transform>(newhanglockKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			LostKeyItem.tag = "vitrindoorLopen";
			((Object)LostKeyItem).name = "LostKey";
			LostKeyItem.transform.position = GameObject.Find("Nav" + Random.Range(1, 17)).transform.position;
			((Renderer)LostKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			newLostKey = Object.Instantiate<GameObject>(LostKeyItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
			((Object)newLostKey).name = "LostKey";
			newLostKey.tag = "vitrindoorLopen";
			hanglockKey.SetActive(true);
			LostKeyHand = Object.Instantiate<GameObject>(hanglockKey, hanglockKey.transform.position, hanglockKey.transform.rotation);
			hanglockKey.SetActive(false);
			((Renderer)LostKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			LostKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			LostKeyHand.SetActive(false);
			LostKeyItem.SetActive(false);
			((Renderer)((Component)newbook).gameObject.GetComponent<MeshRenderer>()).material.color = Color.white;
			return;
		}
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			DropPointStick = Object.Instantiate<GameObject>(dropPoint, GameObject.Find("HandHoldObjects").transform);
			Transform transform = DropPointStick.transform;
			transform.position += new Vector3(0.1f, 0f, 0.3f);
			Object.Instantiate<Transform>(newexitKey, new Vector3(-3.37f, 15.32f, 12.01f), Quaternion.Euler(-90f, 0f, Random.Range(-180f, 180f)));
			EatingCounter = 0;
			Anomaly31Gift = ((Component)Object.Instantiate<Transform>(newbirdSeed, new Vector3(9.75f, -2222.52f, -3.69f), Quaternion.Euler(180f, -90f, 90f))).gameObject;
			((Object)Anomaly31Gift).name = "EventChallenge3Gift";
			Anomaly31Gift.tag = "Untagged";
			((Renderer)Anomaly31Gift.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)((Component)newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
			((Renderer)vas.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)((Component)newmelon).GetComponent<MeshRenderer>()).sharedMaterial.mainTexture;
			return;
		}
		if (startNewDayScript.PrimeAnomalyNR == 9)
		{
			PrimeRedKeyItem = ((Component)Object.Instantiate<Transform>(newplayhouseKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			PrimeRedKeyItem.tag = "Untagged";
			((Object)PrimeRedKeyItem).name = "PrimeRedKey";
			PrimeRedKeyItem.transform.position = new Vector3(15.279f, -113.92f, 0.396f);
			((Renderer)PrimeRedKeyItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			newPrimeRedKey = Object.Instantiate<GameObject>(PrimeRedKeyItem, new Vector3(28.85f, -732.4f, 4.68f), Quaternion.identity);
			newPrimeRedKey.tag = "Untagged";
			((Object)newPrimeRedKey).name = "newPrimeRedKey";
			playhouseKey.SetActive(true);
			PrimeRedKeyHand = Object.Instantiate<GameObject>(playhouseKey, playhouseKey.transform.position, playhouseKey.transform.rotation);
			playhouseKey.SetActive(false);
			((Renderer)PrimeRedKeyHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			PrimeRedKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			PrimeRedKeyHand.SetActive(false);
			PrimeRedKeyItem.GetComponent<Rigidbody>().isKinematic = true;
			Object.Instantiate<GameObject>(PrimeRedKeyItem, new Vector3(-0.61f, 13.32f, 15.7f), Quaternion.Euler(-90f, 0f, 0f));
		}
		if (startNewDayScript.PrimeAnomalyNR == 10)
		{
			spawnPositions = new Vector3[55]
			{
				new Vector3(-3.32f, 2.13f, -4.51f),
				new Vector3(-0.839f, 2.13f, 3.622f),
				new Vector3(-6.094f, 8.59f, -3.886f),
				new Vector3(6.584f, 8.59f, -6.963f),
				new Vector3(-19.67f, 14.073f, 10.81f),
				new Vector3(-12.62f, 14.073f, 2.917f),
				new Vector3(-2.639f, 14.073f, 8.462f),
				new Vector3(8.877f, 14.692f, 4.972f),
				new Vector3(17.59f, 14.692f, -3.77f),
				new Vector3(-19.67f, 14.073f, 6.61f),
				new Vector3(9.578f, 14.073f, 2.777f),
				new Vector3(15.751f, 13.378f, -11.415f),
				new Vector3(12.96f, 13.378f, 2.53f),
				new Vector3(-0.471f, 13.378f, 0.66f),
				new Vector3(4.711f, 2.067f, -3.328f),
				new Vector3(4.923f, 8.01f, 8.19f),
				new Vector3(3.088f, 8.01f, 0.969f),
				new Vector3(24.39f, 12.178f, -6.772f),
				new Vector3(24.39f, 12.178f, -4.747f),
				new Vector3(19.41f, 12.178f, -17.08f),
				new Vector3(8.44f, 12.178f, -25.13f),
				new Vector3(9.147f, 12.178f, -16.948f),
				new Vector3(27.67f, 12.178f, -25.27f),
				new Vector3(33f, 12.178f, -18.526f),
				new Vector3(33f, 12.178f, -5.768f),
				new Vector3(30.06f, 12.178f, -13.016f),
				new Vector3(17.179f, 20.875f, -10.818f),
				new Vector3(8.372f, 20.875f, -7.629f),
				new Vector3(1.047f, 20.875f, -9.61f),
				new Vector3(5.09f, 20.875f, 1.583f),
				new Vector3(-0.65f, 20.875f, -0.164f),
				new Vector3(17.724f, 20.875f, 8.341f),
				new Vector3(-4.5f, 20.875f, 0.22f),
				new Vector3(-3.769f, 20.875f, -5.53f),
				new Vector3(-12.37f, 20.875f, -8.09f),
				new Vector3(-11.62f, 20.875f, 5.871f),
				new Vector3(-23.332f, 20.875f, 0.34f),
				new Vector3(9.385f, 28.078f, 7.663f),
				new Vector3(3.79f, 28.078f, 1.861f),
				new Vector3(-7.63f, 28.078f, -4.07f),
				new Vector3(-12.194f, 27.554f, 9.136f),
				new Vector3(-9.859f, 33.943f, 0.645f),
				new Vector3(3.911f, 33.943f, 4.11f),
				new Vector3(-6.4f, 27.92f, 10.313f),
				new Vector3(-17.85f, 21.101f, -17.817f),
				new Vector3(2.294f, 18.117f, -21.788f),
				new Vector3(2.81f, 13.062f, -23.3f),
				new Vector3(1.15f, 8f, -16.725f),
				new Vector3(-7.277f, 13.237f, -21.134f),
				new Vector3(-5.281f, 13.237f, -39.527f),
				new Vector3(-9.825f, 13.237f, -39.527f),
				new Vector3(4.78f, 13.237f, -36.74f),
				new Vector3(6.467f, 8.46f, -39.516f),
				new Vector3(-1.57f, 8.46f, -39.524f),
				new Vector3(7.635f, 8.46f, -30.706f)
			};
			Vector3[] array = spawnPositions;
			foreach (Vector3 val in array)
			{
				Object.Instantiate<Transform>(newvas2, val, Quaternion.Euler(-90f, 0f, 0f));
			}
		}
		if (startNewDayScript.PrimeAnomalyNR == 18)
		{
			DropPointStick = Object.Instantiate<GameObject>(dropPoint, GameObject.Find("HandHoldObjects").transform);
			Transform transform2 = DropPointStick.transform;
			transform2.position += new Vector3(0.1f, 0f, 0.3f);
			TeleportRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 55f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			TeleportRemoteItem.tag = "Untagged";
			((Object)TeleportRemoteItem).name = "TeleportRemote";
			((Renderer)TeleportRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.green;
			newTeleportRemote = Object.Instantiate<GameObject>(TeleportRemoteItem, new Vector3(28.85f, -224f, 4.68f), Quaternion.identity);
			newTeleportRemote.tag = "Untagged";
			((Object)newTeleportRemote).name = "newTeleportRemote";
			remote.SetActive(true);
			TeleportRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)TeleportRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.green;
			TeleportRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TeleportRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			TeleportRemoteHand.SetActive(false);
			NightmareVaseItem = ((Component)Object.Instantiate<Transform>(newvas, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
			NightmareVaseItem.tag = "Untagged";
			((Object)NightmareVaseItem).name = "NightmareVase";
			NightmareVaseItem.transform.position = new Vector3(-18.95f, 15.03f, -3.86f);
			((Renderer)NightmareVaseItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareVaseItem.AddComponent<NightmareVase>();
			newNightmareVase = Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			newNightmareVase.tag = "Untagged";
			((Object)newNightmareVase).name = "newNightmareVase";
			vas.SetActive(true);
			NightmareVaseHand = Object.Instantiate<GameObject>(vas, vas.transform.position, Quaternion.Euler(-106.5f, -210.4f, -60.6f));
			vas.SetActive(false);
			((Renderer)NightmareVaseHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareVaseHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareVaseHand.SetActive(false);
			NightmareVaseItem.GetComponent<Rigidbody>().isKinematic = true;
			((Object)Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(3.277f, 19.25442f, -17.237f), Quaternion.Euler(-90f, 0f, 0f))).name = "NightmareVase";
			StickItem = ((Component)Object.Instantiate<Transform>(newtopplock, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			StickItem.tag = "vitrindoorLclosed";
			((Object)StickItem).name = "MetalStick";
			Object.Destroy((Object)(object)StickItem.GetComponent<BoxCollider>());
			StickItem.GetComponent<MeshFilter>().mesh = GameObject.Find("Ammo_Garage/Ammo").GetComponent<MeshFilter>().sharedMesh;
			StickItem.transform.localScale = new Vector3(0.02f, 0.02f, 0.1f);
			StickItem.AddComponent<MeshCollider>();
			StickItem.GetComponent<MeshCollider>().convex = true;
			Object.Destroy((Object)(object)((Component)StickItem.transform.GetChild(0)).GetComponent<BoxCollider>());
			((Component)StickItem.transform.GetChild(0)).gameObject.AddComponent<CapsuleCollider>();
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().direction = 2;
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().height = 15f;
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().radius = 0.6f;
			((Collider)((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>()).isTrigger = true;
			newStick = Object.Instantiate<GameObject>(StickItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
			((Object)newStick).name = "MetalStick";
			newStick.tag = "vitrindoorLclosed";
			Object.Destroy((Object)(object)newStick.GetComponent<BoxCollider>());
			StickHand = Object.Instantiate<GameObject>(StickItem, new Vector3(13.389f, 23.52f, -6.918f), Quaternion.Euler(-79.392f, -6.175f, 6.07f));
			StickHand.transform.localScale = new Vector3(0.0092f, 0.0092f, 0.046f);
			StickHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			Object.Destroy((Object)(object)StickHand.GetComponent<Rigidbody>());
			Object.Destroy((Object)(object)StickHand.GetComponent<MeshCollider>());
			Object.Destroy((Object)(object)StickHand.GetComponent<BoxCollider>());
			Object.Destroy((Object)(object)((Component)StickHand.transform.GetChild(0)).gameObject);
			StickHand.SetActive(false);
			StickItem.GetComponent<Rigidbody>().isKinematic = true;
			return;
		}
		if (startNewDayScript.AnomalyNR != 27)
		{
			if (PlayerPrefs.GetInt("DiffData") != 7 && startNewDayScript.AnomalyNR != 36)
			{
				CaramelPlank = ((Component)Object.Instantiate<Transform>(newplanka, new Vector3(14.3189f, 12.764f, -25.7022f), Quaternion.Euler(0f, 71.855f, 0f))).gameObject;
				CaramelPlank.transform.localScale = new Vector3(0.029970905f, 0.035355825f, 0.03111557f);
				CaramelPlank.GetComponent<Rigidbody>().isKinematic = true;
			}
			DropPointStick = Object.Instantiate<GameObject>(dropPoint, GameObject.Find("HandHoldObjects").transform);
			Transform transform3 = DropPointStick.transform;
			transform3.position += new Vector3(0.1f, 0f, 0.3f);
		}
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			PlankaNightmare = (Texture)(object)GameObject.Find("PlankaOH3").GetComponent<changeTextureNightmare>().nightmareTexture;
			((Renderer)planka.GetComponent<MeshRenderer>()).material.mainTexture = PlankaNightmare;
		}
		if (startNewDayScript.AnomalyNR == 11)
		{
			AnomalyTimer11 = 60f;
		}
		if (startNewDayScript.AnomalyNR == 19)
		{
			TeleportRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 55f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			TeleportRemoteItem.tag = "Untagged";
			((Object)TeleportRemoteItem).name = "TeleportRemote";
			((Renderer)TeleportRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.green;
			newTeleportRemote = Object.Instantiate<GameObject>(TeleportRemoteItem, new Vector3(28.85f, -224f, 4.68f), Quaternion.identity);
			newTeleportRemote.tag = "Untagged";
			((Object)newTeleportRemote).name = "newTeleportRemote";
			remote.SetActive(true);
			TeleportRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)TeleportRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.green;
			TeleportRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TeleportRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			TeleportRemoteHand.SetActive(false);
		}
		if (startNewDayScript.AnomalyNR == 21)
		{
			((Renderer)vas.GetComponent<MeshRenderer>()).material.color = Color.magenta;
			Anomaly21 = true;
		}
		if (startNewDayScript.AnomalyNR == 25)
		{
			CommentTextCurse = DefaultControls.CreateText(c);
			CommentTextCurse.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
			CommentTextCurse.GetComponent<Text>().text = "";
			((Graphic)CommentTextCurse.GetComponent<Text>()).color = Color.white;
			CommentTextCurse.GetComponent<Text>().fontStyle = (FontStyle)1;
			CommentTextCurse.GetComponent<Text>().alignment = (TextAnchor)4;
			CommentTextCurse.GetComponent<Text>().resizeTextForBestFit = true;
			CommentTextCurse.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			CommentTextCurse.GetComponent<Text>().fontSize = 0;
			CommentTextCurse.GetComponent<Text>().resizeTextMaxSize = 36;
			CommentTextCurse.GetComponent<RectTransform>().sizeDelta = new Vector2(856f, 30f);
			CommentTextCurse.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			CommentTextCurse.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			CommentTextCurse.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 102f);
			((Renderer)((Component)newgascan).GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("GallerDoor").GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)((Component)newgascan).GetComponent<MeshRenderer>()).material.color = new Color(0.35f, 1f, 0.5f);
			((Renderer)gascan.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("GallerDoor").GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)gascan.GetComponent<MeshRenderer>()).material.color = new Color(0.35f, 1f, 0.5f);
		}
		if (startNewDayScript.AnomalyNR == 27)
		{
			RedKeyItem = ((Component)Object.Instantiate<Transform>(newplayhouseKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			RedKeyItem.tag = "Untagged";
			((Object)RedKeyItem).name = "RedKeyAnomaly27";
			RedKeyItem.transform.position = new Vector3(15.279f, -113.92f, 0.396f);
			((Renderer)RedKeyItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			newRedKey = Object.Instantiate<GameObject>(RedKeyItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			newRedKey.tag = "Untagged";
			((Object)newRedKey).name = "RedKeyAnomaly27";
			playhouseKey.SetActive(true);
			RedKeyHand = Object.Instantiate<GameObject>(playhouseKey, playhouseKey.transform.position, playhouseKey.transform.rotation);
			playhouseKey.SetActive(false);
			((Renderer)RedKeyHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			RedKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			RedKeyHand.SetActive(false);
			RedKeyItem.GetComponent<Rigidbody>().isKinematic = true;
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 0)
			{
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(31.054f, 12.795f, -24.21f), Quaternion.Euler(-90f, 0f, 156f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-3.6f, 22.86f, 13.25f), Quaternion.Euler(-90f, 0f, 135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(6.3f, 10.32f, 0.13f), Quaternion.Euler(-90f, 0f, -135.3f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-14.96f, 20.07f, -13.5f), Quaternion.Euler(-90f, 0f, 130f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(7.21f, 7.02f, -15.98f), Quaternion.Euler(-90f, 0f, 156f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(18.1f, 16.655f, 1.66f), Quaternion.Euler(-90f, 0f, 0f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(2.118f, 4.0271354f, 10.917f), Quaternion.Euler(-90f, 0f, 130f));
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 1)
			{
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(6.739f, 11.862535f, -20.442f), Quaternion.Euler(-90f, 0f, 156f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(8.76f, 15.662172f, -6.48f), Quaternion.Euler(-90f, 0f, 135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-19.05f, 15.2377f, 1.8193f), Quaternion.Euler(-90f, 0f, -135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(3.282f, 35.868156f, -5.38f), Quaternion.Euler(-77.548f, 0f, 130f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-1.44f, 21.741562f, -9.42f), Quaternion.Euler(-90f, 0f, 156f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-12.356f, 29.00136f, -0.74f), Quaternion.Euler(-90f, 0f, 0f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(1.13f, 2.8389974f, -6f), Quaternion.Euler(-90f, 0f, 130f));
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 2)
			{
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-4.61f, 14.001856f, -31.2f), Quaternion.Euler(-90f, 0f, 156f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(1.6f, 7.487f, -15f), Quaternion.Euler(-90f, 0f, 135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(4.6f, 33.476112f, 10.02f), Quaternion.Euler(-90f, 0f, -135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(4.76f, 17.83f, -1.88f), Quaternion.Euler(-160f, 3f, -90f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(11.45f, 14.447f, 9.41f), Quaternion.Euler(-90f, 0f, 135f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(3.06f, 19.254f, -15.57f), Quaternion.Euler(-90f, 0f, -135.3f));
				Object.Instantiate<GameObject>(RedKeyItem, new Vector3(12.48f, 21.507f, -11.8f), Quaternion.Euler(-90f, 0f, -46.1f));
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 3)
			{
				Object.Instantiate<Transform>(newbattery, new Vector3(-6f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-6.5f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-7f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-7.5f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-8f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-8.5f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-9f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				Object.Instantiate<Transform>(newbattery, new Vector3(-9.5f, 9.283939f, -39.3f), Quaternion.Euler(-90f, 0f, -90f));
				((Component)Object.Instantiate<Transform>(newoldShotgun, new Vector3(8.922f, 3.911f, 6.017f), Quaternion.Euler(-90f, 0f, 0f))).GetComponent<Rigidbody>().isKinematic = true;
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(1.525f, 1.637f, 7.117f), Quaternion.Euler(-90f, 0f, 156f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-10.6f, 7.48f, -36.47f), Quaternion.Euler(0f, 180f, 0f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-11.751f, 33.655f, -2.7894275f), Quaternion.Euler(-27.703f, 90f, -90f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(8.17f, 27.0146f, -5.6f), Quaternion.Euler(180f, 0f, 0f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(6.109f, 11.792576f, -21.23f), Quaternion.Euler(-90f, 0f, 0f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(30.037045f, 11.55f, -21.955389f), Quaternion.Euler(180f, -22.5f, 90f)).transform.GetChild(0)).gameObject.SetActive(false);
				((Component)Object.Instantiate<GameObject>(RedKeyItem, new Vector3(7.858f, 7.5478f, 9.608f), Quaternion.Euler(180f, 0f, 180f)).transform.GetChild(0)).gameObject.SetActive(false);
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 4)
			{
				BoxOfSweetsItem = ((Component)Object.Instantiate<Transform>(newbirdSeed, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(0f, -90f, -90f))).gameObject;
				BoxOfSweetsItem.AddComponent<BoxOfSweetsFall>();
				BoxOfSweetsItem.tag = "Untagged";
				((Object)BoxOfSweetsItem).name = "BoxOfSweets";
				((Renderer)BoxOfSweetsItem.GetComponent<MeshRenderer>()).material.mainTexture = BoxOfSweetsTexture;
				BoxOfSweetsItem.transform.position = new Vector3(15.279f, -113.7f, 0.396f);
				((Renderer)BoxOfSweetsItem.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("BastuSpak").GetComponent<MeshRenderer>()).material.mainTexture;
				newBoxOfSweets = Object.Instantiate<GameObject>(BoxOfSweetsItem, new Vector3(28.85f, -401f, 4.68f), Quaternion.identity);
				newBoxOfSweets.tag = "Untagged";
				((Object)newBoxOfSweets).name = "newBoxOfSweets";
				birdSeed.SetActive(true);
				BoxOfSweetsHand = Object.Instantiate<GameObject>(birdSeed, birdSeed.transform.position, Quaternion.Euler(-80.237f, -15.342f, 0.037f));
				birdSeed.SetActive(false);
				((Renderer)BoxOfSweetsHand.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("BastuSpak").GetComponent<MeshRenderer>()).material.mainTexture;
				BoxOfSweetsHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				BoxOfSweetsItem.GetComponent<Rigidbody>().isKinematic = true;
				haveBoxOfSweets = true;
				dropObjectButton.SetActive(true);
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 5)
			{
				LostKeyItem = ((Component)Object.Instantiate<Transform>(newhanglockKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
				((Object)LostKeyItem).name = "LostKey";
				LostKeyItem.tag = "vitrindoorLopen";
				LostKeyItem.transform.position = GameObject.Find("Nav1").transform.position;
				((Renderer)LostKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
				newLostKey = Object.Instantiate<GameObject>(LostKeyItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
				((Object)newLostKey).name = "LostKey";
				newLostKey.tag = "vitrindoorLopen";
				hanglockKey.SetActive(true);
				LostKeyHand = Object.Instantiate<GameObject>(hanglockKey, hanglockKey.transform.position, hanglockKey.transform.rotation);
				hanglockKey.SetActive(false);
				((Renderer)LostKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
				LostKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				LostKeyHand.SetActive(false);
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav2").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav3").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav4").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav5").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav6").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav7").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav8").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav9").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav10").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav11").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav12").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav13").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav14").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav15").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
				((Object)Object.Instantiate<GameObject>(LostKeyItem, GameObject.Find("Nav16").transform.position, Quaternion.Euler(69.056f, -90f, -90f))).name = "LostKey";
			}
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 6)
			{
				BlueKeyItem = ((Component)Object.Instantiate<Transform>(newexitKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
				BlueKeyItem.tag = "Untagged";
				((Object)BlueKeyItem).name = "BlueKey";
				((Renderer)BlueKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0f, 0.33f, 1f);
				newBlueKey = Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(28.85f, -332.4f, 4.68f), Quaternion.identity);
				newBlueKey.tag = "Untagged";
				((Object)newBlueKey).name = "newBlueKey";
				exitKey.SetActive(true);
				BlueKeyHand = Object.Instantiate<GameObject>(exitKey, exitKey.transform.position, exitKey.transform.rotation);
				exitKey.SetActive(false);
				((Renderer)BlueKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0f, 0.33f, 1f);
				BlueKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				BlueKeyHand.SetActive(false);
				BlueKeyItem.GetComponent<Rigidbody>().isKinematic = true;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(10.226f, 33.166f, -5.06195f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(-17.981f, 26.729f, -5.528f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(1.6040748f, 22.297f, -21.79f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(0.332f, 26.711f, -12.199f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(-8.725f, 13.071f, -7.921f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(-0.96f, 7.331f, 6.24f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(-20.421f, 19.852f, 11.03f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
				Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(33.803f, 17.255f, -4.8f), Quaternion.Euler(-90f, 0f, 0f)).GetComponent<Rigidbody>().isKinematic = false;
			}
			((Component)Object.Instantiate<Transform>(newexitKey, new Vector3(8.0184f, 15.0127f, -40.06069f), Quaternion.Euler(-90f, 0f, -30f))).GetComponent<Rigidbody>().isKinematic = true;
			return;
		}
		if (startNewDayScript.AnomalyNR == 31)
		{
			Anomaly31Gift = ((Component)Object.Instantiate<Transform>(newbirdSeed, new Vector3(10.75f, 22.52f, -3.69f), Quaternion.Euler(180f, -90f, 90f))).gameObject;
			Anomaly31Gift.AddComponent<Anomaly31Gift>();
			((Renderer)Anomaly31Gift.GetComponent<MeshRenderer>()).material.mainTexture = MysteryBoxTexture;
			Object.Instantiate<GameObject>(Anomaly31Gift, new Vector3(9.75f, 22.52f, -3.69f), Quaternion.Euler(180f, -90f, 90f));
			Object.Instantiate<GameObject>(Anomaly31Gift, new Vector3(8.75f, 22.52f, -3.69f), Quaternion.Euler(180f, -90f, 90f));
		}
		if (startNewDayScript.AnomalyNR == 36)
		{
			LostKeyItem = ((Component)Object.Instantiate<Transform>(newhanglockKey, new Vector3(6.8829f, 13.5029f, -22.0397f), Quaternion.Euler(180f, 73.8f, 137.8f))).gameObject;
			LostKeyItem.tag = "vitrindoorLopen";
			((Object)LostKeyItem).name = "LostKey";
			((Renderer)LostKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			newLostKey = Object.Instantiate<GameObject>(LostKeyItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
			((Object)newLostKey).name = "LostKey";
			newLostKey.tag = "vitrindoorLopen";
			hanglockKey.SetActive(true);
			LostKeyHand = Object.Instantiate<GameObject>(hanglockKey, hanglockKey.transform.position, hanglockKey.transform.rotation);
			hanglockKey.SetActive(false);
			((Renderer)LostKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			LostKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			LostKeyHand.SetActive(false);
			LostKeyItem.transform.localScale = new Vector3(0.003f, 0.003f, 0.003f);
			LostKeyItem.GetComponent<Rigidbody>().isKinematic = true;
			TVRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(0f, 31f, -90f))).gameObject;
			TVRemoteItem.tag = "vitrindoorRopen";
			((Object)TVRemoteItem).name = "TVRemote";
			TVRemoteItem.transform.position = new Vector3(28.488f, 17.472f, -3.442f);
			((Renderer)TVRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.blue;
			newTVRemote = Object.Instantiate<GameObject>(TVRemoteItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			((Object)newTVRemote).name = "TVRemote";
			newTVRemote.tag = "vitrindoorRopen";
			remote.SetActive(true);
			TVRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)TVRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.blue;
			TVRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TVRemoteHand.SetActive(false);
			TVRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			((Component)TVRemoteItem.transform.GetChild(0)).gameObject.SetActive(false);
			((Component)TVRemoteItem.transform.GetChild(1)).gameObject.SetActive(false);
			RedKeyItem = ((Component)Object.Instantiate<Transform>(newplayhouseKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			RedKeyItem.tag = "Untagged";
			((Object)RedKeyItem).name = "RedKeyAnomaly27";
			RedKeyItem.transform.position = new Vector3(15.279f, -113.92f, 0.396f);
			((Renderer)RedKeyItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			newRedKey = Object.Instantiate<GameObject>(RedKeyItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			newRedKey.tag = "Untagged";
			((Object)newRedKey).name = "RedKeyAnomaly27";
			playhouseKey.SetActive(true);
			RedKeyHand = Object.Instantiate<GameObject>(playhouseKey, playhouseKey.transform.position, playhouseKey.transform.rotation);
			playhouseKey.SetActive(false);
			((Renderer)RedKeyHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			RedKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			RedKeyHand.SetActive(false);
			RedKeyItem.GetComponent<Rigidbody>().isKinematic = true;
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(6.24f, 5.87f, -18.04f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(26.885f, 5.87f, -12.3f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-7.66f, 5.87f, -10.23f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(-3.123f, 5.87f, -21.276f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(3.663f, 5.87f, -28.82f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(12.823f, 5.87f, -31.587f), Quaternion.Euler(-90f, 0f, 156f));
			Object.Instantiate<GameObject>(RedKeyItem, new Vector3(19.314f, 5.87f, -19.36f), Quaternion.Euler(-90f, 0f, 156f));
			StickItem = ((Component)Object.Instantiate<Transform>(newtopplock, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			StickItem.tag = "vitrindoorLclosed";
			((Object)StickItem).name = "MetalStick";
			Object.Destroy((Object)(object)StickItem.GetComponent<BoxCollider>());
			StickItem.GetComponent<MeshFilter>().mesh = GameObject.Find("Ammo_Garage/Ammo").GetComponent<MeshFilter>().sharedMesh;
			StickItem.transform.localScale = new Vector3(0.02f, 0.02f, 0.1f);
			StickItem.AddComponent<MeshCollider>();
			StickItem.GetComponent<MeshCollider>().convex = true;
			Object.Destroy((Object)(object)((Component)StickItem.transform.GetChild(0)).GetComponent<BoxCollider>());
			((Component)StickItem.transform.GetChild(0)).gameObject.AddComponent<CapsuleCollider>();
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().direction = 2;
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().height = 15f;
			((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().radius = 0.6f;
			((Collider)((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>()).isTrigger = true;
			newStick = Object.Instantiate<GameObject>(StickItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
			((Object)newStick).name = "MetalStick";
			newStick.tag = "vitrindoorLclosed";
			Object.Destroy((Object)(object)newStick.GetComponent<BoxCollider>());
			StickHand = Object.Instantiate<GameObject>(StickItem, new Vector3(13.389f, 23.52f, -6.918f), Quaternion.Euler(-79.392f, -6.175f, 6.07f));
			StickHand.transform.localScale = new Vector3(0.0092f, 0.0092f, 0.046f);
			StickHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			Object.Destroy((Object)(object)StickHand.GetComponent<Rigidbody>());
			Object.Destroy((Object)(object)StickHand.GetComponent<MeshCollider>());
			Object.Destroy((Object)(object)StickHand.GetComponent<BoxCollider>());
			Object.Destroy((Object)(object)((Component)StickHand.transform.GetChild(0)).gameObject);
			StickHand.SetActive(false);
			StickItem.GetComponent<Rigidbody>().isKinematic = true;
			return;
		}
		if (startNewDayScript.AnomalyNR == 101)
		{
			Object.Instantiate<Transform>(newmelon, new Vector3(-6f, 8f, -33f), Quaternion.identity);
		}
		if (startNewDayScript.AnomalyNR == 102)
		{
			dropPower = 10000f;
		}
		if (startNewDayScript.AnomalyNR == 13)
		{
			Object.Instantiate<Transform>(newremote, new Vector3(0.814f, 10.113f, 5.3560658f), Quaternion.Euler(0f, 0f, -90f));
			TVRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			TVRemoteItem.tag = "vitrindoorRopen";
			((Object)TVRemoteItem).name = "TVRemote";
			TVRemoteItem.transform.position = new Vector3(15.279f, 13.92f, 0.396f);
			((Renderer)TVRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.blue;
			newTVRemote = Object.Instantiate<GameObject>(TVRemoteItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			((Object)newTVRemote).name = "TVRemote";
			newTVRemote.tag = "vitrindoorRopen";
			remote.SetActive(true);
			TVRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, Quaternion.identity);
			remote.SetActive(false);
			((Renderer)TVRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.blue;
			TVRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TVRemoteHand.SetActive(false);
			TVRemoteItem.GetComponent<Rigidbody>().isKinematic = false;
			return;
		}
		if (startNewDayScript.AnomalyNR == 18)
		{
			if (PlayerPrefs.GetInt("randomNR") == 2)
			{
				Object.Instantiate<Transform>(newexitKey, new Vector3(6.7407246f, 7.8242807f, 1.1509709f), Quaternion.Euler(-90f, 0f, 21.54f));
			}
			if (PlayerPrefs.GetInt("randomNR") == 3 || PlayerPrefs.GetInt("randomNR") == 9)
			{
				Object.Instantiate<Transform>(newHammare, new Vector3(-15.629274f, 14.24328f, -3.667029f), Quaternion.Euler(-180f, -82.7f, 90f));
				Object.Instantiate<Transform>(newhanglockKey, new Vector3(7.144725f, 7.8122807f, 0.58197117f), Quaternion.Euler(-90f, 0f, -29f));
			}
			if (PlayerPrefs.GetInt("randomNR") == 5)
			{
				Object.Instantiate<Transform>(newHammare, new Vector3(7.58f, 8.336f, 1.3f), Quaternion.Euler(-246.1f, 103.7f, 278.74f));
				Object.Instantiate<Transform>(newhanglockKey, new Vector3(-16.064f, 15.041014f, -3.507f), Quaternion.Euler(-90f, 0f, 41.2f));
			}
			TVRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			TVRemoteItem.tag = "vitrindoorRopen";
			((Object)TVRemoteItem).name = "TVRemote";
			TVRemoteItem.transform.position = new Vector3(15.279f, 13.92f, 0.396f);
			((Renderer)TVRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.blue;
			newTVRemote = Object.Instantiate<GameObject>(TVRemoteItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			((Object)newTVRemote).name = "TVRemote";
			newTVRemote.tag = "vitrindoorRopen";
			remote.SetActive(true);
			TVRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)TVRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.blue;
			TVRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TVRemoteHand.SetActive(false);
			TVRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			((Component)TVRemoteItem.transform.GetChild(0)).gameObject.SetActive(false);
			((Component)TVRemoteItem.transform.GetChild(1)).gameObject.SetActive(false);
			Anomaly18TVRemoteRandom = Random.Range(1, 8);
			if (Anomaly18TVRemoteRandom == 1)
			{
				TVRemoteItem.transform.position = new Vector3(2.326f, 7.553f, -4.269f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(-4.2f, 97.82f, -90f);
			}
			if (Anomaly18TVRemoteRandom == 2)
			{
				TVRemoteItem.transform.position = new Vector3(-20.668f, 13.439f, -11.072f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(-74.26f, -90f, -90f);
			}
			if (Anomaly18TVRemoteRandom == 3)
			{
				TVRemoteItem.transform.position = new Vector3(11.911f, 15.726f, 5.421f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(-180f, 90f, -90f);
			}
			if (Anomaly18TVRemoteRandom == 4)
			{
				TVRemoteItem.transform.position = new Vector3(8.317f, 7.586f, 1.263f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
			}
			if (Anomaly18TVRemoteRandom == 5)
			{
				TVRemoteItem.transform.position = new Vector3(16.617f, 20.111f, -2.196f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 90f, -90f);
			}
			if (Anomaly18TVRemoteRandom == 6)
			{
				TVRemoteItem.transform.position = new Vector3(-20.752f, 25.617f, -2.627f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
			}
			if (Anomaly18TVRemoteRandom == 7)
			{
				TVRemoteItem.transform.position = new Vector3(10.551f, 14.9082f, -9.39f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 90f, -90f);
			}
			LostKeyItem = ((Component)Object.Instantiate<Transform>(newhanglockKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			LostKeyItem.tag = "vitrindoorLopen";
			((Object)LostKeyItem).name = "LostKey";
			LostKeyItem.transform.position = GameObject.Find("Nav" + Random.Range(1, 17)).transform.position;
			((Renderer)LostKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			newLostKey = Object.Instantiate<GameObject>(LostKeyItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
			((Object)newLostKey).name = "LostKey";
			newLostKey.tag = "vitrindoorLopen";
			hanglockKey.SetActive(true);
			LostKeyHand = Object.Instantiate<GameObject>(hanglockKey, hanglockKey.transform.position, hanglockKey.transform.rotation);
			hanglockKey.SetActive(false);
			((Renderer)LostKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
			LostKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			LostKeyHand.SetActive(false);
			LostKeyItem.SetActive(false);
			((Component)Object.Instantiate<Transform>(newbirdSeed, new Vector3(11.802f, 15.662174f, -6.233f), Quaternion.Euler(-90f, 0f, -123f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			((Renderer)gascan.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("GallerDoor").GetComponent<MeshRenderer>()).material.mainTexture;
			((Renderer)gascan.GetComponent<MeshRenderer>()).material.color = new Color(0.35f, 1f, 0.5f);
			Object.Instantiate<Transform>(newgascan, new Vector3(14.433f, 26.9244f, 4.37f), Quaternion.Euler(-90f, 0f, -123f));
			if (PlayerPrefs.GetInt("LaserOnOffOnOff") == 1)
			{
				NightmareBookItem = ((Component)Object.Instantiate<Transform>(newbook, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-11.43f, 0f, 90f))).gameObject;
				NightmareBookItem.tag = "Untagged";
				((Object)NightmareBookItem).name = "NightmareBook";
				NightmareBookItem.transform.position = new Vector3(4.823f, 12.782f, -26.76f);
				((Renderer)NightmareBookItem.GetComponent<MeshRenderer>()).material.color = Color.red;
				NightmareBookItem.AddComponent<NightmareBook>();
				newNightmareBook = Object.Instantiate<GameObject>(NightmareBookItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
				((Object)newNightmareBook).name = "newNightmareBook";
				newNightmareBook.tag = "Untagged";
				book.SetActive(true);
				NightmareBookHand = Object.Instantiate<GameObject>(book, book.transform.position, Quaternion.Euler(186f, -11.5f, 54.1f));
				book.SetActive(false);
				((Renderer)NightmareBookHand.GetComponent<MeshRenderer>()).material.color = Color.red;
				NightmareBookHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				NightmareBookHand.SetActive(false);
				NightmareBookItem.GetComponent<Rigidbody>().isKinematic = true;
				NightmareVaseItem = ((Component)Object.Instantiate<Transform>(newvas, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
				NightmareVaseItem.tag = "Untagged";
				((Object)NightmareVaseItem).name = "NightmareVase";
				NightmareVaseItem.transform.position = new Vector3(-18.67f, 15.058f, -3.523f);
				((Renderer)NightmareVaseItem.GetComponent<MeshRenderer>()).material.color = Color.red;
				NightmareVaseItem.AddComponent<NightmareVase>();
				newNightmareVase = Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
				newNightmareVase.tag = "Untagged";
				((Object)newNightmareVase).name = "newNightmareVase";
				vas.SetActive(true);
				NightmareVaseHand = Object.Instantiate<GameObject>(vas, vas.transform.position, Quaternion.Euler(-106.5f, -210.4f, -60.6f));
				vas.SetActive(false);
				((Renderer)NightmareVaseHand.GetComponent<MeshRenderer>()).material.color = Color.red;
				NightmareVaseHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				NightmareVaseHand.SetActive(false);
				NightmareVaseItem.GetComponent<Rigidbody>().isKinematic = true;
				NightmareHammerItem = ((Component)Object.Instantiate<Transform>(newHammare, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-55.14f, 0f, 90f))).gameObject;
				NightmareHammerItem.tag = "Untagged";
				((Object)NightmareHammerItem).name = "NightmareHammer";
				NightmareHammerItem.transform.position = new Vector3(7.6f, 22.962f, -2.21f);
				((Renderer)NightmareHammerItem.GetComponent<MeshRenderer>()).material.color = new Color(0.6f, 0f, 0f);
				newNightmareHammer = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
				newNightmareHammer.AddComponent<NightmareMelon>();
				newNightmareHammer.tag = "Untagged";
				((Object)newNightmareHammer).name = "newNightmareHammer";
				hammare.SetActive(true);
				NightmareHammerHand = Object.Instantiate<GameObject>(hammare, hammare.transform.position, Quaternion.Euler(-82f, -5f, -269f));
				hammare.SetActive(false);
				((Renderer)NightmareHammerHand.GetComponent<MeshRenderer>()).material.color = new Color(0.6f, 0f, 0f);
				NightmareHammerHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				NightmareHammerHand.SetActive(false);
				NightmareHammerItem.GetComponent<Rigidbody>().isKinematic = true;
				NightmareHammerItem2 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(8.3f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
				((Object)NightmareHammerItem2).name = "NightmareHammer";
				NightmareHammerItem3 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(9f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
				((Object)NightmareHammerItem3).name = "NightmareHammer";
				NightmareHammerItem4 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(9.7f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
				((Object)NightmareHammerItem4).name = "NightmareHammer";
				NightmareHammerItem5 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(10.4f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
				((Object)NightmareHammerItem5).name = "NightmareHammer";
			}
			return;
		}
		StickItem = ((Component)Object.Instantiate<Transform>(newtopplock, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		StickItem.tag = "vitrindoorLclosed";
		((Object)StickItem).name = "MetalStick";
		Object.Destroy((Object)(object)StickItem.GetComponent<BoxCollider>());
		StickItem.GetComponent<MeshFilter>().mesh = GameObject.Find("Ammo_Garage/Ammo").GetComponent<MeshFilter>().sharedMesh;
		StickItem.transform.localScale = new Vector3(0.02f, 0.02f, 0.1f);
		StickItem.AddComponent<MeshCollider>();
		StickItem.GetComponent<MeshCollider>().convex = true;
		Object.Destroy((Object)(object)((Component)StickItem.transform.GetChild(0)).GetComponent<BoxCollider>());
		((Component)StickItem.transform.GetChild(0)).gameObject.AddComponent<CapsuleCollider>();
		((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().direction = 2;
		((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().height = 15f;
		((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>().radius = 0.6f;
		((Collider)((Component)StickItem.transform.GetChild(0)).gameObject.GetComponent<CapsuleCollider>()).isTrigger = true;
		newStick = Object.Instantiate<GameObject>(StickItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
		((Object)newStick).name = "MetalStick";
		newStick.tag = "vitrindoorLclosed";
		Object.Destroy((Object)(object)newStick.GetComponent<BoxCollider>());
		StickHand = Object.Instantiate<GameObject>(StickItem, new Vector3(13.389f, 23.52f, -6.918f), Quaternion.Euler(-79.392f, -6.175f, 6.07f));
		StickHand.transform.localScale = new Vector3(0.0092f, 0.0092f, 0.046f);
		StickHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		Object.Destroy((Object)(object)StickHand.GetComponent<Rigidbody>());
		Object.Destroy((Object)(object)StickHand.GetComponent<MeshCollider>());
		Object.Destroy((Object)(object)StickHand.GetComponent<BoxCollider>());
		Object.Destroy((Object)(object)((Component)StickHand.transform.GetChild(0)).gameObject);
		StickHand.SetActive(false);
		StickItem.GetComponent<Rigidbody>().isKinematic = true;
		LostKeyItem = ((Component)Object.Instantiate<Transform>(newhanglockKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		LostKeyItem.tag = "vitrindoorLopen";
		((Object)LostKeyItem).name = "LostKey";
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			GameObject.Find("Nav1").transform.localPosition = new Vector3(-41.55f, -9.02f, 67f);
			GameObject.Find("Nav2").transform.localPosition = new Vector3(-63.655f, -10.138f, 29f);
			if (startNewDayScript.PrimeAnomalyNR == 13)
			{
				GameObject.Find("Nav2").transform.position = GameObject.Find("Nav10").transform.position;
				GameObject.Find("Nav8").transform.position = GameObject.Find("Nav9").transform.position;
				GameObject.Find("Nav11").transform.position = GameObject.Find("Nav7").transform.position;
				GameObject.Find("Nav12").transform.position = GameObject.Find("Nav6").transform.position;
				GameObject.Find("Nav15").transform.position = GameObject.Find("Nav5").transform.position;
				GameObject.Find("Nav16").transform.position = GameObject.Find("Nav1").transform.position;
			}
		}
		LostKeyItem.transform.position = GameObject.Find("Nav" + Random.Range(1, 17)).transform.position;
		((Renderer)LostKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
		newLostKey = Object.Instantiate<GameObject>(LostKeyItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
		((Object)newLostKey).name = "LostKey";
		newLostKey.tag = "vitrindoorLopen";
		hanglockKey.SetActive(true);
		LostKeyHand = Object.Instantiate<GameObject>(hanglockKey, hanglockKey.transform.position, hanglockKey.transform.rotation);
		hanglockKey.SetActive(false);
		((Renderer)LostKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.86f, 1f, 0f);
		LostKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		LostKeyHand.SetActive(false);
		TVRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		TVRemoteItem.tag = "vitrindoorRopen";
		((Object)TVRemoteItem).name = "TVRemote";
		TVRemoteItem.transform.position = new Vector3(15.279f, 13.92f, 0.396f);
		((Renderer)TVRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.blue;
		newTVRemote = Object.Instantiate<GameObject>(TVRemoteItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
		((Object)newTVRemote).name = "TVRemote";
		newTVRemote.tag = "vitrindoorRopen";
		remote.SetActive(true);
		TVRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
		remote.SetActive(false);
		((Renderer)TVRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.blue;
		TVRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		TVRemoteHand.SetActive(false);
		TVRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
		WireItem = ((Component)Object.Instantiate<Transform>(newpadlockCode, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		WireItem.tag = "spak";
		Object.Destroy((Object)(object)WireItem.GetComponent<BoxCollider>());
		WireItem.GetComponent<MeshFilter>().mesh = GameObject.Find("HouseUpdateVind4/KabelFan").GetComponent<MeshFilter>().sharedMesh;
		((Renderer)WireItem.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("FakeWall").GetComponent<MeshRenderer>()).material.mainTexture;
		((Renderer)WireItem.GetComponent<MeshRenderer>()).material.color = Color.white;
		WireItem.transform.localScale = new Vector3(0.4f, 0.4f, 0.64f);
		WireItem.AddComponent<BoxCollider>();
		Object.Destroy((Object)(object)((Component)WireItem.transform.GetChild(1)).gameObject);
		((Component)WireItem.transform.GetChild(0)).gameObject.GetComponent<BoxCollider>().center = new Vector3(-0.000328431f, 0.001440272f, 0.01421105f);
		((Component)WireItem.transform.GetChild(0)).gameObject.GetComponent<BoxCollider>().size = new Vector3(0.003084279f, 0.007525504f, 0.03194545f);
		newWire = Object.Instantiate<GameObject>(WireItem, new Vector3(28.85f, 32.4f, 4.68f), Quaternion.identity);
		((Object)newWire).name = "Wire";
		newWire.tag = "spak";
		Object.Destroy((Object)(object)newWire.GetComponent<BoxCollider>());
		WireHand = Object.Instantiate<GameObject>(WireItem, new Vector3(13.47f, 23.507f, -7.065f), Quaternion.Euler(273.95197f, 337.7683f, 233.8279f));
		WireHand.transform.localScale = new Vector3(0.15f, 0.15f, 0.24f);
		WireHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		Object.Destroy((Object)(object)WireHand.GetComponent<Rigidbody>());
		Object.Destroy((Object)(object)WireHand.GetComponents<BoxCollider>()[0]);
		Object.Destroy((Object)(object)WireHand.GetComponents<BoxCollider>()[1]);
		Object.Destroy((Object)(object)((Component)WireHand.transform.GetChild(0)).gameObject);
		Object.Destroy((Object)(object)((Component)WireHand.transform.GetChild(1)).gameObject);
		WireOnPlace = Object.Instantiate<GameObject>(WireItem, new Vector3(24.304962f, 23.507f, 7.927f), Quaternion.Euler(337.1969f, 335.0712f, 259.54407f));
		WireOnPlace.transform.localScale = new Vector3(0.4f, 0.4f, 0.64f);
		WireOnPlace.tag = "Untagged";
		Object.Destroy((Object)(object)WireOnPlace.GetComponent<Rigidbody>());
		Object.Destroy((Object)(object)WireOnPlace.GetComponent<MeshCollider>());
		Object.Destroy((Object)(object)WireOnPlace.GetComponent<BoxCollider>());
		Object.Destroy((Object)(object)((Component)WireOnPlace.transform.GetChild(0)).gameObject);
		Object.Destroy((Object)(object)((Component)WireOnPlace.transform.GetChild(1)).gameObject);
		WireHand.SetActive(false);
		WireOnPlace.SetActive(false);
		WireItem.GetComponent<Rigidbody>().isKinematic = true;
		if (PlayerPrefs.GetInt("LaserOnOffOnOff") == 1)
		{
			NightmareBookItem = ((Component)Object.Instantiate<Transform>(newbook, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-11.43f, 0f, 90f))).gameObject;
			NightmareBookItem.tag = "Untagged";
			((Object)NightmareBookItem).name = "NightmareBook";
			NightmareBookItem.transform.position = new Vector3(4.823f, 12.782f, -26.76f);
			((Renderer)NightmareBookItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareBookItem.AddComponent<NightmareBook>();
			newNightmareBook = Object.Instantiate<GameObject>(NightmareBookItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			((Object)newNightmareBook).name = "newNightmareBook";
			newNightmareBook.tag = "Untagged";
			book.SetActive(true);
			NightmareBookHand = Object.Instantiate<GameObject>(book, book.transform.position, Quaternion.Euler(186f, -11.5f, 54.1f));
			book.SetActive(false);
			((Renderer)NightmareBookHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareBookHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareBookHand.SetActive(false);
			NightmareBookItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareVaseItem = ((Component)Object.Instantiate<Transform>(newvas, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
			NightmareVaseItem.tag = "Untagged";
			((Object)NightmareVaseItem).name = "NightmareVase";
			NightmareVaseItem.transform.position = new Vector3(-18.95f, 15.03f, -3.86f);
			((Renderer)NightmareVaseItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareVaseItem.AddComponent<NightmareVase>();
			newNightmareVase = Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(28.85f, -32.4f, 4.68f), Quaternion.identity);
			newNightmareVase.tag = "Untagged";
			((Object)newNightmareVase).name = "newNightmareVase";
			vas.SetActive(true);
			NightmareVaseHand = Object.Instantiate<GameObject>(vas, vas.transform.position, Quaternion.Euler(-106.5f, -210.4f, -60.6f));
			vas.SetActive(false);
			((Renderer)NightmareVaseHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareVaseHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareVaseHand.SetActive(false);
			NightmareVaseItem.GetComponent<Rigidbody>().isKinematic = true;
			((Object)Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(3.277f, 19.25442f, -17.237f), Quaternion.Euler(-90f, 0f, 0f))).name = "NightmareVase";
			if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				((Object)Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(7.73f, 10.69f, 8.2f), Quaternion.Euler(-90f, 0f, 0f))).name = "NightmareVase";
				((Object)Object.Instantiate<GameObject>(NightmareVaseItem, new Vector3(18.10294f, 17.64175f, 12.735934f), Quaternion.Euler(-90f, 0f, 0f))).name = "NightmareVase";
			}
			NightmareMelonItem = ((Component)Object.Instantiate<Transform>(newmelon, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(180f, -34.36f, 0f))).gameObject;
			NightmareMelonItem.tag = "Untagged";
			((Object)NightmareMelonItem).name = "NightmareMelon";
			NightmareMelonItem.transform.position = new Vector3(-7.98f, 17.86f, 6.49f);
			((Renderer)NightmareMelonItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			newNightmareMelon = Object.Instantiate<GameObject>(NightmareMelonItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareMelon.AddComponent<NightmareMelon>();
			newNightmareMelon.tag = "Untagged";
			((Object)newNightmareMelon).name = "newNightmareMelon";
			melon.SetActive(true);
			NightmareMelonHand = Object.Instantiate<GameObject>(melon, melon.transform.position, Quaternion.Euler(122.89f, -102.35f, 0f));
			melon.SetActive(false);
			((Renderer)NightmareMelonHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareMelonHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareMelonHand.SetActive(false);
			NightmareMelonItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareHammerItem = ((Component)Object.Instantiate<Transform>(newHammare, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-55.14f, 0f, 90f))).gameObject;
			NightmareHammerItem.tag = "Untagged";
			((Object)NightmareHammerItem).name = "NightmareHammer";
			NightmareHammerItem.transform.position = new Vector3(7.6f, 22.962f, -2.21f);
			((Renderer)NightmareHammerItem.GetComponent<MeshRenderer>()).material.color = new Color(0.6f, 0f, 0f);
			newNightmareHammer = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareHammer.tag = "Untagged";
			((Object)newNightmareHammer).name = "newNightmareHammer";
			hammare.SetActive(true);
			NightmareHammerHand = Object.Instantiate<GameObject>(hammare, hammare.transform.position, Quaternion.Euler(-82f, -5f, -269f));
			hammare.SetActive(false);
			((Renderer)NightmareHammerHand.GetComponent<MeshRenderer>()).material.color = new Color(0.6f, 0f, 0f);
			NightmareHammerHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareHammerHand.SetActive(false);
			NightmareHammerItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareHammerItem2 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(8.3f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem2).name = "NightmareHammer";
			NightmareHammerItem3 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(9f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem3).name = "NightmareHammer";
			NightmareHammerItem4 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(9.7f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem4).name = "NightmareHammer";
			NightmareHammerItem5 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(10.4f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem5).name = "NightmareHammer";
			NightmareHammerItem6 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(11.1f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem6).name = "NightmareHammer";
			NightmareHammerItem7 = Object.Instantiate<GameObject>(NightmareHammerItem, new Vector3(11.8f, 22.962f, -2.21f), Quaternion.Euler(-55.14f, 0f, 90f));
			((Object)NightmareHammerItem7).name = "NightmareHammer";
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				NightmareHammerItem5.SetActive(false);
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				NightmareHammerItem4.SetActive(false);
				NightmareHammerItem5.SetActive(false);
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				NightmareHammerItem3.SetActive(false);
				NightmareHammerItem4.SetActive(false);
				NightmareHammerItem5.SetActive(false);
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				NightmareHammerItem2.SetActive(false);
				NightmareHammerItem3.SetActive(false);
				NightmareHammerItem4.SetActive(false);
				NightmareHammerItem5.SetActive(false);
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				NightmareHammerItem.SetActive(false);
				NightmareHammerItem2.SetActive(false);
				NightmareHammerItem3.SetActive(false);
				NightmareHammerItem4.SetActive(false);
				NightmareHammerItem5.SetActive(false);
				NightmareHammerItem6.SetActive(false);
				NightmareHammerItem7.SetActive(false);
			}
			NightmareBatteryItem = ((Component)Object.Instantiate<Transform>(newbattery, new Vector3(21.159f, 21.03218f, 8.208f), Quaternion.Euler(-90f, -111f, 180f))).gameObject;
			NightmareBatteryItem.tag = "Untagged";
			((Object)NightmareBatteryItem).name = "NightmareBattery";
			((Renderer)NightmareBatteryItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			newNightmareBattery = Object.Instantiate<GameObject>(NightmareBatteryItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareBattery.tag = "Untagged";
			((Object)newNightmareBattery).name = "newNightmareBattery";
			newNightmareBattery.AddComponent<NightmareBattery>();
			battery.SetActive(true);
			NightmareBatteryHand = Object.Instantiate<GameObject>(battery, battery.transform.position, battery.transform.rotation);
			battery.SetActive(false);
			((Renderer)NightmareBatteryHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareBatteryHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareBatteryHand.SetActive(false);
			NightmareBatteryItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareTrapItem = ((Component)Object.Instantiate<Transform>(newfreezeTrap, new Vector3(5.738f, 33.6298f, 9.273f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
			NightmareTrapItem.tag = "Untagged";
			((Object)NightmareTrapItem).name = "NightmareTrap";
			((Renderer)NightmareTrapItem.GetComponent<MeshRenderer>()).material.color = Color.red;
			Object.Destroy((Object)(object)NightmareTrapItem.GetComponent<freezeTrap>());
			newNightmareTrap = Object.Instantiate<GameObject>(NightmareTrapItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareTrap.tag = "Untagged";
			((Object)newNightmareTrap).name = "newNightmareTrap";
			newNightmareTrap.AddComponent<NightmareTrap>();
			freezeTrap.SetActive(true);
			NightmareTrapHand = Object.Instantiate<GameObject>(freezeTrap, freezeTrap.transform.position, freezeTrap.transform.rotation);
			freezeTrap.SetActive(false);
			((Renderer)NightmareTrapHand.GetComponent<MeshRenderer>()).material.color = Color.red;
			NightmareTrapHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareTrapHand.SetActive(false);
			NightmareTrapItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareCanItem = ((Component)Object.Instantiate<Transform>(newgascan, new Vector3(3.85f, 13.32f, 3.27f), Quaternion.Euler(-90f, 0f, -18f))).gameObject;
			NightmareCanItem.tag = "Untagged";
			((Object)NightmareCanItem).name = "NightmareCan";
			((Renderer)NightmareCanItem.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			newNightmareCan = Object.Instantiate<GameObject>(NightmareCanItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareCan.tag = "Untagged";
			((Object)newNightmareCan).name = "newNightmareCan";
			gascan.SetActive(true);
			NightmareCanHand = Object.Instantiate<GameObject>(gascan, gascan.transform.position, gascan.transform.rotation);
			gascan.SetActive(false);
			((Renderer)NightmareCanHand.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			NightmareCanHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareCanHand.SetActive(false);
			NightmareCanItem.GetComponent<Rigidbody>().isKinematic = true;
			NightmareRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(-15.5f, 13.525f, -3.67f), Quaternion.Euler(0f, -37f, -90f))).gameObject;
			NightmareRemoteItem.tag = "Untagged";
			((Object)NightmareRemoteItem).name = "NightmareRemote";
			((Renderer)NightmareRemoteItem.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			newNightmareRemote = Object.Instantiate<GameObject>(NightmareRemoteItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareRemote.tag = "Untagged";
			((Object)newNightmareRemote).name = "newNightmareRemote";
			remote.SetActive(true);
			NightmareRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)NightmareRemoteHand.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			NightmareRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareRemoteHand.SetActive(false);
			NightmareRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			((Component)NightmareRemoteItem.transform.GetChild(1)).gameObject.SetActive(false);
			NightmareWrenchItem = ((Component)Object.Instantiate<Transform>(newwrench, new Vector3(-10.25f, 20.68f, -2.76f), Quaternion.Euler(-90f, 0f, -9f))).gameObject;
			NightmareWrenchItem.tag = "Untagged";
			((Object)NightmareWrenchItem).name = "NightmareWrench";
			((Renderer)NightmareWrenchItem.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			newNightmareWrench = Object.Instantiate<GameObject>(NightmareWrenchItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
			newNightmareWrench.tag = "Untagged";
			((Object)newNightmareWrench).name = "newNightmareWrench";
			wrench.SetActive(true);
			NightmareWrenchHand = Object.Instantiate<GameObject>(wrench, wrench.transform.position, wrench.transform.rotation);
			wrench.SetActive(false);
			((Renderer)NightmareWrenchHand.GetComponent<MeshRenderer>()).material.color = new Color(0.77f, 0f, 0f);
			NightmareWrenchHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			NightmareWrenchHand.SetActive(false);
			NightmareWrenchItem.GetComponent<Rigidbody>().isKinematic = true;
			((Component)NightmareWrenchItem.transform.GetChild(1)).gameObject.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				NightmareWeaponKeyItem = ((Component)Object.Instantiate<Transform>(newweaponKey, new Vector3(-15.588f, 27.046f, 10.5266f), Quaternion.Euler(-33f, 90f, -90f))).gameObject;
				NightmareWeaponKeyItem.tag = "Untagged";
				((Object)NightmareWeaponKeyItem).name = "NightmareWeaponKey";
				((Renderer)NightmareWeaponKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.54f, 0f, 0f);
				newNightmareWeaponKey = Object.Instantiate<GameObject>(NightmareWeaponKeyItem, new Vector3(28.85f, -350.4f, 4.68f), Quaternion.identity);
				newNightmareWeaponKey.tag = "Untagged";
				((Object)newNightmareWeaponKey).name = "newNightmareWeaponKey";
				weaponKey.SetActive(true);
				NightmareWeaponKeyHand = Object.Instantiate<GameObject>(weaponKey, weaponKey.transform.position, weaponKey.transform.rotation);
				weaponKey.SetActive(false);
				((Renderer)NightmareWeaponKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.54f, 0f, 0f);
				NightmareWeaponKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
				NightmareWeaponKeyHand.SetActive(false);
				NightmareWeaponKeyItem.GetComponent<Rigidbody>().isKinematic = true;
				((Object)Object.Instantiate<GameObject>(NightmareWeaponKeyItem, new Vector3(-20.272f, 23.29f, -13.286f), Quaternion.Euler(-90f, 0f, 60f))).name = "NightmareWeaponKey";
				((Object)Object.Instantiate<GameObject>(NightmareWeaponKeyItem, new Vector3(-10.4f, 12.38f, -34.7f), Quaternion.Euler(-90f, 0f, 37f))).name = "NightmareWeaponKey";
				((Object)Object.Instantiate<GameObject>(NightmareWeaponKeyItem, new Vector3(-4.342f, 13.505f, 3.75f), Quaternion.Euler(-15f, 90f, -90f))).name = "NightmareWeaponKey";
				((Object)Object.Instantiate<GameObject>(NightmareWeaponKeyItem, new Vector3(6.515f, 14.068f, -21.142f), Quaternion.Euler(-8.875f, 65.3f, -90f))).name = "NightmareWeaponKey";
			}
		}
		BlueKeyItem = ((Component)Object.Instantiate<Transform>(newexitKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
		BlueKeyItem.tag = "Untagged";
		((Object)BlueKeyItem).name = "BlueKey";
		((Renderer)BlueKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0f, 0.33f, 1f);
		newBlueKey = Object.Instantiate<GameObject>(BlueKeyItem, new Vector3(28.85f, -332.4f, 4.68f), Quaternion.identity);
		newBlueKey.tag = "Untagged";
		((Object)newBlueKey).name = "newBlueKey";
		exitKey.SetActive(true);
		BlueKeyHand = Object.Instantiate<GameObject>(exitKey, exitKey.transform.position, exitKey.transform.rotation);
		exitKey.SetActive(false);
		((Renderer)BlueKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0f, 0.33f, 1f);
		BlueKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		BlueKeyHand.SetActive(false);
		BlueKeyItem.GetComponent<Rigidbody>().isKinematic = true;
		BlueKeyArea = Object.Instantiate<GameObject>(GameObject.Find("Remotetrigger"), new Vector3(-17.1f, 14.33f, -7.59f), Quaternion.Euler(-90f, 0f, 0f));
		((Object)BlueKeyArea).name = "BlueKeyArea";
		BlueKeyArea.transform.SetParent((Transform)null);
		BlueKeyArea.transform.localScale = new Vector3(5.3f, 5.3f, 5.3f);
		BlueKeyAreaNR = Random.Range(1, 9);
		if (startNewDayScript.PrimeAnomalyNR == 13)
		{
			BlueKeyAreaNR = Random.Range(2, 7);
		}
		if (BlueKeyAreaNR == 1)
		{
			BlueKeyArea.transform.position = new Vector3(7.75f, 27.81f, -2.42f);
			BlueKeyItem.transform.position = new Vector3(10.226f, 33.166f, -5.06195f);
		}
		if (BlueKeyAreaNR == 2)
		{
			BlueKeyArea.transform.position = new Vector3(-18.39f, 21.54f, -5.42f);
			BlueKeyItem.transform.position = new Vector3(-17.981f, 26.729f, -5.528f);
		}
		if (BlueKeyAreaNR == 3)
		{
			BlueKeyArea.transform.position = new Vector3(-5.42f, 18.18f, -20.72f);
			BlueKeyItem.transform.position = new Vector3(-7.7f, 22.297f, -18.46f);
		}
		if (BlueKeyAreaNR == 4)
		{
			BlueKeyArea.transform.position = new Vector3(2.75f, 21.05f, -9.51f);
			BlueKeyItem.transform.position = new Vector3(0.332f, 26.711f, -12.199f);
		}
		if (BlueKeyAreaNR == 5)
		{
			BlueKeyArea.transform.position = new Vector3(-6.65f, 8.31f, -5.13f);
			BlueKeyItem.transform.position = new Vector3(-8.725f, 13.071f, -7.921f);
		}
		if (BlueKeyAreaNR == 6)
		{
			BlueKeyArea.transform.position = new Vector3(-17.92f, 14.21f, 9.34f);
			BlueKeyItem.transform.position = new Vector3(-20.421f, 19.852f, 11.03f);
		}
		if (BlueKeyAreaNR == 7)
		{
			BlueKeyArea.transform.position = new Vector3(-1.72f, 2.38f, 3.65f);
			BlueKeyItem.transform.position = new Vector3(-0.96f, 7.331f, 6.24f);
		}
		if (BlueKeyAreaNR == 8)
		{
			BlueKeyArea.transform.position = new Vector3(30.91f, 12.651f, -7.54f);
			BlueKeyItem.transform.position = new Vector3(33.803f, 17.255f, -4.8f);
		}
		DoorUnlockItem = ((Component)Object.Instantiate<Transform>(newcarbattery, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(-47.07f, 0f, 0f))).gameObject;
		DoorUnlockItem.tag = "Untagged";
		((Object)DoorUnlockItem).name = "DoorUnlock";
		((Renderer)DoorUnlockItem.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("GallerDoor").GetComponent<MeshRenderer>()).material.mainTexture;
		DoorUnlockItem.transform.position = new Vector3(-8.155f, 17.805f, 3.682f);
		DoorUnlockItem.transform.localScale = new Vector3(0.2f, 0.2256524f, 0.22f);
		DoorUnlockLamp = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa2"));
		DoorUnlockLamp.transform.SetParent(DoorUnlockItem.transform);
		DoorUnlockLamp.transform.localPosition = new Vector3(0f, 0.014f, 0.707f);
		DoorUnlockLamp.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		DoorUnlockLamp.transform.localScale = new Vector3(1.15f, 4.18f, 1.0117539f);
		((Renderer)DoorUnlockLamp.GetComponent<MeshRenderer>()).material.color = Color.green;
		newDoorUnlock = Object.Instantiate<GameObject>(DoorUnlockItem, new Vector3(28.85f, -335.4f, 4.68f), Quaternion.identity);
		newDoorUnlock.tag = "Untagged";
		((Object)newDoorUnlock).name = "newDoorUnlock";
		DoorUnlockHand = Object.Instantiate<GameObject>(DoorUnlockItem, new Vector3(13.573f, 23.747f, -7.018f), Quaternion.Euler(-25f, 151f, -18f));
		Object.Destroy((Object)(object)DoorUnlockHand.GetComponent<Rigidbody>());
		Object.Destroy((Object)(object)DoorUnlockHand.GetComponent<BoxCollider>());
		Object.Destroy((Object)(object)((Component)DoorUnlockHand.transform.GetChild(0)).gameObject);
		DoorUnlockHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		DoorUnlockHand.transform.localScale = new Vector3(0.06f, 0.067695715f, 0.066f);
		DoorUnlockHand.SetActive(false);
		DoorUnlockItem.GetComponent<Rigidbody>().isKinematic = true;
		ButtonNewEscapeItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		ButtonNewEscapeItem.tag = "Untagged";
		((Object)ButtonNewEscapeItem).name = "ButtonLiftEscape";
		Object.Destroy((Object)(object)ButtonNewEscapeItem.GetComponent<BoxCollider>());
		ButtonNewEscapeItem.GetComponent<MeshFilter>().mesh = GameObject.Find("Larmlampa2").GetComponent<MeshFilter>().sharedMesh;
		((Renderer)ButtonNewEscapeItem.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)GameObject.Find("Larmlampa2").GetComponent<MeshRenderer>()).material.mainTexture;
		((Renderer)ButtonNewEscapeItem.GetComponent<MeshRenderer>()).material.color = Color.red;
		ButtonNewEscapeItem.transform.localScale = new Vector3(0.49f, 0.49f, 0.49f);
		ButtonNewEscapeItem.transform.position = new Vector3(15.279f, 13.92f, 0.396f);
		ButtonNewEscapeItem.AddComponent<MeshCollider>();
		ButtonNewEscapeItem.GetComponent<MeshCollider>().convex = true;
		Object.Destroy((Object)(object)((Component)ButtonNewEscapeItem.transform.GetChild(1)).gameObject);
		((Component)ButtonNewEscapeItem.transform.GetChild(0)).gameObject.GetComponent<BoxCollider>().center = new Vector3(0f, 0f, 2.5f);
		((Component)ButtonNewEscapeItem.transform.GetChild(0)).gameObject.GetComponent<BoxCollider>().size = new Vector3(14.6f, 13.46f, 13.35f);
		newButtonNewEscape = Object.Instantiate<GameObject>(ButtonNewEscapeItem, new Vector3(28.85f, -324.4f, 4.68f), Quaternion.identity);
		newButtonNewEscape.tag = "Untagged";
		((Object)newButtonNewEscape).name = "newButtonLiftEscape";
		ButtonNewEscapeHand = Object.Instantiate<GameObject>(ButtonNewEscapeItem, new Vector3(13.36f, 23.638f, -6.947f), Quaternion.Euler(273.95197f, 337.7683f, 233.8279f));
		ButtonNewEscapeHand.transform.localScale = new Vector3(0.15f, 0.15f, 0.24f);
		ButtonNewEscapeHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		Object.Destroy((Object)(object)ButtonNewEscapeHand.GetComponent<Rigidbody>());
		Object.Destroy((Object)(object)ButtonNewEscapeHand.GetComponent<BoxCollider>());
		Object.Destroy((Object)(object)ButtonNewEscapeHand.GetComponent<MeshCollider>());
		Object.Destroy((Object)(object)((Component)ButtonNewEscapeHand.transform.GetChild(0)).gameObject);
		Object.Destroy((Object)(object)((Component)ButtonNewEscapeHand.transform.GetChild(1)).gameObject);
		ButtonNewEscapeHand.SetActive(false);
		ButtonNewEscapeItem.GetComponent<Rigidbody>().isKinematic = true;
		RedKeyItem = ((Component)Object.Instantiate<Transform>(newcarKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		RedKeyItem.tag = "Untagged";
		((Object)RedKeyItem).name = "CaramelKey";
		RedKeyItem.transform.position = new Vector3(15.279f, -13.92f, 0.396f);
		((Renderer)RedKeyItem.GetComponent<MeshRenderer>()).material.color = Color.yellow;
		newRedKey = Object.Instantiate<GameObject>(RedKeyItem, new Vector3(28.85f, -400f, 4.68f), Quaternion.identity);
		newRedKey.tag = "Untagged";
		((Object)newRedKey).name = "newCaramelKey";
		carKey.SetActive(true);
		RedKeyHand = Object.Instantiate<GameObject>(carKey, carKey.transform.position, carKey.transform.rotation);
		carKey.SetActive(false);
		((Renderer)RedKeyHand.GetComponent<MeshRenderer>()).material.color = Color.yellow;
		RedKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		RedKeyHand.SetActive(false);
		RedKeyItem.GetComponent<Rigidbody>().isKinematic = true;
		ChocolateKeyItem = ((Component)Object.Instantiate<Transform>(newcarKey, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
		ChocolateKeyItem.tag = "Untagged";
		((Object)ChocolateKeyItem).name = "ChocolateKey";
		ChocolateKeyItem.transform.position = new Vector3(15.279f, -13.7f, 0.396f);
		((Renderer)ChocolateKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.27f, 0.12f, 0f);
		newChocolateKey = Object.Instantiate<GameObject>(ChocolateKeyItem, new Vector3(28.85f, -401f, 4.68f), Quaternion.identity);
		newChocolateKey.tag = "Untagged";
		((Object)newChocolateKey).name = "newChocolateKey";
		carKey.SetActive(true);
		ChocolateKeyHand = Object.Instantiate<GameObject>(carKey, carKey.transform.position, carKey.transform.rotation);
		carKey.SetActive(false);
		((Renderer)ChocolateKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.27f, 0.12f, 0f);
		ChocolateKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		ChocolateKeyHand.SetActive(false);
		ChocolateKeyItem.GetComponent<Rigidbody>().isKinematic = true;
		BoxOfSweetsItem = ((Component)Object.Instantiate<Transform>(newbirdSeed, new Vector3(28.85f, 35f, 4.68f), Quaternion.Euler(0f, -90f, -90f))).gameObject;
		BoxOfSweetsItem.AddComponent<BoxOfSweetsFall>();
		BoxOfSweetsItem.tag = "Untagged";
		((Object)BoxOfSweetsItem).name = "BoxOfSweets";
		BoxOfSweetsItem.transform.position = new Vector3(15.279f, 13.7f, 0.396f);
		((Renderer)BoxOfSweetsItem.GetComponent<MeshRenderer>()).material.mainTexture = BoxOfSweetsTexture;
		newBoxOfSweets = Object.Instantiate<GameObject>(BoxOfSweetsItem, new Vector3(28.85f, -401f, 4.68f), Quaternion.identity);
		newBoxOfSweets.tag = "Untagged";
		((Object)newBoxOfSweets).name = "newBoxOfSweets";
		birdSeed.SetActive(true);
		BoxOfSweetsHand = Object.Instantiate<GameObject>(birdSeed, birdSeed.transform.position, Quaternion.Euler(-80.237f, -15.342f, 0.037f));
		birdSeed.SetActive(false);
		((Renderer)BoxOfSweetsHand.GetComponent<MeshRenderer>()).material.mainTexture = BoxOfSweetsTexture;
		BoxOfSweetsHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
		BoxOfSweetsHand.SetActive(false);
		BoxOfSweetsItem.GetComponent<Rigidbody>().isKinematic = true;
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			TeleportRemoteItem = ((Component)Object.Instantiate<Transform>(newremote, new Vector3(28.85f, 55f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			TeleportRemoteItem.tag = "Untagged";
			((Object)TeleportRemoteItem).name = "TeleportRemote";
			((Renderer)TeleportRemoteItem.GetComponent<MeshRenderer>()).material.color = Color.green;
			newTeleportRemote = Object.Instantiate<GameObject>(TeleportRemoteItem, new Vector3(28.85f, -224f, 4.68f), Quaternion.identity);
			newTeleportRemote.tag = "Untagged";
			((Object)newTeleportRemote).name = "newTeleportRemote";
			remote.SetActive(true);
			TeleportRemoteHand = Object.Instantiate<GameObject>(remote, remote.transform.position, remote.transform.rotation);
			remote.SetActive(false);
			((Renderer)TeleportRemoteHand.GetComponent<MeshRenderer>()).material.color = Color.green;
			TeleportRemoteHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			TeleportRemoteItem.GetComponent<Rigidbody>().isKinematic = true;
			TeleportRemoteHand.SetActive(false);
			PrimeTeddyItem = ((Component)Object.Instantiate<Transform>(newteddy, new Vector3(28.85f, 55f, 4.68f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
			PrimeTeddyItem.tag = "Untagged";
			((Object)PrimeTeddyItem).name = "TruePrimeTeddy";
			PrimeTeddyItem.GetComponent<Rigidbody>().isKinematic = true;
			newPrimeTeddy = Object.Instantiate<GameObject>(PrimeTeddyItem, new Vector3(28.85f, -224f, 4.68f), Quaternion.identity);
			newPrimeTeddy.tag = "Untagged";
			((Object)newPrimeTeddy).name = "newTruePrimeTeddy";
			teddy.SetActive(true);
			PrimeTeddyHand = Object.Instantiate<GameObject>(teddy, teddy.transform.position, teddy.transform.rotation);
			teddy.SetActive(false);
			PrimeTeddyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			PrimeTeddyHand.SetActive(false);
			TrueTeddyNR = Random.Range(1, 4);
			DarkMessage = ((Component)Object.Instantiate<Transform>(newmessage, new Vector3(12.8f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).gameObject;
			DarkMessage.GetComponent<Rigidbody>().isKinematic = true;
			((Renderer)DarkMessage.GetComponent<MeshRenderer>()).material.color = new Color(0.2f, 0f, 0f);
			DarkMessage.tag = "Untagged";
			((Object)DarkMessage).name = "TeddyMessage";
			if (PlayerPrefs.GetInt("randomNR") == 1)
			{
				DarkMessage.transform.position = new Vector3(9.375f, 14.244f, -19.062f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, 162f, 0f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 2)
			{
				DarkMessage.transform.position = new Vector3(-4.385f, 17.12f, 4.22f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, 90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 3)
			{
				DarkMessage.transform.position = new Vector3(-20.71f, 23.14f, -13.76f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, 90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 4)
			{
				DarkMessage.transform.position = new Vector3(-15.472f, 15.055f, -3.33f);
				DarkMessage.transform.rotation = Quaternion.Euler(90f, 90f, -53f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 5)
			{
				DarkMessage.transform.position = new Vector3(-15.693f, 30.09f, 3f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, 90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 6)
			{
				DarkMessage.transform.position = new Vector3(11.347f, 4.6f, -0.02f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, -90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 7)
			{
				DarkMessage.transform.position = new Vector3(4.533f, 30.9f, -7.077f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, -90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 8)
			{
				DarkMessage.transform.position = new Vector3(19.545f, 14.81f, 3.41f);
				DarkMessage.transform.rotation = Quaternion.Euler(180f, -90f, -167f);
			}
			if (PlayerPrefs.GetInt("randomNR") == 9)
			{
				DarkMessage.transform.position = new Vector3(21.52f, 22.63f, -0.9f);
				DarkMessage.transform.rotation = Quaternion.Euler(90f, -107f, 180f);
			}
			if (TrueTeddyNR == 1)
			{
				PrimeTeddyItem.transform.position = new Vector3(15.2f, 12.85f, -26.13f);
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(12.8f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime1";
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(14f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime2";
			}
			if (TrueTeddyNR == 2)
			{
				PrimeTeddyItem.transform.position = new Vector3(12.8f, 12.85f, -26.13f);
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(15.2f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime1";
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(14f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime2";
			}
			if (TrueTeddyNR == 3)
			{
				PrimeTeddyItem.transform.position = new Vector3(14f, 12.85f, -26.13f);
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(15.2f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime1";
				((Object)Object.Instantiate<GameObject>(newPrimeTeddy, new Vector3(12.8f, 12.85f, -26.13f), Quaternion.Euler(-90f, 0f, 0f))).name = "FakeTeddyPrime2";
			}
			newPrimeTeddy.GetComponent<Rigidbody>().isKinematic = false;
			DarkKeyItem = ((Component)Object.Instantiate<Transform>(newsafeKey, new Vector3(28.85f, -1055f, 4.68f), Quaternion.Euler(69.056f, -90f, -90f))).gameObject;
			DarkKeyItem.tag = "Untagged";
			((Object)DarkKeyItem).name = "DarkKey";
			((Renderer)DarkKeyItem.GetComponent<MeshRenderer>()).material.color = new Color(0.5f, 0f, 0f);
			newDarkKey = Object.Instantiate<GameObject>(DarkKeyItem, new Vector3(28.85f, -274f, 4.68f), Quaternion.identity);
			newDarkKey.tag = "Untagged";
			((Object)newDarkKey).name = "newDarkKey";
			safeKey.SetActive(true);
			DarkKeyHand = Object.Instantiate<GameObject>(safeKey, safeKey.transform.position, safeKey.transform.rotation);
			safeKey.SetActive(false);
			((Renderer)DarkKeyHand.GetComponent<MeshRenderer>()).material.color = new Color(0.5f, 0f, 0f);
			DarkKeyHand.transform.SetParent(GameObject.Find("HandHoldObjects").transform);
			DarkKeyItem.GetComponent<Rigidbody>().isKinematic = true;
			DarkKeyHand.SetActive(false);
		}
		if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			StickItem.transform.position = new Vector3(-2.1352751f, 8.348278f, -40.45203f);
			StickItem.transform.rotation = Quaternion.Euler(105f, -180f, -90f);
			TVRemoteItem.transform.position = new Vector3(0.396f, 8.601f, -18.329f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
			WireItem.transform.position = new Vector3(-9.625f, 14.72f, -29.747f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, 89f, -261.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(-0.678f, 2.25f, 0.32f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 68.72f, 0f);
			BoxOfSweetsItem.transform.position = new Vector3(-2.47f, 14.376f, -38.54f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(0f, -107f, -90f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			StickItem.transform.position = new Vector3(-10.039275f, 15.623279f, -29.025028f);
			StickItem.transform.rotation = Quaternion.Euler(105f, 0f, -90f);
			TVRemoteItem.transform.position = new Vector3(-10.853f, 29.15f, -5.251f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 115f, -90f);
			WireItem.transform.position = new Vector3(7.449f, 7.89f, 0.598f);
			WireItem.transform.rotation = Quaternion.Euler(-1.3f, -44.5f, -90f);
			ButtonNewEscapeItem.transform.position = new Vector3(6.838f, 13.475f, -22.071f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(0f, 68.72f, -90f);
			BoxOfSweetsItem.transform.position = new Vector3(5.37f, 35.577f, 9.274f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(180f, -49f, 90f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				ButtonNewEscapeItem.transform.position = new Vector3(-19.5f, 15.189f, 13.41f);
				ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, -31f, 0f);
				ButtonNewEscapeItem.transform.SetParent(GameObject.Find("LodaParent/Loda").transform);
				ButtonNewEscapeItem.transform.localScale = new Vector3(2.274157f, 2.3556404f, 0.7103749f);
			}
		}
		if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			StickItem.transform.position = new Vector3(5.6127253f, 16.653278f, 3.3029714f);
			StickItem.transform.rotation = Quaternion.Euler(105f, 0f, -90f);
			TVRemoteItem.GetComponent<Rigidbody>().isKinematic = false;
			WireItem.transform.position = new Vector3(-16.096f, 30.272f, 7.153f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, 89f, -261.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(12.63f, 21.565f, -11.93f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 0f, -134.7f);
			BoxOfSweetsItem.transform.position = new Vector3(13.59f, 9.62f, -3.84f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(180f, -48.1f, 90f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			StickItem.transform.position = new Vector3(-15.392275f, 27.892279f, 5.431971f);
			StickItem.transform.rotation = Quaternion.Euler(105f, -90f, -90f);
			TVRemoteItem.transform.position = new Vector3(4.066f, 3.351f, -0.763f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 90f, -90f);
			WireItem.transform.position = new Vector3(-6.35f, 9.325f, -39.46f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, 89f, -261.45f);
			TVRemoteItem.transform.SetParent(GameObject.Find("Car").transform);
			ButtonNewEscapeItem.transform.position = new Vector3(6.838f, 13.475f, -22.071f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(0f, 68.72f, -90f);
			BoxOfSweetsItem.transform.position = new Vector3(-3.328f, 21f, -15.166f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(0f, 103f, 0f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			StickItem.transform.position = new Vector3(6.8297253f, 8.760279f, 0.31997156f);
			StickItem.transform.rotation = Quaternion.Euler(105f, -180f, -90f);
			TVRemoteItem.transform.position = new Vector3(5.1f, 15.721f, 3.232f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 29f, -90f);
			WireItem.transform.position = new Vector3(8.463f, 12.462f, -30.736f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, 89f, -261.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(0.396f, 8.5f, -18.329f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
			BoxOfSweetsItem.transform.position = new Vector3(2.558f, 14.7026f, -12.025f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(180f, 73f, -90f);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				TVRemoteItem.transform.position = new Vector3(-7.19f, 9.3f, -39.79f);
				TVRemoteItem.transform.rotation = Quaternion.Euler(0f, 109f, -90f);
			}
		}
		if (PlayerPrefs.GetInt("randomNR") == 6)
		{
			StickItem.transform.position = new Vector3(-11.468f, 34.457f, -1.04f);
			StickItem.transform.rotation = Quaternion.Euler(105f, -90f, -90f);
			TVRemoteItem.transform.position = new Vector3(-16.05f, 30.42f, 7.045f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(-62f, 180f, -90f);
			WireItem.transform.position = new Vector3(18.248f, 16.133f, 2.471f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, -3.216f, -270.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(2.1517668f, 20.6f, -19.305658f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 90f, -90f);
			ButtonNewEscapeItem.transform.SetParent(GameObject.Find("Loda2Parent (7)/ByroLoda").transform);
			BoxOfSweetsItem.transform.position = new Vector3(-19.1f, 25.677f, -11.6f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(180f, -121f, -90f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 7)
		{
			StickItem.transform.position = new Vector3(3.4f, 20.23f, -16.55f);
			StickItem.transform.rotation = Quaternion.Euler(105f, 90f, -90f);
			TVRemoteItem.transform.position = new Vector3(6.8743f, 13.499f, -22.0534f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(-90f, 180f, -21.552f);
			WireItem.transform.position = new Vector3(8.488f, 15.045f, -39.944f);
			WireItem.transform.rotation = Quaternion.Euler(-180f, 89f, -261.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(6.685f, 7.819f, 0.419f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 0f, -40f);
			StickItem.transform.position = new Vector3(-0.829f, 2.319f, 0.422f);
			StickItem.transform.rotation = Quaternion.Euler(180f, 15f, -90f);
			StickItem.transform.SetParent(GameObject.Find("Car").transform);
			BoxOfSweetsItem.transform.position = new Vector3(33.686f, 11.928f, -13.537f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(0f, 147f, 90f);
			ButtonNewEscapeItem.transform.position = new Vector3(5.56f, 15.755f, 3.25f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 0f, -40f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 8)
		{
			StickItem.transform.position = new Vector3(6.8297253f, 8.760279f, 0.31997156f);
			StickItem.transform.rotation = Quaternion.Euler(105f, -180f, -90f);
			TVRemoteItem.transform.position = new Vector3(23.155167f, 13.369307f, -18.946373f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(-90f, 0f, -46.91f);
			TVRemoteItem.GetComponent<Rigidbody>().isKinematic = false;
			TVRemoteItem.transform.SetParent(GameObject.Find("GiljotinParent2").transform.GetChild(6));
			WireItem.transform.position = new Vector3(18.8664f, 16.124f, 12.406f);
			WireItem.transform.rotation = Quaternion.Euler(-1.3f, -44.5f, -90f);
			ButtonNewEscapeItem.transform.position = new Vector3(-15.955f, 30.162f, 7.532f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
			BoxOfSweetsItem.transform.position = new Vector3(5.012f, 15.779f, 3.286f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(0f, 115.39f, -90f);
		}
		if (PlayerPrefs.GetInt("randomNR") == 9)
		{
			StickItem.transform.position = new Vector3(-15.522f, 16.029f, -2.126f);
			StickItem.transform.rotation = Quaternion.Euler(75f, 180f, 90f);
			TVRemoteItem.transform.position = new Vector3(6.8743f, 13.499f, -22.0534f);
			TVRemoteItem.transform.rotation = Quaternion.Euler(-90f, 180f, -21.552f);
			WireItem.transform.position = new Vector3(5.905f, 35.551f, 8.662f);
			WireItem.transform.rotation = Quaternion.Euler(180f, 127.6f, -261.45f);
			ButtonNewEscapeItem.transform.position = new Vector3(0.396f, 8.5f, -18.329f);
			ButtonNewEscapeItem.transform.rotation = Quaternion.Euler(-90f, 90f, 0f);
			BoxOfSweetsItem.transform.position = new Vector3(12.9f, 21.584f, -11.79f);
			BoxOfSweetsItem.transform.rotation = Quaternion.Euler(0f, -110f, -90f);
		}
		if (startNewDayScript.AnomalyNR == 11 || startNewDayScript.AnomalyNR == 31 || startNewDayScript.AnomalyNR == 91)
		{
			itemsRain = new Transform[30]
			{
				newAvbitare, newHammare, newsafeKey, newBoxOfSweets.transform, newexitKey, newhanglockKey, newpadlockCode, newweaponKey, newplayhouseKey, newmelon,
				newkugg1, newkugg2, newbrunnsvev, newgunDel1, newgunDel2, newgunDel3, newcarKey, newtopplock, newcarbattery, newButtonNewEscape.transform,
				newwrench, newsparkplug, newmeat, newspecialkey, newbattery, newremote, newbirdSeed, newStick.transform, newTVRemote.transform, newWire.transform
			};
		}
	}

	public virtual void GreenKeyDropAnomaly18()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<Transform>(newLostKey.transform, GameObject.Find("Bip01 L Forearm").transform.position, Quaternion.Euler(0f, -90f, 0f));
	}

	public virtual void RandomPresetAnomaly18()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			Object.Instantiate<Transform>(newexitKey, new Vector3(6.7407246f, 7.8242807f, 1.1509709f), Quaternion.Euler(-90f, 0f, 21.54f));
		}
		if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			Object.Instantiate<Transform>(newHammare, new Vector3(-15.629274f, 14.24328f, -3.667029f), Quaternion.Euler(-180f, -82.7f, 90f));
			Object.Instantiate<Transform>(newhanglockKey, new Vector3(7.144725f, 7.8122807f, 0.58197117f), Quaternion.Euler(-90f, 0f, -29f));
		}
		if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			Object.Instantiate<Transform>(newHammare, new Vector3(7.58f, 8.336f, 1.3f), Quaternion.Euler(-246.1f, 103.7f, 278.74f));
			Object.Instantiate<Transform>(newhanglockKey, new Vector3(-16.064f, 15.041014f, -3.507f), Quaternion.Euler(-90f, 0f, 41.2f));
		}
	}

	public virtual void RainAnomaly20()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.identity);
		Object.Instantiate<Transform>(itemsRain[Random.Range(0, 30)], new Vector3(Random.Range(7.15f, 33.59f), 40f, Random.Range(-26.3f, -13.83f)), Quaternion.identity);
	}

	public virtual IEnumerator XBowDropAnomaly20()
	{
		yield return (object)new WaitForSeconds(15f);
		if (havearmborst)
		{
			CheckInventory();
		}
	}

	public virtual IEnumerator TeddyPlayhouseAnomaly20()
	{
		yield return (object)new WaitForSeconds(23f);
		Object.Instantiate<GameObject>(newDarkKey, new Vector3(-14.74f, 30.3f, -0.63f), Quaternion.Euler(90f, 0f, 0f));
	}

	public virtual void Event2BookSpawn()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1001: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_1053: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_1194: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10be: Unknown result type (might be due to invalid IL or missing references)
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1247: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Unknown result type (might be due to invalid IL or missing references)
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1317: Unknown result type (might be due to invalid IL or missing references)
		//IL_1335: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Unknown result type (might be due to invalid IL or missing references)
		//IL_1523: Unknown result type (might be due to invalid IL or missing references)
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1390: Unknown result type (might be due to invalid IL or missing references)
		//IL_1457: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_157a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_176c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1780: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_1963: Unknown result type (might be due to invalid IL or missing references)
		//IL_1977: Unknown result type (might be due to invalid IL or missing references)
		//IL_180a: Unknown result type (might be due to invalid IL or missing references)
		//IL_181e: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Unknown result type (might be due to invalid IL or missing references)
		//IL_171a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Unknown result type (might be due to invalid IL or missing references)
		//IL_1874: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_190c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1920: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9c: Unknown result type (might be due to invalid IL or missing references)
		BookRandom = Random.Range(1, 56);
		if (BookRandom == 1)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(12.719725f, 21.508278f, -11.850029f), Quaternion.Euler(-90f, 0f, -50f));
		}
		if (BookRandom == 2)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(7.47f, 11.9f), 22.6f, Random.Range(-3.95f, -2.6f)), Quaternion.Euler(-90f, 0f, 180f));
		}
		if (BookRandom == 3)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(1f, 20.44f, -12.57f), Quaternion.Euler(-21.684f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 4)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(19.495f, 20.44f, -0.357f), Quaternion.Euler(-21.684f, -90f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 5)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(7.2f, 16.9f), 23.86f, Random.Range(0f, 13.05f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 6)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(-3.6107514f, 22.861204f, 2.368f), Quaternion.Euler(-90f, 51.12f, 180f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 7)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-10.221f, -8.608f), 21.52f, -2.776f), Quaternion.Euler(-90f, 0f, 180f));
		}
		if (BookRandom == 8)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(-15.084f, 24.48f, -7.359907f), Quaternion.Euler(-21.069f, 90f, 85.73f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 9)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(-17.942122f, 25.599031f, -11.527132f), Quaternion.Euler(-90f, 0f, 107.452f));
		}
		if (BookRandom == 10)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(-19.675f, 25.59903f, Random.Range(-10.175f, -3.94f)), Quaternion.Euler(-90f, 0f, 149.9f));
		}
		if (BookRandom == 11)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-14.613f, -12.948f), 21.52f, -0.472f), Quaternion.Euler(-90f, 0f, 180f));
		}
		if (BookRandom == 12)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-15.89f, -8.26f), 23.86f, Random.Range(0.92f, 12.51f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 13)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-6.542f, 4.879f), 23.86f, Random.Range(-0.42f, 12.059f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 14)
		{
			BookPlaceRandom = Random.Range(1, 5);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(18.352835f, 16.086872f, 12.709f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(18.352835f, 14.577f, 12.536112f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(18f, 17.99f, 12.073f), Quaternion.Euler(-26.569f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 4)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(18f, 16.43f, 12.073f), Quaternion.Euler(-26.569f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 15)
		{
			BookPlaceRandom = Random.Range(1, 5);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(17.942f, 13.903f, 8.21f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(17.942f, 13.903f, 3.23f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(15.093f, 13.9f, 0.231f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 4)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(12.733f, 13.9f, 0.231f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
		}
		if (BookRandom == 16)
		{
			BookPlaceRandom = Random.Range(1, 5);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(14.851f, 16.265f), 17.365f, -0.463f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(12.523f, 13.843f), 17.365f, -0.463f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(12.416f, 16.205f), 16.23f, Random.Range(0.3f, 0.829f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 4)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(17.458f, 18.751f), 16.23f, Random.Range(7.412f, 8.776f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
		}
		if (BookRandom == 17)
		{
			BookPlaceRandom = Random.Range(1, 6);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(2.262f, 4.752f), 14.62596f, -12.021f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(2.262f, 4.752f), 13.427f, -12.021f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(2.262f, 4.752f), 16.2f, -12.021f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 4)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(5.0397253f, 18.009277f, -12.055029f), Quaternion.Euler(200.286f, 90f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 5)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(3.770725f, 16.54028f, -12.469028f), Quaternion.Euler(-20.286f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 18)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(5.283725f, 18.05428f, -1.9590285f), Quaternion.Euler(199.119f, 0f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 19)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(-15.543f, 15.041017f, -3.429573f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 20)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-16.43f, -14.926f), 14.259f, -3.891f), Quaternion.Euler(-90f, 0f, -90f));
		}
		if (BookRandom == 21)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-19.297f, -9.31f), 16.23f, Random.Range(3.298f, 13f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 22)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(-8.122275f, 14.625278f, 4.061971f), Quaternion.Euler(-90f, 0f, 86.629f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 23)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(3.016f, 9.493389f, 5.021f), Quaternion.Euler(-90f, 0f, -160.5f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 24)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(6.593f, 7.577f), 10.32532f, Random.Range(0.085f, 1.52f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 25)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(-3.50608f, 9.782485f, 1.64f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(-3.14f, 9.782485f, 3.7f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-4.3f, 7.807f, 6.813f), Quaternion.Euler(-26.3f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 26)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(2.4642801f, 9.11261f, -4.82613f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 27)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(7.529f, 10.706601f, 8.636565f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 28)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-5.070519f, 8.276f), 4.273071f, -6.096f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 29)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-5.070519f, 8.276f), 2.86f, -6.096f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 30)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-3.94f, 10.57f), 5.592f, Random.Range(-4.989f, 6.15f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 31)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(9.96f, 1.96f, -6.58f), Quaternion.Euler(-26.3f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(7.03f, 3.859f, 6.087f), Quaternion.Euler(-90f, 0f, 90f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(8.276725f, 4.2712784f, -6.1790285f), Quaternion.Euler(-90f, 0f, -50.952f));
			}
		}
		if (BookRandom == 32)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-3.615953f, 2.11f), 4.027135f, 10.941f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 33)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-3.615953f, 2.11f), 3.073f, 10.172f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 34)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(12.556f, 14.207f), 9.544464f, Random.Range(-4.485f, -3.386f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 35)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(-5.682f, 7.526702f, -9.256f), Quaternion.Euler(-90f, 90f, 180f));
		}
		if (BookRandom == 36)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(32.285f, 33.972f), 14.20493f, Random.Range(-3.632f, -3.291f)), Quaternion.Euler(-90f, -90f, 180f));
		}
		if (BookRandom == 37)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(34.43f, 14.61f, -6.24426f), Quaternion.Euler(-31.892f, -90f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 2)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(34.43f, 15.87f, -6.24426f), Quaternion.Euler(-31.892f, -90f, -91.887f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(34.42f, 14.58f, -8.03f), Quaternion.Euler(-31.892f, -90f, -89.3f));
			}
		}
		if (BookRandom == 38)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 39)
		{
			((Component)Object.Instantiate<Transform>(newbook, new Vector3(33.575f, 17.38026f, -10.536f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BookRandom == 40)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(7.15f, 33.59f), 20f, Random.Range(-26.3f, -13.83f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 41)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(3.787f, 7.344f), 8.267f, Random.Range(-20.359f, -15.865f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(3.13f, 7.97f), 8.267f, Random.Range(-39.914f, -37.202f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-10.2f, 8.304f), 8.267f, Random.Range(-35.79f, -31.888f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
		}
		if (BookRandom == 42)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(7.962f, 14.363f, -29.4f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(7.962f, 12.45f, -29.4f), Quaternion.Euler(-90f, 0f, 180f));
			}
			if (BookPlaceRandom == 3)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(7.962f, 12.45f, -30.755f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
		}
		if (BookRandom == 43)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-2.885f, -2.19f), 14.36f, Random.Range(-39.914f, -36.134f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 44)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-7.359f, -6.107f), 14.253f, -19.127f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 45)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-1.2357223f, 16.13f, -20.569f), Quaternion.Euler(-14.679f, -180f, 265.896f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 2)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(0.7f, 16.271f, -20.57f), Quaternion.Euler(-14.679f, -180f, 265.896f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(4.823f, 12.782f, -26.76f), Quaternion.Euler(-11.43f, 0f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 46)
		{
			BookPlaceRandom = Random.Range(1, 4);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-6.71f, 1.753f), 7.5f, Random.Range(-17.69f, -15.18f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(-5.712f, 7.5267024f, -13.814f), Quaternion.Euler(-90f, -90f, 180f));
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(2.23f, 7.84f, Random.Range(-17.69f, -15.18f)), Quaternion.Euler(203.232f, 90f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 47)
		{
			BookPlaceRandom = Random.Range(1, 3);
			if (BookPlaceRandom == 1)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(0.33072495f, 19.119278f, -19.113028f), Quaternion.Euler(-141.446f, -69.83398f, 89.78f));
			}
			if (BookPlaceRandom == 2)
			{
				Object.Instantiate<Transform>(newbook, new Vector3(1.237725f, 18.819279f, -19.355028f), Quaternion.Euler(-90f, 0f, 17.279f));
			}
		}
		if (BookRandom == 48)
		{
			BookPlaceRandom = Random.Range(1, 5);
			if (BookPlaceRandom == 1)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-5.8880343f, 19.503195f, Random.Range(-17.275702f, -15.673f)), Quaternion.Euler(-25.341f, 90f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 2)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-5.8880343f, 21.12f, Random.Range(-17.275702f, -15.673f)), Quaternion.Euler(-25.341f, 90f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-5.17f, -2.729f), 21.12f, -15.12f), Quaternion.Euler(-25.341f, 180f, 90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 4)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-5.17f, -2.729f), 19.503195f, -15.12f), Quaternion.Euler(-25.341f, 180f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 49)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(3.25f, 19.25442f, Random.Range(-17.106f, -15.555f)), Quaternion.Euler(-90f, 0f, 180f));
		}
		if (BookRandom == 50)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-15.341f, -13.687f), 22.46065f, Random.Range(-18.015f, -13.739f)), Quaternion.Euler(-90f, -90f, 180f));
		}
		if (BookRandom == 51)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(Random.Range(-27.215f, -21.5f), 25.51614f, Random.Range(-1.563f, 2.56f)), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 52)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(12.582387f, 26.934237f, 4.6f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
		if (BookRandom == 53)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(-0.1f, 26.933475f, 8.137471f), Quaternion.Euler(-90f, 0f, 180f));
		}
		if (BookRandom == 54)
		{
			BookPlaceRandom = Random.Range(1, 7);
			if (BookPlaceRandom == 1)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(9.53f, 27.34f, -5.58f), Quaternion.Euler(-15.294f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 2)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(0.41f, 27.34f, -5.58f), Quaternion.Euler(-15.294f, 0f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 3)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-0.3f, 27.34f, Random.Range(-5.17f, -2.729f)), Quaternion.Euler(-15.294f, 90f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 4)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(-0.3f, 27.34f, 12.71f), Quaternion.Euler(-15.294f, 90f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 5)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(10.58f, 27.34f, Random.Range(6.73f, 12.6f)), Quaternion.Euler(-15.294f, -90f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
			if (BookPlaceRandom == 6)
			{
				((Component)Object.Instantiate<Transform>(newbook, new Vector3(10.58f, 27.34f, Random.Range(-2.65f, 2.07f)), Quaternion.Euler(-15.294f, -90f, -90f))).gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
		if (BookRandom == 55)
		{
			Object.Instantiate<Transform>(newbook, new Vector3(33.7f, 11.86f, -14f), Quaternion.Euler(-90f, Random.Range(-180f, 180f), 180f));
		}
	}

	public virtual IEnumerator Event3MelonGamblingNew(int melons, float melonsMin, float melonsMax)
	{
		int melonsMinInt = Mathf.RoundToInt(melonsMin);
		int melonsMaxInt = Mathf.RoundToInt(melonsMax);
		((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color = Color.red;
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		EatingCounter = Random.Range(melonsMinInt, melonsMaxInt);
		yield return (object)new WaitForSeconds(0.1f);
		((Graphic)gameController.GetComponent<startNewDay>().EventChallenge3Text.GetComponent<Text>()).color = Color.green;
		EatingCounter = melons;
		if (EatingCounter == 67)
		{
			AchievementSaveManager.Instance.UnlockAchievement("SixSevenAchievement");
		}
		if (EatingCounter >= 1000)
		{
			AchievementSaveManager.Instance.UnlockAchievement("GamblingAddicion");
		}
	}

	public virtual IEnumerator Event3LoanNew(int loan)
	{
		yield return (object)new WaitForSeconds(60f);
		EatingCounter -= loan;
	}
}
