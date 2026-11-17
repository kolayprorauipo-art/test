using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class bedButton : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject underBed;

	public GameObject underBedCam;

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
			HindeInBed();
		}
	}

	public void HindeInBed()
	{
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if ((Time.timeScale != 0f || PlayerPrefs.GetInt("DiffData") == -1 || PlayerHiding || !(Vector3.Distance(player.transform.position, GameObject.Find("GrannyParent").transform.position) < 5f)) && CanHide)
		{
			if (!PlayerHiding)
			{
				player.SetActive(false);
				PlayerHiding = true;
				underBed.SetActive(true);
				underBedCam.transform.localEulerAngles = new Vector3(0f, -90f, 0f);
				PlayerHiding = true;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = true;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = true;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerNearGranny = false;
				joystick.SetActive(false);
				crouchButton.SetActive(false);
				shootButtonHolder.SetActive(false);
				shootGunButtonHolder.SetActive(false);
				sprayButtonHolder.SetActive(false);
				dropButtonHolder.SetActive(false);
				pickupButton.SetActive(false);
				openDoorButton.SetActive(false);
				mittenRing.SetActive(false);
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).underBed();
			}
			else
			{
				underBed.SetActive(false);
				player.transform.position = playerPosition.transform.position;
				player.SetActive(true);
				player.transform.localEulerAngles = new Vector3(0f, 90f, 0f);
				PlayerHiding = false;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHidingUnderBed = false;
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hidingUnderBed1 = false;
				joystick.SetActive(true);
				crouchButton.SetActive(true);
				dropButtonHolder.SetActive(true);
				shootButtonHolder.SetActive(true);
				shootGunButtonHolder.SetActive(true);
				sprayButtonHolder.SetActive(true);
				spraySoundholder.SetActive(false);
				sprayParticle.SetActive(false);
				((sprayPepper)(object)sprayButton.GetComponent(typeof(sprayPepper))).sprayTime = false;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).fromBed();
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
