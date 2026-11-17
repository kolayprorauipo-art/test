using UnityEngine;

public class ratBite : MonoBehaviour
{
	public GameObject playerAnim;

	public GameObject noiseobject;

	public Transform noiseDropPoint;

	public GameObject gameController;

	public GameObject ratController;

	public AudioClip ratNoise;

	public AudioClip ratNoise2;

	public bool PrimeKill;

	public GameObject Granny;

	public bool CursedStool;

	public float CursedTimer;

	public Color StandartColor;

	public float TimeToCurse;

	public virtual void Start()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		Granny = GameObject.Find("GrannyParent");
		CursedStool = false;
		TimeToCurse = 30f;
		StandartColor = Color.white;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			return;
		}
		if (((Component)other).gameObject.tag == "Player" && !GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().ratSpeedBoost)
		{
			playerAnim.gameObject.GetComponent<Animation>().Play("playerHurt");
			((playerInBeartrap)(object)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
			Object.Instantiate<GameObject>(noiseobject, noiseDropPoint.position, noiseDropPoint.rotation);
			((ratController)(object)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ratNoise);
			if (gameController.GetComponent<startNewDay>().AnomalyNR == 26)
			{
				((MonoBehaviour)this).StartCoroutine(GameObject.Find("PlayerHukarSigButton").GetComponent<playerCrawl>().RatSpeedBoost());
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).RatBiteCount++;
			}
		}
		else if (((Component)other).gameObject.tag == "arrow")
		{
			((ratController)(object)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ratNoise2);
		}
		else if (((Component)other).gameObject.tag == "granny")
		{
			((ratController)(object)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ratNoise2);
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (PlayerPrefs.GetInt("PrimeOn") == 1 && ((Component)other).gameObject.tag == "Player" && ((((Component)other).GetComponent<CharacterController>().height < 2f && CursedStool) || (((Component)other).GetComponent<CharacterController>().height > 2f && !CursedStool)) && !PrimeKill && PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (((Component)other).GetComponent<CharacterController>().height > 2f && !CursedStool)
			{
				AchievementSaveManager.Instance.UnlockAchievement("CrouchNextTime");
				((MonoBehaviour)this).StartCoroutine(((playerCaught)(object)((Component)other).GetComponent(typeof(playerCaught))).fallingDead());
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
				PrimeKill = true;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((Component)other).GetComponent<FPSControllerNEW>().soundHolder.GetComponent<soundEffects>().playerLandSound();
			}
			else if (((Component)other).GetComponent<CharacterController>().height < 2f && CursedStool)
			{
				AchievementSaveManager.Instance.UnlockAchievement("StandUpNextTime");
				((MonoBehaviour)this).StartCoroutine(((playerCaught)(object)((Component)other).GetComponent(typeof(playerCaught))).fallingDead());
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
				PrimeKill = true;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((FPSControllerNEW)(object)((Component)other).GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				((Component)other).GetComponent<FPSControllerNEW>().soundHolder.GetComponent<soundEffects>().playerLandSound();
			}
		}
	}

	public virtual void Update()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (gameController.GetComponent<startNewDay>().PrimeAnomalyNR != 8)
		{
			return;
		}
		CursedTimer += Time.deltaTime;
		if (CursedTimer >= TimeToCurse)
		{
			CursedStool = !CursedStool;
			CursedTimer = 0f;
			TimeToCurse = Random.Range(30f, 90f);
			if (CursedStool)
			{
				((Renderer)GameObject.Find("StoolPrime").GetComponent<MeshRenderer>()).material.color = new Color(0.5f, 0f, 1f);
			}
			else
			{
				((Renderer)GameObject.Find("StoolPrime").GetComponent<MeshRenderer>()).material.color = StandartColor;
			}
		}
	}
}
