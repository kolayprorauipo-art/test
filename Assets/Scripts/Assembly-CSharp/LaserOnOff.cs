using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class LaserOnOff : MonoBehaviour
{
	public bool NightmareOnOff;

	public GameObject extraScaryText;

	private Toggle m_Toggle;

	public Resources canvas;

	public GameObject NewTxt;

	public GameObject LowDetailToggle;

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
		if (PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
		{
			((Selectable)m_Toggle).interactable = false;
		}
		else
		{
			((Selectable)m_Toggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
		else if (PlayerPrefs.GetInt("SETNightmareWallsOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("SETNightmareWallsOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			PlayerPrefs.SetInt("LaserOnOffOnOff", 1);
			if (PlayerPrefs.GetInt("DiffData") != 6 && PlayerPrefs.GetInt("DiffData") != 7)
			{
				PlayerPrefs.SetInt("SETNightmareWallsOnOff", 1);
			}
		}
		else
		{
			NightmareOnOff = true;
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("LaserOnOffOnOff", 0);
			PlayerPrefs.SetInt("SETNightmareWallsOnOff", 0);
		}
	}
}
