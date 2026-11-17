using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class sprayPepper : MonoBehaviour
{
	public GameObject spray;

	public GameObject soundHolder;

	public Button btn1;

	public bool sprayTime;

	public GameObject checkSpray;

	public GameObject gameController;

	public PickUp PickUpScript;

	public float sprayCounter = 5f;

	public virtual void Start()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		sprayTime = false;
		gameController = GameObject.Find("GameController");
		if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			spray.GetComponent<ParticleSystem>().startColor = Color.red;
		}
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && Time.timeScale != 0f && PlayerPrefs.GetInt("EventChallenge3") == 0)
		{
			UseSprayButton();
		}
	}

	public void UseSprayButton()
	{
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		if (sprayCounter > 0f || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 6 || PlayerPrefs.GetInt("PrimeOn") == 0 || (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6 && sprayCounter > -45f && PlayerPrefs.GetInt("EventChallenge3") != 1))
		{
			if (!sprayTime)
			{
				spray.SetActive(true);
				sprayTime = true;
				soundHolder.SetActive(true);
				sprayCounter--;
				((MonoBehaviour)this).StartCoroutine(time());
				if (sprayCounter == 0f && (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).RandomTask == 5 || ((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).randomTask2 == 5))
				{
					((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).LiftDoor = 11f;
					return;
				}
			}
		}
		else
		{
			PickUpScript.ShowText2("It's empty");
		}
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, GameObject.Find("Player").transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, GameObject.Find("Player").transform.position, ((Component)this).transform.rotation);
			}
		}
	}

	public virtual IEnumerator time()
	{
		yield return (object)new WaitForSeconds(1f);
		spray.SetActive(false);
		sprayTime = false;
		soundHolder.SetActive(false);
	}

	public virtual IEnumerator Event3Breath()
	{
		for (int i = 0; i < 15; i++)
		{
			if (!sprayTime)
			{
				spray.SetActive(true);
				sprayTime = true;
				soundHolder.SetActive(true);
				((MonoBehaviour)this).StartCoroutine(time());
			}
			yield return (object)new WaitForSeconds(2f);
		}
	}

	public void OnDisable()
	{
		spray.SetActive(false);
		sprayTime = false;
		soundHolder.SetActive(false);
	}
}
