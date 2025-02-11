using System.Text.Json.Serialization;
using dotnet_etcd;
using dotnet_etcd.interfaces;
using Grpc.Core;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
using Serilog;
using SimpleK8.Api.Configurations;
using SimpleK8.Application;
using SimpleK8.Application.Queries;
using SimpleK8.Infrastructure;

namespace SimpleK8.Api.Extensions;

internal static class WebApplicationBuilderExtension {
	internal static WebApplication CreateApplication(this WebApplicationBuilder builder)
	{
		builder.Services.AddOpenTelemetry()
			.WithTracing(config =>
			{
				config
					.AddHttpClientInstrumentation()
					.AddAspNetCoreInstrumentation()
					.AddOtlpExporter();
			})
			.WithMetrics(config =>
			{
				config
					.AddHttpClientInstrumentation()
					.AddAspNetCoreInstrumentation()
					.AddOtlpExporter();
			});
		
		builder.Services.AddMediatR(options =>
		{
			options.AutoRegisterRequestProcessors = true;
			options.RegisterServicesFromAssembly(typeof(GetDeploymentQuery).Assembly);
		});
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
		
		builder.Services.AddTransient<IEtcdClient, EtcdClient>(_
			=> new EtcdClient(builder.Configuration.GetConnectionString("etcd"),
				configureChannelOptions: options => options.Credentials = ChannelCredentials.Insecure));
		builder.Services.AddTransient<IDeploymentRepository, DeploymentRepository>();
		
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