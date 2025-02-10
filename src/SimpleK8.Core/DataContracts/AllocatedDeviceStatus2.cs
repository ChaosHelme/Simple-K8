namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AllocatedDeviceStatus contains the status of an allocated device, if the driver chooses to report it. This may include driver-specific information.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AllocatedDeviceStatus2
{
	/// <summary>
	/// Conditions contains the latest observation of the device's state. If the device has been configured according to the class and claim config references, the `Ready` condition should be True.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Condition> Conditions { get; set; }

	/// <summary>
	/// Data contains arbitrary driver-specific data.
	/// <br/>
	/// <br/>The length of the raw data must be smaller or equal to 10 Ki.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RawExtension Data { get; set; }

	/// <summary>
	/// Device references one device instance via its name in the driver's resource pool. It must be a DNS label.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("device", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Device { get; set; }

	/// <summary>
	/// Driver specifies the name of the DRA driver whose kubelet plugin should be invoked to process the allocation once the claim is needed on a node.
	/// <br/>
	/// <br/>Must be a DNS subdomain and should end with a DNS domain owned by the vendor of the driver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("driver", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Driver { get; set; }

	/// <summary>
	/// NetworkData contains network-related information specific to the device.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("networkData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NetworkDeviceData2 NetworkData { get; set; }

	/// <summary>
	/// This name together with the driver name and the device name field identify which device was allocated (`&lt;driver name&gt;/&lt;pool name&gt;/&lt;device name&gt;`).
	/// <br/>
	/// <br/>Must not be longer than 253 characters and may contain one or more DNS sub-domains separated by slashes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pool", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Pool { get; set; }

}