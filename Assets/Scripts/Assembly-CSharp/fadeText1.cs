using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class fadeText1 : MonoBehaviour
{
	public Image text;

	public float fadeTextSpeed;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(2f);
		yield return ((MonoBehaviour)this).StartCoroutine(Fade(1f, 0f, 2f));
	}

	public virtual IEnumerator Fade(float startLevel, float endLevel, float duration)
	{
		for (float t = 0f; t < 1f; t += Time.deltaTime * fadeTextSpeed)
		{
			float a = Mathf.Lerp(startLevel, endLevel, t);
			Color color = ((Graphic)text).color;
			color.a = a;
			((Graphic)text).color = color;
			yield return null;
		}
	}
}
