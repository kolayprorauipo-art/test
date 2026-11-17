using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class objectFallFloor : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public bool touchGranny;

	public GameObject GameController;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		GameController = GameObject.Find("GameController");
		touchGranny = false;
		GameObject[] array = GameObject.FindGameObjectsWithTag("granny");
		ParentObject.layer = 15;
		for (int i = 0; i < array.Length; i++)
		{
			Collider component = array[i].GetComponent<Collider>();
			if ((Object)(object)component != (Object)null)
			{
				Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), component, true);
			}
		}
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (ParentObject.tag == "vitrindoorRclosed")
		{
			if (GameController.GetComponent<startNewDay>().AnomalyNR == 33)
			{
				yield break;
			}
			if ((((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name == "OldHouseWalls") && !touchGround && ((Object)ParentObject).name != "Picture")
			{
				touchGround = true;
				if (!touchGranny)
				{
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
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
				}
			}
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)GameObject.Find("Player").GetComponent<CharacterController>(), true);
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)GameObject.Find("Main Camera").GetComponent<CharacterController>(), true);
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)GameObject.Find("GrannyCantSeeCollider").GetComponent<BoxCollider>(), true);
		}
		if (((Component)other).gameObject.tag == "granny" && ((Object)ParentObject).name.Contains("LampaSR2"))
		{
			touchGround = true;
		}
		if ((((Component)other).gameObject.tag == "golv" || ((Object)((Component)other).gameObject).name == "OldHouseWalls") && !touchGround && ((Object)ParentObject).name != "Picture")
		{
			touchGround = true;
			if (!touchGranny)
			{
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).resetSafeTimer = false;
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
			}
			if (ParentObject.tag != "vitrindoorRclosed")
			{
				((Collider)((Component)this).gameObject.GetComponent(typeof(Collider))).enabled = false;
				yield return (object)new WaitForSeconds(5f);
				((Collider)ParentObject.GetComponent(typeof(Collider))).enabled = false;
				((Rigidbody)ParentObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
				((Object)ParentObject.transform).name = ((Object)ParentObject.transform).name + "(Clone)";
			}
			else
			{
				Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)GameObject.Find("Player").GetComponent<CharacterController>(), true);
			}
		}
		if (((Component)other).gameObject.tag == "resetfloor" && ParentObject.tag == "vitrindoorRclosed")
		{
			ParentObject.transform.position = new Vector3(29.44f, 14.88f, -16.45f);
		}
	}
}
