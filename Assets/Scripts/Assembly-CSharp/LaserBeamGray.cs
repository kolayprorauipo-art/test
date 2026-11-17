using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamGray : MonoBehaviour
{
	private LineRenderer lr;

	public bool PrimeKill;

	public float LaserDistance;

	public float LaserDistanceMax;

	public bool increase;

	public GameObject ActivateLaser;

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
		((Renderer)lr).material.color = new Color(1f, 0.5f, 0f) * 5f;
		((Renderer)lr).material.SetColor("_Color", new Color(1f, 0.5f, 0f));
		lr.positionCount = 2;
		PrimeKill = false;
		LaserDistance = 16f;
		GameController = GameObject.Find("GameController");
	}

	private void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).transform.position;
		Vector3 forward = ((Component)this).transform.forward;
		RaycastHit[] array = Physics.RaycastAll(position, forward, LaserDistance);
		if (array.Length != 0)
		{
			Array.Sort(array, (RaycastHit a, RaycastHit b) => a.distance.CompareTo(b.distance));
			RaycastHit[] array2 = array;
			for (int num = 0; num < array2.Length; num++)
			{
				RaycastHit val = array2[num];
				if (((Object)val.collider).name != "Innerdoor" && ((Component)val.collider).gameObject.layer != 12)
				{
					lr.SetPosition(0, position);
					lr.SetPosition(1, val.point);
					if ((((Component)val.collider).CompareTag("Player") || ((Component)val.collider).CompareTag("MainCamera")) && !GameController.GetComponent<startNewDay>().deadByLaser)
					{
						((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(1f, 0.5f, 0f, 0f)));
					}
					break;
				}
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
		while (LaserDistance < 16f)
		{
			yield return (object)new WaitForSeconds(0.002f);
			LaserDistance += 0.01f;
		}
		LaserDistance = 16f;
		ActivateLaser.GetComponent<ActivateGrayLaser>().LaserReset();
	}

	public IEnumerator ZeroDistance()
	{
		LaserDistance = 0f;
		((MonoBehaviour)this).StartCoroutine(ChangeDistance());
		yield break;
	}
}
