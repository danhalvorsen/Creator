namespace Creator.EF.Model.Fields {
	public interface IFieldType {
		string FieldType { get; }
	}

	public class BaseType: IFieldType {
		public string FieldName { get; set; }
		public string Description { get; set; }
		public string FieldType => nameof(BaseType);
		public bool NotNull { get; set; }
	}

	public class StringField: BaseType {
		public int Length { get; set; }
		public new string FieldType => nameof(StringField);
	}

	public class IntField: BaseType {

		public int MinValue { get; set; }
		public int MaxValue { get; set; }
		public new string FieldType => nameof(IntField);
	}
}
