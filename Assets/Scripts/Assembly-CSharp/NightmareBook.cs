using UnityEngine;

public class NightmareBook : MonoBehaviour
{
	public GameObject Granny;

	public GameObject Spider;

	public bool NightmareEnergy;

	public GameObject gameController;

	private void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		Spider = GameObject.Find("SpiderParent");
		gameController = GameObject.Find("GameController");
		NightmareEnergy = true;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "grus" || ((Object)((Component)other).gameObject).name == "Lekhus" || ((Object)((Component)other).gameObject).name == "OldHouseWalls")
		{
			NightmareEnergy = false;
		}
		if (((Component)other).gameObject.tag == "Spider" && NightmareEnergy)
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderIsDead();
			AchievementSaveManager.Instance.UnlockAchievement("FourtySevenIQMove");
		}
		if (!(((Component)other).gameObject.tag == "granny") || !NightmareEnergy)
		{
			return;
		}
		if (PlayerPrefs.GetInt("DiffData") != 7)
		{
			NightmareEnergy = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
			((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
			AchievementSaveManager.Instance.UnlockAchievement("ILoveBooks");
			return;
		}
		NightmareEnergy = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).hitByGun = true;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).spiderIsDead = false;
		((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerHaveTeddy = false;
		gameController.GetComponent<startNewDay>().BookAchievementCount++;
		if (gameController.GetComponent<startNewDay>().BookAchievementCount == 15)
		{
			AchievementSaveManager.Instance.UnlockAchievement("StunGunBook");
		}
	}
}
