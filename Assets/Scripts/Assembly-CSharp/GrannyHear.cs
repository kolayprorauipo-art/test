using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class GrannyHear : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public AudioClip PlayerLjud;

	public GameObject GameController;

	public bool dontCreack;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 40)
		{
			if (Random.Range(1, 3) == 1)
			{
				dontCreack = true;
			}
			((MonoBehaviour)this).StartCoroutine(ChangeValueAnomaly40());
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "Player" && !dontCreack)
		{
			if (GameController.GetComponent<startNewDay>().AnomalyNR == 28 && Random.Range(1, 5) == 1)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).Anomaly28TeleportToClone();
			}
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(PlayerLjud);
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(PlayerLjud);
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

	public virtual IEnumerator ChangeValueAnomaly40()
	{
		while (true)
		{
			dontCreack = !dontCreack;
			yield return (object)new WaitForSeconds(Random.Range(15f, 60f));
		}
	}
}
