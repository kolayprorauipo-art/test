using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class seeBearTrap : MonoBehaviour
{
	public int layerMask;

	public Image button;

	public Image removeBar;

	public GameObject SeeRay;

	public bool destroyTrap;

	public bool playerTaken;

	public GameObject player;

	public GameObject joystick;

	public GameObject crawlButton;

	public GameObject allBedButtons;

	public AudioClip removeBeartrapSound;

	public AudioClip removeBeartrapOrganicSound;

	public seeBearTrap()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
	}

	public virtual void Update()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (Input.GetKeyDown((KeyCode)116) && PlayerPrefs.GetInt("PrimeOn") == 0)
		{
			((MonoBehaviour)this).StartCoroutine(FixSoftLock());
		}
		RaycastHit val = default;
		Vector3 val2 = SeeRay.transform.TransformDirection(Vector3.forward);
		if (playerTaken)
		{
			return;
		}
		if (Physics.Raycast(SeeRay.transform.position, val2, ref val, 5f, layerMask))
		{
			if (((Component)val.collider).gameObject.tag == "BearTrapActivated")
			{
				((Behaviour)button).enabled = true;
				((removeBeartrap)(object)((Component)button).GetComponent(typeof(removeBeartrap))).seeTrap = true;
				if (!destroyTrap)
				{
					return;
				}
				if (((Object)((Component)val.collider).gameObject).name == "BearTrapAnomaly17")
				{
					removeBar.fillAmount += 0.17f * Time.deltaTime;
				}
				else
				{
					removeBar.fillAmount += 0.5f * Time.deltaTime;
				}
				if (removeBar.fillAmount != 1f)
				{
					return;
				}
				removeBar.fillAmount = 0f;
				if (((Component)val.collider).gameObject.tag == "BearTrapActivated")
				{
					if (((Object)((Component)val.collider).gameObject).name == "BearTrapAnomaly17")
					{
						AchievementSaveManager.Instance.UnlockAchievement("NotASingleScratch");
					}
					if (PlayerPrefs.GetInt("PrimeOn") == 1)
					{
						Object.Destroy((Object)(object)((Component)val.collider).gameObject);
					}
					else
					{
						((Component)val.collider).gameObject.tag = "Untagged";
						((Collider)((Component)val.collider).gameObject.GetComponent<BoxCollider>()).enabled = false;
					}
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 5f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 4f;
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 5f;
					joystick.SetActive(true);
					crawlButton.SetActive(true);
					allBedButtons.SetActive(true);
					((removeBeartrap)(object)((Component)button).GetComponent(typeof(removeBeartrap))).seeTrap = false;
					((Component)crawlButton.transform.GetChild(0)).gameObject.GetComponent<playerCrawl>().standUp();
					((Behaviour)button).enabled = false;
					destroyTrap = false;
					((Component)this).GetComponent<AudioSource>().PlayOneShot(removeBeartrapSound);
					if (GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 24)
					{
						GameObject.Find("GameController").GetComponent<startNewDay>().Anomaly24PlayerInTrap = false;
					}
				}
			}
			else if (((Component)val.collider).gameObject.tag == "golv")
			{
				((removeBeartrap)(object)((Component)button).GetComponent(typeof(removeBeartrap))).seeTrap = false;
				((Behaviour)button).enabled = false;
				destroyTrap = false;
			}
		}
		else
		{
			((removeBeartrap)(object)((Component)button).GetComponent(typeof(removeBeartrap))).seeTrap = false;
			((Behaviour)button).enabled = false;
			destroyTrap = false;
		}
	}

	public void FixSoftLockButton()
	{
		((MonoBehaviour)this).StartCoroutine(FixSoftLock());
	}

	public virtual IEnumerator FixSoftLock()
	{
		if (player.GetComponent<CharacterController>().height > 2f)
		{
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 5f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 4f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 5f;
			joystick.SetActive(true);
			crawlButton.SetActive(true);
			allBedButtons.SetActive(true);
			((removeBeartrap)(object)((Component)button).GetComponent(typeof(removeBeartrap))).seeTrap = false;
			((Component)crawlButton.transform.GetChild(0)).gameObject.GetComponent<playerCrawl>().standUp();
			((Behaviour)button).enabled = false;
			destroyTrap = false;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(removeBeartrapSound);
		}
		yield break;
	}
}
