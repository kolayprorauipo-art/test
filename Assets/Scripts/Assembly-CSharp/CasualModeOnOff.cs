using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CasualModeOnOff : MonoBehaviour
{
	private Toggle m_Toggle;

	public GameObject DropdownChanger;

	public void Update()
	{
		if (PlayerPrefs.GetInt("CasualOnOff") == 0)
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
			PlayerPrefs.SetInt("CasualOnOff", 1);
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("CasualOnOff", 0);
		}
		DropdownChanger.GetComponent<dropDownOptions>().ChangeDropdown();
	}

	public void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt("CasualOnOff") == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("CasualOnOff") == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}
}
