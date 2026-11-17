using System;
using UnityEngine;

[Serializable]
public class GrannySounds : MonoBehaviour
{
	public AudioClip[] Glaugh;

	public AudioClip skratt;

	public virtual void Start()
	{
	}

	public virtual void startGrannySound()
	{
		((Component)this).GetComponent<AudioSource>().clip = Glaugh[Random.Range(0, Glaugh.Length)];
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void grannySkrattar()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(skratt, ((Component)this).transform.position);
	}
}
