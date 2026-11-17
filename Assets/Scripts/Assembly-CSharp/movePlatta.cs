using System;
using UnityEngine;

[Serializable]
public class movePlatta : MonoBehaviour
{
	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		for (int i = 0; i < Input.touchCount; i++)
		{
			Touch touch = Input.GetTouch(i);
			if ((int)touch.phase == 0)
			{
				Camera main = Camera.main;
				touch = Input.GetTouch(i);
				if (Physics.Raycast(main.ScreenPointToRay(Vector2.op_Implicit(touch.position)), ref val, 8f) && ((Component)val.collider).gameObject.tag == "platta")
				{
					((plattaflyttas)(object)((Component)val.collider).gameObject.GetComponent(typeof(plattaflyttas))).MovePlatta();
					Debug.Log((object)"Moving platta");
				}
			}
		}
	}
}
