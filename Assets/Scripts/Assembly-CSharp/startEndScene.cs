using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class startEndScene : MonoBehaviour
{
	public float fadeBlackSpeed;

	public Image blackScreen;

	public float fogEndDistance;

	public bool fog;

	public Shader AbondonedShader;

	public GameObject granny1;

	public GameObject granny1Anim;

	public GameObject granny2;

	public GameObject granny2Gone;

	public GameObject granny3Home;

	public GameObject GrannyGoneTeddy;

	public GameObject teddy;

	public GameObject cam1;

	public GameObject cam2;

	public GameObject grannyAnim;

	public GameObject soundEffects;

	public GameObject slendrinaTexture;

	public float fadeSpeed;

	public bool slendrinaFade;

	public GameObject theEndText1;

	public GameObject theEndText2;

	public GameObject EndAnomalyText;

	public Resources c;

	public virtual void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)GameObject.Find("BlackScreenStart").GetComponent<Image>()).color = Color.black;
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				RenderSettings.fogColor = Color.white;
				cam1.GetComponent<Camera>().backgroundColor = Color.white;
				cam2.GetComponent<Camera>().backgroundColor = Color.white;
				((Renderer)theEndText1.GetComponent<MeshRenderer>()).material.color = Color.black;
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				RenderSettings.fogColor = Color.red;
				cam1.GetComponent<Camera>().backgroundColor = Color.red;
				cam2.GetComponent<Camera>().backgroundColor = Color.red;
				((Renderer)theEndText1.GetComponent<MeshRenderer>()).material.color = Color.black;
			}
			PlayerPrefs.SetInt("teddyInPlace", 0);
			((MonoBehaviour)this).StartCoroutine(startTheEnd1());
			return;
		}
		if (PlayerPrefs.GetInt("Anomaly41Ending") == 1)
		{
			cam1.gameObject.AddComponent<Anomaly41MirrorCamera>();
			cam2.gameObject.AddComponent<Anomaly41MirrorCamera>();
		}
		if (PlayerPrefs.GetInt("Anomaly45Ending") == 1)
		{
			Scene activeScene = SceneManager.GetActiveScene();
			GameObject[] rootGameObjects = activeScene.GetRootGameObjects();
			for (int i = 0; i < rootGameObjects.Length; i++)
			{
				MeshRenderer[] componentsInChildren = rootGameObjects[i].GetComponentsInChildren<MeshRenderer>(true);
				foreach (MeshRenderer obj in componentsInChildren)
				{
					((Renderer)((Component)obj).GetComponent<MeshRenderer>()).material = new Material(Shader.Find("Legacy Shaders/Transparent/VertexLit"));
					((Renderer)((Component)obj).GetComponent<MeshRenderer>()).material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 0.3f);
				}
			}
		}
		if (PlayerPrefs.GetInt("teddyInPlace") == 1)
		{
			((MonoBehaviour)this).StartCoroutine(startTheEnd2());
			AchievementSaveManager.Instance.UnlockAchievement("FamilyFriendly");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(startTheEnd1());
		}
	}

	public virtual void Update()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (fog)
		{
			RenderSettings.fogEndDistance -= Time.deltaTime * 9f;
			if (RenderSettings.fogEndDistance <= 0f)
			{
				fog = false;
				RenderSettings.fogEndDistance = 0f;
			}
		}
		if (slendrinaFade)
		{
			float a = slendrinaTexture.GetComponent<Renderer>().material.color.a - 0.3f * Time.deltaTime * fadeSpeed;
			Color color = slendrinaTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			slendrinaTexture.GetComponent<Renderer>().material.color = color;
		}
	}

	public virtual IEnumerator startTheEnd1()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			granny1.SetActive(false);
			granny3Home.SetActive(true);
			theEndText2.SetActive(true);
		}
		else
		{
			granny1.SetActive(true);
			if (PlayerPrefs.GetInt("Anomaly9Escape") == 1 || PlayerPrefs.GetInt("Anomaly13Escape") == 1 || PlayerPrefs.GetInt("Anomaly94Escape") == 1)
			{
				granny1.SetActive(false);
			}
			if (PlayerPrefs.GetInt("Anomaly9Escape") == 1 || PlayerPrefs.GetInt("Anomaly13Escape") == 1 || PlayerPrefs.GetInt("Anomaly94Escape") == 1 || PlayerPrefs.GetInt("Anomaly18Escape") == 1 || PlayerPrefs.GetInt("Anomaly18CrowEscape") == 1 || PlayerPrefs.GetInt("Anomaly27DoorEscape") == 1)
			{
				((Renderer)(MeshRenderer)theEndText1.GetComponent(typeof(MeshRenderer))).material.SetColor("_Color", Color.magenta);
			}
			theEndText1.SetActive(true);
			if (PlayerPrefs.GetInt("Anomaly18CrowEscape") == 1 || PlayerPrefs.GetInt("Anomaly27DoorEscape") == 1)
			{
				((Renderer)GameObject.Find("Eyes").GetComponent<MeshRenderer>()).material.SetColor("_Color", Color.red);
			}
		}
		cam1.SetActive(true);
		granny2.SetActive(false);
		cam2.SetActive(false);
		((Graphic)blackScreen).CrossFadeAlpha(0f, 3f, false);
		yield return (object)new WaitForSeconds(7f);
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			fog = true;
		}
		yield return (object)new WaitForSeconds(2f);
		if (PlayerPrefs.GetInt("DiffData") != 4 && PlayerPrefs.GetInt("DiffData") != 7 && PlayerPrefs.GetInt("Anomaly9Escape") != 1 && PlayerPrefs.GetInt("Anomaly13Escape") != 1 && PlayerPrefs.GetInt("Anomaly94Escape") != 1 && PlayerPrefs.GetInt("Anomaly18Escape") != 1)
		{
			granny1Anim.GetComponent<Animation>().Play("GrannyMoveCamera");
			grannyAnim.GetComponent<Animation>().Play("idle");
		}
		yield return (object)new WaitForSeconds(1f);
		if (PlayerPrefs.GetInt("DiffData") != 4 && PlayerPrefs.GetInt("DiffData") != 7 && PlayerPrefs.GetInt("Anomaly9Escape") != 1 && PlayerPrefs.GetInt("Anomaly13Escape") != 1 && PlayerPrefs.GetInt("Anomaly94Escape") != 1 && PlayerPrefs.GetInt("Anomaly18Escape") != 1)
		{
			soundEffects.SetActive(true);
		}
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			yield return (object)new WaitForSeconds(6f);
		}
		fadeBlackSpeed = 0.6f;
		((Graphic)blackScreen).CrossFadeAlpha(1f, 3f, false);
		if ((PlayerPrefs.GetInt("Anomaly9Escape") == 1 || PlayerPrefs.GetInt("Anomaly13Escape") == 1 || PlayerPrefs.GetInt("Anomaly94Escape") == 1 || PlayerPrefs.GetInt("Anomaly18Escape") == 1 || PlayerPrefs.GetInt("Anomaly18CrowEscape") == 1 || PlayerPrefs.GetInt("Anomaly27DoorEscape") == 1) && PlayerPrefs.GetInt("DiffData") != 4)
		{
			EndAnomalyText = DefaultControls.CreateText(c);
			EndAnomalyText.transform.SetParent(GameObject.Find("BlackScreenStartParent").GetComponent<Transform>());
			((Graphic)EndAnomalyText.GetComponent<Text>()).color = Color.white;
			EndAnomalyText.GetComponent<Text>().resizeTextForBestFit = true;
			EndAnomalyText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EndAnomalyText.GetComponent<Text>().fontSize = 0;
			EndAnomalyText.GetComponent<Text>().fontStyle = (FontStyle)3;
			EndAnomalyText.GetComponent<Text>().text = "It feels like... the Crow is very grateful to me";
			EndAnomalyText.GetComponent<Text>().resizeTextMaxSize = 56;
			EndAnomalyText.GetComponent<Text>().alignment = (TextAnchor)4;
			EndAnomalyText.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			EndAnomalyText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			EndAnomalyText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			EndAnomalyText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 0f);
			if (PlayerPrefs.GetInt("Anomaly13Escape") == 1)
			{
				EndAnomalyText.GetComponent<Text>().text = "You did a good deed, and Granny let you go. Granny is very kind because of the anomaly";
			}
			if (PlayerPrefs.GetInt("Anomaly94Escape") == 1)
			{
				EndAnomalyText.GetComponent<Text>().text = "MelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelonMelon";
				((Graphic)EndAnomalyText.GetComponent<Text>()).color = Color.green;
			}
			if (PlayerPrefs.GetInt("Anomaly18Escape") == 1)
			{
				EndAnomalyText.GetComponent<Text>().text = "During your exploration of the past, you didn't uncover anything interesting and successfully returned to the present, escaping the house. Congratulations!";
			}
			if (PlayerPrefs.GetInt("Anomaly18CrowEscape") == 1)
			{
				EndAnomalyText.GetComponent<Text>().text = "During the exploration of the past, you decided to poison the birdseed, as instructed in the note. It turned out that she has a pet, which she fed the poisoned seed to";
			}
			if (PlayerPrefs.GetInt("Anomaly27DoorEscape") == 1)
			{
				EndAnomalyText.GetComponent<Text>().text = "Hey! You lacked patience. I don't need those who have no patience, but have cruelty...";
			}
		}
		yield return (object)new WaitForSeconds(4f);
		PlayerPrefs.SetInt("Anomaly9Escape", 0);
		PlayerPrefs.SetInt("Anomaly13Escape", 0);
		PlayerPrefs.SetInt("Anomaly94Escape", 0);
		PlayerPrefs.SetInt("Anomaly18Escape", 0);
		PlayerPrefs.SetInt("Anomaly18CrowEscape", 0);
		PlayerPrefs.SetInt("Anomaly27DoorEscape", 0);
		yield return (object)new WaitForSeconds(1f);
		readyToMainMenu();
	}

	public virtual IEnumerator startTheEnd2()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			granny2.SetActive(true);
			GrannyGoneTeddy.SetActive(true);
			granny2Gone.SetActive(false);
			teddy.SetActive(false);
			granny3Home.SetActive(true);
			theEndText2.SetActive(true);
		}
		else
		{
			granny2.SetActive(true);
			theEndText1.SetActive(true);
			GrannyGoneTeddy.SetActive(false);
			teddy.SetActive(true);
		}
		cam2.SetActive(true);
		granny1.SetActive(false);
		cam1.SetActive(false);
		((Graphic)blackScreen).CrossFadeAlpha(0f, 3f, false);
		yield return (object)new WaitForSeconds(7f);
		slendrinaFade = true;
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			fog = true;
		}
		yield return (object)new WaitForSeconds(3f);
		PlayerPrefs.SetInt("teddyInPlace", 0);
		fadeBlackSpeed = 0.6f;
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			yield return (object)new WaitForSeconds(6f);
		}
		((Graphic)blackScreen).CrossFadeAlpha(1f, 3f, false);
		yield return (object)new WaitForSeconds(7f);
		readyToMainMenu();
	}

	private void InterstitialAdClosedEvent()
	{
		readyToMainMenu();
	}

	public virtual void readyToMainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scene 1");
	}
}
