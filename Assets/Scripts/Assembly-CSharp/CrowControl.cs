using System.Collections;
using UnityEngine;

public class CrowControl : MonoBehaviour
{
	public GameObject CrowBur;

	public GameObject CrowFlyAnim;

	public GameObject CrowFlyEat;

	public GameObject CrowFlyBack;

	public GameObject CrowEat;

	public GameObject BurDoor;

	public GameObject Seed;

	public GameObject seedPlate;

	public GameObject crowGone;

	public bool burdoorIsOpen;

	public Animator CrowAnimHolder;

	public bool CrowStartEat;

	public bool isFlying;

	public bool isAttacking;

	public bool playerSteal;

	public bool shootInBur;

	public bool crowGetShoot;

	public bool crowNotShotAgain;

	public GameObject GrannyHear;

	public Transform GrannyHearSP;

	public AudioClip crowShootLjud;

	private void Start()
	{
		CrowAnimHolder = ((Component)CrowAnimHolder).gameObject.GetComponent<Animator>();
		CrowAnimHolder.Play("CrowIdle");
	}

	private void Update()
	{
		if (CrowStartEat && !isFlying)
		{
			isFlying = true;
			((MonoBehaviour)this).StartCoroutine(crowStartFly());
		}
		if (playerSteal && !isAttacking && !isFlying)
		{
			isAttacking = true;
			((MonoBehaviour)this).StartCoroutine(crowProtectItem());
		}
		if (shootInBur && !crowGetShoot && !isFlying)
		{
			crowGetShoot = true;
			((MonoBehaviour)this).StartCoroutine(crowStartFlyShoot());
		}
	}

	public virtual IEnumerator crowStartFly()
	{
		if (!burdoorIsOpen)
		{
			burdoorIsOpen = true;
			BurDoor.GetComponent<Animation>().Play("BurDoorOpen");
			BurDoor.gameObject.tag = "Untagged";
		}
		Seed.SetActive(true);
		CrowBur.SetActive(false);
		CrowFlyEat.SetActive(true);
		crowGone.SetActive(false);
		CrowFlyAnim.GetComponent<Animation>().CrossFade("FlyEat");
		yield return (object)new WaitForSeconds(1.1f);
		CrowEat.SetActive(true);
		CrowFlyEat.SetActive(false);
		yield return (object)new WaitForSeconds(3f);
		Seed.SetActive(false);
		yield return (object)new WaitForSeconds(2f);
		CrowEat.SetActive(false);
		CrowFlyBack.SetActive(true);
		CrowFlyAnim.GetComponent<Animation>().CrossFade("CrowFlyBack");
		yield return (object)new WaitForSeconds(1.1f);
		CrowFlyBack.SetActive(false);
		CrowBur.SetActive(true);
		crowGone.SetActive(true);
		CrowAnimHolder.Play("CrowIdle");
		isFlying = false;
		CrowStartEat = false;
		seedPlate.gameObject.tag = "birdseedplate";
	}

	public virtual IEnumerator crowProtectItem()
	{
		CrowAnimHolder.Play("Attack");
		yield return (object)new WaitForSeconds(1.5f);
		CrowAnimHolder.Play("CrowIdle");
		isAttacking = false;
		playerSteal = false;
		Object.Instantiate<GameObject>(GrannyHear, GrannyHearSP.position, GrannyHearSP.rotation);
	}

	public virtual IEnumerator crowStartFlyShoot()
	{
		if (!crowNotShotAgain)
		{
			crowNotShotAgain = true;
			if (!burdoorIsOpen)
			{
				burdoorIsOpen = true;
				BurDoor.GetComponent<Animation>().Play("BurDoorOpen");
				BurDoor.gameObject.tag = "Untagged";
			}
			CrowBur.SetActive(false);
			CrowFlyEat.SetActive(true);
			((Component)this).GetComponent<AudioSource>().PlayOneShot(crowShootLjud, 0.7f);
			CrowFlyAnim.GetComponent<Animation>().CrossFade("crowShootOut");
			yield return (object)new WaitForSeconds(0.3f);
			CrowFlyAnim.GetComponent<Animation>().CrossFade("crowShootIn");
			CrowFlyEat.SetActive(false);
			CrowFlyBack.SetActive(true);
			yield return (object)new WaitForSeconds(0.3f);
			CrowFlyBack.SetActive(false);
			CrowBur.SetActive(true);
			CrowAnimHolder.Play("CrowIdle");
			crowGetShoot = false;
			shootInBur = false;
		}
		else if (crowNotShotAgain)
		{
			((Component)this).GetComponent<AudioSource>().PlayOneShot(crowShootLjud, 0.7f);
			crowGetShoot = false;
			shootInBur = false;
		}
	}
}
