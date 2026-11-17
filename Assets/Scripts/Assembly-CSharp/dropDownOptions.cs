using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class dropDownOptions : MonoBehaviour
{
	public bool easyModeOn;

	public bool normalModeOn;

	public bool hardModeOn;

	public bool extremeModeOn;

	public bool practiseModeOn;

	public Dropdown dropdownOptions;

	public bool extremeModePlusOn;

	public GameObject presetOptionsObj;

	public GameObject musicHolder;

	public Dropdown presetOptions;

	public RectTransform presetOptionsPos;

	public bool CruelOn;

	public bool DevilOn;

	public bool BeginnerOn;

	public Font MonotypeCorsiva;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("FirstTouch") == 0)
		{
			PlayerPrefs.SetFloat("GameVolume", 0.5f);
			PlayerPrefs.SetFloat("UIOpacity", 100f);
			PlayerPrefs.SetInt("FPSLimit", 240);
			PlayerPrefs.SetInt("FirstTouch", 1);
			PlayerPrefs.SetInt("LowDetailOnOff", 0);
			PlayerPrefs.SetInt("LimpingOnOff", 1);
		}
		Cursor.lockState = (CursorLockMode)2;
		Cursor.visible = true;
		Time.timeScale = 1f;
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			musicHolder.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("musikOnOff") == 1)
		{
			musicHolder.SetActive(false);
		}
		ChangeDropdown();
	}

	public virtual void ChangeDropdown()
	{
		if (PlayerPrefs.GetInt("EventChallenge2Completed") == 1)
		{
			dropdownOptions.ClearOptions();
			dropdownOptions.AddOptions(new List<string>
			{
				"Prime+", "Prime", "Cruel", "Extreme+", "Extreme", "Hard", "Normal", "Easy", "Chill", "Practice",
				"Madness05"
			});
		}
		else
		{
			dropdownOptions.ClearOptions();
			dropdownOptions.AddOptions(new List<string> { "Prime+", "Prime", "Cruel", "Extreme+", "Extreme", "Hard", "Normal", "Easy", "Chill", "Practice" });
		}
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			dropdownOptions.value = 10;
			return;
		}
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			dropdownOptions.value = 8;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			dropdownOptions.value = 6;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			dropdownOptions.value = 7;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			dropdownOptions.value = 5;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			dropdownOptions.value = 4;
		}
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			dropdownOptions.value = 9;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			dropdownOptions.value = 3;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			dropdownOptions.value = 2;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0)
		{
			dropdownOptions.value = 1;
		}
		if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
		{
			dropdownOptions.value = 0;
		}
	}

	public virtual void diffOptions()
	{
		if (dropdownOptions.value == 10)
		{
			PlayerPrefs.SetInt("DiffData", 0);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("UltraFlashlight", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		else
		{
			PlayerPrefs.SetInt("UltraFlashlight", 0);
		}
		if (dropdownOptions.value == 6)
		{
			PlayerPrefs.SetInt("DiffData", 0);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 7)
		{
			PlayerPrefs.SetInt("DiffData", 1);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 5)
		{
			PlayerPrefs.SetInt("DiffData", 2);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 4)
		{
			PlayerPrefs.SetInt("DiffData", 3);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 8)
		{
			PlayerPrefs.SetInt("DiffData", -1);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 9)
		{
			PlayerPrefs.SetInt("DiffData", 4);
			PlayerPrefs.SetInt("fogOnExtreme", 0);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 3)
		{
			PlayerPrefs.SetInt("DiffData", 5);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 2)
		{
			PlayerPrefs.SetInt("DiffData", 6);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 1)
		{
			PlayerPrefs.SetInt("DiffData", 7);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 0);
		}
		if (dropdownOptions.value == 0)
		{
			PlayerPrefs.SetInt("DiffData", 7);
			PlayerPrefs.SetInt("fogOnExtreme", 1);
			PlayerPrefs.SetInt("ExtraTrapsOnOff", 1);
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			((Selectable)dropdownOptions).interactable = false;
			if (PlayerPrefs.GetInt("CasualOnOff") == 0)
			{
				dropdownOptions.value = 4;
			}
			else
			{
				dropdownOptions.value = 1;
			}
		}
		else
		{
			((Selectable)dropdownOptions).interactable = true;
		}
	}
}
