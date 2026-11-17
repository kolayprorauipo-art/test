using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class checkTheCar : MonoBehaviour
{
	public GameObject granny;

	public bool batteryOK;

	public bool topplockOK;

	public bool sparkplugOK;

	public bool fuelOK;

	public bool playerHaveCarKey;

	public float topplocksskruvar;

	public GameObject startButton;

	public GameObject forwardButton;

	public GameObject reverseButton;

	public bool forwardOK;

	public bool reverseOK;

	public bool engineOn;

	public GameObject engineStartSound;

	public GameObject engineOnSound;

	public GameObject outOffCarButton;

	public GameObject canNotStartCarText;

	public bool textTimerOnOff;

	public float textTimer;

	public bool carMoving;

	public GameObject CommentText;

	public Resources c;

	public GameObject CommentText2;

	public virtual void Start()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		CommentText = DefaultControls.CreateText(c);
		CommentText.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
		CommentText.GetComponent<Text>().text = "You have unlocked car escape!";
		((Graphic)CommentText.GetComponent<Text>()).color = Color.white;
		CommentText.GetComponent<Text>().fontStyle = (FontStyle)1;
		CommentText.GetComponent<Text>().alignment = (TextAnchor)4;
		CommentText.GetComponent<Text>().resizeTextForBestFit = true;
		CommentText.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
		CommentText.GetComponent<Text>().fontSize = 0;
		CommentText.GetComponent<Text>().resizeTextMaxSize = 54;
		CommentText.GetComponent<RectTransform>().sizeDelta = new Vector2(1556f, 30f);
		CommentText.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		CommentText.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		CommentText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -52f);
		CommentText.SetActive(false);
		CommentText2 = DefaultControls.CreateText(c);
		CommentText2.transform.SetParent(GameObject.Find("AllaTexter").GetComponent<Transform>());
		CommentText2.GetComponent<Text>().text = "You need to open the garage door first!";
		((Graphic)CommentText2.GetComponent<Text>()).color = Color.white;
		CommentText2.GetComponent<Text>().fontStyle = (FontStyle)1;
		CommentText2.GetComponent<Text>().alignment = (TextAnchor)4;
		CommentText2.GetComponent<Text>().resizeTextForBestFit = true;
		CommentText2.GetComponent<Text>().verticalOverflow = (VerticalWrapMode)1;
		CommentText2.GetComponent<Text>().fontSize = 0;
		CommentText2.GetComponent<Text>().resizeTextMaxSize = 54;
		CommentText2.GetComponent<RectTransform>().sizeDelta = new Vector2(1556f, 30f);
		CommentText2.GetComponent<RectTransform>().anchorMin = new Vector2(0.5f, 0.5f);
		CommentText2.GetComponent<RectTransform>().anchorMax = new Vector2(0.5f, 0.5f);
		CommentText2.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -52f);
		CommentText2.SetActive(false);
	}

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				canNotStartCarText.SetActive(false);
				CommentText.SetActive(false);
				CommentText2.SetActive(false);
			}
		}
	}

	public virtual void startCar()
	{
		if (batteryOK && topplockOK && sparkplugOK && fuelOK && playerHaveCarKey && topplocksskruvar == 6f && GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 11 && GameObject.Find("GameController").GetComponent<InventoryController>().OpenedGarageDoor)
		{
			textTimer = 0f;
			startButton.SetActive(false);
			CommentText.SetActive(true);
			textTimerOnOff = true;
		}
		else if (batteryOK && topplockOK && sparkplugOK && fuelOK && playerHaveCarKey && topplocksskruvar == 6f && GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 11 && !GameObject.Find("GameController").GetComponent<InventoryController>().OpenedGarageDoor)
		{
			textTimer = 0f;
			CommentText2.SetActive(true);
			textTimerOnOff = true;
		}
		else if (batteryOK && topplockOK && sparkplugOK && fuelOK && ((Component)this).gameObject.GetComponent<InventoryController>().havecarKey && topplocksskruvar == 6f && GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR != 11)
		{
			startButton.SetActive(false);
			((MonoBehaviour)this).StartCoroutine(startEngine());
			if (reverseOK)
			{
				reverseButton.SetActive(true);
				forwardButton.SetActive(false);
			}
			else if (forwardOK)
			{
				forwardButton.SetActive(true);
				reverseButton.SetActive(false);
			}
			else
			{
				reverseButton.SetActive(true);
				forwardButton.SetActive(false);
			}
		}
		else if (batteryOK && topplockOK && sparkplugOK && fuelOK && !((Component)this).gameObject.GetComponent<InventoryController>().havecarKey && topplocksskruvar == 6f)
		{
			((Component)((Component)this).gameObject.GetComponent<InventoryController>().PickUpScript).GetComponent<PickUp>().ShowText2("I need a car key");
		}
		else
		{
			textTimer = 0f;
			canNotStartCarText.SetActive(true);
			textTimerOnOff = true;
		}
	}

	public virtual IEnumerator startEngine()
	{
		engineOn = true;
		engineStartSound.SetActive(true);
		((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerStartCar = true;
		yield return (object)new WaitForSeconds(0.6f);
		engineOnSound.SetActive(true);
	}
}
