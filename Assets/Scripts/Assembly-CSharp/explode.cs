using System;
using UnityEngine;

[Serializable]
public class explode : MonoBehaviour
{
	public GameObject explosion;

	public GameObject parent;

	public virtual void explodeNow()
	{
		explosion.SetActive(true);
		parent.GetComponent<Renderer>().enabled = false;
		parent.tag = "Untagged";
	}

	public virtual void NightmareCanExplode()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (parent.transform.position.y > 100f)
		{
			AchievementSaveManager.Instance.UnlockAchievement("Fireworks");
		}
		if (Object.op_Implicit((Object)(object)((Component)((Component)this).transform.GetChild(0)).GetComponent<HandObjectFalls>()))
		{
			((Component)Object.Instantiate<GameObject>(parent, parent.transform.position, parent.transform.rotation).transform.GetChild(0)).GetComponent<HandObjectFalls>().floor3trick = true;
		}
		else
		{
			Object.Instantiate<GameObject>(parent, parent.transform.position, parent.transform.rotation);
		}
		((Collider)parent.GetComponent<BoxCollider>()).enabled = false;
		parent.GetComponent<Rigidbody>().isKinematic = true;
		explosion.SetActive(true);
		((Component)explosion.transform.GetChild(1)).gameObject.GetComponent<explodeTrigger>().Achievement = true;
		parent.GetComponent<Renderer>().enabled = false;
		parent.tag = "Untagged";
	}
}
