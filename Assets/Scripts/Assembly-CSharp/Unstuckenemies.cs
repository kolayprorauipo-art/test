using System;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class Unstuckenemies : MonoBehaviour
{
	public GameObject Granny;

	public Transform Door;

	public EnemyAIGranny EnemyAIGranny;

	private float LastMoveTimer_Granny;

	public float Timer;

	public NavMeshAgent NavAgent_Granny;

	private Vector3 LastPos_Granny;

	public Vector3 Position = new Vector3(18.46f, 13.22f, -7.12f);

	public Quaternion Rotation = Quaternion.Euler(0f, 90f, 0f);

	public Unstuckenemies()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
	}

	private void Awake()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		LastPos_Granny = Granny.transform.position;
	}

	private void Update()
	{
		if (EnemyAIGranny.seeClosedDoorTimer > 0f)
		{
			Timer += Time.deltaTime;
			if (Timer >= 10f)
			{
				UnstuckGranny();
				Timer = 0f;
			}
		}
		else
		{
			Timer = 0f;
		}
	}

	private void UnstuckGranny()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		NavAgent_Granny.Warp(Position);
		Granny.transform.rotation = Rotation;
	}

	private void OnTriggerStay(Collider other)
	{
		if (((Component)other).tag == "granny")
		{
			((Behaviour)this).enabled = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (((Component)other).tag == "granny")
		{
			((Behaviour)this).enabled = false;
			Timer = 0f;
		}
	}
}
