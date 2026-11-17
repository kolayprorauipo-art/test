using UnityEngine;

public class CheckingGDPR : MonoBehaviour
{
	public GameObject GDPRmenu;

	public GameObject menuButtons;

	public GameObject iapButtons;

	public void AcceptGdprButton()
	{
		GDPRmenu.SetActive(false);
		menuButtons.SetActive(true);
		iapButtons.SetActive(true);
		PlayerPrefs.SetInt("GDPRoption", 1);
	}

	public void RejectGdprButton()
	{
		GDPRmenu.SetActive(false);
		menuButtons.SetActive(true);
		iapButtons.SetActive(true);
		PlayerPrefs.SetInt("GDPRoption", 1);
	}
}
