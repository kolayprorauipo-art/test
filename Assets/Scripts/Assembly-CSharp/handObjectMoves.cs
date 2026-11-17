using System.Collections;
using UnityEngine;

public class handObjectMoves : MonoBehaviour
{
	private Vector3 vectOffset;

	public GameObject goFollow;

	[SerializeField]
	private float speed = 3f;

	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		vectOffset = ((Component)this).transform.position - goFollow.transform.position;
		((MonoBehaviour)this).StartCoroutine(CheckAnomaly());
	}

	private void LateUpdate()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = goFollow.transform.position + vectOffset;
		((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, goFollow.transform.rotation, speed * Time.deltaTime);
	}

	public IEnumerator CheckAnomaly()
	{
		yield return (object)new WaitForSeconds(1f);
	}
}
