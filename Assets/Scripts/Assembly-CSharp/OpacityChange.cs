using UnityEngine;
using UnityEngine.UI;

public class OpacityChange : MonoBehaviour
{
	private Image image;

	private void Start()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		image = ((Component)this).gameObject.GetComponent<Image>();
		((Graphic)image).color = new Color(1f, 1f, 1f, PlayerPrefs.GetFloat("UIOpacity") * 0.01f);
	}

	private void Update()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		((Graphic)image).color = new Color(1f, 1f, 1f, PlayerPrefs.GetFloat("UIOpacity") * 0.01f);
	}
}
