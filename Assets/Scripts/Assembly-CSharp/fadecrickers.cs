using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class fadecrickers : MonoBehaviour
{
	public float volume;

	public bool startFade;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(7f);
		startFade = true;
	}

	public virtual void Update()
	{
		if (startFade)
		{
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
		}
	}
}
