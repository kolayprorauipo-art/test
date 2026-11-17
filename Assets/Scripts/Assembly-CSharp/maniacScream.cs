using System;
using UnityEngine;

[Serializable]
public class maniacScream : MonoBehaviour
{
	public AudioClip seePlayerSound;

	public AudioClip hitSword;

	public AudioClip scream;

	public bool screamNow;

	public virtual void Start()
	{
		((Component)this).GetComponent<AudioSource>();
	}

	public virtual void Update()
	{
	}

	public virtual void maniacSeePlayer()
	{
		((Component)this).GetComponent<AudioSource>().clip = seePlayerSound;
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void swordHit()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(hitSword, ((Component)this).transform.position);
	}

	public virtual void ManiacScream()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(scream, ((Component)this).transform.position);
	}
}
