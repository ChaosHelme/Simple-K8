using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleK8.Console;
using SimpleK8.Core;

var builder = Host.CreateDefaultBuilder(args);
builder.ConfigureServices(ConfigureServices);

await builder.RunConsoleAsync();
return;

void ConfigureServices(IServiceCollection serviceCollection)
{
	serviceCollection.AddLogging(loggingBuilder => loggingBuilder.AddConsole());
	serviceCollection.AddHostedService<HostedService>();
	serviceCollection.AddScoped<IServiceRegistry, ServiceRegistry>();
}

 