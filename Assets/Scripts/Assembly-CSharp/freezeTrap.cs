using System.Collections;
using UnityEngine;

public class freezeTrap : MonoBehaviour
{
	public Transform spawnObject;

	public GameObject Granny;

	public GameObject gameController;

	public bool trapActivated;

	public bool GrannyFreeze;

	public GameObject steam;

	public Texture red;

	public Texture green;

	public Renderer rend;

	public AudioClip freezeSound;

	private void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		rend = ((Component)this).GetComponent<Renderer>();
		rend.material.mainTexture = red;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "grus" || ((Object)((Component)other).gameObject).name == "OldHouseWalls")
		{
			trapActivated = true;
			rend.material.mainTexture = green;
			((Component)this).gameObject.layer = 0;
		}
		if (((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught || !trapActivated)
		{
			return;
		}
		if (((Component)other).gameObject.tag == "granny" && PlayerPrefs.GetInt("DiffData") != 7)
		{
			((Component)this).gameObject.tag = "Untagged";
			trapActivated = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).freeze = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(freezeSound);
			((MonoBehaviour)this).StartCoroutine(timer());
		}
		else if (((Component)other).gameObject.tag == "Player")
		{
			((Component)this).gameObject.tag = "Untagged";
			trapActivated = false;
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(freezeSound);
			((MonoBehaviour)this).StartCoroutine(timer());
			((PlayerFreeze)(object)gameController.GetComponent(typeof(PlayerFreeze))).playerFreezeStuck();
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
		else if (((Component)other).gameObject.tag == "Spider")
		{
			((Component)this).gameObject.tag = "Untagged";
			trapActivated = false;
			((Rigidbody)((Component)this).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(freezeSound);
			((MonoBehaviour)this).StartCoroutine(timer());
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(spawnObject, ((Component)this).transform.position, ((Component)this).transform.rotation);
			}
		}
	}

	public virtual IEnumerator timer()
	{
		yield return (object)new WaitForSeconds(3.5f);
		steam.GetComponent<ParticleSystem>().enableEmission = false;
		((Component)this).gameObject.tag = "freezetrap";
	}
}
