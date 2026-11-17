using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class destroyInSeconds : MonoBehaviour
{
	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(1.3f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
