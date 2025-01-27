using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm_pj.Model;

public class MatchModel
{
	private LineupModel HomeTeam;
	private LineupModel GuestTeam;
	Random random = new Random();
	private MatchEnum? whoStartMatch = null;

	int HomeScore = 0;
	int GuestScore = 0;

	public MatchModel(LineupModel homeTeam, LineupModel guestTeam)
	{
		HomeTeam = homeTeam;
		GuestTeam = guestTeam;
	}

	public void MatchSimulation()
	{
		WhoStartMatch();

		MatchEnum? turn;
		for (int i = 0; i < 10; i++)
		{
			LineupModel attacker;
			LineupModel defender;

			if (i % 2 == 0)
			{
				attacker = whoStartMatch == MatchEnum.Home ? HomeTeam : GuestTeam;
				defender = whoStartMatch == MatchEnum.Home ? GuestTeam : HomeTeam;
				turn = whoStartMatch == MatchEnum.Home ? MatchEnum.Home : MatchEnum.Guest;
			}
			else
			{
				attacker = whoStartMatch == MatchEnum.Home ? GuestTeam : HomeTeam;
				defender = whoStartMatch == MatchEnum.Home ? HomeTeam : GuestTeam;
				turn = whoStartMatch == MatchEnum.Home ? MatchEnum.Guest : MatchEnum.Home;
			}
			var haveWinMidfield = HaveWinMidfield(attacker, defender);

			if (!haveWinMidfield) continue;

			var isGoal = IsGoal(attacker, defender);

			if (!isGoal) continue;

			if (turn == MatchEnum.Home) HomeScore++;
			else GuestScore++;
		}

		var res = $"Risultato: {HomeScore} - {GuestScore}";
	}

	private void WhoStartMatch()
	{
		whoStartMatch = random.Next(2) == 0 ? MatchEnum.Home : MatchEnum.Guest;
	}

	private bool HaveWinMidfield(LineupModel attacker, LineupModel defender)
	{
		var attCl = attacker.fieldModel.fieldZoneCl.BallControlValue;
		var attCc = attacker.fieldModel.fieldZoneCc.BallControlValue;
		var attCr = attacker.fieldModel.fieldZoneCr.BallControlValue;

		var defCl = defender.fieldModel.fieldZoneCl.DefensiveValue;
		var defCc = defender.fieldModel.fieldZoneCc.DefensiveValue;
		var defCr = defender.fieldModel.fieldZoneCr.DefensiveValue;

		return HaveWinCalculation(attCl, attCc, attCr, defCl, defCc, defCr);
	}

	private bool HaveWinCalculation(double attCl, double attCc, double attCr, double defCl, double defCc, double defCr)
	{
		var valCl = attCl - defCl;
		var valCc = attCc - defCc;
		var valCr = attCr - defCr;

		var selected = Selector(valCl, valCc, valCr);

		if (selected == 0) return HaveWinChallange(attCl, defCl);
		if (selected == 1) return HaveWinChallange(attCc, defCc);
		if (selected == 2) return HaveWinChallange(attCr, defCr);
		return false;
	}

	private bool IsGoal(LineupModel attacker, LineupModel defender)
	{
		var attAl = attacker.fieldModel.fieldZoneAl.AttackValue;
		var attAc = attacker.fieldModel.fieldZoneAc.AttackValue;
		var attAr = attacker.fieldModel.fieldZoneAr.AttackValue;

		var defDl = defender.fieldModel.fieldZoneDl.DefensiveValue;
		var defDc = defender.fieldModel.fieldZoneDc.DefensiveValue;
		var defDr = defender.fieldModel.fieldZoneDr.DefensiveValue;

		return HaveWinCalculation(attAl, attAc, attAr, defDl, defDc, defDr);
	}

	private int Selector(params Double[] values)
	{
		Double sum = 0;
		Double margin = values.Min() + 1;
		foreach (var val in values)
		{
			sum += val + margin;
		}
		// Generazione di un numero casuale compreso tra 0 e la somma dei valori
		double randomNumber = random.NextDouble() * sum;

		// Selezione del valore in base al numero casuale generato
		double cumulativeSum = 0;
		for(int i = 0; i < values.Length; i++)
		{
			cumulativeSum += values[i] + margin;
			if (randomNumber < cumulativeSum)
			{
				return i;
			}
		}
		return -1;
	}

	private bool HaveWinChallange(double attValue, double defValue)
	{
		var result = Selector(attValue, defValue);
		return result == 0;
	}
}

public enum MatchEnum
{
	Home,
	Guest
}