namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IPBlock describes a particular CIDR (Ex. "192.168.1.0/24","2001:db8::/64") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IPBlock
{
	/// <summary>
	/// cidr is a string representing the IPBlock Valid examples are "192.168.1.0/24" or "2001:db8::/64"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cidr", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Cidr { get; set; }

	/// <summary>
	/// except is a slice of CIDRs that should not be included within an IPBlock Valid examples are "192.168.1.0/24" or "2001:db8::/64" Except values will be rejected if they are outside the cidr range
	/// </summary>
	[Newtonsoft.Json.JsonProperty("except", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Except { get; set; }

}