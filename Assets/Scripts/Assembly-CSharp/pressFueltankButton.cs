using System;
using UnityEngine;

[Serializable]
public class pressFueltankButton : MonoBehaviour
{
	public GameObject brunnsVevScriptHolder;

	public void Update()
	{
		if (Input.GetKey((KeyCode)102))
		{
			((fillingFuel)(object)brunnsVevScriptHolder.GetComponent(typeof(fillingFuel))).playerHoldButton = true;
		}
		else
		{
			((fillingFuel)(object)brunnsVevScriptHolder.GetComponent(typeof(fillingFuel))).playerHoldButton = false;
		}
	}
}
