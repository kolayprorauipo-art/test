using UnityEngine;

public class remoteLocktrigger : MonoBehaviour
{
	public bool playerNearDoorLock;

	public GameObject gameController;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			playerNearDoorLock = true;
			if (((Object)((Component)this).gameObject).name == "TasksText")
			{
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TextObject.SetActive(true);
			}
			if (((Object)((Component)this).gameObject).name == "TVArea")
			{
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TVText.SetActive(true);
			}
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			playerNearDoorLock = false;
			if (((Object)((Component)this).gameObject).name == "TasksText")
			{
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TextObject.SetActive(false);
			}
			if (((Object)((Component)this).gameObject).name == "TVArea")
			{
				((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).TVText.SetActive(false);
			}
		}
	}

	public virtual void Start()
	{
		gameController = GameObject.Find("GameController");
	}
}
