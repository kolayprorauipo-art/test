using UnityEngine;

public class NightmareBattery : MonoBehaviour
{
	public GameObject gameController;

	public GameObject pickUp;

	private void Start()
	{
		gameController = GameObject.Find("GameController");
		pickUp = GameObject.Find("PickUp");
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		if (((Component)other).gameObject.tag == "plankavind")
		{
			((Rigidbody)((Component)other).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Component)other).gameObject.tag = "plankawalk";
			pickUp.GetComponent<AudioSource>().PlayOneShot(pickUp.GetComponent<PickUp>().taBortPlanka);
		}
		if (((Component)other).gameObject.tag == "planka")
		{
			if (((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort)
			{
				Object.Destroy((Object)(HingeJoint)((Component)other).gameObject.GetComponent(typeof(HingeJoint)));
				((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka2Bort = true;
				pickUp.GetComponent<AudioSource>().PlayOneShot(pickUp.GetComponent<PickUp>().taBortPlanka);
				((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter = ((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).counter + 1f;
				((Component)other).gameObject.tag = "Untagged";
				return;
			}
			((Rigidbody)((Component)other).gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((CheckExitDoor)(object)gameController.GetComponent(typeof(CheckExitDoor))).planka1Bort = true;
			pickUp.GetComponent<AudioSource>().PlayOneShot(pickUp.GetComponent<PickUp>().taBortPlanka);
		}
		if (((Object)((Component)other).gameObject).name == "PlankaOH2")
		{
			((Rigidbody)((Component)other).gameObject.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Object)((Component)other).gameObject).name = "PlankBroken";
			((Component)other).gameObject.transform.rotation = Quaternion.Euler(5f, 90f, 0f);
			pickUp.GetComponent<AudioSource>().PlayOneShot(pickUp.GetComponent<PickUp>().taBortPlanka);
			((MonoBehaviour)this).StartCoroutine(pickUp.GetComponent<PickUp>().PlankaDisappear(((Component)other).gameObject));
		}
	}
}
