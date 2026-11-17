using System;
using UnityEngine;

public class PrefabLightmapData : MonoBehaviour
{
	[Serializable]
	private struct RendererInfo
	{
		public Renderer renderer;

		public int lightmapIndex;

		public Vector4 lightmapOffsetScale;
	}

	[SerializeField]
	private RendererInfo[] m_RendererInfo;

	[SerializeField]
	private Texture2D[] m_Lightmaps;

	private void Awake()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		if (m_RendererInfo != null && m_RendererInfo.Length != 0)
		{
			LightmapData[] lightmaps = LightmapSettings.lightmaps;
			LightmapData[] array = new LightmapData[lightmaps.Length + m_Lightmaps.Length];
			lightmaps.CopyTo(array, 0);
			for (int i = 0; i < m_Lightmaps.Length; i++)
			{
				array[i + lightmaps.Length] = new LightmapData();
				array[i + lightmaps.Length].lightmapColor = m_Lightmaps[i];
			}
			ApplyRendererInfo(m_RendererInfo, lightmaps.Length);
			LightmapSettings.lightmaps = array;
		}
	}

	private static void ApplyRendererInfo(RendererInfo[] infos, int lightmapOffsetIndex)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < infos.Length; i++)
		{
			RendererInfo rendererInfo = infos[i];
			rendererInfo.renderer.lightmapIndex = rendererInfo.lightmapIndex + lightmapOffsetIndex;
			rendererInfo.renderer.lightmapScaleOffset = rendererInfo.lightmapOffsetScale;
		}
	}
}
