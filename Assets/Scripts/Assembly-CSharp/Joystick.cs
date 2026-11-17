using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[RequireComponent(typeof(Image))]
public class Joystick : MonoBehaviour
{
	private static Joystick[] joysticks;

	private static bool enumeratedJoysticks;

	private static float tapTimeDelta;

	public bool touchPad;

	public Rect touchZone;

	public Vector2 deadZone;

	public bool normalize;

	public Vector2 position;

	public int tapCount;

	private int lastFingerId;

	private float tapTimeWindow;

	private Vector2 fingerDownPos;

	private float fingerDownTime;

	private float firstDeltaTime;

	private Image gui;

	private Vector2 defaultPos;

	private Boundary guiBoundary;

	private Vector2 guiTouchOffset;

	private Vector2 guiCenter;

	public bool havestopped;

	public Image joystickRing;

	public GameObject footstepScriptHolder;

	public GameObject JoystickBase;

	public GameObject joystickCircle;

	public float radius;

	public RectTransform parent;

	public GameObject GameController;

	public Joystick()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		deadZone = Vector2.zero;
		lastFingerId = -1;
		firstDeltaTime = 0.5f;
		guiBoundary = new Boundary();
	}

	static Joystick()
	{
		tapTimeDelta = 0.3f;
	}

	public void OnEnable()
	{
	}

	public virtual void Start()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		footstepScriptHolder = GameObject.Find("Main Camera");
		gui = (Image)((Component)this).GetComponent(typeof(Image));
		defaultPos = ((Graphic)gui).rectTransform.anchoredPosition;
		Rect rect = ((Graphic)gui).rectTransform.rect;
		radius = rect.width * 0.8f;
		parent = ((Component)((Component)this).transform.parent).GetComponent<RectTransform>();
		GameController = GameObject.Find("GameController");
	}

	public virtual void Disable()
	{
		((Component)this).gameObject.SetActive(false);
		enumeratedJoysticks = false;
	}

	public virtual void ResetJoystick()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)gui).rectTransform.anchoredPosition = defaultPos;
		lastFingerId = -1;
	}

	public virtual bool IsFingerDown()
	{
		return lastFingerId != -1;
	}

	public virtual void LatchedFinger(int fingerId)
	{
		if (lastFingerId == fingerId)
		{
			ResetJoystick();
		}
	}

	public virtual void Update()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Invalid comparison between Unknown and I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Invalid comparison between Unknown and I4
		int touchCount = Input.touchCount;
		if (tapTimeWindow > 0f)
		{
			tapTimeWindow -= Time.deltaTime;
			havestopped = false;
		}
		if (touchCount == 0)
		{
			if (tapTimeWindow <= 0f)
			{
				tapTimeWindow = tapTimeDelta;
			}
			ResetJoystick();
		}
		else
		{
			for (int i = 0; i < touchCount; i++)
			{
				float x = ((Transform)parent).localScale.x;
				Rect rect = ((Graphic)gui).rectTransform.rect;
				float num = x * rect.size.x;
				float y = ((Transform)parent).localScale.y;
				rect = ((Graphic)gui).rectTransform.rect;
				new Vector2(num, y * rect.size.y);
				new Vector2(((Transform)parent).localScale.x * ((Graphic)gui).rectTransform.anchoredPosition.x, ((Transform)parent).localScale.y * ((Graphic)gui).rectTransform.anchoredPosition.y);
				Touch touch = Input.GetTouch(i);
				Vector2 val = new Vector2(touch.position.x / ((Transform)parent).localScale.x, touch.position.y / ((Transform)parent).localScale.y);
				Vector2 val2 = val - defaultPos;
				Vector2 anchoredPosition = ((Graphic)gui).rectTransform.anchoredPosition;
				rect = ((Graphic)gui).rectTransform.rect;
				Vector2 val3 = anchoredPosition - rect.size;
				rect = ((Graphic)gui).rectTransform.rect;
				Rect val4 = new Rect(val3, rect.size * 2f);
				if (val4.Contains(val) && (lastFingerId == -1 || lastFingerId != touch.fingerId))
				{
					lastFingerId = touch.fingerId;
				}
				if (lastFingerId == touch.fingerId)
				{
					((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
					if (val2.sqrMagnitude > Mathf.Pow(radius, 2f))
					{
						val2 = val2.normalized * radius;
					}
					((Graphic)gui).rectTransform.anchoredPosition = defaultPos + val2;
					if ((int)touch.phase == 3 || (int)touch.phase == 4)
					{
						ResetJoystick();
					}
				}
			}
		}
		position = (((Graphic)gui).rectTransform.anchoredPosition - defaultPos) / radius;
		if (position.sqrMagnitude > 1f)
		{
			position = position.normalized;
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 41)
		{
			position.x *= -1f;
		}
	}
}
