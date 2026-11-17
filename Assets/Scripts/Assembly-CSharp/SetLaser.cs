using System.Collections.Generic;
using UnityEngine;

public class SetLaser : MonoBehaviour
{
	public Transform HandHoldItems;

	public GameObject LaserPrimeRed;

	public GameObject LaserPrimeGreen;

	public GameObject LaserGreenActivation;

	public GameObject LaserPrimePurple;

	public GameObject Granny;

	public GameObject LaserPrimeYellow;

	public GameObject LaserYellowActivation;

	public int StartingRoomPreset;

	public int HallPreset;

	public int Bedroom1Preset;

	public GameObject LaserPrimeBlue;

	public int Bedroom2Preset;

	public int AtticPreset;

	public GameObject LaserPrimeCyan;

	public int Attic2Preset;

	public int SpiderRoomPreset;

	public GameObject LaserPrimeMarrow;

	public GameObject DangerZone;

	public int CrossbowRoomPreset;

	public int CowlegRoomPreset;

	public GameObject LaserPrimeWhite;

	public int SewerPreset;

	public int KitchenPreset;

	public int LivingRoomPreset;

	public GameObject GameOverDisappear1;

	public GameObject GameOverDisappear2;

	public GameObject GameOverDisappear3;

	public GameObject LaserPrimeGray;

	public GameObject LaserGrayActivation;

	public int StudyRoomPreset;

	public int BasementPreset;

	public int GaragePreset;

	public int BackYardPreset;

	public List<GameObject> ExtraTrapsStartRoom = new List<GameObject>();

	public List<GameObject> ExtraTrapsMainHall = new List<GameObject>();

	public Transform Player;

	public List<GameObject> ExtraTrapsBedroom1 = new List<GameObject>();

	public List<GameObject> ExtraTrapsBedroom2 = new List<GameObject>();

	public List<GameObject> ExtraTrapsAttic = new List<GameObject>();

	public List<GameObject> ExtraTrapsAtticStairs = new List<GameObject>();

	public List<GameObject> ExtraTrapsSpiderAttic = new List<GameObject>();

	public List<GameObject> ExtraTrapsCrossbowArea = new List<GameObject>();

	public List<GameObject> ExtraTrapsCowlegArea = new List<GameObject>();

	public List<GameObject> ExtraTrapsSewerArea = new List<GameObject>();

	public List<GameObject> ExtraTrapsKitchen = new List<GameObject>();

	public List<GameObject> ExtraTrapsLivingRoom = new List<GameObject>();

	public List<GameObject> ExtraTrapsStudyRoom = new List<GameObject>();

	public List<GameObject> ExtraTrapsBasement = new List<GameObject>();

	public List<GameObject> ExtraTrapsGarage = new List<GameObject>();

	public List<GameObject> ExtraTrapsBackyard = new List<GameObject>();

	public Bounds BoundsStartRoom;

	public Bounds BoundsMainHall;

	public Bounds BoundsBedroom1;

	public Bounds BoundsBedroom2;

	public Bounds BoundsAttic;

	public Bounds BoundsAtticStairs;

	public Bounds BoundsSpiderAttic;

	public Bounds BoundsCrossbowArea;

	public Bounds BoundsCowlegArea;

	public Bounds BoundsSewerArea;

	public Bounds BoundsKitchen;

	public Bounds BoundsLivingRoom;

	public Bounds BoundsStudyRoom;

	public Bounds BoundsBasement;

	public Bounds BoundsGarage;

	public Bounds BoundsBackyard;

	public static string CurrentLocation;

	public GameObject LjusstakeCellar;

	public bool LockerAnimationPlayed;

	public static string CurrentPreset;

	public bool ChangePreset;

