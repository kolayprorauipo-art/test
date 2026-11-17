using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
	public Text Volume;

	public Slider SliderVolume;

	public AudioMixer audioMixer;

	private void Start()
	{
		SliderVolume.value = PlayerPrefs.GetFloat("GameVolume");
		Volume.text = "Volume: " + Mathf.Round(PlayerPrefs.GetFloat("GameVolume") * 100f) + "%";
		audioMixer.SetFloat("MasterVolume", 20f * Mathf.Log10(PlayerPrefs.GetFloat("GameVolume")));
	}

	public void ChangeVolume()
	{
		PlayerPrefs.SetFloat("GameVolume", SliderVolume.value);
		Volume.text = "Volume: " + Mathf.Round(SliderVolume.value * 100f) + "%";
		audioMixer.SetFloat("MasterVolume", 20f * Mathf.Log10(SliderVolume.value));
	}
}
