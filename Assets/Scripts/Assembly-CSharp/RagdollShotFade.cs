using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class RagdollShotFade : MonoBehaviour
{
	public GameObject gameController;

	public bool ragdollFade;

	public Shader shader1;

	public Shader shader2;

	public Renderer rend;

	public GameObject ragdollTexture;

	public GameObject leg1Texture;

	public GameObject leg2Texture;

	public GameObject Hair;

	public GameObject Eyes;

	public GameObject Tand;

	public GameObject Bat;

	public float fadeStartTime;

	public float timerCount;

	public bool checkFadeEarly;

	public RagdollShotFade()
	{
		ragdollFade = true;
		timerCount = 5f;
		checkFadeEarly = true;
	}

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		shader2 = Shader.Find("Legacy Shaders/Transparent/VertexLit");
		if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			yield return (object)new WaitForSeconds(10f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			yield return (object)new WaitForSeconds(0f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			yield return (object)new WaitForSeconds(15f);
		}
		else
		{
			yield return (object)new WaitForSeconds(25f);
		}
		ragdollFade = true;
	}

	public virtual void Update()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).playerFallDead)
		{
			ragdollFade = true;
		}
		if (ragdollFade)
		{
			timerCount -= Time.deltaTime;
			Bat.SetActive(false);
			Eyes.SetActive(false);
			Tand.SetActive(false);
			leg1Texture.SetActive(false);
			leg2Texture.SetActive(false);
			((Component)rend).GetComponent<Renderer>().material.shader = shader2;
			float a = ragdollTexture.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
			Color color = ragdollTexture.GetComponent<Renderer>().material.color;
			color.a = a;
			ragdollTexture.GetComponent<Renderer>().material.color = color;
			float a2 = Hair.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
			Color color2 = Hair.GetComponent<Renderer>().material.color;
			color2.a = a2;
			Hair.GetComponent<Renderer>().material.color = color2;
		}
		if (timerCount < 0f)
		{
			ragdollFade = false;
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).setTime2();
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).startTimer2 = true;
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
