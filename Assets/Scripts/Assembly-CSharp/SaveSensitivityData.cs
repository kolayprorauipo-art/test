using System;
using UnityEngine;

[Serializable]
public class SaveSensitivityData : MonoBehaviour
{
	public static float sliderValue;

	public virtual void Awake()
	{
		Object.DontDestroyOnLoad((Object)(object)((Component)((Component)this).transform).gameObject);
	}
}
