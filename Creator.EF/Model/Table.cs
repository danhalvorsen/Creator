namespace Creator.EF.Model;
//How to use source generation in System.Text.Json
public class Table
{
	public List<Column> columns = new List<Column>();

	public Table()
	{
		columns.Add(new Column(typeof(int),value: 100));
	}

	public override bool Equals(object? obj)
	{
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException();
	}
}
