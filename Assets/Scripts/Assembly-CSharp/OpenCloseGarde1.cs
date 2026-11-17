using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class OpenCloseGarde1 : MonoBehaviour
{
	public bool DoorOpen;

	public NavMeshObstacle Innerdoor;

	public AudioClip doorLjud;

	public AudioClip doorLjud2;

	public bool DoorMoving;

	public GameObject Player;

	public GameObject PlayerCam;

	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		Player = GameController.GetComponent<startNewDay>().Player;
		PlayerCam = ((Component)GameController.GetComponent<startNewDay>().playerCam).gameObject;
	}

	public virtual void Update()
	{
		if (!DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("Garde1Open"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud);
			DoorOpen = true;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			Innerdoor.carving = ((Behaviour)this).enabled;
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
			((MonoBehaviour)this).StartCoroutine(timerDooropen());
		}
		if (DoorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("Garde1Close"))
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(doorLjud2);
			DoorOpen = false;
			DoorMoving = true;
			((Component)this).gameObject.tag = "Untagged";
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), true);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), true);
			((MonoBehaviour)this).StartCoroutine(timerDoorclosed());
		}
	}

	public virtual IEnumerator timerDooropen()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "garde1Open";
		DoorMoving = false;
		yield return (object)new WaitForSeconds(0.3f);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), false);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), false);
	}

	public virtual IEnumerator timerDoorclosed()
	{
		yield return (object)new WaitForSeconds(0.2f);
		((Component)this).gameObject.tag = "garde1Closed";
		Innerdoor.carving = !((Behaviour)this).enabled;
		DoorMoving = false;
		yield return (object)new WaitForSeconds(0.3f);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), Player.GetComponent<Collider>(), false);
		Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), PlayerCam.GetComponent<Collider>(), false);
	}
}
