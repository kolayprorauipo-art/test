using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class reverseCar : MonoBehaviour
{
	public GameObject carAnimation;

	public GameObject reverseButton;

	public GameObject outOffCarButton;

	public bool reverse1Played;

	public GameObject carReverseSound1;

	public GameObject engineOnSound;

	public GameObject frontCrashSound;

	public GameObject frontCrashSound2;

	public GameObject CarHitTriggers;

	public GameObject optionButton;

	public GameObject gameController;

	public Button btn1;

	public bool RemoteSpawned;

	public void Update()
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		if (!Input.GetKeyDown((KeyCode)115))
		{
			return;
		}
		((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).carMoving = true;
		if (!reverse1Played)
		{
			carAnimation.GetComponent<Animation>().Play("CarReverse");
			reverseButton.SetActive(false);
			reverse1Played = true;
			outOffCarButton.SetActive(false);
			carReverseSound1.SetActive(true);
			engineOnSound.SetActive(false);
			frontCrashSound.SetActive(false);
			frontCrashSound2.SetActive(false);
			CarHitTriggers.SetActive(true);
			optionButton.SetActive(false);
			if (PlayerPrefs.GetInt("DiffData") == 7 && !RemoteSpawned && ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR != 6)
			{
				Object.Instantiate<GameObject>(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).newTeleportRemote, new Vector3(10.118521f, 6.397f, -6.677f), Quaternion.Euler(-90f, 0f, 0f));
				RemoteSpawned = true;
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 9)
				{
					Object.Instantiate<GameObject>(((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).newPrimeRedKey, new Vector3(10.118521f, 6.5f, -6.677f), Quaternion.Euler(-90f, 0f, 0f));
				}
			}
		}
		else
		{
			carAnimation.GetComponent<Animation>().Play("CarReverse2");
			reverseButton.SetActive(false);
			outOffCarButton.SetActive(false);
			carReverseSound1.SetActive(true);
			engineOnSound.SetActive(false);
			frontCrashSound.SetActive(false);
			frontCrashSound2.SetActive(false);
			CarHitTriggers.SetActive(true);
			optionButton.SetActive(false);
		}
	}
}
