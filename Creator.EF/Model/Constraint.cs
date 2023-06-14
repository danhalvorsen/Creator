namespace Creator.EF.Model;

public class Constraint
{
	public Constraint()
	{
		IsKey = false;
		Sequencer = 0;
	}
	public int Sequencer { get; set; }
	public bool IsKey { get; }

}
