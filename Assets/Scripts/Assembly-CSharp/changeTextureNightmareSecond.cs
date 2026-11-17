using UnityEngine;

public class changeTextureNightmareSecond : MonoBehaviour
{
	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	public Color AbandonedColor;

	private void Start()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		AbandonedColor = new Color(0.75f, 0.6f, 0.3f);
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			((Component)this).GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)nightmareTexture;
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			((Component)this).GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)normalTexture;
			((Component)this).GetComponent<Renderer>().materials[1].color = AbandonedColor;
		}
		else
		{
			((Component)this).GetComponent<Renderer>().materials[1].mainTexture = (Texture)(object)normalTexture;
		}
	}
}
