namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceClaimConfiguration is used for configuration parameters in DeviceClaim.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceClaimConfiguration
{
	/// <summary>
	/// Opaque provides driver-specific configuration parameters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("opaque", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public OpaqueDeviceConfiguration Opaque { get; set; }

	/// <summary>
	/// Requests lists the names of requests where the configuration applies. If empty, it applies to all requests.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Requests { get; set; }

}