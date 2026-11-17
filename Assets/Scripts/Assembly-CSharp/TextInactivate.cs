using System;
using UnityEngine;

[Serializable]
public class TextInactivate : MonoBehaviour
{
	public bool travelDown;

	public float timer;

	public TextInactivate()
	{
		timer = 3f;
	}

	public virtual void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		float y = 14.15f;
		Vector3 localPosition = ((Component)this).transform.localPosition;
		localPosition.y = y;
		((Component)this).transform.localPosition = localPosition;
		travelDown = true;
	}

	public virtual void Update()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (travelDown)
		{
			timer -= Time.deltaTime;
			float y = ((Component)this).transform.localPosition.y - 0.001f;
			Vector3 localPosition = ((Component)this).transform.localPosition;
			localPosition.y = y;
			((Component)this).transform.localPosition = localPosition;
		}
		if (timer < 0f)
		{
			travelDown = false;
			timer = 3f;
			float y2 = 14.15f;
			Vector3 localPosition2 = ((Component)this).transform.localPosition;
			localPosition2.y = y2;
			((Component)this).transform.localPosition = localPosition2;
			((Component)this).gameObject.SetActive(false);
		}
	}
}
