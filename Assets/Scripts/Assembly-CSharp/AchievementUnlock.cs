using UnityEngine;
using UnityEngine.UI;

public class AchievementUnlock : MonoBehaviour
{
	public Image FirstBloodIcon;

	public Image AStrangePlaceIcon;

	public Image FreedomIcon;

	public Image TheBrokenElevatorIcon;

	public Image FamilyFriendly;

	public Image RageBaitEnding;

	public Image NightmareEscape;

	public Image AbandonedEscape;

	public Image ExtremeBeat;

	public Image ExtremePlusBeat;

	public Image CruelBeat;

	public Image IrrationalCruelBeat;

	public Image NinetySevenIQMove;

	public Image BonusDayEnjoyer;

	public Image Titaniumhead;

	public Image FourtySevenIQMove;

	public Image GotUnluky;

	public Image Fireworks;

	public Image NotASingleScratch;

	public Image HappyRemotesFamily;

	public Image TrulyAHiddenVase;

	public Image GrannyTheUnbreakable;

	public Image MirrorPortal;

	public Image AnomalousAnomaly;

	public Image GreenDoorEscape;

	public Image PoisonSeedEscape;

	public Image AnEasierPath;

	public Image MysteriousLetter;

	public Image TheUtopia;

	public Image TheReality;

	public Image Anomaly45AllMessages;

	public Image AHugeSuccess;

	public Image EveryBegin;

	public Image PrionerOfPrime;

	public Image SoClose;

	public Image DarkestHour;

	public Image Unstoppable;

	public Image VeganActivist;

	public Image VictimCard;

	public Image ShootStool;

	public Text ShootStoolText1;

	public Text ShootStoolText2;

	public Image CrouchNextTime;

	public Image StandUpNextTime;

	public Image BaloonParty;

	public Image AuraLoss;

	public Image ThisMadeMeThink;

	public Image StunGunBook;

	public Image SmellOfGasoline;

	public Image UnbelievableStory;

	public Image MyTalkingStool;

	public Image FullOfHope;

	public Image AnomalousPrimeEnjoyer;

	public Image PrimeEnjoyer;

	public Image FourBooks;

	public Image EightBooks;

	public Image LightsOutEscape;

	public Image LightsOutEscapeOneDay;

	public Image BreatheFire;

	public Image IShowSlowness;

	public Image SixSevenAchievement;

	public Image Jackpot;

	public Image GamblingAddicion;

	public Image AnomalyGauntlet;

	public Image ShotGunHater;

	public Image ILoveBooks;

	public Image YouShallNotPass;

	public Image TheBigRedItem;

	public Image BreakRules;

	public Image NerfedPrimeFan;

	public Sprite lockedSprite;

	public Sprite unlockedSprite;

	public float AchievementsCompleted;

	public float AchievementProgress;

	public Text AchievementProgressText;

	public Text YourStatsText;

	private void Start()
	{
		LoadAchievements();
	}

