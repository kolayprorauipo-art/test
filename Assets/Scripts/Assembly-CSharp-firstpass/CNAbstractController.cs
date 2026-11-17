using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public abstract class CNAbstractController : MonoBehaviour
{
	[Flags]
	protected enum AnchorsBase
	{
		Left = 1,
		Right = 2,
		Top = 4,
		Bottom = 8
	}

	public enum Anchors
	{
		LeftTop = 5,
		LeftBottom = 9,
		RightTop = 6,
		RightBottom = 10
	}

	private const string AxisNameHorizontal = "Horizontal";

	private const string AxisNameVertical = "Vertical";

	[SerializeField]
	[HideInInspector]
	private Anchors _anchor = Anchors.LeftBottom;

	[SerializeField]
	[HideInInspector]
	private string _axisNameX = "Horizontal";

	[SerializeField]
	[HideInInspector]
	private string _axisNameY = "Vertical";

	[SerializeField]
	[HideInInspector]
	private Vector2 _touchZoneSize = new Vector2(6f, 6f);

	[SerializeField]
	[HideInInspector]
	private Vector2 _margins = new Vector2(3f, 3f);

	public Anchors Anchor
	{
		get
		{
			return _anchor;
		}
		set
		{
			_anchor = value;
		}
	}

	public string AxisNameX
	{
		get
		{
			return _axisNameX;
		}
		set
		{
			_axisNameX = value;
		}
	}

	public string AxisNameY
	{
		get
		{
			return _axisNameY;
		}
		set
		{
			_axisNameY = value;
		}
	}

	public Vector2 Margins
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _margins;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_margins = value;
		}
	}

	public Vector2 TouchZoneSize
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _touchZoneSize;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_touchZoneSize = value;
		}
	}

	protected Transform TransformCache { get; set; }

	protected Camera ParentCamera { get; set; }

	protected Rect CalculatedTouchZone
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return field;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			field = value;
		}
	}

	protected Vector2 CurrentAxisValues
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return field;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			field = value;
		}
	}

	protected int CurrentFingerId { get; set; }

	protected Nullable CalculatedPosition { get; set; }

	protected bool IsCurrentlyTweaking { get; set; }

	public event Action<Vector3, CNAbstractController> ControllerMovedEvent;

	public event Action<CNAbstractController> FingerTouchedEvent;

	public event Action<CNAbstractController> FingerLiftedEvent;

	public virtual float GetAxis(string axisName)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		if (AxisNameX == null || AxisNameY == null || AxisNameX == string.Empty || AxisNameY == string.Empty)
		{
			throw new UnityException("Input Axis " + axisName + " is not setup");
		}
		if (axisName == AxisNameX)
		{
			return CurrentAxisValues.x;
		}
		if (axisName == AxisNameY)
		{
			return CurrentAxisValues.y;
		}
		throw new UnityException("Input Axis " + axisName + " is not setup");
	}

	public virtual void Disable()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		CurrentAxisValues = Vector2.zero;
		((Component)this).gameObject.SetActive(false);
		((Behaviour)this).enabled = false;
	}

	public virtual void Enable()
	{
		((Component)this).gameObject.SetActive(true);
		((Behaviour)this).enabled = true;
	}

	public virtual void OnEnable()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		TransformCache = ((Component)this).GetComponent<Transform>();
		ParentCamera = ((Component)TransformCache.parent).GetComponent<Camera>();
		TransformCache.localPosition = InitializePosition();
	}

	protected virtual Nullable GetTouchByFingerId(int fingerId)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if (touch.fingerId == fingerId)
			{
				return touch;
			}
		}
		return null;
	}

	protected virtual void OnControllerMoved(Vector2 input)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (ControllerMovedEvent != null)
		{
			ControllerMovedEvent(Vector2.op_Implicit(input), this);
		}
	}

	protected virtual void OnFingerTouched()
	{
		if (FingerTouchedEvent != null)
		{
			FingerTouchedEvent(this);
		}
	}

	protected virtual void OnFingerLifted()
	{
		if (FingerLiftedEvent != null)
		{
			FingerLiftedEvent(this);
		}
	}

	protected Vector3 InitializePosition()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		if (CalculatedPosition.HasValue)
		{
			return CalculatedPosition.Value;
		}
		float orthographicSize = ParentCamera.orthographicSize;
		float num = orthographicSize * ParentCamera.aspect;
		Vector3 result = new Vector3(0f, 0f, 0f);
		if ((Anchor & (Anchors)1) != 0)
		{
			result.x = 0f - num + Margins.x;
		}
		else
		{
			result.x = num - Margins.x;
		}
		if ((Anchor & (Anchors)4) != 0)
		{
			result.y = orthographicSize - Margins.y;
		}
		else
		{
			result.y = 0f - orthographicSize + Margins.y;
		}
		CalculatedTouchZone = new Rect(TransformCache.position.x - TouchZoneSize.x / 2f, TransformCache.position.y - TouchZoneSize.y / 2f, TouchZoneSize.x, TouchZoneSize.y);
		return result;
	}

	protected virtual void ResetControlState()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		IsCurrentlyTweaking = false;
		CurrentAxisValues = Vector2.zero;
		OnFingerLifted();
	}

	protected virtual bool TweakIfNeeded()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (IsCurrentlyTweaking)
		{
			Nullable touchByFingerId = GetTouchByFingerId(CurrentFingerId);
			if (touchByFingerId.HasValue)
			{
				Touch value = touchByFingerId.Value;
				if ((int)value.phase != 3)
				{
					value = touchByFingerId.Value;
					TweakControl(value.position);
					return true;
				}
			}
			ResetControlState();
			return false;
		}
		return false;
	}

	protected virtual bool IsTouchCaptured(out Touch capturedTouch)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if ((int)touch.phase == 0 && IsTouchInZone(touch.position))
			{
				IsCurrentlyTweaking = true;
				CurrentFingerId = touch.fingerId;
				OnFingerTouched();
				capturedTouch = touch;
				return true;
			}
		}
		capturedTouch = default;
		return false;
	}

	private bool IsTouchInZone(Vector2 touchPosition)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Rect calculatedTouchZone = CalculatedTouchZone;
		return calculatedTouchZone.Contains(ParentCamera.ScreenToWorldPoint(Vector2.op_Implicit(touchPosition)), false);
	}

	protected abstract void TweakControl(Vector2 touchPosition);

	protected CNAbstractController()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
	}
}
