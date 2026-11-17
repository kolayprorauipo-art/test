using System;
using UnityEngine;

[Serializable]
public class teddyInVagga : MonoBehaviour
{
	public GameObject slendrina;

	public GameObject teddyTexture;

	public GameObject gameController;

	public GameObject granny;

	public bool fadeDown;

	public Shader shader1;

	public Renderer rend;

	public Transform GrannyStartPos;

	public bool fadeDown2;

	public bool Achievement1;

	public bool Achievement2;

	public bool Achievement3;

	public bool Achievement4;

	public virtual void Start()
	{
		shader1 = Shader.Find("Mobile/Transparent/Vertex Color");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		if (((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			return;
		}
		if (((Component)other).gameObject.tag == "teddy")
		{
			fadeDown = true;
			((Component)other).gameObject.tag = "Untagged";
			if (!((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow)
			{
				granny.SetActive(false);
				granny.transform.position = GrannyStartPos.position;
				granny.SetActive(true);
			}
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).slendrinaAppeard = true;
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				((MonoBehaviour)this).StartCoroutine(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TeddyPlayhouseAnomaly20());
			}
		}
		if (((Object)((Component)other).gameObject).name == "newTruePrimeTeddy(Clone)")
		{
			fadeDown2 = true;
			((Object)((Component)other).gameObject).name = "newTruePrimeTeddy(Unnamed)";
			if (!((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow)
			{
				granny.SetActive(false);
				granny.transform.position = GrannyStartPos.position;
				granny.SetActive(true);
			}
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).slendrinaAppeard = true;
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				((MonoBehaviour)this).StartCoroutine(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).TeddyPlayhouseAnomaly20());
			}
		}
		if (((Component)other).gameObject.tag == "remotecontrol")
		{
			Achievement1 = true;
		}
		if (((Object)((Component)other).gameObject).name.Contains("TeleportRemote"))
		{
			Achievement2 = true;
		}
		if (((Component)other).gameObject.tag == "vitrindoorRopen")
		{
			Achievement3 = true;
		}
		if (((Object)((Component)other).gameObject).name.Contains("NightmareRemote"))
		{
			Achievement4 = true;
		}
		if (Achievement1 && Achievement2 && Achievement3 && Achievement4)
		{
			AchievementSaveManager.Instance.UnlockAchievement("HappyRemotesFamily");
		}
	}

	public virtual void Update()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		if (fadeDown && !((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			rend = GameObject.Find("Teddy(Clone)").GetComponent<Renderer>();
			teddyTexture = GameObject.Find("Teddy(Clone)");
			((Component)rend).GetComponent<Renderer>().material.shader = shader1;
			float a = teddyTexture.GetComponent<Renderer>().material.color.a - 0.3f * Time.deltaTime;
			Color color = teddyTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			teddyTexture.GetComponent<Renderer>().material.color = color;
			if (teddyTexture.GetComponent<Renderer>().material.color.a <= 0f)
			{
				fadeDown = false;
				slendrina.SetActive(true);
				Object.Destroy((Object)(object)teddyTexture);
				PlayerPrefs.SetInt("teddyInPlace", 1);
			}
		}
		if (fadeDown2 && !((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			rend = GameObject.Find("newTruePrimeTeddy(Unnamed)").GetComponent<Renderer>();
			teddyTexture = GameObject.Find("newTruePrimeTeddy(Unnamed)");
			((Component)rend).GetComponent<Renderer>().material.shader = shader1;
			float a2 = teddyTexture.GetComponent<Renderer>().material.color.a - 0.3f * Time.deltaTime;
			Color color2 = teddyTexture.GetComponent<Renderer>().material.color;
			color2.a = a2;
			teddyTexture.GetComponent<Renderer>().material.color = color2;
			if (teddyTexture.GetComponent<Renderer>().material.color.a <= 0f)
			{
				fadeDown = false;
				slendrina.SetActive(true);
				Object.Destroy((Object)(object)teddyTexture);
				PlayerPrefs.SetInt("teddyInPlace", 1);
			}
		}
	}
}
