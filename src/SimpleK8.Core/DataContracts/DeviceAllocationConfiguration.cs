namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceAllocationConfiguration gets embedded in an AllocationResult.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceAllocationConfiguration
{
	/// <summary>
	/// Opaque provides driver-specific configuration parameters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("opaque", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public OpaqueDeviceConfiguration Opaque { get; set; }

	/// <summary>
	/// Requests lists the names of requests where the configuration applies. If empty, its applies to all requests.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Requests { get; set; }

	/// <summary>
	/// Source records whether the configuration comes from a class and thus is not something that a normal user would have been able to set or from a claim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Source { get; set; }

}