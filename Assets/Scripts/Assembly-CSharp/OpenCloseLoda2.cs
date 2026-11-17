using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class OpenCloseLoda2 : MonoBehaviour
{
	public bool DoorOpen;

	public AudioClip LodaUt;

	public AudioClip LodaIn;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("Loda2Open"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(LodaUt);
			DoorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("Loda2Close"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(LodaIn);
			DoorOpen = false;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "loda2Open";
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "loda2Closed";
	}
}
