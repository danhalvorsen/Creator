#nullable disable
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

internal class ThisApplication
{
	private readonly IOptions<HttpClientConfig> config;

	public ThisApplication(IOptions<HttpClientConfig> config,ILogger<ThisApplication> logger)
	{
		this.config = config;
		//this.service = service;
		logger.Log(LogLevel.Information,"Application constructed");
		this.config = config;
	}
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