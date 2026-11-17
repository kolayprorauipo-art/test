using System;
using UnityEngine;

[Serializable]
public class ButtonClicks : MonoBehaviour
{
	public AudioClip buttonclick;

	public AudioClip bearTrap;

	public virtual void clickButton()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(buttonclick, ((Component)this).transform.position);
	}

	public virtual void beartrap()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(bearTrap, ((Component)this).transform.position);
	}
}
