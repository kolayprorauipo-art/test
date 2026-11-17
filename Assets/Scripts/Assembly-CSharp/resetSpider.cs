using System;
using UnityEngine;

[Serializable]
public class resetSpider : MonoBehaviour
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
		if (((Component)other).gameObject.tag == "Spider")
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderInNest = true;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderRunToNest = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).idle();
			SpiderTrigger1.SetActive(true);
			SpiderTrigger2.SetActive(false);
			spiderbackOfPoint.SetActive(false);
		}
	}
}
