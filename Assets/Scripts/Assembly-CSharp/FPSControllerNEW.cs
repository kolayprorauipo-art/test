using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(CharacterController))]
public class FPSControllerNEW : MonoBehaviour
{
	public Transform cameraPivot;

	public EnemyAIGranny EnemyAIGrannyScript;

	public float forwardSpeed;

	public float backwardSpeed;

	public float sidestepSpeed;

	public float jumpSpeed;

	public float inAirMultiplier;

	public Vector2 rotationSpeed;

	public float tiltPositiveYAxis;

	public float tiltNegativeYAxis;

	public float tiltXAxisMinimum;

	private Transform thisTransform;

	private CharacterController character;

	private Vector3 cameraVelocity;

	private Vector3 velocity;

	private bool canJump;

	public GameObject rotateControll;

	public GameObject footstepScriptHolder;

	public GameObject headBobAnimHolder;

	public bool day2;

	public bool day3;

	public bool playerCrouch;

	public bool PlayerIsGrounded;

	public bool fallTimerStarted;

	public float timeInAir;

	public GameObject soundHolder;

	public GameObject FallsoundHolder;

	public GameObject granny;

	public GameObject Player;

	public GameObject checkGround;

	public int startingPitch;

	public object audio;

	private Vector3 movement;

	public bool playerIsDying;

	public bool wetFloor;

	public bool isMirrored;

	private Vector3 currentVelocity;

	public float iceAcceleration;

	public float iceFriction;

	public bool isOnLadder;

	public float ladderSpeed;

	public bool limping;

