using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class EnemyAIGranny : MonoBehaviour
{
	public PickUp PickUpScript;

	public Transform myTransform;

	public Transform grannyEye;

	public GameObject grannyLock;

	public Transform target;

	public Transform bedtargetTemp1;

	public Transform bedtargetTemp2;

	public Transform bedtargetTemp3;

	public Transform coffintargetTemp4;

	public Transform coffintargetTempBY;

	public Transform cartargetTemp;

	public GameObject bedCam1;

	public GameObject bedCam2;

	public GameObject bedCam3;

	public GameObject coffinHead1;

	public GameObject coffinHead2;

	public GameObject carHead;

	public bool hidingUnderBed1;

	public bool hidingUnderBed2;

	public bool hidingUnderBed3;

	public bool hidingInCoffin4;

	public bool hidingInCoffinBY;

	public bool hidingInCar;

	public bool playerHiding;

	public bool playerInHole;

	public bool grannyInBastu;

	public bool bastuswitchOn;

	public bool bastuBomNere;

	public bool bastuTimeOff;

	public float bastuTimer;

	public float bastuDoorTimer;

	public GameObject bastuDoor;

	public NavMeshObstacle bastuDoorCarv;

	public GameObject bastuBom;

	public bool StartbastuSafeTimer;

	public float bastuSafeTimer;

	public Transform player;

	public GameObject Player;

	public Transform playerPos;

	public NavMeshAgent navComponent;

	public float number;

	public float speed;

	public Transform nav1;

	public Transform nav2;

	public Transform nav3;

	public Transform nav4;

	public Transform nav5;

	public Transform nav6;

	public Transform nav7;

	public Transform nav8;

	public Transform nav9;

	public Transform nav10;

	public Transform nav11;

	public Transform nav12;

	public Transform nav13;

	public Transform nav14;

	public Transform nav15;

	public Transform nav16;

	public bool seePlayer;

	public bool seePlayerTimer;

	public float offScreenDot;

	public bool waypointStop;

	public bool waypointStart;

	public float distanceWaypoint;

	public float distance;

	public float attackDistance;

	public bool waypointWaitTime;

	public bool timerOnOff;

	public float timer;

	public float timerSee;

	public float timerSearch;

	public float timerBed;

	public float safeTimer;

	public bool resetSafeTimer;

	public bool startTimerSearch;

	public bool GrannySearching;

	public bool GrannySearch;

	public bool GrannyMoving;

	public bool attackingPlayer;

	public bool huntPlayer;

	public bool grannyIsFollow;

	public GameObject animationHolder;

	public bool startWalk;

	public bool stopWalk;

	public bool startAttack;

	public bool grannyHearPlayer;

	public bool grannyHearObject;

	public bool playerHidingUnderBed;

	public bool playerHidingInCoffin;

	public bool playerHidingInCoffinBackyard;

	public bool playerHidingInCar;

	public bool grannyStandBesideCar;

	public bool grannyLookUnderBed;

	public GameObject allBedButtons;

	public bool playerGetCaught;

	public bool checkInstansName;

	public bool playerFallDeath;

	public bool dontHitPlayer;

	public GameObject doorRay;

	public GameObject checkGround;

	public float seeClosedDoorTimer;

	public float safeDoorTimer;

	public bool grannySeeDoor;

	public bool grannySeeLockedDoor;

	public bool stopSeeLockedDoor;

	public GameObject gameController;

	public bool playerCaughtLastTime;

	public GameObject playerHukaKnapp;

	public GameObject playerHukaKnappParent;

	public GameObject optionButton;

	public Transform PlayerCoffinPos;

	public Transform PlayerCoffinBYPos;

	public Transform PlayerCarPos;

	public GameObject coffinLock;

	public GameObject coffinLockBY;

	public GameObject Spider;

	public GameObject bearTrap;

	public GameObject bearTrapOrganic;

	public Transform bearTrapSP;

	public bool droppingBeartrap;

	public bool soundPlaying;

	public GameObject soundHolder1;

	public GameObject soundHolder2;

	public GameObject soundHolder3;

	public GameObject playerSounds;

	public GameObject grannySounds;

	public GameObject[] NPoints;

	public bool seeStairs;

	public bool hitByArrow;

	public bool hitByGun;

	public bool hitByCar;

	public bool hitByPepper;

	public bool hitByPepperStart;

	public bool freeze;

	public bool bastuKilled;

	public bool ragdollSpawn;

	public Transform grannyRagdoll;

	public Transform grannyForceRagdoll;

	public Transform grannyFreezedoll;

	public GameObject grannyDisaper;

	public float grannysVarSpeed;

	public float grannysAnimSpeed;

	public bool turnFacePlayer;

	public bool playerInPrison;

	public bool prisondoorClosed;

	public bool playerNearGranny;

	public bool GrannyGonnaSmack;

	public bool playerHaveTeddy;

	public bool spiderIsDead;

	public bool playerStartCar;

	public bool grannyEyeColorTimerOn;

	public float grannyEyeColorTimer;

	public float blindTimer = 30f;

	public bool grannyPepperReact;

	public GameObject grannyEyeColor;

	public GameObject teddyMusicHolder;

	public GameObject GrannyHuntMusicHolder;

	public GameObject startCarButton;

	public GameObject forwardButton;

	public GameObject reverseButton;

	public GameObject engineOnSound;

	public GameObject engineOffSound;

	public GameObject engineStartSound;

	public GameObject ObjectHolder;

	public GameObject grannyCloseTrigger;

	public float WalkSpeed;

	public float WalkAnim;

	public float TrainingWalkSpeed;

	public float TrainingWalkAnim;

	public float TrainingRunSpeed;

	public float TrainingRunAnim;

	public float AnomalyTimer;

	public GameObject Anomaly17Trap;

	public float Anomaly24Kef;

	public float StartMoveSpeed;

	public float StartMoveAnim;

	public int RatBiteCount;

	public bool grannyAbility;

	public GameObject Anomaly25Granny;

	public GameObject Anomaly25Leg1;

	public GameObject Anomaly25Leg2;

	public GameObject Anomaly25Bat;

	public GameObject Anomaly25Eyes;

	public GameObject Anomaly25Tooth;

	public GameObject Anomaly25Hair;

	public int Event2GrannySpeed;

	public GameObject GrannyCloneAnomaly28;

	public bool SetClone;

	public GameObject CurrentClone;

	public bool PrimeNowIsOn;

	public bool GrannyTrainingStop;

	public bool isAlreadyCleaning;

	public EnemyAIGranny()
	{
		offScreenDot = 0.8f;
		waypointStart = true;
		timerOnOff = true;
	}

	public virtual void Start()
	{
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Unknown result type (might be due to invalid IL or missing references)
		//IL_102b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_115c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1240: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1700: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f6: Unknown result type (might be due to invalid IL or missing references)
		hitByArrow = false;
		hitByGun = false;
		hitByCar = false;
		hitByPepper = false;
		hitByPepperStart = false;
		freeze = false;
		grannyLock.SetActive(false);
		grannyPepperReact = false;
		GrannyGonnaSmack = false;
		bastuKilled = false;
		grannyStandBesideCar = false;
		playerInPrison = false;
		target = nav1;
		number = Random.Range(1, 33);
		WalkSpeed = 1.2f;
		WalkAnim = 0.9f;
		animationHolder.GetComponent<Animation>().cullingType = (AnimationCullingType)0;
		if (number == 1f || number == 2f)
		{
			target = GameObject.Find("Nav1").transform;
		}
		if (number == 3f || number == 4f)
		{
			target = GameObject.Find("Nav2").transform;
		}
		if (number == 5f || number == 6f)
		{
			target = GameObject.Find("Nav3").transform;
		}
		if (number == 7f || number == 8f)
		{
			target = GameObject.Find("Nav4").transform;
		}
		if (number == 9f || number == 10f)
		{
			target = GameObject.Find("Nav5").transform;
		}
		if (number == 11f || number == 12f)
		{
			target = GameObject.Find("Nav6").transform;
		}
		if (number == 13f || number == 14f)
		{
			target = GameObject.Find("Nav7").transform;
		}
		if (number == 15f || number == 16f)
		{
			target = GameObject.Find("Nav8").transform;
		}
		if (number == 17f || number == 18f)
		{
			target = GameObject.Find("Nav9").transform;
		}
		if (number == 19f || number == 20f)
		{
			target = GameObject.Find("Nav10").transform;
		}
		if (number == 21f || number == 22f)
		{
			target = GameObject.Find("Nav11").transform;
		}
		if (number == 23f || number == 24f)
		{
			target = GameObject.Find("Nav12").transform;
		}
		if (number == 25f || number == 26f)
		{
			target = GameObject.Find("Nav13").transform;
		}
		if (number == 27f || number == 28f)
		{
			target = GameObject.Find("Nav14").transform;
		}
		if (number == 29f || number == 30f)
		{
			target = GameObject.Find("Nav15").transform;
		}
		if (number == 31f || number == 32f)
		{
			target = GameObject.Find("Nav16").transform;
		}
		navComponent = (NavMeshAgent)((Component)((Component)this).transform).GetComponent(typeof(NavMeshAgent));
		player = GameObject.Find("Player").transform;
		playerPos = GameObject.Find("Main Camera").transform;
		nav1 = GameObject.Find("Nav1").transform;
		nav2 = GameObject.Find("Nav2").transform;
		nav3 = GameObject.Find("Nav3").transform;
		nav4 = GameObject.Find("Nav4").transform;
		nav5 = GameObject.Find("Nav5").transform;
		nav6 = GameObject.Find("Nav6").transform;
		nav7 = GameObject.Find("Nav7").transform;
		nav8 = GameObject.Find("Nav8").transform;
		nav9 = GameObject.Find("Nav9").transform;
		nav10 = GameObject.Find("Nav10").transform;
		nav11 = GameObject.Find("Nav11").transform;
		nav12 = GameObject.Find("Nav12").transform;
		nav13 = GameObject.Find("Nav13").transform;
		nav14 = GameObject.Find("Nav14").transform;
		nav15 = GameObject.Find("Nav15").transform;
		nav16 = GameObject.Find("Nav16").transform;
		navComponent.speed = WalkSpeed;
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			grannysVarSpeed = 2.3f;
			grannysAnimSpeed = 1.3f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
		{
			grannysVarSpeed = 4.3f;
			grannysAnimSpeed = 2f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			grannysVarSpeed = 3f;
			grannysAnimSpeed = 1.5f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			grannysVarSpeed = 5f;
			grannysAnimSpeed = 2.7f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			grannysVarSpeed = 7f;
			grannysAnimSpeed = 3.3f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			grannysVarSpeed = 9.55f;
			grannysAnimSpeed = 4.8f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			grannysVarSpeed = 12.6f;
			grannysAnimSpeed = 6.8f;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().obstacleAvoidanceType = (ObstacleAvoidanceType)4;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().avoidancePriority = 0;
			speed = 15f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			GameObject.Find("Bip01 Head").AddComponent<Rigidbody>().isKinematic = true;
			GrannyTrainingStop = false;
			grannysVarSpeed = 20f;
			grannysAnimSpeed = 8.6f;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().obstacleAvoidanceType = (ObstacleAvoidanceType)4;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().avoidancePriority = 0;
			NavMeshAgent component = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component.acceleration *= 3f;
			speed = 25f;
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 1)
			{
				WalkSpeed = 9.55f;
				WalkAnim = 4.8f;
				target = Player.transform;
			}
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 3)
			{
				grannysVarSpeed *= 1.25f;
				grannysAnimSpeed *= 1.25f;
				WalkSpeed *= 1.25f;
				WalkAnim *= 1.25f;
				NavMeshAgent component2 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
				component2.acceleration *= 1.25f;
				NavMeshAgent component3 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
				component3.angularSpeed *= 1.25f;
			}
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 4)
			{
				((Component)this).gameObject.GetComponent<SphereCollider>().center = new Vector3(0f, 2f, 0f);
				((Component)this).gameObject.GetComponent<SphereCollider>().radius = 0.01f;
			}
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 15)
			{
				AnomalyTimer = 30f;
				target = Player.transform;
			}
			if (PlayerPrefs.GetInt("PrimeOn") == 0)
			{
				TrainingWalkSpeed = WalkSpeed;
				TrainingWalkAnim = WalkAnim;
				TrainingRunSpeed = grannysVarSpeed;
				TrainingRunAnim = grannysAnimSpeed;
			}
		}
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			grannysVarSpeed = 40f;
			grannysAnimSpeed = 25.2f;
			WalkSpeed = 20f;
			WalkAnim = 12.6f;
			NavMeshAgent component4 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component4.acceleration *= 9f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 1)
		{
			grannysVarSpeed *= 1.5f;
			grannysAnimSpeed *= 1.5f;
			WalkSpeed *= 1.5f;
			WalkAnim *= 1.5f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 3)
		{
			grannysVarSpeed *= 2f;
			grannysAnimSpeed *= 2f;
			WalkSpeed *= 2f;
			WalkAnim *= 2f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 13)
		{
			grannysVarSpeed *= 1.25f;
			grannysAnimSpeed *= 1.25f;
			WalkSpeed *= 1.25f;
			WalkAnim *= 1.25f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 15)
		{
			AnomalyTimer = 30f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 17 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 17)
		{
			Anomaly17Trap = Object.Instantiate<GameObject>(bearTrap, new Vector3(-5.34f, -200.09f, 4.07f), Quaternion.Euler(0f, 90f, 0f));
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				((Renderer)((Component)Anomaly17Trap.transform.GetChild(0)).GetComponent<MeshRenderer>()).material.color = Color.red;
				((Renderer)((Component)Anomaly17Trap.transform.GetChild(1)).GetComponent<MeshRenderer>()).material.color = Color.red;
				((Renderer)((Component)Anomaly17Trap.transform.GetChild(2)).GetComponent<MeshRenderer>()).material.color = Color.red;
			}
			Anomaly17Trap.transform.localScale = new Vector3(1.11f, 1.11f, 1.11f);
			Anomaly17Trap.GetComponent<Rigidbody>().isKinematic = true;
			((Object)Anomaly17Trap).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-5.398f, 20.09f, 7.81f), Quaternion.Euler(0f, 90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-13.86f, 20.09f, -10.338f), Quaternion.Euler(0f, -38.33f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-8.897f, 26.891f, 3.34f), Quaternion.Euler(0f, 0f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(7.537f, 26.963f, 12.07f), Quaternion.Euler(0f, -90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(14.88f, 20.09f, 4.44f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-16.359f, 20.09f, -20.296f), Quaternion.Euler(0f, -53.33f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(15.21f, 13.29f, 5.626f), Quaternion.Euler(0f, -90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-9.45f, 13.29f, 9.15f), Quaternion.Euler(0f, -90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-12.37f, 13.29f, 5.78f), Quaternion.Euler(0f, -117.6f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-16.4f, 13.29f, 3.73f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(16.273f, 13.29f, -3.92f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(12.55f, 11.843f, -16.571f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(5.178f, 7.513f, -6.559f), Quaternion.Euler(0f, 0f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-2.065f, 1.635f, 8.84f), Quaternion.Euler(0f, 90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(0.91f, 1.637f, 4.243f), Quaternion.Euler(0f, 148.3f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(4.12f, 7.518f, 2.91f), Quaternion.Euler(0f, 148.3f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-7.347f, 7.518f, -30.69f), Quaternion.Euler(0f, -27.3f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-2.49f, 33.471f, -2.95f), Quaternion.Euler(0f, 0f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(5.75f, 1.64f, -3.82f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(3.531f, 17.425f, -23.35f), Quaternion.Euler(0f, 0f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-1.57f, 12.368f, -33.22f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(30.82f, 11.86f, -12.012f), Quaternion.Euler(0f, 180f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(6.48f, 13.36f, -10.11f), Quaternion.Euler(0f, -90f, 0f))).name = "BearTrapAnomaly17";
			((Object)Object.Instantiate<GameObject>(Anomaly17Trap, new Vector3(-5.275f, 7.502f, -16.31f), Quaternion.Euler(0f, -90f, 0f))).name = "BearTrapAnomaly17";
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 18)
		{
			((Component)nav11).transform.localPosition = new Vector3(-54.01f, -15.03f, 67.59f);
			((Component)nav12).transform.localPosition = new Vector3(-54.01f, -15.03f, 67.59f);
			((Component)nav13).transform.localPosition = new Vector3(-41.55f, -9.02f, 62.45f);
			((Component)nav14).transform.localPosition = new Vector3(-71.95f, -2.33f, 62.16f);
			((Component)nav15).transform.localPosition = new Vector3(-71.95f, -2.33f, 62.16f);
			((Component)nav16).transform.localPosition = new Vector3(-57.622f, -9.08f, 65.79f);
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 22)
		{
			grannysVarSpeed *= 2f;
			grannysAnimSpeed *= 2f;
			WalkSpeed *= 2f;
			WalkAnim *= 2f;
			NavMeshAgent component5 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component5.acceleration *= 0.5f;
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				NavMeshAgent component6 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
				component6.acceleration *= 0.25f;
			}
			if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				NavMeshAgent component7 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
				component7.acceleration *= 0.15f;
			}
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24)
		{
			Anomaly24Kef = 1f;
			StartMoveSpeed = grannysVarSpeed;
			StartMoveAnim = grannysAnimSpeed;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 2525)
		{
			Anomaly25Granny = GameObject.Find("Granny");
			Anomaly25Leg1 = GameObject.Find("GrannyLleg2");
			Anomaly25Leg2 = GameObject.Find("GrannyRleg2");
			Anomaly25Bat = GameObject.Find("BatBloody");
			Anomaly25Tooth = GameObject.Find("Tand");
			Anomaly25Eyes = GameObject.Find("Eyes");
			Anomaly25Hair = GameObject.Find("Hair");
			((Renderer)Anomaly25Granny.GetComponent<SkinnedMeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Leg1.GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Leg2.GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Bat.GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Tooth.GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Eyes.GetComponent<MeshRenderer>()).enabled = false;
			((Renderer)Anomaly25Hair.GetComponent<MeshRenderer>()).enabled = false;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 28)
		{
			GrannyCloneAnomaly28 = ((Component)Object.Instantiate<Transform>(grannyFreezedoll, new Vector3(100f, 50f, 100f), ((Component)this).transform.rotation)).gameObject;
			((Behaviour)((Component)GrannyCloneAnomaly28.transform.GetChild(0)).GetComponent<GrannyBreak>()).enabled = false;
			((Collider)((Component)GrannyCloneAnomaly28.transform.GetChild(0)).GetComponent<MeshCollider>()).enabled = false;
			((Collider)((Component)GrannyCloneAnomaly28.transform.GetChild(0)).GetComponent<BoxCollider>()).enabled = false;
			((Component)GrannyCloneAnomaly28.transform.GetChild(0)).GetComponent<Rigidbody>().isKinematic = true;
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(0)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(1)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(2)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Collider)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(2)).GetComponent<MeshCollider>()).enabled = false;
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(3)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Collider)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(3)).GetComponent<MeshCollider>()).enabled = false;
			((Renderer)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(3).GetChild(0)).GetComponent<MeshRenderer>()).material.color = new Color(1f, 0f, 0.78f);
			((Collider)((Component)GrannyCloneAnomaly28.transform.GetChild(0).GetChild(3).GetChild(0)
				.GetChild(0)).GetComponent<BoxCollider>()).enabled = false;
			AnomalyTimer = 30f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 31 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 38)
		{
			grannysVarSpeed *= 1.75f;
			grannysAnimSpeed *= 1.75f;
			WalkSpeed *= 1.75f;
			WalkAnim *= 1.75f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 32)
		{
			grannysVarSpeed *= 5f;
			grannysAnimSpeed *= 5f;
			WalkSpeed *= 5f;
			WalkAnim *= 5f;
			NavMeshAgent component8 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component8.acceleration *= 100f;
			((Collider)((Component)this).gameObject.GetComponent<SphereCollider>()).enabled = false;
			((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = false;
			grannyLock.SetActive(true);
			grannyCloseTrigger.SetActive(true);
			grannyCloseTrigger.GetComponent<SphereCollider>().radius = 0.7f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 36)
		{
			((Component)this).gameObject.GetComponent<SphereCollider>().center = new Vector3(0f, 2f, 0f);
			((Component)this).gameObject.GetComponent<SphereCollider>().radius = 0.01f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 37)
		{
			((Collider)((Component)this).gameObject.GetComponent<SphereCollider>()).enabled = false;
			((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = false;
			grannyLock.SetActive(true);
			grannyCloseTrigger.SetActive(true);
			grannyCloseTrigger.GetComponent<SphereCollider>().radius = 0.7f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 50)
		{
			grannysVarSpeed *= 2f;
			grannysAnimSpeed *= 2f;
			WalkSpeed *= 2f;
			WalkAnim *= 2f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 96)
		{
			grannysVarSpeed = 1000f;
			grannysAnimSpeed = 1000f;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().acceleration = 1f;
		}
	}

	public virtual void FixedUpdate()
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_3261: Unknown result type (might be due to invalid IL or missing references)
		//IL_326c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3271: Unknown result type (might be due to invalid IL or missing references)
		//IL_3276: Unknown result type (might be due to invalid IL or missing references)
		//IL_328c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3291: Unknown result type (might be due to invalid IL or missing references)
		//IL_329a: Unknown result type (might be due to invalid IL or missing references)
		//IL_329f: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2796: Unknown result type (might be due to invalid IL or missing references)
		//IL_27a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_160e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1613: Unknown result type (might be due to invalid IL or missing references)
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Unknown result type (might be due to invalid IL or missing references)
		//IL_162a: Unknown result type (might be due to invalid IL or missing references)
		//IL_163b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1640: Unknown result type (might be due to invalid IL or missing references)
		//IL_27c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_27cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2728: Unknown result type (might be due to invalid IL or missing references)
		//IL_272d: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1754: Unknown result type (might be due to invalid IL or missing references)
		//IL_19bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_189d: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1827: Unknown result type (might be due to invalid IL or missing references)
		//IL_182c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2065: Unknown result type (might be due to invalid IL or missing references)
		//IL_206a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2124: Unknown result type (might be due to invalid IL or missing references)
		//IL_2129: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ace: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2546: Unknown result type (might be due to invalid IL or missing references)
		//IL_254b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2309: Unknown result type (might be due to invalid IL or missing references)
		//IL_230e: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2180: Unknown result type (might be due to invalid IL or missing references)
		//IL_2185: Unknown result type (might be due to invalid IL or missing references)
		//IL_2361: Unknown result type (might be due to invalid IL or missing references)
		//IL_2366: Unknown result type (might be due to invalid IL or missing references)
		//IL_2436: Unknown result type (might be due to invalid IL or missing references)
		//IL_243b: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("PrimeOn") == 0 && !PrimeNowIsOn)
		{
			attackDistance = 0f;
			if (GrannyTrainingStop)
			{
				grannysVarSpeed = 0f;
				grannysAnimSpeed = 0f;
				WalkSpeed = 0f;
				WalkAnim = 0f;
			}
			else
			{
				grannysVarSpeed = TrainingRunSpeed;
				grannysAnimSpeed = TrainingRunAnim;
				WalkSpeed = TrainingWalkSpeed;
				WalkAnim = TrainingWalkAnim;
			}
		}
		if (PlayerPrefs.GetInt("PrimeOn") == 0 && PrimeNowIsOn)
		{
			grannysVarSpeed = 20f;
			grannysAnimSpeed = 12.6f;
			WalkSpeed = 1.2f;
			WalkAnim = 0.9f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 15 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 15)
		{
			grannyHearPlayer = false;
			grannyHearObject = false;
			WalkSpeed = grannysVarSpeed;
			WalkAnim = grannysAnimSpeed;
		}
		if ((((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 15 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 15) && Time.timeSinceLevelLoad > AnomalyTimer)
		{
			newNav();
			AnomalyTimer += 30f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 22 || PlayerPrefs.GetInt("DiffData") == -1)
		{
			attackDistance = 3f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 26 && RatBiteCount == 5)
		{
			RatBiteCount = 0;
			AchievementSaveManager.Instance.UnlockAchievement("GrannyTheUnbreakable");
			((MonoBehaviour)this).StartCoroutine(Anomaly26GrannyAbility());
		}
		if (grannyAbility)
		{
			attackDistance = 10f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 28 && Time.timeSinceLevelLoad > AnomalyTimer)
		{
			if (!SetClone)
			{
				CurrentClone = Object.Instantiate<GameObject>(GrannyCloneAnomaly28, ((Component)this).transform.position, ((Component)this).transform.rotation);
				SetClone = true;
			}
			AnomalyTimer += 30f;
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 32 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 37)
		{
			((Collider)((Component)this).gameObject.GetComponent<SphereCollider>()).enabled = false;
			((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = false;
			grannyLock.SetActive(true);
			grannyCloseTrigger.SetActive(true);
			grannyCloseTrigger.GetComponent<SphereCollider>().radius = 0.7f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && Player.activeSelf)
		{
			nav1 = Player.transform;
			nav2 = Player.transform;
			nav3 = Player.transform;
			nav4 = Player.transform;
			nav5 = Player.transform;
			nav6 = Player.transform;
			nav7 = Player.transform;
			nav8 = Player.transform;
			nav9 = Player.transform;
			nav10 = Player.transform;
			nav11 = Player.transform;
			nav12 = Player.transform;
			nav13 = Player.transform;
			nav14 = Player.transform;
			nav15 = Player.transform;
			nav16 = Player.transform;
		}
		RaycastHit val = default;
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			if (playerHaveTeddy && !freeze)
			{
				grannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.2264151f, 0f, 0f);
				grannyEyeColorTimerOn = true;
				grannyEyeColorTimer = 0f;
				((fadeUpDownTeddyMusic)(object)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).startFade = true;
			}
			else if (grannyEyeColorTimerOn)
			{
				grannyEyeColorTimer += Time.deltaTime;
				if (grannyEyeColorTimer > 7f)
				{
					grannyEyeColorTimerOn = false;
					grannyEyeColorTimer = 0f;
					grannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(150f / 255f, 150f / 255f, 150f / 255f);
					((fadeUpDownTeddyMusic)(object)teddyMusicHolder.GetComponent(typeof(fadeUpDownTeddyMusic))).startFade = false;
				}
			}
		}
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			int num = 0;
			Quaternion rotation = ((Component)this).transform.rotation;
			rotation.x = num;
			((Component)this).transform.rotation = rotation;
			if (Object.op_Implicit((Object)(object)target))
			{
				distanceWaypoint = Vector3.Distance(target.position, ((Component)this).transform.position);
			}
			distance = Vector3.Distance(playerPos.position, ((Component)grannyEye).transform.position);
		}
		if (playerGetCaught && playerFallDeath)
		{
			navComponent.speed = 0f;
			animationHolder.GetComponent<Animation>().CrossFade("idle");
		}
		if (!playerGetCaught)
		{
			if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && (Object)(object)target == (Object)null)
			{
				target = nav1;
			}
			if (!grannyIsFollow && !grannyLookUnderBed && !playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				safeTimer += Time.deltaTime;
				if (safeTimer >= 80f)
				{
					safeTimer = 0f;
					if (((Object)target).name != "Player")
					{
						grannyHearObject = false;
						grannyHearPlayer = false;
						number = Random.Range(1, 33);
						newNav();
					}
				}
			}
			if (!playerGetCaught)
			{
				if (hitByArrow)
				{
					((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						((Component)this).gameObject.tag = "Untagged";
						animationHolder.GetComponent<Animation>().CrossFade("arrowHit");
						animationHolder.GetComponent<Animation>()["arrowHit"].speed = 0.8f;
						((MonoBehaviour)this).StartCoroutine(grannyHitByArrow());
						huntPlayer = false;
					}
				}
				else if (hitByGun)
				{
					((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						grannyHitByGun();
						huntPlayer = false;
					}
				}
				else if (hitByCar)
				{
					((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						((Component)this).gameObject.tag = "Untagged";
						grannyHitByCar();
						huntPlayer = false;
					}
				}
				else if (freeze)
				{
					((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
					if (!ragdollSpawn)
					{
						ragdollSpawn = true;
						navComponent.speed = 0f;
						((Component)this).gameObject.tag = "Untagged";
						animationHolder.GetComponent<Animation>().CrossFade("freezeTrap");
						animationHolder.GetComponent<Animation>()["freezeTrap"].speed = 1f;
						((MonoBehaviour)this).StartCoroutine(grannyFreeze());
						huntPlayer = false;
					}
				}
			}
			if (navComponent.velocity != Vector3.zero)
			{
				if (!grannyLookUnderBed && !playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					stopWalk = false;
					GrannyMoving = true;
					if (!startWalk)
					{
						if (!grannyIsFollow)
						{
							if (!grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor && !droppingBeartrap)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Walk");
								animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
								navComponent.speed = WalkSpeed;
							}
						}
						else if (seePlayer)
						{
							animationHolder.GetComponent<Animation>().CrossFade("Walk");
							animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
							navComponent.stoppingDistance = 2f;
						}
					}
				}
			}
			else if (navComponent.velocity == Vector3.zero && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !grannyLookUnderBed)
			{
				startWalk = false;
				GrannyMoving = false;
				if (!stopWalk)
				{
					stopWalk = true;
					if (!attackingPlayer && !GrannySearch && !huntPlayer)
					{
						if (grannyHearPlayer)
						{
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Look");
							}
						}
						else if (grannyHearObject)
						{
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("Look");
							}
						}
						else if (navComponent.velocity == Vector3.zero)
						{
							animationHolder.GetComponent<Animation>().CrossFade("idle");
						}
					}
				}
			}
			if (Object.op_Implicit((Object)(object)target) && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				navComponent.destination = target.position;
				if (!seePlayer && !grannyIsFollow && !GrannySearching)
				{
					if (prisondoorClosed)
					{
						if (waypointStart && !waypointStop)
						{
							waypointStart = false;
							waypointStop = true;
							timer = 0f;
							if (((Object)target).name == "TempNavObjects(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								timerSearch = 0f;
								((MonoBehaviour)this).StartCoroutine(cleaning());
							}
							if (((Object)target).name == "TempNav(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								timerSearch = 0f;
							}
						}
					}
					else if (distanceWaypoint < 5f)
					{
						if (waypointStart && !waypointStop)
						{
							waypointStart = false;
							waypointStop = true;
							timer = 0f;
							if (((Object)target).name == "TempNavObjects(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								timerSearch = 0f;
								((MonoBehaviour)this).StartCoroutine(cleaning());
							}
							if (((Object)target).name == "TempNav(Clone)")
							{
								startTimerSearch = true;
								GrannySearching = true;
								timerSearch = 0f;
							}
						}
					}
					else if (distanceWaypoint > 3f && !waypointStop)
					{
						waypointStart = true;
						waypointStop = false;
					}
				}
			}
			if (waypointStop && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !startTimerSearch && (!grannyHearObject || !grannyHearPlayer))
			{
				timer += Time.deltaTime;
			}
			if (timer >= 10f && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				waypointStop = false;
				waypointStart = true;
				timer = 0f;
				if (!grannyIsFollow)
				{
					number = Random.Range(1, 33);
					if (!grannyHearPlayer || !grannyHearObject)
					{
						newNav();
					}
				}
			}
			if (seePlayer)
			{
				if (!grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					grannyHearPlayer = false;
					grannyHearObject = false;
					timerSee = 0f;
					safeTimer = 0f;
					if (!huntPlayer)
					{
						huntPlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
						}
						if (!grannyIsFollow)
						{
							grannyIsFollow = true;
							followPlayer();
						}
					}
				}
			}
			else if (playerHaveTeddy)
			{
				if (PlayerPrefs.GetInt("DiffData") != 4 && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
				{
					grannyHearPlayer = false;
					grannyHearObject = false;
					timerSee = 0f;
					safeTimer = 0f;
					if (!huntPlayer)
					{
						huntPlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
						}
						if (!grannyIsFollow)
						{
							grannyIsFollow = true;
							followPlayer();
						}
					}
				}
			}
			else if (playerStartCar && PlayerPrefs.GetInt("DiffData") != 4 && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				grannyHearPlayer = false;
				grannyHearObject = false;
				timerSee = 0f;
				safeTimer = 0f;
				seePlayer = true;
				if (!huntPlayer)
				{
					huntPlayer = true;
					if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
					{
						((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
					}
					if (!grannyIsFollow)
					{
						grannyIsFollow = true;
						followPlayer();
					}
				}
			}
			if (grannyIsFollow && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				if (!seePlayer)
				{
					seePlayerTimer = true;
				}
				else
				{
					seePlayerTimer = false;
					timerSee = 0f;
					safeTimer = 0f;
				}
			}
			if (seePlayerTimer && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				timerSee += Time.deltaTime;
				if (timerSee >= 6f)
				{
					seePlayerTimer = false;
					grannyIsFollow = false;
					huntPlayer = false;
					if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("DiffData") != 7)
					{
						((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = false;
					}
					timerSee = 0f;
					timerSearch = 0f;
					safeTimer = 0f;
					startTimerSearch = true;
					GrannySearching = true;
				}
			}
			if (startTimerSearch && !grannyLookUnderBed && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
			{
				if (GrannySearching)
				{
					navComponent.speed = 0f;
					if (!GrannySearch && navComponent.velocity == Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("Look");
					}
				}
				timerSearch += Time.deltaTime;
				if (timerSearch >= 8f || (PlayerPrefs.GetInt("DiffData") == 4 && timerSearch >= 0.5f))
				{
					if (navComponent.velocity != Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("Walk");
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
					animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
					grannyHearPlayer = false;
					grannyHearObject = false;
					timerSearch = 0f;
					if (!grannyIsFollow)
					{
						startTimerSearch = false;
						GrannySearching = false;
						GrannySearch = false;
						if (!grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
						{
							navComponent.speed = WalkSpeed;
						}
						number = Random.Range(1, 33);
						if (!grannyHearPlayer || !grannyHearObject)
						{
							newNav();
							waypointStop = false;
							waypointStart = true;
							timer = 0f;
							if (gameController.GetComponent<startNewDay>().AnomalyNR == 23 || gameController.GetComponent<startNewDay>().AnomalyNR == 28 || PlayerPrefs.GetInt("EventChallenge1") == 1)
							{
								((MonoBehaviour)this).StartCoroutine(dropBearTrap());
							}
							if (PlayerPrefs.GetInt("DiffData") != 4)
							{
								if (playerInPrison && prisondoorClosed)
								{
									((GrannySounds)(object)grannySounds.GetComponent(typeof(GrannySounds))).grannySkrattar();
								}
								else
								{
									((GrannySounds)(object)grannySounds.GetComponent(typeof(GrannySounds))).startGrannySound();
								}
							}
						}
					}
				}
			}
			if (PlayerPrefs.GetInt("DiffData") != 4)
			{
				Vector3 val2 = doorRay.transform.TransformDirection(Vector3.forward);
				doorRay.transform.TransformDirection(Vector3.down);
				if (Physics.Raycast(doorRay.transform.position, val2, ref val, 3f))
				{
					if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
					{
						Debug.DrawRay(doorRay.transform.position, ((Component)this).transform.forward, Color.green);
						if (((Component)val.collider).gameObject.tag == "innerdoorClosed")
						{
							grannySeeDoor = true;
							if (!seePlayer)
							{
								if (playerHaveTeddy)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else if (playerStartCar)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else
								{
									navComponent.speed = 0f;
								}
							}
							seeClosedDoorTimer += Time.deltaTime;
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
							}
							if (seeClosedDoorTimer >= 2f || (PlayerPrefs.GetInt("DiffData") == 6 && seeClosedDoorTimer >= 0.1f) || (PlayerPrefs.GetInt("DiffData") == 7 && seeClosedDoorTimer >= 0f) || (PlayerPrefs.GetInt("UltraFlashlight") == 1 && seeClosedDoorTimer >= 0.1f) || (Event2GrannySpeed > 4 && seeClosedDoorTimer >= 0.1f))
							{
								((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
								if (!grannyIsFollow)
								{
									navComponent.speed = WalkSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
								}
								else
								{
									navComponent.speed = grannysVarSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
								}
								seeClosedDoorTimer = 0f;
								safeDoorTimer = 0f;
							}
						}
						else if (((Component)val.collider).gameObject.tag == "innerdoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									if (playerHaveTeddy)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else if (playerStartCar)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else
									{
										navComponent.speed = 0f;
									}
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (seeClosedDoorTimer <= 2f)
								{
									((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
								}
								if (seeClosedDoorTimer >= 4f || (PlayerPrefs.GetInt("DiffData") == 6 && seeClosedDoorTimer >= 2f) || (PlayerPrefs.GetInt("DiffData") == 7 && seeClosedDoorTimer >= 0f) || (PlayerPrefs.GetInt("UltraFlashlight") == 1 && seeClosedDoorTimer >= 2f) || (Event2GrannySpeed > 4 && seeClosedDoorTimer >= 2f))
								{
									((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
									if (!grannyIsFollow)
									{
										navComponent.speed = WalkSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									seeClosedDoorTimer = 0f;
									safeDoorTimer = 0f;
								}
							}
						}
						else if (((Component)val.collider).gameObject.tag == "steeldoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									if (playerHaveTeddy)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else if (playerStartCar)
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									else
									{
										navComponent.speed = 0f;
									}
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (seeClosedDoorTimer <= 2f)
								{
									((Component)val.collider).gameObject.GetComponent<Animation>().Play("InnerdoorLocked");
								}
								if (seeClosedDoorTimer >= 4f)
								{
									if (!grannyIsFollow)
									{
										navComponent.speed = WalkSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
								}
							}
						}
						else if (((Component)val.collider).gameObject.tag == "bastudoorLocked")
						{
							if (!stopSeeLockedDoor)
							{
								grannySeeLockedDoor = true;
								seeClosedDoorTimer += Time.deltaTime;
								if (grannySeeLockedDoor && !seePlayer)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
									navComponent.speed = 0f;
								}
								if (navComponent.velocity == Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								if (seeClosedDoorTimer >= 4f)
								{
									if (!grannyIsFollow)
									{
										navComponent.speed = WalkSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
									}
									else
									{
										navComponent.speed = grannysVarSpeed;
										if (navComponent.velocity != Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("Walk");
										}
										else
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									if (grannySeeLockedDoor && seeClosedDoorTimer >= 10f)
									{
										grannySeeLockedDoor = false;
										stopSeeLockedDoor = false;
										seeClosedDoorTimer = 0f;
										grannyHearPlayer = false;
										grannyHearObject = false;
										number = Random.Range(1, 33);
										newNav();
									}
								}
							}
						}
						else if (((Component)val.collider).gameObject.tag == "smalldoorClosed")
						{
							grannySeeDoor = true;
							if (!seePlayer)
							{
								if (playerHaveTeddy)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else if (playerStartCar)
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								else
								{
									navComponent.speed = 0f;
								}
							}
							seeClosedDoorTimer += Time.deltaTime;
							if (navComponent.velocity == Vector3.zero)
							{
								animationHolder.GetComponent<Animation>().CrossFade("idle");
							}
							if (seeClosedDoorTimer >= 2f || (PlayerPrefs.GetInt("DiffData") == 6 && seeClosedDoorTimer >= 0.1f) || (PlayerPrefs.GetInt("DiffData") == 7 && seeClosedDoorTimer >= 0f) || (PlayerPrefs.GetInt("UltraFlashlight") == 1 && seeClosedDoorTimer >= 0.1f) || (Event2GrannySpeed > 4 && seeClosedDoorTimer >= 0.1f))
							{
								((Component)val.collider).gameObject.GetComponent<Animation>().Play("SmallDoorOpen");
								if (navComponent.velocity != Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("Walk");
								}
								else
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								if (!grannyIsFollow)
								{
									navComponent.speed = WalkSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
										animationHolder.GetComponent<Animation>()["Walk"].speed = 0.9f;
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
								}
								else
								{
									navComponent.speed = grannysVarSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
										animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
								}
								seeClosedDoorTimer = 0f;
								safeDoorTimer = 0f;
							}
						}
						else if (((Component)val.collider).gameObject.tag == "garde1Closed")
						{
							grannySeeDoor = true;
							if (PlayerPrefs.GetInt("DiffData") == 7)
							{
								((Component)val.collider).gameObject.GetComponent<Animation>().Play("Garde1Open");
							}
							if (grannyIsFollow)
							{
								if (!seePlayer)
								{
									if (playerHiding)
									{
										navComponent.speed = 0f;
										seeClosedDoorTimer += Time.deltaTime;
										if (navComponent.velocity == Vector3.zero)
										{
											animationHolder.GetComponent<Animation>().CrossFade("idle");
										}
										if (seeClosedDoorTimer >= 2f)
										{
											((Component)val.collider).gameObject.GetComponent<Animation>().Play("Garde1Open");
											if (navComponent.velocity != Vector3.zero)
											{
												animationHolder.GetComponent<Animation>().CrossFade("Walk");
											}
											else
											{
												animationHolder.GetComponent<Animation>().CrossFade("idle");
											}
											if (!grannyIsFollow)
											{
												navComponent.speed = WalkSpeed;
												if (navComponent.velocity != Vector3.zero)
												{
													animationHolder.GetComponent<Animation>().CrossFade("Walk");
													animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
												}
												else
												{
													animationHolder.GetComponent<Animation>().CrossFade("idle");
												}
											}
											else
											{
												navComponent.speed = grannysVarSpeed;
												if (navComponent.velocity != Vector3.zero)
												{
													animationHolder.GetComponent<Animation>().CrossFade("Walk");
													animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
												}
												else
												{
													animationHolder.GetComponent<Animation>().CrossFade("idle");
												}
											}
											seeClosedDoorTimer = 0f;
											safeDoorTimer = 0f;
										}
									}
									seePlayerTimer = true;
								}
								else
								{
									seePlayerTimer = false;
									timerSee = 0f;
									safeTimer = 0f;
								}
							}
						}
						else if (((Component)val.collider).gameObject.tag == "Untagged")
						{
							grannySeeDoor = false;
							grannySeeLockedDoor = false;
							stopSeeLockedDoor = false;
							if (seeClosedDoorTimer > 0f)
							{
								seeClosedDoorTimer = 0f;
								if (!grannyIsFollow)
								{
									navComponent.speed = WalkSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
								}
								else
								{
									navComponent.speed = grannysVarSpeed;
									if (navComponent.velocity != Vector3.zero)
									{
										animationHolder.GetComponent<Animation>().CrossFade("Walk");
									}
									else
									{
										animationHolder.GetComponent<Animation>().CrossFade("idle");
									}
									animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
								}
							}
						}
					}
				}
				else
				{
					grannySeeDoor = false;
					grannySeeLockedDoor = false;
					stopSeeLockedDoor = false;
					if (seeClosedDoorTimer > 0f)
					{
						seeClosedDoorTimer = 0f;
						if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
						{
							if (!grannyIsFollow)
							{
								navComponent.speed = WalkSpeed;
								if (navComponent.velocity != Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("Walk");
								}
								else
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
							}
							else
							{
								navComponent.speed = grannysVarSpeed;
								if (navComponent.velocity != Vector3.zero)
								{
									animationHolder.GetComponent<Animation>().CrossFade("Walk");
								}
								else
								{
									animationHolder.GetComponent<Animation>().CrossFade("idle");
								}
								animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
							}
						}
					}
				}
			}
			Vector3 val3 = new Vector3(0f, -1f, 0f);
			if (Physics.Raycast(checkGround.transform.position, val3, ref val, 5f))
			{
				Debug.DrawRay(checkGround.transform.position, val3, Color.yellow);
				if (((Object)((Component)val.collider).gameObject).name == "StairColliderC")
				{
					if (!seeStairs)
					{
						seeStairs = true;
						if (PlayerPrefs.GetInt("PrimeOn") != 0)
						{
							attackDistance = 4.5f;
						}
					}
				}
				else if (((Object)((Component)val.collider).gameObject).name == "Golv" && seeStairs)
				{
					seeStairs = false;
					attackDistance = 4f;
					((GrannyFootstep)(object)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = 0;
				}
				if (((Component)val.collider).gameObject.tag == "grus")
				{
					((GrannyFootstep)(object)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = 1;
				}
				if (((Component)val.collider).gameObject.tag == "golv")
				{
					((GrannyFootstep)(object)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = 0;
				}
				if (((Component)val.collider).gameObject.tag == "water")
				{
					((GrannyFootstep)(object)animationHolder.GetComponent(typeof(GrannyFootstep))).walkGrus = 2;
				}
			}
		}
		if (distance < attackDistance && seePlayer && !grannyLookUnderBed && !playerHidingInCoffin && !playerHidingInCoffinBackyard && !playerHidingInCar && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !playerInHole && !playerGetCaught)
		{
			playerGetCaught = true;
			attackingPlayer = true;
			((MonoBehaviour)this).StartCoroutine(Playercaught());
			((Component)this).transform.LookAt(playerPos);
		}
		if (!playerGetCaught && !hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			if (distanceWaypoint < 4f && playerHidingUnderBed && grannyIsFollow)
			{
				if (!grannyLookUnderBed && navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				navComponent.speed = 0f;
				facePlayerBed();
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingUnderBed && PlayerPrefs.GetInt("PrimeOn") == 1)
				{
					optionButton.SetActive(false);
					animationHolder.GetComponent<Animation>().CrossFade("lookBed");
					grannyLookUnderBed = true;
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(false);
					if (hidingUnderBed1)
					{
						((bedEyes)(object)bedCam1.GetComponent(typeof(bedEyes))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)(object)soundHolder1.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					if (hidingUnderBed2)
					{
						((bedEyes2)(object)bedCam2.GetComponent(typeof(bedEyes2))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)(object)soundHolder2.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					if (hidingUnderBed3)
					{
						((bedEyes3)(object)bedCam3.GetComponent(typeof(bedEyes3))).lookAtGranny = true;
						if (!soundPlaying)
						{
							soundPlaying = true;
							((soundEffectsBeds)(object)soundHolder3.GetComponent(typeof(soundEffectsBeds))).playerCaught();
						}
					}
					((MonoBehaviour)this).StartCoroutine(((playerCaughtUnderBed)(object)gameController.GetComponent(typeof(playerCaughtUnderBed))).EndDayUnderBed());
					soundPlaying = false;
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCoffin && grannyIsFollow && PlayerPrefs.GetInt("PrimeOn") == 1)
			{
				navComponent.speed = 0f;
				facePlayerBed();
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingInCoffin)
				{
					optionButton.SetActive(false);
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(false);
					((MonoBehaviour)this).StartCoroutine(Playercaught());
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCoffinBackyard && grannyIsFollow && PlayerPrefs.GetInt("PrimeOn") == 1)
			{
				navComponent.speed = 0f;
				facePlayerBed();
				if (navComponent.velocity != Vector3.zero)
				{
					animationHolder.GetComponent<Animation>().CrossFade("idle");
				}
				if (!grannyLookUnderBed)
				{
					timerBed += Time.deltaTime;
				}
				if (timerBed >= 3f && playerHidingInCoffinBackyard)
				{
					optionButton.SetActive(false);
					timerBed = 0f;
					safeTimer = 0f;
					allBedButtons.SetActive(false);
					((MonoBehaviour)this).StartCoroutine(Playercaught());
				}
			}
			else if (distanceWaypoint < 4f && playerHidingInCar && grannyIsFollow && grannyStandBesideCar && PlayerPrefs.GetInt("PrimeOn") == 1)
			{
				if (!((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).carMoving)
				{
					navComponent.speed = 0f;
					facePlayerBed();
					if (navComponent.velocity != Vector3.zero)
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
					if (!grannyLookUnderBed)
					{
						timerBed += Time.deltaTime;
					}
					if (timerBed >= 3f && playerHidingInCar)
					{
						optionButton.SetActive(false);
						timerBed = 0f;
						safeTimer = 0f;
						allBedButtons.SetActive(false);
						startCarButton.SetActive(false);
						forwardButton.SetActive(false);
						reverseButton.SetActive(false);
						((MonoBehaviour)this).StartCoroutine(Playercaught());
					}
				}
			}
			else if (!playerHidingUnderBed && !playerHidingInCoffin && !playerHidingInCoffinBackyard && !playerHidingInCar && grannyIsFollow)
			{
				followPlayer();
			}
			if (grannyHearPlayer && !seePlayer && !grannyIsFollow)
			{
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNav(Clone)Old")))
				{
					target = GameObject.Find("TempNav(Clone)").transform;
				}
				else
				{
					target = GameObject.Find("TempNav(Clone)").transform;
				}
				if (!grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
				{
					navComponent.speed = grannysVarSpeed;
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
				grannyHearObject = false;
				droppingBeartrap = false;
			}
			if (grannyHearObject && !seePlayer && !grannyIsFollow)
			{
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
					{
						target = GameObject.Find("TempNavObjects(Clone)").transform;
					}
					else
					{
						target = nav1;
					}
				}
				else
				{
					target = GameObject.Find("TempNavObjects(Clone)").transform;
				}
				if (!grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
				{
					navComponent.speed = grannysVarSpeed;
				}
				animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
				grannyHearPlayer = false;
				droppingBeartrap = false;
				if (!resetSafeTimer)
				{
					resetSafeTimer = true;
					safeTimer = 0f;
				}
			}
			if (playerHidingUnderBed && seePlayer && grannyIsFollow)
			{
				if (hidingUnderBed1)
				{
					target = bedtargetTemp1;
				}
				if (hidingUnderBed2)
				{
					target = bedtargetTemp2;
				}
				if (hidingUnderBed3)
				{
					target = bedtargetTemp3;
				}
				seePlayer = false;
				navComponent.stoppingDistance = 2f;
				droppingBeartrap = false;
			}
			else if (playerHidingInCoffin && seePlayer && grannyIsFollow)
			{
				target = coffintargetTemp4;
			}
			else if (playerHidingInCoffinBackyard && seePlayer && grannyIsFollow)
			{
				target = coffintargetTempBY;
			}
			else if (playerHidingInCar && seePlayer && grannyIsFollow)
			{
				target = cartargetTemp;
			}
			GrannyDecisions();
		}
		if (playerNearGranny && !playerGetCaught && !playerHiding && !grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
		{
			Vector3 val4 = playerPos.position - ((Component)this).transform.position;
			float num2 = speed * Time.deltaTime;
			Vector3 val5 = Vector3.RotateTowards(((Component)this).transform.forward, val4, num2, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val5);
		}
		if (grannyInBastu && bastuswitchOn && bastuBomNere && !freeze)
		{
			bastuTimer -= Time.deltaTime;
			bastuDoorTimer -= Time.deltaTime;
			if (bastuTimer <= 0f)
			{
				grannyInBastu = false;
				bastuKilled = true;
				((MonoBehaviour)this).StartCoroutine(grannyHitByArrow());
			}
			if (!bastuTimeOff && bastuDoorTimer <= 0f)
			{
				bastuTimeOff = true;
				bastuDoor.gameObject.tag = "innerdoorLocked";
				bastuDoorCarv.carving = !((Behaviour)this).enabled;
			}
		}
		if (grannyInBastu && !bastuswitchOn && bastuBomNere && !freeze)
		{
			if (!bastuTimeOff)
			{
				bastuDoorTimer -= Time.deltaTime;
				if (bastuDoorTimer <= 0f)
				{
					bastuTimeOff = true;
					bastuDoor.gameObject.tag = "innerdoorLocked";
					bastuDoorCarv.carving = !((Behaviour)this).enabled;
					StartbastuSafeTimer = true;
				}
			}
			if (StartbastuSafeTimer)
			{
				bastuSafeTimer += Time.deltaTime;
				if (bastuSafeTimer >= 30f)
				{
					StartbastuSafeTimer = false;
					bastuDoor.gameObject.GetComponent<Animation>().Play("InnerdoorOpen");
				}
			}
		}
		if (grannyInBastu && !bastuswitchOn && !bastuBomNere)
		{
			bastuDoorTimer = 20f;
		}
		if (hitByPepper && !playerGetCaught)
		{
			huntPlayer = false;
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = false;
			}
			grannyLock.SetActive(true);
			seePlayer = false;
			grannyIsFollow = false;
			playerNearGranny = false;
			((Component)this).gameObject.GetComponent<Collider>().enabled = false;
			((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = false;
			blindTimer -= Time.deltaTime;
			if (blindTimer < 0f)
			{
				((Component)this).gameObject.GetComponent<Collider>().enabled = true;
				((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = true;
				grannyCloseTrigger.SetActive(false);
				grannyLock.SetActive(false);
				hitByPepper = false;
				blindTimer = 30f;
				grannyPepperReact = false;
			}
			if (!grannyPepperReact)
			{
				grannyPepperReact = true;
				grannyHitByPepper();
			}
		}
		else if (playerGetCaught && hitByPepper)
		{
			grannyLock.SetActive(false);
			((Component)this).gameObject.GetComponent<Collider>().enabled = true;
			((Behaviour)(EnemyEye)(object)((Component)grannyEye).GetComponent(typeof(EnemyEye))).enabled = true;
			blindTimer = 30f;
		}
		if (hitByPepperStart && !animationHolder.GetComponent<Animation>().IsPlaying("pepperHit") && !animationHolder.GetComponent<Animation>().IsPlaying("pepperHit"))
		{
			hitByPepperStart = false;
			pepperAnimDone();
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 22 || PlayerPrefs.GetInt("DiffData") == -1)
		{
			attackDistance = 3f;
		}
		if (grannyAbility)
		{
			attackDistance = 10f;
		}
		if (PlayerPrefs.GetInt("PrimeOn") == 0 && !PrimeNowIsOn)
		{
			attackDistance = 0f;
			if (GrannyTrainingStop)
			{
				grannysVarSpeed = 0f;
				grannysAnimSpeed = 0f;
				WalkSpeed = 0f;
				WalkAnim = 0f;
			}
			else
			{
				grannysVarSpeed = 20f;
				grannysAnimSpeed = 12.6f;
				WalkSpeed = 1.2f;
				WalkAnim = 0.9f;
			}
		}
		if (PlayerPrefs.GetInt("PrimeOn") == 0 && PrimeNowIsOn)
		{
			grannysVarSpeed = 20f;
			grannysAnimSpeed = 12.6f;
			WalkSpeed = 1.2f;
			WalkAnim = 0.9f;
		}
	}

	public virtual void grannyHitByPepper()
	{
		navComponent.speed = 0f;
		animationHolder.GetComponent<Animation>().CrossFade("pepperHit");
	}

	public virtual void pepperAnimDone()
	{
		newNav();
	}

	public virtual IEnumerator grannyHitByArrow()
	{
		yield return (object)new WaitForSeconds(3f);
		if (!((playerDead)(object)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			Object.Instantiate<Transform>(grannyRagdoll, ((Component)this).transform.position, ((Component)this).transform.rotation);
			grannyDisaper.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 minute");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 2 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 3 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				PickUpScript.ShowText3("Granny is now gone for about 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				PickUpScript.ShowText3("Granny is now gone for about 15 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				PickUpScript.ShowText3("Granny is now gone for about 7.5 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 second");
			}
		}
	}

	public virtual void grannyHitByCar()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (!((playerDead)(object)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			Object.Instantiate<Transform>(grannyRagdoll, ((Component)this).transform.position, ((Component)this).transform.rotation);
			grannyDisaper.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 minute");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 2 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 3 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				PickUpScript.ShowText3("Granny is now gone for about 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				PickUpScript.ShowText3("Granny is now gone for about 15 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				PickUpScript.ShowText3("Granny is now gone for about 7.5 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 second");
			}
		}
	}

	public virtual void grannyHitByGun()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (!((playerDead)(object)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			Object.Instantiate<Transform>(grannyForceRagdoll, ((Component)this).transform.position, ((Component)this).transform.rotation);
			grannyDisaper.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 minute and 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 2 minutes and 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 3 minutes and 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 minute");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				PickUpScript.ShowText3("Granny is now gone for about 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				PickUpScript.ShowText3("Granny is now gone for about 15 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				PickUpScript.ShowText3("Granny is now gone for about 5 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				PickUpScript.ShowText3("This book is too strong... Granny is now gone for about 20 seconds");
			}
		}
	}

	public virtual IEnumerator grannyFreeze()
	{
		yield return (object)new WaitForSeconds(2.5f);
		if (!((playerDead)(object)gameController.GetComponent(typeof(playerDead))).endSceneRunning)
		{
			Object.Instantiate<Transform>(grannyFreezedoll, ((Component)this).transform.position, ((Component)this).transform.rotation);
			grannyDisaper.SetActive(false);
			if (PlayerPrefs.GetInt("EventChallenge1") == 1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 15 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 minute");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 2 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				PickUpScript.ShowText3("Granny is now gone for about 3 minutes");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 2)
			{
				PickUpScript.ShowText3("Granny is now gone for about 30 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 3)
			{
				PickUpScript.ShowText3("Granny is now gone for about 15 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 5)
			{
				PickUpScript.ShowText3("Granny is now gone for about 7.5 seconds");
			}
			else if (PlayerPrefs.GetInt("DiffData") == 6)
			{
				PickUpScript.ShowText3("Granny is now gone for about 1 second");
			}
		}
	}

	public virtual IEnumerator dropBearTrap()
	{
		yield return (object)new WaitForSeconds(10f);
		if (!grannyIsFollow && !hitByArrow && !hitByGun && !grannyInBastu && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			navComponent.speed = 0f;
			droppingBeartrap = true;
			yield return (object)new WaitForSeconds(1f);
			if (gameController.GetComponent<startNewDay>().AnomalyNR == 23)
			{
				Object.Instantiate<GameObject>(gameController.GetComponent<startNewDay>().Anomaly23creack, bearTrapSP.position, bearTrapSP.rotation);
			}
			else if (gameController.GetComponent<startNewDay>().AnomalyNR == 28 && Random.Range(1, 5) == 1)
			{
				Anomaly28TeleportToClone();
			}
			yield return (object)new WaitForSeconds(1f);
			droppingBeartrap = false;
			navComponent.speed = WalkSpeed;
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			else
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && ((Component)other).gameObject.tag == "Player" && !playerHiding)
		{
			playerNearGranny = true;
			target = player;
			GrannyGonnaSmack = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			GrannyGonnaSmack = false;
		}
	}

	public virtual void GrannyDecisions()
	{
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze)
		{
			return;
		}
		if (grannyIsFollow)
		{
			if (distance < 4f)
			{
				facePlayer();
			}
			else if (distance > 6f)
			{
				playerNearGranny = false;
			}
		}
		else if (distance > 6f && (Object)(object)target != (Object)(object)player && !GrannyGonnaSmack)
		{
			playerNearGranny = false;
		}
	}

	public virtual void facePlayer()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze && !grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
		{
			Vector3 val = target.position - ((Component)this).transform.position;
			float num = speed * Time.deltaTime;
			Vector3 val2 = Vector3.RotateTowards(((Component)this).transform.forward, val, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val2);
		}
	}

	public virtual void facePlayerBed()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		float num = speed * Time.deltaTime;
		if (hidingUnderBed1)
		{
			Vector3 val = bedtargetTemp1.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(bedtargetTemp1);
			Vector3 val2 = Vector3.RotateTowards(((Component)this).transform.forward, val, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val2);
		}
		if (hidingUnderBed2)
		{
			Vector3 val3 = bedtargetTemp2.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(bedtargetTemp2);
			Vector3 val4 = Vector3.RotateTowards(((Component)this).transform.forward, val3, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val4);
		}
		if (hidingUnderBed3)
		{
			Vector3 val5 = bedtargetTemp3.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(bedtargetTemp3);
			Vector3 val6 = Vector3.RotateTowards(((Component)this).transform.forward, val5, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val6);
		}
		if (hidingInCoffin4)
		{
			Vector3 val7 = coffintargetTemp4.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(coffintargetTemp4);
			Vector3 val8 = Vector3.RotateTowards(((Component)this).transform.forward, val7, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val8);
		}
		if (hidingInCoffinBY)
		{
			Vector3 val9 = coffintargetTempBY.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(coffintargetTempBY);
			Vector3 val10 = Vector3.RotateTowards(((Component)this).transform.forward, val9, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val10);
		}
		if (hidingInCar)
		{
			Vector3 val11 = cartargetTemp.position - ((Component)this).transform.position;
			((Component)this).transform.LookAt(cartargetTemp);
			Vector3 val12 = Vector3.RotateTowards(((Component)this).transform.forward, val11, num, 0f);
			((Component)this).transform.rotation = Quaternion.LookRotation(val12);
		}
	}

	public virtual IEnumerator Playercaught()
	{
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze || playerInHole)
		{
			yield break;
		}
		if (playerCaughtLastTime)
		{
			if (!playerHidingUnderBed)
			{
				if (playerHidingInCoffin)
				{
					((Component)player).transform.position = PlayerCoffinPos.position;
					Player.SetActive(true);
					coffinHead1.SetActive(false);
					coffinLock.transform.localEulerAngles = new Vector3(-153.846f, 0f, 0f);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						yield return (object)new WaitForSeconds(0.6f);
						yield return (object)new WaitForSeconds(0.3f);
						((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else if (playerHidingInCoffinBackyard)
				{
					((Component)player).transform.position = PlayerCoffinBYPos.position;
					Player.SetActive(true);
					coffinHead2.SetActive(false);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						yield return (object)new WaitForSeconds(0.6f);
						yield return (object)new WaitForSeconds(0.3f);
						((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else if (playerHidingInCar)
				{
					((Component)player).transform.position = PlayerCarPos.position;
					Player.SetActive(true);
					carHead.SetActive(false);
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						((soundEffects)(object)playerSounds.GetComponent(typeof(soundEffects))).CarOut();
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						playerStartCar = false;
						engineOnSound.SetActive(false);
						engineOffSound.SetActive(true);
						engineStartSound.SetActive(false);
						grannyStandBesideCar = false;
						ObjectHolder.SetActive(true);
						yield return (object)new WaitForSeconds(0.6f);
						yield return (object)new WaitForSeconds(0.3f);
						((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
						GrannyGonnaSmack = false;
						engineOffSound.SetActive(false);
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
				else
				{
					playerNearGranny = false;
					GrannyGonnaSmack = false;
					navComponent.speed = 0f;
					if (!dontHitPlayer)
					{
						((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
						playerHukaKnappParent.SetActive(false);
						animationHolder.GetComponent<Animation>().CrossFade("Hit");
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).startFOV = true;
						((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
						if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
						{
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannySmackPlayer = true;
							((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).playerCaught = true;
						}
						if (Spider.activeSelf)
						{
							((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).grannyCaughtPlayer();
						}
						yield return (object)new WaitForSeconds(0.6f);
						((soundEffects)(object)playerSounds.GetComponent(typeof(soundEffects))).playerGetHit();
						yield return (object)new WaitForSeconds(0.3f);
						((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
					}
					else
					{
						animationHolder.GetComponent<Animation>().CrossFade("idle");
					}
				}
			}
		}
		else if (!playerHidingUnderBed)
		{
			((playerCrawl)(object)playerHukaKnapp.GetComponent(typeof(playerCrawl))).standUp();
			playerHukaKnappParent.SetActive(false);
			if (navComponent.velocity == Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
			((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).startFOV = true;
			((playerCaught)(object)((Component)player).GetComponent(typeof(playerCaught))).grannyTakePlayer = true;
			GrannyGonnaSmack = false;
		}
		navComponent.speed = 0f;
	}

	public virtual void followPlayer()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if (!hitByArrow && !hitByGun && !bastuKilled && !hitByCar && !hitByPepperStart && !freeze)
		{
			droppingBeartrap = false;
			if (!grannySeeDoor && !grannySeeLockedDoor && !stopSeeLockedDoor)
			{
				navComponent.speed = grannysVarSpeed;
			}
			navComponent.stoppingDistance = 2f;
			if (navComponent.velocity != Vector3.zero)
			{
				animationHolder.GetComponent<Animation>().CrossFade("Walk");
			}
			else
			{
				animationHolder.GetComponent<Animation>().CrossFade("idle");
			}
			animationHolder.GetComponent<Animation>()["Walk"].speed = grannysAnimSpeed;
			target = player;
			GrannySearching = false;
			startTimerSearch = false;
			timerSearch = 0f;
		}
	}

	public virtual void newNav()
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (hitByArrow || hitByGun || bastuKilled || hitByCar || hitByPepperStart || freeze)
		{
			return;
		}
		droppingBeartrap = false;
		if (!grannyHearPlayer)
		{
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNav(Clone)")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNav(Clone)"));
			}
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNav(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNav(Clone)Old"));
			}
		}
		if (!grannyHearObject)
		{
			if (GameObject.FindGameObjectsWithTag("noiseobject") != null)
			{
				NPoints = GameObject.FindGameObjectsWithTag("noiseobject");
				for (int i = 0; i < NPoints.Length; i++)
				{
					Object.Destroy((Object)(object)NPoints[i]);
				}
			}
			((MonoBehaviour)this).StartCoroutine(cleaning());
		}
		animationHolder.GetComponent<Animation>()["Walk"].speed = WalkAnim;
		navComponent.SetDestination(target.position);
		navComponent.speed = WalkSpeed;
		waypointWaitTime = false;
		safeTimer = 0f;
		if (number == 1f || number == 2f)
		{
			target = nav1;
		}
		if (number == 3f || number == 4f)
		{
			target = nav2;
		}
		if (number == 5f || number == 6f)
		{
			target = nav3;
		}
		if (number == 7f || number == 8f)
		{
			target = nav4;
		}
		if (number == 9f || number == 10f)
		{
			target = nav5;
		}
		if (number == 11f || number == 12f)
		{
			target = nav6;
		}
		if (number == 13f || number == 14f)
		{
			target = nav7;
		}
		if (number == 15f || number == 16f)
		{
			target = nav8;
		}
		if (number == 17f || number == 18f)
		{
			target = nav9;
		}
		if (number == 19f || number == 20f)
		{
			target = nav10;
		}
		if (number == 21f || number == 22f)
		{
			target = nav11;
		}
		if (number == 23f || number == 24f)
		{
			target = nav12;
		}
		if (number == 25f || number == 26f)
		{
			target = nav13;
		}
		if (number == 27f || number == 28f)
		{
			target = nav14;
		}
		if (number == 29f || number == 30f)
		{
			target = nav15;
		}
		if (number == 31f || number == 32f)
		{
			target = nav16;
		}
	}

	public virtual IEnumerator cleaning()
	{
		yield return (object)new WaitForSeconds(15f);
		((MonoBehaviour)this).StartCoroutine(((furnitureControlls)(object)gameController.GetComponent(typeof(furnitureControlls))).cleanUp());
	}

	public virtual void Anomaly24Trap()
	{
		if (Anomaly24Kef < 3f)
		{
			Anomaly24Kef += 0.01f;
			grannysVarSpeed = StartMoveSpeed * Anomaly24Kef;
			grannysAnimSpeed = StartMoveAnim * Anomaly24Kef;
			WalkSpeed = 1.2f * Anomaly24Kef;
			WalkAnim = 0.9f * Anomaly24Kef;
		}
	}

	public virtual IEnumerator Anomaly26GrannyAbility()
	{
		grannyAbility = true;
		((GrannySounds)(object)grannySounds.GetComponent(typeof(GrannySounds))).grannySkrattar();
		gameController.GetComponent<startNewDay>().GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			grannysVarSpeed = 3.45f;
			grannysAnimSpeed = 1.95f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
		{
			grannysVarSpeed = 6.45f;
			grannysAnimSpeed = 2f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			grannysVarSpeed = 4.5f;
			grannysAnimSpeed = 2.25f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			grannysVarSpeed = 7.5f;
			grannysAnimSpeed = 4.05f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			grannysVarSpeed = 10.5f;
			grannysAnimSpeed = 4.95f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			grannysVarSpeed = 14.33f;
			grannysAnimSpeed = 7.2f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			grannysVarSpeed = 18.9f;
			grannysAnimSpeed = 10.1f;
		}
		NavMeshAgent component = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
		component.acceleration *= 2f;
		yield return (object)new WaitForSeconds(30f);
		gameController.GetComponent<startNewDay>().GrannyEyeColor.gameObject.GetComponent<Renderer>().material.color = new Color(0.588f, 0.588f, 0.588f);
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			grannysVarSpeed = 2.3f;
			grannysAnimSpeed = 1.3f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0 || PlayerPrefs.GetInt("DiffData") == 4)
		{
			grannysVarSpeed = 4.3f;
			grannysAnimSpeed = 2f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			grannysVarSpeed = 3f;
			grannysAnimSpeed = 1.5f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			grannysVarSpeed = 5f;
			grannysAnimSpeed = 2.7f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			grannysVarSpeed = 7f;
			grannysAnimSpeed = 3.3f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			grannysVarSpeed = 9.55f;
			grannysAnimSpeed = 4.8f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			grannysVarSpeed = 12.6f;
			grannysAnimSpeed = 6.8f;
		}
		NavMeshAgent component2 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
		component2.acceleration /= 2f;
		grannyAbility = false;
	}

	public virtual void Event2Buff()
	{
		Event2GrannySpeed++;
		if (Event2GrannySpeed == 1)
		{
			grannysVarSpeed = 4.3f;
			grannysAnimSpeed = 2f;
			WalkSpeed = 1.6f;
			WalkAnim = 1.1f;
		}
		if (Event2GrannySpeed == 2)
		{
			grannysVarSpeed = 5f;
			grannysAnimSpeed = 2.7f;
			WalkSpeed = 2f;
			WalkAnim = 1.3f;
		}
		if (Event2GrannySpeed == 3)
		{
			grannysVarSpeed = 7f;
			grannysAnimSpeed = 3.3f;
			WalkSpeed = 3f;
			WalkAnim = 1.7f;
		}
		if (Event2GrannySpeed == 4)
		{
			grannysVarSpeed = 9.55f;
			grannysAnimSpeed = 4.8f;
			WalkSpeed = 4.3f;
			WalkAnim = 2f;
		}
		if (Event2GrannySpeed == 5)
		{
			grannysVarSpeed = 12.6f;
			grannysAnimSpeed = 6.8f;
			WalkSpeed = 6f;
			WalkAnim = 3.4f;
		}
		if (Event2GrannySpeed == 6)
		{
			grannysVarSpeed = 16f;
			grannysAnimSpeed = 9f;
			WalkSpeed = 9.2f;
			WalkAnim = 4.8f;
			NavMeshAgent component = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component.acceleration *= 3f;
		}
		if (Event2GrannySpeed == 7)
		{
			grannysVarSpeed = 20f;
			grannysAnimSpeed = 12.6f;
			WalkSpeed = 11.9f;
			WalkAnim = 6.8f;
		}
		if (Event2GrannySpeed == 8)
		{
			grannysVarSpeed = 40f;
			grannysAnimSpeed = 25.2f;
			WalkSpeed = 20f;
			WalkAnim = 12.6f;
			NavMeshAgent component2 = ((Component)this).gameObject.GetComponent<NavMeshAgent>();
			component2.acceleration *= 3f;
		}
	}

	public virtual void FixBed()
	{
		optionButton.SetActive(false);
		animationHolder.GetComponent<Animation>().CrossFade("lookBed");
		grannyLookUnderBed = true;
		timerBed = 0f;
		safeTimer = 0f;
		allBedButtons.SetActive(false);
		if (hidingUnderBed1)
		{
			((bedEyes)(object)bedCam1.GetComponent(typeof(bedEyes))).lookAtGranny = true;
			if (!soundPlaying)
			{
				soundPlaying = true;
				((soundEffectsBeds)(object)soundHolder1.GetComponent(typeof(soundEffectsBeds))).playerCaught();
			}
		}
		if (hidingUnderBed2)
		{
			((bedEyes2)(object)bedCam2.GetComponent(typeof(bedEyes2))).lookAtGranny = true;
			if (!soundPlaying)
			{
				soundPlaying = true;
				((soundEffectsBeds)(object)soundHolder2.GetComponent(typeof(soundEffectsBeds))).playerCaught();
			}
		}
		if (hidingUnderBed3)
		{
			((bedEyes3)(object)bedCam3.GetComponent(typeof(bedEyes3))).lookAtGranny = true;
			if (!soundPlaying)
			{
				soundPlaying = true;
				((soundEffectsBeds)(object)soundHolder3.GetComponent(typeof(soundEffectsBeds))).playerCaught();
			}
		}
		((MonoBehaviour)this).StartCoroutine(((playerCaughtUnderBed)(object)gameController.GetComponent(typeof(playerCaughtUnderBed))).EndDayUnderBed());
		soundPlaying = false;
	}

	public virtual IEnumerator FakePrimeChase()
	{
		while (true)
		{
			yield return (object)new WaitForSeconds(Random.Range(50f, 120f));
			((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = true;
			yield return (object)new WaitForSeconds(Random.Range(6f, 25f));
			((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).startFade = false;
		}
	}

	public virtual void OnEnable()
	{
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 15)
		{
			timer = 10f;
		}
	}

	public virtual void Anomaly28TeleportToClone()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (SetClone)
		{
			hitByPepper = true;
			hitByPepperStart = true;
			grannyPepperReact = false;
			grannyCloseTrigger.SetActive(true);
			blindTimer = 3f;
			((Component)this).gameObject.GetComponent<NavMeshAgent>().Warp(CurrentClone.transform.position);
			CurrentClone.SetActive(false);
			SetClone = false;
		}
	}

	public virtual IEnumerator PrimeAnomaly1()
	{
		while (true)
		{
			yield return (object)new WaitForSeconds(30f);
			((Renderer)grannyEyeColor.GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
		}
	}

	public virtual void Update()
	{
		if (Input.GetKeyUp((KeyCode)103))
		{
			GrannyTrainingStop = !GrannyTrainingStop;
		}
	}
}
