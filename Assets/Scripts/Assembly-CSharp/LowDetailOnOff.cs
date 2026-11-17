using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class LowDetailOnOff : MonoBehaviour
{
	private Toggle m_Toggle;

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("LowDetailOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			PlayerPrefs.SetInt("LowDetailOnOff", 1);
			QualitySettings.SetQualityLevel(0);
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("LowDetailOnOff", 0);
			QualitySettings.SetQualityLevel(2);
		}
	}

	public virtual void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("LowDetailOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			QualitySettings.SetQualityLevel(2);
		}
		else if (PlayerPrefs.GetInt("LowDetailOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			QualitySettings.SetQualityLevel(0);
		}
	}
}
