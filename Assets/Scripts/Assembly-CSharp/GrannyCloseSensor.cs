using UnityEngine;

public class GrannyCloseSensor : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEye;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (((Component)other).gameObject.tag == "Player")
		{
			granny.gameObject.GetComponent<Collider>().enabled = true;
			((Behaviour)(EnemyEye)(object)grannyEye.GetComponent(typeof(EnemyEye))).enabled = true;
			((EnemyAIGranny)(object)granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = false;
			((Component)this).gameObject.SetActive(false);
		}
	}
}
