#nullable disable
using System.ComponentModel.DataAnnotations;

internal class AppConfig: IAppConfig
{
	public string Setting { get; }
	public AppConfig()
	{
		Console.WriteLine("AppConfig constructed");
	}
}

public class RulesEngineServiceOptions
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RulesEngineServiceOptions" /> class.
	/// </summary>
	public RulesEngineServiceOptions()
	{
		HttpClientConfig = new HttpClientConfigOptions();
	}
	/// <summary>
	/// Gets or sets the HTTP client configuration.
	/// </summary>
	/// <value>The HTTP client configuration.</value>
	public HttpClientConfigOptions HttpClientConfig { get; set; }
}

public class HttpClientConfigOptions
{
	/// <summary>
	/// The HTTP client configuration
	/// </summary>
	public const string HttpClientConfig = "HttpClientConfig";
	/// <summary>
	/// Gets or sets the base address.
	/// </summary>
	/// <value>The base address.</value>
	[Required]
	public string BaseAddress { get; set; } = String.Empty;
	public string RequestTimeout { get; set; } = String.Empty;
	public string Agent { get; set; } = String.Empty;
	public Dictionary<string,string> Headers = new Dictionary<string,string>();
}
//namespace Creator.CLI
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{
//			Console.WriteLine("Hello, World!");
//			//-c 
//			if (args[0] != null && args[0].Length > 1)
//			{
//				if (args[1] != null && args[1].Length > 10)
//				{ }
//			}

//		}
//	}
//}