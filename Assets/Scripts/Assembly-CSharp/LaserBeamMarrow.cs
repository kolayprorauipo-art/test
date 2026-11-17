using System.Collections;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamMarrow : MonoBehaviour
{
	private LineRenderer lr;

	public bool PrimeKill;

	public float LaserDistance;

	public float LaserDistanceMax;

	public bool increase;

	public GameObject GameController;

	private void Start()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		lr = ((Component)this).GetComponent<LineRenderer>();
		lr.startWidth = 0.05f;
		lr.endWidth = 0.05f;
		((Renderer)lr).material = new Material(Shader.Find("Legacy Shaders/Self-Illumin/VertexLit"));
		((Renderer)lr).material.color = new Color(0.8f, 0f, 0.4f) * 5f;
		((Renderer)lr).material.SetColor("_Color", new Color(0.8f, 0f, 0.4f));
		lr.positionCount = 2;
		PrimeKill = false;
		LaserDistance = 0f;
		((MonoBehaviour)this).StartCoroutine(ChangeDistance());
		GameController = GameObject.Find("GameController");
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).gameObject.transform.position;
		Vector3 forward = ((Component)this).gameObject.transform.forward;
		RaycastHit val = default;
		if (Physics.Raycast(position, forward, ref val, LaserDistance))
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, val.point);
			if ((((Component)val.collider).CompareTag("Player") || ((Component)val.collider).CompareTag("MainCamera")) && !GameController.GetComponent<startNewDay>().deadByLaser)
			{
				((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(0.8f, 0f, 0.4f, 0f)));
			}
		}
		else
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position + forward * LaserDistance);
		}
	}

	private IEnumerator ChangeDistance()
	{
		while (true)
		{
			yield return (object)new WaitForSeconds(0.0075f);
			if (increase)
			{
				LaserDistance += 0.1f;
			}
			else
			{
				LaserDistance -= 0.1f;
			}
			if (LaserDistance >= LaserDistanceMax)
			{
				increase = false;
			}
			if (LaserDistance <= 0f)
			{
				yield return (object)new WaitForSeconds(1f);
				increase = true;
			}
		}
	}
}
