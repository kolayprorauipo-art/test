using System;
using UnityEngine;

[Serializable]
public class disableKinematic : MonoBehaviour
{
	public AudioClip sound;

	public bool done;

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !done)
		{
			done = true;
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(sound);
		}
	}
}
