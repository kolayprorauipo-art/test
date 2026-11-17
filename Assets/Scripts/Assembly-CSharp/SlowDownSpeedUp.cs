using System.Collections;
using UnityEngine;

public class SlowDownSpeedUp : MonoBehaviour
{
	public GameObject GameController;

	public bool SpeedUp;

	public bool playerIn;

	public GameObject CrouchController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
		CrouchController = ((Component)GameObject.Find("OHCrouchButtonParent").transform.GetChild(0).GetChild(0)).gameObject;
		int num = Random.Range(1, 3);
		SpeedUp = num == 1;
		((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.shader = Shader.Find("Legacy Shaders/Self-Illumin/VertexLit");
		((MonoBehaviour)this).StartCoroutine(ChangeColor());
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (((Component)other).gameObject.tag == "MainCamera")
		{
			CrouchController.GetComponent<playerCrawl>().Anomaly29SpeedUp = false;
			CrouchController.GetComponent<playerCrawl>().Anomaly29SlowDown = false;
		}
	}

	public virtual IEnumerator ChangeColor()
	{
		while (true)
		{
			SpeedUp = !SpeedUp;
			if (SpeedUp)
			{
				((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.cyan;
			}
			else
			{
				((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = new Color(1f, 0.5f, 0f);
			}
			yield return (object)new WaitForSeconds(Random.Range(15f, 60f));
		}
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (((Component)other).gameObject.tag == "MainCamera")
		{
			if (SpeedUp)
			{
				CrouchController.GetComponent<playerCrawl>().Anomaly29SpeedUp = true;
				CrouchController.GetComponent<playerCrawl>().Anomaly29SlowDown = false;
			}
			else
			{
				CrouchController.GetComponent<playerCrawl>().Anomaly29SpeedUp = false;
				CrouchController.GetComponent<playerCrawl>().Anomaly29SlowDown = true;
			}
		}
	}
}
