using System;
using UnityEngine;

[Serializable]
public class objectIsMoving : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Object)((Component)other).gameObject).name == "ByroLoda")
		{
			((Component)this).transform.parent = ((Component)other).transform;
		}
		else if (((Object)((Component)other).gameObject).name == "Loda")
		{
			((Component)this).transform.parent = ((Component)other).transform;
		}
	}
}
