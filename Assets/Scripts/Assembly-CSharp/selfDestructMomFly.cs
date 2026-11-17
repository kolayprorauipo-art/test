using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class selfDestructMomFly : MonoBehaviour
{
	public GameObject head;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(1f);
		Object.Destroy((Object)(object)head);
	}
}
