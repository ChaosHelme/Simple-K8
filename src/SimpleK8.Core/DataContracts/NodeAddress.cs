namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeAddress contains information for the node's address.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeAddress
{
	/// <summary>
	/// The node address.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Address { get; set; }

	/// <summary>
	/// Node address type, one of Hostname, ExternalIP or InternalIP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}