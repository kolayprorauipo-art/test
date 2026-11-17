using UnityEngine;

public class DropPointMoveAway : MonoBehaviour
{
	public Vector3 initialPosition;

	public bool itWorks;

	public void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		initialPosition = ((Component)this).gameObject.transform.localPosition;
	}

	public void OnTriggerStay(Collider other)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if ((((Component)other).gameObject.tag == "Untagged" || ((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "grus" || ((Component)other).gameObject.tag == "water") && !other.isTrigger)
		{
			((Component)this).gameObject.transform.localPosition = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z - 1f);
			((Component)this).gameObject.GetComponent<SphereCollider>().center = new Vector3(0f, 0f, 1f);
			itWorks = true;
			Debug.Log((object)((Object)((Component)other).gameObject).name);
		}
	}

	public void OnTriggerExit(Collider other)
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if ((((Component)other).gameObject.tag == "Untagged" || ((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "grus" || ((Component)other).gameObject.tag == "water") && !other.isTrigger)
		{
			((Component)this).gameObject.transform.localPosition = initialPosition;
			((Component)this).gameObject.GetComponent<SphereCollider>().center = new Vector3(0f, 0f, 0f);
			itWorks = false;
		}
	}
}
