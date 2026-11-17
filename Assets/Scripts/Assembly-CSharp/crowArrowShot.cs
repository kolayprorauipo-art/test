using UnityEngine;

public class crowArrowShot : MonoBehaviour
{
	public GameObject crow;

	public float AnomalyTimer = 90f;

	public bool DiedByAnomaly;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "arrow")
		{
			((CrowControl)(object)crow.GetComponent(typeof(CrowControl))).shootInBur = true;
		}
	}
}
