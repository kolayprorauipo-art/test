using UnityEngine;
using UnityEngine.UI;

public class ExtraEnemyDropdown : MonoBehaviour
{
	public Dropdown dropdownOptions;

	private void Start()
	{
		if (PlayerPrefs.GetInt("SETExtraEnemy") == 0)
		{
			dropdownOptions.value = 0;
		}
		if (PlayerPrefs.GetInt("SETExtraEnemy") == 1)
		{
			dropdownOptions.value = 1;
		}
	}

	public void ChangeSetting()
	{
		if (dropdownOptions.value == 0)
		{
			PlayerPrefs.SetInt("NerfedPrimeOnOff", 1);
			if (((Selectable)dropdownOptions).interactable)
			{
				PlayerPrefs.SetInt("SETExtraEnemy", 0);
			}
		}
		else if (dropdownOptions.value == 1)
		{
			PlayerPrefs.SetInt("NerfedPrimeOnOff", 0);
			if (((Selectable)dropdownOptions).interactable)
			{
				PlayerPrefs.SetInt("SETExtraEnemy", 1);
			}
		}
	}

	private void Update()
	{
		if (((Selectable)dropdownOptions).interactable)
		{
			if (PlayerPrefs.GetInt("SETExtraEnemy") == 0)
			{
				dropdownOptions.value = 0;
			}
			else if (PlayerPrefs.GetInt("SETExtraEnemy") == 1)
			{
				dropdownOptions.value = 1;
			}
		}
	}
}
