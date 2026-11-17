using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class spawnRagdoll : MonoBehaviour
{
	public Transform grannyRagdoll;

	public virtual IEnumerator Start()
	{
		yield return (object)new WaitForSeconds(5f);
		Object.Instantiate<Transform>(grannyRagdoll, ((Component)this).transform.position, ((Component)this).transform.rotation);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}

	public virtual void Update()
	{
	}
}
