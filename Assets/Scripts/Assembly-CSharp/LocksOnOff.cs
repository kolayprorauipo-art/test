using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class LocksOnOff : MonoBehaviour
{
	public bool twoLocksOnOff;

	private Toggle m_Toggle;

	public virtual void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
		else if (PlayerPrefs.GetInt("SETtwoLocksOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("SETtwoLocksOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			PlayerPrefs.SetInt("twoLocksOnOff", 1);
			if (PlayerPrefs.GetInt("DiffData") != 5 && PlayerPrefs.GetInt("DiffData") != 6 && PlayerPrefs.GetInt("DiffData") != 7)
			{
				PlayerPrefs.SetInt("SETtwoLocksOnOff", 1);
			}
		}
		else
		{
			twoLocksOnOff = true;
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("twoLocksOnOff", 0);
			PlayerPrefs.SetInt("SETtwoLocksOnOff", 0);
		}
	}
}
