using UnityEngine;

public class CNThrowableTouchpad : CNTouchpad
{
	[SerializeField]
	[HideInInspector]
	private float _speedDecay = 0.9f;

	public float SpeedDecay
	{
		get
		{
			return _speedDecay;
		}
		set
		{
			_speedDecay = value;
		}
	}

	protected override void ResetControlState()
	{
		((CNAbstractController)this).IsCurrentlyTweaking = false;
		((CNAbstractController)this).OnFingerLifted();
	}

	protected override void Update()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		Vector2 currentAxisValues = ((CNAbstractController)this).CurrentAxisValues;
		if (currentAxisValues.sqrMagnitude <= 0.001f)
		{
			((CNAbstractController)this).CurrentAxisValues = Vector2.zero;
			return;
		}
		((CNAbstractController)this).CurrentAxisValues = ((CNAbstractController)this).CurrentAxisValues * SpeedDecay;
		((CNAbstractController)this).OnControllerMoved(((CNAbstractController)this).CurrentAxisValues);
	}
}
