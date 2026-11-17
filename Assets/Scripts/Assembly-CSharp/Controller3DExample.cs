using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Controller3DExample : MonoBehaviour
{
	public const float ROTATE_SPEED = 15f;

	public float movementSpeed = 5f;

	public CNAbstractController MovementJoystick;

	private CharacterController _characterController;

	private Transform _mainCameraTransform;

	private Transform _transformCache;

	private Transform _playerTransform;

	private void Start()
	{
		_characterController = ((Component)this).GetComponent<CharacterController>();
		_mainCameraTransform = ((Component)Camera.main).GetComponent<Transform>();
		_transformCache = ((Component)this).GetComponent<Transform>();
		_playerTransform = _transformCache.Find("Cocoon");
	}

	private void Update()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		Vector3 movement = new Vector3(MovementJoystick.GetAxis("Horizontal"), 0f, MovementJoystick.GetAxis("Vertical"));
		CommonMovementMethod(movement);
	}

	private void MoveWithEvent(Vector3 inputMovement)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Vector3 movement = new Vector3(inputMovement.x, 0f, inputMovement.y);
		CommonMovementMethod(movement);
	}

	private void CommonMovementMethod(Vector3 movement)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		movement = _mainCameraTransform.TransformDirection(movement);
		movement.y = 0f;
		movement.Normalize();
		FaceDirection(movement);
		_characterController.Move(movement * movementSpeed * Time.deltaTime);
	}

	public void FaceDirection(Vector3 direction)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StopCoroutine("RotateCoroutine");
		((MonoBehaviour)this).StartCoroutine("RotateCoroutine", (object)direction);
	}

	private IEnumerator RotateCoroutine(Vector3 direction)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (!(direction == Vector3.zero))
		{
			Quaternion lookRotation = Quaternion.LookRotation(direction);
			Vector3 val;
			do
			{
				_playerTransform.rotation = Quaternion.Lerp(_playerTransform.rotation, lookRotation, Time.deltaTime * 15f);
				yield return null;
				val = direction - _playerTransform.forward;
			}
			while (val.sqrMagnitude > 0.2f);
		}
	}
}
