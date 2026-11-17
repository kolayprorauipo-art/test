using UnityEngine;

public class saveSensitivityData : MonoBehaviour
{
	public float sliderValue;

	private void Start()
	{
		Object.DontDestroyOnLoad((Object)(object)((Component)((Component)this).transform).gameObject);
		if (PlayerPrefs.GetInt("slideData") == 0)
		{
			sliderValue = 10f;
		}
		else
		{
			sliderValue = PlayerPrefs.GetInt("slideData");
		}
	}
}
