using System;
using UnityEngine;

[Serializable]
public class fadeUpDownGrannyHunt : MonoBehaviour
{
	public bool playerCaught;

	public bool grannySmackPlayer;

	public bool grannyDead;

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
		if (!playerCaught && gameController.GetComponent<startNewDay>().AnomalyNR != 2525 && PlayerPrefs.GetInt("EventChallenge2") != 1)
		{
			if (grannyDead)
			{
				musicOn = false;
				startMusic = false;
				((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
				if (((Component)this).GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					((Component)this).GetComponent<AudioSource>().volume = 0f;
					((Component)this).GetComponent<AudioSource>().Stop();
					playerCaught = false;
					grannyDead = false;
				}
			}
			else if (startFade)
			{
				if (!musicOn)
				{
					((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume + 0.2f * Time.deltaTime;
					if (((Component)this).GetComponent<AudioSource>().volume >= 0.4f)
					{
						musicOn = true;
						((Component)this).GetComponent<AudioSource>().volume = 0.4f;
					}
				}
				if (!startMusic)
				{
					startMusic = true;
					((Component)this).GetComponent<AudioSource>().Play();
				}
			}
			else if (!startFade)
			{
				musicOn = false;
				startMusic = false;
				((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.1f * Time.deltaTime;
				if (((Component)this).GetComponent<AudioSource>().volume == 0f)
				{
					startFade = false;
					((Component)this).GetComponent<AudioSource>().volume = 0f;
					((Component)this).GetComponent<AudioSource>().Stop();
				}
			}
		}
		else if (!grannySmackPlayer)
		{
			musicOn = false;
			startMusic = false;
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 0.05f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume == 0f)
			{
				startFade = false;
				((Component)this).GetComponent<AudioSource>().volume = 0f;
				((Component)this).GetComponent<AudioSource>().Stop();
				playerCaught = false;
			}
		}
		else
		{
			musicOn = false;
			startMusic = false;
			((Component)this).GetComponent<AudioSource>().volume = ((Component)this).GetComponent<AudioSource>().volume - 1.05f * Time.deltaTime;
			if (((Component)this).GetComponent<AudioSource>().volume == 0f)
			{
				startFade = false;
				((Component)this).GetComponent<AudioSource>().volume = 0f;
				((Component)this).GetComponent<AudioSource>().Stop();
				playerCaught = false;
				grannySmackPlayer = false;
			}
		}
	}
}
