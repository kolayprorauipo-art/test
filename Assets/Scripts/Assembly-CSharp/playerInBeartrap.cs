using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerInBeartrap : MonoBehaviour
{
	public Image bloodScreen;

	public Image bloodScreenHit;

	public Image bloodScreenBiten;

	public GameObject bloodScreenTexture;

	public GameObject bloodScreenHitTexture;

	public GameObject bloodScreenBitenTexture;

	public bool bloodON;

	public bool bloodHitON;

	public bool bloodBitenON;

	public virtual void Update()
	{
		if (bloodON)
		{
			((Graphic)bloodScreen).CrossFadeAlpha(0f, 0.8f, false);
			if (((Graphic)bloodScreen).canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodON = false;
				bloodScreenTexture.SetActive(false);
			}
		}
		if (bloodHitON)
		{
			((Graphic)bloodScreenHit).CrossFadeAlpha(0f, 0.8f, false);
			if (((Graphic)bloodScreenHit).canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodHitON = false;
				bloodScreenHitTexture.SetActive(false);
			}
		}
		if (bloodBitenON)
		{
			((Graphic)bloodScreenBiten).CrossFadeAlpha(0f, 0.8f, false);
			if (((Graphic)bloodScreenBiten).canvasRenderer.GetAlpha() < 0.1f)
			{
				bloodBitenON = false;
				bloodScreenBitenTexture.SetActive(false);
			}
		}
	}

	public virtual void playerStuck()
	{
		((MonoBehaviour)this).StartCoroutine(stuckTimer());
		((Graphic)bloodScreen).canvasRenderer.SetAlpha(1f);
	}

	public virtual void playerHit()
	{
		((MonoBehaviour)this).StartCoroutine(hitTimer());
		((Graphic)bloodScreenHit).canvasRenderer.SetAlpha(1f);
	}

	public virtual void playerBiten()
	{
		((MonoBehaviour)this).StartCoroutine(bitenTimer());
		((Graphic)bloodScreenBiten).canvasRenderer.SetAlpha(1f);
	}

	public virtual IEnumerator stuckTimer()
	{
		bloodScreenTexture.SetActive(true);
		yield return (object)new WaitForSeconds(3f);
		bloodON = true;
	}

	public virtual IEnumerator hitTimer()
	{
		yield return (object)new WaitForSeconds(0.8f);
		bloodScreenHitTexture.SetActive(true);
		yield return (object)new WaitForSeconds(3f);
		bloodHitON = true;
	}

	public virtual IEnumerator bitenTimer()
	{
		bloodScreenBitenTexture.SetActive(true);
		yield return (object)new WaitForSeconds(3f);
		bloodBitenON = true;
	}
}
