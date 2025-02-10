namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceClaimSpec defines what is being requested in a ResourceClaim and how to configure it.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceClaimSpec
{
	/// <summary>
	/// Devices defines how to request devices.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DeviceClaim Devices { get; set; }

}