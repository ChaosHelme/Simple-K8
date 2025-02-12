using Polly;
using Serilog;
using SimpleK8.Core;
using SimpleK8.Services;

var loggerConfig = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json")
	.Build();

var builder = Host.CreateDefaultBuilder(args)
	.UseSerilog((_, services, configuration) => configuration
	.ReadFrom.Configuration(loggerConfig)
	.ReadFrom.Services(services)
	.Enrich.FromLogContext()
	.WriteTo.Console());

builder.ConfigureAppConfiguration(config =>
{
	config.AddJsonFile("appsettings.json");
});
builder.ConfigureServices(ConfigureDelegate);

var host = builder.Build();
await host.RunAsync();
return;

void ConfigureDelegate(HostBuilderContext context, IServiceCollection services)
{
	services
		.AddHostedService<DeploymentBackgroundService>()
		.AddScoped<IServiceRegistry, ServiceRegistry>()
		.AddSingleton<KubernetesHttpClientFactory>();
	
	services
		.AddHttpClient("kubernetes")
		.AddTransientHttpErrorPolicy(httpClientBuilder => httpClientBuilder.WaitAndRetryAsync([
			TimeSpan.FromSeconds(1),
			TimeSpan.FromSeconds(5),
			TimeSpan.FromSeconds(10),
		]))
		.AddTransientHttpErrorPolicy(httpClientBuilder => httpClientBuilder.CircuitBreakerAsync(
			handledEventsAllowedBeforeBreaking: 3,
			durationOfBreak: TimeSpan.FromSeconds(30)));
}