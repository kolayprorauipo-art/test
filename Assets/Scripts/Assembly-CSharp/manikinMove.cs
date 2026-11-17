using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class manikinMove : MonoBehaviour
{
	public bool startStopMoving;

	public bool soundPlayed;

	public Transform player;

	public int damping;

	public GameObject soundHolder;

	public GameObject gameController;

	public manikinMove()
	{
		damping = 2;
	}

	public virtual void Start()
	{
		player = GameObject.Find("Player").transform;
		soundHolder = GameObject.Find("SoundEffects");
		gameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (startStopMoving)
		{
			Vector3 val = player.position - ((Component)this).transform.position;
			val.y = 0f;
			Quaternion val2 = Quaternion.LookRotation(val);
			((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, val2, Time.deltaTime * (float)damping);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			startStopMoving = true;
			if (!soundPlayed)
			{
				soundPlayed = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).manakinLook();
			}
			((MonoBehaviour)this).StartCoroutine(Timer());
		}
	}

	public virtual IEnumerator Timer()
	{
		yield return (object)new WaitForSeconds(5f);
		startStopMoving = false;
		yield return (object)new WaitForSeconds(30f);
		Object.Destroy((Object)(object)((Component)this).gameObject);
	}
}
