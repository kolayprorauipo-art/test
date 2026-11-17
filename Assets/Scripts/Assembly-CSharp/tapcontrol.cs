using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class tapcontrol : MonoBehaviour
{
	public GameObject cameraObject;

	public Transform cameraPivot;

	public Image jumpButton;

	public float speed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public float minimumDistanceToMove;

	public float minimumTimeUntilMove;

	public bool zoomEnabled;

	public float zoomEpsilon;

	public float zoomRate;

	public bool rotateEnabled;

	public float rotateEpsilon;

	private ZoomCamera zoomCamera;

	private Camera cam;

	private Transform thisTransform;

	private CharacterController character;

	private AnimationController animationController;

	private Vector3 targetLocation;

	private bool moving;

	private float rotationTarget;

	private float rotationVelocity;

	private Vector3 velocity;

	private ControlState state;

	private int[] fingerDown;

	private Vector2[] fingerDownPosition;

	private int[] fingerDownFrame;

	private float firstTouchTime;

	public tapcontrol()
	{
		inAirMultiplier = 0.25f;
		minimumDistanceToMove = 1f;
		minimumTimeUntilMove = 0.25f;
		rotateEpsilon = 1f;
		state = ControlState.WaitingForFirstTouch;
		fingerDown = new int[2];
		fingerDownPosition = new Vector2[2];
		fingerDownFrame = new int[2];
	}

	public virtual void Start()
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		thisTransform = ((Component)this).transform;
		zoomCamera = (ZoomCamera)(object)cameraObject.GetComponent(typeof(ZoomCamera));
		cam = cameraObject.GetComponent<Camera>();
		character = (CharacterController)((Component)this).GetComponent(typeof(CharacterController));
		animationController = (AnimationController)(object)((Component)this).GetComponent(typeof(AnimationController));
		animationController.maxForwardSpeed = speed;
		ResetControlState();
		GameObject val = GameObject.Find("PlayerSpawn");
		if (Object.op_Implicit((Object)(object)val))
		{
			thisTransform.position = val.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		((Behaviour)this).enabled = false;
	}

	public virtual void FaceMovementDirection()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = character.velocity;
		val.y = 0f;
		if (val.magnitude > 0.1f)
		{
			thisTransform.forward = val.normalized;
		}
	}

	public virtual void CameraControl(Touch touch0, Touch touch1)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if (rotateEnabled && state == ControlState.RotatingCamera)
		{
			Vector2 val = touch1.position - touch0.position;
			Vector2 val2 = val / val.magnitude;
			Vector2 val3 = touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition);
			Vector2 val4 = val3 / val3.magnitude;
			float num = Vector2.Dot(val2, val4);
			if (num < 1f)
			{
				Vector3 val5 = new Vector3(val.x, val.y);
				Vector3 val6 = new Vector3(val3.x, val3.y);
				Vector3 val7 = Vector3.Cross(val5, val6);
				float z = val7.normalized.z;
				float num2 = Mathf.Acos(num);
				rotationTarget += num2 * 57.29578f * z;
				if (rotationTarget < 0f)
				{
					rotationTarget += 360f;
				}
				else if (rotationTarget >= 360f)
				{
					rotationTarget -= 360f;
				}
			}
		}
		else if (zoomEnabled && state == ControlState.ZoomingCamera)
		{
			Vector2 val8 = touch1.position - touch0.position;
			float magnitude = val8.magnitude;
			val8 = touch1.position - touch1.deltaPosition - (touch0.position - touch0.deltaPosition);
			float magnitude2 = val8.magnitude;
			float num3 = magnitude - magnitude2;
			zoomCamera.zoom += num3 * zoomRate * Time.deltaTime;
		}
	}

	public virtual void CharacterControl()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		if (Input.touchCount == 1 && state == ControlState.MovingCharacter)
		{
			Touch touch = Input.GetTouch(0);
			_ = character.isGrounded;
			if ((int)touch.phase != 0 && Physics.Raycast(cam.ScreenPointToRay(new Vector3(touch.position.x, touch.position.y)), ref val))
			{
				Vector3 val2 = ((Component)this).transform.position - val.point;
				if (val2.magnitude > minimumDistanceToMove)
				{
					targetLocation = val.point;
				}
				moving = true;
			}
		}
		Vector3 val3 = Vector3.zero;
		if (moving)
		{
			val3 = targetLocation - thisTransform.position;
			val3.y = 0f;
			if (val3.magnitude < 1f)
			{
				moving = false;
			}
			else
			{
				val3 = val3.normalized * speed;
			}
		}
		if (!character.isGrounded)
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			val3.x *= inAirMultiplier;
			val3.z *= inAirMultiplier;
		}
		val3 += velocity;
		val3 += Physics.gravity;
		val3 *= Time.deltaTime;
		character.Move(val3);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
		FaceMovementDirection();
	}

	public virtual void ResetControlState()
	{
		state = ControlState.WaitingForFirstTouch;
		fingerDown[0] = -1;
		fingerDown[1] = -1;
	}

	public virtual void Update()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Invalid comparison between Unknown and I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Invalid comparison between Unknown and I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Invalid comparison between Unknown and I4
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Invalid comparison between Unknown and I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Invalid comparison between Unknown and I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Invalid comparison between Unknown and I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Invalid comparison between Unknown and I4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Invalid comparison between Unknown and I4
		int num = 0;
		Touch val = default;
		Touch touch = default;
		Touch touch2 = default;
		int touchCount = Input.touchCount;
		if (touchCount == 0)
		{
			ResetControlState();
		}
		else
		{
			Touch[] touches = Input.touches;
			bool flag = false;
			bool flag2 = false;
			if (state == ControlState.WaitingForFirstTouch)
			{
				for (num = 0; num < touchCount; num++)
				{
					val = touches[num];
					if ((int)val.phase != 3 && (int)val.phase != 4)
					{
						state = ControlState.WaitingForSecondTouch;
						firstTouchTime = Time.time;
						fingerDown[0] = val.fingerId;
						fingerDownPosition[0] = val.position;
						fingerDownFrame[0] = Time.frameCount;
						break;
					}
				}
			}
			if (state == ControlState.WaitingForSecondTouch)
			{
				for (num = 0; num < touchCount; num++)
				{
					val = touches[num];
					if ((int)val.phase == 4)
					{
						continue;
					}
					if (touchCount >= 2 && val.fingerId != fingerDown[0])
					{
						state = ControlState.WaitingForMovement;
						fingerDown[1] = val.fingerId;
						fingerDownPosition[1] = val.position;
						fingerDownFrame[1] = Time.frameCount;
						break;
					}
					if (touchCount == 1)
					{
						_ = val.position - fingerDownPosition[0];
						if (val.fingerId == fingerDown[0] && (Time.time > firstTouchTime + minimumTimeUntilMove || (int)val.phase == 3))
						{
							state = ControlState.MovingCharacter;
							break;
						}
					}
				}
			}
			if (state == ControlState.WaitingForMovement)
			{
				for (num = 0; num < touchCount; num++)
				{
					val = touches[num];
					if ((int)val.phase == 0)
					{
						if (val.fingerId == fingerDown[0] && fingerDownFrame[0] == Time.frameCount)
						{
							touch = val;
							flag = true;
						}
						else if (val.fingerId != fingerDown[0] && val.fingerId != fingerDown[1])
						{
							fingerDown[1] = val.fingerId;
							touch2 = val;
							flag2 = true;
						}
					}
					if ((int)val.phase == 1 || (int)val.phase == 2 || (int)val.phase == 3)
					{
						if (val.fingerId == fingerDown[0])
						{
							touch = val;
							flag = true;
						}
						else if (val.fingerId == fingerDown[1])
						{
							touch2 = val;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						Vector2 val2 = fingerDownPosition[1] - fingerDownPosition[0];
						Vector2 val3 = touch2.position - touch.position;
						Vector2 val4 = val2 / val2.magnitude;
						Vector2 val5 = val3 / val3.magnitude;
						float num2 = Vector2.Dot(val4, val5);
						if (num2 < 1f && Mathf.Acos(num2) > rotateEpsilon * ((float)Math.PI / 180f))
						{
							state = ControlState.RotatingCamera;
						}
						if (state == ControlState.WaitingForMovement && Mathf.Abs(val2.magnitude - val3.magnitude) > zoomEpsilon)
						{
							state = ControlState.ZoomingCamera;
						}
					}
				}
				else
				{
					state = ControlState.WaitingForNoFingers;
				}
			}
			if (state == ControlState.RotatingCamera || state == ControlState.ZoomingCamera)
			{
				for (num = 0; num < touchCount; num++)
				{
					val = touches[num];
					if ((int)val.phase == 1 || (int)val.phase == 2 || (int)val.phase == 3)
					{
						if (val.fingerId == fingerDown[0])
						{
							touch = val;
							flag = true;
						}
						else if (val.fingerId == fingerDown[1])
						{
							touch2 = val;
							flag2 = true;
						}
					}
				}
				if (flag)
				{
					if (flag2)
					{
						CameraControl(touch, touch2);
					}
				}
				else
				{
					state = ControlState.WaitingForNoFingers;
				}
			}
		}
		CharacterControl();
	}

	public virtual void LateUpdate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		float y = Mathf.SmoothDampAngle(cameraPivot.eulerAngles.y, rotationTarget, ref rotationVelocity, 0.3f);
		Vector3 eulerAngles = cameraPivot.eulerAngles;
		eulerAngles.y = y;
		cameraPivot.eulerAngles = eulerAngles;
	}
}
