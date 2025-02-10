namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceCapacity describes a quantity associated with a device.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceCapacity
{
	/// <summary>
	/// Value defines how much of a certain device capacity is available.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Value { get; set; }

}