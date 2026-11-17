using System;
using UnityEngine;

[Serializable]
public class IfgarderobDoorOpens : MonoBehaviour
{
	public GameObject gardeDoorH;

	public GameObject doorButton;

	public GameObject nos;

	public GameObject doorV;

	public GameObject doorH;

	public bool doorsClosed;

	public GameObject player;

	public AudioClip gardeDoorsOpen;

	public IfgarderobDoorOpens()
	{
		doorsClosed = true;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (doorsClosed && ((Component)this).GetComponent<Animation>().IsPlaying("VgarderobDoorOpen"))
		{
			doorsClosed = false;
			gardeDoorH.GetComponent<Animation>().Play("HgarderobDoorOpen");
			doorV.gameObject.tag = "Untagged";
			doorH.gameObject.tag = "Untagged";
			((AIfollow)(object)nos.GetComponent(typeof(AIfollow))).playerHiding = false;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 6f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 8f;
			doorButton.SetActive(false);
			AudioSource.PlayClipAtPoint(gardeDoorsOpen, ((Component)this).transform.position);
		}
	}
}
