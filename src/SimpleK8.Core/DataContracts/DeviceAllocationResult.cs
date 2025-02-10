namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceAllocationResult is the result of allocating devices.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceAllocationResult
{
	/// <summary>
	/// This field is a combination of all the claim and class configuration parameters. Drivers can distinguish between those based on a flag.
	/// <br/>
	/// <br/>This includes configuration parameters for drivers which have no allocated devices in the result because it is up to the drivers which configuration parameters they support. They can silently ignore unknown configuration parameters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("config", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceAllocationConfiguration> Config { get; set; }

	/// <summary>
	/// Results lists all allocated devices.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("results", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceRequestAllocationResult> Results { get; set; }

}