using UnityEngine;
using UnityEngine.UI;

public class PlayerFreeze : MonoBehaviour
{
	public Image FreezeScreen;

	public GameObject FreezeScreenTexture;

	public bool freezeON;

	public bool freezeOFF;

	public GameObject Granny;

	public GameObject footstepScriptHolder;

	public GameObject player;

	public GameObject playerHead;

	public GameObject GrannyEye;

	public GameObject crawlButtonParent;

	public GameObject joystick;

	public GameObject allBedButtons;

	public GameObject doorRay;

	public GameObject pickUpRay;

	public GameObject iceBreakSoundHolder;

	public bool playerStuckTimer;

	public float timerCount;

	private void Start()
	{
		((Graphic)FreezeScreen).canvasRenderer.SetAlpha(0f);
		timerCount = 10f;
	}

	private void Update()
	{
		if (playerStuckTimer)
		{
			timerCount -= Time.deltaTime;
			if (timerCount <= 0f)
			{
				playerStuckTimer = false;
				freezeOFF = true;
				timerCount = 10f;
				playerFreezeFree();
			}
		}
		if (freezeON)
		{
			((Graphic)FreezeScreen).CrossFadeAlpha(1f, 4f, false);
			if (((Graphic)FreezeScreen).canvasRenderer.GetAlpha() > 0.9f)
			{
				freezeON = false;
			}
		}
		if (freezeOFF)
		{
			((Graphic)FreezeScreen).CrossFadeAlpha(0f, 2f, false);
			if (((Graphic)FreezeScreen).canvasRenderer.GetAlpha() < 0.1f)
			{
				freezeOFF = false;
				((Graphic)FreezeScreen).canvasRenderer.SetAlpha(0f);
			}
		}
	}

	public virtual void playerFreezeStuck()
	{
		playerStuckTimer = true;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
		((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuKilled && !((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).freeze && GrannyEye.activeSelf)
		{
			((EnemyEye)(object)GrannyEye.GetComponent(typeof(EnemyEye))).seeRange = 200f;
		}
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
		joystick.SetActive(false);
		crawlButtonParent.SetActive(false);
		allBedButtons.SetActive(false);
		doorRay.SetActive(false);
		pickUpRay.SetActive(false);
		freezeON = true;
		if (((startNewDay)(object)((Component)this).gameObject.GetComponent(typeof(startNewDay))).RandomTask == 1 || ((startNewDay)(object)((Component)this).gameObject.GetComponent(typeof(startNewDay))).randomTask2 == 1)
		{
			((startNewDay)(object)((Component)this).gameObject.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
		}
	}

	public virtual void playerFreezeFree()
	{
		if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught)
		{
			joystick.SetActive(true);
			crawlButtonParent.SetActive(true);
			allBedButtons.SetActive(true);
			((deactivateIceBreakSound)(object)iceBreakSoundHolder.GetComponent(typeof(deactivateIceBreakSound))).playIceBreak();
			if (player.GetComponent<CharacterController>().height == 2.76f)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 5f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 4f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 5f;
			}
			else if (player.GetComponent<CharacterController>().height == 1.8f)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 1f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 1f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 1f;
			}
		}
		doorRay.SetActive(true);
		pickUpRay.SetActive(true);
	}
}
