using UnityEngine;

public class melonGrannyRagdollChange : MonoBehaviour
{
	public Texture MelonTexture;

	public GameObject Melon1;

	public GameObject Melon2;

	public GameObject Granny;

	public GameObject Granny2;

	public GameObject Granny3;

	public GameObject Granny4;

	public bool frozen;

	public Color FreezeColor;

	private void Start()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 1)
		{
			if (!frozen)
			{
				((Behaviour)Granny.GetComponent<changeTextureNightmare>()).enabled = false;
				((Renderer)Granny.GetComponent<SkinnedMeshRenderer>()).material.mainTexture = MelonTexture;
				Melon1.SetActive(true);
				Melon2.SetActive(true);
				return;
			}
			((Renderer)Granny.GetComponent<MeshRenderer>()).material.mainTexture = MelonTexture;
			((Renderer)Granny.GetComponent<MeshRenderer>()).material.color = FreezeColor;
			((Renderer)Granny2.GetComponent<MeshRenderer>()).material.mainTexture = MelonTexture;
			((Renderer)Granny2.GetComponent<MeshRenderer>()).material.color = FreezeColor;
			((Renderer)Granny3.GetComponent<MeshRenderer>()).material.mainTexture = MelonTexture;
			((Renderer)Granny3.GetComponent<MeshRenderer>()).material.color = FreezeColor;
			((Renderer)Granny4.GetComponent<MeshRenderer>()).material.mainTexture = MelonTexture;
			((Renderer)Granny4.GetComponent<MeshRenderer>()).material.color = FreezeColor;
			Melon1.SetActive(true);
			Melon2.SetActive(true);
		}
	}
}
