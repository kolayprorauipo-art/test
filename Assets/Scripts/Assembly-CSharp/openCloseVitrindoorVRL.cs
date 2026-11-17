using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class openCloseVitrindoorVRL : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("VitrindoorVRLOpen"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			((Component)this).GetComponent<Collider>().enabled = false;
			DoorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
			Innerdoor.carving = ((Behaviour)this).enabled;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("VitrindoorVRLClose"))
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
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "vitrindoorVRLopen";
		((Component)this).GetComponent<Collider>().enabled = true;
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(1f);
		((Component)this).gameObject.tag = "vitrindoorVRLclosed";
		Innerdoor.carving = !((Behaviour)this).enabled;
		((Component)this).GetComponent<Collider>().enabled = true;
	}
}
