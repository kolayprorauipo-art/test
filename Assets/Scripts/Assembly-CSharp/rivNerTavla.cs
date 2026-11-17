using System;
using UnityEngine;

[Serializable]
public class rivNerTavla : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player")
		{
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
		else if (((Component)other).gameObject.tag == "arrow")
		{
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
	}
}
