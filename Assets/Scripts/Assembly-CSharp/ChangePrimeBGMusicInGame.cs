using UnityEngine;

public class ChangePrimeBGMusicInGame : MonoBehaviour
{
	public GameObject Prime2;

	public GameObject Prime3;

	private void Start()
	{
		if (PlayerPrefs.GetInt("DiffData") == 7)
		{
			if (PlayerPrefs.GetInt("PrimeMusic") == 2)
			{
				((Behaviour)((Component)this).gameObject.GetComponent<AudioSource>()).enabled = false;
				Prime2.SetActive(true);
			}
			if (PlayerPrefs.GetInt("PrimeMusic") == 3)
			{
				((Behaviour)((Component)this).gameObject.GetComponent<AudioSource>()).enabled = false;
				Prime3.SetActive(true);
			}
		}
	}
}
