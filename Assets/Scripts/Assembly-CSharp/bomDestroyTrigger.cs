using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class bomDestroyTrigger : MonoBehaviour
{
	public AudioClip taBortPlanka;

	public bool soundPlaying;

	public GameObject granny;

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "bomdestroyer")
		{
			((Component)this).gameObject.tag = "Untagged";
			((Rigidbody)((Component)this).GetComponent(typeof(Rigidbody))).isKinematic = false;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).bastuBomNere = false;
			if (!soundPlaying)
			{
				soundPlaying = true;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			((MonoBehaviour)this).StartCoroutine(destroyPlank());
		}
	}

	public virtual IEnumerator destroyPlank()
	{
		yield return (object)new WaitForSeconds(10f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
