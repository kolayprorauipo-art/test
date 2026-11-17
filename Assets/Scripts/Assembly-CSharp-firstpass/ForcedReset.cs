using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Image))]
public class ForcedReset : MonoBehaviour
{
	private void Update()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
		{
			Scene sceneAt = SceneManager.GetSceneAt(0);
			SceneManager.LoadScene(sceneAt.name);
		}
	}
}
