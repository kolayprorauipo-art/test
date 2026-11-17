using System;
using UnityEngine;

[Serializable]
public class teddyFalls : MonoBehaviour
{
	public Transform objectResetPos;

	public GameObject ParentObject;

	public Transform player;

	public GameObject GameController;

	public virtual void Start()
	{
		objectResetPos = GameObject.Find("ObjectResetPoint").transform;
		GameController = GameObject.Find("GameController");
		Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameObject.Find("GrannyCantSeeCollider").GetComponent<Collider>(), true);
		Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameObject.Find("GrannyCantSeeCollider2").GetComponent<Collider>(), true);
		Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), GameController.GetComponent<startNewDay>().Player.GetComponent<Collider>(), true);
		Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), ((Component)GameController.GetComponent<startNewDay>().playerCam).GetComponent<Collider>(), true);
		GameObject[] array = GameObject.FindGameObjectsWithTag("granny");
		for (int i = 0; i < array.Length; i++)
		{
			Collider component = array[i].GetComponent<Collider>();
			if ((Object)(object)component != (Object)null)
			{
				Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), component, true);
			}
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<CharacterController>(), true);
		}
		else if (((Component)other).gameObject.tag == "resetfloor")
		{
			ParentObject.transform.position = objectResetPos.position;
		}
	}
}
