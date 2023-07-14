using HandlebarsDotNet;

namespace Creator.Handlebar.Templates.Handlebar {

	public interface IClassWriter {
		Task Write(string fullPath,string code);
	}
	public class ClassWriter: IClassWriter {
		public async Task Write(string fullPath,string code) {
			var stream = File.CreateText(fullPath);
			await stream.WriteAsync(code);
			stream.Close();
		}
	}

	public class DtoHandlebarTemplate {

		private const string code =
		@"""
		public class {{className}}Dto 
		{
				{{#each properties}}
					public {{type}} {{name}} {get;set}
				{{/each}}
																					 
		}
		""";

		public string Create() {
			HandlebarsTemplate<object,object> template = Handlebars.Compile(code);
			var data = new {
				className = "Fido",
				properties = new[] {
					new {
					name = "Foo",
					type = typeof(string).FullName
						},
					new {
					name = "Bla",
					type = typeof(int).FullName
						}
				}
			};
			return template(data);
		}
	}
}
