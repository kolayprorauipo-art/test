using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ClickMoregamesButton : MonoBehaviour
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
		Application.OpenURL("https://discord.gg/zK4w5mTVgv");
		((ButtonClicks)(object)ljudHolder.GetComponent(typeof(ButtonClicks))).clickButton();
		if (PlayerPrefs.GetInt("ADSon") == 0)
		{
			IronSource.Agent.destroyBanner();
		}
	}
}
