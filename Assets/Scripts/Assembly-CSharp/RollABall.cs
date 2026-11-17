using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(Rigidbody))]
public class RollABall : MonoBehaviour
{
	public Vector3 tilt;

	public float speed;

	private float circ;

	private Vector3 previousPosition;

	public RollABall()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		tilt = Vector3.zero;
	}

	public virtual void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		Bounds bounds = ((Component)this).GetComponent<Collider>().bounds;
		circ = (float)Math.PI * 2f * bounds.extents.x;
		previousPosition = ((Component)this).transform.position;
	}

	public virtual void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		tilt.x = 0f - Input.acceleration.y;
		tilt.z = Input.acceleration.x;
		((Component)this).GetComponent<Rigidbody>().AddForce(tilt * speed * Time.deltaTime);
	}

	public virtual void LateUpdate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((Component)this).transform.position - previousPosition;
		val = new Vector3(val.z, 0f, 0f - val.x);
		((Component)this).transform.Rotate(val / circ * 360f, (Space)0);
		previousPosition = ((Component)this).transform.position;
	}
}
