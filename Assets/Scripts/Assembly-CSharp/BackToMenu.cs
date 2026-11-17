using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public class BackToMenu : MonoBehaviour
{
	public GameObject savedValue;

	public GameObject soundHolder;

	public GameObject gameController;

	public startNewDay startNewDayScript;

	public bool buttonClicked;

	public Button btn1;

	public virtual void Start()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		if (startNewDayScript.saveRandomNR)
		{
			PlayerPrefs.SetInt("randomNR", 100);
		}
		if (startNewDayScript.saveInOrder)
		{
			PlayerPrefs.SetInt("randomNR", 99);
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			((Component)startNewDayScript).GetComponent<startNewDay>().CheckNewBest();
		}
		if (((Component)startNewDayScript).GetComponent<startNewDay>().GrannyGauntlet)
		{
			GlobalSaveManager.InstanceSaveData.SaveAllData("GrannyGauntlet", 0);
		}
		saveSensitivityData val = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		PlayerPrefs.SetInt("slideData", (int)val.sliderValue);
		((backgroundSound)(object)soundHolder.GetComponent(typeof(backgroundSound))).buttonClick();
		((FetchAds)(object)gameController.GetComponent(typeof(FetchAds))).toMainMenu();
		PlayerPrefs.SetInt("teddyInPlace", 0);
	}
}
