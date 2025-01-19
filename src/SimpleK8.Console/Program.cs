using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleK8.Console;
using SimpleK8.ControlPlane;
using SimpleK8.Core;

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices(ConfigureServices);

await builder.RunConsoleAsync();
return;

void ConfigureServices(IServiceCollection serviceCollection)
{
	serviceCollection
		.AddLogging(loggingBuilder => loggingBuilder.AddConsole())
		.AddHostedService<HostedService>()
		.AddScoped<IServiceRegistry, ServiceRegistry>()
		.AddScoped<IApiServer, ApiServer>()
		.AddScoped<IScheduler, Scheduler>()
		.AddScoped<IControllerManager, ControllerManager>()
		.AddScoped<IStore, PersistentClusterStore>();
}

 