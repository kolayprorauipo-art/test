using System;
using System.IO;
using UnityEngine;

public class GlobalSaveManager : MonoBehaviour
{
	[Serializable]
	public class SaveData
	{
		public float TimePlayed;

		public int NerfedPrimeBest;

		public int PrimeBest;

		public int PrimePlusBest;

		public int NerfedPrimeAtts;

		public int PrimeAtts;

		public int PrimePlusAtts;

		public int GrannyGauntlet;
	}

	public static GlobalSaveManager InstanceSaveData;

	private string savePath;

	public float Timer;

	public SaveData data = new SaveData();

	private void Awake()
	{
		if ((Object)(object)InstanceSaveData == (Object)null)
		{
			InstanceSaveData = this;
			Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
			savePath = Path.Combine(Application.persistentDataPath, "SaveData.dat");
			LoadData();
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	private void Update()
	{
		Timer += Time.deltaTime;
		if (Timer >= 30f)
		{
			InstanceSaveData.SaveAllData("TimePlayed", 0);
			Timer = 0f;
		}
	}

	public void SaveAllData(string DataName, int value)
	{
		switch (DataName)
		{
		case "TimePlayed":
			data.TimePlayed += Timer;
			break;
		case "NerfedPrimeBest":
			if (data.NerfedPrimeBest < value)
			{
				data.NerfedPrimeBest = value;
			}
			break;
		case "PrimeBest":
			if (data.PrimeBest < value)
			{
				data.PrimeBest = value;
			}
			break;
		case "PrimePlusBest":
			if (data.PrimePlusBest < value)
			{
				data.PrimePlusBest = value;
			}
			break;
		case "NerfedPrimeAtts":
			data.NerfedPrimeAtts++;
			break;
		case "PrimeAtts":
			data.PrimeAtts++;
			break;
		case "PrimePlusAtts":
			data.PrimePlusAtts++;
			break;
		case "GrannyGauntlet":
			switch (value)
			{
			case 1:
				data.GrannyGauntlet++;
				if (data.GrannyGauntlet == 3)
				{
					AchievementSaveManager.Instance.UnlockAchievement("AnomalyGauntlet");
				}
				break;
			case 0:
				data.GrannyGauntlet = 0;
				break;
			}
			break;
		}
		SaveDataInFile();
	}

	public void SaveDataInFile()
	{
		string text = JsonUtility.ToJson((object)data, true);
		text = Encrypt(text);
		File.WriteAllText(savePath, text);
	}

	public void LoadData()
	{
		if (File.Exists(savePath))
		{
			string text = File.ReadAllText(savePath);
			text = Encrypt(text);
			data = JsonUtility.FromJson<SaveData>(text);
		}
		else
		{
			SaveDataInFile();
		}
	}

	private string Encrypt(string text)
	{
		string text2 = "GrannyHorrorGameKey";
		char[] array = new char[text.Length];
		for (int i = 0; i < text.Length; i++)
		{
			array[i] = (char)(text[i] ^ text2[i % text2.Length]);
		}
		return new string(array);
	}
}
