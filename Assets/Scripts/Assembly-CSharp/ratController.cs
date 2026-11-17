using UnityEngine;
using UnityEngine.AI;

public class ratController : MonoBehaviour
{
	public float wanderRadius;

	public float wanderTimer;

	public float waitingTimer;

	public Animator ratAnim;

	private Transform target;

	private NavMeshAgent agent;

	public float timer;

	public float Waittimer;

	public bool wait;

	public float distanceWaypoint;

	public bool ratS;

	public bool ratR;

	public AudioClip ratNoise;

	public BoxCollider boxCol;

	public float stuckTimer;

	public GameObject GameController;

	public GameObject BOMB;

	public float AnomalySpeed;

	public Vector3[] waypoints;

	public bool Anomaly10;

	public bool Anomaly11;

	public Color BalloonColor;

	public bool Anomaly12;

	public float Anomaly12Timer;

	public virtual void Start()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		ratAnim.Play("Idle");
		agent.speed = 4.5f;
		wanderTimer = Random.Range(10, 30);
		ratAnim = ((Component)ratAnim).gameObject.GetComponent<Animator>();
		ratR = false;
		ratS = false;
		GameController = GameObject.Find("GameController");
		AnomalySpeed = 5f;
		if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 10)
		{
			Anomaly10 = true;
		}
		if (Anomaly11)
		{
			((Renderer)((Component)((Component)this).gameObject.transform.GetChild(2)).gameObject.GetComponent<MeshRenderer>()).material.color = BalloonColor;
			((Component)((Component)this).gameObject.transform.GetChild(2)).gameObject.AddComponent<MeshCollider>().convex = true;
			((Component)((Component)this).gameObject.transform.GetChild(2)).gameObject.layer = 19;
			((Object)((Component)((Component)this).gameObject.transform.GetChild(2)).gameObject).name = "BaloonEvilChair";
		}
		Physics.IgnoreCollision(((Component)this).gameObject.GetComponent<Collider>(), GameObject.Find("Kartong").GetComponent<Collider>());
	}

	private void OnEnable()
	{
		agent = ((Component)this).GetComponent<NavMeshAgent>();
		timer = wanderTimer;
	}

	private void Update()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		if (Anomaly10)
		{
			GameObject[] array = GameObject.FindGameObjectsWithTag("vas2");
			waypoints = new Vector3[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				waypoints[i] = array[i].transform.position;
			}
		}
		Vector3 velocity;
		if (Anomaly12)
		{
			Anomaly12Timer += Time.deltaTime;
			if (Anomaly12Timer >= 1f)
			{
				velocity = agent.velocity;
				if (velocity.sqrMagnitude > 0.0025f)
				{
					Object.Instantiate<GameObject>(BOMB, ((Component)this).transform.position, BOMB.transform.rotation);
				}
				Anomaly12Timer = 0f;
			}
		}
		if (!wait)
		{
			timer += Time.deltaTime;
		}
		if (wait)
		{
			Waittimer += Time.deltaTime;
			agent.speed = 0f;
			if (Waittimer >= waitingTimer)
			{
				wait = false;
				Waittimer = 0f;
				agent.speed = 4.5f;
				if (PlayerPrefs.GetInt("DiffData") == 7)
				{
					agent.speed = 20f;
					agent.acceleration = 100f;
					if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 3)
					{
						agent.speed = 25f;
					}
					else if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 11 && !Anomaly11)
					{
						agent.speed = 10f;
					}
				}
			}
		}
		if (timer >= wanderTimer)
		{
			Vector3 destination = new Vector3(0f, 0f, 0f);
			if (Anomaly10)
			{
				NavMeshHit val = default;
				if (NavMesh.SamplePosition(waypoints[Random.Range(0, waypoints.Length)], ref val, 5f, -1))
				{
					destination = val.position;
				}
			}
			else
			{
				destination = RandomNavSphere(((Component)this).transform.position, wanderRadius, -1);
			}
			agent.SetDestination(destination);
			timer = 0f;
			wait = true;
			wanderTimer = Random.Range(10, 30);
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				wanderTimer = 5f;
			}
		}
		if (agent.velocity != Vector3.zero)
		{
			if (!ratR)
			{
				ratR = true;
				ratS = false;
				ratRunning();
				return;
			}
		}
		else if (!ratS)
		{
			ratS = true;
			ratR = false;
			ratStopped();
		}
		velocity = agent.velocity;
		if (velocity.sqrMagnitude < 0.0025f)
		{
			stuckTimer += Time.deltaTime;
			if (!(stuckTimer >= 30f))
			{
				return;
			}
			if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 13)
				{
					agent.Warp(new Vector3(-3.87f, 1.624f, -3.976f));
				}
				else
				{
					agent.Warp(new Vector3(18.47f, 20.1f, -11.077f));
				}
			}
			stuckTimer = 0f;
		}
		else
		{
			stuckTimer = 0f;
		}
	}

	public virtual void ratStopped()
	{
		agent.speed = 0f;
		ratAnim.Play("Idle");
		timer = 50f;
		((Collider)boxCol).enabled = true;
	}

	public virtual void ratRunning()
	{
		agent.speed = 4.5f;
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			agent.speed = 20f;
			agent.acceleration = 100f;
			if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 3)
			{
				agent.speed = 25f;
			}
			else if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 11 && !Anomaly11)
			{
				agent.speed = 10f;
			}
		}
		ratAnim.Play("Run");
		((Collider)boxCol).enabled = false;
	}

	public virtual void getShoot()
	{
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ratNoise);
		}
	}

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		NavMeshHit val = default;
		NavMesh.SamplePosition(Random.insideUnitSphere * dist + origin, ref val, dist, layermask);
		return val.position;
	}
}
