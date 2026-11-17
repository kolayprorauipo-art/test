using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class LightsOutOnOff : MonoBehaviour
{
	private Toggle m_Toggle;

	public GameObject NewTxt;

	public Resources canvas;

	public GameObject LightsOutToggle;

	private void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("EventChallenge3") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			PlayerPrefs.SetInt("EventChallenge3", 1);
		}
		else
		{
			PlayerPrefs.SetInt("EventChallenge3", 0);
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("EventChallenge3") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}
}
