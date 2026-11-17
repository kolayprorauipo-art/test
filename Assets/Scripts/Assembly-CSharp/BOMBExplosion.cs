using UnityEngine;

public class BOMBExplosion : MonoBehaviour
{
	public GameObject explosion;

	public Texture BOMB;

	private float timer;

	public void Start()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.mainTexture = BOMB;
		((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.white;
	}

	public void Update()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		timer += Time.deltaTime;
		((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = new Color(1f, 1f - timer / 30f, 1f - timer / 30f);
		if (timer >= 30f)
		{
			explosion.SetActive(true);
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).enabled = false;
		}
	}
}
