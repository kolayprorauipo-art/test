using System;
using UnityEngine;

[Serializable]
public class spiderHitPlayer : MonoBehaviour
{
	public GameObject Spider;

	public GameObject Player;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			if (PlayerPrefs.GetInt("PrimeOn") == 1)
			{
				((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).huntPlayer = false;
				((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).playerDead();
				((playerCaught)(object)Player.GetComponent(typeof(playerCaught))).spiderBitePlayer = true;
			}
			else
			{
				((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderIsDead();
			}
		}
	}
}
