using System;
using UnityEngine;

[Serializable]
public class StartTheApp : MonoBehaviour
{
	public GameObject GDPRmenu;

	public GameObject menuButtons;

	public GameObject Message;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("DontShowMessageOnOff") == 1)
		{
			menuButtons.SetActive(true);
		}
		else if (PlayerPrefs.GetInt("DontShowMessageOnOff") == 0)
		{
			Message.SetActive(true);
		}
	}
}
