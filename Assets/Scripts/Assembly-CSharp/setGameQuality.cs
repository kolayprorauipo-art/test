using UnityEngine;

public class setGameQuality : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetInt("LowDetailOnOff") == 0)
		{
			QualitySettings.SetQualityLevel(2);
		}
		if (PlayerPrefs.GetInt("LowDetailOnOff") == 1)
		{
			QualitySettings.SetQualityLevel(0);
		}
	}
}
