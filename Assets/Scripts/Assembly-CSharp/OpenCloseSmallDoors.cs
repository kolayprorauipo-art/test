using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseSmallDoors : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public bool doorLocked;

	public AudioClip doorLockedLjud;

	public NavMeshObstacle obs;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			obs = ((Component)this).GetComponent<NavMeshObstacle>();
			((Behaviour)obs).enabled = false;
		}
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorOpen"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorOpen);
			DoorOpen = true;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			Innerdoor.carving = ((Behaviour)this).enabled;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorClose"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorClose);
			DoorOpen = false;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorLocked") && !doorLocked)
		{
			doorLocked = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLockedLjud);
			((MonoBehaviour)this).StartCoroutine(timerDoorlocked());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "smalldoorOpen";
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(0.66f);
		((Component)this).gameObject.tag = "smalldoorClosed";
		Innerdoor.carving = !((Behaviour)this).enabled;
		DoorMoving = false;
	}

	public virtual IEnumerator timerDoorlocked()
	{
		yield return (object)new WaitForSeconds(1f);
		doorLocked = false;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (DoorMoving)
		{
			if (((Component)other).gameObject.tag == "Player")
			{
				Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<CharacterController>(), true);
			}
		}
		else if (!DoorMoving && ((Component)other).gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<CharacterController>(), false);
		}
	}
}
