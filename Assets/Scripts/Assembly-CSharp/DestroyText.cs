using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class DestroyText : MonoBehaviour
{
	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(3f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
