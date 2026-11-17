using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class WhiteFogOnOff : MonoBehaviour
{
	public GameObject extraScaryText;

	private Toggle m_Toggle;

	public Resources canvas;

	public GameObject NewTxt;

	public GameObject WhiteFog;

	public virtual void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("FastAnimOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("FastAnimOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("FastAnimOnOff") == 0)
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
			PlayerPrefs.SetInt("FastAnimOnOff", 1);
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("FastAnimOnOff", 0);
		}
	}
}
