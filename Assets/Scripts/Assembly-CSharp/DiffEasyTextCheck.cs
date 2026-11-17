using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DiffEasyTextCheck : MonoBehaviour
{
	public GameObject diffEasyText;

	public GameObject diffHardText;

	public GameObject diffNormalText;

	public GameObject diffExtremeText;

	public GameObject diffPractiseText;

	public GameObject diffMadness05Text;

	public Toggle darkerToggle;

	public Toggle extraLockToggle;

	public Sprite EasyMode;

	public Sprite ChillMode;

	public Sprite PracticeMode;

	public Sprite NormalMode;

	public Sprite PrimeMode;

	public Sprite PrimePlusMode;

	public Sprite NerfedPrimeMode;

	public GameObject ExtraEnemyDropdown;

	public GameObject ExtraTrapsTraining;

	public GameObject ExtraTrapsLaser;

	public GameObject Granny;

	public GameObject PracticeNote;

	public InputField AnomalyInputfield;

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("fogOnExtreme") == 1)
		{
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		else
		{
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			Granny.SetActive(false);
			PracticeNote.SetActive(true);
		}
		else
		{
			Granny.SetActive(true);
			PracticeNote.SetActive(false);
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
		{
			ExtraTrapsTraining.SetActive(true);
			ExtraTrapsLaser.SetActive(true);
		}
		else
		{
			ExtraTrapsTraining.SetActive(false);
			ExtraTrapsLaser.SetActive(false);
		}
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			diffMadness05Text.SetActive(true);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
			return;
		}
		diffMadness05Text.SetActive(false);
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = ChillMode;
			diffNormalText.SetActive(false);
			diffHardText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = NormalMode;
			diffNormalText.SetActive(false);
			diffHardText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = EasyMode;
			diffHardText.SetActive(false);
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffHardText.SetActive(true);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffPractiseText.SetActive(false);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffExtremeText.SetActive(true);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			diffPractiseText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 4)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = PracticeMode;
			diffPractiseText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffNormalText.SetActive(false);
			((Selectable)darkerToggle).interactable = true;
			((Selectable)extraLockToggle).interactable = true;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffPractiseText.SetActive(true);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffNormalText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffNormalText.SetActive(true);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffEasyText.SetActive(false);
			diffPractiseText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 0 && PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1 && (PlayerPrefs.GetInt("AnomalyOnOff") == 0 || (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && AnomalyInputfield.text != "1" && AnomalyInputfield.text != "6" && AnomalyInputfield.text != "9" && AnomalyInputfield.text != "15" && AnomalyInputfield.text != "16")))
		{
			ExtraEnemyDropdown.SetActive(true);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = NerfedPrimeMode;
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffPractiseText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("ExtraTrapsOnOff") == 1)
		{
			ExtraEnemyDropdown.SetActive(false);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = PrimePlusMode;
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffPractiseText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		else if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			ExtraEnemyDropdown.SetActive(true);
			diffEasyText.SetActive(true);
			diffEasyText.GetComponent<Image>().sprite = PrimeMode;
			diffNormalText.SetActive(false);
			diffExtremeText.SetActive(false);
			diffHardText.SetActive(false);
			diffPractiseText.SetActive(false);
			darkerToggle.isOn = true;
			((Selectable)darkerToggle).interactable = false;
			extraLockToggle.isOn = true;
			((Selectable)extraLockToggle).interactable = false;
		}
		if (PlayerPrefs.GetInt("EventChallenge2") == 1 || PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			extraLockToggle.isOn = false;
			((Selectable)extraLockToggle).interactable = false;
			darkerToggle.isOn = false;
			((Selectable)darkerToggle).interactable = false;
		}
	}
}
