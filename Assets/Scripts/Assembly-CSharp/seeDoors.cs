using System;
using UnityEngine;

[Serializable]
public class seeDoors : MonoBehaviour
{
	public Transform myTransform;

	public float seeRange;

	public virtual void Start()
	{
	}

	public virtual void FixedUpdate()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = myTransform.TransformDirection(Vector3.forward);
		Debug.DrawLine(((Component)this).transform.position, val2, Color.green);
		if (Physics.Raycast(myTransform.position, val2, 3f) && ((Component)val.collider).gameObject.tag != "innerdoorclosed")
		{
			MonoBehaviour.print((object)"There is something in front of the object!");
		}
	}
}
