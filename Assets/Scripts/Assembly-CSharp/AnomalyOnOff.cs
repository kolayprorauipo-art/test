using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class AnomalyOnOff : MonoBehaviour
{
	private Toggle m_Toggle;

	public GameObject NewTxt;

	public Resources canvas;

	public GameObject AnomalyInputField;

	public GameObject CurrentAnomalyText;

	private void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("AnomalyOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			PlayerPrefs.SetInt("AnomalyOnOff", 1);
		}
		else
		{
			PlayerPrefs.SetInt("AnomalyOnOff", 0);
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1 || PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			((Selectable)m_Toggle).interactable = false;
		}
		else
		{
			((Selectable)m_Toggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			AnomalyInputField.SetActive(false);
			CurrentAnomalyText.SetActive(false);
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
			AnomalyInputField.SetActive(true);
			CurrentAnomalyText.SetActive(true);
		}
	}
}
