using System.Diagnostics;

namespace Creator.EF.Model;

public interface IField
{
	public object Value { get; set; }
	public string TypeName { get; set; }
}

public class Field: IField
{
	[NonSerialized]
	private readonly Type theType;

	//<Type> <Name>
	//E.g. string Weight
	public Field(Type type,object value)
	{
		Debug.Assert(type != null);
		this.theType = type;
		TypeName = type.Name;

		Debug.Assert(value != null);
		this.Value = value;

	}

	public object Value { get; set; } = string.Empty;
	public string TypeName { get; set; }
}

public class FieldInt: Field
{
	public FieldInt(int value) : base(typeof(int),value)
	{
	}

}

public class FieldString: Field
{
	public FieldString(string value) : base(typeof(string),value)
	{
	}

}
