using System;
using UnityEngine;

[Serializable]
public class bedEyes3 : MonoBehaviour
{
	public bool lookAtGranny;

	public Transform granny;

	public float speed;

	public MonoBehaviour playerStopscript;

	public GameObject playerStop;

	public virtual void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		((Component)this).transform.localEulerAngles = new Vector3(0f, 270f, 0f);
		playerStop = GameObject.Find("BedCam3");
		playerStopscript = (MonoBehaviour)playerStop.GetComponent("CameraFollowExample");
	}

	public virtual void Update()
	{
		if (lookAtGranny)
		{
			faceGrannyBed();
			((Behaviour)playerStopscript).enabled = false;
		}
	}

	public virtual void faceGrannyBed()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = granny.position - ((Component)this).transform.position;
		float num = speed * Time.deltaTime;
		Vector3 val2 = Vector3.RotateTowards(((Component)this).transform.forward, val, num, 0f);
		Debug.DrawRay(((Component)this).transform.position, val2, Color.red);
		((Component)this).transform.rotation = Quaternion.LookRotation(val2);
	}
}
