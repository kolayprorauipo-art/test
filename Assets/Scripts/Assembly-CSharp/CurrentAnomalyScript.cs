using UnityEngine;
using UnityEngine.UI;

public class CurrentAnomalyScript : MonoBehaviour
{
	public Text AnomalyDescriptionText;

	public Text AnomalyPlaceholderText;

	public GameObject NewInputField;

	public GameObject ContinueButton;

	public GameObject TrainingButton;

	public Dropdown ExtraEnemyDropdown;

	public string AnomalyText;

	private void Start()
	{
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			NewInputField.GetComponent<InputField>().text = string.Concat(PlayerPrefs.GetInt("AnomalyNR"));
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			NewInputField.GetComponent<InputField>().text = string.Concat(PlayerPrefs.GetInt("PrimeAnomalyNR"));
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			AnomalyPlaceholderText.text = "From 0 to 47";
			if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "" || (NewInputField.GetComponent<InputField>().text != "0" && NewInputField.GetComponent<InputField>().text != "1" && NewInputField.GetComponent<InputField>().text != "2" && NewInputField.GetComponent<InputField>().text != "3" && NewInputField.GetComponent<InputField>().text != "4" && NewInputField.GetComponent<InputField>().text != "5" && NewInputField.GetComponent<InputField>().text != "6" && NewInputField.GetComponent<InputField>().text != "7" && NewInputField.GetComponent<InputField>().text != "8" && NewInputField.GetComponent<InputField>().text != "9" && NewInputField.GetComponent<InputField>().text != "10" && NewInputField.GetComponent<InputField>().text != "" && NewInputField.GetComponent<InputField>().text != "11" && NewInputField.GetComponent<InputField>().text != "12" && NewInputField.GetComponent<InputField>().text != "13" && NewInputField.GetComponent<InputField>().text != "14" && NewInputField.GetComponent<InputField>().text != "15" && NewInputField.GetComponent<InputField>().text != "16" && NewInputField.GetComponent<InputField>().text != "17" && NewInputField.GetComponent<InputField>().text != "18" && NewInputField.GetComponent<InputField>().text != "19" && NewInputField.GetComponent<InputField>().text != "20" && NewInputField.GetComponent<InputField>().text != "21" && NewInputField.GetComponent<InputField>().text != "22" && NewInputField.GetComponent<InputField>().text != "23" && NewInputField.GetComponent<InputField>().text != "24" && NewInputField.GetComponent<InputField>().text != "25" && NewInputField.GetComponent<InputField>().text != "26" && NewInputField.GetComponent<InputField>().text != "27" && NewInputField.GetComponent<InputField>().text != "28" && NewInputField.GetComponent<InputField>().text != "29" && NewInputField.GetComponent<InputField>().text != "30" && NewInputField.GetComponent<InputField>().text != "31" && NewInputField.GetComponent<InputField>().text != "32" && NewInputField.GetComponent<InputField>().text != "33" && NewInputField.GetComponent<InputField>().text != "34" && NewInputField.GetComponent<InputField>().text != "35" && NewInputField.GetComponent<InputField>().text != "36" && NewInputField.GetComponent<InputField>().text != "37" && NewInputField.GetComponent<InputField>().text != "38" && NewInputField.GetComponent<InputField>().text != "39" && NewInputField.GetComponent<InputField>().text != "40" && NewInputField.GetComponent<InputField>().text != "41" && NewInputField.GetComponent<InputField>().text != "42" && NewInputField.GetComponent<InputField>().text != "43" && NewInputField.GetComponent<InputField>().text != "44" && NewInputField.GetComponent<InputField>().text != "45" && NewInputField.GetComponent<InputField>().text != "46" && NewInputField.GetComponent<InputField>().text != "47" && NewInputField.GetComponent<InputField>().text != "9191" && NewInputField.GetComponent<InputField>().text != "1405" && NewInputField.GetComponent<InputField>().text != "8841" && NewInputField.GetComponent<InputField>().text != "3991" && NewInputField.GetComponent<InputField>().text != "1793" && NewInputField.GetComponent<InputField>().text != "1000" && NewInputField.GetComponent<InputField>().text != "2134" && NewInputField.GetComponent<InputField>().text != "2025" && NewInputField.GetComponent<InputField>().text != "1954" && NewInputField.GetComponent<InputField>().text != "2202" && NewInputField.GetComponent<InputField>().text != "2311" && NewInputField.GetComponent<InputField>().text != "8228" && NewInputField.GetComponent<InputField>().text != "3103" && NewInputField.GetComponent<InputField>().text != "4542" && NewInputField.GetComponent<InputField>().text != "1305" && NewInputField.GetComponent<InputField>().text != "7102")))
			{
				AnomalyDescriptionText.text = "You can't play this anomaly";
				ContinueButton.SetActive(false);
				return;
			}
			ContinueButton.SetActive(true);
			PlayerPrefs.SetInt("AnomalyNR", int.Parse(NewInputField.GetComponent<InputField>().text));
			if (NewInputField.GetComponent<InputField>().text == "0")
			{
				AnomalyDescriptionText.text = "A random anomaly";
			}
			if (NewInputField.GetComponent<InputField>().text == "1")
			{
				AnomalyDescriptionText.text = "Anomaly 1:\r\nGranny moves 50% faster, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "2")
			{
				AnomalyDescriptionText.text = "Anomaly 2:\r\nThe house is MUCH darker, but Granny's vision is also very poor";
			}
			if (NewInputField.GetComponent<InputField>().text == "3")
			{
				AnomalyDescriptionText.text = "Anomaly 3:\r\nAll characters move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "4")
			{
				AnomalyDescriptionText.text = "Anomaly 4:\r\nAll the doors in the house are gone";
			}
			if (NewInputField.GetComponent<InputField>().text == "5")
			{
				AnomalyDescriptionText.text = "Anomaly 5:\r\nEvery 30 seconds the bell rings, reminding Granny to guard the main exit door";
			}
			if (NewInputField.GetComponent<InputField>().text == "6")
			{
				AnomalyDescriptionText.text = "Anomaly 6:\r\nYou can only crawl, but you have endless spray";
			}
			if (NewInputField.GetComponent<InputField>().text == "7")
			{
				AnomalyDescriptionText.text = "Anomaly 7:\r\nYou can't use the Drop button, but then you have long arms";
			}
			if (NewInputField.GetComponent<InputField>().text == "8")
			{
				AnomalyDescriptionText.text = "Anomaly 8:\r\nThere are more creaking floors in the house, but the padlock and trunk have already opened";
			}
			if (NewInputField.GetComponent<InputField>().text == "9")
			{
				AnomalyDescriptionText.text = "Special anomaly 9:\r\nThe Crow is terminally ill, it will die in 90 seconds, so you must feed it food to extend its life for another 90 seconds and you have only one day, but you have a bird seed";
			}
			if (NewInputField.GetComponent<InputField>().text == "10")
			{
				AnomalyDescriptionText.text = "Anomaly 10:\r\nEvery 30 seconds, a new vase will appear, which will fall in a random place in the house and may make some noise";
			}
			if (NewInputField.GetComponent<InputField>().text == "11")
			{
				AnomalyDescriptionText.text = "Anomaly 11:\r\nYou need to unlock all escape routes and you only have one day, but items will fall from the sky every 2 minutes";
			}
			if (NewInputField.GetComponent<InputField>().text == "12")
			{
				AnomalyDescriptionText.text = "Anomaly 12:\r\nYou have only 8 minutes to escape, but you move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "13")
			{
				AnomalyDescriptionText.text = "Anomaly 13:\r\nThere are almost no items in the house, only pieces of a painting, and Granny moves 25% faster. But you will escape if you collect the painting 3 times";
			}
			if (NewInputField.GetComponent<InputField>().text == "14")
			{
				AnomalyDescriptionText.text = "Anomaly 14:\r\nItems slip out of hands every 10 seconds, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "15")
			{
				AnomalyDescriptionText.text = "Anomaly 15:\r\nGranny hears NOTHING\r\n(But she is always running)";
			}
			if (NewInputField.GetComponent<InputField>().text == "16")
			{
				AnomalyDescriptionText.text = "Anomaly 16:\r\nGranny hears EVERYTHING\r\n(But not your footsteps, picking up items, locked doors and hiding under bed)";
			}
			if (NewInputField.GetComponent<InputField>().text == "17")
			{
				AnomalyDescriptionText.text = "Anomaly 17:\r\nThere are giant traps, but there are no more creaking floors in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "18")
			{
				AnomalyDescriptionText.text = "Special anomaly 18:\r\n You have returned to 1.0, but something went wrong...";
			}
			if (NewInputField.GetComponent<InputField>().text == "19")
			{
				AnomalyDescriptionText.text = "Anomaly 19:\r\n Some obstacles have been placed in the house, but you have a special remote that teleports you around the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "20")
			{
				AnomalyDescriptionText.text = "Anomaly 20:\r\n Something strange is happening with the light in the house";
			}
			if (NewInputField.GetComponent<InputField>().text == "21")
			{
				AnomalyDescriptionText.text = "Anomaly 21:\r\n When you drop an item, it will fall near the anomaly vase";
			}
			if (NewInputField.GetComponent<InputField>().text == "22")
			{
				AnomalyDescriptionText.text = "Anomaly 22:\r\n Granny moves twice as fast, but she is worse at catching you";
			}
			if (NewInputField.GetComponent<InputField>().text == "23")
			{
				AnomalyDescriptionText.text = "Anomaly 23:\r\n Granny will set new creacking floors during the game, but there are less creacking floors";
			}
			if (NewInputField.GetComponent<InputField>().text == "24")
			{
				AnomalyDescriptionText.text = "Anomaly 24:\r\n Every 4 seconds, Granny gains +1% speed (up to a maximum of 300%), but you move twice as fast";
			}
			if (NewInputField.GetComponent<InputField>().text == "25")
			{
				AnomalyDescriptionText.text = "Anomaly 25:\r\n Granny is invisible, but you have a freeze trap";
			}
			if (NewInputField.GetComponent<InputField>().text == "26")
			{
				AnomalyDescriptionText.text = "Anomaly 26:\r\n There are anomalous rats in the house. When they bite you, Granny charges a secret ability. After every fifth bite, Granny activates it";
			}
			if (NewInputField.GetComponent<InputField>().text == "27")
			{
				AnomalyDescriptionText.text = "Special anomaly 27:\r\n There are almost no items in the house, but you can find 7 keys to escape through the red door";
			}
			if (NewInputField.GetComponent<InputField>().text == "28")
			{
				AnomalyDescriptionText.text = "Anomaly 28:\r\n Granny can create her own clone, which she can use for teleportation";
			}
			if (NewInputField.GetComponent<InputField>().text == "29")
			{
				AnomalyDescriptionText.text = "Anomaly 29:\r\n There are floor plates in the house that either speed you up or slow you down by 60%";
			}
			if (NewInputField.GetComponent<InputField>().text == "30")
			{
				AnomalyDescriptionText.text = "Anomaly 30:\r\n If Granny spots you, you will die, but there are no creaking floors in the house and there is can't be darker";
			}
			if (NewInputField.GetComponent<InputField>().text == "31")
			{
				AnomalyDescriptionText.text = "Anomaly 31:\r\n Granny moves 75% faster, but you have 3 mysterious boxes in your room";
			}
			if (NewInputField.GetComponent<InputField>().text == "32")
			{
				AnomalyDescriptionText.text = "Anomaly 32:\r\n Granny moves ultra fast, you have one day and there are no doors, but she is blind for the rest of the game";
			}
			if (NewInputField.GetComponent<InputField>().text == "33")
			{
				AnomalyDescriptionText.text = "Anomaly 33:\r\n Items can't make noises";
			}
			if (NewInputField.GetComponent<InputField>().text == "34")
			{
				AnomalyDescriptionText.text = "Anomaly 34:\r\n If you have an item, you move 30% slower, but if your hands are empty, you move 60% faster";
			}
			if (NewInputField.GetComponent<InputField>().text == "35")
			{
				AnomalyDescriptionText.text = "Anomaly 35:\r\n You have short hands, but you drop items very hard";
			}
			if (NewInputField.GetComponent<InputField>().text == "36")
			{
				AnomalyDescriptionText.text = "Special anomaly 36:\r\n Everything is wrong with this house...";
			}
			if (NewInputField.GetComponent<InputField>().text == "37")
			{
				AnomalyDescriptionText.text = "Anomaly 37:\r\n You have 1 day and if you see Granny, you die, but she is blind";
			}
			if (NewInputField.GetComponent<InputField>().text == "38")
			{
				AnomalyDescriptionText.text = "Anomaly 38:\r\nGranny moves 75% faster, but you slide on floor instead of walking";
			}
			if (NewInputField.GetComponent<InputField>().text == "39")
			{
				AnomalyDescriptionText.text = "Anomaly 39:\r\nWhen you drop items, they randomly change their size";
			}
			if (NewInputField.GetComponent<InputField>().text == "40")
			{
				AnomalyDescriptionText.text = "Anomaly 40:\r\n There are more creacking floors but everytime you step on creacking floor there is a 50% chance that it wouldn't creack";
			}
			if (NewInputField.GetComponent<InputField>().text == "41")
			{
				AnomalyDescriptionText.text = "Anomaly 41:\r\n The house is mirrored";
			}
			if (NewInputField.GetComponent<InputField>().text == "42")
			{
				AnomalyDescriptionText.text = "Anomaly 42:\r\n Gravity is gone and items can make noice everywhere";
			}
			if (NewInputField.GetComponent<InputField>().text == "43")
			{
				AnomalyDescriptionText.text = "Anomaly 43:\r\n Floor creaks in different places";
			}
			if (NewInputField.GetComponent<InputField>().text == "44")
			{
				AnomalyDescriptionText.text = "Anomaly 44:\r\n Your hand's lenght is constantly changing";
			}
			if (NewInputField.GetComponent<InputField>().text == "45")
			{
				AnomalyDescriptionText.text = "Special anomaly 45:\r\n Try to escape from the broken reality";
			}
			if (NewInputField.GetComponent<InputField>().text == "46")
			{
				AnomalyDescriptionText.text = "Anomaly 46:\r\n Your and Granny's field of view is constantly changing";
			}
			if (NewInputField.GetComponent<InputField>().text == "47")
			{
				AnomalyDescriptionText.text = "Anomaly 47:\r\n There are randomly placed dark holes to make you and Granny see less";
			}
			if (NewInputField.GetComponent<InputField>().text == "50")
			{
				AnomalyDescriptionText.text = "Anomaly 50:\r\n Granny moves twice as fast, but you can crawl under tables and railings";
			}
			if (NewInputField.GetComponent<InputField>().text == "9191")
			{
				AnomalyDescriptionText.text = "A secret GABON anomaly (DON'T TRY IF YOUR MOBILE HAS LOW PERFORMANCE)";
			}
			if (NewInputField.GetComponent<InputField>().text == "1405" || NewInputField.GetComponent<InputField>().text == "8841" || NewInputField.GetComponent<InputField>().text == "3991" || NewInputField.GetComponent<InputField>().text == "1793" || NewInputField.GetComponent<InputField>().text == "1000" || NewInputField.GetComponent<InputField>().text == "2134" || NewInputField.GetComponent<InputField>().text == "2025" || NewInputField.GetComponent<InputField>().text == "2202" || NewInputField.GetComponent<InputField>().text == "2311" || NewInputField.GetComponent<InputField>().text == "8228" || NewInputField.GetComponent<InputField>().text == "3103" || NewInputField.GetComponent<InputField>().text == "7102")
			{
				AnomalyDescriptionText.text = "A secret GABON anomaly";
			}
		}
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			return;
		}
		AnomalyPlaceholderText.text = "From 1 to 18";
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "2" || NewInputField.GetComponent<InputField>().text == "8" || NewInputField.GetComponent<InputField>().text == "10" || NewInputField.GetComponent<InputField>().text == "11" || NewInputField.GetComponent<InputField>().text == "12"))
		{
			((Selectable)ExtraEnemyDropdown).interactable = false;
			ExtraEnemyDropdown.value = 1;
		}
		else if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "1" || NewInputField.GetComponent<InputField>().text == "6" || NewInputField.GetComponent<InputField>().text == "9" || NewInputField.GetComponent<InputField>().text == "15" || NewInputField.GetComponent<InputField>().text == "16"))
		{
			((Selectable)ExtraEnemyDropdown).interactable = false;
			ExtraEnemyDropdown.value = 0;
		}
		else
		{
			((Selectable)ExtraEnemyDropdown).interactable = true;
		}
		if (PlayerPrefs.GetInt("AnomalyOnOff") == 1 && (NewInputField.GetComponent<InputField>().text == "" || (NewInputField.GetComponent<InputField>().text != "1" && NewInputField.GetComponent<InputField>().text != "2" && NewInputField.GetComponent<InputField>().text != "3" && NewInputField.GetComponent<InputField>().text != "4" && NewInputField.GetComponent<InputField>().text != "5" && NewInputField.GetComponent<InputField>().text != "6" && NewInputField.GetComponent<InputField>().text != "7" && NewInputField.GetComponent<InputField>().text != "8" && NewInputField.GetComponent<InputField>().text != "9" && NewInputField.GetComponent<InputField>().text != "10" && NewInputField.GetComponent<InputField>().text != "11" && NewInputField.GetComponent<InputField>().text != "12" && NewInputField.GetComponent<InputField>().text != "13" && NewInputField.GetComponent<InputField>().text != "14" && NewInputField.GetComponent<InputField>().text != "15" && NewInputField.GetComponent<InputField>().text != "16" && NewInputField.GetComponent<InputField>().text != "17" && NewInputField.GetComponent<InputField>().text != "18" && NewInputField.GetComponent<InputField>().text != "")))
		{
			AnomalyDescriptionText.text = "You can't play this anomaly";
			ContinueButton.SetActive(false);
			TrainingButton.SetActive(false);
			return;
		}
		ContinueButton.SetActive(true);
		TrainingButton.SetActive(true);
		PlayerPrefs.SetInt("PrimeAnomalyNR", int.Parse(NewInputField.GetComponent<InputField>().text));
		if (NewInputField.GetComponent<InputField>().text == "1")
		{
			AnomalyText = " anomaly 1:\r\nGranny walks 800% faster and the farther you are from Granny, the slower you move, but there are no more creaking floors in the house and there is no evil chair";
		}
		if (NewInputField.GetComponent<InputField>().text == "2")
		{
			AnomalyText = " anomaly 2:\r\nThere is MUCH more fog, but you know how far evil chair is from you";
		}
		if (NewInputField.GetComponent<InputField>().text == "3")
		{
			AnomalyText = " anomaly 3:\r\nAll characters move 25% faster and enemies are twice as small";
		}
		if (NewInputField.GetComponent<InputField>().text == "4")
		{
			AnomalyText = " anomaly 4:\r\nThere are new creaking floors, some doors and nightmare walls are removed (grass and concrete can also creack), but Granny is less smarter";
		}
		if (NewInputField.GetComponent<InputField>().text == "5")
		{
			AnomalyText = " anomaly 5:\r\nYou have a bell in your left hand that rings every 30 seconds, but you have a nightmare crossbow";
		}
		if (NewInputField.GetComponent<InputField>().text == "6")
		{
			AnomalyText = " anomaly 6:\r\nYou can only crawl, but you have a spray, which you can use up to 50 times, there is no evil chair and you need to open only one escape route";
		}
		if (NewInputField.GetComponent<InputField>().text == "7")
		{
			AnomalyText = " anomaly 7:\r\nYou can drop an item only once per minute, but you have long arms";
		}
		if (NewInputField.GetComponent<InputField>().text == "8")
		{
			AnomalyText = " anomaly 8:\r\nFrom time to time, evil chair may become cursed. When cursed, it kills you only when you crouch, but the padlock and trunk are opened";
		}
		if (NewInputField.GetComponent<InputField>().text == "9")
		{
			AnomalyText = " special anomaly 9:\r\nYou need to find 4 red keys to escape through the new door, but there is no evil chair";
		}
		if (NewInputField.GetComponent<InputField>().text == "10")
		{
			AnomalyText = " anomaly 10:\r\nEvil chair loves vases: there are a lot of these in the house and evil chair only goes check these vases";
		}
		if (NewInputField.GetComponent<InputField>().text == "11")
		{
			AnomalyText = " anomaly 11:\r\nEvil chair's clones will fall from the sky every 2 minutes, but the original one moves 50% slower";
		}
		if (NewInputField.GetComponent<InputField>().text == "12")
		{
			AnomalyText = " anomaly 12:\r\nIn 8 minutes evil chair becomes a bomber, but before it hapens you move 25% faster";
		}
		if (NewInputField.GetComponent<InputField>().text == "13")
		{
			AnomalyText = " anomaly 13:\r\nSome areas are blocked and evil chair is imprisoned until you collect the painting 3 times, but numeric padlock and battery lock are opened";
		}
		if (NewInputField.GetComponent<InputField>().text == "14")
		{
			AnomalyText = " anomaly 14:\r\nItems slip out of hands every 10 seconds, but you have an extra day";
		}
		if (NewInputField.GetComponent<InputField>().text == "15")
		{
			AnomalyText = " anomaly 15:\r\nGranny hears nothing and she is always running, but there is no evil chair and you have a nightmare book";
		}
		if (NewInputField.GetComponent<InputField>().text == "16")
		{
			AnomalyText = " anomaly 16:\r\nGranny hears almost everything, but she has a very poor vision and there is no evil chair";
		}
		if (NewInputField.GetComponent<InputField>().text == "17")
		{
			AnomalyText = " anomaly 17:\r\nBeartraps in the house are replaced by the giant ones, but you have a nightmare remote control";
		}
		if (NewInputField.GetComponent<InputField>().text == "18")
		{
			AnomalyText = " special anomaly 18:\r\nYou have returned to 1.7 and almost everything went right...";
		}
		if (PlayerPrefs.GetInt("NerfedPrimeOnOff") == 1 && NewInputField.GetComponent<InputField>().text != "1" && NewInputField.GetComponent<InputField>().text != "6" && NewInputField.GetComponent<InputField>().text != "9" && NewInputField.GetComponent<InputField>().text != "15" && NewInputField.GetComponent<InputField>().text != "16")
		{
			AnomalyDescriptionText.text = "Nerfed prime" + AnomalyText;
		}
		else
		{
			AnomalyDescriptionText.text = "Prime" + AnomalyText;
		}
	}
}
