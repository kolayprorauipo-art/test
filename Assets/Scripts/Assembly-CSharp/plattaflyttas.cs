using System;
using UnityEngine;

[Serializable]
public class plattaflyttas : MonoBehaviour
{
	public bool Upp;

	public bool H;

	public bool Ner;

	public bool V;

	public AudioClip flyttaPlatta;

	public virtual void update()
	{
	}

	public virtual void MovePlatta()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		if (Upp)
		{
			float z = ((Component)this).gameObject.transform.localPosition.z - 0.5f;
			Vector3 localPosition = ((Component)this).gameObject.transform.localPosition;
			localPosition.z = z;
			((Component)this).gameObject.transform.localPosition = localPosition;
			AudioSource.PlayClipAtPoint(flyttaPlatta, ((Component)this).transform.position);
		}
		else if (H)
		{
			float x = ((Component)this).gameObject.transform.localPosition.x - 0.5f;
			Vector3 localPosition2 = ((Component)this).gameObject.transform.localPosition;
			localPosition2.x = x;
			((Component)this).gameObject.transform.localPosition = localPosition2;
			AudioSource.PlayClipAtPoint(flyttaPlatta, ((Component)this).transform.position);
		}
		else if (Ner)
		{
			float z2 = ((Component)this).gameObject.transform.localPosition.z + 0.5f;
			Vector3 localPosition3 = ((Component)this).gameObject.transform.localPosition;
			localPosition3.z = z2;
			((Component)this).gameObject.transform.localPosition = localPosition3;
			AudioSource.PlayClipAtPoint(flyttaPlatta, ((Component)this).transform.position);
		}
		else if (V)
		{
			float x2 = ((Component)this).gameObject.transform.localPosition.x + 0.5f;
			Vector3 localPosition4 = ((Component)this).gameObject.transform.localPosition;
			localPosition4.x = x2;
			((Component)this).gameObject.transform.localPosition = localPosition4;
			AudioSource.PlayClipAtPoint(flyttaPlatta, ((Component)this).transform.position);
		}
	}
}
