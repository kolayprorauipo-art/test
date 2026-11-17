using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graphicsSettings : MonoBehaviour
{
	public Dropdown dropdownOptions;

	public GameObject varningTextHigh;

	public GameObject varningTextMedium;

	public GameObject Quality;

	public Resources canvas;

	public GameObject NewTxt;

	public virtual void Start()
	{
		dropdownOptions.ClearOptions();
		dropdownOptions.AddOptions(new List<string>
		{
			"In order", "Random", "Default1", "Default2", "Default3", "Default4", "Default5", "Custom6", "Custom7", "Custom8",
			"Custom9"
		});
		if (PlayerPrefs.GetInt("randomNR") == 1)
		{
			dropdownOptions.value = 2;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 2)
		{
			dropdownOptions.value = 3;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 3)
		{
			dropdownOptions.value = 4;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 4)
		{
			dropdownOptions.value = 5;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 5)
		{
			dropdownOptions.value = 6;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 6)
		{
			dropdownOptions.value = 7;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 7)
		{
			dropdownOptions.value = 8;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 8)
		{
			dropdownOptions.value = 9;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 9)
		{
			dropdownOptions.value = 10;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 100)
		{
			dropdownOptions.value = 1;
		}
		else if (PlayerPrefs.GetInt("randomNR") == 99)
		{
			dropdownOptions.value = 0;
		}
	}

	private void Update()
	{
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			((Selectable)dropdownOptions).interactable = false;
			dropdownOptions.value = 1;
		}
		else
		{
			((Selectable)dropdownOptions).interactable = true;
		}
		if (dropdownOptions.value == 0)
		{
			PlayerPrefs.SetInt("randomNR", 99);
		}
		if (dropdownOptions.value == 1)
		{
			PlayerPrefs.SetInt("randomNR", 100);
		}
		if (dropdownOptions.value == 2)
		{
			PlayerPrefs.SetInt("randomNR", 1);
		}
		if (dropdownOptions.value == 3)
		{
			PlayerPrefs.SetInt("randomNR", 2);
		}
		if (dropdownOptions.value == 4)
		{
			PlayerPrefs.SetInt("randomNR", 3);
		}
		if (dropdownOptions.value == 5)
		{
			PlayerPrefs.SetInt("randomNR", 4);
		}
		if (dropdownOptions.value == 6)
		{
			PlayerPrefs.SetInt("randomNR", 5);
		}
		if (dropdownOptions.value == 7)
		{
			PlayerPrefs.SetInt("randomNR", 6);
		}
		if (dropdownOptions.value == 8)
		{
			PlayerPrefs.SetInt("randomNR", 7);
		}
		if (dropdownOptions.value == 9)
		{
			PlayerPrefs.SetInt("randomNR", 8);
		}
		if (dropdownOptions.value == 10)
		{
			PlayerPrefs.SetInt("randomNR", 9);
		}
	}

	public void SetQuality(int qualityindex)
	{
	}
}
