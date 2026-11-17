using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ObjectFallFloorMultiple : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "golv")
		{
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
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			((Collider)((Component)this).gameObject.GetComponent(typeof(Collider))).enabled = false;
			yield return (object)new WaitForSeconds(5f);
			((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
			((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			((Object)ParentObject.transform).name = ((Object)ParentObject.transform).name + "(Clone)";
		}
	}
}
