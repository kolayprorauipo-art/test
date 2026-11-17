using UnityEngine;
using UnityEngine.UI;

public class opendoorbugfix : MonoBehaviour
{
	public GameObject DoorRay;

	public Image handSprite;

	private void Update()
	{
		if (DoorRay.activeInHierarchy)
		{
			((Behaviour)handSprite).enabled = true;
		}
		else
		{
			((Behaviour)handSprite).enabled = false;
		}
	}
}
