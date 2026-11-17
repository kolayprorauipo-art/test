using System;
using UnityEngine;
using UnityEngine.AI;

[Serializable]
public class EnemyEye : MonoBehaviour
{
	public int layerMask;

	public Transform myTransform;

	public Transform target;

	public Camera cam;

	public GameObject granny;

	public float seeRange;

	public GameObject playerCrouch;

	public GameObject GameController;

	public EnemyEye()
	{
		layerMask = 1024;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
		if (PlayerPrefs.GetInt("DiffData") == 2)
		{
			seeRange = 250f;
		}
		else
		{
			seeRange = 200f;
		}
		cam = ((Component)this).GetComponent<Camera>();
		GameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = cam.WorldToViewportPoint(target.position);
		Vector3 val3 = target.position - myTransform.position;
		float sqrMagnitude = val3.sqrMagnitude;
		if (((playerCrawl)(object)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
			{
				seeRange = 400f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 300f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				seeRange = 100f;
			}
			else
			{
				seeRange = 50f;
			}
		}
		else if (((playerCrawl)(object)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && !((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
			{
				seeRange = 600f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 500f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				seeRange = 150f;
			}
			else
			{
				seeRange = 50f;
			}
		}
		else if (!((playerCrawl)(object)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && ((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
			{
				seeRange = 600f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 500f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				seeRange = 150f;
			}
			else
			{
				seeRange = 50f;
			}
		}
		else if (!((playerCrawl)(object)playerCrouch.GetComponent(typeof(playerCrawl))).PlayerHukarSig && !((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding)
		{
			if (PlayerPrefs.GetInt("DiffData") == 2 || PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("DiffData") == 5 || PlayerPrefs.GetInt("DiffData") == 6 || PlayerPrefs.GetInt("DiffData") == 7)
			{
				seeRange = 800f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 0)
			{
				seeRange = 700f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 1)
			{
				seeRange = 200f;
			}
			else
			{
				seeRange = 50f;
			}
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 2 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 16)
		{
			seeRange = 50f;
		}
		if (PlayerPrefs.GetInt("DiffData") == -1)
		{
			seeRange = 75f;
		}
		if (!Physics.Linecast(myTransform.position, target.position, ref val, layerMask))
		{
			return;
		}
		if (((Object)((Component)val.collider).gameObject).name == ((Object)target).name)
		{
			if (!(sqrMagnitude < seeRange))
			{
				return;
			}
			if (val2.z <= 0f || val2.x <= 0f || val2.x >= 1f || val2.y <= 0f || val2.y >= 1f)
			{
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
			}
			else if (!((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInPrison && !((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole)
			{
				((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = true;
				if (((startNewDay)(object)GameObject.Find("GameController").GetComponent(typeof(startNewDay))).AnomalyNR == 30)
				{
					GameController.GetComponent<startNewDay>().Anomaly30Achievement = true;
					((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannysVarSpeed = 40f;
					((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).grannysAnimSpeed = 16f;
					NavMeshAgent val4 = (NavMeshAgent)granny.GetComponent(typeof(NavMeshAgent));
					val4.acceleration *= 100f;
				}
			}
		}
		else
		{
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		}
	}
}
