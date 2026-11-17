using UnityEngine;

public class GrannyActiveYellowLaser__0 : MonoBehaviour
{
	public GameObject GameController;

	public virtual void Start()
	{
		GameController = GameObject.Find("GameController");
	}

	public virtual void Update()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (GameController.GetComponent<startNewDay>().activateYellowLaser)
		{
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = Color.gray;
		}
		else
		{
			((Renderer)((Component)this).gameObject.GetComponent<MeshRenderer>()).material.color = new Color(0.58f, 0.58f, 0f);
		}
	}
}
