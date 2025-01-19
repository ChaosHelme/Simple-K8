using Serilog;
using Serilog.Events;
using SimpleK8.Api.Extensions;

Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
	.WriteTo.Console()
	.CreateLogger();

try {
	var builder = WebApplication.CreateBuilder(args);

	var application = builder.CreateApplication();

	await application.RunAsync();
} catch (Exception ex) {
	Log.Fatal(ex, "Application terminated unexpectedly");
} finally {
	await Log.CloseAndFlushAsync();
}