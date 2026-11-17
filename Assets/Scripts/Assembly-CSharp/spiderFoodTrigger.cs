using System;
using UnityEngine;

[Serializable]
public class spiderFoodTrigger : MonoBehaviour
{
	public GameObject Spider;

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
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).idle();
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderStartEat = true;
		}
	}
}
