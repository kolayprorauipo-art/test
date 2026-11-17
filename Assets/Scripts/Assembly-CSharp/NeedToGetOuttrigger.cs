using System;
using UnityEngine;

[Serializable]
public class NeedToGetOuttrigger : MonoBehaviour
{
	public GameObject needToGetOutText;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			needToGetOutText.SetActive(true);
			((TextInactivate)(object)needToGetOutText.GetComponent(typeof(TextInactivate))).travelDown = true;
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
