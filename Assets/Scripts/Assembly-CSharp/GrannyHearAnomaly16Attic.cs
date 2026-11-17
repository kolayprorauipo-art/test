using System;
using UnityEngine;

[Serializable]
public class GrannyHearAnomaly16Attic : MonoBehaviour
{
	public Vector3 point;

	public virtual void Update()
	{
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorClose") || ((Component)this).GetComponent<Animation>().IsPlaying("InnerdoorLocked") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorOpen") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorClose") || ((Component)this).GetComponent<Animation>().IsPlaying("SmallDoorLocked") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda1Open") || ((Component)this).GetComponent<Animation>().IsPlaying("Loda1Close"))
		{
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
			((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
			if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
			{
				((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, point, ((Component)this).transform.rotation);
			}
			else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
			{
				Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, point, ((Component)this).transform.rotation);
			}
		}
	}
}
