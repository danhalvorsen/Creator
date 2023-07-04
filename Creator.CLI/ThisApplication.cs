#nullable disable
using Creator.CLI;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

internal class ThisApplication {

	private readonly HttpClientConfigOption option;

	public ThisApplication(
	IOptions<HttpClientConfigOption> config,
	ILogger<ThisApplication> logger,
	IStringArguments arguments) {
		this.option = config.Value;
		logger.Log(LogLevel.Information,"Application constructed");

		Console.WriteLine("Hello, World!");
		
		foreach (var arg in arguments.Args) {
			Console.WriteLine(arg);
		}

		var data = string.Empty;
		do
		{
			Console.WriteLine("What do you now want to do?");
			data = Console.ReadLine();

		} while (data != string.Empty) ;

	}
}