	public FPSControllerNEW()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		forwardSpeed = 6f;
		backwardSpeed = 1f;
		sidestepSpeed = 1f;
		jumpSpeed = 8f;
		inAirMultiplier = 0.25f;
		rotationSpeed = new Vector2(50f, 25f);
		tiltPositiveYAxis = 0.6f;
		tiltNegativeYAxis = 0.4f;
		tiltXAxisMinimum = 0.1f;
		canJump = true;
		PlayerIsGrounded = true;
		startingPitch = 4;
	}

	public virtual void Start()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		timeInAir = 0f;
		thisTransform = (Transform)((Component)this).GetComponent(typeof(Transform));
		character = (CharacterController)((Component)this).GetComponent(typeof(CharacterController));
		GameObject val = GameObject.Find("PlayerSpawn");
		if (Object.op_Implicit((Object)(object)val))
		{
			thisTransform.position = val.transform.position;
		}
		if (GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 38)
		{
			wetFloor = true;
			iceAcceleration = 1f;
			iceFriction = 0.995f;
		}
		if (GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 41)
		{
			isMirrored = true;
		}
		ladderSpeed = 3f;
		if (PlayerPrefs.GetInt("LimpingOnOff") == 1)
		{
			limping = true;
		}
		Cursor.lockState = (CursorLockMode)1;
		Cursor.visible = false;
	}

	public virtual void OnEndGame()
	{
		((Behaviour)this).enabled = false;
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		float num = Input.GetAxisRaw("Horizontal");
		float axisRaw = Input.GetAxisRaw("Vertical");
		if (isMirrored)
		{
			num = 0f - num;
		}
		Vector3 val2 = ((Component)this).transform.forward * axisRaw + ((Component)this).transform.right * num;
		val2.Normalize();
		float num2 = 0f;
		if (axisRaw > 0f)
		{
			num2 = forwardSpeed;
		}
		else if (axisRaw < 0f)
		{
			num2 = backwardSpeed;
		}
		else if (num != 0f)
		{
			num2 = sidestepSpeed;
		}
		RaycastHit val3 = default;
		Physics.SphereCast(((Component)this).transform.position, character.radius, Vector3.down, ref val3, character.height / 2f, -257, (QueryTriggerInteraction)1);
		Vector3 val4 = Vector3.ProjectOnPlane(val2, val3.normal);
		val2 = val4.normalized;
		Vector3 val5 = val2 * num2;
		if (wetFloor)
		{
			currentVelocity = Vector3.Lerp(currentVelocity, val5, iceAcceleration * Time.deltaTime);
			currentVelocity *= iceFriction;
		}
		else
		{
			currentVelocity = val5;
		}
		movement.x = currentVelocity.x;
		movement.z = currentVelocity.z;
		if (isOnLadder)
		{
			movement.y = 240f * Time.deltaTime;
		}
		else if (character.isGrounded)
		{
			movement.y = -10f;
		}
		else
		{
			movement.y += -20f * Time.deltaTime;
		}
		character.Move(movement * Time.deltaTime);
		int num3 = 0;
		Vector3 eulerAngles = ((Component)this).transform.eulerAngles;
		eulerAngles.x = num3;
		((Component)this).transform.eulerAngles = eulerAngles;
		int num4 = 0;
		Vector3 eulerAngles2 = ((Component)this).transform.eulerAngles;
		eulerAngles2.z = num4;
		((Component)this).transform.eulerAngles = eulerAngles2;
		if (day2 && limping)
		{
			AnimationState val6 = headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation2"];
			val4 = character.velocity;
			val6.speed = 1f * Mathf.Clamp01(val4.magnitude / 6f);
		}
		else if (day3 && limping)
		{
			AnimationState val7 = headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation3"];
			val4 = character.velocity;
			val7.speed = 1f * Mathf.Clamp01(val4.magnitude / 6f);
		}
		else
		{
			AnimationState val8 = headBobAnimHolder.GetComponent<Animation>()["HeadBobAnimation"];
			val4 = character.velocity;
			val8.speed = 1f * Mathf.Clamp01(val4.magnitude / 6f);
		}
		if (character.isGrounded)
		{
			PlayerIsGrounded = true;
			velocity = Vector3.zero;
			((playerFallingSound)(object)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFallingNot();
			if (timeInAir > 0.5f)
			{
				timeInAir = 0f;
				fallTimerStarted = false;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).playerLandSound();
				EnemyAIGrannyScript.playerGetCaught = true;
				EnemyAIGrannyScript.playerFallDeath = true;
				((MonoBehaviour)this).StartCoroutine(((playerCaught)(object)Player.GetComponent(typeof(playerCaught))).fallingDead());
				forwardSpeed = 0f;
			}
		}
		else
		{
			PlayerIsGrounded = false;
			if (fallTimerStarted)
			{
				timeInAir += Time.deltaTime;
				((playerFallingSound)(object)FallsoundHolder.GetComponent(typeof(playerFallingSound))).playerFalling();
			}
		}
		CharacterController component = ((Component)this).GetComponent<CharacterController>();
		Vector3 val9 = component.velocity;
		val9 = new Vector3(component.velocity.x, 0f, component.velocity.z);
		if (val9.magnitude > 0f && PlayerIsGrounded && !EnemyAIGrannyScript.playerGetCaught && !playerIsDying)
		{
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).isWalking = true;
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walk();
		}
		else
		{
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).isWalking = false;
			((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).stopwalk();
		}
		Vector3 val10 = new Vector3(0f, -1f, 0f);
		if (Physics.Raycast(checkGround.transform.position, val10, ref val, 5f))
		{
			Debug.DrawRay(checkGround.transform.position, val10, Color.yellow);
			if (((Component)val.collider).gameObject.tag == "grus")
			{
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkGrus = true;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkWater = false;
			}
			if (((Component)val.collider).gameObject.tag == "golv")
			{
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkGrus = false;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkWater = false;
			}
			if (((Component)val.collider).gameObject.tag == "water")
			{
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkWater = true;
				((Footsteps)(object)footstepScriptHolder.GetComponent(typeof(Footsteps))).walkGrus = false;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (((Object)((Component)other).gameObject).name == "PrimeAnomaly18LadderTrigger")
		{
			isOnLadder = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (((Object)((Component)other).gameObject).name == "PrimeAnomaly18LadderTrigger")
		{
			isOnLadder = false;
		}
	}
}
