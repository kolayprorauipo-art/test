using UnityEngine;

public class ignoreCollider : MonoBehaviour
{
	public GameObject trap;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(trap.GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<CharacterController>(), true);
		}
	}
}
