using UnityEngine;

public class Anomaly47Spheres : MonoBehaviour
{
	public void Start()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).gameObject.transform.position = new Vector3(Random.Range(-18f, 32f), Random.Range(3f, 40f), Random.Range(-39f, 13f));
		((Component)this).gameObject.transform.rotation = Quaternion.Euler(Random.Range(150f, 210f), Random.Range(-180f, 180f), Random.Range(-180f, 180f));
		((Component)this).gameObject.transform.localScale = new Vector3(Random.Range(3f, 12f), Random.Range(3f, 12f), 0.5f);
	}
}
