using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class clickBeartrapMenu : MonoBehaviour
{
	public GameObject beartrapOpen;

	public GameObject beartrapClose;

	public GameObject SoundHolder;

	public bool beartrapOK;

	public Button btn1;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		if (!beartrapOK)
		{
			beartrapOK = true;
			beartrapClose.SetActive(true);
			((ButtonClicks)(object)SoundHolder.GetComponent(typeof(ButtonClicks))).beartrap();
			beartrapOpen.SetActive(false);
		}
	}
}
