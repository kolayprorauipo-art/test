using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class splashScreenStart : MonoBehaviour
{
	public AudioClip sound;

	public AudioClip sound2;

	public Sprite dvloperVanlig;

	public Sprite dvloperUtsmetad;

	public Image dvloper;

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(readyToStart());
	}

	public virtual IEnumerator readyToStart()
	{
		SceneManager.LoadScene("Scene 1");
		yield return (object)new WaitForSeconds(5f);
	}
}
