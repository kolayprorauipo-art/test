using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class theEndCarEscape : MonoBehaviour
{
	public GameObject GameController;

	public GameObject theEndText;

	public Image theEndTexture;

	public float fadeTextSpeed;

	public float time;

	public float time2;

	public GameObject GrannyHuntMusicHolder;

	public GameObject EndAnomalyText;

	public Resources c;

	public bool newEnd;

	public virtual IEnumerator Start()
	{
		((fadeUpDownGrannyHunt)(object)GrannyHuntMusicHolder.GetComponent(typeof(fadeUpDownGrannyHunt))).grannyDead = true;
		yield return (object)new WaitForSeconds(time);
		theEndText.SetActive(true);
		if (PlayerPrefs.GetInt("EventTrap") == 1)
		{
			PlayerPrefs.SetInt("EventCompleted", 1);
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 9 && Object.op_Implicit((Object)(object)GameObject.Find("CrowParent")))
		{
			EndAnomalyText = DefaultControls.CreateText(c);
			EndAnomalyText.transform.SetParent(GameObject.Find("All days texter").GetComponent<Transform>());
			((Graphic)EndAnomalyText.GetComponent<Text>()).color = Color.white;
			EndAnomalyText.GetComponent<Text>().resizeTextForBestFit = true;
			EndAnomalyText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			EndAnomalyText.GetComponent<Text>().fontSize = 0;
			EndAnomalyText.GetComponent<Text>().fontStyle = (FontStyle)3;
			EndAnomalyText.GetComponent<Text>().text = "Wow, I can't believe the crow instantly healed the moment I escaped! How is that possible?";
			EndAnomalyText.GetComponent<Text>().resizeTextMaxSize = 56;
			EndAnomalyText.GetComponent<Text>().alignment = (TextAnchor)4;
			EndAnomalyText.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			EndAnomalyText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			EndAnomalyText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			EndAnomalyText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 80f);
			((Graphic)theEndText.GetComponent<Image>()).color = Color.magenta;
		}
		yield return (object)new WaitForSeconds(time2);
		((FetchAds)(object)GameController.GetComponent(typeof(FetchAds))).toMainMenu();
		PlayerPrefs.SetInt("teddyInPlace", 0);
	}
}
