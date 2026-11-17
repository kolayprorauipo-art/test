using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class ClickOnOffMusic : MonoBehaviour
{
	private Toggle m_Toggle;

	public GameObject musicHolder;

	private void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			musicHolder.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("musikOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			musicHolder.SetActive(false);
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			PlayerPrefs.SetInt("musikOnOff", 0);
			musicHolder.SetActive(true);
		}
		else
		{
			PlayerPrefs.SetInt("musikOnOff", 1);
			musicHolder.SetActive(false);
		}
	}
}
