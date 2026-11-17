using System;
using UnityEngine;

[Serializable]
public class GrannyFootstep : MonoBehaviour
{
	public AudioClip[] footstepGranny;

	public AudioClip[] footstepGrusGranny;

	public AudioClip[] footstepWaterGranny;

	public int walkGrus;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void step()
	{
		if (PlayerPrefs.GetInt("DiffData") != 4)
		{
			if (walkGrus == 0)
			{
				int num = Random.Range(0, footstepGranny.Length);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepGranny[num]);
			}
			else if (walkGrus == 1)
			{
				int num2 = Random.Range(0, footstepGrusGranny.Length);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepGrusGranny[num2]);
			}
			else if (walkGrus == 2)
			{
				int num3 = Random.Range(0, footstepWaterGranny.Length);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(footstepWaterGranny[num3]);
			}
		}
	}
}
