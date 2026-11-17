using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CountBooks : MonoBehaviour
{
	public int books;

	public Text bookText;

	public bool findAllBooks;

	public GameObject allaBooksSkylt;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		bookText.text = books + " / 8";
		if (books == 8 && !findAllBooks)
		{
			findAllBooks = true;
			allaBooksSkylt.SetActive(true);
			((TextInactivate)(object)allaBooksSkylt.GetComponent(typeof(TextInactivate))).travelDown = true;
		}
	}

	public virtual void countUpBooks()
	{
		books++;
	}
}
