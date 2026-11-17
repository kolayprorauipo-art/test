using System;
using UnityEngine;

[Serializable]
public class gameOverScenes : MonoBehaviour
{
	public float GameOverScenes;

	public virtual void Awake()
	{
		Object.DontDestroyOnLoad((Object)(object)((Component)((Component)this).transform).gameObject);
	}
}
