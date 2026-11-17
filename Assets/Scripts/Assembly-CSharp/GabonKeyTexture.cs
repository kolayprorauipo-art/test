using UnityEngine;

public class GabonKeyTexture : MonoBehaviour
{
	public Texture GabonKeyTexure;

	private void Start()
	{
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.mainTexture = GabonKeyTexure;
		}
	}
}
