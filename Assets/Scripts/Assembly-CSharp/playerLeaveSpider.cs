using System;
using UnityEngine;

[Serializable]
public class playerLeaveSpider : MonoBehaviour
{
	public GameObject Spider;

	public GameObject SpiderTrigger1;

	public GameObject SpiderTrigger2;

	public GameObject spiderbackOfPoint;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = true;
			spiderbackOfPoint.SetActive(true);
		}
	}
}
