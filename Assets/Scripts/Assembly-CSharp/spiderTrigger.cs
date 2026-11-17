using System;
using UnityEngine;

[Serializable]
public class spiderTrigger : MonoBehaviour
{
	public GameObject Spider;

	public GameObject spiderbackOfPoint;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).huntPlayer = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderInNest)
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = true;
			spiderbackOfPoint.SetActive(true);
		}
	}
}
