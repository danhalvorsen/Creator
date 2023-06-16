using System.Text.Json;
using System.Text.Json.Serialization;

namespace Creator.EF.Model.Fields {
	public class FieldMetaDataConverter<T>: JsonConverter<T> where T : IFieldType {
		private readonly IEnumerable<Type> _types;

		public FieldMetaDataConverter() {
			var type = typeof(T);
			_types = AppDomain.CurrentDomain.GetAssemblies()
			.SelectMany(s => s.GetTypes())
			.Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract);
		}
		public override T Read(ref Utf8JsonReader reader,Type typeToConvert,JsonSerializerOptions options) {
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException();

			using (var jsonDocument = JsonDocument.ParseValue(ref reader)) {
				if (!jsonDocument.RootElement.TryGetProperty(nameof(IFieldType.FieldType),out var typeProperty))
					throw new JsonException();
				var type = _types.FirstOrDefault(x => x.Name == typeProperty.GetString());
				if (type == null)
					throw new JsonException();
				var jsonString = jsonDocument.RootElement.GetRawText();
				var jsonObject = (T)JsonSerializer.Deserialize(jsonString,type,options);
				return jsonObject;
			}
		}

		public override void Write(Utf8JsonWriter writer,T value,JsonSerializerOptions options) {
			JsonSerializer.Serialize(writer,(object)value,options);
		}
	}
}
