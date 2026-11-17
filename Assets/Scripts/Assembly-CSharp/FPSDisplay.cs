using UnityEngine;

public class FPSDisplay : MonoBehaviour
{
	private float deltaTime;

	private void Update()
	{
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
	}

	private void OnGUI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle val = new GUIStyle();
		Rect val2 = new Rect(0f, 0f, (float)width, (float)(height * 2 / 100));
		val.alignment = (TextAnchor)0;
		val.fontSize = height * 2 / 100;
		val.normal.textColor = new Color(0f, 0f, 0.5f, 1f);
		float num = deltaTime * 1000f;
		float num2 = 1f / deltaTime;
		string text = $"{num:0.0} ms ({num2:0.} fps)";
		GUI.Label(val2, text, val);
	}
}
