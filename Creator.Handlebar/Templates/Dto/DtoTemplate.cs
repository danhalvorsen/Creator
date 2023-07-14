// Ignore Spelling: Dto
using System.Text;

namespace Creator.Handlebar.Templates.Dto {
	public class PropertyDefinition {
		public Type? Type { get; set; }
		public string? Name { get; set; }
		public object? Value { get; set; }
	}

	public class PropertyDefinitions: List<PropertyDefinition> {

		public List<PropertyDefinition> Properties { get; set; } = new List<PropertyDefinition>();

		public void AddProperty(Type type,string name,object value) {

			Properties.Add(new PropertyDefinition { Type = type,Name = name,Value = value });
		}
	};

	public class DtoTemplate: ITemplate {
		private string className = string.Empty;
		private readonly PropertyDefinitions properties;

		public DtoTemplate(string className,PropertyDefinitions properties) {
			this.className = className;
			this.properties = properties;
		}

		public DtoTemplate() {
		}

		public void CreateFile(string code) {
			var stream = File.CreateText(@"c:\temp\Dtos" + className + ".cs");
			stream.WriteAsync(code);
			stream.Close();
		}

		public string CSCode { get => CreateCSCode(); }
		public string TSCode { get => CreateTSCode(); }

		public string CreateCSCode() {

			StringBuilder classBuilder = new StringBuilder();
			classBuilder.AppendLine($"public class  {className}Dto");
			classBuilder.AppendLine("{");
			StringBuilder propertyBuilder = new StringBuilder();
			foreach (var property in properties) {
				propertyBuilder.AppendLine($"public {property.Type} {property.Name} {{ get; set; }}");
			}
			classBuilder.Append("\t" + propertyBuilder);
			classBuilder.AppendLine("}");
			return classBuilder.ToString();
		}

		public string CreateTSCode() {
			var propertyBuilder = new StringBuilder();

			foreach (var property in properties) {
				propertyBuilder.AppendLine($"public {property.Type} {property.Name} {{ get; set; }}");
			}
			return $"""
			class  {className}Dto
			{propertyBuilder}
		""";

		}

	}
}
