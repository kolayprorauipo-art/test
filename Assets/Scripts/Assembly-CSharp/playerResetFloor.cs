using System;
using UnityEngine;

[Serializable]
public class playerResetFloor : MonoBehaviour
{
	public GameObject player;

	public Transform playerResetPos;

	public GameObject Sound1;

	public GameObject Sound2;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "resetfloor")
		{
			player.transform.position = playerResetPos.position;
			((backgroundSound)(object)Sound1.GetComponent(typeof(backgroundSound))).fadeDown = true;
			((backgroundSound)(object)Sound2.GetComponent(typeof(backgroundSound))).fadeUp = true;
		}
	}
}
