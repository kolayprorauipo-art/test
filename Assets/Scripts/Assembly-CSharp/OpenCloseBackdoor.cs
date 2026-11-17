using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseBackdoor : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public NavMeshObstacle Innerdoor;

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
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("BackDoorOpen"))
		{
			if (((Component)this).gameObject.tag == "innerdoorLocked")
			{
				((Component)this).GetComponent<AudioSource>().PlayOneShot(doorUnLockedLjud);
			}
			else
			{
				((Component)this).GetComponent<AudioSource>().PlayOneShot(doorOpen);
			}
			DoorOpen = true;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			Innerdoor.carving = ((Behaviour)this).enabled;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("BackDoorClose"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("BackDoorLocked") && !doorLocked)
		{
			doorLocked = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
			((MonoBehaviour)this).StartCoroutine(timerDoorlocked());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorOpen";
		DoorMoving = false;
		yield return (object)new WaitForSeconds(3f);
		((Component)this).gameObject.GetComponent<Animation>().Play("InnerdoorClose");
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorLocked";
		Innerdoor.carving = !((Behaviour)this).enabled;
		doorLocked = false;
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorlocked()
	{
		yield return (object)new WaitForSeconds(1.3f);
		doorLocked = false;
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
