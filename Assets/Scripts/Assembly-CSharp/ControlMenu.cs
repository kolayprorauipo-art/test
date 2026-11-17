using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public class ControlMenu : MonoBehaviour
{
	public Texture2D background;

	public bool display;

	public Font font;

	public ControllerScene[] controllers;

	public Transform[] destroyOnLoad;

	public GameObject launchIntro;

	public GameObject orbEmitter;

	private int selection;

	private bool displayBackground;

	public ControlMenu()
	{
		selection = -1;
	}

	public virtual void Start()
	{
		launchIntro.SetActive(false);
		orbEmitter.GetComponent<Renderer>().enabled = false;
	}

	public virtual void Update()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (!display && selection == -1 && Input.touchCount > 0)
		{
			for (int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				_ = touch.phase;
			}
		}
	}

	public virtual void OnGUI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		GUI.skin.font = font;
		if (displayBackground)
		{
			GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), (Texture)(object)background, (ScaleMode)0, false);
		}
		if (!display)
		{
			return;
		}
		int num = -1;
		int num2 = 60;
		int num3 = 400;
		GUILayout.BeginArea(new Rect((float)((Screen.width - num3) / 2), (float)((Screen.height - num2) / 2), (float)num3, (float)num2));
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		for (int i = 0; i < controllers.Length; i++)
		{
			if (GUILayout.Button(controllers[i].label, new GUILayoutOption[1] { GUILayout.MinHeight((float)num2) }))
			{
				num = i;
			}
		}
		if (num >= 0)
		{
			selection = num;
			((Behaviour)((Component)this).GetComponent<Image>()).enabled = false;
			display = false;
			displayBackground = false;
			((MonoBehaviour)this).StartCoroutine(ChangeControls());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}

	public virtual IEnumerator WaitUntilObjectDestroyed(object o)
	{
		while (o != null)
		{
			yield return (object)new WaitForFixedUpdate();
		}
	}

	public virtual IEnumerator ChangeControls()
	{
		Transform[] array = destroyOnLoad;
		for (int i = 0; i < array.Length; i++)
		{
			Object.Destroy((Object)(object)((Component)array[i]).gameObject);
		}
		launchIntro.SetActive(true);
		yield return ((MonoBehaviour)this).StartCoroutine(WaitUntilObjectDestroyed(launchIntro));
		displayBackground = true;
		orbEmitter.GetComponent<Renderer>().enabled = true;
		SceneManager.LoadScene(controllers[selection].controlScene);
		Object.Destroy((Object)(object)((Component)this).gameObject, 1f);
	}
}
