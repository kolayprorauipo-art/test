using System;
using UnityEngine;

[Serializable]
public class stopMusik : MonoBehaviour
{
	public bool musicOnOff;

	public stopMusik()
	{
		musicOnOff = true;
	}

	public virtual void Start()
	{
		if (PlayerPrefs.GetInt("musikOnOff") == 0)
		{
			((Component)this).GetComponent<AudioSource>().Play();
		}
		else
		{
			((Component)this).GetComponent<AudioSource>().Stop();
		}
	}

	public virtual void Update()
	{
	}

	public virtual void turnOn()
	{
		musicOnOff = true;
		PlayerPrefs.SetInt("musikOnOff", 0);
		((Component)this).GetComponent<AudioSource>().Play();
	}

	public virtual void turnOff()
	{
		musicOnOff = false;
		PlayerPrefs.SetInt("musikOnOff", 1);
		((Component)this).GetComponent<AudioSource>().Stop();
	}
}
