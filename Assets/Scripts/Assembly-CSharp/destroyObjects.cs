using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class destroyObjects : MonoBehaviour
{
	public GameObject @object;

	public float timer;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(timer);
		Object.Destroy((Object)(object)@object);
	}
}
