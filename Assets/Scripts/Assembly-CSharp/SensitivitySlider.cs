using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SensitivitySlider : MonoBehaviour
{
	public float hSliderValue;

	public GUIStyle style;

	public GUIStyle style1;

	private Rect defaultRect;

	private Image gui;

	public saveSensitivityData scriptC;

	public GameObject savedValue;

	public virtual void Start()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_ = (saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData));
		if (PlayerPrefs.GetInt("slideData") == 0)
		{
			PlayerPrefs.SetInt("slideData", 10);
			hSliderValue = 10f;
		}
		else
		{
			hSliderValue = PlayerPrefs.GetInt("slideData");
		}
	}

	public virtual void Update()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((saveSensitivityData)savedValue.GetComponent(typeof(saveSensitivityData))).sliderValue = hSliderValue;
	}

	public virtual void OnGUI()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		int width = Screen.width;
		int height = Screen.height;
		GUI.skin.horizontalSlider = style;
		GUI.skin.horizontalSliderThumb = style1;
		hSliderValue = GUI.HorizontalSlider(new Rect((float)(width / 2) * 0.69f, (float)(height / 2), (float)(width / 2) * 0.60732985f, (float)(height / 2) * (17f / 166f)), hSliderValue, 0.1f, 25f);
		GUI.skin.horizontalSliderThumb.fixedWidth = (float)(width / 2) * 0.06f;
	}
}
