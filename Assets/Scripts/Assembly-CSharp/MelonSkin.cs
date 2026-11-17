using UnityEngine;

public class MelonSkin : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 0)
		{
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).enabled = false;
		}
		else if (PlayerPrefs.GetInt("EventChallenge3RewardOnOff") == 1)
		{
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).enabled = true;
		}
	}
}
