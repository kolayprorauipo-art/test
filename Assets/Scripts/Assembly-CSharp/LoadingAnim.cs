using UnityEngine;

public class LoadingAnim : MonoBehaviour
{
	private float rot;

	private void Update()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		rot += 100f * Time.deltaTime;
		((Component)this).transform.localRotation = Quaternion.Euler(0f, 0f, rot);
	}
}
