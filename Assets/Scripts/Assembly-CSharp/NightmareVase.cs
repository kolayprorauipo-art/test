using UnityEngine;

public class NightmareVase : MonoBehaviour
{
	public virtual void Start()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("kitchenDoor2Open");
		Collider component = ((Component)this).GetComponent<Collider>();
		GameObject[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Collider component2 = array2[i].GetComponent<Collider>();
			if ((Object)(object)component2 != (Object)null)
			{
				Physics.IgnoreCollision(component, component2, true);
			}
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
	}
}
