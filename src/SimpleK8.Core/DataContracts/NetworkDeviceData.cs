namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NetworkDeviceData provides network-related details for the allocated device. This information may be filled by drivers or other components to configure or identify the device within a network context.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NetworkDeviceData
{
	/// <summary>
	/// HardwareAddress represents the hardware address (e.g. MAC Address) of the device's network interface.
	/// <br/>
	/// <br/>Must not be longer than 128 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hardwareAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string HardwareAddress { get; set; }

	/// <summary>
	/// InterfaceName specifies the name of the network interface associated with the allocated device. This might be the name of a physical or virtual network interface being configured in the pod.
	/// <br/>
	/// <br/>Must not be longer than 256 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("interfaceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string InterfaceName { get; set; }

	/// <summary>
	/// IPs lists the network addresses assigned to the device's network interface. This can include both IPv4 and IPv6 addresses. The IPs are in the CIDR notation, which includes both the address and the associated subnet mask. e.g.: "192.0.2.5/24" for IPv4 and "2001:db8::5/64" for IPv6.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Ips { get; set; }

}