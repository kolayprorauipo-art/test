using UnityEngine;

public class ChangeNightmareTextureMainMenu : MonoBehaviour
{
	private Renderer rend;

	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	public Texture2D melonTexture;

	public Shader AbondonedShader;

	public Shader DefaultShader;

	public Color DefaultColor;

	public Color AbandonedColor;

	private void Start()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		rend = ((Component)this).GetComponent<Renderer>();
		DefaultShader = rend.material.shader;
		DefaultColor = rend.material.color;
		AbandonedColor = new Color(0.75f, 0.6f, 0.3f);
	}

	private void Update()
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (((Object)((Component)this).gameObject).name == "Granny" && PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 1)
		{
			rend.material.mainTexture = (Texture)(object)melonTexture;
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			rend.material.mainTexture = (Texture)(object)nightmareTexture;
			if (((Object)((Component)this).gameObject).name != "Granny")
			{
				rend.material.shader = DefaultShader;
				rend.material.color = DefaultColor;
			}
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 2)
		{
			rend.material.mainTexture = (Texture)(object)normalTexture;
			if (((Object)((Component)this).gameObject).name != "Granny")
			{
				rend.material.color = AbandonedColor;
			}
		}
		else
		{
			rend.material.mainTexture = (Texture)(object)normalTexture;
			if (((Object)((Component)this).gameObject).name != "Granny")
			{
				rend.material.shader = DefaultShader;
				rend.material.color = DefaultColor;
			}
		}
	}
}
