using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FreezeGrannyButton : MonoBehaviour
{
	public GameObject soundHolder;

	public bool buttonClicked;

	public Button btn1;

	public GameObject Granny;

	public virtual void Start()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		btn1 = ((Component)this).gameObject.GetComponent<Button>();
		((UnityEvent)btn1.onClick).AddListener((UnityAction)TaskOnClick);
	}

	private void TaskOnClick()
	{
		if (PlayerPrefs.GetInt("PrimeOn") == 0)
		{
			Granny.GetComponent<EnemyAIGranny>().GrannyTrainingStop = !Granny.GetComponent<EnemyAIGranny>().GrannyTrainingStop;
		}
	}
}
