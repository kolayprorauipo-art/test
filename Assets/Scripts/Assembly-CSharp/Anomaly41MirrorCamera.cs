using UnityEngine;

public class Anomaly41MirrorCamera : MonoBehaviour
{
	private void Start()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		Camera component = ((Component)this).GetComponent<Camera>();
		Matrix4x4 projectionMatrix = component.projectionMatrix;
		projectionMatrix.m00 *= -1f;
		component.projectionMatrix = projectionMatrix;
	}

	private void OnPreCull()
	{
		GL.invertCulling = true;
	}

	private void OnPostRender()
	{
		GL.invertCulling = false;
	}
}
