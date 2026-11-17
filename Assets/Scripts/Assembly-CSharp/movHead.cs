using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class movHead : MonoBehaviour
{
	public Sprite headR;

	public Sprite headL;

	public Image head;

	private bool headMove;

	public void OnEnable()
	{
		((MonoBehaviour)this).StartCoroutine(StartMove());
	}

	public IEnumerator StartMove()
	{
		((Component)head).GetComponent<Image>().sprite = headR;
		yield return (object)new WaitForSeconds(10f);
		((Component)head).GetComponent<Image>().sprite = headL;
		yield return (object)new WaitForSeconds(10f);
		((Component)head).GetComponent<Image>().sprite = headR;
		headMove = true;
	}

	public void Update()
	{
		if (headMove)
		{
			headMove = false;
			((MonoBehaviour)this).StartCoroutine(moveHead());
		}
	}

	public IEnumerator moveHead()
	{
		yield return (object)new WaitForSeconds(10f);
		((Component)head).GetComponent<Image>().sprite = headL;
		yield return (object)new WaitForSeconds(10f);
		((Component)head).GetComponent<Image>().sprite = headR;
		headMove = true;
	}
}
