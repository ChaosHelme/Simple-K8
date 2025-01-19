using System.Text.Json.Serialization;
using Serilog;
using SimpleK8.Api.Configurations;
using SimpleK8.ControlPlane;

namespace SimpleK8.Api.Extensions;

internal static class WebApplicationBuilderExtension {
	internal static WebApplication CreateApplication(this WebApplicationBuilder builder) {
		
		builder.Services.AddSerilog();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerConfiguration();
		builder.Services.AddControllers().AddJsonOptions(options =>
		{
			options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
		});
		builder.Services.AddAuthentication();
		builder.Services.AddAuthorization();

		builder.Services.AddHealthChecks();

		builder.Services.AddTransient<IStore, PersistentClusterStore>();
		
		// builder.Services.AddTransient<IDbConnectionFactory, NpgsqlServerConnectionFactory>();
		// builder.Services
		// 	.AddScoped<TransactionalDbConnectionProvider>()
		// 	.AddScoped<IDbConnectionProvider, TransactionalDbConnectionProvider>(sp => sp.GetRequiredService<TransactionalDbConnectionProvider>())
		// 	.AddScoped<IDbContextResolver, ModuleDbContextResolver>();
		
		
		builder.Services.AddDefaultApiVersioning();
		
		var application = builder.Build();
		application.ConfigureWebApplication();
		
		return application;
	}
}