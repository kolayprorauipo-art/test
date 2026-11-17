using System.Collections;
using UnityEngine;

public class TestFPS : MonoBehaviour
{
	private int FramesPerSec;

	private float frequency = 1f;

	private string fps;

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(FPS());
	}

	private IEnumerator FPS()
	{
		while (true)
		{
			int lastFrameCount = Time.frameCount;
			float lastTime = Time.realtimeSinceStartup;
			yield return (object)new WaitForSeconds(frequency);
			float num = Time.realtimeSinceStartup - lastTime;
			int num2 = Time.frameCount - lastFrameCount;
			fps = $"FPS: {(float)num2 / num}";
		}
	}

	private void OnGUI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		GUI.Label(new Rect((float)(Screen.width - 100), 10f, 150f, 20f), fps);
	}
}
