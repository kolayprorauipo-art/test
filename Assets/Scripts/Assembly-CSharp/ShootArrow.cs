using System;
using UnityEngine;

[Serializable]
public class ShootArrow : MonoBehaviour
{
	public GameObject SeeRay;

	public Rigidbody arrow;

	public Transform bulletSpawn;

	public Transform bulletSpawn2;

	public bool shooting;

	public GameObject shootButton;

	public GameObject gameController;

	public InventoryController InventoryControllerScript;

	public GameObject laddad;

	public GameObject Oladdad;

	public GameObject Arrow;

	public GameObject soundHolder;

	public Vector3 velocity;

	public virtual void Shot()
	{
		shooting = true;
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		Vector3 val2 = SeeRay.transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(SeeRay.transform.position, val2, ref val, 100f) && shooting)
		{
			Vector3 val3;
			if (InventoryControllerScript.haveNightmareCrossbow)
			{
				Rigidbody component = Object.Instantiate<GameObject>(InventoryControllerScript.newNightmareVase, ((Component)bulletSpawn2).transform.position, ((Component)bulletSpawn2).transform.rotation).GetComponent<Rigidbody>();
				val3 = val.point - ((Component)bulletSpawn2).transform.position;
				component.velocity = val3.normalized * 30f;
				component.rotation = Quaternion.LookRotation(component.velocity);
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).CrossbowShoot();
				shooting = false;
				return;
			}
			shooting = false;
			shootButton.SetActive(false);
			laddad.SetActive(false);
			Oladdad.SetActive(true);
			Arrow.SetActive(false);
			InventoryControllerScript.armborstArrowOK = false;
			InventoryControllerScript.haveArrow = false;
			Rigidbody val4 = Object.Instantiate<Rigidbody>(arrow, ((Component)bulletSpawn).transform.position, ((Component)bulletSpawn).transform.rotation);
			val3 = val.point - ((Component)bulletSpawn).transform.position;
			val4.velocity = val3.normalized * 30f;
			val4.rotation = Quaternion.LookRotation(val4.velocity);
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).CrossbowShoot();
		}
	}
}
