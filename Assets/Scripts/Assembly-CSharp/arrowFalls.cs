using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class arrowFalls : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public Transform objectResetPos;

	public bool audioPlayed;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		objectResetPos = GameObject.Find("ObjectResetPoint").transform;
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name == "OldHouseWalls")
		{
			if (!audioPlayed)
			{
				audioPlayed = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
					yield return (object)new WaitForSeconds(0.5f);
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
					((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				}
			}
		}
		else if (!(((Component)other).gameObject.tag == "Player") && ((Component)other).gameObject.tag == "resetfloor")
		{
			ParentObject.transform.position = objectResetPos.position;
		}
	}
}
