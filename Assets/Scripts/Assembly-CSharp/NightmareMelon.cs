using UnityEngine;

public class NightmareMelon : MonoBehaviour
{
	public GameObject gameController;

	public int RandomItem;

	private void Start()
	{
		gameController = GameObject.Find("GameController");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "kitchenDoor2Open")
		{
			Physics.IgnoreCollision(((Component)this).gameObject.GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<BoxCollider>(), true);
			RandomItem = Random.Range(1, 26);
			if (RandomItem == 1)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newsafeKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 2)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newexitKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 3)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newhanglockKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 4)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newweaponKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 5)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newplayhouseKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 6)
			{
				Object.Instantiate<GameObject>(gameController.GetComponent<InventoryController>().newStick, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 7)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newkugg2, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 8)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newcarKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 9)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newsparkplug, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 10)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newTVRemote.transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 11)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newButtonNewEscape.transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 12)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newsafeKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 13)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newexitKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 14)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newhanglockKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 15)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newweaponKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 16)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newplayhouseKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 17)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newkugg1, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 18)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newsafeKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 19)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newcarKey, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 20)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newsparkplug, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 21)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newTVRemote.transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 22)
			{
				Object.Instantiate<Transform>(gameController.GetComponent<InventoryController>().newButtonNewEscape.transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 23)
			{
				Object.Instantiate<GameObject>(gameController.GetComponent<InventoryController>().newNightmareHammer, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			if (RandomItem == 24)
			{
				Object.Instantiate<Transform>(((Component)gameController.GetComponent<InventoryController>().newArrow).transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
				AchievementSaveManager.Instance.UnlockAchievement("GotUnluky");
			}
			if (RandomItem == 25)
			{
				Object.Instantiate<Transform>(((Component)gameController.GetComponent<InventoryController>().newmelon).transform, ((Component)this).gameObject.transform.position, ((Component)this).gameObject.transform.rotation);
			}
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
