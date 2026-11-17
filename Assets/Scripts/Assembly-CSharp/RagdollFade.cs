using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class RagdollFade : MonoBehaviour
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

	public RagdollFade()
	{
		ragdollFade = true;
		checkFadeEarly = true;
	}

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		shader2 = Shader.Find("Legacy Shaders/Transparent/VertexLit");
		if (PlayerPrefs.GetInt("DiffData") == 6 || (PlayerPrefs.GetInt("DiffData") == 7 && GameObject.Find("GameController").GetComponent<startNewDay>().PrimeAnomalyNR != 15))
		{
			timerCount = 1f;
		}
		else
		{
			timerCount = 5f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			yield return (object)new WaitForSeconds(10f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			yield return (object)new WaitForSeconds(2.5f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
		{
			yield return (object)new WaitForSeconds(0f);
		}
		else
		{
			yield return (object)new WaitForSeconds(25f);
		}
		ragdollFade = true;
	}

	public virtual void Update()
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		if (((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).playerFallDead)
		{
			ragdollFade = true;
		}
		if (ragdollFade)
		{
			if (PlayerPrefs.GetInt("DiffData") == 6 || (PlayerPrefs.GetInt("DiffData") == 7 && GameObject.Find("GameController").GetComponent<startNewDay>().PrimeAnomalyNR != 15))
			{
				timerCount -= Time.deltaTime;
				Bat.SetActive(false);
				Eyes.SetActive(false);
				Tand.SetActive(false);
				leg1Texture.SetActive(false);
				leg2Texture.SetActive(false);
				((Component)rend).GetComponent<Renderer>().material.shader = shader2;
				float a = ragdollTexture.GetComponent<Renderer>().material.color.a - Time.deltaTime;
				Color color = ragdollTexture.GetComponent<Renderer>().material.color;
				color.a = a;
				ragdollTexture.GetComponent<Renderer>().material.color = color;
				float a2 = Hair.GetComponent<Renderer>().material.color.a - Time.deltaTime;
				Color color2 = Hair.GetComponent<Renderer>().material.color;
				color2.a = a2;
				Hair.GetComponent<Renderer>().material.color = color2;
			}
			else
			{
				timerCount -= Time.deltaTime;
				Bat.SetActive(false);
				Eyes.SetActive(false);
				Tand.SetActive(false);
				leg1Texture.SetActive(false);
				leg2Texture.SetActive(false);
				((Component)rend).GetComponent<Renderer>().material.shader = shader2;
				float a3 = ragdollTexture.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
				Color color3 = ragdollTexture.GetComponent<Renderer>().material.color;
				color3.a = a3;
				ragdollTexture.GetComponent<Renderer>().material.color = color3;
				float a4 = Hair.GetComponent<Renderer>().material.color.a - 0.2f * Time.deltaTime;
				Color color4 = Hair.GetComponent<Renderer>().material.color;
				color4.a = a4;
				Hair.GetComponent<Renderer>().material.color = color4;
			}
		}
		if (timerCount < 0f)
		{
			ragdollFade = false;
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).setTime();
			((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).startTimer = true;
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
