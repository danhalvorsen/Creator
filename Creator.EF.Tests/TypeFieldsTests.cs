using Creator.EF.Model.Fields;
using System.Text.Json;

namespace Creator.EF.Tests
{
	public class TypeFieldsTests
	{
		[Fact]
		public void Test()
		{
			;

			ObjectMetadata FishTable = CreateFishTable();
			var jsonString = JsonSerializer.Serialize(FishTable);
			var deserialized = JsonSerializer.Deserialize<ObjectMetadata>(jsonString);
		}

		private static ObjectMetadata CreateFishTable()
		{
			return new ObjectMetadata
			{
				ObjectName = "Fish",
				FieldMetaData = new List<BaseType>
				{
					new IntField
					{
						MaxValue = 10,
						MinValue = 0,
						Description = "How big a fish can be",
						FieldName = "The fish length"
					},
					new StringField {
						Description = "How big a fish can be",
						FieldName = "Maximum fish length",
						Length = 10
					}
				},
			};
		}
	}
}
