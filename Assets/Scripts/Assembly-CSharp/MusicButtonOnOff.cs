using System;
using UnityEngine;

[Serializable]
public class MusicButtonOnOff : MonoBehaviour
{
	public GameObject BGMuiscDefault;

	public GameObject BGMuiscNightmare;

	public GameObject BGMuiscAbandoned;

	public void Start()
	{
	}

	public void MusicOnOff()
	{
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			PlayerPrefs.SetInt("musikOnOff", 1);
		}
		else if (PlayerPrefs.GetInt("musikOnOff") == 1)
		{
			PlayerPrefs.SetInt("musikOnOff", 0);
		}
		if (PlayerPrefs.GetInt("musikOnOff") == 1)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				BGMuiscDefault.SetActive(false);
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				BGMuiscNightmare.SetActive(false);
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
			{
				BGMuiscAbandoned.SetActive(false);
			}
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
		{
			BGMuiscDefault.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			BGMuiscNightmare.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			BGMuiscAbandoned.SetActive(true);
		}
	}
}
