using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class objectsFallFloorTavla : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip[] ObjectLjud;

	public bool notMore;

	public bool madeNoice;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "golv" && !madeNoice)
		{
			((MonoBehaviour)this).StartCoroutine(StopCreatingSounds());
			int num = Random.Range(0, ObjectLjud.Length);
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud[num]);
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
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
			}
			yield return (object)new WaitForSeconds(6f);
			((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
			((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			nameIt();
		}
	}

	public virtual void nameIt()
	{
		if (!notMore)
		{
			notMore = true;
			((Object)ParentObject.transform).name = ((Object)ParentObject.transform).name + "(Clone)";
		}
	}

	public IEnumerator StopCreatingSounds()
	{
		yield return (object)new WaitForSeconds(1.5f);
		madeNoice = true;
	}
}
