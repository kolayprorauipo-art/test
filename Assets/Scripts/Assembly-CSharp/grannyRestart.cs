using System;
using UnityEngine;

[Serializable]
public class grannyRestart : MonoBehaviour
{
	public GameObject Granny;

	public GameObject GrannyBody;

	public GameObject GrannyEyeLock;

	public Transform GrannyStartPos1;

	public Transform GrannyStartPos2;

	public Transform GrannyStartPos3;

	public Transform GrannyStartPos4;

	public float timerCount;

	public bool startTimer;

	public bool startTimer2;

	public float RandomNR;

	public bool playerFallDead;

	public virtual void setTime()
	{
		if (PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			timerCount = 0f;
			return;
		}
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			timerCount = 90f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			timerCount = 30f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			timerCount = 150f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			timerCount = 0f;
		}
	}

	public virtual void setTime2()
	{
		if (PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			timerCount = 15f;
			return;
		}
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			timerCount = 180f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 0)
		{
			timerCount = 60f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 1)
		{
			timerCount = 120f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			timerCount = 30f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			timerCount = 15f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			timerCount = 0f;
		}
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			timerCount = 0f;
		}
	}

	public virtual void Update()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_120b: Unknown result type (might be due to invalid IL or missing references)
		//IL_122f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Unknown result type (might be due to invalid IL or missing references)
		//IL_1165: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_138f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1281: Unknown result type (might be due to invalid IL or missing references)
		//IL_118b: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_1524: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590: Unknown result type (might be due to invalid IL or missing references)
		//IL_15b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Unknown result type (might be due to invalid IL or missing references)
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1458: Unknown result type (might be due to invalid IL or missing references)
		//IL_164d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		if (startTimer)
		{
			timerCount -= Time.deltaTime;
			if (timerCount < 0f || playerFallDead)
			{
				startTimer = false;
				Granny.SetActive(false);
				RandomNR = Random.Range(0, 10);
				if (RandomNR == 0f)
				{
					Granny.transform.position = new Vector3(6.62f, 1.55f, -3.56f);
					if (-10.15f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 9.36f && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 6.84f && -9.09f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 10.25f && GameObject.Find("ReverseButton").GetComponent<reverseCar>().RemoteSpawned)
					{
						Granny.transform.position = GrannyStartPos1.position;
					}
				}
				if (RandomNR == 1f)
				{
					Granny.transform.position = GrannyStartPos1.position;
					if (-10.15f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 9.36f && 6.84f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 12.3f && -9.09f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 10.25f)
					{
						Granny.transform.position = new Vector3(6.62f, 1.55f, -3.56f);
					}
				}
				if (RandomNR == 2f)
				{
					Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
					if (5.01f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 19.31f && 13.46f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 17.76f && -1.56f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
					{
						Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
					}
				}
				if (RandomNR == 3f)
				{
					Granny.transform.position = GrannyStartPos3.position;
					if (-22.13f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 2f && 13.46f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 17.76f && -13.207f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
					{
						Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
					}
				}
				if (RandomNR == 4f)
				{
					Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
					if (5.165f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 35.6f && 11.68f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && -27.3f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < -1.56f)
					{
						Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
					}
				}
				if (RandomNR == 5f)
				{
					Granny.transform.position = new Vector3(16.74f, 20.1641f, 8.14f);
					if (5.01f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 19.31f && 19.89f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 21.651f && -12.26f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
					{
						Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
					}
				}
				if (RandomNR == 6f)
				{
					Granny.transform.position = GrannyStartPos2.position;
					if (-30.88f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < -7.911f && 19.22f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 21.308f && -14.2f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
					{
						Granny.transform.position = new Vector3(1.52f, 26.88f, 12.18f);
					}
				}
				if (RandomNR == 7f)
				{
					Granny.transform.position = new Vector3(1.52f, 26.88f, 12.18f);
					if (21.651f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 32.86f)
					{
						Granny.transform.position = GrannyStartPos2.position;
					}
				}
				if (RandomNR == 8f)
				{
					Granny.transform.position = new Vector3(6.82f, 7.314f, -30.23f);
					if (-27.45f > ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z)
					{
						Granny.transform.position = GrannyStartPos4.position;
					}
				}
				if (RandomNR == 9f)
				{
					Granny.transform.position = GrannyStartPos4.position;
					if (-8.64f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 5.93f && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 18.59f && -27.45f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < -13.207f)
					{
						Granny.transform.position = new Vector3(6.82f, 7.314f, -30.23f);
					}
				}
				Granny.SetActive(true);
				GrannyBody.SetActive(true);
				playerFallDead = false;
				noArrow();
			}
		}
		if (!startTimer2)
		{
			return;
		}
		timerCount -= Time.deltaTime;
		if (!(timerCount < 0f) && !playerFallDead)
		{
			return;
		}
		startTimer2 = false;
		Granny.SetActive(false);
		RandomNR = Random.Range(0, 10);
		if (((Component)this).gameObject.GetComponent<startNewDay>().AnomalyNR == 18 || (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("PrimeOn") == 1 && ((Component)this).gameObject.GetComponent<startNewDay>().PrimeAnomalyNR != 15))
		{
			RandomNR = 1f;
		}
		if (RandomNR == 0f)
		{
			Granny.transform.position = new Vector3(6.62f, 1.55f, -3.56f);
			if (-10.15f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 9.36f && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 6.84f && -9.09f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 10.25f)
			{
				Granny.transform.position = GrannyStartPos1.position;
			}
		}
		if (RandomNR == 1f)
		{
			Granny.transform.position = GrannyStartPos1.position;
			if (-10.15f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 9.36f && 6.84f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 12.3f && -9.09f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 10.25f)
			{
				Granny.transform.position = new Vector3(6.62f, 1.55f, -3.56f);
				if (((Component)this).gameObject.GetComponent<startNewDay>().AnomalyNR == 18)
				{
					Granny.transform.position = GrannyStartPos3.position;
				}
			}
		}
		if (RandomNR == 2f)
		{
			Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
			if (5.01f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 19.31f && 13.46f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 17.76f && -1.56f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
			{
				Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
			}
		}
		if (RandomNR == 3f)
		{
			Granny.transform.position = GrannyStartPos3.position;
			if (-22.13f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 2f && 13.46f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 17.76f && -13.207f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
			{
				Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
			}
		}
		if (RandomNR == 4f)
		{
			Granny.transform.position = new Vector3(25.17f, 11.73f, -6.186f);
			if (5.165f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 35.6f && 11.68f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && -27.3f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < -1.56f)
			{
				Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
			}
		}
		if (RandomNR == 5f)
		{
			Granny.transform.position = new Vector3(16.74f, 20.1641f, 8.14f);
			if (5.01f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 19.31f && 19.89f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 21.651f && -12.26f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
			{
				Granny.transform.position = new Vector3(14.89f, 13.3451f, 3.46f);
			}
		}
		if (RandomNR == 6f)
		{
			Granny.transform.position = GrannyStartPos2.position;
			if (-30.88f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < -7.911f && 19.22f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 21.308f && -14.2f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < 14.72f)
			{
				Granny.transform.position = new Vector3(1.52f, 26.88f, 12.18f);
			}
		}
		if (RandomNR == 7f)
		{
			Granny.transform.position = new Vector3(1.52f, 26.88f, 12.18f);
			if (21.651f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 32.86f)
			{
				Granny.transform.position = GrannyStartPos2.position;
			}
		}
		if (RandomNR == 8f)
		{
			Granny.transform.position = new Vector3(6.82f, 7.314f, -30.23f);
			if (-27.45f > ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z)
			{
				Granny.transform.position = GrannyStartPos4.position;
			}
		}
		if (RandomNR == 9f)
		{
			Granny.transform.position = GrannyStartPos4.position;
			if (-8.64f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.x < 5.93f && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.y < 18.59f && -27.45f < ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z && ((Component)this).gameObject.GetComponent<startNewDay>().Player.transform.position.z < -13.207f)
			{
				Granny.transform.position = new Vector3(6.82f, 7.314f, -30.23f);
			}
		}
		Granny.SetActive(true);
		GrannyBody.SetActive(true);
		playerFallDead = false;
		noArrow();
	}

	public virtual void noArrow()
	{
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByCar = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).freeze = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyStandBesideCar = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuKilled = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).ragdollSpawn = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyInBastu = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimer = 15f;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuDoorTimer = 20f;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).bastuTimeOff = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).huntPlayer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyIsFollow = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepperStart = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyPepperReact = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).waypointStop = true;
		GrannyEyeLock.SetActive(false);
		if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		}
		else if (!((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).navComponent.speed = ((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannysVarSpeed;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).animationHolder.GetComponent<Animation>()["Walk"].speed = ((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannysAnimSpeed;
		}
		else
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
		}
	}
}
