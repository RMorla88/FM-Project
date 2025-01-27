using Fm_pj.ValuesKind;

namespace Fm_pj.Model;

public class PlayerModel
{
	public AttributeInt Stamina {  get; set; }
	public AttributeInt Defense { get; set; }
	public AttributeInt Attack { get; set; }
	public AttributeInt Passing { get; set; }
	public AttributeInt Speed { get; set; }
	public AttributeInt BallControl { get; set; }
	public AttributeInt Saves { get; set; } //GoalKeaper

	public PlayerModel()
	{
		SetDefaultPlayer();
	}

	public PlayerModel(AttributeInt stamina, AttributeInt defense, AttributeInt attack, AttributeInt passing, AttributeInt speed, AttributeInt ballcontrol, AttributeInt saves)
	{
		Stamina = stamina;
		Defense = defense;
		Attack = attack;
		Passing = passing;
		Speed = speed;
		BallControl = ballcontrol;
		Saves = saves;
	}

	public void SetDefaultPlayer()
	{
		Stamina = 10;
		Defense = 10;
		Attack = 10;
		Passing = 10;
		Speed = 10;
		BallControl = 10;
		Saves = 10;
	}
}
