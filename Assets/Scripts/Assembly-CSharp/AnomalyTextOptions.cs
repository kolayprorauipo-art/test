using UnityEngine;
using UnityEngine.UI;

public class AnomalyTextOptions : MonoBehaviour
{
	public startNewDay startNewDayScript;

	private void Start()
	{
		((Component)this).GetComponent<Text>().text = startNewDayScript.AnomalyText.GetComponent<Text>().text;
	}
}
