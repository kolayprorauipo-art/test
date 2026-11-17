using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class slendrinaAppear : MonoBehaviour
{
	public bool SlendrinaAppear;

	public bool fadeUpDown;

	public float fadeSpeed;

	public GameObject slendrinaTexture;

	public GameObject slendrinaHairTexture;

	public GameObject particleSys;

	public virtual IEnumerator Start()
	{
		SlendrinaAppear = true;
		yield return (object)new WaitForSeconds(5f);
		fadeUpDown = true;
		yield return (object)new WaitForSeconds(4f);
		fadeUpDown = false;
		yield return (object)new WaitForSeconds(5f);
		fadeUpDown = true;
		yield return (object)new WaitForSeconds(3f);
		particleSys.GetComponent<ParticleSystem>().enableEmission = false;
		particleSys.GetComponent<ParticleSystem>().Stop();
		yield return (object)new WaitForSeconds(4f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	public virtual void Update()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		if (SlendrinaAppear)
		{
			if (!fadeUpDown)
			{
				float a = slendrinaTexture.GetComponent<Renderer>().material.color.a + 0.01f * Time.deltaTime * fadeSpeed;
				Color color = slendrinaTexture.GetComponent<Renderer>().material.color;
				color.a = a;
				slendrinaTexture.GetComponent<Renderer>().material.color = color;
				float a2 = slendrinaHairTexture.GetComponent<Renderer>().material.color.a + 0.01f * Time.deltaTime * fadeSpeed;
				Color color2 = slendrinaHairTexture.GetComponent<Renderer>().material.color;
				color2.a = a2;
				slendrinaHairTexture.GetComponent<Renderer>().material.color = color2;
			}
			if (fadeUpDown)
			{
				float a3 = slendrinaTexture.GetComponent<Renderer>().material.color.a - 0.01f * Time.deltaTime * fadeSpeed;
				Color color3 = slendrinaTexture.GetComponent<Renderer>().material.color;
				color3.a = a3;
				slendrinaTexture.GetComponent<Renderer>().material.color = color3;
				float a4 = slendrinaHairTexture.GetComponent<Renderer>().material.color.a - 0.01f * Time.deltaTime * fadeSpeed;
				Color color4 = slendrinaHairTexture.GetComponent<Renderer>().material.color;
				color4.a = a4;
				slendrinaHairTexture.GetComponent<Renderer>().material.color = color4;
			}
		}
	}
}
