using UnityEngine;
using UnityEngine.UI;

public class UIOpacitySlider : MonoBehaviour
{
	public Text UIOpacity;

	public Image UIOpacityExample;

	private void Start()
	{
		((Component)this).gameObject.GetComponent<Slider>().value = PlayerPrefs.GetFloat("UIOpacity");
	}

	private void Update()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		PlayerPrefs.SetFloat("UIOpacity", ((Component)this).gameObject.GetComponent<Slider>().value);
		UIOpacity.text = "UI opacity: " + ((Component)this).gameObject.GetComponent<Slider>().value + "%";
		((Graphic)UIOpacityExample).color = new Color(1f, 1f, 1f, ((Component)this).gameObject.GetComponent<Slider>().value * 0.01f);
	}
}
