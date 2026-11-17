using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class triggerForestSound : MonoBehaviour
{
	public GameObject soundHolder;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			soundHolder.SetActive(true);
			((MonoBehaviour)this).StartCoroutine(soundTimer());
		}
	}

	public virtual IEnumerator soundTimer()
	{
		yield return (object)new WaitForSeconds(30f);
		soundHolder.SetActive(false);
	}
}
