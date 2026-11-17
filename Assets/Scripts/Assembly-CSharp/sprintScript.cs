using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class sprintScript : MonoBehaviour
{
	public bool sprintGone;

	public GameObject sparcle1;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (((Component)this).GetComponent<Animation>().IsPlaying("sprintAnim") && !sprintGone)
		{
			sprintGone = true;
			((MonoBehaviour)this).StartCoroutine(sprintTimer());
		}
	}

	public virtual IEnumerator sprintTimer()
	{
		yield return (object)new WaitForSeconds(1f);
		((Rigidbody)((Component)this).GetComponent(typeof(Rigidbody))).isKinematic = false;
		sparcle1.SetActive(false);
		yield return (object)new WaitForSeconds(5f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
