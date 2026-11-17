using UnityEngine;

public class MyAppStart : MonoBehaviour
{
	public static string appKey = "8eec4d4d";

	private void Start()
	{
		IronSource.Agent.getAdvertiserId();
		IronSource.Agent.init(appKey);
	}

	private void OnApplicationPause(bool isPaused)
	{
		Debug.Log((object)("unity-script: OnApplicationPause = " + isPaused));
		IronSource.Agent.onApplicationPause(isPaused);
	}
}
