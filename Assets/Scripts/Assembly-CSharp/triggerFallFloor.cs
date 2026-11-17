using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class triggerFallFloor : MonoBehaviour
{
	public GameObject bit1;

	public GameObject bit2;

	public GameObject bit3;

	public GameObject bit4;

	public GameObject soundHolder;

	public GameObject placePlankTrigger;

	public bool TouchedFloor;

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !TouchedFloor)
		{
			TouchedFloor = true;
			((Rigidbody)bit1.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit2.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit3.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)bit4.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((placePlanka)(object)placePlankTrigger.GetComponent(typeof(placePlanka))).holeOpen = true;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).playerFallFloor();
			yield return (object)new WaitForSeconds(1.5f);
			((Collider)((Component)bit1.transform.GetChild(0)).GetComponent<BoxCollider>()).enabled = true;
			((Collider)((Component)bit2.transform.GetChild(0)).GetComponent<BoxCollider>()).enabled = true;
			((Collider)((Component)bit3.transform.GetChild(0)).GetComponent<BoxCollider>()).enabled = true;
			((Collider)((Component)bit4.transform.GetChild(0)).GetComponent<BoxCollider>()).enabled = true;
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
