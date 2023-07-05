#nullable disable
using Creator.CLI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = CreateHostBuilder(args).Build();

ThisApplication app = host.Services.GetRequiredService<ThisApplication>();

static IHostBuilder CreateHostBuilder(string[] args) {
	var builder = Host.CreateDefaultBuilder(args)
	.ConfigureAppConfiguration(c => c.AddJsonFile("appsettings.json",optional: false,reloadOnChange: true))
	.ConfigureServices((hostContext,services) => {

		IConfiguration configuration = hostContext.Configuration;
		HttpClientConfigOption config = configuration
		.GetSection(HttpClientConfigOption.HttpClientConfig)
		.Get<HttpClientConfigOption>();
		services.AddLogging(b => b.AddConsole());

		services.AddTransient<IStringArguments,StringArguments>(a => new StringArguments(args.ToList()));
		services.AddOptions<HttpClientConfigOption>()
		.Bind(configuration.GetSection(HttpClientConfigOption.HttpClientConfig));

		services
							.AddSingleton<ThisApplication,ThisApplication>()
							.AddSingleton<IAppConfig,AppConfig>();

	});
	return builder;
}
