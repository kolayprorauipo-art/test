using System.Collections;
using UnityEngine;

public class AbandonedDifferentSounds : MonoBehaviour
{
	public AudioSource audio;

	public AudioClip[] differentSounds;

	private void OnEnable()
	{
		((MonoBehaviour)this).StartCoroutine(AbandonedSound(1f));
	}

	public IEnumerator AbandonedSound(float time)
	{
		yield return (object)new WaitForSeconds(134f * time);
		audio.PlayOneShot(differentSounds[Random.Range(0, differentSounds.Length)]);
		((MonoBehaviour)this).StartCoroutine(AbandonedSound(3f));
	}
}
