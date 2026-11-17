using System;
using UnityEngine;

[Serializable]
public class Event3GamblingButton : MonoBehaviour
{
	public float GamblingTimer;

	public GameObject GameController;

	public float GoldenMoment;

	public int GamblingMode;

	public bool oncePerGame;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		oncePerGame = false;
	}

	public virtual void Update()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		GamblingTimer += Time.deltaTime;
		if ((GamblingTimer < 60f && GamblingMode == 1) || (GamblingTimer < 120f && GamblingMode == 2) || (GamblingTimer < 180f && GamblingMode == 3) || (oncePerGame && GamblingMode == 4))
		{
			((Object)((Component)this).gameObject).name = "GamblingButtonUnavailable";
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.red;
		}
		else if (GamblingMode == 1)
		{
			((Object)((Component)this).gameObject).name = "GamblingButton1";
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.green;
		}
		else if (GamblingMode == 2)
		{
			((Object)((Component)this).gameObject).name = "GamblingButton2";
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.cyan;
		}
		else if (GamblingMode == 3)
		{
			((Object)((Component)this).gameObject).name = "GamblingButton3";
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.yellow;
		}
		else if (GamblingMode == 4)
		{
			((Object)((Component)this).gameObject).name = "GamblingButton4";
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.blue;
		}
	}
}
