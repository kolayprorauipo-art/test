using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ObjectFallFloorDestroys : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if ((((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name == "Lekhus") && !touchGround)
		{
			touchGround = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
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
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			((Collider)((Component)this).gameObject.GetComponent(typeof(Collider))).enabled = false;
			yield return (object)new WaitForSeconds(3f);
			((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
			((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			((Object)ParentObject.transform).name = ((Object)ParentObject.transform).name + "(Clone)";
			yield return (object)new WaitForSeconds(10f);
			Object.Destroy((Object)(object)ParentObject);
		}
	}
}
