using System;
using UnityEngine;

[Serializable]
public class triggerCloseGarderobdoor : MonoBehaviour
{
	public GameObject doorV;

	public GameObject doorH;

	public bool playerInLocker;

	public GameObject doorButton;

	public GameObject nos;

	public GameObject player;

	public AudioClip gardeDoorsClose;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player")
		{
			playerInLocker = true;
			doorButton.SetActive(true);
			doorV.GetComponent<Animation>().Play("VgarderobDoorClose");
			doorH.GetComponent<Animation>().Play("HgarderobDoorClose");
			((IfgarderobDoorOpens)(object)doorV.GetComponent(typeof(IfgarderobDoorOpens))).doorsClosed = true;
			((IfHgarderobDoorOpens)(object)doorH.GetComponent(typeof(IfHgarderobDoorOpens))).doorsClosed = true;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 1f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 1f;
			((AIfollow)(object)nos.GetComponent(typeof(AIfollow))).playerHiding = true;
			doorV.gameObject.tag = "garderobDoorV";
			doorH.gameObject.tag = "garderobDoorH";
			AudioSource.PlayClipAtPoint(gardeDoorsClose, ((Component)this).transform.position);
		}
	}
}
