using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class nightmareOnOff : MonoBehaviour
{
	public Dropdown dropdownOptions;

	public GameObject DefaultMenuMusic;

	public GameObject NightmareMenuMusic;

	public GameObject AbaodonedMenuMusic;

	public GameObject DarkerOnOff;

	private void Start()
	{
		if (PlayerPrefs.GetInt("SETNightmare") == 0)
		{
			dropdownOptions.value = 0;
			DefaultMenuMusic.SetActive(true);
			NightmareMenuMusic.SetActive(false);
			AbaodonedMenuMusic.SetActive(false);
			DarkerOnOff.SetActive(true);
		}
		if (PlayerPrefs.GetInt("SETNightmare") == 1)
		{
			dropdownOptions.value = 1;
			DefaultMenuMusic.SetActive(false);
			NightmareMenuMusic.SetActive(true);
			AbaodonedMenuMusic.SetActive(false);
			DarkerOnOff.SetActive(true);
		}
		if (PlayerPrefs.GetInt("SETNightmare") == 2)
		{
			dropdownOptions.value = 2;
			DefaultMenuMusic.SetActive(false);
			NightmareMenuMusic.SetActive(false);
			AbaodonedMenuMusic.SetActive(true);
			DarkerOnOff.SetActive(false);
		}
	}

	public void ChangeSetting()
	{
		if (dropdownOptions.value == 0)
		{
			DefaultMenuMusic.SetActive(true);
			NightmareMenuMusic.SetActive(false);
			AbaodonedMenuMusic.SetActive(false);
			DarkerOnOff.SetActive(true);
			PlayerPrefs.SetInt("NightMareOnOff", 0);
			if (((Selectable)dropdownOptions).interactable)
			{
				PlayerPrefs.SetInt("SETNightmare", 0);
			}
		}
		else if (dropdownOptions.value == 1)
		{
			DefaultMenuMusic.SetActive(false);
			NightmareMenuMusic.SetActive(true);
			AbaodonedMenuMusic.SetActive(false);
			DarkerOnOff.SetActive(true);
			PlayerPrefs.SetInt("NightMareOnOff", 1);
			if (((Selectable)dropdownOptions).interactable)
			{
				PlayerPrefs.SetInt("SETNightmare", 1);
			}
		}
		else if (dropdownOptions.value == 2)
		{
			DefaultMenuMusic.SetActive(false);
			NightmareMenuMusic.SetActive(false);
			AbaodonedMenuMusic.SetActive(true);
			DarkerOnOff.SetActive(false);
			PlayerPrefs.SetInt("NightMareOnOff", 2);
			if (((Selectable)dropdownOptions).interactable)
			{
				PlayerPrefs.SetInt("SETNightmare", 2);
			}
		}
	}

	private void Update()
	{
		if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
		{
			((Selectable)dropdownOptions).interactable = false;
			dropdownOptions.value = 0;
		}
		else
		{
			((Selectable)dropdownOptions).interactable = true;
		}
		if (((Selectable)dropdownOptions).interactable)
		{
			if (PlayerPrefs.GetInt("SETNightmare") == 0)
			{
				dropdownOptions.value = 0;
			}
			else if (PlayerPrefs.GetInt("SETNightmare") == 1)
			{
				dropdownOptions.value = 1;
			}
			else if (PlayerPrefs.GetInt("SETNightmare") == 2)
			{
				dropdownOptions.value = 2;
			}
		}
	}
}
