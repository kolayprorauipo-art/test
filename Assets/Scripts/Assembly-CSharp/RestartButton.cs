using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class RestartButton : MonoBehaviour
{
	public GameObject soundHolder;

	public bool buttonClicked;

	public Button btn1;

	public startNewDay startNewDayScript;

	public virtual void Start()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		btn1 = ((Component)this).gameObject.GetComponent<Button>();
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		Time.timeScale = 1f;
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
		PlayerPrefs.SetInt("teddyInPlace", 0);
		PlayerPrefs.SetInt("Anomaly27Levels", 0);
		PlayerPrefs.SetInt("EventTrap", 0);
		SceneManager.LoadScene("Scene");
	}
}
