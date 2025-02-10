namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceSelector must have exactly one field set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceSelector2
{
	/// <summary>
	/// CEL contains a CEL expression for selecting a device.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CELDeviceSelector2 Cel { get; set; }

}