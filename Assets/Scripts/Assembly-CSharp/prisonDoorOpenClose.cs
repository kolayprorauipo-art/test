using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class prisonDoorOpenClose : MonoBehaviour
{
	public bool DoorOpen;

	public bool DoorMoving;

	public AudioClip doorOpen;

	public AudioClip doorClose;

	public AudioClip doorLockedLjud;

	public bool doorLocked;

	public bool sprint1Bort;

	public bool sprint2Bort;

	public GameObject sprint1;

	public GameObject sprint2;

	public bool doorFree;

	public GameObject sparcle1;

	public GameObject sparcle2;

	public GameObject galler;

	public GameObject gallerColliders;

	public GameObject doorTrigger;

	public GameObject camSeeTrigger;

	public GameObject camSound;

	public GameObject bottomCollider;

	public bool doorOpenAgain;

	public GameObject granny;

	public prisonDoorOpenClose()
	{
		DoorOpen = true;
	}

	public virtual void Start()
	{
		DoorOpen = true;
	}

	public virtual void Update()
	{
		if (!sprint1Bort || !sprint2Bort)
		{
			if (!DoorOpen)
			{
				if (((Component)this).GetComponent<Animation>().IsPlaying("prisondoorOpen"))
				{
					((Component)this).GetComponent<AudioSource>().PlayOneShot(doorOpen);
					DoorOpen = true;
					DoorMoving = true;
					((Component)this).gameObject.tag = "Untagged";
					((MonoBehaviour)this).StartCoroutine(timerDooropen());
				}
				else
				{
					DoorMoving = false;
				}
			}
			if (DoorOpen)
			{
				if (((Component)this).GetComponent<Animation>().IsPlaying("prisondoorClose"))
				{
					((Component)this).GetComponent<AudioSource>().PlayOneShot(doorClose);
					DoorOpen = false;
					DoorMoving = true;
					((Component)this).gameObject.tag = "Untagged";
					((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
				}
				else
				{
					DoorMoving = false;
				}
			}
			if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("prisondoorLocked") && !doorLocked)
			{
				doorLocked = true;
				timerDoorlocked();
			}
		}
		if (sprint1Bort && sprint2Bort && !doorFree)
		{
			doorFree = true;
			((MonoBehaviour)this).StartCoroutine(doorLoose());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(1f);
		DoorMoving = false;
		if ((Object)(object)GameObject.Find("Sprint1") != (Object)null)
		{
			sprint1.gameObject.tag = "Untagged";
		}
		if ((Object)(object)GameObject.Find("Sprint2") != (Object)null)
		{
			sprint2.gameObject.tag = "Untagged";
		}
		if ((Object)(object)GameObject.Find("Sparkle1") != (Object)null)
		{
			sparcle1.SetActive(false);
		}
		if ((Object)(object)GameObject.Find("Sparkle2") != (Object)null)
		{
			sparcle2.SetActive(false);
		}
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "prisondoorlocked";
		doorTrigger.SetActive(true);
		if ((Object)(object)GameObject.Find("Sprint1") != (Object)null)
		{
			sprint1.gameObject.tag = "sprint1";
		}
		if ((Object)(object)GameObject.Find("Sprint2") != (Object)null)
		{
			sprint2.gameObject.tag = "sprint2";
		}
		doorLocked = false;
		DoorMoving = false;
		yield return (object)new WaitForSeconds(30f);
		if (((Component)this).gameObject.tag == "prisondoorlocked")
		{
			if ((Object)(object)GameObject.Find("Sprint1") != (Object)null)
			{
				sparcle1.SetActive(true);
			}
			if ((Object)(object)GameObject.Find("Sprint2") != (Object)null)
			{
				sparcle2.SetActive(true);
			}
		}
	}

	public virtual void timerDoorlocked()
	{
	}

	public virtual IEnumerator doorLoose()
	{
		galler.GetComponent<Collider>().enabled = true;
		gallerColliders.SetActive(false);
		camSeeTrigger.SetActive(false);
		yield return (object)new WaitForSeconds(2f);
		doorTrigger.SetActive(false);
		((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
		((Rigidbody)((Component)this).GetComponent(typeof(Rigidbody))).isKinematic = false;
		((MeshCollider)((Component)this).GetComponent(typeof(MeshCollider))).convex = true;
		((Component)this).gameObject.tag = "Untagged";
		if ((Object)(object)GameObject.Find("Kameralampa") != (Object)null)
		{
			((camLampBlink)(object)camSound.GetComponent(typeof(camLampBlink))).soundOff = true;
		}
		yield return (object)new WaitForSeconds(15f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "granny" && (((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer || ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow || ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject) && !doorFree && !doorOpenAgain)
		{
			doorOpenAgain = true;
			((Component)this).GetComponent<Animation>().Play("prisondoorOpen");
			doorTrigger.SetActive(false);
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison = false;
			camSeeTrigger.SetActive(false);
		}
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
