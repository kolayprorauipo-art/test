using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene4 : MonoBehaviour
{
	public GameObject AdsController;

	public GameObject Granny;

	public GameObject vindSound;

	public AudioClip smack;

	public AudioClip GrannySound;

	public AudioClip playerLand;

	public Image blackScreenTexture;

	public GameObject gameOverText;

	public Image gameOverTexture;

	public GameObject Beartrap;

	public GameObject BeartrapNM;

	public virtual IEnumerator Start()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			BeartrapNM.SetActive(true);
		}
		else
		{
			Beartrap.SetActive(true);
		}
		Granny.GetComponent<Animation>().CrossFade("GrannyPush");
		yield return (object)new WaitForSeconds(15f);
		AudioSource.PlayClipAtPoint(GrannySound, ((Component)this).transform.position);
		yield return (object)new WaitForSeconds(10.5f);
		AudioSource.PlayClipAtPoint(smack, ((Component)this).transform.position);
		yield return (object)new WaitForSeconds(2.5f);
		((Graphic)blackScreenTexture).CrossFadeAlpha(1f, 0.02f, false);
		gameOverText.SetActive(true);
		vindSound.SetActive(false);
		AudioSource.PlayClipAtPoint(playerLand, ((Component)this).transform.position);
		yield return (object)new WaitForSeconds(4f);
		((Graphic)gameOverTexture).CrossFadeAlpha(0f, 2.2f, false);
		yield return (object)new WaitForSeconds(3f);
		((FetchAds)(object)AdsController.GetComponent(typeof(FetchAds))).toMainMenu();
	}
}
