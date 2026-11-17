using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NightmareTrap : MonoBehaviour
{
	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		if (((Component)other).gameObject.tag == "golv" || ((Component)other).gameObject.tag == "grus")
		{
			AchievementSaveManager.Instance.UnlockAchievement("YouShallNotPass");
			((Component)this).gameObject.AddComponent<NavMeshObstacle>().size = new Vector3(0.08f, 0.08f, 0.08f);
			((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<ParticleSystem>().enableEmission = true;
			MainModule main = ((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<ParticleSystem>().main;
			MinMaxGradient startColor = main.startColor;
			if ((int)startColor.mode == 2)
			{
				Color colorMin = startColor.colorMin;
				Color colorMax = startColor.colorMax;
				colorMin = Color.black;
				colorMax = Color.red;
				main.startColor = new MinMaxGradient(colorMin, colorMax);
			}
			((Object)((Component)this).gameObject).name = "NightmareTrapActivated";
			((MonoBehaviour)this).StartCoroutine(timer());
		}
	}

	public virtual IEnumerator timer()
	{
		yield return (object)new WaitForSeconds(60f);
		((Component)((Component)this).gameObject.transform.GetChild(0)).GetComponent<ParticleSystem>().enableEmission = false;
		((Object)((Component)this).gameObject).name = "newNightmareTrap(Clone)";
		((Behaviour)((Component)this).gameObject.GetComponent<NavMeshObstacle>()).enabled = false;
	}
}
