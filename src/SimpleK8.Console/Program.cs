using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Polly;
using Serilog;
using Serilog.Debugging;
using SimpleK8.Console;
using SimpleK8.Core;

var loggerConfig = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json")
	.Build();

var builder = Host.CreateDefaultBuilder(args)
	.UseSerilog((context, services, configuration) => configuration
		.ReadFrom.Configuration(loggerConfig)
		.ReadFrom.Services(services)
		.Enrich.FromLogContext()
		.WriteTo.Console());

SelfLog.Enable(Console.Error);

builder.ConfigureServices(ConfigureServices);

await builder.RunConsoleAsync();

return;

void ConfigureServices(IServiceCollection serviceCollection)
{
	serviceCollection
		.AddHostedService<HostedService>()
		.AddScoped<IServiceRegistry, ServiceRegistry>();
	
	serviceCollection
		.AddHttpClient("kubernetes", client =>
		{
			client.BaseAddress = new Uri("http://localhost:5077/apis/app/v1/");
		})
		.AddTransientHttpErrorPolicy(httpClientBuilder => httpClientBuilder.WaitAndRetryAsync([
			TimeSpan.FromSeconds(1),
			TimeSpan.FromSeconds(5),
			TimeSpan.FromSeconds(10),
		]))
		.AddTransientHttpErrorPolicy(httpClientBuilder => httpClientBuilder.CircuitBreakerAsync(
			handledEventsAllowedBeforeBreaking: 3,
			durationOfBreak: TimeSpan.FromSeconds(30)));
}
 