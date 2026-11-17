using System;
using UnityEngine;

[Serializable]
public class destroyTempNav : MonoBehaviour
{
	public virtual void Start()
	{
		Object.Destroy((Object)(object)((Component)this).gameObject, 5f);
	}
}
