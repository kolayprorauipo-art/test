using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class placePlanka : MonoBehaviour
{
	public GameObject gameController;

	public GameObject highlightPlanka;

	public bool holeOpen;

	public bool startText;

	public GameObject PlaceButton;

	public GameObject text;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (!(((Component)other).gameObject.tag == "Player"))
		{
			return;
		}
		if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplanka)
		{
			highlightPlanka.SetActive(true);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = true;
			PlaceButton.SetActive(true);
			return;
		}
		highlightPlanka.SetActive(false);
		((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
		if (Object.op_Implicit((Object)(object)GameObject.FindWithTag("plankawalk")) && holeOpen && !startText)
		{
			startText = true;
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).PlanktextTimer();
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			if (((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).haveplanka)
			{
				highlightPlanka.SetActive(true);
				((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = true;
				PlaceButton.SetActive(true);
			}
			else
			{
				highlightPlanka.SetActive(false);
				((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
			}
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			highlightPlanka.SetActive(false);
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).plankaHighlighted = false;
			PlaceButton.SetActive(false);
		}
	}

	public virtual IEnumerator textTimer()
	{
		yield return (object)new WaitForSeconds(3f);
		text.SetActive(true);
		yield return (object)new WaitForSeconds(3f);
		text.SetActive(false);
	}
}
