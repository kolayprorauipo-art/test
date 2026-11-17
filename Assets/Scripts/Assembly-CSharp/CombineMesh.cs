using System;
using UnityEngine;

[Serializable]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CombineMesh : MonoBehaviour
{
	public virtual void Start()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		MeshFilter[] componentsInChildren = ((Component)this).GetComponentsInChildren<MeshFilter>();
		CombineInstance[] array = new CombineInstance[componentsInChildren.Length];
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			array[i].mesh = componentsInChildren[i].sharedMesh;
			array[i].transform = ((Component)componentsInChildren[i]).transform.localToWorldMatrix;
			((Component)componentsInChildren[i]).gameObject.SetActive(false);
		}
		((MeshFilter)((Component)((Component)this).transform).GetComponent(typeof(MeshFilter))).mesh = new Mesh();
		((MeshFilter)((Component)((Component)this).transform).GetComponent(typeof(MeshFilter))).mesh.CombineMeshes(array);
		((Component)this).transform.localPosition = new Vector3(0f, 0f, 0f);
		((Component)this).gameObject.AddComponent(typeof(MeshCollider));
		((Component)((Component)this).transform).gameObject.SetActive(true);
	}
}
