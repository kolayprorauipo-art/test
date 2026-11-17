using UnityEngine;

[ExecuteInEditMode]
public class CNJoystick : CNAbstractController
{
	[SerializeField]
	[HideInInspector]
	private float _dragRadius = 1.5f;

	[SerializeField]
	[HideInInspector]
	private bool _snapsToFinger = true;

	[SerializeField]
	[HideInInspector]
	private bool _isHiddenIfNotTweaking;

	private Transform _stickTransform;

	private Transform _baseTransform;

	private GameObject _stickGameObject;

	private GameObject _baseGameObject;

	public float DragRadius
	{
		get
		{
			return _dragRadius;
		}
		set
		{
			_dragRadius = value;
		}
	}

	public bool SnapsToFinger
	{
		get
		{
			return _snapsToFinger;
		}
		set
		{
			_snapsToFinger = value;
		}
	}

	public bool IsHiddenIfNotTweaking
	{
		get
		{
			return _isHiddenIfNotTweaking;
		}
		set
		{
			_isHiddenIfNotTweaking = value;
		}
	}

	public override void OnEnable()
	{
		((CNAbstractController)this).OnEnable();
		_stickTransform = ((Component)((CNAbstractController)this).TransformCache.Find("Stick")).GetComponent<Transform>();
		_baseTransform = ((Component)((CNAbstractController)this).TransformCache.Find("Base")).GetComponent<Transform>();
		_stickGameObject = ((Component)_stickTransform).gameObject;
		_baseGameObject = ((Component)_baseTransform).gameObject;
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(false);
			_stickGameObject.gameObject.SetActive(false);
		}
		else
		{
			_baseGameObject.gameObject.SetActive(true);
			_stickGameObject.gameObject.SetActive(true);
		}
	}

	protected override void ResetControlState()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((CNAbstractController)this).ResetControlState();
		Transform stickTransform = _stickTransform;
		Vector3 zero = Vector3.zero;
		_baseTransform.localPosition = zero;
		stickTransform.localPosition = zero;
	}

	protected override void OnFingerLifted()
	{
		((CNAbstractController)this).OnFingerLifted();
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(false);
			_stickGameObject.gameObject.SetActive(false);
		}
	}

	protected override void OnFingerTouched()
	{
		((CNAbstractController)this).OnFingerTouched();
		if (IsHiddenIfNotTweaking)
		{
			_baseGameObject.gameObject.SetActive(true);
			_stickGameObject.gameObject.SetActive(true);
		}
	}

	protected virtual void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		Touch touch = default;
		if (!((CNAbstractController)this).TweakIfNeeded() && ((CNAbstractController)this).IsTouchCaptured(ref touch))
		{
			PlaceJoystickBaseUnderTheFinger(touch);
		}
	}

	protected override void TweakControl(Vector2 touchPosition)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = ((CNAbstractController)this).ParentCamera.ScreenToWorldPoint(Vector2.op_Implicit(touchPosition));
		Vector3 val2 = val - _baseTransform.position;
		if (val2.sqrMagnitude > DragRadius * DragRadius)
		{
			val2.Normalize();
			_stickTransform.position = _baseTransform.position + val2 * DragRadius;
		}
		else
		{
			_stickTransform.position = val;
		}
		((CNAbstractController)this).CurrentAxisValues = Vector2.op_Implicit(val2);
		((CNAbstractController)this).OnControllerMoved(Vector2.op_Implicit(val2));
	}

	protected virtual void PlaceJoystickBaseUnderTheFinger(Touch touch)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (_snapsToFinger)
		{
			Transform stickTransform = _stickTransform;
			Vector3 position = ((CNAbstractController)this).ParentCamera.ScreenToWorldPoint(Vector2.op_Implicit(touch.position));
			_baseTransform.position = position;
			stickTransform.position = position;
		}
	}
}
