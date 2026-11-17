using System;
using UnityEngine;

[Serializable]
public class vevaBrunnsVev : MonoBehaviour
{
	public GameObject brunnsVevScriptHolder;

	public GameObject brunnsLjud;

	public bool isDown;

	public virtual void Start()
	{
	}

	public void Update()
	{
		if (Input.GetKey((KeyCode)102))
		{
			((playerVevar)(object)brunnsVevScriptHolder.GetComponent(typeof(playerVevar))).playerHoldButton = true;
			return;
		}
		((playerVevar)(object)brunnsVevScriptHolder.GetComponent(typeof(playerVevar))).playerHoldButton = false;
		((vevarBrunnLjud)(object)brunnsLjud.GetComponent(typeof(vevarBrunnLjud))).PlayerVevar = false;
	}
}
