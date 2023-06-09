namespace Creator.EF.Model;
public class Column
{
	public class Field
	{
		private readonly Type type;
		private readonly object value;

		//<Type> <Name>
		//E.g. string Weight
		public Field(Type type,object value)
		{
			this.type = type;
			this.value = value;
		}
	}
	Constraint key;
	Field field;

	//<Type> <Name>
	//E.g. string Weight
	public Column(Field dataTypeValue)
	{
		this.key = new Constraint();
		this.field = dataTypeValue;
	}
}

