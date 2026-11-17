using UnityEngine;

public class changeTextureNightmare : MonoBehaviour
{
	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	public bool onlyAbondoned;

	public bool Granny;

	public bool EndScene;

	public Color AbandonedColor;

	private void Start()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		AbandonedColor = new Color(0.75f, 0.6f, 0.3f);
		if (onlyAbondoned)
		{
			if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
			{
				((Component)this).GetComponent<Renderer>().material.color = AbandonedColor;
			}
		}
		else if (PlayerPrefs.GetInt("AnomalyNR") == 4542 && ((Component)this).gameObject.tag == "tavelbitar")
		{
			((Component)this).GetComponent<Renderer>().material.mainTexture = (Texture)(object)nightmareTexture;
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && ((Object)((Component)this).gameObject).name != "LitetBordSR3" && ((Object)((Component)this).gameObject).name != "LitetBordVR" && ((Object)((Component)this).gameObject).name != "Tavelram")
		{
			((Component)this).GetComponent<Renderer>().material.mainTexture = (Texture)(object)nightmareTexture;
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1 && (((Object)((Component)this).gameObject).name == "LitetBordSR3" || ((Object)((Component)this).gameObject).name == "LitetBordVR"))
		{
			((Component)this).GetComponent<Renderer>().material.color = new Color(0.3f, 0f, 0f);
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2 && !Granny && !EndScene)
		{
			((Component)this).GetComponent<Renderer>().material.mainTexture = (Texture)(object)normalTexture;
			((Component)this).GetComponent<Renderer>().material.color = AbandonedColor;
		}
		else if (EndScene && !Granny && PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			((Component)this).GetComponent<Renderer>().material.mainTexture = (Texture)(object)normalTexture;
			((Component)this).GetComponent<Renderer>().material.color = AbandonedColor;
		}
		else
		{
			((Component)this).GetComponent<Renderer>().material.mainTexture = (Texture)(object)normalTexture;
		}
	}
}
