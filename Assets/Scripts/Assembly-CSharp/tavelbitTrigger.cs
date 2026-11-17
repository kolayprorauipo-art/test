using System;
using UnityEngine;

[Serializable]
public class tavelbitTrigger : MonoBehaviour
{
	public GameObject gameController;

	public GameObject tb1Ram;

	public GameObject tb2Ram;

	public GameObject tb3Ram;

	public GameObject tb4Ram;

	public GameObject tb1Hand;

	public GameObject tb2Hand;

	public GameObject tb3Hand;

	public GameObject tb4Hand;

	public GameObject dropObjectButton;

	public GameObject mittenRing;

	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (!(((Component)other).gameObject.tag == "Player"))
		{
			return;
		}
		if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb1)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb1 = false;
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).tavelbit1 = true;
			tb1Ram.SetActive(true);
			tb1Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR == 13)
			{
				gameController.GetComponent<startNewDay>().ProgressBehavior++;
			}
		}
		else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb2)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb2 = false;
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).tavelbit2 = true;
			tb2Ram.SetActive(true);
			tb2Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR == 13)
			{
				gameController.GetComponent<startNewDay>().ProgressBehavior++;
			}
		}
		else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb3)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb3 = false;
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).tavelbit3 = true;
			tb3Ram.SetActive(true);
			tb3Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR == 13)
			{
				gameController.GetComponent<startNewDay>().ProgressBehavior++;
			}
		}
		else if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb4)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).havetb4 = false;
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).tavelbit4 = true;
			tb4Ram.SetActive(true);
			tb4Hand.SetActive(false);
			dropObjectButton.SetActive(false);
			mittenRing.SetActive(false);
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).tavelbitPlace();
			if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR == 13)
			{
				gameController.GetComponent<startNewDay>().ProgressBehavior++;
			}
		}
	}
}
