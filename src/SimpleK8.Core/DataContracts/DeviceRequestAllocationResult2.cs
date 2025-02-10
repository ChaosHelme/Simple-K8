namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceRequestAllocationResult contains the allocation result for one request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceRequestAllocationResult2
{
	/// <summary>
	/// AdminAccess indicates that this device was allocated for administrative access. See the corresponding request field for a definition of mode.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling the DRAAdminAccess feature gate. Admin access is disabled if this field is unset or set to false, otherwise it is enabled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("adminAccess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? AdminAccess { get; set; }

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
	/// This name together with the driver name and the device name field identify which device was allocated (`&lt;driver name&gt;/&lt;pool name&gt;/&lt;device name&gt;`).
	/// <br/>
	/// <br/>Must not be longer than 253 characters and may contain one or more DNS sub-domains separated by slashes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pool", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Pool { get; set; }

	/// <summary>
	/// Request is the name of the request in the claim which caused this device to be allocated. Multiple devices may have been allocated per request.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Request { get; set; }

}