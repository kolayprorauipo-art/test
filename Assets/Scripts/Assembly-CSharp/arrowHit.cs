using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class arrowHit : MonoBehaviour
{
	public bool timer;

	public bool noMoreHit;

	public float depth;

	public GameObject Granny;

	public Transform arrow;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(2f);
		timer = true;
	}

	public virtual void Update()
	{
		Granny = GameObject.Find("GrannyParent");
	}

	public virtual IEnumerator OnTriggerEnter(Collider other)
	{
		if (!timer && ((Component)other).gameObject.tag == "granny" && !noMoreHit)
		{
			noMoreHit = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByArrow = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			((Component)this).transform.Translate(depth * Vector3.forward);
			((Component)this).transform.rotation = Quaternion.LookRotation(Vector3.right);
			Object.Destroy((Object)(object)((Component)this).gameObject.GetComponent<Collider>());
			((Component)this).transform.parent = ((Component)other).transform;
			((Behaviour)(arrowHit)(object)((Component)this).gameObject.GetComponent(typeof(arrowHit))).enabled = false;
			yield return (object)new WaitForSeconds(2f);
			Object.Instantiate<Transform>(arrow, ((Component)this).transform.position, ((Component)this).transform.rotation);
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
		if (((Object)((Component)other).gameObject).name == "GrannyCantSeeCollider")
		{
			((Component)this).gameObject.transform.position = new Vector3(((Component)this).gameObject.transform.position.x, ((Component)this).gameObject.transform.position.y - 0.5f, ((Component)this).gameObject.transform.position.z);
		}
	}
}
