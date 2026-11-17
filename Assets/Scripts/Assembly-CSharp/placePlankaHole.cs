using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class placePlankaHole : MonoBehaviour
{
	public GameObject gameController;

	public Button btn1;

	private void Update()
	{
		if (Input.GetKeyDown((KeyCode)102))
		{
			PlacePlankaButton();
		}
	}

	public void PlacePlankaButton()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (gameController.GetComponent<startNewDay>().Player.transform.position.y > 17.5f)
		{
			((InventoryController)(object)gameController.GetComponent(typeof(InventoryController))).placePlankaHole();
			return;
		}
		if (gameController.GetComponent<startNewDay>().Player.transform.position.y < 17.5f && gameController.GetComponent<startNewDay>().Player.transform.position.y > 8.5f)
		{
			GameObject.Find("PlankPlace").GetComponent<DeliverShotgunParts>().PlacePlanka();
			gameController.GetComponent<startNewDay>().PlankaHighlightReady.SetActive(false);
			((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).ProgressLift += 6;
		}
		if (gameController.GetComponent<startNewDay>().Player.transform.position.y < 8.5f || gameController.GetComponent<startNewDay>().AnomalyNR == 18)
		{
			GameObject.Find("DeliverShotgunParts (1)").GetComponent<DeliverShotgunParts>().PlaceShotgunParts();
		}
	}
}
