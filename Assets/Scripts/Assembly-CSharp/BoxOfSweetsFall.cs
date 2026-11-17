using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class BoxOfSweetsFall : MonoBehaviour
{
	public GameObject GameController;

	public bool StartFall;

	public GameObject CaramelKey;

	public GameObject ChocolateKey;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		CaramelKey = GameController.GetComponent<InventoryController>().newRedKey;
		ChocolateKey = GameController.GetComponent<InventoryController>().newChocolateKey;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		if ((((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "Untagged") && StartFall && ((Component)this).gameObject.transform.position.y < 16f)
		{
			if (PlayerPrefs.GetInt("Anomaly27Levels") == 4)
			{
				((Object)((Component)this).gameObject).name = "BoxDropped";
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 0.5f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 1f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 1.25f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 1.5f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 1.75f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 2f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 2.25f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				StartFall = false;
				((MonoBehaviour)this).StartCoroutine(BoxOfSweetsDisappear());
			}
			else
			{
				((Object)((Component)this).gameObject).name = "BoxDropped";
				Object.Instantiate<GameObject>(CaramelKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 0.5f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				Object.Instantiate<GameObject>(ChocolateKey, new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y + 1f, ((Component)this).gameObject.transform.position.z), Quaternion.identity);
				StartFall = false;
				((MonoBehaviour)this).StartCoroutine(BoxOfSweetsDisappear());
			}
		}
	}

	public virtual IEnumerator BoxOfSweetsDisappear()
	{
		yield return (object)new WaitForSeconds(12f);
		((Component)this).gameObject.SetActive(false);
	}
}
