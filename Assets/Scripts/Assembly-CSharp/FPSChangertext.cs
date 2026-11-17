using UnityEngine;
using UnityEngine.UI;

public class FPSChangertext : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		((Component)this).gameObject.GetComponent<Text>().text = "FPS limit: " + PlayerPrefs.GetInt("FPSLimit");
	}
}
