using Asp.Versioning;

namespace SimpleK8.Api.Extensions;

internal static class ApiVersioningExtensions {
	internal static void AddDefaultApiVersioning(this IServiceCollection services)
	{
		services
			.AddApiVersioning(options =>
			{
				options.DefaultApiVersion = new ApiVersion(1, 0);
				options.AssumeDefaultVersionWhenUnspecified = true;
				options.ReportApiVersions = true;
				options.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
					new HeaderApiVersionReader("X-Api-Version"));
			})
			.AddMvc()
			.AddApiExplorer(options =>
			{
				options.GroupNameFormat = "'v'VVV";
				options.SubstituteApiVersionInUrl = true;
			});
	}
}