using UnityEngine;

public class Anomaly31Gift : MonoBehaviour
{
	private string[] possibleTagsAndNames = new string[42]
	{
		"vas", "vas2", "hammer", "hanglockkey", "exitkey", "avbitare", "safekey", "weaponkey", "screwdriver", "plankawalk",
		"battery", "kugg1", "kugg2", "melon", "playhousekey", "book", "specialkey", "meat", "wrench", "gascan",
		"carbattery", "topplock", "sparkplug", "dpadlockCode", "brunnsvevpickup", "shotgunp1", "shotgunp2", "shotgunp3", "carkey", "remotecontrol",
		"birdseed", "vitrindoorLclosed", "vitrindoorLopen", "vitrindoorRopen", "spak", "vitrindoorRclosed", "newBlueKey(Clone)", "newDoorUnlock(Clone)", "newCaramelKey(Clone)", "newChocolateKey(Clone)",
		"newBoxOfSweets(Clone)", "newButtonLiftEscape(Clone)"
	};

	private void Start()
	{
		string text = possibleTagsAndNames[Random.Range(0, possibleTagsAndNames.Length)];
		if (IsTagDefined(text))
		{
			((Component)this).gameObject.tag = text;
			((Object)((Component)this).gameObject).name = "Anomaly31Gift";
		}
		else
		{
			((Component)this).gameObject.tag = "Untagged";
			((Object)((Component)this).gameObject).name = text;
		}
	}

	private bool IsTagDefined(string tag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		try
		{
			Object.Destroy((Object)new GameObject
			{
				tag = tag
			});
			return true;
		}
		catch
		{
			return false;
		}
	}
}
