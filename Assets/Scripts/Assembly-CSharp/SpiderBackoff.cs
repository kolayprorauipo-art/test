using UnityEngine;

public class SpiderBackoff : MonoBehaviour
{
	public GameObject Spider;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Spider")
		{
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderResetNow = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).spiderBackoff = true;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).foodTime = false;
			((spiderControll)(object)Spider.GetComponent(typeof(spiderControll))).idle();
			((Component)this).gameObject.SetActive(false);
		}
	}
}
