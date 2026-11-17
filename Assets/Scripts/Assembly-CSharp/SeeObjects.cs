using UnityEngine;

public class SeeObjects : MonoBehaviour
{
	public PickUp ray;

	private void Update()
	{
		if (Input.GetKeyDown((KeyCode)101))
		{
			ray.pressPickUp();
		}
	}
}
