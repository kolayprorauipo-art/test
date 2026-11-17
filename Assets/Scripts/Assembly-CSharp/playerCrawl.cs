using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class playerCrawl : MonoBehaviour
{
	public GameObject player;

	public GameObject playerHead;

	public GameObject grannyParent;

	public GameObject granny;

	public GameObject soundHolder;

	public bool PlayerHukarSig;

	public Sprite standTexture;

	public Sprite crouchTexture;

	public Image button;

	public Button btn1;

	public bool ratSpeedBoost;

	public GameObject GameController;

	public bool Anomaly29SpeedUp;

	public bool Anomaly29SlowDown;

	public bool Anomaly12Buff;

	public InventoryController inventoryController;

	public float SpeedStandUp;

	public float SpeedCrouch;

	public virtual void Start()
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		GameController = GameObject.Find("GameController");
		inventoryController = GameObject.Find("GameController").GetComponent<InventoryController>();
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 6 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
		{
			player.GetComponent<CharacterController>().height = 1.8f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = true;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.016f, 0f);
			PlayerHukarSig = true;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
			button.sprite = crouchTexture;
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 3 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 12 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 12f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 3)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 7.5f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 12)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 7.5f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
			Anomaly12Buff = true;
		}
		SpeedCrouch = 3f;
		SpeedStandUp = 6f;
	}

	public void PressCrouchStandUp()
	{
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerHukarSig && !ratSpeedBoost)
		{
			if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 3 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 12 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24)
			{
				player.GetComponent<CharacterController>().height = 1.8f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = true;
				((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.016f, 0f);
				PlayerHukarSig = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
				button.sprite = crouchTexture;
			}
			else if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 50)
			{
				player.GetComponent<CharacterController>().height = 1f;
				player.GetComponent<CharacterController>().center = new Vector3(0f, 0.35f, 0f);
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = true;
				((Component)playerHead.transform).transform.localPosition = new Vector3(0f, -0.57f, 0f);
				PlayerHukarSig = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
				button.sprite = crouchTexture;
			}
			else if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 3)
			{
				player.GetComponent<CharacterController>().height = 1.8f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3.75f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = true;
				((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.016f, 0f);
				PlayerHukarSig = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
				button.sprite = crouchTexture;
			}
			else
			{
				player.GetComponent<CharacterController>().height = 1.8f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = true;
				((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.016f, 0f);
				PlayerHukarSig = true;
				((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).hukarSig();
				button.sprite = crouchTexture;
			}
		}
		else if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 3 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 12 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 12f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).standUp();
			button.sprite = standTexture;
		}
		else if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 6 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).standUp();
			button.sprite = standTexture;
		}
		else if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 3)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 7.5f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).standUp();
			button.sprite = standTexture;
		}
		else
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			player.GetComponent<CharacterController>().center = new Vector3(0f, 1.18f, 0f);
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			((soundEffects)(object)soundHolder.GetComponent(typeof(soundEffects))).standUp();
			button.sprite = standTexture;
		}
		if (PlayerHukarSig)
		{
			button.sprite = crouchTexture;
		}
		else
		{
			button.sprite = standTexture;
		}
	}

	public virtual void standUp()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		player.GetComponent<CharacterController>().height = 2.76f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
		((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
		PlayerHukarSig = false;
		button.sprite = standTexture;
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 3 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 12 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 12f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 6 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 6)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
		}
		if (((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).PrimeAnomalyNR == 3)
		{
			player.GetComponent<CharacterController>().height = 2.76f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 7.5f;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).playerCrouch = false;
			((Component)playerHead.transform).transform.localPosition = new Vector3(0f, 0.786f, 0f);
			PlayerHukarSig = false;
			button.sprite = standTexture;
		}
	}

	public virtual IEnumerator RatSpeedBoost()
	{
		ratSpeedBoost = true;
		standUp();
		((Graphic)button).color = Color.magenta;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 9f;
		yield return (object)new WaitForSeconds(5f);
		ratSpeedBoost = false;
		standUp();
		((Graphic)button).color = Color.white;
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown((KeyCode)99) || Input.GetKeyDown((KeyCode)306))
		{
			PressCrouchStandUp();
		}
		if (GameController.GetComponent<startNewDay>().AnomalyNR == 3 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 12 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 24 || ((startNewDay)(object)GameController.GetComponent(typeof(startNewDay))).AnomalyNR == 38)
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 12f;
			}
		}
		else if (GameController.GetComponent<startNewDay>().AnomalyNR == 6)
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			}
		}
		else if (GameController.GetComponent<startNewDay>().AnomalyNR == 29)
		{
			if (!Anomaly29SlowDown && !Anomaly29SpeedUp)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
				}
			}
			if (Anomaly29SlowDown && Anomaly29SpeedUp)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
				}
			}
			if (Anomaly29SlowDown && !Anomaly29SpeedUp)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 1.2f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 2.4f;
				}
			}
			if (!Anomaly29SlowDown && Anomaly29SpeedUp)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 4.8f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 9.6f;
				}
			}
		}
		else if (GameController.GetComponent<startNewDay>().AnomalyNR == 34)
		{
			if (!inventoryController.haveAvbitare && !inventoryController.haveHammare && !inventoryController.havevas && !inventoryController.havesafeKey && !inventoryController.haveexitKey && !inventoryController.havehanglockKey && !inventoryController.havepadlockCode && !inventoryController.haveweaponKey && !inventoryController.havescrewdriver && !inventoryController.haveplanka && !inventoryController.havebattery && !inventoryController.havevas2 && !inventoryController.haveplayhouseKey && !inventoryController.havemelon && !inventoryController.haveteddy && !inventoryController.havekugg1 && !inventoryController.havekugg2 && !inventoryController.havemessage && !inventoryController.havebrunnsvev && !inventoryController.haveoldShotgun && !inventoryController.havegunDel1 && !inventoryController.havegunDel2 && !inventoryController.havegunDel3 && !inventoryController.havecarKey && !inventoryController.havetopplock && !inventoryController.havecarbattery && !inventoryController.havegascan && !inventoryController.havewrench && !inventoryController.havesparkplug && !inventoryController.havemeat && !inventoryController.havespecialkey && !inventoryController.havebook && !inventoryController.havepepperspray && !inventoryController.haveremote && !inventoryController.havebirdSeed && !inventoryController.havefreezeTrap && !inventoryController.havePicture && !inventoryController.haveStick && !inventoryController.haveLostKey && !inventoryController.haveTVRemote && !inventoryController.haveWire && !inventoryController.haveNightmareVase && !inventoryController.haveBlueKey && !inventoryController.haveDoorUnlock && !inventoryController.haveButtonNewEscape && !inventoryController.haveBoxOfSweets && !inventoryController.haveChocolateKey && !inventoryController.haveRedKey && !inventoryController.haveNightmareBattery && !inventoryController.haveNightmareBook && !inventoryController.haveNightmareCan && !inventoryController.haveNightmareHammer && !inventoryController.haveNightmareMelon && !inventoryController.haveNightmareTrap && !inventoryController.haveNightmareVase && !inventoryController.haveNightmareWeaponKey && !inventoryController.haveNightmareWrench && !inventoryController.haveNightmareRemote)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 4.8f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 9.6f;
				}
				return;
			}
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 2.1f;
				return;
			}
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 4.2f;
		}
		else if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 1)
		{
			if (SpeedStandUp > 6f)
			{
				if (PlayerHukarSig)
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
				}
				else
				{
					((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
				}
			}
			else if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = SpeedCrouch;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = SpeedCrouch;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = SpeedCrouch;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = SpeedStandUp;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = SpeedStandUp;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = SpeedStandUp;
			}
		}
		else if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 3 || (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 12 && Anomaly12Buff))
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3.75f;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 7.5f;
			}
		}
		else if (GameController.GetComponent<startNewDay>().PrimeAnomalyNR == 6)
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
			}
		}
		else if (PlayerPrefs.GetInt("EventChallenge3") == 1)
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = SpeedCrouch;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = SpeedCrouch;
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = SpeedCrouch;
				return;
			}
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = SpeedStandUp;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = SpeedStandUp;
			((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = SpeedStandUp;
		}
		else if (GameController.GetComponent<startNewDay>().AnomalyNR != 26)
		{
			if (PlayerHukarSig)
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 3f;
			}
			else
			{
				((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 6f;
			}
		}
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = ((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed;
		((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = ((FPSControllerNEW)(object)player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed;
	}
}
