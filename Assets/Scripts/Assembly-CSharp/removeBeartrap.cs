using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class removeBeartrap : MonoBehaviour
{
	public int layerMask;

	public Image removeBar;

	public bool PressButton;

	public GameObject rayHolder;

	public bool seeTrap;

	public bool playerTaken;

	public removeBeartrap()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		removeBar.fillAmount = 0f;
	}

	public virtual void Update()
	{
		if (Input.GetKey((KeyCode)102))
		{
			if (!playerTaken)
			{
				if (seeTrap)
				{
					PressButton = true;
					((seeBearTrap)(object)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = true;
				}
				else
				{
					removeBar.fillAmount = 0f;
					((seeBearTrap)(object)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = false;
				}
			}
		}
		else
		{
			PressButton = false;
			((seeBearTrap)(object)rayHolder.GetComponent(typeof(seeBearTrap))).destroyTrap = false;
		}
		if (!PressButton)
		{
			Image val = removeBar;
			val.fillAmount -= 1f * Time.deltaTime;
		}
		if (!seeTrap)
		{
			removeBar.fillAmount = 0f;
		}
	}
}
