using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AchievementSaveManager : MonoBehaviour
{
	[Serializable]
	public class AchievementData
	{
		public bool FirstBlood;

		public bool AStrangePlace;

		public bool Freedom;

		public bool TheBrokenElevator;

		public bool FamilyFriendly;

		public bool RageBaitEnding;

		public bool NightmareEscape;

		public bool AbandonedEscape;

		public bool ExtremeBeat;

		public bool ExtremePlusBeat;

		public bool CruelBeat;

		public bool IrrationalCruelBeat;

		public bool NinetySevenIQMove;

		public bool BonusDayEnjoyer;

		public bool Titaniumhead;

		public bool FourtySevenIQMove;

		public bool GotUnluky;

		public bool Fireworks;

		public bool NotASingleScratch;

		public bool HappyRemotesFamily;

		public bool TrulyAHiddenVase;

		public bool GrannyTheUnbreakable;

		public bool MirrorPortal;

		public bool AnomalousAnomaly;

		public bool GreenDoorEscape;

		public bool PoisonSeedEscape;

		public bool AnEasierPath;

		public bool MysteriousLetter;

		public bool TheUtopia;

		public bool TheReality;

		public bool Anomaly45AllMessages;

		public bool AHugeSuccess;

		public bool EveryBegin;

		public bool PrionerOfPrime;

		public bool SoClose;

		public bool DarkestHour;

		public bool Unstoppable;

		public bool VeganActivist;

		public bool VictimCard;

		public bool ShootStool;

		public bool CrouchNextTime;

		public bool StandUpNextTime;

		public bool BaloonParty;

		public bool AuraLoss;

		public bool ThisMadeMeThink;

		public bool StunGunBook;

		public bool SmellOfGasoline;

		public bool UnbelievableStory;

		public bool MyTalkingStool;

		public bool FullOfHope;

		public bool AnomalousPrimeEnjoyer;

		public bool PrimeEnjoyer;

		public bool FourBooks;

		public bool EightBooks;

		public bool LightsOutEscape;

		public bool LightsOutEscapeOneDay;

		public bool BreatheFire;

		public bool IShowSlowness;

		public bool SixSevenAchievement;

		public bool Jackpot;

		public bool GamblingAddicion;

		public bool AnomalyGauntlet;

		public bool ShotGunHater;

		public bool ILoveBooks;

		public bool YouShallNotPass;

		public bool TheBigRedItem;

		public bool BreakRules;

		public bool NerfedPrimeFan;
	}

	public static AchievementSaveManager Instance;

	public Animation AchievementTab;

	public AudioSource AchievementSound;

	public AudioSource HEHEHEHAsoundholder;

	public Text AchievementName;

	public AudioClip AchievementSoundWav;

	public AudioClip HEHEHEHAsound;

	private bool HEHEHEHA;

	private string savePath;

	public AchievementData data = new AchievementData();

	private void Awake()
	{
		if ((Object)(object)Instance == (Object)null)
		{
			Instance = this;
			Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
			savePath = Path.Combine(Application.persistentDataPath, "achievements.dat");
			LoadAchievements();
		}
		else
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
		}
	}

	public void UnlockAchievement(string achievementName)
	{
		if (PlayerPrefs.GetInt("DiffData") == 4 || PlayerPrefs.GetInt("PrimeOn") == 0)
		{
			return;
		}
		bool flag = false;
		switch (achievementName)
		{
		case "AnomalyGauntlet":
			if (!data.AnomalyGauntlet)
			{
				data.AnomalyGauntlet = true;
				flag = true;
				AchievementName.text = "Granny Anomaly Gauntlet by Logan";
			}
			break;
		case "ShotGunHater":
			if (!data.ShotGunHater)
			{
				data.ShotGunHater = true;
				flag = true;
				AchievementName.text = "Crossbow glaser";
			}
			break;
		case "ILoveBooks":
			if (!data.ILoveBooks)
			{
				data.ILoveBooks = true;
				flag = true;
				AchievementName.text = "I love books";
			}
			break;
		case "YouShallNotPass":
			if (!data.YouShallNotPass)
			{
				data.YouShallNotPass = true;
				flag = true;
				AchievementName.text = "You shall not pass!";
			}
			break;
		case "TheBigRedItem":
			if (!data.TheBigRedItem)
			{
				data.TheBigRedItem = true;
				flag = true;
				AchievementName.text = "The big red item";
			}
			break;
		case "BreakRules":
			if (!data.BreakRules)
			{
				data.BreakRules = true;
				flag = true;
				AchievementName.text = "The rules are made to be broken";
			}
			break;
		case "NerfedPrimeFan":
			if (!data.NerfedPrimeFan)
			{
				data.NerfedPrimeFan = true;
				flag = true;
				AchievementName.text = "Nerfed Prime Fan";
			}
			break;
		case "FourBooks":
			if (!data.FourBooks)
			{
				data.FourBooks = true;
				flag = true;
				AchievementName.text = "The full story";
			}
			break;
		case "EightBooks":
			if (!data.EightBooks)
			{
				data.EightBooks = true;
				flag = true;
				AchievementName.text = "Eye Contact";
			}
			break;
		case "LightsOutEscape":
			if (!data.LightsOutEscape)
			{
				data.LightsOutEscape = true;
				flag = true;
				AchievementName.text = "She is behind you...";
			}
			break;
		case "LightsOutEscapeOneDay":
			if (!data.LightsOutEscapeOneDay)
			{
				data.LightsOutEscapeOneDay = true;
				flag = true;
				AchievementName.text = "An arm in a bucket";
			}
			break;
		case "BreatheFire":
			if (!data.BreatheFire)
			{
				data.BreatheFire = true;
				flag = true;
				AchievementName.text = "Th pwr f DrgnLrd";
			}
			break;
		case "IShowSlowness":
			if (!data.IShowSlowness)
			{
				data.IShowSlowness = true;
				flag = true;
				AchievementName.text = "I show slowness";
			}
			break;
		case "SixSevenAchievement":
			if (!data.SixSevenAchievement)
			{
				data.SixSevenAchievement = true;
				flag = true;
				AchievementName.text = "The best achievement";
			}
			break;
		case "Jackpot":
			if (!data.Jackpot)
			{
				data.Jackpot = true;
				flag = true;
				AchievementName.text = "Jackpot!";
			}
			break;
		case "GamblingAddicion":
			if (!data.GamblingAddicion)
			{
				data.GamblingAddicion = true;
				flag = true;
				AchievementName.text = "Gambling addiction";
			}
			break;
		case "CrouchNextTime":
			if (!data.CrouchNextTime)
			{
				data.CrouchNextTime = true;
				flag = true;
				AchievementName.text = "Crouch next time";
			}
			break;
		case "StandUpNextTime":
			if (!data.StandUpNextTime)
			{
				data.StandUpNextTime = true;
				flag = true;
				AchievementName.text = "Stand up next time";
			}
			break;
		case "BaloonParty":
			if (!data.BaloonParty)
			{
				data.BaloonParty = true;
				flag = true;
				AchievementName.text = "Baloon party";
			}
			break;
		case "AuraLoss":
			if (!data.AuraLoss)
			{
				data.AuraLoss = true;
				flag = true;
				AchievementName.text = "Aura loss";
			}
			break;
		case "ThisMadeMeThink":
			if (!data.ThisMadeMeThink)
			{
				data.ThisMadeMeThink = true;
				flag = true;
				AchievementName.text = "This made me think";
			}
			break;
		case "StunGunBook":
			if (!data.StunGunBook)
			{
				data.StunGunBook = true;
				flag = true;
				AchievementName.text = "A book about how to use a stun gun";
			}
			break;
		case "SmellOfGasoline":
			if (!data.SmellOfGasoline)
			{
				data.SmellOfGasoline = true;
				flag = true;
				AchievementName.text = "Smell of Gasoline";
			}
			break;
		case "UnbelievableStory":
			if (!data.UnbelievableStory)
			{
				data.UnbelievableStory = true;
				flag = true;
				AchievementName.text = "What the hell is going on?";
			}
			break;
		case "MyTalkingStool":
			if (!data.MyTalkingStool)
			{
				data.MyTalkingStool = true;
				flag = true;
				AchievementName.text = "My talking stool";
			}
			break;
		case "FullOfHope":
			if (!data.FullOfHope)
			{
				data.FullOfHope = true;
				flag = true;
				AchievementName.text = "Full of hope";
			}
			break;
		case "AnomalousPrimeEnjoyer":
			if (!data.AnomalousPrimeEnjoyer)
			{
				data.AnomalousPrimeEnjoyer = true;
				flag = true;
				AchievementName.text = "Anomalous Prime Enjoyer";
			}
			break;
		case "PrimeEnjoyer":
			if (!data.PrimeEnjoyer)
			{
				data.PrimeEnjoyer = true;
				flag = true;
				AchievementName.text = "Prime Enjoyer";
			}
			break;
		case "VictimCard":
			if (!data.VictimCard)
			{
				data.VictimCard = true;
				flag = true;
				AchievementName.text = "I suffer a lot while playing Prime!";
			}
			break;
		case "ShootStool":
			if (!data.ShootStool)
			{
				data.ShootStool = true;
				flag = true;
				HEHEHEHA = true;
				AchievementName.text = "Got scammed by an achievement";
			}
			break;
		case "AnomalousAnomaly":
			if (!data.AnomalousAnomaly)
			{
				data.AnomalousAnomaly = true;
				flag = true;
				AchievementName.text = "The most anomalous anomaly";
			}
			break;
		case "GreenDoorEscape":
			if (!data.GreenDoorEscape)
			{
				data.GreenDoorEscape = true;
				flag = true;
				AchievementName.text = "I swear, these doors were in 1.0!";
			}
			break;
		case "PoisonSeedEscape":
			if (!data.PoisonSeedEscape)
			{
				data.PoisonSeedEscape = true;
				flag = true;
				AchievementName.text = "You were just supposed to escape!";
			}
			break;
		case "AnEasierPath":
			if (!data.AnEasierPath)
			{
				data.AnEasierPath = true;
				flag = true;
				AchievementName.text = "An easier path";
			}
			break;
		case "MysteriousLetter":
			if (!data.MysteriousLetter)
			{
				data.MysteriousLetter = true;
				flag = true;
				AchievementName.text = "To be continued in Anomaly 36";
			}
			break;
		case "TheUtopia":
			if (!data.TheUtopia)
			{
				data.TheUtopia = true;
				flag = true;
				AchievementName.text = "A genious plan!";
			}
			break;
		case "TheReality":
			if (!data.TheReality)
			{
				data.TheReality = true;
				flag = true;
				AchievementName.text = "It's too late...";
			}
			break;
		case "Anomaly45AllMessages":
			if (!data.Anomaly45AllMessages)
			{
				data.Anomaly45AllMessages = true;
				flag = true;
				AchievementName.text = "We're going insane together!";
			}
			break;
		case "AHugeSuccess":
			if (!data.AHugeSuccess)
			{
				data.AHugeSuccess = true;
				flag = true;
				AchievementName.text = "A huge success!";
			}
			break;
		case "EveryBegin":
			if (!data.EveryBegin)
			{
				data.EveryBegin = true;
				flag = true;
				AchievementName.text = "Every begin...";
			}
			break;
		case "PrionerOfPrime":
			if (!data.PrionerOfPrime)
			{
				data.PrionerOfPrime = true;
				flag = true;
				AchievementName.text = "Prioner of Prime";
			}
			break;
		case "SoClose":
			if (!data.SoClose)
			{
				data.SoClose = true;
				flag = true;
				AchievementName.text = "SO CLOSE!!";
			}
			break;
		case "DarkestHour":
			if (!data.DarkestHour)
			{
				data.DarkestHour = true;
				flag = true;
				AchievementName.text = "Darkest hour";
			}
			break;
		case "Unstoppable":
			if (!data.Unstoppable)
			{
				data.Unstoppable = true;
				flag = true;
				AchievementName.text = "Unstoppable!";
			}
			break;
		case "VeganActivist":
			if (!data.VeganActivist)
			{
				data.VeganActivist = true;
				flag = true;
				AchievementName.text = "Vegan activist";
			}
			break;
		case "NinetySevenIQMove":
			if (!data.NinetySevenIQMove)
			{
				data.NinetySevenIQMove = true;
				flag = true;
				AchievementName.text = "97 IQ move";
			}
			break;
		case "BonusDayEnjoyer":
			if (!data.BonusDayEnjoyer)
			{
				data.BonusDayEnjoyer = true;
				flag = true;
				AchievementName.text = "Bonus day enjoyer";
			}
			break;
		case "Titaniumhead":
			if (!data.Titaniumhead)
			{
				data.Titaniumhead = true;
				flag = true;
				AchievementName.text = "Titanium head";
			}
			break;
		case "FourtySevenIQMove":
			if (!data.FourtySevenIQMove)
			{
				data.FourtySevenIQMove = true;
				flag = true;
				AchievementName.text = "47 IQ move";
			}
			break;
		case "GotUnluky":
			if (!data.GotUnluky)
			{
				data.GotUnluky = true;
				flag = true;
				AchievementName.text = "Got unlucky :( A least you have an achievement";
			}
			break;
		case "Fireworks":
			if (!data.Fireworks)
			{
				data.Fireworks = true;
				flag = true;
				AchievementName.text = "Fireworks!";
			}
			break;
		case "NotASingleScratch":
			if (!data.NotASingleScratch)
			{
				data.NotASingleScratch = true;
				flag = true;
				AchievementName.text = "Not a single scratch";
			}
			break;
		case "HappyRemotesFamily":
			if (!data.HappyRemotesFamily)
			{
				data.HappyRemotesFamily = true;
				flag = true;
				AchievementName.text = "A happy remote control's family :)";
			}
			break;
		case "TrulyAHiddenVase":
			if (!data.TrulyAHiddenVase)
			{
				data.TrulyAHiddenVase = true;
				flag = true;
				AchievementName.text = "Truly a hidden vase!";
			}
			break;
		case "GrannyTheUnbreakable":
			if (!data.GrannyTheUnbreakable)
			{
				data.GrannyTheUnbreakable = true;
				flag = true;
				AchievementName.text = "Granny the Unbreakable";
			}
			break;
		case "MirrorPortal":
			if (!data.MirrorPortal)
			{
				data.MirrorPortal = true;
				flag = true;
				AchievementName.text = "!epacse rorriM";
			}
			break;
		case "FirstBlood":
			if (!data.FirstBlood)
			{
				data.FirstBlood = true;
				flag = true;
				AchievementName.text = "First blood";
			}
			break;
		case "AStrangePlace":
			if (!data.AStrangePlace)
			{
				data.AStrangePlace = true;
				flag = true;
				AchievementName.text = "A strange place";
			}
			break;
		case "Freedom":
			if (!data.Freedom)
			{
				data.Freedom = true;
				flag = true;
				AchievementName.text = "Freedom?";
			}
			break;
		case "TheBrokenElevator":
			if (!data.TheBrokenElevator)
			{
				data.TheBrokenElevator = true;
				flag = true;
				AchievementName.text = "The broken elevator";
			}
			break;
		case "FamilyFriendly":
			if (!data.FamilyFriendly)
			{
				data.FamilyFriendly = true;
				flag = true;
				AchievementName.text = "Family friendly";
			}
			break;
		case "RageBaitEnding":
			if (!data.RageBaitEnding)
			{
				data.RageBaitEnding = true;
				flag = true;
				AchievementName.text = "Ragebait ending";
			}
			break;
		case "NightmareEscape":
			if (!data.NightmareEscape)
			{
				data.NightmareEscape = true;
				flag = true;
				AchievementName.text = "What a horrible house! (I want more of this)";
			}
			break;
		case "AbandonedEscape":
			if (!data.AbandonedEscape)
			{
				data.AbandonedEscape = true;
				flag = true;
				AchievementName.text = "Abandoned buildings explorer";
			}
			break;
		case "ExtremeBeat":
			if (!data.ExtremeBeat)
			{
				data.ExtremeBeat = true;
				flag = true;
				AchievementName.text = "How is this possible if she is faster than you?";
			}
			break;
		case "ExtremePlusBeat":
			if (!data.ExtremePlusBeat)
			{
				data.ExtremePlusBeat = true;
				flag = true;
				AchievementName.text = "Pro player plus";
			}
			break;
		case "CruelBeat":
			if (!data.CruelBeat)
			{
				data.CruelBeat = true;
				flag = true;
				AchievementName.text = "And who is more cruel at this point?";
			}
			break;
		case "IrrationalCruelBeat":
			if (!data.IrrationalCruelBeat)
			{
				data.IrrationalCruelBeat = true;
				flag = true;
				AchievementName.text = "Irrational escape route";
			}
			break;
		}
		if (flag)
		{
			AchievementTab.Play();
			if (!HEHEHEHA)
			{
				AchievementSound.PlayOneShot(AchievementSoundWav);
			}
			else
			{
				HEHEHEHAsoundholder.PlayOneShot(HEHEHEHAsound);
				HEHEHEHA = false;
			}
			SaveAchievements();
			Debug.Log((object)("Achievement unlocked: " + achievementName));
		}
	}

	public void SaveAchievements()
	{
		string text = JsonUtility.ToJson((object)data, true);
		text = Encrypt(text);
		File.WriteAllText(savePath, text);
	}

	public void LoadAchievements()
	{
		if (File.Exists(savePath))
		{
			string text = File.ReadAllText(savePath);
			text = Encrypt(text);
			data = JsonUtility.FromJson<AchievementData>(text);
		}
		else
		{
			SaveAchievements();
		}
	}

	private string Encrypt(string text)
	{
		string text2 = "GrannyHorrorGameKey";
		char[] array = new char[text.Length];
		for (int i = 0; i < text.Length; i++)
		{
			array[i] = (char)(text[i] ^ text2[i % text2.Length]);
		}
		return new string(array);
	}
}
