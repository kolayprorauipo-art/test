using System;
using UnityEngine;

[Serializable]
public class pushRigidbody : MonoBehaviour
{
	public float pushPower;

	public pushRigidbody()
	{
		pushPower = 2f;
	}

	public virtual void OnControllerColliderHit(ControllerColliderHit hit)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Rigidbody attachedRigidbody = hit.collider.attachedRigidbody;
		if (!((Object)(object)attachedRigidbody == (Object)null) && !attachedRigidbody.isKinematic && !(hit.moveDirection.y < -0.3f))
		{
			Vector3 val = new Vector3(hit.moveDirection.x, 0f, hit.moveDirection.z);
			attachedRigidbody.velocity = val * pushPower;
		}
	}
}
