using UnityEngine;
using UnityEngine.UI;

public class ChangePrimeMusic : MonoBehaviour
{
	public Dropdown dropdownOptions;

	private void Start()
	{
		if (PlayerPrefs.GetInt("PrimeMusic") == 1)
		{
			dropdownOptions.value = 0;
		}
		if (PlayerPrefs.GetInt("PrimeMusic") == 2)
		{
			dropdownOptions.value = 1;
		}
		if (PlayerPrefs.GetInt("PrimeMusic") == 3)
		{
			dropdownOptions.value = 2;
		}
	}

	private void Update()
	{
		if (dropdownOptions.value == 0)
		{
			PlayerPrefs.SetInt("PrimeMusic", 1);
		}
		if (dropdownOptions.value == 1)
		{
			PlayerPrefs.SetInt("PrimeMusic", 2);
		}
		if (dropdownOptions.value == 2)
		{
			PlayerPrefs.SetInt("PrimeMusic", 3);
		}
	}
}
