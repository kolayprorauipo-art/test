using System;
using UnityEngine;

[Serializable]
public class fadeUpDownTeddyMusic : MonoBehaviour
{
	public bool playerCaught;

	public bool startFade;

	public bool musicOn;

	public bool startMusic;

	public bool stopMusic;

	public float volume;

	public GameObject gameController;

	public virtual void Start()
	{
		gameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		if (!playerCaught)
		{
			if (startFade)
			{
				if (!musicOn)
				{
					((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
					if (((Component)this).GetComponent<AudioSource>().volume >= 0.7f)
					{
						musicOn = true;
						((Component)this).GetComponent<AudioSource>().volume = 0.7f;
						if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1)
						{
							((MonoBehaviour)this).StartCoroutine(((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).FadeTimerText(1f, 0f, 1.5f, 0f));
						}
					}
				}
				if (!startMusic)
				{
					startMusic = true;
					((Component)this).GetComponent<AudioSource>().Play();
				}
			}
			else
			{
				if (startFade)
				{
					return;
				}
				musicOn = false;
				startMusic = false;
				((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
				if (((Component)this).GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					((Component)this).GetComponent<AudioSource>().volume = 0f;
					((Component)this).GetComponent<AudioSource>().Stop();
					if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1)
					{
						((MonoBehaviour)this).StartCoroutine(((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).FadeTimerText(0f, 1f, 1.5f, 0f));
					}
				}
			}
			return;
		}
		musicOn = false;
		startMusic = false;
		((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
		if (((Component)this).GetComponent<AudioSource>().volume == 0f)
		{
			startFade = false;
			((Component)this).GetComponent<AudioSource>().volume = 0f;
			((Component)this).GetComponent<AudioSource>().Stop();
			playerCaught = false;
			if (PlayerPrefs.GetInt("ShowTimerOnOff") == 1)
			{
				((MonoBehaviour)this).StartCoroutine(((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).FadeTimerText(0f, 1f, 0.1f, 0f));
			}
		}
	}
}
