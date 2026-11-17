using UnityEngine;

public class ActivateGrayLaser : MonoBehaviour
{
	public GameObject GrayLaser;

	public bool LaserStarted;

	public virtual void Start()
	{
		LaserStarted = false;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !LaserStarted)
		{
			((MonoBehaviour)this).StartCoroutine(GrayLaser.GetComponent<LaserBeamGray>().ZeroDistance());
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.white;
			LaserStarted = true;
		}
	}

	public virtual void LaserReset()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = new Color(1f, 0.5f, 0f);
		LaserStarted = false;
	}
}
