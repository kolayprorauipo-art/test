using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carFrontSensor : MonoBehaviour
{
	public GameObject gameController;

	public GameObject forwardButton;

	public GameObject ReverseButton;

	public GameObject outOffCarButton;

	public bool garagedoorOpen;

	public float hitGaragedoorCounter;

	public GameObject brickWallStart;

	public GameObject brickWallBroken;

	public Texture2D brokenTextureMin;

	public Texture2D brokenTextureMax;

	public GameObject camInCar;

	public GameObject escapeCam;

	public GameObject escapeCamNoGranny;

	public GameObject granny;

	public GameObject dust1;

	public GameObject dust2;

	public GameObject headAnim;

	public GameObject carForwardSound;

	public GameObject engineOnSound;

	public GameObject crashSound;

	public GameObject crashSoundPort;

	public GameObject CarHitTriggers;

	public GameObject shouldOpenDoorFirstText;

	public GameObject optionButton;

	public bool textTimerOnOff;

	public float textTimer;

	public bool textShown;

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(false);
			}
		}
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (!(((Component)other).gameObject.tag == "car"))
		{
			yield break;
		}
		((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).reverseOK = true;
		((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).forwardOK = false;
		((checkTheCar)(object)gameController.GetComponent(typeof(checkTheCar))).carMoving = false;
		if (garagedoorOpen)
		{
			if (hitGaragedoorCounter == 1f)
			{
				brickWallStart.GetComponent<Renderer>().material.mainTexture = (Texture)(object)brokenTextureMax;
				hitGaragedoorCounter++;
				dust2.SetActive(true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
				yield return (object)new WaitForSeconds(1f);
				forwardButton.SetActive(false);
				ReverseButton.SetActive(true);
				optionButton.SetActive(true);
				outOffCarButton.SetActive(true);
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
			}
			else if (hitGaragedoorCounter == 2f)
			{
				brickWallStart.SetActive(false);
				brickWallBroken.SetActive(true);
				camInCar.SetActive(false);
				granny.SetActive(false);
				if (PlayerPrefs.GetInt("DiffData") == 4)
				{
					escapeCamNoGranny.SetActive(true);
					RenderSettings.fog = false;
					optionButton.SetActive(false);
					if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
					{
						Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				else
				{
					escapeCam.SetActive(true);
					if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 9 && Object.op_Implicit((Object)(object)GameObject.Find("CrowParent")))
					{
						((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).DiedByAnomaly = true;
						GameObject.Find("CrowBur").transform.SetParent((Transform)null);
						GameObject.Find("CrowBur").transform.position = new Vector3(9.98f, 5.267f, 0.414f);
						GameObject.Find("CrowBur").transform.rotation = Quaternion.Euler(0f, 90f, 0f);
					}
					RenderSettings.fog = false;
					optionButton.SetActive(false);
					if (Object.op_Implicit((Object)(object)GameObject.Find("GrannyRagdoll(Clone)")))
					{
						Object.Destroy((Object)(object)GameObject.Find("GrannyRagdoll(Clone)"));
					}
				}
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
			}
			else
			{
				hitGaragedoorCounter++;
				brickWallStart.GetComponent<Renderer>().material.mainTexture = (Texture)(object)brokenTextureMin;
				dust1.SetActive(true);
				headAnim.GetComponent<Animation>().Play("HeadForward");
				carForwardSound.SetActive(false);
				engineOnSound.SetActive(true);
				crashSound.SetActive(true);
				CarHitTriggers.SetActive(false);
				yield return (object)new WaitForSeconds(1f);
				forwardButton.SetActive(false);
				ReverseButton.SetActive(true);
				outOffCarButton.SetActive(true);
				optionButton.SetActive(true);
			}
		}
		else
		{
			headAnim.GetComponent<Animation>().Play("HeadForward");
			carForwardSound.SetActive(false);
			engineOnSound.SetActive(true);
			crashSoundPort.SetActive(true);
			CarHitTriggers.SetActive(false);
			yield return (object)new WaitForSeconds(1f);
			forwardButton.SetActive(false);
			ReverseButton.SetActive(true);
			outOffCarButton.SetActive(true);
			optionButton.SetActive(true);
			if (!textShown)
			{
				textShown = true;
				textTimer = 0f;
				shouldOpenDoorFirstText.SetActive(true);
				textTimerOnOff = true;
			}
		}
	}
}
