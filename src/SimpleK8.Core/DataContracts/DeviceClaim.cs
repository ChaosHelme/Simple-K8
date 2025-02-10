namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceClaim defines how to request devices with a ResourceClaim.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceClaim
{
	/// <summary>
	/// This field holds configuration for multiple potential drivers which could satisfy requests in this claim. It is ignored while allocating the claim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("config", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceClaimConfiguration> Config { get; set; }

	/// <summary>
	/// These constraints must be satisfied by the set of devices that get allocated for the claim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("constraints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceConstraint> Constraints { get; set; }

	/// <summary>
	/// Requests represent individual requests for distinct devices which must all be satisfied. If empty, nothing needs to be allocated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceRequest> Requests { get; set; }

}