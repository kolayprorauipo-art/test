using System;
using UnityEngine;

[Serializable]
public class soundEffects : MonoBehaviour
{
	public AudioSource audioSource;

	public AudioSource audioSource2;

	public AudioClip PCaught;

	public AudioClip NoScreamersCaught;

	public AudioClip PCaughtNightmare;

	public AudioClip exitDoorOpen;

	public AudioClip playerHit;

	public AudioClip hukaSig;

	public AudioClip stand;

	public AudioClip bedNer;

	public AudioClip bedUpp;

	public AudioClip manakin;

	public AudioClip crossbowShoot;

	public AudioClip crossbowLoad;

	public AudioClip inCoffin;

	public AudioClip OutCoffin;

	public AudioClip landSound;

	public AudioClip landBRSound;

	public AudioClip fallFloor;

	public AudioClip placeTavelbit;

	public AudioClip gunShot;

	public AudioClip inCar;

	public AudioClip outCar;

	public AudioClip shotgunLoad;

	public AudioClip shotgunEmpty;

	public AudioClip pickUpLoaded;

	public AudioClip remoteSound;

	public virtual void Start()
	{
	}

	public virtual void playerCaught()
	{
		if (PlayerPrefs.GetInt("NoScreamersOnOff") == 0)
		{
			audioSource.PlayOneShot(PCaught);
		}
		else
		{
			audioSource.PlayOneShot(NoScreamersCaught);
		}
	}

	public virtual void playerCaughtNightmare()
	{
		if (PlayerPrefs.GetInt("NoScreamersOnOff") == 0)
		{
			audioSource.PlayOneShot(PCaught);
			audioSource.PlayOneShot(PCaughtNightmare);
		}
		else
		{
			audioSource.PlayOneShot(NoScreamersCaught);
		}
	}

	public virtual void openExitDoor()
	{
		audioSource.PlayOneShot(exitDoorOpen);
		if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 9 && Object.op_Implicit((Object)(object)GameObject.Find("CrowParent")))
		{
			PlayerPrefs.SetInt("Anomaly9Escape", 1);
		}
	}

	public virtual void playerGetHit()
	{
		audioSource.PlayOneShot(playerHit);
	}

	public virtual void hukarSig()
	{
		audioSource.PlayOneShot(hukaSig);
	}

	public virtual void standUp()
	{
		audioSource.PlayOneShot(stand);
	}

	public virtual void underBed()
	{
		audioSource2.PlayOneShot(bedNer);
	}

	public virtual void fromBed()
	{
		audioSource.PlayOneShot(bedUpp);
	}

	public virtual void manakinLook()
	{
		audioSource.PlayOneShot(manakin);
	}

	public virtual void CrossbowShoot()
	{
		audioSource.PlayOneShot(crossbowShoot);
	}

	public virtual void CrossbowLoad()
	{
		audioSource.PlayOneShot(crossbowLoad);
	}

	public virtual void CoffinIn()
	{
		audioSource2.PlayOneShot(inCoffin);
	}

	public virtual void CoffinUt()
	{
		audioSource.PlayOneShot(OutCoffin);
	}

	public virtual void playerLandSound()
	{
		audioSource.PlayOneShot(landSound);
	}

	public virtual void playerLandBRSound()
	{
		audioSource.PlayOneShot(landBRSound);
	}

	public virtual void playerFallFloor()
	{
		audioSource.PlayOneShot(fallFloor);
	}

	public virtual void tavelbitPlace()
	{
		audioSource.PlayOneShot(placeTavelbit);
	}

	public virtual void GunShoot()
	{
		audioSource.PlayOneShot(gunShot);
	}

	public virtual void CarIn()
	{
		audioSource2.PlayOneShot(inCar);
	}

	public virtual void CarOut()
	{
		audioSource.PlayOneShot(outCar);
	}

	public virtual void loadShotgun()
	{
		audioSource.PlayOneShot(shotgunLoad);
	}

	public virtual void emptyShotgun()
	{
		audioSource.PlayOneShot(shotgunEmpty);
	}

	public virtual void loadedPickup()
	{
		audioSource.PlayOneShot(pickUpLoaded);
	}

	public virtual void clickRemote()
	{
		audioSource.PlayOneShot(remoteSound);
	}
}
