using System;
using UnityEngine;

[Serializable]
public class InvinsibleObj : MonoBehaviour
{
	public virtual void Start()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		Component[] componentsInChildren = ((Component)this).GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Renderer)componentsInChildren[i]).material.renderQueue = 2002;
		}
	}
}
