using Creator.Handlebar.Templates;
using HandlebarsDotNet;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace Creator.Handlebar {
	public class MyAppClass {
		private readonly CodeGenerationOptions _setupOptions;

		// Inject IOptions in your constructor
		public MyAppClass(IOptions<CodeGenerationOptions> codeGenerationOptions) {
			Debug.Assert(codeGenerationOptions != null);
			Debug.Assert(codeGenerationOptions?.Value != null);
			if (codeGenerationOptions?.Value != null &&
			codeGenerationOptions != null &&
			codeGenerationOptions.Value != null) {
				_setupOptions = codeGenerationOptions.Value;
			}

		}

		public async Task RunAsync(string[] args) {
			// Use your Setup Options value loaded from appsettings file.
			var myPropertyValue = _setupOptions.MyProperty;

			var commandTemplate = Handlebars.Compile(new CommandTemplate().CSCode);
			var commandHandlerTemplate = Handlebars.Compile(new CommandHandlerTemplate().CSCode);

			var data = new {
				name = "Bla"

			};

			var commandResult = commandTemplate(data);
			var commandHandlerResult = commandHandlerTemplate(data);
			Console.WriteLine($"{commandResult} /n {commandHandlerResult}");
			Console.ReadLine();
		}
	}
}
