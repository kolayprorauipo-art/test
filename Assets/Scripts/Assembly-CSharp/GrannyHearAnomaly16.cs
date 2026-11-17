using System;
using UnityEngine;

[Serializable]
public class GrannyHearAnomaly16 : MonoBehaviour
{
	public EnemyAIGranny EnemyAIGrannyScript;

	public Transform Noise16Anomaly;

	public bool animIsPlaying;

	public virtual void Start()
	{
		Noise16Anomaly = ((Component)GameObject.Find("Noise16Anomaly").GetComponent<GrannyHear>().spawnObject).transform;
		EnemyAIGrannyScript = GameObject.Find("GrannyParent").GetComponent<EnemyAIGranny>();
	}

	public virtual void Update()
	{
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorClose") || ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorLocked") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorClose") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorLocked") || ((Component)this).GetComponent<Animation>().IsPlaying("Garde1Open") || ((Component)this).GetComponent<Animation>().IsPlaying("Garde1Close") || ((Component)this).GetComponent<Animation>().IsPlaying("KitchenDoor1Open") || ((Component)this).GetComponent<Animation>().IsPlaying("KitchenDoor1Close") || ((Component)this).GetComponent<Animation>().IsPlaying("bakluckaOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("bakluckaClose") || ((Component)this).GetComponent<Animation>().IsPlaying("motorhuvOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("motorhuvClose") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda2Open") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda2Close") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda1Open") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda1Close") || ((Component)this).GetComponent<Animation>().IsPlaying("KylOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("KylClose") || ((Component)this).GetComponent<Animation>().IsPlaying("GallerHole"))
		{
			if (!animIsPlaying)
			{
				EnemyAIGrannyScript.grannyHearObject = true;
				EnemyAIGrannyScript.startTimerSearch = false;
				EnemyAIGrannyScript.GrannySearching = false;
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(Noise16Anomaly, ((Component)this).transform.position, ((Component)this).transform.rotation);
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(Noise16Anomaly, ((Component)this).transform.position, ((Component)this).transform.rotation);
				}
			}
			animIsPlaying = true;
		}
		else if (((Component)this).GetComponent<Animation>().IsPlaying("WindowOpenClose"))
		{
			if (!animIsPlaying)
			{
				EnemyAIGrannyScript.grannyHearObject = true;
				EnemyAIGrannyScript.startTimerSearch = false;
				EnemyAIGrannyScript.GrannySearching = false;
				if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
				{
					((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
					Object.Instantiate<Transform>(Noise16Anomaly, new Vector3(7.62f, 14.21f, -11.1f), ((Component)this).transform.rotation);
				}
				else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
				{
					Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
				}
				else
				{
					Object.Instantiate<Transform>(Noise16Anomaly, new Vector3(7.62f, 14.21f, -11.1f), ((Component)this).transform.rotation);
				}
			}
			animIsPlaying = true;
		}
		else
		{
			animIsPlaying = false;
		}
	}
}
