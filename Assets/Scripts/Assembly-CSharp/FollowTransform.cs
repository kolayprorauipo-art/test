using System;
using UnityEngine;

[Serializable]
public class FollowTransform : MonoBehaviour
{
	public Transform targetTransform;

	public bool faceForward;

	private Transform thisTransform;

	public virtual void Start()
	{
		thisTransform = ((Component)this).transform;
	}

	public virtual void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		thisTransform.position = targetTransform.position;
		if (faceForward)
		{
			thisTransform.forward = targetTransform.forward;
		}
	}
}
