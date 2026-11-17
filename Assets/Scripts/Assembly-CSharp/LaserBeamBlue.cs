using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserBeamBlue : MonoBehaviour
{
	private LineRenderer lr;

	private Light hitLight;

	public bool PrimeKill;

	public Vector2 LaserLimits;

	public InventoryController inventoryController;

	public bool haveNothing;

	public GameObject GameController;

	private void Start()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		lr = ((Component)this).GetComponent<LineRenderer>();
		lr.startWidth = 0.05f;
		lr.endWidth = 0.05f;
		((Renderer)lr).material = new Material(Shader.Find("Legacy Shaders/Self-Illumin/VertexLit"));
		((Renderer)lr).material.color = Color.blue;
		((Renderer)lr).material.SetColor("_Color", Color.blue * 5f);
		lr.positionCount = 2;
		PrimeKill = false;
		inventoryController = GameObject.Find("GameController").GetComponent<InventoryController>();
		GameController = GameObject.Find("GameController");
	}

	private void Update()
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		if (!inventoryController.haveAvbitare && !inventoryController.haveHammare && !inventoryController.havevas && !inventoryController.havesafeKey && !inventoryController.haveexitKey && !inventoryController.havehanglockKey && !inventoryController.havepadlockCode && !inventoryController.haveweaponKey && !inventoryController.havescrewdriver && !inventoryController.haveplanka && !inventoryController.havebattery && !inventoryController.havevas2 && !inventoryController.haveplayhouseKey && !inventoryController.havemelon && !inventoryController.haveteddy && !inventoryController.havekugg1 && !inventoryController.havekugg2 && !inventoryController.havemessage && !inventoryController.havebrunnsvev && !inventoryController.haveoldShotgun && !inventoryController.havegunDel1 && !inventoryController.havegunDel2 && !inventoryController.havegunDel3 && !inventoryController.havecarKey && !inventoryController.havetopplock && !inventoryController.havecarbattery && !inventoryController.havegascan && !inventoryController.havewrench && !inventoryController.havesparkplug && !inventoryController.havemeat && !inventoryController.havespecialkey && !inventoryController.havebook && !inventoryController.havepepperspray && !inventoryController.haveremote && !inventoryController.havebirdSeed && !inventoryController.havefreezeTrap && !inventoryController.havePicture && !inventoryController.haveStick && !inventoryController.haveLostKey && !inventoryController.haveTVRemote && !inventoryController.haveWire && !inventoryController.haveNightmareVase && !inventoryController.haveBlueKey && !inventoryController.haveDoorUnlock && !inventoryController.haveButtonNewEscape && !inventoryController.haveTeleportRemote && !inventoryController.haveDarkKey && !inventoryController.haveChocolateKey && !inventoryController.haveRedKey && !inventoryController.haveBoxOfSweets)
		{
			haveNothing = true;
		}
		else
		{
			haveNothing = false;
		}
		Vector3 position = ((Component)this).gameObject.transform.position;
		Vector3 forward = ((Component)this).gameObject.transform.forward;
		RaycastHit val = default;
		if (haveNothing)
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position);
		}
		else if (Physics.Raycast(position, forward, ref val, 50f))
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, val.point);
			if ((((Component)val.collider).CompareTag("Player") || ((Component)val.collider).CompareTag("MainCamera")) && !GameController.GetComponent<startNewDay>().deadByLaser)
			{
				((MonoBehaviour)this).StartCoroutine(GameController.GetComponent<startNewDay>().VignetteEffect(((Component)this).gameObject, new Color(0f, 0f, 1f, 0f)));
				PrimeKill = true;
			}
		}
		else
		{
			lr.SetPosition(0, position);
			lr.SetPosition(1, position + forward * 50f);
		}
	}

	public void OnDestroy()
	{
	}
}
