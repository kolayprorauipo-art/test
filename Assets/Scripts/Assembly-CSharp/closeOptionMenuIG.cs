using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class closeOptionMenuIG : MonoBehaviour
{
	public GameObject gameController;

	public GameObject optionMenu;

	public GameObject optionButton;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject bedButtons;

	public GameObject savedValue;

	public GameObject soundHolder;

	public GameObject carControls;

	public GameObject diffButtons;

	public Button btn1;

	public virtual void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		_ = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown((KeyCode)27))
		{
			CloseOptionMenu();
		}
	}

	private void TaskOnClick()
	{
		CloseOptionMenu();
	}

	public void CloseOptionMenu()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cursor.lockState = (CursorLockMode)1;
		Cursor.visible = false;
		saveSensitivityData val = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		Time.timeScale = 1f;
		optionMenu.SetActive(false);
		optionButton.SetActive(true);
		joystick.SetActive(true);
		if (!((PlayerFreeze)(object)gameController.GetComponent(typeof(PlayerFreeze))).playerStuckTimer)
		{
			crouchButton.SetActive(true);
		}
		diffButtons.SetActive(true);
		PlayerPrefs.SetInt("slideData", (int)val.sliderValue);
		((backgroundSound)(object)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
	}
}
