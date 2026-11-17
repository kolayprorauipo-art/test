using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class PlayerRelativeControl : MonoBehaviour
{
	public Joystick moveJoystick;

	public Joystick rotateJoystick;

	public Transform cameraPivot;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	private Transform thisTransform;

	private CharacterController character;

	private AnimationController animationController;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	public PlayerRelativeControl()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		forwardSpeed = 4f;
		backwardSpeed = 1f;
		sidestepSpeed = 1f;
		jumpSpeed = 8f;
		inAirMultiplier = 0.25f;
		rotationSpeed = new Vector2(50f, 25f);
	}

	public virtual void Start()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		thisTransform = (Transform)((Component)this).GetComponent(typeof(Transform));
		character = (CharacterController)((Component)this).GetComponent(typeof(CharacterController));
		animationController = (AnimationController)(object)((Component)this).GetComponent(typeof(AnimationController));
		animationController.maxForwardSpeed = forwardSpeed;
		animationController.maxBackwardSpeed = backwardSpeed;
		animationController.maxSidestepSpeed = sidestepSpeed;
		GameObject val = GameObject.Find("PlayerSpawn");
		if (Object.op_Implicit((Object)(object)val))
		{
			thisTransform.position = val.transform.position;
		}
	}

	public virtual void OnEndGame()
	{
		moveJoystick.Disable();
		rotateJoystick.Disable();
		((Behaviour)this).enabled = false;
	}

	public virtual void Update()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = thisTransform.TransformDirection(new Vector3(moveJoystick.position.x, 0f, moveJoystick.position.y));
		val.y = 0f;
		val.Normalize();
		Vector3 zero = Vector3.zero;
		Vector2 val2 = new Vector2(Mathf.Abs(moveJoystick.position.x), Mathf.Abs(moveJoystick.position.y));
		if (val2.y > val2.x)
		{
			if (moveJoystick.position.y > 0f)
			{
				val *= forwardSpeed * val2.y;
			}
			else
			{
				val *= backwardSpeed * val2.y;
				zero.z = moveJoystick.position.y * 0.75f;
			}
		}
		else
		{
			val *= sidestepSpeed * val2.x;
			zero.x = (0f - moveJoystick.position.x) * 0.5f;
		}
		if (character.isGrounded)
		{
			if (rotateJoystick.tapCount == 2)
			{
				velocity = character.velocity;
				velocity.y = jumpSpeed;
			}
		}
		else
		{
			velocity.y += Physics.gravity.y * Time.deltaTime;
			zero.z = (0f - jumpSpeed) * 0.25f;
			val.x *= inAirMultiplier;
			val.z *= inAirMultiplier;
		}
		val += velocity;
		val += Physics.gravity;
		val *= Time.deltaTime;
		character.Move(val);
		if (character.isGrounded)
		{
			velocity = Vector3.zero;
		}
		Vector3 localPosition = cameraPivot.localPosition;
		localPosition.x = Mathf.SmoothDamp(localPosition.x, zero.x, ref cameraVelocity.x, 0.3f);
		localPosition.z = Mathf.SmoothDamp(localPosition.z, zero.z, ref cameraVelocity.z, 0.5f);
		cameraPivot.localPosition = localPosition;
		if (character.isGrounded)
		{
			Vector2 position = rotateJoystick.position;
			position.x *= rotationSpeed.x;
			position.y *= rotationSpeed.y;
			position *= Time.deltaTime;
			thisTransform.Rotate(0f, position.x, 0f, (Space)0);
			cameraPivot.Rotate(position.y, 0f, 0f);
		}
	}
}
