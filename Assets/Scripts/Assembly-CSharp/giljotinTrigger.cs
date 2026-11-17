using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class giljotinTrigger : MonoBehaviour
{
	public GameObject melon;

	public GameObject deladMelon;

	public GameObject Granny;

	public Transform spawnObject;

	public GameObject ParentObject;

	public AudioClip ObjectLjud;

	public bool touchGround;

	public bool meloninPlace;

	public GameObject spak;

	public GameObject keyShow;

	public virtual void Start()
	{
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "giljotinklinga")
		{
			spak.gameObject.tag = "Untagged";
			if (meloninPlace)
			{
				melon.SetActive(false);
				deladMelon.SetActive(true);
				keyShow.SetActive(true);
				meloninPlace = false;
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).timerSearch = 0f;
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
				((Component)this).GetComponent<AudioSource>().PlayOneShot(ObjectLjud);
			}
			((MonoBehaviour)this).StartCoroutine(giljoTimer());
		}
	}

	public virtual IEnumerator giljoTimer()
	{
		yield return (object)new WaitForSeconds(1.6f);
		spak.gameObject.tag = "giljotinspak";
	}
}
