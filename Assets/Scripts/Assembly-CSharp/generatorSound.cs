using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class generatorSound : MonoBehaviour
{
	public AudioClip generatorStart;

	public AudioClip generatorRun;

	public virtual void Start()
	{
	}

	public virtual void startGen()
	{
		((Component)this).GetComponent<AudioSource>().PlayOneShot(generatorStart);
		((MonoBehaviour)this).StartCoroutine(genTimer());
	}

	public virtual void runGen()
	{
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual IEnumerator genTimer()
	{
		yield return (object)new WaitForSeconds(2f);
		runGen();
	}
}
