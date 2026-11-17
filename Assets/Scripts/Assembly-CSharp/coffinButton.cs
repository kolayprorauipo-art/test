using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class coffinButton : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject inCoffin;

	public GameObject underBedCam;

	public GameObject coffinLock;

	public GameObject playerPosition;

	public bool PlayerHiding;

	public bool CanHide;

	public GameObject joystick;

	public GameObject crouchButton;

	public GameObject soundHolder;

	public GameObject dropButtonHolder;

	public GameObject shootButtonHolder;

	public GameObject shootGunButtonHolder;

	public GameObject sprayButtonHolder;

	public GameObject spraySoundholder;

	public GameObject sprayButton;

	public GameObject sprayParticle;

	public GameObject pickupButton;

	public GameObject openDoorButton;

	public GameObject mittenRing;

	public Sprite hideTexture;

	public Sprite UnhideTexture;

	public Image button;

	public Button btn1;

	public float lockRotXNer;

	public float lockRotXUpp;

	public virtual void Start()
	{
		button.sprite = hideTexture;
		PlayerHiding = false;
		CanHide = true;
	}

	public void Update()
	{
		if (Input.GetKeyDown((KeyCode)114))
		{
			HideUnderCoffin();
		}
	}

	public void HideUnderCoffin()
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (Time.timeScale != 0f && CanHide)
		{
			if (!PlayerHiding)
			{
				player.SetActive(false);
				PlayerHiding = true;
				inCoffin.SetActive(true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
				coffinLock.transform.localEulerAngles = new Vector3(lockRotXNer, 0f, 0f);
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffin = true;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffin4 = true;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				dropButtonHolder.SetActive(false);
				shootButtonHolder.SetActive(false);
				shootGunButtonHolder.SetActive(false);
				sprayButtonHolder.SetActive(false);
				pickupButton.SetActive(false);
				openDoorButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).CoffinIn();
			}
			else
			{
				inCoffin.SetActive(false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(true);
				player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
				coffinLock.transform.localEulerAngles = new Vector3(lockRotXUpp, 0f, 0f);
				PlayerHiding = false;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingInCoffin = false;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hidingInCoffin4 = false;
				joystick.SetActive(true);
				crouchButton.SetActive(true);
				dropButtonHolder.SetActive(true);
				shootButtonHolder.SetActive(true);
				shootGunButtonHolder.SetActive(true);
				sprayButtonHolder.SetActive(true);
				spraySoundholder.SetActive(false);
				sprayParticle.SetActive(false);
				((sprayPepper)(object)sprayButton.GetComponent(typeof(sprayPepper))).sprayTime = false;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).CoffinUt();
			}
			if (PlayerHiding)
			{
				button.sprite = UnhideTexture;
				((MonoBehaviour)this).StartCoroutine(UnhideDisappear());
			}
			else
			{
				button.sprite = hideTexture;
				((MonoBehaviour)this).StartCoroutine(UnhideDisappear());
			}
		}
	}

	public virtual IEnumerator UnhideDisappear()
	{
		((Graphic)button).color = Color.gray;
		CanHide = false;
		yield return (object)new WaitForSeconds(1.5f);
		((Graphic)button).color = Color.white;
		CanHide = true;
	}

	public virtual void OnEnable()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		button.sprite = hideTexture;
		PlayerHiding = false;
		((Graphic)button).color = Color.white;
		CanHide = true;
	}
}
