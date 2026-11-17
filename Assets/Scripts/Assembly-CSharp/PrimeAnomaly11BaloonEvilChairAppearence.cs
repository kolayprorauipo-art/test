using UnityEngine;

public class PrimeAnomaly11BaloonEvilChairAppearence : MonoBehaviour
{
	public GameObject BaloonEvilChair;

	private float yPos;

	private void Start()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		yPos = ((Component)this).gameObject.transform.position.y;
	}

	public void OnTriggerEnter(Collider other)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "grus")
		{
			GameObject val = Object.Instantiate<GameObject>(BaloonEvilChair, new Vector3(((Component)this).gameObject.transform.position.x, 11.84f, ((Component)this).gameObject.transform.position.z), ((Component)this).gameObject.transform.rotation);
			val.GetComponent<ratController>().Anomaly11 = true;
			val.GetComponent<ratController>().BalloonColor = ((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color;
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		else
		{
			((Component)this).gameObject.transform.position = new Vector3(Random.Range(7.15f, 33.59f), yPos, Random.Range(-26.3f, -13.83f));
		}
	}
}
