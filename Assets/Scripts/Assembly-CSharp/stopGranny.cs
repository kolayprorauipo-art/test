using System;
using UnityEngine;

[Serializable]
public class stopGranny : MonoBehaviour
{
	public GameObject planka1;

	public GameObject planka2;

	public GameObject planka3;

	public AudioClip taBortPlanka;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "granny" && PlayerPrefs.GetInt("DiffData") == -1)
		{
			if ((Object)(object)GameObject.Find("PlankaVind") != (Object)null)
			{
				((Rigidbody)planka1.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				((Component)planka1.GetComponent<Collider>()).gameObject.tag = "plankawalk";
				((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			if ((Object)(object)GameObject.Find("PlankaVind2") != (Object)null)
			{
				((Rigidbody)planka2.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				((Component)planka2.GetComponent<Collider>()).gameObject.tag = "plankawalk";
				((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			if ((Object)(object)GameObject.Find("PlankaVind3") != (Object)null)
			{
				((Rigidbody)planka3.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
				((Component)planka3.GetComponent<Collider>()).gameObject.tag = "plankawalk";
				((Component)this).GetComponent<AudioSource>().PlayOneShot(taBortPlanka);
			}
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}
}
