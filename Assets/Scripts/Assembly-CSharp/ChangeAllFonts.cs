using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAllFonts : MonoBehaviour
{
	public Font font2;

	private float optimizationTimer;

	private IEnumerator Start()
	{
		while (optimizationTimer < 60f)
		{
			ChangeFonts();
			optimizationTimer += 0.5f;
			yield return (object)new WaitForSeconds(0.5f);
		}
	}

	public void ChangeFonts()
	{
		Text[] array = Object.FindObjectsOfType<Text>(true);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].font = font2;
		}
	}
}
