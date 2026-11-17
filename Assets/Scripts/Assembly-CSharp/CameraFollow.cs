using System;
using UnityEngine;

public sealed class CameraFollow : MonoBehaviour
{
	public static Vector2 vector;

	private Rect touchZone = new Rect(8.78f, 0f, 10f, 11f);

	private Vector2 previousPos;

	private int currentFingerID = -1;

	private bool tweak;

	private bool IsTouchCaptured(out Vector2 touchPos)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		int touchCount = Input.touchCount;
		for (int i = 0; i < touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			Vector2 val = new Vector2(touch.position.x * 19.56f / (float)Screen.width, touch.position.y * 11f / (float)Screen.height);
			if ((int)touch.phase == 0 && touchZone.Contains(val))
			{
				tweak = true;
				currentFingerID = touch.fingerId;
				touchPos = val;
				return true;
			}
		}
		touchPos = Vector2.zero;
		return false;
	}

	private bool TweakIfNeeded()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (tweak)
		{
			Nullable touchByFingerId = GetTouchByFingerId(currentFingerID);
			if (touchByFingerId.HasValue)
			{
				Touch value = touchByFingerId.Value;
				if ((int)value.phase != 3)
				{
					value = touchByFingerId.Value;
					float num = value.position.x * 19.56f / (float)Screen.width;
					value = touchByFingerId.Value;
					Vector2 val = new Vector2(num, value.position.y * 11f / (float)Screen.height);
					vector = Vector2.op_Implicit(Vector2.op_Implicit(val - previousPos));
					previousPos = val;
					return true;
				}
			}
			ResetState();
			return false;
		}
		return false;
	}

	private void Update()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!TweakIfNeeded() && IsTouchCaptured(out var touchPos))
		{
			previousPos = touchPos;
		}
	}

	private Nullable GetTouchByFingerId(int fingerId)
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

	private void ResetState()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		tweak = false;
		vector = Vector2.zero;
	}

	public CameraFollow()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
	}
}
