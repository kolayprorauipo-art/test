using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class clickOptionButtonIG : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject optionButton;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject bedButtons;

	public GameObject soundHolder;

	public GameObject carControls;

	public GameObject diffButtons;

	public Button btn1;

	public void Update()
	{
		if (Input.GetKeyDown((KeyCode)27))
		{
			OpenOptionMenu();
			Cursor.lockState = (CursorLockMode)2;
			Cursor.visible = true;
		}
	}

	public void OpenOptionMenu()
	{
		Time.timeScale = 0f;
		optionMenu.SetActive(true);
		optionButton.SetActive(false);
		joystick.SetActive(false);
		crouchButton.SetActive(false);
		diffButtons.SetActive(false);
		((backgroundSound)(object)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
	}
}
