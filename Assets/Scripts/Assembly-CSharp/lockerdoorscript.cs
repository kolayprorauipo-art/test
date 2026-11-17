using System;
using UnityEngine;

[Serializable]
public class lockerdoorscript : MonoBehaviour
{
	public bool doorOpen;

	public virtual void Update()
	{
		if (!doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("LockerDoorOpen"))
		{
			doorOpen = true;
			((Component)this).gameObject.tag = "Untagged";
		}
		if (doorOpen && ((Component)this).GetComponent<Animation>().IsPlaying("LockerDoorClose"))
		{
			doorOpen = false;
		}
	}
}
