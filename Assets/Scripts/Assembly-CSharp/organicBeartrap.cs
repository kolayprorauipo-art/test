using System.Collections;
using UnityEngine;

public class organicBeartrap : MonoBehaviour
{
	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(StartAnim());
	}

	private IEnumerator StartAnim()
	{
		yield return (object)new WaitForSeconds(2f);
		((Component)this).gameObject.GetComponent<Animation>().Play("BeartrapLive");
	}

	public virtual void Update()
	{
		if (((BearTrap)(object)((Component)this).gameObject.GetComponent(typeof(BearTrap))).beartrapOn)
		{
			((Component)this).gameObject.GetComponent<Animation>().Stop("BeartrapLive");
		}
	}
}
