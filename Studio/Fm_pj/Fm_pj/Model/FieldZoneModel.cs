namespace Fm_pj.Model;

public class FieldZoneModel
{
	public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
	public PlayerModel GoalKeeper { get; set; } = null;
	public List<FieldZoneModel> NearFieldZones { get; set; } = new List<FieldZoneModel>();
	public Int32 AttackBaseValue { get; set; }
	public Int32 BallControlBaseValue { get; set; }
	public Int32 DefensiveBaseValue { get; set; }

	public Double AttackValue { get; set; }
	public Double BallControlValue { get; set; }
	public Double DefensiveValue { get; set; }

	public FieldZoneModel()	{
		ResetValue();
	}

	public void CalculateBaseValues()
	{
		ResetValue();
		foreach (var player in Players)
		{
			AttackBaseValue += player.Attack;
			if(player.BallControl > player.Passing)
				BallControlBaseValue += player.BallControl;
			else
				BallControlBaseValue += player.Passing;
			DefensiveBaseValue += player.Defense;
		}

		if (GoalKeeper != null)
		{
			AttackBaseValue += GoalKeeper.Attack;
			BallControlBaseValue += GoalKeeper.BallControl;
			BallControlBaseValue += GoalKeeper.Passing;
			DefensiveBaseValue += GoalKeeper.Defense;
			DefensiveBaseValue += GoalKeeper.Saves;
		}
	}

	public void CalculateValues()
	{
		AttackValue = AttackBaseValue;
		BallControlValue = BallControlBaseValue;
		DefensiveValue = DefensiveBaseValue;

		foreach(var nearFieldZone in NearFieldZones)
		{
			AttackValue += (nearFieldZone.AttackBaseValue * 0.5);
			BallControlValue += (nearFieldZone.BallControlBaseValue * 0.5);
			DefensiveValue += (nearFieldZone.DefensiveBaseValue * 0.5);
		}
	}

	public void ResetValue()
	{
		AttackBaseValue = 0;
		BallControlBaseValue = 0;
		DefensiveBaseValue = 0;

		AttackValue = 0;
		BallControlValue = 0;
		DefensiveValue = 0;
	}

}
