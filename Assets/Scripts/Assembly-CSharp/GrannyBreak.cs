using System.Collections;
using UnityEngine;

public class GrannyBreak : MonoBehaviour
{
	public GameObject parent;

	public GameObject gameController;

	public GameObject top;

	public GameObject head;

	public GameObject leftArm;

	public GameObject RightArm;

	public AudioClip crashLjud;

	public bool haveBreaked;

	public float fadeStartTime;

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		if (PlayerPrefs.GetInt("DiffData") == 3 || PlayerPrefs.GetInt("EventChallenge1") == 1)
		{
			yield return (object)new WaitForSeconds(10f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 5)
		{
			yield return (object)new WaitForSeconds(2.5f);
		}
		else if (PlayerPrefs.GetInt("DiffData") == 6)
		{
			yield return (object)new WaitForSeconds(0f);
		}
		else
		{
			yield return (object)new WaitForSeconds(25f);
		}
		startBrake();
		((MonoBehaviour)this).StartCoroutine(Destroytimer());
	}

	public virtual void startBrake()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		if (!haveBreaked)
		{
			haveBreaked = true;
			((Component)top.transform).GetComponent<MeshCollider>().convex = true;
			((Rigidbody)top.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)head.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)leftArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)RightArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			top.transform.parent = null;
			head.transform.parent = null;
			leftArm.transform.parent = null;
			RightArm.transform.parent = null;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(crashLjud);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "golv" && !haveBreaked)
		{
			haveBreaked = true;
			((Component)top.transform).GetComponent<MeshCollider>().convex = true;
			((Rigidbody)top.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)head.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)leftArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)RightArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			top.transform.parent = null;
			head.transform.parent = null;
			leftArm.transform.parent = null;
			RightArm.transform.parent = null;
			((Component)this).GetComponent<AudioSource>().PlayOneShot(crashLjud);
		}
	}

	public virtual IEnumerator Destroytimer()
	{
		yield return (object)new WaitForSeconds(5f);
		((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).setTime();
		((grannyRestart)(object)gameController.GetComponent(typeof(grannyRestart))).startTimer = true;
		Object.Destroy((Object)(object)parent);
		Object.Destroy((Object)(object)top);
		Object.Destroy((Object)(object)head);
		Object.Destroy((Object)(object)leftArm);
		Object.Destroy((Object)(object)RightArm);
	}
}
