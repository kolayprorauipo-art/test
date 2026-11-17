using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseKitchenDoor2 : MonoBehaviour
{
	public bool DoorOpen;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("KitchenDoor2Open"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			((Component)this).GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("KitchenDoor2Close"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			((Component)this).GetComponent<Collider>().enabled = false;
			DoorOpen = false;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(0.5f);
		((Component)this).gameObject.tag = "kitchenDoor2Open";
		((Component)this).GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(0.5f);
		((Component)this).gameObject.tag = "kitchenDoor2Closed";
		((Component)this).GetComponent<Collider>().enabled = true;
	}
}
