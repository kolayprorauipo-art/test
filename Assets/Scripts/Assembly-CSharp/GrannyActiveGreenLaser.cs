using UnityEngine;

public class GrannyActiveGreenLaser : MonoBehaviour
{
	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Object)((Component)other).gameObject).name == "Bip01 Head")
		{
			GameController.GetComponent<startNewDay>().activateGreenLaser = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Object)((Component)other).gameObject).name == "Bip01 Head")
		{
			GameController.GetComponent<startNewDay>().activateGreenLaser = false;
		}
	}
}
