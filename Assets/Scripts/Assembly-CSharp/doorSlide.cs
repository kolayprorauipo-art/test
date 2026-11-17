using System;
using UnityEngine;

[Serializable]
public class doorSlide : MonoBehaviour
{
	public bool plattaTryck;

	public bool maxH;

	public bool maxV;

	public AudioClip slidingDoor;

	public bool stopsound;

	public bool startsound;

	public virtual void Start()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		float x = 20.60735f;
		Vector3 position = ((Component)this).gameObject.transform.position;
		position.x = x;
		((Component)this).gameObject.transform.position = position;
	}

	public virtual void Update()
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		if (plattaTryck)
		{
			if (!maxH)
			{
				float x = ((Component)this).gameObject.transform.position.x - 3f * Time.deltaTime;
				Vector3 position = ((Component)this).gameObject.transform.position;
				position.x = x;
				((Component)this).gameObject.transform.position = position;
			}
		}
		else if (!plattaTryck && !maxV)
		{
			float x2 = ((Component)this).gameObject.transform.position.x - -3f * Time.deltaTime;
			Vector3 position2 = ((Component)this).gameObject.transform.position;
			position2.x = x2;
			((Component)this).gameObject.transform.position = position2;
		}
		if (((Component)this).gameObject.transform.position.x <= 16.31f)
		{
			maxH = true;
			StopSound();
		}
		else if (((Component)this).gameObject.transform.position.x > 16.31f && ((Component)this).gameObject.transform.position.x < 20.60735f)
		{
			stopsound = false;
			maxH = false;
		}
		if (((Component)this).gameObject.transform.position.x >= 20.60735f)
		{
			maxV = true;
			StopSound();
		}
		else if (((Component)this).gameObject.transform.position.x < 20.60735f && ((Component)this).gameObject.transform.position.x > 16.31f)
		{
			stopsound = false;
			maxV = false;
		}
	}

	public virtual void StartSound()
	{
		((Component)this).GetComponent<AudioSource>().Play();
		startsound = true;
	}

	public virtual void StopSound()
	{
		if (!stopsound)
		{
			stopsound = true;
			((Component)this).GetComponent<AudioSource>().Stop();
		}
	}
}
