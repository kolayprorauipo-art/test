using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class moveTunnellock : MonoBehaviour
{
	public bool LockMoved;

	public AudioClip ObjectLjud;

	public GameObject gameController;

	public virtual void Start()
	{
		gameController = GameObject.Find("GameController");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player" && !LockMoved)
		{
			LockMoved = true;
			((Component)this).gameObject.GetComponent<Animation>().Play("TunnelLock");
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			Physics.IgnoreCollision(((Component)this).GetComponent<Collider>(), ((Component)other).GetComponent<Collider>(), true);
			if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
			{
				yield return ((MonoBehaviour)this).StartCoroutine(Anomaly16());
			}
			yield return (object)new WaitForSeconds(20f);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public virtual IEnumerator Anomaly16()
	{
		if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		yield break;
	}
}
