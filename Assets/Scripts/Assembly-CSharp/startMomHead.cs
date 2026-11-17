using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class startMomHead : MonoBehaviour
{
	public GameObject head;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(5f);
		head.SetActive(true);
	}
}
