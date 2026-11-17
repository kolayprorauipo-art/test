using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseKyl : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public GameObject GameController;

	public GameObject Player;

	public GameObject PlayerCam;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		Player = GameController.GetComponent<startNewDay>().Player;
		PlayerCam = ((Component)GameController.GetComponent<startNewDay>().playerCam).gameObject;
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("KylOpen"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
			DoorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
			Innerdoor.carving = ((Behaviour)this).enabled;
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("KylClose"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
			DoorOpen = false;
			((Component)this).gameObject.tag = "Untagged";
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "kylOpen";
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "kylClosed";
		Innerdoor.carving = !((Behaviour)this).enabled;
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
	}
}
