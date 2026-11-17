using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class furnitureControlls : MonoBehaviour
{
	public GameObject bordVR;

	public Transform bordVRPos;

	public GameObject lampaVR;

	public Transform lampaVRPos;

	public GameObject TavlaVR;

	public Transform TavlaVRPos;

	public GameObject TavlaRumBV;

	public Transform TavlaRumBVPos;

	public GameObject LampaRumBV;

	public Transform LampaRumBVPos;

	public GameObject LjusstakeHall;

	public Transform LjusstakeHallPos;

	public GameObject LjusstakeHall2;

	public Transform LjusstakeHallPos2;

	public GameObject LjusstakeCellar;

	public Transform LjusstakeCellarPos;

	public GameObject LitenTavla1;

	public Transform LitenTavla1Pos;

	public GameObject LitenTavla2;

	public Transform LitenTavla2Pos;

	public GameObject LitenTavla3;

	public Transform LitenTavla3Pos;

	public GameObject TavlaSR1;

	public Transform TavlaSR1Pos;

	public GameObject ChairSR1;

	public Transform ChairSR1Pos;

	public GameObject Galge;

	public Transform GalgePos;

	public GameObject LampaSR2;

	public Transform LampaSR2Pos;

	public GameObject LitetBordSR3;

	public Transform LitetBordSR3Pos;

	public GameObject TavlaSR3;

	public Transform TavlaSR3Pos;

	public GameObject TavlaKitchen;

	public Transform TavlaKitchenPos;

	public GameObject Tallrik1;

	public Transform Tallrik1Pos;

	public GameObject Tallrik2;

	public Transform Tallrik2Pos;

	public GameObject Tallrik3;

	public Transform Tallrik3Pos;

	public GameObject GallerDoor;

	public Transform GallerDoorPos;

	public GameObject WoodenBox;

	public Transform WoodenBoxPos;

	public GameObject Pedistal;

	public Transform PedistalPos;

	public GameObject Manikin;

	public Transform ManikinPos;

	public GameObject BurkOH;

	public Transform BurkOHPos;

	public GameObject TavlaOH;

	public Transform TavlaOHPos;

	public virtual IEnumerator cleanUp()
	{
		if (Object.op_Implicit((Object)(object)GameObject.Find("LitetBordVR(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LitetBordVR(Clone)"));
			if (((Component)this).gameObject.GetComponent<startNewDay>().AnomalyNR == 18)
			{
				Object.Instantiate<GameObject>(bordVR, new Vector3(-2.01f, 13.345f, -10.269998f), bordVRPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("LitetBordVR(Clone)").transform).name = "LitetBordVR";
			}
			else
			{
				Object.Instantiate<GameObject>(bordVR, bordVRPos.position, bordVRPos.rotation);
				yield return (object)new WaitForSeconds(0.5f);
				((Object)GameObject.Find("LitetBordVR(Clone)").transform).name = "LitetBordVR";
			}
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LampaVR(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LampaVR(Clone)"));
			Object.Instantiate<GameObject>(lampaVR, lampaVRPos.position, lampaVRPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LampaVR(Clone)").transform).name = "LampaVR";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("TavlaVR(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TavlaVR(Clone)"));
			Object.Instantiate<GameObject>(TavlaVR, TavlaVRPos.position, TavlaVRPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("TavlaVR(Clone)").transform).name = "TavlaVR";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("RumBVTavla(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("RumBVTavla(Clone)"));
			Object.Instantiate<GameObject>(TavlaRumBV, TavlaRumBVPos.position, TavlaRumBVPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("RumBVTavla(Clone)").transform).name = "RumBVTavla";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("RumBVLampa(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("RumBVLampa(Clone)"));
			Object.Instantiate<GameObject>(LampaRumBV, LampaRumBVPos.position, LampaRumBVPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("RumBVLampa(Clone)").transform).name = "RumBVLampa";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LjusstakeHall(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LjusstakeHall(Clone)"));
			Object.Instantiate<GameObject>(LjusstakeHall, LjusstakeHallPos.position, LjusstakeHallPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LjusstakeHall(Clone)").transform).name = "LjusstakeHall";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LjusstakeHall2(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LjusstakeHall2(Clone)"));
			Object.Instantiate<GameObject>(LjusstakeHall2, LjusstakeHallPos2.position, LjusstakeHallPos2.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LjusstakeHall2(Clone)").transform).name = "LjusstakeHall2";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LjusstakeCellar(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LjusstakeCellar(Clone)"));
			Object.Instantiate<GameObject>(LjusstakeCellar, LjusstakeCellarPos.position, LjusstakeCellarPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LjusstakeCellar(Clone)").transform).name = "LjusstakeCellar";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LitenTavla1(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LitenTavla1(Clone)"));
			Object.Instantiate<GameObject>(LitenTavla1, LitenTavla1Pos.position, LitenTavla1Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LitenTavla1(Clone)").transform).name = "LitenTavla1";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LitenTavla2(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LitenTavla2(Clone)"));
			Object.Instantiate<GameObject>(LitenTavla2, LitenTavla2Pos.position, LitenTavla2Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LitenTavla2(Clone)").transform).name = "LitenTavla2";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LitenTavla3(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LitenTavla3(Clone)"));
			Object.Instantiate<GameObject>(LitenTavla3, LitenTavla3Pos.position, LitenTavla3Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LitenTavla3(Clone)").transform).name = "LitenTavla3";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("TavlaSR1(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TavlaSR1(Clone)"));
			Object.Instantiate<GameObject>(TavlaSR1, TavlaSR1Pos.position, TavlaSR1Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("TavlaSR1(Clone)").transform).name = "TavlaSR1";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ChairSR1(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("ChairSR1(Clone)"));
			Object.Instantiate<GameObject>(ChairSR1, ChairSR1Pos.position, ChairSR1Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("ChairSR1(Clone)").transform).name = "ChairSR1";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("Galge(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("Galge(Clone)"));
			Object.Instantiate<GameObject>(Galge, GalgePos.position, GalgePos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("Galge(Clone)").transform).name = "Galge";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LampaSR2(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LampaSR2(Clone)"));
			Object.Instantiate<GameObject>(LampaSR2, LampaSR2Pos.position, LampaSR2Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LampaSR2(Clone)").transform).name = "LampaSR2";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("LitetBordSR3(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("LitetBordSR3(Clone)"));
			Object.Instantiate<GameObject>(LitetBordSR3, LitetBordSR3Pos.position, LitetBordSR3Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("LitetBordSR3(Clone)").transform).name = "LitetBordSR3";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("TavlaSR3(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TavlaSR3(Clone)"));
			Object.Instantiate<GameObject>(TavlaSR3, TavlaSR3Pos.position, TavlaSR3Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("TavlaSR3(Clone)").transform).name = "TavlaSR3";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("TavlaKitchen(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("TavlaKitchen(Clone)"));
			Object.Instantiate<GameObject>(TavlaKitchen, TavlaKitchenPos.position, TavlaKitchenPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("TavlaKitchen(Clone)").transform).name = "TavlaKitchen";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("Tallrik1(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("Tallrik1(Clone)"));
			Object.Instantiate<GameObject>(Tallrik1, Tallrik1Pos.position, Tallrik1Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("Tallrik1(Clone)").transform).name = "Tallrik1";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("Tallrik2(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("Tallrik2(Clone)"));
			Object.Instantiate<GameObject>(Tallrik2, Tallrik2Pos.position, Tallrik2Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("Tallrik2(Clone)").transform).name = "Tallrik2";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("Tallrik3(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("Tallrik3(Clone)"));
			Object.Instantiate<GameObject>(Tallrik3, Tallrik3Pos.position, Tallrik3Pos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("Tallrik3(Clone)").transform).name = "Tallrik3";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("GallerDoor(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("GallerDoor(Clone)"));
			Object.Instantiate<GameObject>(GallerDoor, GallerDoorPos.position, GallerDoorPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("GallerDoor(Clone)").transform).name = "GallerDoor";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("WoodenBox(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("WoodenBox(Clone)"));
			Object.Instantiate<GameObject>(WoodenBox, WoodenBoxPos.position, WoodenBoxPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("WoodenBox(Clone)").transform).name = "WoodenBox";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("Pedistal(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("Pedistal(Clone)"));
			Object.Instantiate<GameObject>(Pedistal, PedistalPos.position, PedistalPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("Pedistal(Clone)").transform).name = "Pedistal";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("ManikinDoll(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("ManikinDoll(Clone)"));
			Object.Instantiate<GameObject>(Manikin, ManikinPos.position, ManikinPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("ManikinDoll(Clone)").transform).name = "ManikinDoll";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("MetalCanOuthouse(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("MetalCanOuthouse(Clone)"));
			Object.Instantiate<GameObject>(BurkOH, BurkOHPos.position, BurkOHPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("MetalCanOuthouse(Clone)").transform).name = "MetalCanOuthouse";
		}
		if (Object.op_Implicit((Object)(object)GameObject.Find("OldHouseTavla(Clone)")))
		{
			Object.Destroy((Object)(object)GameObject.Find("OldHouseTavla(Clone)"));
			Object.Instantiate<GameObject>(TavlaOH, TavlaOHPos.position, TavlaOHPos.rotation);
			yield return (object)new WaitForSeconds(0.5f);
			((Object)GameObject.Find("OldHouseTavla(Clone)").transform).name = "OldHouseTavla";
		}
	}
}
