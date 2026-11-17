using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ClickContinueButton2 : MonoBehaviour
{
	public GameObject LoadingScreen;

	public GameObject allButtons;

	public GameObject optionBackground;

	public GameObject ljudHolder;

	private bool buttonPressed;

	public Button btn1;

	public GameObject NewInputField;

	public Resources canvas;

	public GameObject NewTxt;

	public GameObject ContinueButton;

	public GameObject BackButton;

	public GameObject TrainingButton;

	public Toggle NerfedPrimeToggle;

	public Sprite TrainingTexture;

	public GameObject MusicDropdown;

	public Toggle NightmareMode;

	public GameObject TextScreenBild;

	public GameObject Bakgrundsbild;

	public string AnomalyText;

	private string[] optionNames = new string[5] { "ShowTimer", "ShowAttempts", "ShowProgress", "NerfedPrime", "EventChallenge3Reward" };

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	public void BacktoMenu()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)Bakgrundsbild.GetComponent<Image>()).color = Color.white;
		for (int num = GameObject.Find("TextScreen").transform.childCount - 1; num >= 4; num--)
		{
			Object.Destroy((Object)(object)((Component)GameObject.Find("TextScreen").transform.GetChild(num)).gameObject);
		}
		ContinueButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(6f, 65f);
		TextScreenBild.SetActive(true);
		MusicDropdown.SetActive(false);
		LoadingScreen.SetActive(false);
		optionBackground.SetActive(true);
		allButtons.SetActive(true);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	private void TaskOnClick()
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edc: Unknown result type (might be due to invalid IL or missing references)
		if (buttonPressed)
		{
			return;
		}
		TrainingTexture = GameObject.Find("OptionMenuParent/QualityText").GetComponent<Image>().sprite;
		LoadingScreen.SetActive(true);
		allButtons.SetActive(false);
		optionBackground.SetActive(false);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
		ContinueButton = GameObject.Find("ContinueButton");
		if (PlayerPrefs.GetInt("DiffData") != 7 && PlayerPrefs.GetInt("AnomalyOnOff") == 1)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewInputField = DefaultControls.CreateInputField(canvas);
			NewInputField.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewInputField.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 50f);
			NewInputField.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewInputField.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewInputField.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -90f);
			NewInputField.GetComponent<InputField>().contentType = (ContentType)2;
			NewInputField.GetComponent<InputField>().characterLimit = 4;
			if (PlayerPrefs.GetInt("NotFirstEverAnomaly") == 1)
			{
				NewInputField.GetComponent<InputField>().text = string.Concat(PlayerPrefs.GetInt("AnomalyNR"));
			}
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Leave here the number of the anomaly you want to play on (from 1 to 47). If you want a random anomaly, type «0»";
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 76;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 40f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = new Color(0.4157456f, 0f, 97f / 106f);
			GameObject.Find("TextScreen/InputField (Legacy)/Text (Legacy)").GetComponent<Text>().fontSize = 37;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0 && PlayerPrefs.GetInt("AnomalyOnOff") == 0)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Welcome to Prime! This challenge will only be conquered by the very best players, while the rest will suffer from everything happening in this house, even from the evil chair. Are you sure you're ready?\r\n\r\nHint: the chair is very evil and very fast, but it has no ears or eyes. Also, it won't be able to kill you if you crouch.\r\n\r\nAttempts: " + PlayerPrefs.GetInt("PrimeAttemps");
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 54;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 30f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = Color.red;
			TrainingButton = Object.Instantiate<GameObject>(ContinueButton, GameObject.Find("TextScreen").transform);
			TrainingButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-80f, 65f);
			TrainingButton.GetComponent<RectTransform>().sizeDelta = new Vector2(160f, 30f);
			TrainingButton.GetComponent<Image>().sprite = TrainingTexture;
			ContinueButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(86f, 65f);
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				MusicDropdown.SetActive(true);
			}
			CreateTogglesRow();
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1 && PlayerPrefs.GetInt("AnomalyOnOff") == 0)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Welcome to Prime+ (BETA)! If you had enough with evil chair, you can be happy, because it's now gone. However, there is something more terrifying in the house, which makes the escape almost impossible. Are you ready to die instantly?\r\n\r\nNote: This difficulty is from Prime Mode (PC version) and has almost no changes. But maybe there will be some special updates for this version of Prime Plus later.\r\n\r\nAttempts: " + PlayerPrefs.GetInt("PrimeAttemps");
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 54;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 30f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = Color.red;
			TrainingButton = Object.Instantiate<GameObject>(ContinueButton, GameObject.Find("TextScreen").transform);
			TrainingButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-80f, 65f);
			TrainingButton.GetComponent<RectTransform>().sizeDelta = new Vector2(160f, 30f);
			TrainingButton.GetComponent<Image>().sprite = TrainingTexture;
			ContinueButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(86f, 65f);
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				MusicDropdown.SetActive(true);
			}
			CreateTogglesRow();
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("AnomalyOnOff") == 1)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewInputField = DefaultControls.CreateInputField(canvas);
			NewInputField.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewInputField.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 50f);
			NewInputField.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewInputField.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewInputField.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -90f);
			NewInputField.GetComponent<InputField>().contentType = (ContentType)2;
			NewInputField.GetComponent<InputField>().characterLimit = 4;
			NewInputField.GetComponent<InputField>().text = string.Concat(PlayerPrefs.GetInt("PrimeAnomalyNR"));
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Leave here the number of the prime anomaly you want to play on (from 1 to 18).\r\nAttempts: " + PlayerPrefs.GetInt("PrimeAttemps");
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 76;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 40f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = Color.red;
			TrainingButton = Object.Instantiate<GameObject>(ContinueButton, GameObject.Find("TextScreen").transform);
			TrainingButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(-80f, 65f);
			TrainingButton.GetComponent<RectTransform>().sizeDelta = new Vector2(160f, 30f);
			TrainingButton.GetComponent<Image>().sprite = TrainingTexture;
			ContinueButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(86f, 65f);
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				MusicDropdown.SetActive(true);
			}
			CreateTogglesRow();
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Welcome to Event Challenge 2!\r\n\r\nHere, your goal is to collect 8 books and escape from the house. But with each book you collect, Granny becomes faster, there will be more rats in the house, and the house will get darker. Once you collect all the books, a green key will appear somewhere in the house. You will need it to unlock the main door and make your escape.\r\n\r\nAt the start of the game, there will be only one book in the house, but once you pick it up, another one will appear somewhere else and this will continue until you collect all 8 books. You also have 3 hints that can help you find a book or a green key. If you manage to escape, you will be rewarded with a new difficulty.\r\n\r\nThis event challenge is inspired by Granny Devour by Kadir. Good luck!";
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 46;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 30f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = Color.gray;
		}
		else if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			GameObject.Find("TextScreen/TextScreenBild").SetActive(false);
			((ClickPlayButton)(object)((Component)this).gameObject.GetComponent(typeof(ClickPlayButton))).optionbackground.SetActive(true);
			NewTxt = DefaultControls.CreateText(canvas);
			NewTxt.transform.SetParent(GameObject.Find("TextScreen").transform);
			NewTxt.GetComponent<Text>().text = "Welcome to Event Challenge 3!\r\n\r\nHere, your goal is to collect 200 melons and escape from the house. Melons will appear somewhere in the house constantly. But collecting 200 melons sounds very boring, so you can gamble. There are 4 buttons in the kitchen:\r\nYellow button: you can win or lose up to 25% of your melons. Cooldown lasts 1 minute.\r\nCyan button: you can win or lose up to 50% of your melons. Cooldown lasts 2 minutes.\r\nGreen button: you can win or lose up to 100% of your melons. Cooldown lasts 3 minutes.\r\nBlue button: you can win up to 300% of your melons or lose everything. But Granny becomes as fast as in Cruel mode. You can use this button only once.\r\n\r\nYou can also find melon lootboxes. Items don't make noises. When you escape you can find a reward in Prime difficulty.\r\n\r\nGood luck curing your gambling addiction after playing!";
			((Graphic)NewTxt.GetComponent<Text>()).color = Color.white;
			NewTxt.GetComponent<Text>().fontStyle = (FontStyle)1;
			NewTxt.GetComponent<Text>().resizeTextForBestFit = true;
			NewTxt.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
			NewTxt.GetComponent<Text>().fontSize = 0;
			NewTxt.GetComponent<Text>().resizeTextMaxSize = 46;
			NewTxt.GetComponent<Text>().alignment = (TextAnchor)4;
			NewTxt.GetComponent<RectTransform>().sizeDelta = new Vector2(1456f, 30f);
			NewTxt.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
			NewTxt.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, 30f);
			((Graphic)GameObject.Find("MenuOptionBackground/Bakgrundsbild").GetComponent<Image>()).color = Color.green;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "" || (NewInputField.GetComponent<InputField>().text != "0" && NewInputField.GetComponent<InputField>().text != "1" && NewInputField.GetComponent<InputField>().text != "2" && NewInputField.GetComponent<InputField>().text != "3" && NewInputField.GetComponent<InputField>().text != "4" && NewInputField.GetComponent<InputField>().text != "5" && NewInputField.GetComponent<InputField>().text != "6" && NewInputField.GetComponent<InputField>().text != "7" && NewInputField.GetComponent<InputField>().text != "8" && NewInputField.GetComponent<InputField>().text != "9" && NewInputField.GetComponent<InputField>().text != "10" && NewInputField.GetComponent<InputField>().text != "" && NewInputField.GetComponent<InputField>().text != "11" && NewInputField.GetComponent<InputField>().text != "12" && NewInputField.GetComponent<InputField>().text != "13" && NewInputField.GetComponent<InputField>().text != "14" && NewInputField.GetComponent<InputField>().text != "15" && NewInputField.GetComponent<InputField>().text != "16" && NewInputField.GetComponent<InputField>().text != "17" && NewInputField.GetComponent<InputField>().text != "18" && NewInputField.GetComponent<InputField>().text != "19" && NewInputField.GetComponent<InputField>().text != "20" && NewInputField.GetComponent<InputField>().text != "21" && NewInputField.GetComponent<InputField>().text != "22" && NewInputField.GetComponent<InputField>().text != "23" && NewInputField.GetComponent<InputField>().text != "24" && NewInputField.GetComponent<InputField>().text != "25" && NewInputField.GetComponent<InputField>().text != "26" && NewInputField.GetComponent<InputField>().text != "27" && NewInputField.GetComponent<InputField>().text != "28" && NewInputField.GetComponent<InputField>().text != "29" && NewInputField.GetComponent<InputField>().text != "30" && NewInputField.GetComponent<InputField>().text != "31" && NewInputField.GetComponent<InputField>().text != "32" && NewInputField.GetComponent<InputField>().text != "33" && NewInputField.GetComponent<InputField>().text != "34" && NewInputField.GetComponent<InputField>().text != "35" && NewInputField.GetComponent<InputField>().text != "37" && NewInputField.GetComponent<InputField>().text != "38" && NewInputField.GetComponent<InputField>().text != "39" && NewInputField.GetComponent<InputField>().text != "40" && NewInputField.GetComponent<InputField>().text != "41" && NewInputField.GetComponent<InputField>().text != "42" && NewInputField.GetComponent<InputField>().text != "43" && NewInputField.GetComponent<InputField>().text != "44" && NewInputField.GetComponent<InputField>().text != "45" && NewInputField.GetComponent<InputField>().text != "46" && NewInputField.GetComponent<InputField>().text != "47" && NewInputField.GetComponent<InputField>().text != "9191" && NewInputField.GetComponent<InputField>().text != "1405" && NewInputField.GetComponent<InputField>().text != "8841" && NewInputField.GetComponent<InputField>().text != "3991" && NewInputField.GetComponent<InputField>().text != "1793" && NewInputField.GetComponent<InputField>().text != "1000" && NewInputField.GetComponent<InputField>().text != "2134" && NewInputField.GetComponent<InputField>().text != "2025" && NewInputField.GetComponent<InputField>().text != "1954" && NewInputField.GetComponent<InputField>().text != "2202" && NewInputField.GetComponent<InputField>().text != "2311" && NewInputField.GetComponent<InputField>().text != "8228" && NewInputField.GetComponent<InputField>().text != "3103" && NewInputField.GetComponent<InputField>().text != "4542" && NewInputField.GetComponent<InputField>().text != "1305" && NewInputField.GetComponent<InputField>().text != "7102")))
			{
				NewTxt.GetComponent<Text>().text = "Leave here the number of the anomaly you want to play on (from 1 to 47). If you want a random anomaly, type «0»";
				ContinueButton.SetActive(false);
				BackButton.SetActive(false);
				return;
			}
			ContinueButton.SetActive(true);
			BackButton.SetActive(true);
			PlayerPrefs.SetInt("AnomalyNR", int.Parse(NewInputField.GetComponent<InputField>().text));
			if (NewInputField.GetComponent<InputField>().text == "0")
			{
				NewTxt.GetComponent<Text>().text = "A random anomaly";
			}
			if (NewInputField.GetComponent<InputField>().text == "1")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 1:\r\nGranny moves 50% faster, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "2")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 2:\r\nThe house is MUCH darker, but Granny's vision is also very poor";
			}
			if (NewInputField.GetComponent<InputField>().text == "3")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 3:\r\nAll characters move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "4")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 4:\r\nAll the doors in the house are gone";
			}
			if (NewInputField.GetComponent<InputField>().text == "5")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 5:\r\nEvery 30 seconds the bell rings, reminding Granny to guard the main exit door";
			}
			if (NewInputField.GetComponent<InputField>().text == "6")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 6:\r\nYou can only crawl, but you have endless spray";
			}
			if (NewInputField.GetComponent<InputField>().text == "7")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 7:\r\nYou can't use the Drop button, but then you have long arms";
			}
			if (NewInputField.GetComponent<InputField>().text == "8")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 8:\r\nThere are more creaking floors in the house, but the padlock and trunk have already opened";
			}
			if (NewInputField.GetComponent<InputField>().text == "9")
			{
				NewTxt.GetComponent<Text>().text = "Special anomaly 9:\r\nThe Crow is terminally ill, he will die in 90 seconds, so you must feed him food to extend his life for another 90 seconds";
			}
			if (NewInputField.GetComponent<InputField>().text == "10")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 10:\r\nEvery 30 seconds, a new vase will appear, which will fall in a random place in the house and may make some noise";
			}
			if (NewInputField.GetComponent<InputField>().text == "11")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 11:\r\nYou need to unlock all escape routes and you only have one day, but items will fall from the sky every 2 minutes";
			}
			if (NewInputField.GetComponent<InputField>().text == "12")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 12:\r\nYou have only 8 minutes to escape, but you move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "13")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 13:\r\nThere are almost no items in the house, only pieces of a painting, and Granny moves 25% faster. But you will escape if you collect the painting 3 times";
			}
			if (NewInputField.GetComponent<InputField>().text == "14")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 14:\r\nItems slip out of hands every 10 seconds, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "15")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 15:\r\nGranny hears NOTHING\r\n(But she is always running)";
			}
			if (NewInputField.GetComponent<InputField>().text == "16")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 16:\r\nGranny hears EVERYTHING\r\n(But not your footsteps, picking up items, locked doors and hiding under bed)";
			}
			if (NewInputField.GetComponent<InputField>().text == "17")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 17:\r\nThere are giant traps, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "18")
			{
				NewTxt.GetComponent<Text>().text = "Special anomaly 18:\r\n You have returned to 1.0, but something went wrong...";
			}
			if (NewInputField.GetComponent<InputField>().text == "19")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 19:\r\n Some obstacles have been placed in the house, but you have a special remote that teleports you around the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "20")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 20:\r\n Something strange is happening with the light in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "21")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 21:\r\n When you drop an item, it will fall near the anomaly vase";
			}
			if (NewInputField.GetComponent<InputField>().text == "22")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 22:\r\n Granny moves twice as fast, but she is worse at catching you";
			}
			if (NewInputField.GetComponent<InputField>().text == "23")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 23:\r\n Granny will set new creacking floors during the game, but there are less creacking floors";
			}
			if (NewInputField.GetComponent<InputField>().text == "24")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 24:\r\n Every 4 seconds, Granny gains +1% speed (up to a maximum of 300%), but you move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "25")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 25:\r\n Granny is invisible, but you have a freeze trap";
			}
			if (NewInputField.GetComponent<InputField>().text == "26")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 26:\r\n There are anomalous rats in the house. When they bite you, Granny charges a secret ability. After every fifth bite, Granny activates it";
			}
			if (NewInputField.GetComponent<InputField>().text == "27")
			{
				NewTxt.GetComponent<Text>().text = "Special anomaly 27:\r\n There are almost no items in the house, but you can find 7 keys to escape through the red door";
			}
			if (NewInputField.GetComponent<InputField>().text == "28")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 28:\r\n Granny can create her own clone, which she can use for teleportation";
			}
			if (NewInputField.GetComponent<InputField>().text == "29")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 29:\r\n There are floor plates in the house that either speed you up or slow you down by 60%";
			}
			if (NewInputField.GetComponent<InputField>().text == "30")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 30:\r\n If Granny spots you, you will die, but there are no creaking floors in the house and there is can't be darker";
			}
			if (NewInputField.GetComponent<InputField>().text == "31")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 31:\r\n Granny moves 75% faster, but you have 3 mysterious boxes in your room";
			}
			if (NewInputField.GetComponent<InputField>().text == "32")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 32:\r\n Granny moves ultra fast, you have one day and there are no doors, but she is blind for the rest of the game";
			}
			if (NewInputField.GetComponent<InputField>().text == "33")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 33:\r\n Items can't make noises";
			}
			if (NewInputField.GetComponent<InputField>().text == "34")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 34:\r\n If you have an item, you move 30% slower, but if your hands are empty, you move 60% faster";
			}
			if (NewInputField.GetComponent<InputField>().text == "35")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 35:\r\n You have short hands, but you drop items very hard";
			}
			if (NewInputField.GetComponent<InputField>().text == "36")
			{
				NewTxt.GetComponent<Text>().text = "Special anomaly 36:\r\n Everything is possible";
			}
			if (NewInputField.GetComponent<InputField>().text == "37")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 37:\r\n You have 1 day and if you see Granny, you die, but she is blind";
			}
			if (NewInputField.GetComponent<InputField>().text == "38")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 38:\r\nGranny moves 75% faster, but you slide on floor instead of walking";
			}
			if (NewInputField.GetComponent<InputField>().text == "39")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 39:\r\nWhen you drop items, they randomly change their size";
			}
			if (NewInputField.GetComponent<InputField>().text == "40")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 40:\r\n There are more creacking floors but everytime you step on creacking floor there is a 50% chance that it wouldn't creack";
			}
			if (NewInputField.GetComponent<InputField>().text == "41")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 41:\r\n The house is mirrored";
			}
			if (NewInputField.GetComponent<InputField>().text == "42")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 42:\r\n Gravity is gone and items can make noice everywhere";
			}
			if (NewInputField.GetComponent<InputField>().text == "43")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 43:\r\n Floor creacks in different places";
			}
			if (NewInputField.GetComponent<InputField>().text == "44")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 44:\r\n Your hand's lenght is constantly changing";
			}
			if (NewInputField.GetComponent<InputField>().text == "45")
			{
				NewTxt.GetComponent<Text>().text = "Special anomaly 45:\r\n Try to escape from broken reality";
			}
			if (NewInputField.GetComponent<InputField>().text == "46")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 46:\r\n Your and Granny's field of view is constantly changing";
			}
			if (NewInputField.GetComponent<InputField>().text == "47")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 47:\r\n There are randomly placed «Arcs of Shadow» to make you and Granny see less";
			}
			if (NewInputField.GetComponent<InputField>().text == "50")
			{
				NewTxt.GetComponent<Text>().text = "Anomaly 50:\r\n Granny moves twice as fast, but you can crawl under tables and railings";
			}
			if (NewInputField.GetComponent<InputField>().text == "9191")
			{
				NewTxt.GetComponent<Text>().text = "A secret GABON anomaly (DON'T TRY IF YOUR MOBILE HAS LOW PERFORMANCE)";
			}
			if (NewInputField.GetComponent<InputField>().text == "1405" || NewInputField.GetComponent<InputField>().text == "8841" || NewInputField.GetComponent<InputField>().text == "3991" || NewInputField.GetComponent<InputField>().text == "1793" || NewInputField.GetComponent<InputField>().text == "1000" || NewInputField.GetComponent<InputField>().text == "2134" || NewInputField.GetComponent<InputField>().text == "2025" || NewInputField.GetComponent<InputField>().text == "2202" || NewInputField.GetComponent<InputField>().text == "2311" || NewInputField.GetComponent<InputField>().text == "8228" || NewInputField.GetComponent<InputField>().text == "3103" || NewInputField.GetComponent<InputField>().text == "7102")
			{
				NewTxt.GetComponent<Text>().text = "A secret GABON anomaly";
			}
		}
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			return;
		}
		if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1 || (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "1" || NewInputField.GetComponent<InputField>().text == "2" || NewInputField.GetComponent<InputField>().text == "5" || NewInputField.GetComponent<InputField>().text == "6" || NewInputField.GetComponent<InputField>().text == "8" || NewInputField.GetComponent<InputField>().text == "9" || NewInputField.GetComponent<InputField>().text == "10" || NewInputField.GetComponent<InputField>().text == "11" || NewInputField.GetComponent<InputField>().text == "12" || NewInputField.GetComponent<InputField>().text == "15")))
		{
			NerfedPrimeToggle.isOn = false;
			((Selectable)NerfedPrimeToggle).interactable = false;
			PlayerPrefs.SetInt("NerfedPrimeOnOff", 0);
		}
		else
		{
			((Selectable)NerfedPrimeToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "" || (NewInputField.GetComponent<InputField>().text != "1" && NewInputField.GetComponent<InputField>().text != "2" && NewInputField.GetComponent<InputField>().text != "3" && NewInputField.GetComponent<InputField>().text != "4" && NewInputField.GetComponent<InputField>().text != "5" && NewInputField.GetComponent<InputField>().text != "6" && NewInputField.GetComponent<InputField>().text != "7" && NewInputField.GetComponent<InputField>().text != "8" && NewInputField.GetComponent<InputField>().text != "9" && NewInputField.GetComponent<InputField>().text != "10" && NewInputField.GetComponent<InputField>().text != "11" && NewInputField.GetComponent<InputField>().text != "12" && NewInputField.GetComponent<InputField>().text != "13" && NewInputField.GetComponent<InputField>().text != "14" && NewInputField.GetComponent<InputField>().text != "15" && NewInputField.GetComponent<InputField>().text != "16" && NewInputField.GetComponent<InputField>().text != "17" && NewInputField.GetComponent<InputField>().text != "18" && NewInputField.GetComponent<InputField>().text != "")))
		{
			NewTxt.GetComponent<Text>().text = "Leave here the number of the prime anomaly you want to play on (from 1 to 18).\r\nAttempts: " + PlayerPrefs.GetInt("PrimeAttemps");
			ContinueButton.SetActive(false);
			TrainingButton.SetActive(false);
			BackButton.SetActive(false);
			return;
		}
		ContinueButton.SetActive(true);
		TrainingButton.SetActive(true);
		BackButton.SetActive(true);
		PlayerPrefs.SetInt("PrimeAnomalyNR", int.Parse(NewInputField.GetComponent<InputField>().text));
		if (NewInputField.GetComponent<InputField>().text == "1")
		{
			AnomalyText = " anomaly 1:\r\nGranny walks 800% faster and the farther you are from Granny, the slower you move, but there are no more creaking floors in the house and there is no evil chair";
		}
		if (NewInputField.GetComponent<InputField>().text == "2")
		{
			AnomalyText = " anomaly 2:\r\nThere is MUCH more fog, but you know how far evil chair is from you";
		}
		if (NewInputField.GetComponent<InputField>().text == "3")
		{
			AnomalyText = " anomaly 3:\r\nAll characters move 25% faster";
		}
		if (NewInputField.GetComponent<InputField>().text == "4")
		{
			AnomalyText = " anomaly 4:\r\nThere are new creaking floors, some doors and nightmare walls are removed (grass and concrete can also creack), but Granny is less smarter";
		}
		if (NewInputField.GetComponent<InputField>().text == "5")
		{
			AnomalyText = " anomaly 5:\r\nWhen you make a noice with bell, Evil chair's speed increases by 2, but from the start of the game it's only 5";
		}
		if (NewInputField.GetComponent<InputField>().text == "6")
		{
			AnomalyText = " anomaly 6:\r\nYou can only crawl, but you have a spray, which you can use up to 50 times, there is no evil chair and you need to open only one escape route";
		}
		if (NewInputField.GetComponent<InputField>().text == "7")
		{
			AnomalyText = " anomaly 7:\r\nYou can drop an item only once per minute, but you have long arms";
		}
		if (NewInputField.GetComponent<InputField>().text == "8")
		{
			AnomalyText = " anomaly 8:\r\nFrom time to time, evil chair may become cursed. When cursed, it kills you only when you crouch, but the padlock and trunk are opened";
		}
		if (NewInputField.GetComponent<InputField>().text == "9")
		{
			AnomalyText = " special anomaly 9:\r\nYou need to find 4 red keys to escape through the new door, but there is no evil chair";
		}
		if (NewInputField.GetComponent<InputField>().text == "10")
		{
			AnomalyText = " anomaly 10:\r\nEvil chair loves vases: there are a lot of these in the house and evil chair only goes check these vases";
		}
		if (NewInputField.GetComponent<InputField>().text == "11")
		{
			AnomalyText = " anomaly 11:\r\nEvil chair's clones will fall from the sky every 2 minutes, but the original one moves 50% slower";
		}
		if (NewInputField.GetComponent<InputField>().text == "12")
		{
			AnomalyText = " anomaly 12:\r\nIn 8 minutes evil chair becomes a bomber, but before it hapens you move 25% faster";
		}
		if (NewInputField.GetComponent<InputField>().text == "13")
		{
			AnomalyText = " anomaly 13:\r\nSome areas are blocked and evil chair is imprisoned until you collect the painting 3 times, but numeric padlock and battery lock are opened";
		}
		if (NewInputField.GetComponent<InputField>().text == "14")
		{
			AnomalyText = " anomaly 14:\r\nItems slip out of hands every 10 seconds, but you have an extra day";
		}
		if (NewInputField.GetComponent<InputField>().text == "15")
		{
			AnomalyText = " anomaly 15:\r\nGranny hears nothing and she is always running, but there is no evil chair and you have a nightmare book";
		}
		if (NewInputField.GetComponent<InputField>().text == "16")
		{
			AnomalyText = " anomaly 16:\r\nGranny hears almost everything, but she has a very poor vision";
		}
		if (NewInputField.GetComponent<InputField>().text == "17")
		{
			AnomalyText = " anomaly 17:\r\nBeartraps in the house are replaced by the giant ones, but you have a nightmare remote control";
		}
		if (NewInputField.GetComponent<InputField>().text == "18")
		{
			AnomalyText = " special anomaly 18:\r\nYou have returned to 1.7 and almost everything went right...";
		}
		if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1)
		{
			NewTxt.GetComponent<Text>().text = "Nerfed prime" + AnomalyText;
		}
		else
		{
			NewTxt.GetComponent<Text>().text = "Prime" + AnomalyText;
		}
	}

	private void CreateTogglesRow()
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("NightMareOnOff") == 0 && PlayerPrefs.GetInt("EventChallenge3Completed") == 0)
		{
			optionNames = new string[4] { "ShowTimer", "ShowAttempts", "ShowProgress", "NerfedPrime" };
		}
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("EventChallenge3Completed") == 0)
		{
			optionNames = new string[5] { "ShowTimer", "ShowAttempts", "ShowProgress", "NerfedPrime", "AnxietyMode" };
		}
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && PlayerPrefs.GetInt("EventChallenge3Completed") == 1)
		{
			optionNames = new string[6] { "ShowTimer", "ShowAttempts", "ShowProgress", "NerfedPrime", "EventChallenge3Reward", "AnxietyMode" };
		}
		float num = 180f;
		float num2 = 100f;
		float num3 = 150f;
		float num4 = 60f;
		for (int i = 0; i < optionNames.Length; i++)
		{
			string opt = optionNames[i];
			GameObject val = new GameObject(opt + "Container", new Type[1] { typeof(RectTransform) });
			val.transform.SetParent(GameObject.Find("TextScreen").transform, false);
			RectTransform component = val.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 1f);
			component.anchorMax = new Vector2(0f, 1f);
			component.pivot = new Vector2(0f, 1f);
			float num5 = num + (float)i * num2;
			component.anchoredPosition = new Vector2(num5, -13f);
			component.sizeDelta = new Vector2(num3, num4);
			GameObject val2 = new GameObject("Label", new Type[1] { typeof(Text) });
			val2.transform.SetParent(val.transform, false);
			Text component2 = val2.GetComponent<Text>();
			component2.text = FormatName(opt);
			component2.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
			component2.fontSize = 18;
			((Graphic)component2).color = Color.white;
			component2.alignment = (TextAnchor)4;
			RectTransform component3 = val2.GetComponent<RectTransform>();
			component3.anchorMin = new Vector2(0f, 0.5f);
			component3.anchorMax = new Vector2(1f, 1f);
			component3.pivot = new Vector2(0.5f, 1f);
			component3.offsetMin = new Vector2(0f, -10f);
			component3.offsetMax = new Vector2(0f, -10f);
			GameObject val3 = new GameObject(opt + "Toggle", new Type[1] { typeof(RectTransform) });
			val3.transform.SetParent(val.transform, false);
			RectTransform component4 = val3.GetComponent<RectTransform>();
			component4.anchorMin = new Vector2(0.5f, 0f);
			component4.anchorMax = new Vector2(0.5f, 0f);
			component4.pivot = new Vector2(0.5f, 0f);
			component4.anchoredPosition = new Vector2(0f, 0f);
			component4.sizeDelta = new Vector2(20f, 20f);
			Toggle val4 = val3.AddComponent<Toggle>();
			GameObject val5 = new GameObject("Background", new Type[1] { typeof(Image) });
			val5.transform.SetParent(val3.transform, false);
			RectTransform component5 = val5.GetComponent<RectTransform>();
			component5.anchorMin = Vector2.zero;
			component5.anchorMax = Vector2.one;
			component5.offsetMin = Vector2.zero;
			component5.offsetMax = Vector2.zero;
			Image component6 = val5.GetComponent<Image>();
			component6.sprite = Resources.GetBuiltinResource<Sprite>("UI/Skin/UISprite.psd");
			component6.type = (Type)1;
			((Graphic)component6).color = Color.white;
			((Selectable)val4).targetGraphic = (Graphic)(object)component6;
			GameObject val6 = new GameObject("Checkmark", new Type[1] { typeof(Image) });
			val6.transform.SetParent(val5.transform, false);
			RectTransform component7 = val6.GetComponent<RectTransform>();
			component7.anchorMin = new Vector2(0.2f, 0.2f);
			component7.anchorMax = new Vector2(0.8f, 0.8f);
			component7.offsetMin = Vector2.zero;
			component7.offsetMax = Vector2.zero;
			Image component8 = val6.GetComponent<Image>();
			component8.sprite = Resources.GetBuiltinResource<Sprite>("UI/Skin/UIMask.psd");
			((Graphic)component8).color = Color.black;
			val4.graphic = (Graphic)(object)component8;
			int num6 = PlayerPrefs.GetInt(opt + "OnOff", 0);
			val4.isOn = num6 == 1;
			if (opt == "NerfedPrime" && (PlayerPrefs.GetInt("AnomalyOnOff", 0) == 1 || PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1))
			{
				NerfedPrimeToggle = val4;
			}
			((UnityEvent<bool>)(object)val4.onValueChanged).AddListener((UnityAction<bool>)((bool value) =>
			{
				PlayerPrefs.SetInt(opt + "OnOff", value ? 1 : 0);
			}));
		}
	}

	private string FormatName(string raw)
	{
		return raw switch
		{
			"ShowTimer" => "Show timer", 
			"ShowAttempts" => "Show attempts", 
			"ShowProgress" => "Show progress", 
			"NerfedPrime" => "Nerfed Prime", 
			"AnxietyMode" => "Anxiety mode", 
			"EventChallenge3Reward" => "EC 3 reward", 
			_ => raw, 
		};
	}
}
