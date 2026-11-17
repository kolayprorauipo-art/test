using UnityEngine;

public class deactivateIceBreakSound : MonoBehaviour
{
	public AudioClip iceBreak;

	public virtual void playIceBreak()
	{
		((Component)this).GetComponent<AudioSource>().PlayOneShot(iceBreak);
	}
}
