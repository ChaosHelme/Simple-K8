namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AllocationResult contains attributes of an allocated resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AllocationResult
{
	/// <summary>
	/// Devices is the result of allocating devices.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DeviceAllocationResult Devices { get; set; }

	/// <summary>
	/// NodeSelector defines where the allocated resources are available. If unset, they are available everywhere.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeSelector NodeSelector { get; set; }

}