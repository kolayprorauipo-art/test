using System;
using UnityEngine;

[Serializable]
public class ClickOptionButton : MonoBehaviour
{
	public GameObject ljudHolder;

	private bool buttonPressed;

	private bool buttonsounds;

	public GameObject OptionsMenu;

	public GameObject MenuButtons;

	public GameObject noAdsButton;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			_ = touch.position;
			((Component)this).transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
			buttonPressed = false;
			buttonsounds = false;
		}
		else if (buttonPressed)
		{
			((Component)this).transform.localPosition = new Vector3(-0.28f, -0.04f, 2f);
			buttonPressed = false;
			OptionsMenu.SetActive(true);
			MenuButtons.SetActive(false);
			if (PlayerPrefs.GetInt("ADSon") == 0)
			{
				noAdsButton.SetActive(true);
			}
		}
	}
}
