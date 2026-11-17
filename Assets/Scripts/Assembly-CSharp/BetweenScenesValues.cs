using System;
using UnityEngine;

[Serializable]
public class BetweenScenesValues : MonoBehaviour
{
	public static bool difficultyEasy;

	public static bool difficultyMedium;

	public static bool difficultyHard;

	public virtual void Awake()
	{
		Object.DontDestroyOnLoad((Object)(object)((Component)((Component)this).transform).gameObject);
	}
}
