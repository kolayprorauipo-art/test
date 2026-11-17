using System;
using UnityEngine;

[Serializable]
public class spiderSoundEffects : MonoBehaviour
{
	public AudioClip spiderSee;

	public AudioClip SpiderAttack;

	public AudioClip SpiderDie;

	public virtual void Start()
	{
	}

	public virtual void spiderSeePlayer()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(spiderSee, ((Component)this).transform.position);
	}

	public virtual void spiderAttackPlayer()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(SpiderAttack, ((Component)this).transform.position);
	}

	public virtual void spiderDie()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(SpiderDie, ((Component)this).transform.position);
	}
}
