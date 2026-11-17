using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerDead : MonoBehaviour
{
	public Image blackScreenTexture;

	public float fadeBlackSpeed;

	public GameObject cam1;

	public GameObject cam2;

	public GameObject endScene2;

	public GameObject PlayerendScene3;

	public GameObject player;

	public GameObject granny;

	public GameObject grannyOverPlayer;

	public GameObject grannyOverPlayerAnim;

	public Transform GrannyEndPos;

	public GameObject cellarDoor;

	public GameObject gameController;

	public GameObject bloodscreenEnd;

	public GameObject gameOverText;

	public Image gameOverTexture;

	public GameObject soundHolder;

	public GameObject musicHolder;

	public GameObject musicHolderNM;

	public GameObject BGnoiceHolder;

	public GameObject carEngineSound;

	public GameObject carEngineStart;

	public GameObject carCrashSound;

	public GameObject grannyLaughSound;

	public GameObject playerInBed;

	public bool endSceneRunning;

	public bool endSceneRunning2;

	public bool endSceneRunning3;

	public GameObject giljoAnimHolder;

	public GameObject giljoSoundHolder;

	public GameObject grannyAnimHolder;

	public GameObject grannyInCar;

	public GameObject Motorhuv;

	public GameObject Car;

	public GameObject carReverseSound;

	public GameObject carForwardSound;

	public GameObject carSensors;

	public GameObject carBumper;

	public Transform CarStartPos;

	public GameObject GameOverScene4;

	public virtual void Start()
	{
	}

	public virtual IEnumerator startEndScene()
	{
		AchievementSaveManager.Instance.UnlockAchievement("FirstBlood");
		if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning = true;
		playerInBed.SetActive(false);
		bloodscreenEnd.SetActive(true);
		soundHolder.SetActive(true);
		cam1.SetActive(true);
		cellarDoor.SetActive(false);
		granny.SetActive(false);
		granny.transform.position = GrannyEndPos.position;
		granny.transform.rotation = GrannyEndPos.rotation;
		granny.SetActive(true);
		musicHolder.SetActive(false);
		musicHolderNM.SetActive(false);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 2f, false);
		yield return (object)new WaitForSeconds(0.9f);
		((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerHit();
		yield return (object)new WaitForSeconds(4f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.5f, false);
		yield return (object)new WaitForSeconds(2f);
		player.SetActive(false);
		cam1.SetActive(false);
		cam2.SetActive(true);
		yield return (object)new WaitForSeconds(1f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 3.5f, false);
		yield return (object)new WaitForSeconds(3.2f);
		yield return (object)new WaitForSeconds(4.1f);
		grannyOverPlayer.SetActive(true);
		grannyOverPlayerAnim.GetComponent<Animation>()["GrannyEnd"].speed = 3f;
		yield return (object)new WaitForSeconds(0.7f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.2f, false);
		yield return (object)new WaitForSeconds(3f);
		gameOverText.SetActive(true);
		yield return (object)new WaitForSeconds(4f);
		((Graphic)gameOverTexture).CrossFadeAlpha(0f, 2.2f, false);
		yield return (object)new WaitForSeconds(3f);
		((FetchAds)(object)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator startEndScene2()
	{
		AchievementSaveManager.Instance.UnlockAchievement("FirstBlood");
		if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning2 = true;
		playerInBed.SetActive(false);
		bloodscreenEnd.SetActive(true);
		BGnoiceHolder.SetActive(false);
		endScene2.SetActive(true);
		cellarDoor.SetActive(false);
		granny.SetActive(false);
		musicHolder.SetActive(false);
		musicHolderNM.SetActive(false);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
		yield return (object)new WaitForSeconds(9.5f);
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyLooking");
		yield return (object)new WaitForSeconds(2.1f);
		giljoSoundHolder.SetActive(true);
		giljoAnimHolder.GetComponent<Animation>().Play("giljotinOn");
		grannyAnimHolder.GetComponent<Animation>().CrossFade("GrannyPullGiljotin");
		yield return (object)new WaitForSeconds(0.9f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		yield return (object)new WaitForSeconds(3f);
		gameOverText.SetActive(true);
		yield return (object)new WaitForSeconds(4f);
		((Graphic)gameOverTexture).CrossFadeAlpha(0f, 2.2f, false);
		yield return (object)new WaitForSeconds(3f);
		((FetchAds)(object)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public virtual IEnumerator startEndScene3()
	{
		AchievementSaveManager.Instance.UnlockAchievement("FirstBlood");
		Car.SetActive(false);
		Car.transform.position = CarStartPos.position;
		Car.SetActive(true);
		if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
		}
		endSceneRunning3 = true;
		playerInBed.SetActive(false);
		bloodscreenEnd.SetActive(true);
		PlayerendScene3.SetActive(true);
		cellarDoor.SetActive(false);
		granny.SetActive(false);
		musicHolder.SetActive(false);
		musicHolderNM.SetActive(false);
		carSensors.SetActive(false);
		if (Object.op_Implicit((Object)(object)GameObject.Find("CarBumper")))
		{
			carBumper.SetActive(false);
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("MotorhuvCar")))
		{
			Motorhuv.gameObject.GetComponent<Animation>().Play("motorhuvClose");
		}
		carEngineStart.SetActive(true);
		carEngineSound.SetActive(true);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
		yield return (object)new WaitForSeconds(7.5f);
		grannyInCar.SetActive(true);
		yield return (object)new WaitForSeconds(7f);
		Car.GetComponent<Animation>().Play("CarReverse");
		carReverseSound.SetActive(true);
		yield return (object)new WaitForSeconds(5f);
		carForwardSound.SetActive(true);
		yield return (object)new WaitForSeconds(0.3f);
		Car.GetComponent<Animation>().Play("CarForward");
		yield return (object)new WaitForSeconds(0.7f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.1f, false);
		carCrashSound.SetActive(true);
		yield return (object)new WaitForSeconds(3f);
		grannyLaughSound.SetActive(true);
		gameOverText.SetActive(true);
		yield return (object)new WaitForSeconds(4f);
		((Graphic)gameOverTexture).CrossFadeAlpha(0f, 2.2f, false);
		yield return (object)new WaitForSeconds(3f);
		((FetchAds)(object)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}

	public void startEndScene4()
	{
		AchievementSaveManager.Instance.UnlockAchievement("FirstBlood");
		if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
		}
		musicHolder.SetActive(false);
		musicHolderNM.SetActive(false);
		GameOverScene4.SetActive(true);
		((Graphic)blackScreenTexture).CrossFadeAlpha(0f, 6f, false);
	}

	public virtual IEnumerator gameOverNoGranny()
	{
		gameOverText.SetActive(true);
		yield return (object)new WaitForSeconds(4f);
		((Graphic)gameOverTexture).CrossFadeAlpha(0f, 2.2f, false);
		yield return (object)new WaitForSeconds(3f);
		((FetchAds)(object)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}
}
