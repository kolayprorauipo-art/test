using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemChecker : MonoBehaviour
{
	private void Awake()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)Object.FindObjectOfType<EventSystem>()))
		{
			GameObject val = new GameObject("EventSystem");
			val.AddComponent<EventSystem>();
			val.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}
}
