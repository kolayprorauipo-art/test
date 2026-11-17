using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class carbumberTrigger : MonoBehaviour
{
	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player")
		{
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Component)this).transform.parent = null;
			((MonoBehaviour)this).StartCoroutine(destroy());
		}
	}

	public virtual IEnumerator destroy()
	{
		yield return (object)new WaitForSeconds(30f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
