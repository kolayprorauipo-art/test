using System;
using UnityEngine;

[Serializable]
public class tryckplatta : MonoBehaviour
{
	public GameObject slideDoor;

	public bool ironKlumpOnPlace;

	public Texture bildVit;

	public Texture bildGreen;

	public GameObject standOnPlatta;

	public AudioClip tryckplattaLjud;

	public GameObject soundHolder;

	public virtual void Update()
	{
		if (ironKlumpOnPlace)
		{
			((doorSlide)(object)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = true;
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !ironKlumpOnPlace)
		{
			((doorSlide)(object)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = true;
			((haveObjects)(object)standOnPlatta.GetComponent(typeof(haveObjects))).playerStandOnPlatta = true;
			AudioSource.PlayClipAtPoint(tryckplattaLjud, ((Component)this).transform.position);
			((doorSlide)(object)soundHolder.GetComponent(typeof(doorSlide))).StartSound();
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !ironKlumpOnPlace)
		{
			((doorSlide)(object)slideDoor.GetComponent(typeof(doorSlide))).plattaTryck = false;
			((haveObjects)(object)standOnPlatta.GetComponent(typeof(haveObjects))).playerStandOnPlatta = false;
			((doorSlide)(object)soundHolder.GetComponent(typeof(doorSlide))).StartSound();
		}
	}
}
