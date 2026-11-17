using System;
using UnityEngine;

[Serializable]
public class ZoomCamera : MonoBehaviour
{
	public Transform origin;

	public float zoom;

	public float zoomMin;

	public float zoomMax;

	public float seekTime;

	public bool smoothZoomIn;

	private Vector3 defaultLocalPosition;

	private Transform thisTransform;

	private float currentZoom;

	private float targetZoom;

	private float zoomVelocity;

	public ZoomCamera()
	{
		zoomMin = -5f;
		zoomMax = 5f;
		seekTime = 1f;
	}

	public virtual void Start()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		thisTransform = ((Component)this).transform;
		defaultLocalPosition = thisTransform.localPosition;
		currentZoom = zoom;
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		zoom = Mathf.Clamp(zoom, zoomMin, zoomMax);
		int num = -261;
		Vector3 position = origin.position;
		Vector3 val2 = defaultLocalPosition + thisTransform.parent.InverseTransformDirection(thisTransform.forward * zoom);
		Vector3 val3 = thisTransform.parent.TransformPoint(val2);
		if (Physics.Linecast(position, val3, ref val, num))
		{
			Vector3 val4 = val.point + thisTransform.TransformDirection(Vector3.forward);
			Vector3 val5 = val4 - thisTransform.parent.TransformPoint(defaultLocalPosition);
			targetZoom = val5.magnitude;
		}
		else
		{
			targetZoom = zoom;
		}
		targetZoom = Mathf.Clamp(targetZoom, zoomMin, zoomMax);
		if (!smoothZoomIn && targetZoom - currentZoom > 0f)
		{
			currentZoom = targetZoom;
		}
		else
		{
			currentZoom = Mathf.SmoothDamp(currentZoom, targetZoom, ref zoomVelocity, seekTime);
		}
		val2 = defaultLocalPosition + thisTransform.parent.InverseTransformDirection(thisTransform.forward * currentZoom);
		thisTransform.localPosition = val2;
	}
}
