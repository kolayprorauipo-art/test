using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class SidescrollControl : MonoBehaviour
{
	public Joystick moveTouchPad;

	public Joystick jumpTouchPad;

	public float forwardSpeed;

	public float backwardSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 velocity;

	private bool canJump;

	public SidescrollControl()
	{
		forwardSpeed = 4f;
		backwardSpeed = 4f;
		jumpSpeed = 16f;
		inAirMultiplier = 0.25f;
		canJump = true;
	}

	public virtual void Start()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		thisTransform = (Transform)((Component)this).GetComponent(typeof(Transform));
		character = (CharacterController)((Component)this).GetComponent(typeof(CharacterController));
		GameObject val = GameObject.Find("PlayerSpawn");
		if (Object.op_Implicit((Object)(object)val))
		{
			thisTransform.position = val.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		moveTouchPad.Disable();
		jumpTouchPad.Disable();
		((Behaviour)this).enabled = false;
	}

	public virtual void Update()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		Vector3 zero = Vector3.zero;
		zero = ((!(moveTouchPad.position.x > 0f)) ? (Vector3.right * backwardSpeed * moveTouchPad.position.x) : (Vector3.right * forwardSpeed * moveTouchPad.position.x));
		if (character.isGrounded)
		{
			bool flag = false;
			Joystick joystick = jumpTouchPad;
			if (!joystick.IsFingerDown())
			{
				canJump = true;
			}
			if (canJump && joystick.IsFingerDown())
			{
				flag = true;
				canJump = false;
			}
			if (flag)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			zero.x *= inAirMultiplier;
		}
		zero += velocity;
		zero += Physics.gravity;
		zero *= Time.deltaTime;
		character.Move(zero);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
	}
}
