using System;
using UnityEngine;

[Serializable]
public class clickRemoveAdsButton : MonoBehaviour
{
	public GameObject ljudHolder;

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
		}
	}
}