	public virtual void Start()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Unknown result type (might be due to invalid IL or missing references)
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		LjusstakeCellar = GameObject.Find("LjusstakeCellar");
		Granny = GameObject.Find("GrannyParent");
		Player = Granny.GetComponent<EnemyAIGranny>().player;
		HandHoldItems = GameObject.Find("HandHoldObjects").transform;
		LaserPrimeRed = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(0.94f, 22f, -12.735f), Quaternion.Euler(0f, 0f, 0f));
		LaserPrimeRed.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimeRed.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("GallerHole").GetComponent<MeshRenderer>()).materials;
		((Renderer)LaserPrimeRed.GetComponent<MeshRenderer>()).material.color = Color.grey;
		LaserPrimeRed.AddComponent<LineRenderer>();
		LaserPrimeRed.AddComponent<LaserBeam>();
		LaserPrimeGreen = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(5.7f, 14.5f, -13.1f), Quaternion.Euler(0f, 90f, 0f));
		LaserPrimeGreen.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimeGreen.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("GallerHole").GetComponent<MeshRenderer>()).materials;
		((Renderer)LaserPrimeGreen.GetComponent<MeshRenderer>()).material.color = Color.green;
		LaserPrimeGreen.AddComponent<LineRenderer>();
		LaserPrimeGreen.AddComponent<LaserBeamGreen>();
		Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(5.7f, 14.5f, -13.6f), Quaternion.Euler(0f, 90f, 0f));
		Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(5.7f, 14.5f, -14.1f), Quaternion.Euler(0f, 90f, 0f));
		Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(5.7f, 14.5f, -14.6f), Quaternion.Euler(0f, 90f, 0f));
		LaserGreenActivation = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, (Transform)null);
		LaserGreenActivation.SetActive(true);
		LaserGreenActivation.transform.position = new Vector3(8.51f, 13.31f, -11.65f);
		LaserGreenActivation.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
		LaserGreenActivation.transform.localScale = new Vector3(0.11050239f, 0.03577788f, 0.0415763f);
		((Collider)LaserGreenActivation.AddComponent<BoxCollider>()).isTrigger = true;
		LaserGreenActivation.GetComponent<BoxCollider>().center = new Vector3(0f, 7f, -81.5f);
		LaserGreenActivation.GetComponent<BoxCollider>().size = new Vector3(16.70534f, 140.6033f, 157.6f);
		LaserGreenActivation.AddComponent<GrannyActiveGreenLaser>();
		LaserPrimePurple = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 22f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		LaserPrimePurple.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimePurple.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		((Renderer)LaserPrimePurple.GetComponent<MeshRenderer>()).material.color = Color.gray;
		LaserPrimePurple.AddComponent<LineRenderer>();
		LaserPrimePurple.AddComponent<LaserBeamPurple>();
		LaserPrimeYellow = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 90f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		LaserPrimeYellow.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimeYellow.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		((Renderer)LaserPrimeYellow.GetComponent<MeshRenderer>()).material.color = Color.gray;
		LaserPrimeYellow.AddComponent<LineRenderer>();
		LaserPrimeYellow.AddComponent<LaserBeamYellow>();
		LaserYellowActivation = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 90f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		LaserYellowActivation.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		LaserYellowActivation.AddComponent<BoxCollider>();
		LaserYellowActivation.AddComponent<GrannyActiveYellowLaser__0>();
		((Renderer)LaserYellowActivation.GetComponent<MeshRenderer>()).material.color = Color.yellow;
		((Object)LaserYellowActivation).name = "LaserYellowActivation";
		LaserPrimeBlue = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 90f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		((Renderer)LaserPrimeBlue.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("LitetBordSR3").GetComponent<MeshRenderer>()).materials;
		LaserPrimeBlue.transform.localScale = new Vector3(1f, 1f, 1f);
		LaserPrimeBlue.AddComponent<LineRenderer>();
		LaserPrimeBlue.AddComponent<LaserBeamBlue>();
		LaserPrimeCyan = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 90f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		((Renderer)LaserPrimeCyan.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Burk").GetComponent<MeshRenderer>()).materials;
		LaserPrimeCyan.transform.localScale = new Vector3(1f, 1f, 1f);
		LaserPrimeCyan.AddComponent<LineRenderer>();
		LaserPrimeCyan.AddComponent<LaserBeamCyan>().LaserDistance = 1f;
		LaserPrimeMarrow = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(-21.69f, 90f, 3.065f), Quaternion.Euler(0f, 180f, 0f));
		((Renderer)LaserPrimeMarrow.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		LaserPrimeMarrow.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimeMarrow.GetComponent<MeshRenderer>()).material.color = new Color(0.8f, 0f, 0.4f);
		LaserPrimeMarrow.AddComponent<LineRenderer>();
		LaserPrimeMarrow.AddComponent<LaserBeamMarrow>();
		DangerZone = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, (Transform)null);
		DangerZone.SetActive(true);
		DangerZone.transform.position = new Vector3(8.51f, 190f, -11.65f);
		((Renderer)DangerZone.GetComponent<MeshRenderer>()).material.color = Color.red;
		LaserPrimeGray = Object.Instantiate<GameObject>(GameObject.Find("Larmlampa1"), new Vector3(6.98f, 21.61f, 13.96f), Quaternion.Euler(0f, 180f, 0f));
		((Renderer)LaserPrimeGray.GetComponent<MeshRenderer>()).materials = ((Renderer)GameObject.Find("Fan").GetComponent<MeshRenderer>()).materials;
		LaserPrimeGray.transform.localScale = new Vector3(1f, 1f, 1f);
		((Renderer)LaserPrimeGray.GetComponent<MeshRenderer>()).material.color = new Color(1f, 0.5f, 0f);
		LaserPrimeGray.AddComponent<LineRenderer>();
		LaserPrimeGray.AddComponent<LaserBeamGray>();
		LaserGrayActivation = Object.Instantiate<GameObject>(GameObject.Find("placePlankaTrigger").GetComponent<placePlanka>().highlightPlanka, (Transform)null);
		LaserGrayActivation.SetActive(true);
		LaserGrayActivation.transform.position = new Vector3(14.45f, 20.1f, 4.32f);
		LaserGrayActivation.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
		LaserGrayActivation.transform.localScale = new Vector3(0.1813096f, 0.02065374f, 0.0415763f);
		((Renderer)LaserGrayActivation.GetComponent<MeshRenderer>()).material.mainTexture = ((Renderer)LaserPrimeGray.GetComponent<MeshRenderer>()).material.mainTexture;
		((Renderer)LaserGrayActivation.GetComponent<MeshRenderer>()).material.color = new Color(1f, 0.5f, 0f);
		((Collider)LaserGrayActivation.AddComponent<BoxCollider>()).isTrigger = true;
		LaserGrayActivation.GetComponent<BoxCollider>().center = new Vector3(0f, 7f, -15f);
		LaserGrayActivation.GetComponent<BoxCollider>().size = new Vector3(16.70534f, 140.6033f, 24.45f);
		LaserGrayActivation.AddComponent<ActivateGrayLaser>().GrayLaser = LaserPrimeGray;
		LaserPrimeGray.GetComponent<LaserBeamGray>().ActivateLaser = LaserGrayActivation;
		Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-7.527f, 21.453f, 13.471f), Quaternion.Euler(0f, -90f, 0f));
		Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(6.317f, 36.55f, 9.75f), Quaternion.Euler(0f, 224.6f, 0f));
		GameOverDisappear1 = Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-14.5f, 14.63f, -3.1f), Quaternion.Euler(0f, 90f, 0f));
		GameOverDisappear2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-14.5f, 14.63f, -11.12f), Quaternion.Euler(0f, 90f, 0f));
		GameOverDisappear2.GetComponent<LaserBeamCyan>().LaserDistance = 19.7f;
		GameOverDisappear3 = Object.Instantiate<GameObject>(DangerZone, new Vector3(-5.149f, 13.31f, -7.1289f), Quaternion.Euler(90f, 90f, 0f));
		GameOverDisappear3.transform.localScale = new Vector3(0.53518236f, 0.14556295f, 0.0415763f);
		BoundsStartRoom.SetMinMax(new Vector3(-0.529f, 20.037f, -12.7961f), new Vector3(19.763f, 26.868f, -1.683f));
		BoundsMainHall.SetMinMax(new Vector3(-7.333f, 13.2219f, -1.683f), new Vector3(6.177f, 26.868f, 14.099f));
		BoundsBedroom1.SetMinMax(new Vector3(-20.986f, 20.037f, -21.569f), new Vector3(-0.529f, 26.868f, -1.683f));
		BoundsBedroom2.SetMinMax(new Vector3(-20.9f, 20.037f, -2.039f), new Vector3(-7.361f, 26.868f, 14.099f));
		BoundsAttic.SetMinMax(new Vector3(-15.837f, 26.868f, -5.764f), new Vector3(15.68f, 33.327f, 14.099f));
		BoundsAtticStairs.SetMinMax(new Vector3(-7.361f, 20.037f, 14.099f), new Vector3(8.9f, 33.327f, 16.63f));
		BoundsSpiderAttic.SetMinMax(new Vector3(-12.05f, 26.868f, -8.2f), new Vector3(6.973f, 41.51f, 10.544f));
		BoundsCrossbowArea.SetMinMax(new Vector3(-17.69f, 17.396f, -26.94f), new Vector3(5.506f, 24.885f, -14.944f));
		BoundsCowlegArea.SetMinMax(new Vector3(-8.201f, 7.416f, -26.94f), new Vector3(5.506f, 17.396f, -12.764f));
		BoundsSewerArea.SetMinMax(new Vector3(-10.855f, 7.416f, -41.29f), new Vector3(8.865f, 17.396f, -26.94f));
		BoundsKitchen.SetMinMax(new Vector3(6.177f, 13.2219f, -1.683f), new Vector3(19.791f, 20.037f, 14.099f));
		BoundsLivingRoom.SetMinMax(new Vector3(-21.012f, 13.2219f, -12.758f), new Vector3(19.791f, 20.037f, -1.683f));
		BoundsStudyRoom.SetMinMax(new Vector3(-21.012f, 13.2219f, -1.683f), new Vector3(-7.333f, 20.037f, 14.099f));
		BoundsBasement.SetMinMax(new Vector3(-9.611f, 7.438f, -8.462f), new Vector3(8.5266f, 13.2219f, 9.7967f));
		BoundsGarage.SetMinMax(new Vector3(-7.221f, 1.608f, -6.87f), new Vector3(11.282f, 7.438f, 7.001f));
		BoundsBackyard.SetMinMax(new Vector3(5.566f, 7.438f, -27.056f), new Vector3(34.814f, 17.362f, -2.235f));
		StartingRoomPreset = Random.Range(1, 8);
		PlaceStartRoom();
		HallPreset = Random.Range(1, 8);
		PlaceMainHall();
		Bedroom1Preset = Random.Range(1, 9);
		PlaceBedroom1();
		Bedroom2Preset = Random.Range(1, 8);
		PlaceBedroom2();
		AtticPreset = Random.Range(1, 9);
		PlaceAttic();
		Attic2Preset = Random.Range(1, 3);
		PlaceAtticStairs();
		SpiderRoomPreset = Random.Range(1, 7);
		PlaceSpiderAttic();
		CrossbowRoomPreset = Random.Range(1, 7);
		PlaceCrossbowArea();
		CowlegRoomPreset = Random.Range(1, 7);
		PlaceCowlegArea();
		SewerPreset = Random.Range(1, 9);
		PlaceSewerArea();
		KitchenPreset = Random.Range(1, 9);
		PlaceKitchen();
		LivingRoomPreset = Random.Range(1, 7);
		PlaceLivingRoom();
		StudyRoomPreset = Random.Range(1, 7);
		PlaceStudyRoom();
		BasementPreset = Random.Range(1, 8);
		PlaceBasement();
		GaragePreset = Random.Range(1, 8);
		PlaceGarage();
		BackYardPreset = Random.Range(1, 9);
		PlaceBackyard();
	}

	public void DeleteTraps()
	{
		GameOverDisappear1.SetActive(false);
		GameOverDisappear2.SetActive(false);
		GameOverDisappear3.SetActive(false);
		LaserGreenActivation.SetActive(false);
	}

	public void ChangePresetButton()
	{
		if (!((Component)this).gameObject.GetComponent<startNewDay>().deadByLaser)
		{
			ChangePreset = true;
		}
	}

	public void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = HandHoldItems.position;
		if (BoundsStartRoom.Contains(position))
		{
			CurrentLocation = "Your bedroom";
			CurrentPreset = string.Concat(StartingRoomPreset);
			if (ChangePreset)
			{
				if (StartingRoomPreset < 7)
				{
					StartingRoomPreset++;
				}
				else
				{
					StartingRoomPreset = 1;
				}
				DestroyStartRoom();
				PlaceStartRoom();
				ChangePreset = false;
			}
		}
		else if (BoundsMainHall.Contains(position))
		{
			CurrentLocation = "Hall";
			CurrentPreset = string.Concat(HallPreset);
			if (ChangePreset)
			{
				if (HallPreset < 7)
				{
					HallPreset++;
				}
				else
				{
					HallPreset = 1;
				}
				DestroyMainHall();
				PlaceMainHall();
				ChangePreset = false;
			}
		}
		else if (BoundsBedroom1.Contains(position))
		{
			CurrentLocation = "Bedroom 1";
			CurrentPreset = string.Concat(Bedroom1Preset);
			if (ChangePreset)
			{
				if (Bedroom1Preset < 8)
				{
					Bedroom1Preset++;
				}
				else
				{
					Bedroom1Preset = 1;
				}
				DestroyBedroom1();
				PlaceBedroom1();
				ChangePreset = false;
			}
		}
		else if (BoundsBedroom2.Contains(position))
		{
			CurrentLocation = "Bedroom 2";
			CurrentPreset = string.Concat(Bedroom2Preset);
			if (ChangePreset)
			{
				if (Bedroom2Preset < 7)
				{
					Bedroom2Preset++;
				}
				else
				{
					Bedroom2Preset = 1;
				}
				DestroyBedroom2();
				PlaceBedroom2();
				ChangePreset = false;
			}
		}
		else if (BoundsAttic.Contains(position))
		{
			CurrentLocation = "Attic";
			CurrentPreset = string.Concat(AtticPreset);
			if (ChangePreset)
			{
				if (AtticPreset < 8)
				{
					AtticPreset++;
				}
				else
				{
					AtticPreset = 1;
				}
				DestroyAttic();
				PlaceAttic();
				ChangePreset = false;
			}
		}
		else if (BoundsAtticStairs.Contains(position))
		{
			CurrentLocation = "Attic stairs";
			CurrentPreset = string.Concat(Attic2Preset);
			if (ChangePreset)
			{
				if (Attic2Preset < 2)
				{
					Attic2Preset++;
				}
				else
				{
					Attic2Preset = 1;
				}
				DestroyAtticStairs();
				PlaceAtticStairs();
				ChangePreset = false;
			}
		}
		else if (BoundsSpiderAttic.Contains(position))
		{
			CurrentLocation = "Special room";
			CurrentPreset = string.Concat(SpiderRoomPreset);
			if (ChangePreset)
			{
				if (SpiderRoomPreset < 6)
				{
					SpiderRoomPreset++;
				}
				else
				{
					SpiderRoomPreset = 1;
				}
				DestroySpiderAttic();
				PlaceSpiderAttic();
				ChangePreset = false;
			}
		}
		else if (BoundsCrossbowArea.Contains(position))
		{
			CurrentLocation = "Secret area 1";
			CurrentPreset = string.Concat(CrossbowRoomPreset);
			if (ChangePreset)
			{
				if (CrossbowRoomPreset < 6)
				{
					CrossbowRoomPreset++;
				}
				else
				{
					CrossbowRoomPreset = 1;
				}
				DestroyCrossbowArea();
				PlaceCrossbowArea();
				ChangePreset = false;
			}
		}
		else if (BoundsCowlegArea.Contains(position))
		{
			CurrentLocation = "Secret area 2";
			CurrentPreset = string.Concat(CowlegRoomPreset);
			if (ChangePreset)
			{
				if (CowlegRoomPreset < 6)
				{
					CowlegRoomPreset++;
				}
				else
				{
					CowlegRoomPreset = 1;
				}
				DestroyCowlegArea();
				PlaceCowlegArea();
				ChangePreset = false;
			}
		}
		else if (BoundsSewerArea.Contains(position))
		{
			CurrentLocation = "Secret area 3";
			CurrentPreset = string.Concat(SewerPreset);
			if (ChangePreset)
			{
				if (SewerPreset < 8)
				{
					SewerPreset++;
				}
				else
				{
					SewerPreset = 1;
				}
				DestroySewerArea();
				PlaceSewerArea();
				ChangePreset = false;
			}
		}
		else if (BoundsKitchen.Contains(position))
		{
			CurrentLocation = "Kitchen";
			CurrentPreset = string.Concat(KitchenPreset);
			if (ChangePreset)
			{
				if (KitchenPreset < 8)
				{
					KitchenPreset++;
				}
				else
				{
					KitchenPreset = 1;
				}
				DestroyKitchen();
				PlaceKitchen();
				ChangePreset = false;
			}
		}
		else if (BoundsLivingRoom.Contains(position))
		{
			CurrentLocation = "Living room 1";
			CurrentPreset = string.Concat(LivingRoomPreset);
			if (ChangePreset)
			{
				if (LivingRoomPreset < 6)
				{
					LivingRoomPreset++;
				}
				else
				{
					LivingRoomPreset = 1;
				}
				DestroyLivingRoom();
				PlaceLivingRoom();
				ChangePreset = false;
			}
		}
		else if (BoundsStudyRoom.Contains(position))
		{
			CurrentLocation = "Living room 2";
			CurrentPreset = string.Concat(StudyRoomPreset);
			if (ChangePreset)
			{
				if (StudyRoomPreset < 6)
				{
					StudyRoomPreset++;
				}
				else
				{
					StudyRoomPreset = 1;
				}
				DestroyStudyRoom();
				PlaceStudyRoom();
				ChangePreset = false;
			}
		}
		else if (BoundsBasement.Contains(position))
		{
			CurrentLocation = "Basement";
			CurrentPreset = string.Concat(BasementPreset);
			if (ChangePreset)
			{
				if (BasementPreset < 7)
				{
					BasementPreset++;
				}
				else
				{
					BasementPreset = 1;
				}
				DestroyBasement();
				PlaceBasement();
				ChangePreset = false;
			}
		}
		else if (BoundsGarage.Contains(position))
		{
			CurrentLocation = "Garage";
			CurrentPreset = string.Concat(GaragePreset);
			if (ChangePreset)
			{
				if (GaragePreset < 7)
				{
					GaragePreset++;
				}
				else
				{
					GaragePreset = 1;
				}
				DestroyGarage();
				PlaceGarage();
				ChangePreset = false;
			}
		}
		else if (BoundsBackyard.Contains(position))
		{
			CurrentLocation = "Backyard";
			CurrentPreset = string.Concat(BackYardPreset);
			if (ChangePreset)
			{
				if (BackYardPreset < 8)
				{
					BackYardPreset++;
				}
				else
				{
					BackYardPreset = 1;
				}
				DestroyBackyard();
				PlaceBackyard();
				ChangePreset = false;
			}
		}
		else
		{
			CurrentLocation = "Other";
			CurrentPreset = "1";
		}
	}

	public void PlaceStartRoom()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_083b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		if (StartingRoomPreset == 1)
		{
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(19.6f, 23.8f, -4.88f), Quaternion.Euler(0f, -90f, 0f)));
		}
		else if (StartingRoomPreset == 2)
		{
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(7.86f, 22.73f, -12.7f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.57f, 21.61f, -1.86f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 2f;
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(12.65f, 21.61f, -1.86f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 2f;
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.localPosition = new Vector3(2.131577f, 6.578941f, 0.03282004f);
			val.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.SetParent(GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.localPosition = new Vector3(4.763153f, 6.578941f, 0.03282004f);
			val.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.SetParent(GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.localPosition = new Vector3(7.394728f, 6.578941f, 0.03282004f);
			val.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.SetParent(GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.localPosition = new Vector3(10.02631f, 6.578941f, 0.03282004f);
			val.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsStartRoom.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.SetParent(GameObject.Find("InnerdoorParent/Innerdoor").transform);
			val.transform.localPosition = new Vector3(12.65788f, 6.578941f, 0.03282004f);
			val.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsStartRoom.Add(val);
		}
		else if (StartingRoomPreset == 3)
		{
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(15.7f, 21f, -1.8f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(15.2f, 21f, -1.8f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(14.7f, 21f, -1.8f), Quaternion.Euler(0f, 180f, 0f)));
			GameObject val2 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(17.922f, 20.1f, -11.16f), Quaternion.Euler(90f, 0f, 0f));
			val2.transform.localScale = new Vector3(0.18130957f, 0.020653741f, 0.0415763f);
			ExtraTrapsStartRoom.Add(val2);
		}
		else if (StartingRoomPreset == 4)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.4f, 20.1f, -5.32f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsStartRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(6.09f, 20.1f, -2.65f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsStartRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(13.25f, 20.1f, -2.65f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsStartRoom.Add(val3);
		}
		else if (StartingRoomPreset == 5)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.956f, 20.1f, -2.65f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsStartRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(6.35f, 20.1f, -7.47f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsStartRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.4f, 20.1f, -5.32f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsStartRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(6.09f, 20.1f, -2.65f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsStartRoom.Add(val4);
		}
		else if (StartingRoomPreset == 6)
		{
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(16.01f, 21.45f, -2.38f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(2.19f, 23.73f, -11.91f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(6.078f, 23.73f, 3.05f), Quaternion.Euler(0f, -90f, 0f)));
			GameObject val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.072f, 20.205f, 4f), Quaternion.Euler(0f, 130f, 0f));
			((Object)val5).name = "BearTrapPrimeYellow";
			ExtraTrapsStartRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.072f, 18.5f, 5.5f), Quaternion.Euler(0f, 38f, 0f));
			((Object)val5).name = "BearTrapPrimeYellow";
			ExtraTrapsStartRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.072f, 17.6f, 7f), Quaternion.Euler(0f, 117f, 0f));
			((Object)val5).name = "BearTrapPrimeYellow";
			ExtraTrapsStartRoom.Add(val5);
		}
		else if (StartingRoomPreset == 7)
		{
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(2.19f, 22f, -12.3f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsStartRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(2.19f, 22f, -11.7f), Quaternion.Euler(0f, 90f, 0f)));
			GameObject val6 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(9.33f, 20.09f, -9f), Quaternion.Euler(90f, 0f, 0f));
			val6.transform.localScale = new Vector3(0.276682f, 0.056493208f, 0.0415763f);
			ExtraTrapsStartRoom.Add(val6);
		}
	}

	public void DestroyStartRoom()
	{
		foreach (GameObject item in ExtraTrapsStartRoom)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsStartRoom.Clear();
	}

	public void PlaceMainHall()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		if (HallPreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.46f, 20.1f, 2.718f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsMainHall.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.35f, 13.33f, 7.835f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsMainHall.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.42f, 20.1f, 3.85f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsMainHall.Add(val);
		}
		else if (HallPreset == 2)
		{
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.203f, 23f, -1.076f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.203f, 24f, -1.076f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.203f, 25f, -1.076f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (HallPreset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.73f, 13.32f, 10.035f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.092f, 13.32f, 12.114f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.06f, 13.32f, 8.73f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.37f, 13.32f, 7.2f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.06f, 13.32f, 9.76f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.37f, 13.32f, 12.01f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val2);
		}
		else if (HallPreset == 4)
		{
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-0.19f, 22f, -1.528f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-7.2f, 22f, 5.528f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-7.2f, 22f, 8.856f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (HallPreset == 5)
		{
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(5.808f, 23.1f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(0.908f, 23.1f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (HallPreset == 6)
		{
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(2.333f, 15.47f, -1.528f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsMainHall.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-2.36f, 16.5f, -1.528f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (HallPreset == 7)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.46f, 20.1f, 2.718f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.951f, 20.1f, 3.33f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.87f, 20.1f, 5.02f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.34f, 20.1f, 1.13f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsMainHall.Add(val3);
		}
	}

	public void DestroyMainHall()
	{
		foreach (GameObject item in ExtraTrapsMainHall)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsMainHall.Clear();
	}

	public void PlaceBedroom1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		if (Bedroom1Preset == 1)
		{
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-6.4f, 21.639f, -1.78f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-6.9f, 21.639f, -1.78f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-7.4f, 21.639f, -1.78f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-16.75f, 21.84f, -24f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-16.25f, 21.84f, -24f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-15.75f, 21.84f, -24f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(-12.07f, 20.1f, -8.25f), Quaternion.Euler(90f, 0f, 0f));
			val.transform.localScale = new Vector3(0.18130957f, 0.020653741f, 0.0415763f);
			ExtraTrapsBedroom1.Add(val);
		}
		else if (Bedroom1Preset == 2)
		{
			GameObject item = Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-14.76f, 21.639f, -12.72f), Quaternion.Euler(0f, 0f, 0f));
			ExtraTrapsBedroom1.Add(item);
		}
		else if (Bedroom1Preset == 3)
		{
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-15.244f, 23.35f, -4.85f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (Bedroom1Preset == 4)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeRed, GameObject.Find("InnerdoorParent (3)/Innerdoor").transform);
			val2.transform.localPosition = new Vector3(5.648799f, 13.59648f, 0.211839f);
			val2.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val2.transform.localScale = new Vector3(4.38596f, 4.385961f, 2.983648f);
			ExtraTrapsBedroom1.Add(val2);
		}
		else if (Bedroom1Preset == 5)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-16.4f, 20.1f, -8.796f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-18.07f, 20.1f, -8.796f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-18.9f, 20.1f, -10.289f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val3);
		}
		else if (Bedroom1Preset == 6)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.85f, 20.1f, -3.68f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.283f, 20.1f, -5.439f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.396f, 20.1f, -2.907f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.78f, 20.1f, -5.362f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.307f, 20.1f, -6.8f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-12.16f, 20.1f, -8.524f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-14.46f, 20.1f, -10.93f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-14.46f, 20.1f, -6.01f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom1.Add(val4);
		}
		else if (Bedroom1Preset == 7)
		{
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-15.92f, 21f, -1.811f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-15.92f, 22f, -1.811f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-15.92f, 23f, -1.811f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-15.92f, 24f, -1.811f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-15.92f, 25f, -1.811f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (Bedroom1Preset == 8)
		{
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-13.073f, 21.817f, -21f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-13.073f, 21.817f, -19.5f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-13.073f, 21.817f, -18f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-13.073f, 21.817f, -16.5f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBedroom1.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-13.073f, 21.817f, -15f), Quaternion.Euler(0f, -90f, 0f)));
		}
	}

	public void DestroyBedroom1()
	{
		foreach (GameObject item in ExtraTrapsBedroom1)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsBedroom1.Clear();
	}

	public void PlaceBedroom2()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		if (Bedroom2Preset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.142f, 20.1f, 8.477f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.978f, 20.1f, 12.14f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.669f, 20.1f, 10.38f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-14.431f, 20.1f, 8.82f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-15.265f, 20.1f, 7.25f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-15.37f, 20.1f, 5.57f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-17.089f, 20.1f, 5.413f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsBedroom2.Add(val);
		}
		else if (Bedroom2Preset == 2)
		{
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-9.7f, 22f, -1.539f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (Bedroom2Preset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeRed, GameObject.Find("movingBookshelf").transform);
			val2.transform.localPosition = new Vector3(3.045801f, 4.778393f, 3.656785f);
			val2.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			val2.transform.localScale = new Vector3(4.431599f, 4.431597f, 6.43236f);
			ExtraTrapsBedroom2.Add(val2);
		}
		else if (Bedroom2Preset == 4)
		{
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-16.133f, 21f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-16.133f, 22f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-16.133f, 23f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-16.133f, 24f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-16.133f, 25f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (Bedroom2Preset == 5)
		{
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-6.5f, 21.84f, 16.6f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-6f, 21.84f, 16.6f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBedroom2.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-5.5f, 21.84f, 16.6f), Quaternion.Euler(0f, 180f, 0f)));
			GameObject val3 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(-14.39f, 20.1f, 3.21f), Quaternion.Euler(90f, 0f, 0f));
			val3.transform.localScale = new Vector3(0.18130957f, 0.020653741f, 0.0415763f);
			ExtraTrapsBedroom2.Add(val3);
		}
		else if (Bedroom2Preset == 6)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-15.37f, 20.1f, 5.57f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom2.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-17.089f, 20.1f, 5.413f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom2.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.8f, 20.1f, 4.726f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom2.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-12.37f, 20.1f, 3.55f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom2.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.02f, 20.1f, 2.33f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBedroom2.Add(val4);
		}
		else if (Bedroom2Preset == 7)
		{
			GameObject val5 = Object.Instantiate<GameObject>(LaserPrimeRed, GameObject.Find("InnerdoorParent (1)/Innerdoor").transform);
			val5.transform.localPosition = new Vector3(2.358412f, 14.21053f, 0.3070985f);
			val5.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			val5.transform.localScale = new Vector3(4.385965f, 4.385965f, 2.98365f);
			ExtraTrapsBedroom2.Add(val5);
		}
	}

	public void DestroyBedroom2()
	{
		foreach (GameObject item in ExtraTrapsBedroom2)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsBedroom2.Clear();
	}

	public void PlaceAttic()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Unknown result type (might be due to invalid IL or missing references)
		//IL_101b: Unknown result type (might be due to invalid IL or missing references)
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1106: Unknown result type (might be due to invalid IL or missing references)
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_115b: Unknown result type (might be due to invalid IL or missing references)
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1205: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Unknown result type (might be due to invalid IL or missing references)
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12af: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_130d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1321: Unknown result type (might be due to invalid IL or missing references)
		//IL_134b: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1389: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Unknown result type (might be due to invalid IL or missing references)
		//IL_1419: Unknown result type (might be due to invalid IL or missing references)
		if (AtticPreset == 1)
		{
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(14f, 26.3f, -1.531f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(14.5f, 26.3f, -1.531f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(15f, 26.3f, -1.531f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (AtticPreset == 2)
		{
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-1.068f, 28f, 1.46f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-1.068f, 29f, 1.46f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-1.068f, 30f, 1.46f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-1.068f, 31f, 1.46f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-1.068f, 32f, 1.46f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (AtticPreset == 3)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.566f, 26.934f, 12.7f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.566f, 26.934f, 11.05f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.566f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.09f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.71f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.31f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.867f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.867f, 26.934f, 7.907f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.867f, 26.934f, 4.65f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.867f, 26.934f, 3.03f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.867f, 26.934f, 1.48f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.37f, 26.934f, 1.48f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.8f, 26.934f, 1.48f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.62f, 26.934f, 1.48f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.8f, 26.934f, -0.16f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.2f, 26.934f, -0.16f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.62f, 26.934f, -0.16f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.62f, 26.934f, 3.03f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-0.41f, 28.88f, 5.17f), Quaternion.Euler(0f, 90f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 6.7f;
			ExtraTrapsAttic.Add(val);
		}
		else if (AtticPreset == 4)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-5.8f, 30f, 14f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 9f;
			ExtraTrapsAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-8.24f, 30f, 1.437f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 9f;
			ExtraTrapsAttic.Add(val2);
		}
		else if (AtticPreset == 5)
		{
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-15.72f, 30f, -1.281f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-15.72f, 30f, -0.327f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-15.72f, 30f, 0.56f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (AtticPreset == 6)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.65f, 26.934f, 0.301f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.191f, 26.934f, 0.301f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.511f, 26.934f, 0.301f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.23f, 26.934f, -0.364f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.068f, 26.934f, -0.364f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.068f, 26.934f, -1.898f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.511f, 26.934f, -1.369f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.13f, 26.934f, -1.953f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.68f, 26.934f, -2.44f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-12.5f, 26.934f, -3.01f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.83f, 26.934f, -3.952f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.15f, 26.934f, -3.952f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.7f, 26.934f, -4.44f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.08f, 26.934f, -4.77f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.44f, 26.934f, -4.77f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.09f, 26.934f, 9.463f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.37f, 26.934f, 2.95f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsAttic.Add(val3);
		}
		else if (AtticPreset == 7)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.901f, 26.93f, 13.07f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.82f, 26.93f, 11.33f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.52f, 26.93f, 9.63f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.48f, 26.93f, 7.22f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.58f, 26.93f, 7.21f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.37f, 26.93f, 5.18f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.36f, 26.93f, 3.89f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.96f, 27.93f, 3.89f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-14.43f, 26.93f, 7.09f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.494f, 26.93f, 1.321f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsAttic.Add(val4);
		}
		else if (AtticPreset == 8)
		{
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-0.41f, 28.88f, 5.9f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-0.41f, 28.88f, 10.19f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-10.935f, 28.88f, 5.36f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-1.668f, 28.88f, 1.281f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsAttic.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-1.668f, 28.88f, 1.47f), Quaternion.Euler(0f, 0f, 0f)));
		}
	}

	public void DestroyAttic()
	{
		foreach (GameObject item in ExtraTrapsAttic)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsAttic.Clear();
	}

	public void PlaceAtticStairs()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		if (Attic2Preset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-3.7f, 22.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-0.7f, 24.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(2.3f, 26.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(5.3f, 28.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-2.2f, 23.5f, 14.056f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(0.8f, 25.5f, 14.056f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(3.8f, 27.5f, 14.174f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val);
		}
		else if (Attic2Preset == 2)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-3.7f, 22.5f, 14.056f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-0.7f, 24.5f, 14.056f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(2.3f, 26.5f, 14.056f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(5.3f, 28.5f, 14.174f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-2.2f, 23.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.75f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(0.8f, 25.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(3.8f, 27.5f, 16.6f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 1.5f;
			ExtraTrapsAtticStairs.Add(val2);
		}
	}

	public void DestroyAtticStairs()
	{
		foreach (GameObject extraTrapsAtticStair in ExtraTrapsAtticStairs)
		{
			Object.DestroyImmediate((Object)(object)extraTrapsAtticStair);
		}
		ExtraTrapsAtticStairs.Clear();
	}

	public void PlaceSpiderAttic()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bee: Unknown result type (might be due to invalid IL or missing references)
		if (SpiderRoomPreset == 1)
		{
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(0.95f, 28.5f, -8.11f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(0.95f, 29.5f, -8.11f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(0.95f, 30.5f, -8.11f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(0.95f, 31.5f, -8.11f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(0.95f, 32.5f, -8.11f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (SpiderRoomPreset == 2)
		{
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.928f, 35f, 6.52f), Quaternion.Euler(0f, -90f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.928f, 35f, 2.72f), Quaternion.Euler(0f, -90f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.928f, 35f, -1.08f), Quaternion.Euler(0f, -90f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val);
		}
		else if (SpiderRoomPreset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.928f, 34.6f, 7.5f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 14.64f;
			ExtraTrapsSpiderAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-7.7f, 34.6f, -5.783f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamCyan>().LaserDistance = 13.31f;
			ExtraTrapsSpiderAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(6.928f, 34.6f, 7f), Quaternion.Euler(0f, -90f, 0f));
			ExtraTrapsSpiderAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-7.2f, 34.6f, -5.783f), Quaternion.Euler(0f, 0f, 0f));
			ExtraTrapsSpiderAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.928f, 34.6f, 6.5f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-6.7f, 34.6f, -5.783f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val2);
		}
		else if (SpiderRoomPreset == 4)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.474f, 33.48f, -4.986f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.637f, 33.48f, -3.749f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.799f, 33.48f, -2.512f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.962f, 33.48f, -1.275f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.125f, 33.48f, -0.038f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.288f, 33.48f, 1.199f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.451f, 33.48f, 2.436f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.614f, 33.48f, 3.673f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.776f, 33.48f, 4.91f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.937f, 33.48f, 6.151f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsSpiderAttic.Add(val3);
		}
		else if (SpiderRoomPreset == 5)
		{
			GameObject val4 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.928f, 34.6f, 6.52f), Quaternion.Euler(0f, -90f, 0f));
			val4.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-7.401f, 34.6f, -5.783f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-3.073f, 34.6f, -5.783f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 20f;
			ExtraTrapsSpiderAttic.Add(val4);
		}
		else if (SpiderRoomPreset == 6)
		{
			GameObject val5 = Object.Instantiate<GameObject>(DangerZone, new Vector3(-0.43f, 33.47f, 2.4f), Quaternion.Euler(90f, -43.6f, 0f));
			val5.transform.localScale = new Vector3(0.2816333f, 0.1135574f, 0.0415763f);
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.901f, 33.48f, 9.034f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.989f, 33.48f, 6.77f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.924f, 33.48f, 5.473f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.079f, 33.48f, 4.282f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.069f, 33.48f, 1.197f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.08f, 33.48f, 1.197f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.914f, 33.48f, -1.026f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsSpiderAttic.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.985f, 33.48f, -3.058f), Quaternion.Euler(0f, -137.4f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsSpiderAttic.Add(val5);
			ExtraTrapsSpiderAttic.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-11.85f, 35f, 10f), Quaternion.Euler(0f, 90f, 0f)));
		}
	}

	public void DestroySpiderAttic()
	{
		foreach (GameObject item in ExtraTrapsSpiderAttic)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsSpiderAttic.Clear();
	}

	public void PlaceCrossbowArea()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Unknown result type (might be due to invalid IL or missing references)
		if (CrossbowRoomPreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(DangerZone, new Vector3(0.916f, 17.44f, -21.59f), Quaternion.Euler(90f, 90f, 0f));
			val.transform.localScale = new Vector3(0.40029293f, 0.05665987f, 0.0415763f);
			ExtraTrapsCrossbowArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.41f, 17.425f, -19.82f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<BearTrap>().timerInvisible2 = 1f;
			ExtraTrapsCrossbowArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.165f, 17.425f, -23.743f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<BearTrap>().timerInvisible2 = 2f;
			ExtraTrapsCrossbowArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0f, 17.425f, -20.29f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<BearTrap>().timerInvisible2 = 3f;
			ExtraTrapsCrossbowArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.488f, 17.425f, -21.267f), Quaternion.Euler(0f, 180f, 0f));
			val.GetComponent<BearTrap>().timerInvisible2 = 4f;
			ExtraTrapsCrossbowArea.Add(val);
		}
		else if (CrossbowRoomPreset == 2)
		{
			GameObject val2 = Object.Instantiate<GameObject>(DangerZone, new Vector3(0.916f, 17.44f, -21.59f), Quaternion.Euler(90f, 90f, 0f));
			val2.transform.localScale = new Vector3(0.40029293f, 0.05665987f, 0.0415763f);
			ExtraTrapsCrossbowArea.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.8f, 17.425f, -20.48f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 1f;
			ExtraTrapsCrossbowArea.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1f, 17.425f, -22.86f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 2f;
			ExtraTrapsCrossbowArea.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -23.759f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 3f;
			ExtraTrapsCrossbowArea.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -19.59f), Quaternion.Euler(0f, 180f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 4f;
			ExtraTrapsCrossbowArea.Add(val2);
		}
		else if (CrossbowRoomPreset == 3)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.41f, 17.425f, -19.82f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.165f, 17.425f, -23.743f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.488f, 17.425f, -21.267f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.8f, 17.425f, -20.48f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1f, 17.425f, -22.86f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -23.759f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -19.59f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.99f, 17.425f, -18.99f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.19f, 17.425f, -20.34f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.82f, 17.425f, -22.41f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val3).name = "BearTrapPrime";
			ExtraTrapsCrossbowArea.Add(val3);
		}
		else if (CrossbowRoomPreset == 4)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.27f, 17.425f, -18.92f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -23.76f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -22.21f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.86f, 17.425f, -20.66f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.6f, 17.425f, -23.76f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.6f, 17.425f, -22.21f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.16f, 17.425f, -23.76f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeNotClose";
			ExtraTrapsCrossbowArea.Add(val4);
		}
		else if (CrossbowRoomPreset == 5)
		{
			ExtraTrapsCrossbowArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(2.662f, 18.495f, -18.842f), Quaternion.Euler(0f, 192.651f, 0f)));
			ExtraTrapsCrossbowArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-5.52f, 19.02f, -18.064f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCrossbowArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-6.62f, 19.02f, -18.064f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCrossbowArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-7.72f, 19.02f, -18.064f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (CrossbowRoomPreset == 6)
		{
			GameObject val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-13.6f, 20.69f, -24f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-12f, 20.35f, -24f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-10.4f, 20.01f, -24f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-8.8f, 19.66f, -24f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-13.6f, 20.69f, -21.67f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-12f, 20.35f, -21.67f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-10.4f, 20.01f, -21.67f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-8.8f, 19.66f, -21.67f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-2.166f, 19.66f, -14.94f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-2.166f, 19.66f, -17.98f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsCrossbowArea.Add(val5);
		}
	}

	public void DestroyCrossbowArea()
	{
		foreach (GameObject item in ExtraTrapsCrossbowArea)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsCrossbowArea.Clear();
	}

	public void PlaceCowlegArea()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		LjusstakeCellar.SetActive(true);
		if (CowlegRoomPreset == 1)
		{
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-8.16f, 15.3f, -22.5f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(1.59f, 14.2f, -20.46f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(1.59f, 14.2f, -20.24f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-6.11f, 9f, -14.23f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (CowlegRoomPreset == 2)
		{
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(-4.3f, 16f, -40.76f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeYellow, GameObject.Find("SmallDoorParent (2)/SmallDoor").transform);
			val.transform.localPosition = new Vector3(-2.897999f, 8.970038f, 0.4998705f);
			val.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			val.transform.localScale = new Vector3(4.449785f, 5.131798f, 4.449785f);
			ExtraTrapsCowlegArea.Add(val);
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(0.4f, 9.5f, -14.69f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(-5.27f, 15.5f, -23.92f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-7.23f, 10.75f, -19.3f), Quaternion.Euler(0f, 90f, 0f)));
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.497f, 12.416f, -22.355f), Quaternion.Euler(0f, 130f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.416f, 12.416f, -23.78f), Quaternion.Euler(0f, 38f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.82f, 12.416f, -25.05f), Quaternion.Euler(0f, 117f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val);
		}
		else if (CowlegRoomPreset == 3)
		{
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-2.5f, 15.5f, -20.5f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-2.5f, 16.5f, -20.5f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(2.07f, 13.5f, -20.5f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(2.07f, 14.5f, -20.5f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (CowlegRoomPreset == 4)
		{
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-0.1f, 16.2f, -20.47f), Quaternion.Euler(0f, 180f, 0f)));
			GameObject val2 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-4.47f, 8.55f, -14.32f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3.9f;
			ExtraTrapsCowlegArea.Add(val2);
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(1.59f, 14.2f, -20.24f), Quaternion.Euler(0f, 0f, 0f)));
			val2 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-8.16f, 15.3f, -22.5f), Quaternion.Euler(0f, 90f, 0f));
			val2.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 15f;
			ExtraTrapsCowlegArea.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(-6.85f, 12.41f, -23.36f), Quaternion.Euler(90f, 90f, 0f));
			val2.transform.localScale = new Vector3(0.40933958f, 0.019751374f, 0.0415763f);
			ExtraTrapsCowlegArea.Add(val2);
		}
		else if (CowlegRoomPreset == 5)
		{
			GameObject val3 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(1.59f, 14.1f, -25.2f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<LaserBeamCyan>().LaserDistance = 3.3f;
			ExtraTrapsCowlegArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(1.59f, 14.1f, -20.46f), Quaternion.Euler(0f, 180f, 0f));
			val3.GetComponent<LaserBeamCyan>().LaserDistance = 0.45f;
			ExtraTrapsCowlegArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-4.47f, 8.55f, -14.32f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamCyan>().LaserDistance = 0.75f;
			ExtraTrapsCowlegArea.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-5.26f, 14.2f, -23.88f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamCyan>().LaserDistance = 2f;
			ExtraTrapsCowlegArea.Add(val3);
		}
		else if (CowlegRoomPreset == 6)
		{
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(-5.55f, 14.2f, -26.84f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsCowlegArea.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(1.8f, 10.73f, -18.14f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.97f, 12.416f, -23.172f), Quaternion.Euler(0f, 130f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.585f, 12.416f, -23.716f), Quaternion.Euler(0f, 38f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.902f, 12.416f, -24.38f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.585f, 12.416f, -21.315f), Quaternion.Euler(0f, 150f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.398f, 12.416f, -21.49f), Quaternion.Euler(0f, -101f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.6f, 12.416f, -22.5f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.417f, 12.416f, -19.062f), Quaternion.Euler(0f, -73.1f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.577f, 11.454f, -18.614f), Quaternion.Euler(0f, -73.1f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.555f, 9.6f, -19.59f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsCowlegArea.Add(val4);
			LjusstakeCellar.SetActive(false);
		}
	}

	public void DestroyCowlegArea()
	{
		foreach (GameObject item in ExtraTrapsCowlegArea)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsCowlegArea.Clear();
	}

	public void DestroySewerArea()
	{
		foreach (GameObject item in ExtraTrapsSewerArea)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsSewerArea.Clear();
	}

	public void PlaceSewerArea()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1023: Unknown result type (might be due to invalid IL or missing references)
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Unknown result type (might be due to invalid IL or missing references)
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		if (SewerPreset == 1)
		{
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-5.8f, 13.5f, -35f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-5.8f, 14.5f, -35f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-5.8f, 15.5f, -35f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-5.8f, 16.5f, -35f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-4.6f, 11.48f, -36.323f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-4.6f, 10.48f, -36.323f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-4.6f, 9.48f, -36.323f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-4.6f, 8.48f, -36.323f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (SewerPreset == 2)
		{
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-2.3f, 13.8f, -35f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 5f;
			ExtraTrapsSewerArea.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-4.9f, 13.8f, -35f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 5f;
			ExtraTrapsSewerArea.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-9.23f, 13.8f, -35f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 5f;
			ExtraTrapsSewerArea.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(0.6f, 8.96f, -36.32f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 7f;
			ExtraTrapsSewerArea.Add(val);
			val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(2.145f, 8.96f, -36.78f), Quaternion.Euler(0f, -90f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 16f;
			ExtraTrapsSewerArea.Add(val);
		}
		else if (SewerPreset == 3)
		{
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(0.6f, 8.96f, -36.32f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(8.72f, 13f, -30.75f), Quaternion.Euler(0f, -90f, 0f)));
			GameObject val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.93f, 12.38f, -33.22f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrimeYellow";
			ExtraTrapsSewerArea.Add(val2);
		}
		else if (SewerPreset == 4)
		{
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-9.3f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-9.9f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-10.5f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val3 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(-9.76f, 12.4f, -38.27f), Quaternion.Euler(90f, 0f, 0f));
			val3.transform.localScale = new Vector3(0.1156056f, 0.039069653f, 0.0415763f);
			ExtraTrapsSewerArea.Add(val3);
		}
		else if (SewerPreset == 5)
		{
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-4f, 13.8f, -40.77f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-4.6f, 13.8f, -40.77f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-5.2f, 13.8f, -40.77f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-5.8f, 13.8f, -40.77f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-9.3f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-9.9f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsSewerArea.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-10.5f, 13.8f, -35.02f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val4 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(2.546f, 12.4f, -35.478f), Quaternion.Euler(90f, 0f, 0f));
			val4.transform.localScale = new Vector3(0.47103313f, 0.05408668f, 0.0415763f);
			ExtraTrapsSewerArea.Add(val4);
		}
		else if (SewerPreset == 6)
		{
			GameObject val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-5f, 13.745f, -31.25f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-3.9f, 13.745f, -31.25f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-2.8f, 13.745f, -31.25f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-1.7f, 13.745f, -31.25f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-8.85f, 13.745f, -31.2f), Quaternion.Euler(0f, 90f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(-5.31f, 13.745f, -29.8f), Quaternion.Euler(0f, -90f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 2.5f;
			ExtraTrapsSewerArea.Add(val5);
		}
		else if (SewerPreset == 7)
		{
			GameObject val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.9f, 7.711f, -32.3f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.02f, 7.711f, -33.809f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.395f, 7.711f, -35.26f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.332f, 7.711f, -33.876f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.489f, 7.711f, -35.482f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.57f, 7.711f, -34.657f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.659f, 7.711f, -32.239f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.594f, 7.711f, -34f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.945f, 7.711f, -37.292f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.593f, 7.711f, -38.8f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.06f, 7.711f, -39.15f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.27f, 7.711f, -39.9f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.136f, 7.711f, -39.23f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.432f, 7.711f, -38.618f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsSewerArea.Add(val6);
		}
		else if (SewerPreset == 8)
		{
			GameObject val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.84f, 12.38f, -36.42f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.83f, 12.38f, -38.95f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.52f, 12.38f, -37.18f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.62f, 12.38f, -39.46f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.17f, 12.38f, -32.94f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.65f, 12.38f, -32.178f), Quaternion.Euler(0f, -90f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsSewerArea.Add(val7);
		}
	}

	public void PlaceKitchen()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		if (KitchenPreset == 1)
		{
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(5.75f, 15.5f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(5.25f, 15.5f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(4.75f, 15.5f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			GameObject val = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(13.7266f, 13.31f, 11.907f), Quaternion.Euler(90f, 0f, 0f));
			val.transform.localScale = new Vector3(0.41978905f, 0.025713671f, 0.0415763f);
			ExtraTrapsKitchen.Add(val);
		}
		else if (KitchenPreset == 2)
		{
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(6.37f, 14.63f, 4.83f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(6.37f, 14.63f, 2.83f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(6.37f, 14.63f, 0.83f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsKitchen.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(6.37f, 14.63f, -1.17f), Quaternion.Euler(0f, 90f, 0f)));
		}
		else if (KitchenPreset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(DangerZone, new Vector3(8.6314f, 13.31f, 3.5538f), Quaternion.Euler(90f, 0f, 0f));
			val2.transform.localScale = new Vector3(0.23863867f, 0.07617634f, 0.0415763f);
			ExtraTrapsKitchen.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(9.33f, 13.43f, 8.156f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 1f;
			ExtraTrapsKitchen.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.48f, 13.43f, 5.953f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 2f;
			ExtraTrapsKitchen.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(9.42f, 13.43f, 3.82f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 3f;
			ExtraTrapsKitchen.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.99f, 13.43f, 1.33f), Quaternion.Euler(0f, -90f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible2 = 4f;
			ExtraTrapsKitchen.Add(val2);
		}
		else if (KitchenPreset == 4)
		{
			GameObject val3 = Object.Instantiate<GameObject>(DangerZone, new Vector3(8.6314f, 13.31f, 3.5538f), Quaternion.Euler(90f, 0f, 0f));
			val3.transform.localScale = new Vector3(0.23863867f, 0.07617634f, 0.0415763f);
			ExtraTrapsKitchen.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.639f, 13.43f, 7.07f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible2 = 1f;
			ExtraTrapsKitchen.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.69f, 13.43f, 4.64f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible2 = 2f;
			ExtraTrapsKitchen.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(9.575f, 13.43f, 2.21f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible2 = 3f;
			ExtraTrapsKitchen.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.739f, 13.43f, -0.136f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible2 = 4f;
			ExtraTrapsKitchen.Add(val3);
		}
		else if (KitchenPreset == 5)
		{
			GameObject val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.37f, 14.63f, 6.83f), Quaternion.Euler(0f, 90f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 3.25f;
			ExtraTrapsKitchen.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.37f, 14.63f, 4.83f), Quaternion.Euler(0f, 90f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 3.25f;
			ExtraTrapsKitchen.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.37f, 14.63f, 2.83f), Quaternion.Euler(0f, 90f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 3.5f;
			ExtraTrapsKitchen.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.37f, 14.63f, 0.83f), Quaternion.Euler(0f, 90f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 3.5f;
			ExtraTrapsKitchen.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(6.37f, 14.63f, -1.17f), Quaternion.Euler(0f, 90f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 3.5f;
			ExtraTrapsKitchen.Add(val4);
			val4 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(10.359f, 16.07f, -5.1f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<LaserBeamCyan>().LaserDistance = 12f;
			ExtraTrapsKitchen.Add(val4);
		}
		else if (KitchenPreset == 6)
		{
			GameObject val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(19.455f, 15.3f, 13f), Quaternion.Euler(0f, -90f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 9f;
			ExtraTrapsKitchen.Add(val5);
			val5 = Object.Instantiate<GameObject>(LaserPrimeCyan, new Vector3(19.455f, 15.3f, 12.41f), Quaternion.Euler(0f, -90f, 0f));
			val5.GetComponent<LaserBeamCyan>().LaserDistance = 4f;
			ExtraTrapsKitchen.Add(val5);
		}
		else if (KitchenPreset == 7)
		{
			GameObject val6 = Object.Instantiate<GameObject>(LaserPrimeMarrow, GameObject.Find("KitchenDoor1Parent/KitchenDoor").transform);
			val6.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 12.5f;
			val6.transform.localPosition = new Vector3(0.01716714f, 5.858479f, 3.322586f);
			val6.transform.localRotation = Quaternion.Euler(0f, -90f, -90f);
			val6.transform.localScale = new Vector3(5.604484f, 2.720436f, 3.412621f);
			ExtraTrapsKitchen.Add(val6);
			val6 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(6.37f, 14.8f, 5.515f), Quaternion.Euler(0f, 90f, 0f));
			val6.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 12.5f;
			ExtraTrapsKitchen.Add(val6);
		}
		else if (KitchenPreset == 8)
		{
			GameObject val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.23f, 13.43f, 8.85f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsKitchen.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(7.23f, 13.43f, 7.3f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsKitchen.Add(val7);
			val7 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.721f, 13.43f, 8.85f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val7).name = "BearTrapPrimeNotClose";
			ExtraTrapsKitchen.Add(val7);
		}
	}

	public void DestroyKitchen()
	{
		foreach (GameObject item in ExtraTrapsKitchen)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsKitchen.Clear();
	}

	public void PlaceLivingRoom()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1008: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Unknown result type (might be due to invalid IL or missing references)
		//IL_1079: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		if (LivingRoomPreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.455f, 13.43f, -10.285f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.391f, 13.43f, -7.52f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.21f, 13.43f, -4.23f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.11f, 13.43f, -5.9f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.68f, 13.43f, -4.3f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.3f, 13.43f, -8.2f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.88f, 13.43f, -6.24f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.64f, 13.43f, -9.86f), Quaternion.Euler(0f, 0f, 0f));
			val.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val);
		}
		else if (LivingRoomPreset == 2)
		{
			GameObject val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.523f, 13.43f, -5f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.64f, 13.43f, -7.52f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.212f, 13.43f, -10.118f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.01f, 13.43f, -8.83f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.68f, 13.43f, -4.3f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.3f, 13.43f, -8.2f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.88f, 13.43f, -6.24f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.64f, 13.43f, -9.86f), Quaternion.Euler(0f, 0f, 0f));
			val2.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val2);
		}
		else if (LivingRoomPreset == 3)
		{
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.87f, 13.43f, -9.89f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.87f, 13.43f, -7.24f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.86f, 13.43f, -4.53f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.93f, 13.43f, -9.68f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.32f, 13.43f, -6.77f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.06f, 13.43f, -6.68f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.97f, 13.43f, -6.27f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.45f, 13.43f, -4f), Quaternion.Euler(0f, 0f, 0f));
			val3.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val3);
		}
		else if (LivingRoomPreset == 4)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.92f, 13.43f, -8.77f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.41f, 13.43f, -4.65f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.38f, 13.43f, -7.23f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.17f, 13.43f, -9.64f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.55f, 13.43f, -5.08f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.92f, 13.43f, -9.88f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-11.23f, 13.43f, -6.12f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.45f, 13.43f, -4f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val4);
		}
		else if (LivingRoomPreset == 5)
		{
			GameObject val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(5.01f, 13.43f, -6.44f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.63f, 13.43f, -9.12f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.14f, 13.43f, -5.77f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.48f, 13.43f, -8.96f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-4.88f, 13.43f, -7.39f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.31f, 13.43f, -4.58f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.17f, 13.43f, -10.03f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.37f, 13.43f, -5.44f), Quaternion.Euler(0f, 0f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val5);
		}
		else if (LivingRoomPreset == 6)
		{
			GameObject val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.85f, 13.43f, -5.72f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.94f, 13.43f, -8.51f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.66f, 13.43f, -9.94f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.87f, 13.43f, -6.11f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.49f, 13.43f, -8.32f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.12f, 13.43f, -4.39f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.44f, 13.43f, -9.17f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsLivingRoom.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.22f, 13.43f, -6.58f), Quaternion.Euler(0f, 0f, 0f));
			val6.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsLivingRoom.Add(val6);
		}
	}

	public void DestroyLivingRoom()
	{
		foreach (GameObject item in ExtraTrapsLivingRoom)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsLivingRoom.Clear();
	}

	public void PlaceStudyRoom()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		if (StudyRoomPreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-20.8f, 15.3f, 7.632f), Quaternion.Euler(0f, 90f, 0f));
			val.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 14f;
			ExtraTrapsStudyRoom.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-6.58f, 13.32f, 10.36f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsStudyRoom.Add(val);
		}
		else if (StudyRoomPreset == 2)
		{
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-7.525f, 15.3f, 8.79f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-16.25f, 15.3f, 13.99f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (StudyRoomPreset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.48f, 13.32f, 10.36f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsStudyRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.63f, 13.32f, 11.89f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsStudyRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.31f, 13.32f, 8.99f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrimeNotClose";
			ExtraTrapsStudyRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-15.88f, 13.32f, 10.16f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsStudyRoom.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.6f, 13.32f, 7.97f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsStudyRoom.Add(val2);
		}
		else if (StudyRoomPreset == 4)
		{
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-7.9f, 15.5f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-8.4f, 15.5f, 13.96f), Quaternion.Euler(0f, 180f, 0f)));
			GameObject val3 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(-13.86f, 13.31f, 13.05f), Quaternion.Euler(90f, 90f, 0f));
			val3.transform.localScale = new Vector3(0.10923076f, 0.04846442f, 0.0415763f);
			ExtraTrapsStudyRoom.Add(val3);
		}
		else if (StudyRoomPreset == 5)
		{
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-8.01f, 14.25f, 6.99f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-8.01f, 15.25f, 6.99f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-8.01f, 16.25f, 6.99f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-8.01f, 17.25f, 6.99f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsStudyRoom.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-8.01f, 18.25f, 6.99f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (StudyRoomPreset == 6)
		{
			GameObject val4 = Object.Instantiate<GameObject>(DangerZone, new Vector3(-15.2483f, 13.31f, 7.7794f), Quaternion.Euler(90f, 90f, 0f));
			val4.transform.localScale = new Vector3(0.5210871f, 0.083399445f, 0.0415763f);
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-9.7f, 13.43f, 6.37f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-10.79f, 13.43f, 10.62f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-12.3f, 13.43f, 4.965f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-13.31f, 13.43f, 9.85f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-14.87f, 13.43f, 6.371f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-15.88f, 13.43f, 10.16f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-18.1f, 13.43f, 8.19f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsStudyRoom.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-19.47f, 13.43f, 4.81f), Quaternion.Euler(0f, 0f, 0f));
			val4.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsStudyRoom.Add(val4);
		}
	}

	public void DestroyStudyRoom()
	{
		foreach (GameObject item in ExtraTrapsStudyRoom)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsStudyRoom.Clear();
	}

	public void PlaceBasement()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
		//IL_102e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_109f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Unknown result type (might be due to invalid IL or missing references)
		if (BasementPreset == 1)
		{
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(-7.13f, 8.791f, 0.138f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(8.36f, 11.3f, 7.34f), Quaternion.Euler(0f, -90f, 0f)));
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.9f, 7.47f, 7.37f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.9f, 7.47f, 7.37f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.1f, 7.47f, 7.37f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-2.4f, 7.47f, 8.94f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.6f, 7.47f, 8.94f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.6f, 7.47f, 8.94f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val);
		}
		else if (BasementPreset == 2)
		{
			GameObject val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.9f, 7.47f, 2.867f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsBasement.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-8.708f, 7.47f, 1.365f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsBasement.Add(val2);
			val2 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-7.9f, 7.47f, -0.125f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val2).name = "BearTrapPrime";
			ExtraTrapsBasement.Add(val2);
		}
		else if (BasementPreset == 3)
		{
			GameObject val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-7.16f, 8.791f, 0.15f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-9.44f, 8.791f, 0.15f), Quaternion.Euler(0f, 90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-7.16f, 8.791f, 1.9f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-9.44f, 8.791f, 1.9f), Quaternion.Euler(0f, 90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-7.16f, 8.791f, 3.65f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-9.44f, 8.791f, 3.65f), Quaternion.Euler(0f, 90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-7.16f, 8.791f, 5.4f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(-9.44f, 8.791f, 5.4f), Quaternion.Euler(0f, 90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 3f;
			ExtraTrapsBasement.Add(val3);
			val3 = Object.Instantiate<GameObject>(LaserPrimeMarrow, new Vector3(7.9f, 8.791f, 0.254f), Quaternion.Euler(0f, -90f, 0f));
			val3.GetComponent<LaserBeamMarrow>().LaserDistanceMax = 13f;
			ExtraTrapsBasement.Add(val3);
		}
		else if (BasementPreset == 4)
		{
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(8.356f, 11.3f, 0.5f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(2.5f, 9f, 6.3f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(1f, 9f, 6.3f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-0.5f, 9f, 6.3f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-2f, 9f, 6.3f), Quaternion.Euler(0f, 180f, 0f)));
		}
		else if (BasementPreset == 5)
		{
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.19f, 12.5f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.19f, 11.5f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.19f, 10.5f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.19f, 9.5f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(-7.19f, 8.5f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
		}
		else if (BasementPreset == 6)
		{
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserPrimeYellow, new Vector3(-7.19f, 9.25f, 6.2f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBasement.Add(Object.Instantiate<GameObject>(LaserYellowActivation, new Vector3(8.36f, 11.3f, -7.6f), Quaternion.Euler(0f, -90f, 0f)));
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.174f, 7.47f, -0.05f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.174f, 7.47f, -1.637f), Quaternion.Euler(0f, -50.11f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.866f, 7.47f, -2.948f), Quaternion.Euler(0f, -137.25f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.483f, 7.47f, -4.506f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-5.57f, 7.47f, -5.833f), Quaternion.Euler(0f, 221f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.079f, 7.47f, -6.33f), Quaternion.Euler(0f, -24.6f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.259f, 7.47f, -7.385f), Quaternion.Euler(0f, -146.5f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.719f, 7.47f, -2.203f), Quaternion.Euler(0f, -102f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.306f, 7.47f, 0.01f), Quaternion.Euler(0f, 17f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.101f, 7.47f, 2.47f), Quaternion.Euler(0f, 122.6f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.97f, 7.47f, 0.01f), Quaternion.Euler(0f, -21f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.256f, 7.47f, -1.17f), Quaternion.Euler(0f, 122.6f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.256f, 7.47f, 2.049f), Quaternion.Euler(0f, -152.6f, 0f));
			((Object)val4).name = "BearTrapPrimeYellow";
			ExtraTrapsBasement.Add(val4);
		}
		else if (BasementPreset == 7)
		{
			GameObject val5 = Object.Instantiate<GameObject>(DangerZone, new Vector3(1.2419f, 7.47f, -0.898f), Quaternion.Euler(90f, 90f, 0f));
			val5.transform.localScale = new Vector3(0.6538055f, 0.05641749f, 0.0415763f);
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.49f, 7.47f, 2.992f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 1f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(2.76f, 7.47f, 2.61f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 2f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(0.362f, 7.47f, 1.09f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 3f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(3.548f, 7.47f, 0.46f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 4f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.526f, 7.47f, -1.03f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 5f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(4.61f, 7.47f, -2.11f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 6f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(1.023f, 7.47f, -3.515f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 7f;
			ExtraTrapsBasement.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-1.13f, 7.47f, -4.8f), Quaternion.Euler(0f, 180f, 0f));
			val5.GetComponent<BearTrap>().timerInvisible = 8f;
			ExtraTrapsBasement.Add(val5);
		}
	}

	public void DestroyBasement()
	{
		foreach (GameObject item in ExtraTrapsBasement)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsBasement.Clear();
	}

	public void PlaceGarage()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		if (GaragePreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.24f, 1.64f, 5.83f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsGarage.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.24f, 1.64f, 4.33f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsGarage.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-0.24f, 1.64f, 2.83f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsGarage.Add(val);
		}
		else if (GaragePreset == 2)
		{
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-3.9f, 3.43f, -6.8f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-4.4f, 3.43f, -6.8f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val2 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(2.978f, 1.62f, -3.66f), Quaternion.Euler(90f, 90f, 0f));
			val2.transform.localScale = new Vector3(0.2219f, 0.03474033f, 0.0415763f);
			ExtraTrapsGarage.Add(val2);
		}
		else if (GaragePreset == 3)
		{
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(9.3f, 2.5f, -6.79f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(9.3f, 3.5f, -6.79f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(9.3f, 4.5f, -6.79f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(9.3f, 5.5f, -6.79f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(9.3f, 6.5f, -6.79f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.05f, 1.64f, -0.86f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsGarage.Add(val3);
			val3 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(8.05f, 1.64f, 0.86f), Quaternion.Euler(0f, 0f, 0f));
			((Object)val3).name = "BearTrapPrimeNotClose";
			ExtraTrapsGarage.Add(val3);
		}
		else if (GaragePreset == 4)
		{
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-6.7f, 3.055f, -6.74f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(-6.2f, 3.055f, -6.74f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-6.7f, 4.71f, -6.74f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-6.2f, 4.71f, -6.74f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(0.3f, 4.26f, 6.685f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(1.8f, 4.26f, 6.685f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(3.3f, 4.26f, 6.685f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(4.8f, 4.26f, 6.685f), Quaternion.Euler(0f, 180f, 0f)));
			if (!LockerAnimationPlayed)
			{
				GameObject.Find("MetalLockerDoor").GetComponent<AudioSource>().volume = 0f;
				GameObject.Find("MetalLockerDoor").GetComponent<Animation>().Play("Garde1Open");
				LockerAnimationPlayed = true;
			}
		}
		else if (GaragePreset == 5)
		{
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-3.9f, 3.43f, -6.8f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimeGreen, new Vector3(-4.4f, 3.43f, -6.8f), Quaternion.Euler(0f, 0f, 0f)));
			GameObject val4 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(9.348f, 1.62f, -1.2264f), Quaternion.Euler(90f, 0f, 0f));
			val4.transform.localScale = new Vector3(0.1981887f, 0.08408497f, 0.0415763f);
			ExtraTrapsGarage.Add(val4);
		}
		else if (GaragePreset == 6)
		{
			GameObject val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.82f, 1.64f, 0.86f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val5).name = "BearTrapPrimeNotClose";
			ExtraTrapsGarage.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(-3.82f, 1.64f, -0.86f), Quaternion.Euler(0f, 180f, 0f));
			((Object)val5).name = "BearTrapPrimeNotClose";
			ExtraTrapsGarage.Add(val5);
		}
		else if (GaragePreset == 7)
		{
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 2.832f, 0.217f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 3.6f, 1.355f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 4.35f, 2.492f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 5.148f, 3.613f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 6.1f, 4.76f), Quaternion.Euler(0f, 90f, 0f)));
			ExtraTrapsGarage.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(-4.638f, 6.666f, 5.84f), Quaternion.Euler(0f, 90f, 0f)));
		}
	}

	public void DestroyGarage()
	{
		foreach (GameObject item in ExtraTrapsGarage)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsGarage.Clear();
	}

	public void PlaceBackyard()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		if (BackYardPreset == 1)
		{
			GameObject val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(14.13f, 11.8f, -16.74f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(21.17f, 11.8f, -24.952f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val);
			val = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(20.34f, 11.8f, -26.187f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val);
		}
		else if (BackYardPreset == 2)
		{
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(17.2f, 13f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(17.2f, 14f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(17.2f, 15f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(17.2f, 16f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(17.2f, 17f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(22.5f, 13f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(22.5f, 14f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(22.5f, 15f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(22.5f, 16f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(22.5f, 17f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(28.2f, 13f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(28.2f, 14f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(28.2f, 15f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(28.2f, 16f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeBlue, new Vector3(28.2f, 17f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
		}
		else if (BackYardPreset == 3)
		{
			GameObject val2 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(25f, 11.79f, -17.32f), Quaternion.Euler(90f, 38f, 0f));
			val2.transform.localScale = new Vector3(0.11050239f, 0.027058812f, 0.0415763f);
			ExtraTrapsBackyard.Add(val2);
			val2 = Object.Instantiate<GameObject>(LaserGreenActivation, new Vector3(30.6712f, 11.79f, -6.6614f), Quaternion.Euler(90f, 90f, 0f));
			val2.transform.localScale = new Vector3(0.4808358f, 0.05090151f, 0.0415763f);
			ExtraTrapsBackyard.Add(val2);
		}
		else if (BackYardPreset == 4)
		{
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(29.149f, 12.519f, -22.96f), Quaternion.Euler(0f, -90f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(29.2f, 12.9f, -2.5f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(15.74f, 13.53f, -12.78f), Quaternion.Euler(0f, 180f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimePurple, new Vector3(34.79f, 14.7f, -11.86f), Quaternion.Euler(0f, -90f, 0f)));
			GameObject val3 = Object.Instantiate<GameObject>(LaserPrimePurple, GameObject.Find("LekhusDoor").transform);
			val3.transform.SetParent(GameObject.Find("LekhusDoor").transform);
			val3.transform.localPosition = new Vector3(4.8f, 0.37f, 0.05f);
			val3.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			val3.transform.localScale = new Vector3(4.4315987f, 4.4315968f, 7.4926176f);
			ExtraTrapsBackyard.Add(val3);
		}
		else if (BackYardPreset == 5)
		{
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(17.2f, 14.7f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(22.5f, 14.7f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(28.2f, 14.7f, -26.97f), Quaternion.Euler(0f, 0f, 0f)));
			ExtraTrapsBackyard.Add(Object.Instantiate<GameObject>(LaserPrimeRed, new Vector3(34.787f, 14.7f, -11.86f), Quaternion.Euler(0f, -90f, 0f)));
		}
		else if (BackYardPreset == 6)
		{
			GameObject val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(30.179f, 11.8f, -11.72f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(31.649f, 11.8f, -11.72f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(32.52f, 11.8f, -17.43f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val4);
			val4 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(33.99f, 11.8f, -17.43f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val4).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val4);
		}
		else if (BackYardPreset == 7)
		{
			GameObject val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(15.28f, 11.8f, -17.5f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(18.46f, 11.8f, -21.96f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(14.69f, 11.8f, -20.71f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(17.19f, 11.8f, -24.15f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(17.32f, 11.8f, -19.43f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrimeNotClose";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(17.82f, 11.8f, -16.92f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
			val5 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(20.38f, 11.8f, -19.48f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val5).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val5);
		}
		else if (BackYardPreset == 8)
		{
			GameObject val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(22.66f, 11.8f, -25.636f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(24.12f, 11.8f, -23.511f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(25.11f, 11.8f, -24.79f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(24.85f, 11.8f, -18.8f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(27.6f, 11.8f, -25.99f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(27.33f, 11.8f, -18.84f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(29.39f, 11.8f, -20.01f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(28.12f, 11.8f, -16.27f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(31.88f, 11.8f, -18.59f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(30.7f, 11.8f, -16.42f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(29.81f, 11.8f, -13.83f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
			val6 = Object.Instantiate<GameObject>(Granny.GetComponent<EnemyAIGranny>().bearTrap, new Vector3(31.96f, 11.8f, -12.13f), Quaternion.Euler(0f, 90f, 0f));
			((Object)val6).name = "BearTrapPrime";
			ExtraTrapsBackyard.Add(val6);
		}
	}

	public void DestroyBackyard()
	{
		foreach (GameObject item in ExtraTrapsBackyard)
		{
			Object.DestroyImmediate((Object)(object)item);
		}
		ExtraTrapsBackyard.Clear();
	}
}
