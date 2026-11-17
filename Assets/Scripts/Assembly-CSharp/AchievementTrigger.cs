using UnityEngine;

public class AchievementTrigger : MonoBehaviour
{
	public string Achievement;

	private void OnTriggerEnter(Collider other)
	{
		if (((Component)other).tag == "Player")
		{
			AchievementSaveManager.Instance.UnlockAchievement(Achievement);
		}
	}

	private void Update()
	{
	}
}
