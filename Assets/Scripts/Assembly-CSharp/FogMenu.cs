using UnityEngine;

public class FogMenu : MonoBehaviour
{
	public GameObject MoreSpiderWebs;

	private Color Madness05Fog;

	private void Start()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		Madness05Fog = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
	}

	private void Update()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("UltraFlashlight") == 1)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = Madness05Fog;
			RenderSettings.skybox.color = Madness05Fog;
			RenderSettings.fogStartDistance = 2f;
			RenderSettings.fogEndDistance = 3.86f;
			return;
		}
		if (PlayerPrefs.GetInt("fogOnExtreme") == 1 || PlayerPrefs.GetInt("fogOnOff") == 1)
		{
			RenderSettings.fog = true;
			if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("NightMareOnOff") == 0)
			{
				RenderSettings.fogColor = Color.white;
				RenderSettings.skybox.color = Color.white;
				RenderSettings.fogStartDistance = 7.2f;
				RenderSettings.fogEndDistance = 13.91f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 7 && PlayerPrefs.GetInt("NightMareOnOff") == 1)
			{
				RenderSettings.fogColor = Color.red;
				RenderSettings.skybox.color = Color.red;
				RenderSettings.fogStartDistance = 7.2f;
				RenderSettings.fogEndDistance = 13.91f;
			}
			else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
			{
				RenderSettings.fog = true;
				RenderSettings.fogColor = Color.black;
				RenderSettings.fogStartDistance = 5f;
				RenderSettings.fogEndDistance = 10f;
			}
			else if (PlayerPrefs.GetInt("DiffData") != 7)
			{
				RenderSettings.fogColor = Color.black;
				RenderSettings.skybox.color = Color.black;
				RenderSettings.fogStartDistance = 7.2f;
				RenderSettings.fogEndDistance = 13.91f;
			}
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = Color.black;
			RenderSettings.fogStartDistance = 5f;
			RenderSettings.fogEndDistance = 10f;
		}
		else
		{
			RenderSettings.fog = false;
		}
		if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			MoreSpiderWebs.SetActive(true);
		}
		else
		{
			MoreSpiderWebs.SetActive(false);
		}
	}
}
