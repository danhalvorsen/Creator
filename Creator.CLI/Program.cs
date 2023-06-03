#nullable disable
using fields.Entities.HttpServices;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = CreateHostBuilder(args).Build();

ThisApplication app = host.Services.GetRequiredService<ThisApplication>();

static IHostBuilder CreateHostBuilder(string[] args)
{
	var builder = Host.CreateDefaultBuilder(args)
	.ConfigureAppConfiguration(c => c.AddJsonFile("appsettings.json",optional: false,reloadOnChange: true))
	.ConfigureServices((hostContext,services) =>
	{

		IConfiguration configuration = hostContext.Configuration;
		var config = configuration.GetSection(nameof(RulesEngineServiceOptions));
		services.AddLogging(b => b.AddConsole());

		//services.AddTransient<IPipelineBehavior<ExecuteWorkflowsRequest,WorkflowResponse>,LoadRuleBehavior>();
		//services.AddTransient<IPipelineBehavior<ExecuteWorkflowsRequest,WorkflowResponse>,LoadInputBehavior>();
		services.AddTransient<HttpClientConfig>();
		services.AddOptions<HttpClientConfig>();
		services.AddOptions<HttpClientConfigOptions>();

		services
							.AddSingleton<ThisApplication,ThisApplication>()
							.AddSingleton<IAppConfig,AppConfig>();
							
	});
	return builder;
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