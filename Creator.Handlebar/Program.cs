using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Creator.Handlebar {
	public class Program {
		static async Task Main(string[] args) {

			var currentDirectory = Directory.GetCurrentDirectory();
			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(currentDirectory)
				.AddJsonFile("appsettings.json",optional: false)
				.Build();

			ServiceCollection? serviceCollection = new ServiceCollection();
			/* */
			ConfigureServices(serviceCollection,configuration);

			var serviceProvider = serviceCollection.BuildServiceProvider();
			if (serviceProvider != null) {
				var service = serviceProvider?.GetService<MyAppClass>();
				service?.RunAsync(args);
			}

		}

		private static void ConfigureServices(IServiceCollection? services,
		IConfiguration configuration) {

			Debug.Assert(configuration != null);
			Debug.Assert(services != null);
			CodeGenerationOptions? options = configuration?.GetSection(CodeGenerationOptions.ConfigKey).Get<CodeGenerationOptions>();
			Debug.Assert(configuration != null);
			services.AddOptions<CodeGenerationOptions>().Bind(configuration.GetSection(CodeGenerationOptions.ConfigKey));
			services.AddSingleton<MyAppClass>();
		}

	}

}
