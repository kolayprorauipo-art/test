using System;
using UnityEngine;

[Serializable]
public class spiderHuntPlayer : MonoBehaviour
{
	public GameObject Spider;

	public GameObject largeTrigger;

	public GameObject startTrigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).SpiderBitePlayer)
		{
			largeTrigger.SetActive(true);
			startTrigger.SetActive(false);
		}
	}
}
