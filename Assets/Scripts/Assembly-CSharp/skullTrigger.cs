using UnityEngine;

public class skullTrigger : MonoBehaviour
{
	public GameObject skull;

	public bool skullFallen;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !skullFallen)
		{
			skullFallen = true;
			((Rigidbody)skull.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
	}
}
