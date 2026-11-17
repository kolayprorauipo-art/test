using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamCyan : MonoBehaviour
{
	private LineRenderer lr;

	public bool PrimeKill;

	public float LaserDistance;

	public GameObject GameController;

	private void Start()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		lr = ((Component)this).GetComponent<LineRenderer>();
		lr.startWidth = 0.05f;
		lr.endWidth = 0.05f;
		((Renderer)lr).material = new Material(Shader.Find("Legacy Shaders/Self-Illumin/VertexLit"));
		((Renderer)lr).material.color = Color.cyan;
		((Renderer)lr).material.SetColor("_Color", Color.cyan * 5f);
		lr.positionCount = 2;
		lr.endColor = new Color(0f, 1f, 1f, 0f);
		PrimeKill = false;
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
				((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(0f, 1f, 1f, 0f)));
			}
		}
		else
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position + forward * LaserDistance);
		}
	}
}
