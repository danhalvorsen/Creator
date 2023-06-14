using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;

namespace Creator.EF.Model
{
	public sealed class JsonConverterField: JsonConverter<Field>
	{
		public override Field? Read(ref Utf8JsonReader reader,Type typeToConvert,JsonSerializerOptions options)
		{
			var data = reader.GetString()!;
			switch (data)
			{
				case ("Int32"): return new FieldInt(100);
				case ("String"): return new FieldString("Empty");
				default: throw new Exception("Unknown Field");
			}
			
		}
		public override void Write(Utf8JsonWriter writer,Field value,JsonSerializerOptions options)
		{
			throw new NotImplementedException();
		}
	}
}