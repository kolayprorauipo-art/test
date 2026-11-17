using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class FogOnOff : MonoBehaviour
{
	public bool fogOnOff;

	private Toggle m_Toggle;

	public virtual void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)delegate
		{
			ToggleValueChanged(m_Toggle);
		});
		if (PlayerPrefs.GetInt("fogOnOff") == 0)
		{
			if (PlayerPrefs.GetInt("fogOnExtreme") == 0)
			{
				((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			}
		}
		else if (PlayerPrefs.GetInt("fogOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("fogOnOff") == 0)
		{
			if (PlayerPrefs.GetInt("fogOnExtreme") == 0)
			{
				((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			}
		}
		else if (PlayerPrefs.GetInt("fogOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			if (PlayerPrefs.GetInt("fogOnExtreme") == 0)
			{
				PlayerPrefs.SetInt("fogOnOff", 1);
			}
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("fogOnOff", 0);
		}
	}
}
