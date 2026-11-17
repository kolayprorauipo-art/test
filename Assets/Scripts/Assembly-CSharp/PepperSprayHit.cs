using UnityEngine;

public class PepperSprayHit : MonoBehaviour
{
	public GameObject granny;

	public GameObject GrannyClosetrigger;

	public sprayPepper sprayController;

	public float sprayDistance;

	public float sprayRadius;

	private EnemyAIGranny grannyAI;

	public GameObject GameController;

	private void Start()
	{
		sprayController = GameObject.Find("PeppersprayButton").GetComponent<sprayPepper>();
		granny = GameObject.Find("GrannyParent");
		GameController = GameObject.Find("GameController");
		sprayDistance = 6f;
		sprayRadius = 1f;
		grannyAI = granny.GetComponent<EnemyAIGranny>();
	}

	private void OnParticleCollision(GameObject other)
	{
		if (((Object.op_Implicit((Object)(object)sprayController) && sprayController.sprayTime) || GameController.GetComponent<startNewDay>().AnomalyNR == 32) && other.tag == "granny")
		{
			ApplyPepper();
		}
	}

	private void Update()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if ((Object.op_Implicit((Object)(object)sprayController) && sprayController.sprayTime) || GameController.GetComponent<startNewDay>().AnomalyNR == 32)
		{
			Vector3 position = ((Component)this).gameObject.transform.position;
			Vector3 forward = ((Component)this).gameObject.transform.forward;
			RaycastHit val = default;
			if (Physics.Raycast(position, forward, ref val, 10f) && ((Component)val.collider).CompareTag("granny"))
			{
				ApplyPepper();
			}
		}
	}

	private void ApplyPepper()
	{
		if (!grannyAI.hitByPepper)
		{
			grannyAI.hitByPepper = true;
			grannyAI.hitByPepperStart = true;
			grannyAI.grannyPepperReact = false;
			GrannyClosetrigger.SetActive(true);
			grannyAI.blindTimer = 30f;
			if (PlayerPrefs.GetInt("DiffData") == -1)
			{
				grannyAI.blindTimer = 60f;
			}
			else if (PlayerPrefs.GetInt("DiffData") == 7)
			{
				grannyAI.blindTimer = 15f;
			}
			if (PlayerPrefs.GetInt("EventChallenge3") == 1)
			{
				AchievementSaveManager.Instance.UnlockAchievement("BreatheFire");
			}
		}
	}
}
