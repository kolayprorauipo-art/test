using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class PlayerWindowController : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject window;

	public GameObject camIndoor;

	public GameObject camOutdoor;

	public Transform PlayerOutPos;

	public Transform PlayerInPos;

	public GameObject crouchButton;

	public GameObject holeCollider;

	public GameObject SoundOut;

	public GameObject SoundIn;

	public GameObject camLadder;

	public Animation ClimbLadderAnim;

	public virtual void Start()
	{
	}

	public virtual void jumpOut()
	{
		((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		player.SetActive(false);
		camIndoor.SetActive(true);
		holeCollider.SetActive(true);
		window.gameObject.GetComponent<Animation>().Play("WindowOpenClose");
		camIndoor.gameObject.GetComponent<Animation>().Play("CamInToOut");
		((backgroundSound)(object)SoundOut.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)(object)SoundIn.GetComponent(typeof(backgroundSound))).fadeUp = true;
		((MonoBehaviour)this).StartCoroutine(playerSpawnOutside());
	}

	public virtual void jumpIn()
	{
		((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		player.SetActive(false);
		camOutdoor.SetActive(true);
		holeCollider.SetActive(true);
		window.gameObject.GetComponent<Animation>().Play("WindowOpenClose");
		camOutdoor.gameObject.GetComponent<Animation>().Play("CamOutToIn");
		((backgroundSound)(object)SoundIn.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)(object)SoundOut.GetComponent(typeof(backgroundSound))).fadeUp = true;
		((MonoBehaviour)this).StartCoroutine(playerSpawnInside());
	}

	public virtual void ClimbLadder()
	{
		player.SetActive(false);
		camLadder.SetActive(true);
		ClimbLadderAnim.Play();
		((MonoBehaviour)this).StartCoroutine(playerSpawnInRoof());
	}

	public virtual IEnumerator playerSpawnOutside()
	{
		yield return (object)new WaitForSeconds(2.1f);
		player.transform.position = PlayerOutPos.position;
		player.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
		player.SetActive(true);
		camIndoor.SetActive(false);
		crouchButton.SetActive(true);
		holeCollider.SetActive(false);
	}

	public virtual IEnumerator playerSpawnInside()
	{
		yield return (object)new WaitForSeconds(1.75f);
		player.transform.position = PlayerInPos.position;
		player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		player.SetActive(true);
		camOutdoor.SetActive(false);
		crouchButton.SetActive(true);
		holeCollider.SetActive(false);
	}

	public virtual IEnumerator playerSpawnInRoof()
	{
		yield return (object)new WaitForSeconds(3.2f);
		player.transform.position = new Vector3(27.97f, 17.79f, -9.13f);
		player.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
		player.SetActive(true);
		camLadder.SetActive(false);
		crouchButton.SetActive(true);
	}
}
