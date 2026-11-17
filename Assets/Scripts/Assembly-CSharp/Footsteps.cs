using System;
using UnityEngine;

[Serializable]
public class Footsteps : MonoBehaviour
{
	public AudioClip[] footstepConcrete;

	public AudioClip[] footstepConcreteSticky;

	public AudioClip[] footstepGrus;

	public AudioClip[] footstepWater;

	public bool isWalking;

	public bool walkGrus;

	public bool walkWater;

	public GameObject headBob;

	public bool day2;

	public bool day3;

	public bool limping;

	public Footsteps()
	{
		isWalking = true;
	}

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("LimpingOnOff") == 1)
		{
			limping = true;
		}
	}

	public virtual void Update()
	{
	}

	public virtual void step()
	{
		if (!isWalking)
		{
			return;
		}
		if (!walkGrus && !walkWater)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				int num = Random.Range(0, footstepConcreteSticky.Length);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepConcreteSticky[num]);
			}
			else
			{
				int num2 = Random.Range(0, footstepConcrete.Length);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepConcrete[num2]);
			}
		}
		else if (walkGrus)
		{
			int num3 = Random.Range(0, footstepGrus.Length);
			((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepGrus[num3]);
		}
		else if (walkWater)
		{
			int num4 = Random.Range(0, footstepWater.Length);
			((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepWater[num4]);
		}
	}

	public virtual void walk()
	{
		if (headBob.GetComponent<Animation>().IsPlaying("playerHurt"))
		{
			return;
		}
		if (isWalking)
		{
			if (day2 && limping)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation2");
			}
			else if (day3 && limping)
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation3");
			}
			else
			{
				headBob.GetComponent<Animation>().Play("HeadBobAnimation");
			}
		}
		else if (day2 && limping)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
		}
		else if (day3 && limping)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
		}
	}

	public virtual void stopwalk()
	{
		((Component)this).GetComponent<AudioSource>().Stop();
		if (day2 && limping)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation2");
		}
		else if (day3 && limping)
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation3");
		}
		else
		{
			headBob.GetComponent<Animation>().Stop("HeadBobAnimation");
		}
	}
}
