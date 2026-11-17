using System;
using UnityEngine;

[Serializable]
public class soundEffectsBeds : MonoBehaviour
{
	public AudioClip PCaught;

	public AudioClip NoScreamersCaught;

	public virtual void Start()
	{
	}

	public virtual void playerCaught()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("NoScreamersOnOff") == 0)
		{
			AudioSource.PlayClipAtPoint(PCaught, ((Component)this).transform.position);
		}
		else
		{
			AudioSource.PlayClipAtPoint(NoScreamersCaught, ((Component)this).transform.position);
		}
	}
}
