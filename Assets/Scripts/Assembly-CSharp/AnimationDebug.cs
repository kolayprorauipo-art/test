using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(AnimationController))]
public class AnimationDebug : MonoBehaviour
{
	private AnimationController animationController;

	private CharacterController character;

	public virtual void Start()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		character = (CharacterController)((Component)this).GetComponent(typeof(CharacterController));
		animationController = (AnimationController)(object)((Component)this).GetComponent(typeof(AnimationController));
		if (!Application.isEditor)
		{
			Object.Destroy((Object)(object)this);
		}
	}

	public virtual void OnGUI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.font = null;
		float num = 0f;
		AnimationState val = null;
		foreach (AnimationState item in animationController.animationTarget)
		{
			AnimationState val2 = item;
			if (val2.weight > num)
			{
				num = val2.weight;
				val = val2;
			}
		}
		Vector3 velocity = character.velocity;
		Vector3 val3 = velocity;
		val3.y = 0f;
		float magnitude = val3.magnitude;
		if (TrackedReference.op_Implicit((TrackedReference)(object)val))
		{
			GUI.Label(new Rect(10f, 70f, 400f, 60f), string.Format("Vel: {5}  Speed: {0:0.000}\nAnimation: {1}\n  * weight {2:0.00}  speed {3:0.00} time {4:0.00}", magnitude, val.name, val.weight, val.speed, val.normalizedTime, velocity));
		}
	}
}
