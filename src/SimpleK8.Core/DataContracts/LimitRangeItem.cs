namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LimitRangeItem defines a min/max usage limit for any resource that matches on kind.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LimitRangeItem
{
	/// <summary>
	/// Default resource requirement limit value by resource name if resource limit is omitted.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Default { get; set; }

	/// <summary>
	/// DefaultRequest is the default resource requirement request value by resource name if resource request is omitted.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("defaultRequest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> DefaultRequest { get; set; }

	/// <summary>
	/// Max usage constraints on this kind by resource name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("max", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Max { get; set; }

	/// <summary>
	/// MaxLimitRequestRatio if specified, the named resource must have a request and limit that are both non-zero where limit divided by request is less than or equal to the enumerated value; this represents the max burst for the named resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("maxLimitRequestRatio", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> MaxLimitRequestRatio { get; set; }

	/// <summary>
	/// Min usage constraints on this kind by resource name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("min", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Min { get; set; }

	/// <summary>
	/// Type of resource that this limit applies to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}