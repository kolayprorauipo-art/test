using UnityEngine;

public class Anomaly37SeeGranny : MonoBehaviour
{
	public GameObject Player;

	public GameObject Granny;

	public bool killPlayer;

	private void Update()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		GameObject[] array = GameObject.FindGameObjectsWithTag("granny");
		RaycastHit val4 = default;
		foreach (GameObject val in array)
		{
			Vector3 val2 = val.transform.position - ((Component)this).transform.position;
			Ray val3 = new Ray(((Component)this).transform.position, val2.normalized);
			if (!(Vector3.Dot(((Component)this).transform.forward, val2.normalized) <= 0f) && !(Vector3.Angle(((Component)this).transform.forward, val2) > ((Component)this).GetComponent<Camera>().fieldOfView) && Physics.Raycast(val3, ref val4) && (Object)(object)val4.transform == (Object)(object)val.transform && !killPlayer)
			{
				killPlayer = true;
				((MonoBehaviour)this).StartCoroutine(((playerCaught)(object)Player.GetComponent(typeof(playerCaught))).fallingDead());
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught = true;
				((EnemyAIGranny)(object)Granny.GetComponent(typeof(EnemyAIGranny))).playerFallDeath = true;
				((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).forwardSpeed = 0f;
				((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).sidestepSpeed = 0f;
				((FPSControllerNEW)(object)Player.GetComponent(typeof(FPSControllerNEW))).backwardSpeed = 0f;
				Player.GetComponent<FPSControllerNEW>().soundHolder.GetComponent<soundEffects>().playerLandSound();
			}
		}
	}
}
