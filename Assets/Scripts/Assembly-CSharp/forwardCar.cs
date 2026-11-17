using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class forwardCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject forwardButton;

	public GameObject outOffCarButton;

	public GameObject carSensorFront;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject backCrashSound;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public GameObject escapeMusic;

	public GameObject mainMusic;

	public GameObject gameController;

	public Button btn1;

	public bool RemoteSpawned;

	public void Update()
	{
		if (Input.GetKeyDown((KeyCode)119) && (PlayerPrefs.GetInt("DiffData") != 7 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6) && PlayerPrefs.GetInt("PrimeOn") != 0)
		{
			((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).carMoving = true;
			if (((carFrontSensor)(object)carSensorFront.GetComponent(typeof(carFrontSensor))).hitGaragedoorCounter == 2f)
			{
				gameController.GetComponent<startNewDay>().CheckAchievementsGoodEnding();
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AllProgress = true;
				carAnimation.GetComponent<Animation>().Play("CarEscape");
				forwardButton.SetActive(false);
				outOffCarButton.SetActive(false);
				carForwardSound.SetActive(true);
				optionButton.SetActive(false);
				escapeMusic.SetActive(true);
				mainMusic.SetActive(false);
			}
			else
			{
				carAnimation.GetComponent<Animation>().Play("CarForward");
				forwardButton.SetActive(false);
				outOffCarButton.SetActive(false);
				carForwardSound.SetActive(true);
				engineOnSound.SetActive(false);
				backCrashSound.SetActive(false);
				CarHitTriggers.SetActive(true);
				optionButton.SetActive(false);
			}
		}
	}
}
