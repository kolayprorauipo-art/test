using System;
using UnityEngine;

[Serializable]
public class adForceToBody : MonoBehaviour
{
	public GameObject player;

	public bool grannyShoot;

	public virtual void Start()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		player = GameObject.Find("Player");
		Vector3 val = player.transform.position - ((Component)this).transform.position;
		((Component)this).GetComponent<Rigidbody>().AddForce(-val * 500f);
	}

	public virtual void Update()
	{
	}
}
