namespace Creator.EF.Model.Fields
{

	//https://umamaheswaran.com/2022/07/29/how-to-do-polymorphic-serialization-deserialization-in-c-system-text-json/
	public class ObjectMetadata
	{
		public string ObjectName { get; set; }
		public List<BaseType> FieldMetaData { get; set; }
	}
	public class BaseFieldMetaData
	{
		public string FieldName { get; set; }
		public string Description { get; set; }
	}
	public class StringFieldMetaData
	{
		public int Length { get; set; }
	}
	public class IntFieldMetaData
	{
		public int Min { get; set; }
		public int Max { get; set; }
	}
}
