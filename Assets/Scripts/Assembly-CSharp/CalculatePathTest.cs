using UnityEngine;
using UnityEngine.AI;

[ExecuteInEditMode]
public class CalculatePathTest : MonoBehaviour
{
	public Transform target;

	private void OnDrawGizmos()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected Obj, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)target == (Object)null))
		{
			NavMeshPath val = new NavMeshPath();
			NavMesh.CalculatePath(((Component)this).transform.position, target.position, -1, val);
			Gizmos.color = Color.red;
			Gizmos.DrawRay(((Component)this).transform.position, Vector3.up);
			Gizmos.DrawRay(((Component)target).transform.position, Vector3.up);
			Gizmos.color = Color.green;
			Vector3 val2 = 0.2f * Vector3.up;
			for (int i = 1; i < val.corners.Length; i++)
			{
				Gizmos.DrawLine(val.corners[i - 1] + val2, val.corners[i] + val2);
			}
		}
	}
}
