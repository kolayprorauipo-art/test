using System;
using UnityEngine;

[Serializable]
public class stopRopeTrigger : MonoBehaviour
{
	public GameObject vevaHolder;

	public GameObject vev;

	public GameObject vevButton;

	public GameObject brunnsLjud;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "stoprope")
		{
			((playerVevar)(object)vevaHolder.GetComponent(typeof(playerVevar))).noMoreVev = true;
			((playerVevar)(object)vevaHolder.GetComponent(typeof(playerVevar))).playerHoldButton = false;
			vev.gameObject.tag = "Untagged";
			vevButton.SetActive(false);
			((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
		}
	}
}
