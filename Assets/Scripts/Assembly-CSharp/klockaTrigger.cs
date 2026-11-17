using System;
using UnityEngine;

[Serializable]
public class klockaTrigger : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ljudHolder;

	public float AnomalyTimer = 30f;

	public float Anomaly20Timer;

	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		AnomalyTimer = Time.timeSinceLevelLoad + 30f;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player")
		{
			if (GameController.GetComponent<startNewDay>().AnomalyNR == 28 && Random.Range(1, 5) == 1)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).Anomaly28TeleportToClone();
			}
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((klockaRinger)(object)ljudHolder.GetComponent(typeof(klockaRinger))).startKlock = true;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
	}

	public virtual void Update()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 5 && Time.timeSinceLevelLoad > AnomalyTimer)
		{
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((klockaRinger)(object)ljudHolder.GetComponent(typeof(klockaRinger))).startKlock = true;
			AnomalyTimer += 30f;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
	}
}
