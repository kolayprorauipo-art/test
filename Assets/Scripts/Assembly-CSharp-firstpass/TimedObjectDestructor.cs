using System;
using UnityEngine;

[Serializable]
public class TimedObjectDestructor : MonoBehaviour
{
	public float timeOut;

	public bool detachChildren;

	public TimedObjectDestructor()
	{
		timeOut = 1f;
	}

	public virtual void Awake()
	{
		((MonoBehaviour)this).Invoke("DestroyNow", timeOut);
	}

	public virtual void DestroyNow()
	{
		if (detachChildren)
		{
			((Component)this).transform.DetachChildren();
		}
		Object.DestroyObject((Object)(object)((Component)this).gameObject);
	}
}
