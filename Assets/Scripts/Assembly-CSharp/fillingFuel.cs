using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class fillingFuel : MonoBehaviour
{
	public int layerMask;

	public GameObject gameController;

	public bool playerHoldButton;

	public GameObject fillFuelButton;

	public GameObject fillFuelMeter;

	public Image fillFuealBar;

	public GameObject doorRay;

	public bool playerTaken;

	public bool playSound;

	public bool noMoreFill;

	public GameObject pickUpButton;

	public GameObject tanklockAnim;

	public GameObject fillingGasSoundHolder;

	public bool tanklockAnimPlayed;

	public fillingFuel()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		if (noMoreFill)
		{
			return;
		}
		Vector3 val2 = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (!Physics.Raycast(doorRay.transform.position, val2, ref val, 5f, layerMask))
			{
				fillFuelButton.SetActive(false);
				fillFuelMeter.SetActive(false);
				playerHoldButton = false;
				fillingGasSoundHolder.SetActive(false);
			}
			else if (((Component)val.collider).gameObject.tag == "fueltankPlace")
			{
				if (!((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havegascan)
				{
					pickUpButton.SetActive(true);
					return;
				}
				fillFuelMeter.SetActive(true);
				fillFuelButton.SetActive(true);
				if (!playerHoldButton)
				{
					fillingGasSoundHolder.SetActive(false);
					return;
				}
				fillingGasSoundHolder.SetActive(true);
				if (!tanklockAnimPlayed)
				{
					tanklockAnimPlayed = true;
					tanklockAnim.GetComponent<Animation>().Play("tanklockOpen");
				}
				fillFuealBar.fillAmount += 0.1f * Time.deltaTime;
				if (fillFuealBar.fillAmount >= 1f)
				{
					((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressCar += 6;
					((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).fuelOK = true;
					fillFuelMeter.SetActive(false);
					fillFuelButton.SetActive(false);
					Object.Destroy((Object)(object)((Component)val.collider).gameObject);
					tanklockAnim.GetComponent<Animation>().Play("tanklockClose");
					fillingGasSoundHolder.SetActive(false);
					if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 16)
					{
						AchievementSaveManager.Instance.UnlockAchievement("SmellOfGasoline");
					}
				}
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
				{
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
					{
						((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
						Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
					}
					else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
					{
						Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else
					{
						Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
					}
				}
			}
			else if (((Component)val.collider).gameObject.tag == "golv")
			{
				fillFuelButton.SetActive(false);
				fillFuelMeter.SetActive(false);
				playerHoldButton = false;
				fillingGasSoundHolder.SetActive(false);
			}
			else if (((Component)val.collider).gameObject.tag == "Untagged")
			{
				fillFuelButton.SetActive(false);
				fillFuelMeter.SetActive(false);
				playerHoldButton = false;
				fillingGasSoundHolder.SetActive(false);
			}
		}
		else
		{
			fillFuelButton.SetActive(false);
			fillFuelMeter.SetActive(false);
			playerHoldButton = false;
			fillingGasSoundHolder.SetActive(false);
		}
	}
}
