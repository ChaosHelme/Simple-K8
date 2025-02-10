namespace SimpleK8.Core.DataContracts;

/// <summary>
/// BasicDevice defines one device instance.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class BasicDevice2
{
	/// <summary>
	/// Attributes defines the set of attributes for this device. The name of each attribute must be unique in that set.
	/// <br/>
	/// <br/>The maximum number of attributes and capacities combined is 32.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("attributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, DeviceAttribute2> Attributes { get; set; }

	/// <summary>
	/// Capacity defines the set of capacities for this device. The name of each capacity must be unique in that set.
	/// <br/>
	/// <br/>The maximum number of attributes and capacities combined is 32.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, DeviceCapacity> Capacity { get; set; }

}