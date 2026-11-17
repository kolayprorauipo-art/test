using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseOldDoor : MonoBehaviour
{
	public bool DoorOpen;

	public GameObject doorStop;

	public bool DoorBlocked;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorOpen"))
		{
			DoorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
			((enableDisableCarve)(object)doorStop.GetComponent(typeof(enableDisableCarve))).doorOpenCarve = true;
			((Component)this).GetComponent<Collider>().enabled = false;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorClose"))
		{
			DoorOpen = false;
			((Component)this).gameObject.tag = "Untagged";
			((enableDisableCarve)(object)doorStop.GetComponent(typeof(enableDisableCarve))).doorOpenCarve = false;
			((Component)this).GetComponent<Collider>().enabled = false;
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
		if (DoorBlocked)
		{
			((Component)this).gameObject.tag = "doorLockedNoKey";
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(2f);
		((Component)this).gameObject.tag = "doorOpen";
		((Component)this).GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		if (!DoorBlocked)
		{
			yield return (object)new WaitForSeconds(2f);
			((Component)this).gameObject.tag = "doorClosed";
			((Component)this).GetComponent<Collider>().enabled = true;
		}
		else
		{
			yield return (object)new WaitForSeconds(1f);
			((Component)this).GetComponent<Collider>().enabled = true;
		}
	}
}
