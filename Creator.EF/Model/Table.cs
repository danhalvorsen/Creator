using System.Text.Json.Serialization;

namespace Creator.EF.Model;
//How to use source generation in System.Text.Json

//[JsonDerivedType(typeof(Field),typeDiscriminator: "base")]
//[JsonDerivedType(typeof(FieldInt),typeDiscriminator: 1)]
//[JsonDerivedType(typeof(FieldString),typeDiscriminator: 2)]
public class Table
{
	
	public IList<Field> Columns { get; set; }

	public Table()
	{
		Columns = new List<Field>();
	}

	public void AddColumn(IField field)
	{
		Columns.Add(field as Field);
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
