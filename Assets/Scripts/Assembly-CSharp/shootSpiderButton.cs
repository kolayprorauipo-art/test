using System;
using UnityEngine;

[Serializable]
public class shootSpiderButton : MonoBehaviour
{
	public bool buttonShot;

	public GameObject luckaAnim;

	public GameObject spider;

	public GameObject spiderTrigger1;

	public GameObject spiderTrigger2;

	public GameObject leaveTrigger;

	public GameObject shootbutton;

	public GameObject foodPos;

	public GameObject spiderNestpos;

	public GameObject spiderStartpos;

	public openDoors DoorRay;

	public AudioClip luckaFaller;

	public virtual void Start()
	{
	}

	public virtual void closeSpiderlucka()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (buttonShot)
		{
			return;
		}
		if (!((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				buttonShot = true;
				luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
				if (PlayerPrefs.GetInt("AnomalyNR") != 27 && PlayerPrefs.GetInt("EventChallenge3") != 1)
				{
					luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
				}
				spiderNestpos.transform.localPosition = new Vector3(20.28f, 91.04f, -17.06f);
				spiderStartpos.transform.localPosition = new Vector3(22.68f, 90.5774f, -9.64f);
				((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(false);
				spiderTrigger2.SetActive(false);
			}
			return;
		}
		buttonShot = true;
		if (DoorRay.closeSpiderAchievement)
		{
			AchievementSaveManager.Instance.UnlockAchievement("NinetySevenIQMove");
		}
		luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
		if (PlayerPrefs.GetInt("AnomalyNR") != 27 && PlayerPrefs.GetInt("EventChallenge3") != 1)
		{
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
		}
		spider.SetActive(false);
		spiderTrigger1.SetActive(false);
		spiderTrigger2.SetActive(false);
		leaveTrigger.SetActive(false);
		foodPos.SetActive(false);
		spiderNestpos.SetActive(false);
		shootbutton.SetActive(false);
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (buttonShot || !(((Component)other).gameObject.tag == "arrow"))
		{
			return;
		}
		if (!((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			if (!((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
			{
				buttonShot = true;
				luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
				luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
				spiderNestpos.transform.localPosition = new Vector3(20.28f, 91.04f, -17.06f);
				spiderStartpos.transform.localPosition = new Vector3(22.68f, 90.5774f, -9.64f);
				((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
				((spiderControll)(object)spider.GetComponent(typeof(spiderControll))).foodTime = false;
				spiderTrigger1.SetActive(false);
				spiderTrigger2.SetActive(false);
				leaveTrigger.SetActive(false);
			}
		}
		else
		{
			buttonShot = true;
			luckaAnim.GetComponent<Animation>().Play("SpiderLuckaClose");
			luckaAnim.GetComponent<AudioSource>().PlayOneShot(luckaFaller);
			spider.SetActive(false);
			spiderTrigger1.SetActive(false);
			spiderTrigger2.SetActive(false);
			leaveTrigger.SetActive(false);
			foodPos.SetActive(false);
			spiderNestpos.SetActive(false);
			shootbutton.SetActive(false);
		}
	}
}
