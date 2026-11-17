using UnityEngine;

public class SwipeScript : MonoBehaviour
{
	private float fingerStartTime;

	private Vector2 fingerStartPos = Vector2.zero;

	private bool isSwipe;

	private float minSwipeDist = 50f;

	private float maxSwipeTime = 3.5f;

	public GameObject animationHolder;

	private void Update()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		if (Input.touchCount <= 0)
		{
			return;
		}
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch val = touches[i];
			TouchPhase phase = val.phase;
			switch ((int)phase)
			{
			case 3:
				isSwipe = true;
				fingerStartTime = Time.time;
				fingerStartPos = val.position;
				break;
			case 4:
				isSwipe = false;
				break;
			case 0:
			{
				float num = Time.time - fingerStartTime;
				Vector2 val2 = val.position - fingerStartPos;
				float magnitude = val2.magnitude;
				if (!isSwipe || !(num < maxSwipeTime) || !(magnitude > minSwipeDist))
				{
					break;
				}
				Vector2 val3 = val.position - fingerStartPos;
				Vector2 zero = Vector2.zero;
				zero = ((!(Mathf.Abs(val3.x) > Mathf.Abs(val3.y))) ? (Vector2.up * Mathf.Sign(val3.y)) : (Vector2.right * Mathf.Sign(val3.x)));
				if (zero.x != 0f)
				{
					if (zero.x > 0f)
					{
						Debug.Log((object)"Right");
					}
					else
					{
						Debug.Log((object)"Left");
					}
				}
				if (zero.y != 0f)
				{
					_ = zero.y;
					_ = 0f;
				}
				break;
			}
			}
		}
	}

	public SwipeScript()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
	}
}
