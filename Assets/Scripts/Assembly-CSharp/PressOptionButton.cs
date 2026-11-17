using System;
using UnityEngine;

[Serializable]
public class PressOptionButton : MonoBehaviour
{
	public GameObject optionMenu;

	public GameObject joystick;

	public GameObject joystickRing;

	public GameObject mapButton;

	public GameObject swordButton;

	public GameObject allapapperslappar;

	public GameObject pianoCollider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch val = touches[i];
			_ = val.phase;
			_ = 3;
		}
	}
}
