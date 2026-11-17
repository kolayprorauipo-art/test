using System.Collections;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamPurple : MonoBehaviour
{
	private LineRenderer lr;

	private Light hitLight;

	public bool PrimeKill;

	public GameObject GameController;

	public bool isActive;

	private void Start()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		lr = ((Component)this).GetComponent<LineRenderer>();
		lr.startWidth = 0.05f;
		lr.endWidth = 0.05f;
		((Renderer)lr).material = new Material(Shader.Find("Legacy Shaders/Self-Illumin/VertexLit"));
		((Renderer)lr).material.color = new Color(0.5f, 0f, 0.8f);
		((Renderer)lr).material.SetColor("_Color", new Color(0.5f, 0f, 0.8f) * 2f);
		lr.positionCount = 2;
		PrimeKill = false;
		GameController = GameObject.Find("GameController");
		((MonoBehaviour)this).StartCoroutine(ActiveSwitch());
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).gameObject.transform.position;
		Vector3 forward = ((Component)this).gameObject.transform.forward;
		RaycastHit val = default;
		if (!isActive)
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position);
		}
		else if (Physics.Raycast(position, forward, ref val, 50f))
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, val.point);
			if ((((Component)val.collider).CompareTag("Player") || ((Component)val.collider).CompareTag("MainCamera")) && !GameController.GetComponent<startNewDay>().deadByLaser)
			{
				((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(0.5f, 0f, 0.8f, 0f)));
			}
		}
		else
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position + forward * 50f);
		}
	}

	public virtual IEnumerator ActiveSwitch()
	{
		while (true)
		{
			yield return (object)new WaitForSeconds(1.5f);
			isActive = !isActive;
		}
	}

	public void OnDestroy()
	{
	}
}
