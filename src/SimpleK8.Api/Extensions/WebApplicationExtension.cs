using System.Diagnostics;
using Serilog;

namespace SimpleK8.Api.Extensions;

internal static class WebApplicationExtension {
	const string BasePath = "/modulith";
	
	internal static void ConfigureWebApplication(this WebApplication webApplication) {
		webApplication.UseSerilogRequestLogging();
		
		webApplication.UseAuthentication();
		webApplication.UseAuthorization();

		webApplication.UseHealthChecks("/api/health");
		
		webApplication.UsePathBase(BasePath);
		webApplication.MapControllers();
		webApplication.UseHttpsRedirection();

		if (webApplication.Environment.IsDevelopment() || Debugger.IsAttached)
		{
			webApplication.UseSwaggerUI();
			webApplication.MapSwagger();
		}
		
		webApplication.MapHealthChecks("/api/health");
	}
}