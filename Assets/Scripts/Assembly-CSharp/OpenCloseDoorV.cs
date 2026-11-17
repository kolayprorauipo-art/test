using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseDoorV : MonoBehaviour
{
	public bool doorOpen;

	public float doorHealth;

	public bool doorDead;

	public GameObject doorStop;

	public AudioClip doorDeadLjud;

	public virtual void Start()
	{
		doorHealth = 100f;
	}

	public virtual void Update()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (doorHealth <= 0f && !doorDead)
		{
			doorDead = true;
			((Component)this).GetComponent<Animation>().Play("InnerDoorVSmash");
			((Component)this).gameObject.tag = "Untagged";
			((Component)this).GetComponent<Collider>().enabled = false;
			doorStop.SetActive(false);
			AudioSource.PlayClipAtPoint(doorDeadLjud, ((Component)this).transform.position);
			((MonoBehaviour)this).StartCoroutine(removeDoor());
		}
		if (!doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerDoorHOpen"))
		{
			doorOpen = true;
			((Component)this).gameObject.tag = null;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerDoorHClose"))
		{
			doorOpen = false;
			((Component)this).gameObject.tag = null;
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
		if (!doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerDoorVOpen"))
		{
			doorOpen = true;
			((Component)this).gameObject.tag = null;
			((MonoBehaviour)this).StartCoroutine(timerDoorVopen());
		}
		if (doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("InnerDoorVClose"))
		{
			doorOpen = false;
			((Component)this).gameObject.tag = null;
			((MonoBehaviour)this).StartCoroutine(timerDoorVclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorHOpen";
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorHClosed";
	}

	public virtual IEnumerator timerDoorVopen()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorVOpen";
	}

	public virtual IEnumerator timerDoorVclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "innerdoorVClosed";
	}

	public virtual IEnumerator removeDoor()
	{
		yield return (object)new WaitForSeconds(10f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
