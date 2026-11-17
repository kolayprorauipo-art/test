using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class clickMoreInfo2 : MonoBehaviour
{
	public Button btn1;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		Application.OpenURL("https://dvloperapps.weebly.com");
	}
}
