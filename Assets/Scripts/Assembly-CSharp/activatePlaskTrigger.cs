using UnityEngine;

public class activatePlaskTrigger : MonoBehaviour
{
	public GameObject plaskTrigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			plaskTrigger.SetActive(true);
		}
	}
}
