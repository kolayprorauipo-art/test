using System;
using UnityEngine;

[Serializable]
public class deactivateSlendrina : MonoBehaviour
{
	public GameObject slendrina;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			slendrina.SetActive(false);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
