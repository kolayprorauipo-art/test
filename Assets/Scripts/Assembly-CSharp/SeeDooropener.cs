using System;
using UnityEngine;

[Serializable]
public class SeeDooropener : MonoBehaviour
{
	public GameObject yellowRay1;

	public GameObject hitDoorButton;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = yellowRay1.transform.TransformDirection(Vector3.forward);
		Debug.DrawRay(yellowRay1.transform.position, val2 * 3f, Color.yellow);
		if (Physics.Raycast(yellowRay1.transform.position, val2, ref val, 4f))
		{
			if (((Component)val.collider).gameObject.tag == "dooropener")
			{
				hitDoorButton.SetActive(true);
			}
			else if (((Component)val.collider).gameObject.tag == "Untagged")
			{
				hitDoorButton.SetActive(false);
			}
		}
		else
		{
			hitDoorButton.SetActive(false);
		}
	}
}
