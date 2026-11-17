using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class FootstepScript : MonoBehaviour
{
	public AudioClip[] footstepConcrete;

	public bool step;

	public bool startWalking;

	public float audioStepLengthWalk;

	public FootstepScript()
	{
		step = true;
		startWalking = true;
		audioStepLengthWalk = 0.45f;
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (startWalking && !step)
		{
			step = true;
			((MonoBehaviour)this).StartCoroutine(Playerwalk());
		}
	}

	public virtual void walk()
	{
		startWalking = true;
	}

	public virtual IEnumerator Playerwalk()
	{
		if (step)
		{
			step = false;
			((Component)this).GetComponent<AudioSource>().clip = footstepConcrete[Random.Range(0, footstepConcrete.Length)];
			((Component)this).GetComponent<AudioSource>().volume = 1f;
			((Component)this).GetComponent<AudioSource>().Play();
			yield return (object)new WaitForSeconds(audioStepLengthWalk);
			step = true;
		}
	}

	public virtual void stopwalk()
	{
		startWalking = false;
		step = false;
		((Component)this).GetComponent<AudioSource>().Stop();
	}
}
