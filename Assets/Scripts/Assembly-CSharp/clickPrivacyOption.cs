using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class clickPrivacyOption : MonoBehaviour
{
	public GameObject GDPRmenu;

	public GameObject menuButtons;

	public Button btn1;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		GDPRmenu.SetActive(true);
		menuButtons.SetActive(false);
	}
}
