using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ClickNightmareEventButton : MonoBehaviour
{
	public Button btn1;

	public GameObject NewText;

	public GameObject C;

	public Resources canvas;

	public virtual void Start()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		btn1 = ((Component)this).gameObject.GetComponent<Button>();
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
		((Component)this).gameObject.SetActive(false);
	}

	private void TaskOnClick()
	{
		GameObject.Find("GameController").GetComponent<ClickPlayButton>().TaskOnClick();
		PlayerPrefs.SetInt("EventChallenge2", 1);
		PlayerPrefs.SetInt("DiffData", 0);
		PlayerPrefs.SetInt("AnomalyOnOff", 0);
		PlayerPrefs.SetInt("DarkerOnOff", 0);
		PlayerPrefs.SetInt("TwoLocksOnOff", 0);
		PlayerPrefs.SetInt("RandomNR", 100);
	}
}