	private void LoadAchievements()
	{
		AchievementSaveManager.AchievementData data = AchievementSaveManager.Instance.data;
		GlobalSaveManager.SaveData data2 = GlobalSaveManager.InstanceSaveData.data;
		AnomalyGauntlet.sprite = (data.AnomalyGauntlet ? unlockedSprite : lockedSprite);
		ShotGunHater.sprite = (data.ShotGunHater ? unlockedSprite : lockedSprite);
		ILoveBooks.sprite = (data.ILoveBooks ? unlockedSprite : lockedSprite);
		YouShallNotPass.sprite = (data.YouShallNotPass ? unlockedSprite : lockedSprite);
		TheBigRedItem.sprite = (data.TheBigRedItem ? unlockedSprite : lockedSprite);
		BreakRules.sprite = (data.BreakRules ? unlockedSprite : lockedSprite);
		NerfedPrimeFan.sprite = (data.NerfedPrimeFan ? unlockedSprite : lockedSprite);
		FourBooks.sprite = (data.FourBooks ? unlockedSprite : lockedSprite);
		EightBooks.sprite = (data.EightBooks ? unlockedSprite : lockedSprite);
		LightsOutEscape.sprite = (data.LightsOutEscape ? unlockedSprite : lockedSprite);
		LightsOutEscapeOneDay.sprite = (data.LightsOutEscapeOneDay ? unlockedSprite : lockedSprite);
		BreatheFire.sprite = (data.BreatheFire ? unlockedSprite : lockedSprite);
		IShowSlowness.sprite = (data.IShowSlowness ? unlockedSprite : lockedSprite);
		SixSevenAchievement.sprite = (data.SixSevenAchievement ? unlockedSprite : lockedSprite);
		Jackpot.sprite = (data.Jackpot ? unlockedSprite : lockedSprite);
		GamblingAddicion.sprite = (data.GamblingAddicion ? unlockedSprite : lockedSprite);
		FirstBloodIcon.sprite = (data.FirstBlood ? unlockedSprite : lockedSprite);
		AStrangePlaceIcon.sprite = (data.AStrangePlace ? unlockedSprite : lockedSprite);
		FreedomIcon.sprite = (data.Freedom ? unlockedSprite : lockedSprite);
		TheBrokenElevatorIcon.sprite = (data.TheBrokenElevator ? unlockedSprite : lockedSprite);
		FamilyFriendly.sprite = (data.FamilyFriendly ? unlockedSprite : lockedSprite);
		RageBaitEnding.sprite = (data.RageBaitEnding ? unlockedSprite : lockedSprite);
		NightmareEscape.sprite = (data.NightmareEscape ? unlockedSprite : lockedSprite);
		AbandonedEscape.sprite = (data.AbandonedEscape ? unlockedSprite : lockedSprite);
		ExtremeBeat.sprite = (data.ExtremeBeat ? unlockedSprite : lockedSprite);
		ExtremePlusBeat.sprite = (data.ExtremePlusBeat ? unlockedSprite : lockedSprite);
		CruelBeat.sprite = (data.CruelBeat ? unlockedSprite : lockedSprite);
		IrrationalCruelBeat.sprite = (data.IrrationalCruelBeat ? unlockedSprite : lockedSprite);
		NinetySevenIQMove.sprite = (data.NinetySevenIQMove ? unlockedSprite : lockedSprite);
		BonusDayEnjoyer.sprite = (data.BonusDayEnjoyer ? unlockedSprite : lockedSprite);
		Titaniumhead.sprite = (data.Titaniumhead ? unlockedSprite : lockedSprite);
		Titaniumhead.sprite = (data.Titaniumhead ? unlockedSprite : lockedSprite);
		FourtySevenIQMove.sprite = (data.FourtySevenIQMove ? unlockedSprite : lockedSprite);
		GotUnluky.sprite = (data.GotUnluky ? unlockedSprite : lockedSprite);
		Fireworks.sprite = (data.Fireworks ? unlockedSprite : lockedSprite);
		NotASingleScratch.sprite = (data.NotASingleScratch ? unlockedSprite : lockedSprite);
		NotASingleScratch.sprite = (data.NotASingleScratch ? unlockedSprite : lockedSprite);
		HappyRemotesFamily.sprite = (data.HappyRemotesFamily ? unlockedSprite : lockedSprite);
		TrulyAHiddenVase.sprite = (data.TrulyAHiddenVase ? unlockedSprite : lockedSprite);
		GrannyTheUnbreakable.sprite = (data.GrannyTheUnbreakable ? unlockedSprite : lockedSprite);
		MirrorPortal.sprite = (data.MirrorPortal ? unlockedSprite : lockedSprite);
		AnomalousAnomaly.sprite = (data.AnomalousAnomaly ? unlockedSprite : lockedSprite);
		GreenDoorEscape.sprite = (data.GreenDoorEscape ? unlockedSprite : lockedSprite);
		PoisonSeedEscape.sprite = (data.PoisonSeedEscape ? unlockedSprite : lockedSprite);
		AnEasierPath.sprite = (data.AnEasierPath ? unlockedSprite : lockedSprite);
		MysteriousLetter.sprite = (data.MysteriousLetter ? unlockedSprite : lockedSprite);
		TheUtopia.sprite = (data.TheUtopia ? unlockedSprite : lockedSprite);
		TheReality.sprite = (data.TheReality ? unlockedSprite : lockedSprite);
		Anomaly45AllMessages.sprite = (data.Anomaly45AllMessages ? unlockedSprite : lockedSprite);
		AHugeSuccess.sprite = (data.AHugeSuccess ? unlockedSprite : lockedSprite);
		EveryBegin.sprite = (data.EveryBegin ? unlockedSprite : lockedSprite);
		PrionerOfPrime.sprite = (data.PrionerOfPrime ? unlockedSprite : lockedSprite);
		SoClose.sprite = (data.SoClose ? unlockedSprite : lockedSprite);
		DarkestHour.sprite = (data.DarkestHour ? unlockedSprite : lockedSprite);
		Unstoppable.sprite = (data.Unstoppable ? unlockedSprite : lockedSprite);
		VeganActivist.sprite = (data.VeganActivist ? unlockedSprite : lockedSprite);
		VictimCard.sprite = (data.VictimCard ? unlockedSprite : lockedSprite);
		ShootStool.sprite = (data.ShootStool ? unlockedSprite : lockedSprite);
		if (data.ShootStool)
		{
			ShootStoolText1.text = "Got scammed by an achievement";
			ShootStoolText2.text = "HE-HE-HE-HA";
		}
		CrouchNextTime.sprite = (data.CrouchNextTime ? unlockedSprite : lockedSprite);
		StandUpNextTime.sprite = (data.StandUpNextTime ? unlockedSprite : lockedSprite);
		BaloonParty.sprite = (data.BaloonParty ? unlockedSprite : lockedSprite);
		AuraLoss.sprite = (data.AuraLoss ? unlockedSprite : lockedSprite);
		ThisMadeMeThink.sprite = (data.ThisMadeMeThink ? unlockedSprite : lockedSprite);
		StunGunBook.sprite = (data.StunGunBook ? unlockedSprite : lockedSprite);
		SmellOfGasoline.sprite = (data.SmellOfGasoline ? unlockedSprite : lockedSprite);
		UnbelievableStory.sprite = (data.UnbelievableStory ? unlockedSprite : lockedSprite);
		MyTalkingStool.sprite = (data.MyTalkingStool ? unlockedSprite : lockedSprite);
		FullOfHope.sprite = (data.FullOfHope ? unlockedSprite : lockedSprite);
		AnomalousPrimeEnjoyer.sprite = (data.AnomalousPrimeEnjoyer ? unlockedSprite : lockedSprite);
		PrimeEnjoyer.sprite = (data.PrimeEnjoyer ? unlockedSprite : lockedSprite);
		bool[] array = new bool[68]
		{
			data.FirstBlood, data.AStrangePlace, data.Freedom, data.TheBrokenElevator, data.FamilyFriendly, data.RageBaitEnding, data.NightmareEscape, data.AbandonedEscape, data.ExtremeBeat, data.ExtremePlusBeat,
			data.CruelBeat, data.IrrationalCruelBeat, data.NinetySevenIQMove, data.BonusDayEnjoyer, data.Titaniumhead, data.FourtySevenIQMove, data.GotUnluky, data.Fireworks, data.NotASingleScratch, data.HappyRemotesFamily,
			data.TrulyAHiddenVase, data.GrannyTheUnbreakable, data.MirrorPortal, data.AnomalousAnomaly, data.GreenDoorEscape, data.PoisonSeedEscape, data.AnEasierPath, data.MysteriousLetter, data.TheUtopia, data.TheReality,
			data.Anomaly45AllMessages, data.AHugeSuccess, data.EveryBegin, data.PrionerOfPrime, data.SoClose, data.DarkestHour, data.Unstoppable, data.VeganActivist, data.VictimCard, data.ShootStool,
			data.CrouchNextTime, data.StandUpNextTime, data.BaloonParty, data.AuraLoss, data.ThisMadeMeThink, data.StunGunBook, data.SmellOfGasoline, data.UnbelievableStory, data.MyTalkingStool, data.FullOfHope,
			data.AnomalousPrimeEnjoyer, data.PrimeEnjoyer, data.FourBooks, data.EightBooks, data.LightsOutEscape, data.LightsOutEscapeOneDay, data.BreatheFire, data.IShowSlowness, data.SixSevenAchievement, data.Jackpot,
			data.GamblingAddicion, data.AnomalyGauntlet, data.ShotGunHater, data.ILoveBooks, data.YouShallNotPass, data.TheBigRedItem, data.BreakRules, data.NerfedPrimeFan
		};
		bool[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			if (array2[i])
			{
				AchievementsCompleted++;
			}
		}
		if (AchievementsCompleted < (float)array.Length)
		{
			AchievementProgress = AchievementsCompleted / (float)array.Length * 100f;
		}
		else
		{
			AchievementProgress = 100f;
		}
		AchievementProgressText.text = "Your progress: " + Mathf.Floor(AchievementProgress) + "%";
		YourStatsText.text = "Time played: " + Mathf.Floor(data2.TimePlayed / 3600f) + " hours\r\nAchievements progress: " + Mathf.Floor(AchievementProgress) + "%\r\nNerfed Prime progress: " + data2.NerfedPrimeBest + "%\r\nPrime progress: " + data2.PrimeBest + "%\r\nNerfed Prime attempts: " + data2.NerfedPrimeAtts + "\r\nPrime attempts: " + data2.PrimeAtts + "\r\nGranny Anomaly Gauntlet progress: " + data2.GrannyGauntlet + "/3";
	}
}
