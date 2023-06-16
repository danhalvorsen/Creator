using Creator.EF.Model.Fields;

namespace Creator.EF.Tests {

	public interface IFieldFactory {
		public IntField CreateIntField(string fieldName,int min,int max,string description);
	}
	public class FieldFactory: IFieldFactory {
		public IntField CreateIntField(string fieldName,int min,int max,string description) => new IntField() {
			MaxValue = max,
			MinValue = min,
			Description = description,
			FieldName = fieldName
		};

	}
}
