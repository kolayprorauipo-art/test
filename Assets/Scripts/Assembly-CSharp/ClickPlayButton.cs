using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ClickPlayButton : MonoBehaviour
{
	public GameObject allButtons;

	public GameObject ljudHolder;

	public GameObject OptionButtons;

	public GameObject Menubackground;

	public GameObject optionbackground;

	public GameObject iapButton;

	private bool buttonPressed;

	private bool buttonsounds;

	public Button btn1;

	public Resources canvas;

	public GameObject C;

	public GameObject NewText;

	public GameObject TestMusic;

	public GameObject MoreOptions;

	public GameObject MainOptions;

	public Image Bat;

	public Image Melon;

	public AudioMixer audioMixer;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
		PlayerPrefs.SetInt("VaseColliderChange", 0);
		PlayerPrefs.SetInt("Anomaly27Levels", 0);
		PlayerPrefs.SetInt("EventChallenge1", 0);
		PlayerPrefs.SetInt("EventChallenge2", 0);
		PlayerPrefs.SetInt("EventChallenge3", 0);
		PlayerPrefs.SetInt("EventTrap", 0);
		PlayerPrefs.SetInt("NoExtrasOnOff", 0);
		PlayerPrefs.SetInt("PrimeOn", 1);
		PlayerPrefs.SetInt("IgnoreCollisionOnOff", 1);
		PlayerPrefs.SetInt("UIMenuFix", 0);
		ChangeGrannySkin(PlayerPrefs.GetInt("EventChallenge3RewardOnOff"));
	}

	public void TaskOnClick()
	{
		Menubackground.SetActive(false);
		optionbackground.SetActive(true);
		allButtons.SetActive(false);
		OptionButtons.SetActive(true);
		iapButton.SetActive(false);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void BacktoMenu()
	{
		Menubackground.SetActive(true);
		optionbackground.SetActive(false);
		allButtons.SetActive(true);
		OptionButtons.SetActive(false);
		iapButton.SetActive(true);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void GoToMoreOptions()
	{
		MoreOptions.SetActive(true);
		MainOptions.SetActive(false);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void GoToMainOptions()
	{
		MoreOptions.SetActive(false);
		MainOptions.SetActive(true);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void OpenYoutube(string url)
	{
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
		Application.OpenURL(url);
	}

	public void Sound()
	{
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void ChangeGrannySkin(int skin)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		switch (skin)
		{
		case 0:
			PlayerPrefs.SetInt("EventChallenge3RewardOnOff", 0);
			((Graphic)Bat).color = new Color(0.5f, 0f, 0f);
			if (PlayerPrefs.GetInt("EventChallenge3Completed") == 0)
			{
				((Graphic)Melon).color = Color.grey;
			}
			else if (PlayerPrefs.GetInt("EventChallenge3Completed") == 1)
			{
				((Graphic)Melon).color = Color.white;
			}
			break;
		case 1:
			if (PlayerPrefs.GetInt("EventChallenge3Completed") == 1)
			{
				PlayerPrefs.SetInt("EventChallenge3RewardOnOff", 1);
				((Graphic)Bat).color = Color.white;
				((Graphic)Melon).color = new Color(0f, 0.5f, 0f);
			}
			break;
		}
	}
}
