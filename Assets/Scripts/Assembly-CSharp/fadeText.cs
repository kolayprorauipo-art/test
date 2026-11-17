using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class fadeText : MonoBehaviour
{
	public Image text;

	public float fadeTextSpeed;

	public bool buttonReady;

	public GameObject ljudHolder;

	public GameObject difficultyMenu;

	public GameObject Menu;

	public GameObject helpButton;

	public GameObject quitButton;

	public GameObject moreGamesButton;

	public Sprite buttonEffect;

	public Sprite playButton;

	public bool scriptReady;

	public virtual IEnumerator Start()
	{
		yield return ((MonoBehaviour)this).StartCoroutine(Fade(0f, 1f, 2f));
		buttonReady = true;
		((Component)this).GetComponent<Image>().sprite = buttonEffect;
		helpButton.SetActive(true);
		quitButton.SetActive(true);
		moreGamesButton.SetActive(true);
		yield return (object)new WaitForSeconds(0.05f);
		((Component)this).GetComponent<Image>().sprite = playButton;
	}

	public virtual void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch val = touches[i];
			if (buttonReady)
			{
				_ = val.phase;
				_ = 3;
			}
		}
		if (scriptReady)
		{
			scriptReady = false;
			((MonoBehaviour)this).StartCoroutine(StartFade());
		}
	}

	public virtual IEnumerator StartFade()
	{
		((Component)this).GetComponent<Image>().sprite = playButton;
		yield return ((MonoBehaviour)this).StartCoroutine(Fade(0f, 1f, 2f));
		buttonReady = true;
		((Component)this).GetComponent<Image>().sprite = buttonEffect;
		helpButton.SetActive(true);
		quitButton.SetActive(true);
		moreGamesButton.SetActive(true);
		yield return (object)new WaitForSeconds(0.1f);
		((Component)this).GetComponent<Image>().sprite = playButton;
	}

	public virtual IEnumerator Fade(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 0.5f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)text).color;
			color.a = a;
			((Graphic)text).color = color;
			yield return null;
		}
	}
}
