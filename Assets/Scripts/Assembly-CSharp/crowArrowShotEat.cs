using UnityEngine;

public class crowArrowShotEat : MonoBehaviour
{
	public AudioClip crowShootLjud;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "arrow")
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(crowShootLjud, 0.7f);
		}
	}
}
