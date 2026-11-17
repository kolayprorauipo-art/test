using System.IO;
using UnityEngine;

public class SixSevenScript : MonoBehaviour
{
	public Texture2D RGBA32Texture;

	public Texture2D RGBA32Texture2;

	public Texture2D RGBA32Texture3;

	public Texture2D RGBA32Texture4;

	public Texture2D RGBA32Texture5;

	public Texture2D RGBA32Texture6;

	public Texture2D RGBA32Texture7;

	public Texture2D RGBA32Texture8;

	private void Start()
	{
		byte[] bytes = ImageConversion.EncodeToEXR(RGBA32Texture, (EXRFlags)2);
		File.WriteAllBytes(Application.dataPath + "/../SavedRenderTexture.exr", bytes);
	}
}
