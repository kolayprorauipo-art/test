using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class openCloseBaklucka : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public AudioClip doorLockedLjud;

	public AudioClip doorUnLockedLjud;

	public bool doorLocked;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("bakluckaOpen"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorOpen);
			DoorOpen = true;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("bakluckaClose"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "bakluckaOpen";
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "bakluckaClosed";
		doorLocked = false;
		DoorMoving = false;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (DoorMoving)
		{
			if (((Component)other).gameObject.tag == "Player")
			{
				Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), ((Component)other).GetComponent<Collider>(), true);
			}
		}
		else if (!DoorMoving)
		{
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), ((Component)other).GetComponent<Collider>(), false);
		}
	}
}
