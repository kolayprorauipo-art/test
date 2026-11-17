using UnityEngine;
using UnityEngine.UI;

public class FPSSliderlimit : MonoBehaviour
{
	private void Start()
	{
		if (PlayerPrefs.GetInt("FPSLimit") == 30)
		{
			((Component)this).gameObject.GetComponent<Slider>().value = 1f;
		}
		else if (PlayerPrefs.GetInt("FPSLimit") == 60)
		{
			((Component)this).gameObject.GetComponent<Slider>().value = 2f;
		}
		else if (PlayerPrefs.GetInt("FPSLimit") == 120)
		{
			((Component)this).gameObject.GetComponent<Slider>().value = 3f;
		}
		else if (PlayerPrefs.GetInt("FPSLimit") == 144)
		{
			((Component)this).gameObject.GetComponent<Slider>().value = 4f;
		}
		else if (PlayerPrefs.GetInt("FPSLimit") == 240)
		{
			((Component)this).gameObject.GetComponent<Slider>().value = 5f;
		}
	}

	private void Update()
	{
		if (((Component)this).gameObject.GetComponent<Slider>().value == 1f)
		{
			PlayerPrefs.SetInt("FPSLimit", 30);
		}
		else if (((Component)this).gameObject.GetComponent<Slider>().value == 2f)
		{
			PlayerPrefs.SetInt("FPSLimit", 60);
		}
		else if (((Component)this).gameObject.GetComponent<Slider>().value == 3f)
		{
			PlayerPrefs.SetInt("FPSLimit", 120);
		}
		else if (((Component)this).gameObject.GetComponent<Slider>().value == 4f)
		{
			PlayerPrefs.SetInt("FPSLimit", 144);
		}
		else if (((Component)this).gameObject.GetComponent<Slider>().value == 5f)
		{
			PlayerPrefs.SetInt("FPSLimit", 240);
		}
	}
}
