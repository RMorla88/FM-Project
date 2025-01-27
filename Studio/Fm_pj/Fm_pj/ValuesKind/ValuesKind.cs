namespace Fm_pj.ValuesKind;

public class AttributeInt
{
	private int value;
	public int Value
	{
		get { return value; }
		private set { if (value < 1 || value > 20) throw new ArgumentOutOfRangeException("Value must be between 1 and 20."); this.value = value; }
	}
	public AttributeInt(int value) { Value = value; }

	// Implicit conversion from LimitedInt to int
	public static implicit operator int(AttributeInt li) => li.value;

	// Implicit conversion from int to LimitedInt
	public static implicit operator AttributeInt(int value) => new AttributeInt(value);

	public override string ToString()
	{
		return value.ToString();
	}
}
