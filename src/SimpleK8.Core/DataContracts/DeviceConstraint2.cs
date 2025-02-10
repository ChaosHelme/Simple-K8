namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceConstraint must have exactly one field set besides Requests.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceConstraint2
{
	/// <summary>
	/// MatchAttribute requires that all devices in question have this attribute and that its type and value are the same across those devices.
	/// <br/>
	/// <br/>For example, if you specified "dra.example.com/numa" (a hypothetical example!), then only devices in the same NUMA node will be chosen. A device which does not have that attribute will not be chosen. All devices should use a value of the same type for this attribute because that is part of its specification, but if one device doesn't, then it also will not be chosen.
	/// <br/>
	/// <br/>Must include the domain qualifier.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchAttribute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string MatchAttribute { get; set; }

	/// <summary>
	/// Requests is a list of the one or more requests in this claim which must co-satisfy this constraint. If a request is fulfilled by multiple devices, then all of the devices must satisfy the constraint. If this is not specified, this constraint applies to all requests in this claim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Requests { get; set; }

}