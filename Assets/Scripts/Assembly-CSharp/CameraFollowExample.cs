using UnityEngine;

public class CameraFollowExample : MonoBehaviour
{
	public CNAbstractController RotateJoystick;

	public float PitchSpeed = 10f;

	public float YawSpeed = 10f;

	public Transform player;

	public Transform playerHead;

	public float Pitch;

	public float yaw;

	public float rotationx;

	private Transform _transformCache;

	public Transform _parentTransformCache;

	private Vector3 clampedRotation;

	public bool touching;

	public bool test;

	public GameObject playerActive;

	public GameObject senseHolder;

	private saveSensitivityData SensData;

	public bool isMirrored;

	private void Start()
	{
		SensData = senseHolder.GetComponent<saveSensitivityData>();
		YawSpeed = SensData.sliderValue;
		PitchSpeed = YawSpeed / 2f;
		_transformCache = ((Component)this).GetComponent<Transform>();
		_parentTransformCache = _transformCache.parent;
		if (GameObject.Find("GameController").GetComponent<startNewDay>().AnomalyNR == 41)
		{
			isMirrored = true;
		}
	}

	private void Update()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (!playerActive.activeSelf)
		{
			PitchSpeed = 0f;
		}
		else
		{
			PitchSpeed = YawSpeed;
		}
		YawSpeed = SensData.sliderValue;
		if ((Object)(object)RotateJoystick != (Object)null && Time.timeScale != 0f)
		{
			float axisRaw = Input.GetAxisRaw("Mouse X");
			float axisRaw2 = Input.GetAxisRaw("Mouse Y");
			if (!isMirrored)
			{
				player.Rotate(Vector3.up * axisRaw * YawSpeed);
			}
			else
			{
				player.Rotate(Vector3.up * (0f - axisRaw) * YawSpeed);
			}
			rotationx -= axisRaw2 * PitchSpeed;
			rotationx = Mathf.Clamp(rotationx, -90f, 90f);
			playerHead.localEulerAngles = new Vector3(rotationx, 0f, 0f);
		}
	}
}
