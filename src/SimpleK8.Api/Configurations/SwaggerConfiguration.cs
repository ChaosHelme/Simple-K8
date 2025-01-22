using System.Reflection;
using Microsoft.OpenApi.Models;

namespace SimpleK8.Api.Configurations;

internal static class SwaggerConfiguration {
	public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services) {
		return services.AddSwaggerGen(o => {
			o.SchemaFilter<EnumSchemaFilter>();
			o.SwaggerDoc("v1", new OpenApiInfo { Title = "SimpleK8.Api", Version = "v1" });
			o.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
				In = ParameterLocation.Header,
				Description = "Please enter a valid token",
				Name = "Authorization",
				Type = SecuritySchemeType.Http,
				BearerFormat = "JWT",
				Scheme = "Bearer"
			});
			var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
			var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
			o.IncludeXmlComments(xmlPath);
			o.AddSecurityRequirement(new OpenApiSecurityRequirement {
				{
					new OpenApiSecurityScheme {
						Reference = new OpenApiReference {
							Type = ReferenceType.SecurityScheme,
							Id = "Bearer"
						}
					},
					[]
				}
			});
		});
	}
}