using UnityEngine;

public class Anomaly46CameraChange : MonoBehaviour
{
	private startNewDay StartNewDay;

	private void Start()
	{
		StartNewDay = GameObject.Find("GameController").GetComponent<startNewDay>();
	}

	private void Update()
	{
		((Component)this).gameObject.GetComponent<Camera>().fieldOfView = StartNewDay.Anomaly46FOV;
	}
}
