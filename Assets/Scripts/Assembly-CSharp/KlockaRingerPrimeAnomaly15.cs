using UnityEngine;

public class KlockaRingerPrimeAnomaly15 : MonoBehaviour
{
	public bool startKlock;

	public AudioClip klockljud;

	public float AnomalyTimer;

	public Transform spawnObject;

	public Transform Player;

	public EnemyAIGranny EnemyAIGrannyScript;

	private void Start()
	{
		AnomalyTimer = Time.timeSinceLevelLoad + 30f;
	}

	public void Update()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		if (startKlock)
		{
			startKlock = false;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(klockljud);
			((Component)this).gameObject.GetComponent<Animation>().Play("Klocka");
		}
		if (Time.timeSinceLevelLoad > AnomalyTimer)
		{
			EnemyAIGrannyScript.grannyHearObject = true;
			EnemyAIGrannyScript.startTimerSearch = false;
			EnemyAIGrannyScript.GrannySearching = false;
			startKlock = true;
			AnomalyTimer += 30f;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, Player.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, Player.position, ((Component)this).transform.rotation);
			}
		}
	}
}
