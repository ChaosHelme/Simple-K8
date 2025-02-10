namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceRequest is a request for devices required for a claim. This is typically a request for a single resource like a device, but can also ask for several identical devices.
/// <br/>
/// <br/>A DeviceClassName is currently required. Clients must check that it is indeed set. It's absence indicates that something changed in a way that is not supported by the client yet, in which case it must refuse to handle the request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceRequest
{
	/// <summary>
	/// AdminAccess indicates that this is a claim for administrative access to the device(s). Claims with AdminAccess are expected to be used for monitoring or other management services for a device.  They ignore all ordinary claims to the device with respect to access modes and any resource allocations.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling the DRAAdminAccess feature gate. Admin access is disabled if this field is unset or set to false, otherwise it is enabled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("adminAccess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? AdminAccess { get; set; }

	/// <summary>
	/// AllocationMode and its related fields define how devices are allocated to satisfy this request. Supported values are:
	/// <br/>
	/// <br/>- ExactCount: This request is for a specific number of devices.
	/// <br/>  This is the default. The exact number is provided in the
	/// <br/>  count field.
	/// <br/>
	/// <br/>- All: This request is for all of the matching devices in a pool.
	/// <br/>  At least one device must exist on the node for the allocation to succeed.
	/// <br/>  Allocation will fail if some devices are already allocated,
	/// <br/>  unless adminAccess is requested.
	/// <br/>
	/// <br/>If AllocationMode is not specified, the default mode is ExactCount. If the mode is ExactCount and count is not specified, the default count is one. Any other requests must specify this field.
	/// <br/>
	/// <br/>More modes may get added in the future. Clients must refuse to handle requests with unknown modes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocationMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string AllocationMode { get; set; }

	/// <summary>
	/// Count is used only when the count mode is "ExactCount". Must be greater than zero. If AllocationMode is ExactCount and this field is not specified, the default is one.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? Count { get; set; }

	/// <summary>
	/// DeviceClassName references a specific DeviceClass, which can define additional configuration and selectors to be inherited by this request.
	/// <br/>
	/// <br/>A class is required. Which classes are available depends on the cluster.
	/// <br/>
	/// <br/>Administrators may use this to restrict which devices may get requested by only installing classes with selectors for permitted devices. If users are free to request anything without restrictions, then administrators can create an empty DeviceClass for users to reference.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deviceClassName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string DeviceClassName { get; set; }

	/// <summary>
	/// Name can be used to reference this request in a pod.spec.containers[].resources.claims entry and in a constraint of the claim.
	/// <br/>
	/// <br/>Must be a DNS label.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Selectors define criteria which must be satisfied by a specific device in order for that device to be considered for this request. All selectors must be satisfied for a device to be considered.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selectors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceSelector> Selectors { get; set; }

}