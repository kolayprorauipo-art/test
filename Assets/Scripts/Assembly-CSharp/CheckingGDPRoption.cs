using UnityEngine;

public class CheckingGDPRoption : MonoBehaviour
{
	public GameObject GDPRmenu;

	public GameObject menuButtons;

	public void AcceptGdprButton()
	{
		IronSource.Agent.setConsent(consent: true);
		GDPRmenu.SetActive(false);
		menuButtons.SetActive(true);
		PlayerPrefs.SetInt("GDPRoption", 1);
	}

	public void RejectGdprButton()
	{
		IronSource.Agent.setConsent(consent: false);
		GDPRmenu.SetActive(false);
		menuButtons.SetActive(true);
		PlayerPrefs.SetInt("GDPRoption", 1);
	}
}
