using UnityEngine;
using UnityEngine.UI;

public class TipText : MonoBehaviour
{
	public int randomText;

	public int TipType;

	public float timer;

	public bool textchanged;

	public void Start()
	{
		ChangeText();
	}

	public void Update()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		timer += Time.deltaTime;
		if (timer > 9f && timer < 10f)
		{
			((Graphic)((Component)this).GetComponent<Text>()).color = new Color(1f, 1f, 1f, 10f - timer);
		}
		if (timer > 10f && !textchanged)
		{
			textchanged = true;
			ChangeText();
		}
		if (timer > 11f)
		{
			((Graphic)((Component)this).GetComponent<Text>()).color = new Color(1f, 1f, 1f, 1f - (12f - timer));
		}
		if (timer > 12f)
		{
			timer = 0f;
			textchanged = false;
		}
	}

	public void ChangeText()
	{
		randomText = Random.Range(1, 65);
		if (randomText == 1)
		{
			((Component)this).GetComponent<Text>().text = "You should wait for Granny 4 with time machine escape...";
		}
		else if (randomText == 2)
		{
			((Component)this).GetComponent<Text>().text = "It's impossible to find the book on preset 7. Granny hid it well";
		}
		else if (randomText == 3)
		{
			((Component)this).GetComponent<Text>().text = "Granny always places some item in the microwave";
		}
		else if (randomText == 4)
		{
			((Component)this).GetComponent<Text>().text = "Relax, a Giant Spider isn't here";
		}
		else if (randomText == 5)
		{
			((Component)this).GetComponent<Text>().text = "There is a small chance that there will be something in your bedroom's drawer";
		}
		else if (randomText == 6)
		{
			((Component)this).GetComponent<Text>().text = "Thank you for downloading this mod!";
		}
		else if (randomText == 7)
		{
			((Component)this).GetComponent<Text>().text = "I hope you enjoy playing this mod";
		}
		else if (randomText == 8)
		{
			((Component)this).GetComponent<Text>().text = "It's better to memorize where all the creaking floors are";
		}
		else if (randomText == 9)
		{
			((Component)this).GetComponent<Text>().text = "Cruel + Nightmare theme + Preset 3 + Unlock all escape routes + Without killing + Anomaly 4 + Only 1 day = DEATH CHALLENGE";
		}
		else if (randomText == 10)
		{
			((Component)this).GetComponent<Text>().text = "There are currently 47 anomalies in the game, but there will be more soon (Like it isn't already too much lol)";
		}
		else if (randomText == 11)
		{
			((Component)this).GetComponent<Text>().text = "Something bad can happen if you pick up Teddy";
		}
		else if (randomText == 12)
		{
			((Component)this).GetComponent<Text>().text = "Bonus day is gone forever (nobody cares)";
		}
		else if (randomText == 13)
		{
			((Component)this).GetComponent<Text>().text = "One day Granny will get a vegan spider, and it will eat grass and not bother anyone";
		}
		else if (randomText == 14)
		{
			((Component)this).GetComponent<Text>().text = "There is a picture that you can pick up and even use to escape!";
		}
		else if (randomText == 15)
		{
			((Component)this).GetComponent<Text>().text = "Are you brave enough to complete each anomaly on Cruel difficulty?";
		}
		else if (randomText == 16)
		{
			((Component)this).GetComponent<Text>().text = "You can choose: door escape, car escape or something else";
		}
		else if (randomText == 17)
		{
			((Component)this).GetComponent<Text>().text = "Metal stick is the best friend of wooden stick";
		}
		else if (randomText == 18)
		{
			((Component)this).GetComponent<Text>().text = "You can watch TV. It can show many interesting things";
		}
		else if (randomText == 19)
		{
			((Component)this).GetComponent<Text>().text = "What is your favorite anomaly?";
		}
		else if (randomText == 19)
		{
			((Component)this).GetComponent<Text>().text = "Remote control is an overpowered item";
		}
		else if (randomText == 20)
		{
			((Component)this).GetComponent<Text>().text = "Cruel + Anomaly 1 = The most easiest thing in the world (according to GGGamer!!!)";
		}
		else if (randomText == 21)
		{
			((Component)this).GetComponent<Text>().text = "The evil chair's name is Stool";
		}
		else if (randomText == 22)
		{
			((Component)this).GetComponent<Text>().text = "There will be no mods by me for Granny 1.8";
		}
		else if (randomText == 23)
		{
			((Component)this).GetComponent<Text>().text = "If you encounter any bugs, please contact the developer on the discord server";
		}
		else if (randomText == 24)
		{
			((Component)this).GetComponent<Text>().text = "There are some secrets...";
		}
		else if (randomText == 25)
		{
			((Component)this).GetComponent<Text>().text = "«Door unlock» is the biggest enemy of door lock";
		}
		else if (randomText == 26)
		{
			((Component)this).GetComponent<Text>().text = "If you encounter any bugs, please contact the developer on the discord server";
		}
		else if (randomText == 27)
		{
			((Component)this).GetComponent<Text>().text = "Anomaly mode is very underrated";
		}
		else if (randomText == 28)
		{
			((Component)this).GetComponent<Text>().text = "Prime is possible";
		}
		else if (randomText == 29)
		{
			((Component)this).GetComponent<Text>().text = "Challenge: complete the anomaly 18 in less than a minute";
		}
		else if (randomText == 30)
		{
			((Component)this).GetComponent<Text>().text = "Some anomalies completely change the game";
		}
		else if (randomText == 31)
		{
			((Component)this).GetComponent<Text>().text = "Join our Discord server!";
		}
		else if (randomText == 32)
		{
			((Component)this).GetComponent<Text>().text = "White fog is awesome";
		}
		else if (randomText == 33)
		{
			((Component)this).GetComponent<Text>().text = "Prime is harder than Easy (SHOCKING FACT!!!)";
		}
		else if (randomText == 34)
		{
			((Component)this).GetComponent<Text>().text = "Thanks for 350k downloads! You are the best!";
		}
		else if (randomText == 35)
		{
			((Component)this).GetComponent<Text>().text = "Thanks for 350k downloads! You are the best!";
		}
		else if (randomText == 36)
		{
			((Component)this).GetComponent<Text>().text = "If you are a beginner, play without anomalies first";
		}
		else if (randomText == 37)
		{
			((Component)this).GetComponent<Text>().text = "Around 40 people have completed Prime. Maybe there will be more in the future";
		}
		else if (randomText == 38)
		{
			((Component)this).GetComponent<Text>().text = "Nerfed Prime is a thing";
		}
		else if (randomText == 39)
		{
			((Component)this).GetComponent<Text>().text = "Can you beat all anomalies on Prime?";
		}
		else if (randomText == 40)
		{
			((Component)this).GetComponent<Text>().text = "Granny doesn't set bear traps in this mod to make the game expirience more enjoyable";
		}
		else if (randomText == 41)
		{
			((Component)this).GetComponent<Text>().text = "Prime+ is only for the strongest people";
		}
		else if (randomText == 42)
		{
			((Component)this).GetComponent<Text>().text = "In Prime difficulties Granny loves camping people while they are under bed";
		}
		else if (randomText == 43)
		{
			((Component)this).GetComponent<Text>().text = "Green key has 16 random spawn places and blue key has only 8";
		}
		else if (randomText == 44)
		{
			((Component)this).GetComponent<Text>().text = "There are the only 5 victors of mobile Prime+";
		}
		else if (randomText == 45)
		{
			((Component)this).GetComponent<Text>().text = "Join the amazing community of the mod in Discord";
		}
		else if (randomText == 46)
		{
			((Component)this).GetComponent<Text>().text = "If you can suggest your ideas in the Discord server";
		}
		else if (randomText == 47)
		{
			((Component)this).GetComponent<Text>().text = "If you find this game a bit scary (and that's totally fine!), you can turn on No Jumpscares option";
		}
		else if (randomText == 48)
		{
			((Component)this).GetComponent<Text>().text = "If you find this game a bit scary (and that's totally fine!), you can turn on No Jumpscares option";
		}
		else if (randomText == 49)
		{
			((Component)this).GetComponent<Text>().text = "You can choose the task you need to do to open the elevator. You don't need to do both";
		}
		else if (randomText == 50)
		{
			((Component)this).GetComponent<Text>().text = "If you are a beginner, play without anomalies first";
		}
		else if (randomText == 51)
		{
			((Component)this).GetComponent<Text>().text = "Can someone add a bossfight to their Granny mod or remake?";
		}
		else if (randomText == 52)
		{
			((Component)this).GetComponent<Text>().text = "In Prime difficulty every small thing matters and there is no room for mistakes";
		}
		else if (randomText == 53)
		{
			((Component)this).GetComponent<Text>().text = "Hiding under tables is so OP, so in this mod you can't do that";
		}
		else if (randomText == 54)
		{
			((Component)this).GetComponent<Text>().text = "If you are a beginner, play without anomalies first";
		}
		else if (randomText == 55)
		{
			((Component)this).GetComponent<Text>().text = "I think we did a pretty job so far";
		}
		else if (randomText == 56)
		{
			((Component)this).GetComponent<Text>().text = "67";
		}
		else if (randomText == 57)
		{
			((Component)this).GetComponent<Text>().text = "Thanks DVloper for such an amazing horror game to mod";
		}
		else if (randomText == 58)
		{
			((Component)this).GetComponent<Text>().text = "Chill is harder than Prime (RH47 proved it)";
		}
		else if (randomText == 59)
		{
			((Component)this).GetComponent<Text>().text = "You must know that Granny is doing aurafarm in the main menu";
		}
		else if (randomText == 60)
		{
			((Component)this).GetComponent<Text>().text = "Yes, box of sweets is not that useful";
		}
		else if (randomText == 61)
		{
			((Component)this).GetComponent<Text>().text = "Tiki tiki tiki tiki";
		}
		else if (randomText == 62)
		{
			((Component)this).GetComponent<Text>().text = "Prime mode is very easy my frenjis";
		}
		else if (randomText == 63)
		{
			((Component)this).GetComponent<Text>().text = "The rats in Abandoned theme are alive, so they would not bite you";
		}
		else if (randomText == 64)
		{
			((Component)this).GetComponent<Text>().text = "Try to break different nightmare walls, maybe you will find something interesting";
		}
	}
}
