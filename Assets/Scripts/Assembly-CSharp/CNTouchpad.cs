using UnityEngine;

public class CNTouchpad : CNAbstractController
{
	[SerializeField]
	[HideInInspector]
	private bool _isAlwaysNormalized;

	public bool isMirrored;

	public float mouseSensitivity = 1f;

	public SensitivitySlider SensivityChanger;

	private Vector2 smoothMouse;

	public bool IsAlwaysNormalized
	{
		get
		{
			return _isAlwaysNormalized;
		}
		set
		{
			_isAlwaysNormalized = value;
		}
	}

	protected virtual void Update()
	{
	}

	protected override void TweakControl(Vector2 touchPosition)
	{
	}
}
