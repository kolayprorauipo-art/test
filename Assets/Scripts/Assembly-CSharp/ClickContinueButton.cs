using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class ClickContinueButton : MonoBehaviour
{
	public GameObject LoadingScreen;

	public GameObject ljudHolder;

	public GameObject OptionMenu;

	private bool buttonPressed;

	public virtual void Start()
	{
	}

	public void TaskOnClick()
	{
		if (!buttonPressed)
		{
			if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0)
			{
				SceneManager.LoadSceneAsync("Scene");
				((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
				OptionMenu.SetActive(false);
				LoadingScreen.SetActive(true);
			}
			else
			{
				Application.OpenURL("https://lubenchenkoboris.itch.io/granny-prime-mode");
			}
		}
	}

	public void TaskOnClick2()
	{
		if (!buttonPressed)
		{
			if (PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0)
			{
				PlayerPrefs.SetInt("PrimeOn", 0);
				SceneManager.LoadSceneAsync("Scene");
				((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
				OptionMenu.SetActive(false);
				LoadingScreen.SetActive(true);
			}
			else
			{
				Application.OpenURL("https://lubenchenkoboris.itch.io/granny-prime-mode");
			}
		}
	}

	public void LightsOut()
	{
		SceneManager.LoadSceneAsync("Scene");
		PlayerPrefs.SetInt("EventChallenge2", 1);
		PlayerPrefs.SetInt("DiffData", 0);
		PlayerPrefs.SetInt("AnomalyOnOff", 0);
		PlayerPrefs.SetInt("twoLocksOnOff", 0);
		PlayerPrefs.SetInt("fogOnOff", 0);
		PlayerPrefs.SetInt("fogOnExtreme", 0);
		PlayerPrefs.SetInt("LaserOnOffOnOff", 0);
		PlayerPrefs.SetInt("NightMareOnOff", 0);
		PlayerPrefs.SetInt("SETNightmareWallsOnOff", 0);
		PlayerPrefs.SetInt("SETExtraEnemy", 0);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}

	public void MelonGambling()
	{
		SceneManager.LoadSceneAsync("Scene");
		PlayerPrefs.SetInt("EventChallenge3", 1);
		PlayerPrefs.SetInt("DiffData", 3);
		PlayerPrefs.SetInt("fogOnExtreme", 1);
		PlayerPrefs.SetInt("AnomalyOnOff", 0);
		PlayerPrefs.SetInt("twoLocksOnOff", 0);
		PlayerPrefs.SetInt("LaserOnOffOnOff", 0);
		PlayerPrefs.SetInt("NightMareOnOff", 0);
		PlayerPrefs.SetInt("SETNightmareWallsOnOff", 0);
		PlayerPrefs.SetInt("SETExtraEnemy", 0);
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
	}
}
