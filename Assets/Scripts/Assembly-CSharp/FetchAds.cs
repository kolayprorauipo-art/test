using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class FetchAds : MonoBehaviour
{
	public GameObject blackScreen;

	public GameObject optionMenu;

	public GameObject granny;

	public virtual void Start()
	{
	}

	public virtual void toMainMenu()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		Time.timeScale = 1f;
		blackScreen.SetActive(true);
		((Graphic)GameObject.Find("BlackScreenAdsPlay").GetComponent<Image>()).color = Color.black;
		optionMenu.SetActive(false);
		granny.SetActive(false);
		SceneManager.LoadScene("Scene 1");
	}

	public virtual void readyToMainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Scene 1");
	}
}
