using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OptionOnOff : MonoBehaviour
{
	public string PlayerPrefsSetting;

	private Toggle m_Toggle;

	private void Start()
	{
		m_Toggle = ((Component)this).GetComponent<Toggle>();
		((UnityEvent<bool>)(object)m_Toggle.onValueChanged).AddListener((UnityAction<bool>)((bool A_1) =>
		{
			ToggleValueChanged(m_Toggle);
		}));
		if (PlayerPrefs.GetInt(PlayerPrefsSetting) == 0)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt(PlayerPrefsSetting) == 1)
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt(PlayerPrefsSetting) == 0)
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
			PlayerPrefs.SetInt(PlayerPrefsSetting, 1);
		}
		else
		{
			((Component)m_Toggle).GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt(PlayerPrefsSetting, 0);
		}
	}
}
