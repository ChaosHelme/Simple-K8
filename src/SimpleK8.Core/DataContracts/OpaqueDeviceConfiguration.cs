namespace SimpleK8.Core.DataContracts;

/// <summary>
/// OpaqueDeviceConfiguration contains configuration parameters for a driver in a format defined by the driver vendor.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class OpaqueDeviceConfiguration
{
	/// <summary>
	/// Driver is used to determine which kubelet plugin needs to be passed these configuration parameters.
	/// <br/>
	/// <br/>An admission policy provided by the driver developer could use this to decide whether it needs to validate them.
	/// <br/>
	/// <br/>Must be a DNS subdomain and should end with a DNS domain owned by the vendor of the driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("driver", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Driver { get; set; }

	/// <summary>
	/// Parameters can contain arbitrary data. It is the responsibility of the driver developer to handle validation and versioning. Typically this includes self-identification and a version ("kind" + "apiVersion" for Kubernetes types), with conversion between different versions.
	/// <br/>
	/// <br/>The length of the raw data must be smaller or equal to 10 Ki.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public RawExtension Parameters { get; set; } = new RawExtension();

}