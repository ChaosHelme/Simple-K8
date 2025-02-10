namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceClassConfiguration is used in DeviceClass.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceClassConfiguration
{
	/// <summary>
	/// Opaque provides driver-specific configuration parameters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("opaque", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public OpaqueDeviceConfiguration Opaque { get; set; }

}