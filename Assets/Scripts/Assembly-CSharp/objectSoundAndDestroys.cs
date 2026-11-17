using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class objectSoundAndDestroys : MonoBehaviour
{
	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public bool haveMakedSound;

	public virtual void Start()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "golv")
		{
			if (((Object)ParentObject).name != "Burk")
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
				}
				else
				{
					Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
				}
				((MonoBehaviour)this).StartCoroutine(HaveMakedSound());
				yield return (object)new WaitForSeconds(10f);
				Object.Destroy((Object)(object)ParentObject);
			}
			else
			{
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
				((MonoBehaviour)this).StartCoroutine(HaveMakedSound());
				yield return (object)new WaitForSeconds(10f);
				Object.Destroy((Object)(object)ParentObject);
			}
		}
		else if (((Component)other).gameObject.tag == "Player" && haveMakedSound)
		{
			Physics.IgnoreCollision(ParentObject.GetComponent<Collider>(), (Collider)(object)((Component)other).GetComponent<CharacterController>(), true);
		}
	}

	public virtual IEnumerator HaveMakedSound()
	{
		yield return (object)new WaitForSeconds(2f);
		haveMakedSound = true;
	}
}
