using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class skruvplattaOutside : MonoBehaviour
{
	public bool skruv1;

	public bool skruv2;

	public bool skruv3;

	public bool skruv4;

	public GameObject Screw1;

	public GameObject Screw2;

	public GameObject Screw3;

	public GameObject Screw4;

	public bool skruvBorta;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (skruv1 && skruv2 && skruv3 && skruv4 && !skruvBorta)
		{
			skruvBorta = true;
			((MonoBehaviour)this).StartCoroutine(plattaFaller());
		}
	}

	public virtual IEnumerator plattaFaller()
	{
		yield return (object)new WaitForSeconds(1f);
		((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
	}

	public virtual IEnumerator Screw1Bort()
	{
		yield return (object)new WaitForSeconds(0.8f);
		Object.Destroy((Object)(object)Screw1);
	}

	public virtual IEnumerator Screw2Bort()
	{
		yield return (object)new WaitForSeconds(0.8f);
		Object.Destroy((Object)(object)Screw2);
	}

	public virtual IEnumerator Screw3Bort()
	{
		yield return (object)new WaitForSeconds(0.8f);
		Object.Destroy((Object)(object)Screw3);
	}

	public virtual IEnumerator Screw4Bort()
	{
		yield return (object)new WaitForSeconds(0.8f);
		Object.Destroy((Object)(object)Screw4);
	}
}
