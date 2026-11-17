using System.Collections;
using UnityEngine;

public class plaskLjudTrigger : MonoBehaviour
{
	public bool ljudSpelats;

	public AudioClip plaskljud;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !ljudSpelats)
		{
			ljudSpelats = true;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(plaskljud);
			((MonoBehaviour)this).StartCoroutine(ljudlength());
		}
	}

	public virtual IEnumerator ljudlength()
	{
		yield return (object)new WaitForSeconds(1f);
		ljudSpelats = false;
		((Component)this).gameObject.SetActive(false);
	}
}
