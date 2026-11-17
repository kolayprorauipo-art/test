using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamYellow : MonoBehaviour
{
	private LineRenderer lr;

	private Light hitLight;

	public bool PrimeKill;

	public GameObject GameController;

	private void Start()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		lr = ((Component)this).GetComponent<LineRenderer>();
		lr.startWidth = 0.05f;
		lr.endWidth = 0.05f;
		((Renderer)lr).material = new Material(Shader.Find("Legacy Shaders/Self-Illumin/VertexLit"));
		((Renderer)lr).material.color = Color.yellow;
		((Renderer)lr).material.SetColor("_Color", Color.yellow * 2f);
		lr.positionCount = 2;
		PrimeKill = false;
		GameController = GameObject.Find("GameController");
	}

	private void Update()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)this).gameObject.transform.position;
		Vector3 forward = ((Component)this).gameObject.transform.forward;
		RaycastHit val = default;
		if (GameController.GetComponent<startNewDay>().activateYellowLaser)
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
				((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(1f, 1f, 0f, 0f)));
			}
		}
		else
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position + forward * 50f);
		}
	}

	public void OnDestroy()
	{
	}
}
