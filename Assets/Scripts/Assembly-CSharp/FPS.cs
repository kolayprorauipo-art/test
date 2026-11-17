using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class FPS : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	public FPS()
	{
		updateInterval = 0.5f;
	}

	public virtual void Start()
	{
		if (!Object.op_Implicit((Object)(object)((Component)this).GetComponent<Text>()))
		{
			MonoBehaviour.print((object)"FramesPerSecond needs a GUIText component!");
			((Behaviour)this).enabled = false;
		}
		else
		{
			timeleft = updateInterval;
		}
	}

	public virtual void Update()
	{
		timeleft -= Time.deltaTime;
		accum += Time.timeScale / Time.deltaTime;
		frames++;
		if (timeleft <= 0f)
		{
			((Component)this).GetComponent<Text>().text = string.Empty + (accum / (float)frames).ToString("f2");
			timeleft = updateInterval;
			accum = 0f;
			frames = 0;
		}
	}
}
