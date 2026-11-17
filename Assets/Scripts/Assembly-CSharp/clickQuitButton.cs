using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class clickQuitButton : MonoBehaviour
{
	public GameObject ljudHolder;

	public bool buttonPressed;

	public bool buttonsounds;

	public Button btn1;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
		Application.Quit();
	}
}
