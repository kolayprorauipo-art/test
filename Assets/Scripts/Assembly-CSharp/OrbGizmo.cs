using System;
using UnityEngine;

[Serializable]
public class OrbGizmo : MonoBehaviour
{
	public virtual void Start()
	{
		MonoBehaviour.print((object)("Orb count: " + ((Component)this).transform.childCount));
	}

	public virtual void OnDrawGizmos()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (!((Behaviour)this).enabled)
		{
			return;
		}
		foreach (Transform item in ((Component)this).transform)
		{
			Gizmos.DrawIcon(item.position, "particleGizmo.tif");
		}
	}
}
