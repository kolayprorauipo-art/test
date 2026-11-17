using System;
using UnityEngine;

[Serializable]
public class playerVevar : MonoBehaviour
{
	public int layerMask;

	public bool playerHoldButton;

	public GameObject brunnsVevButton;

	public GameObject doorRay;

	public bool playerTaken;

	public bool playSound;

	public GameObject rope;

	public GameObject winch;

	public bool noMoreVev;

	public bool vevInPlace;

	public GameObject brunnsLjud;

	public GameObject gameController;

	public playerVevar()
	{
		layerMask = 256;
	}

	public virtual void Start()
	{
		layerMask = ~layerMask;
		gameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default;
		if (!vevInPlace || noMoreVev)
		{
			return;
		}
		Vector3 val2 = doorRay.transform.TransformDirection(Vector3.forward);
		if (!playerTaken)
		{
			if (!Physics.Raycast(doorRay.transform.position, val2, ref val, 4f, layerMask))
			{
				brunnsVevButton.SetActive(false);
				playerHoldButton = false;
				((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
			}
			else if (((Component)val.collider).gameObject.tag == "brunnsvev")
			{
				brunnsVevButton.SetActive(true);
				if (!playerHoldButton)
				{
					return;
				}
				((Component)val.collider).gameObject.transform.Rotate(0f, 0f, 100f * Time.deltaTime);
				winch.gameObject.transform.Rotate(0f, 0f, 100f * Time.deltaTime);
				rope.transform.Translate(-Vector3.forward * Time.deltaTime * 0.5f, (Space)1);
				((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = true;
				if (((startNewDay)(object)gameController.GetComponent(typeof(startNewDay))).AnomalyNR == 16)
				{
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).grannyHearObject = true;
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).startTimerSearch = false;
					((EnemyAIGranny)(object)GameObject.Find("GrannyParent").GetComponent(typeof(EnemyAIGranny))).GrannySearching = false;
					if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)")))
					{
						((Object)GameObject.Find("TempNavObjects(Clone)").transform).name = "TempNavObjects(Clone)Old";
						Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
					}
					else if (Object.op_Implicit((Object)(object)GameObject.Find("TempNavObjects(Clone)Old")))
					{
						Object.Destroy((Object)(object)GameObject.Find("TempNavObjects(Clone)Old"));
					}
					else
					{
						Object.Instantiate<Transform>(((GrannyHear)(object)GameObject.Find("Noise16Anomaly").GetComponent(typeof(GrannyHear))).spawnObject, ((Component)val.collider).gameObject.transform.position, ((Component)this).transform.rotation);
					}
				}
			}
			else if (((Component)val.collider).gameObject.tag == "grus")
			{
				brunnsVevButton.SetActive(false);
				playerHoldButton = false;
				((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
			}
			else if (((Component)val.collider).gameObject.tag == "Untagged")
			{
				brunnsVevButton.SetActive(false);
				playerHoldButton = false;
				((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
			}
		}
		else
		{
			brunnsVevButton.SetActive(false);
			playerHoldButton = false;
			((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
		}
	}
}
