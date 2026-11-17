using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class dropObjects : MonoBehaviour
{
	public GameObject gameController;

	public Button btn1;

	private void Update()
	{
		if (Input.GetKeyDown((KeyCode)32) || Input.GetKeyDown((KeyCode)113))
		{
			DropItemButton();
		}
	}

	public void DropItemButton()
	{
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR != 7 && !((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomaly7CantDrop)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).CheckInventory();
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).NoObjectText();
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 7)
			{
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomaly7Timer = 0f;
			}
		}
	}
}
