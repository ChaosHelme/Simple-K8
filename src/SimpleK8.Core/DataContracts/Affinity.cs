namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Affinity is a group of affinity scheduling rules.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Affinity
{
	/// <summary>
	/// Describes node affinity scheduling rules for the pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeAffinity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeAffinity NodeAffinity { get; set; }

	/// <summary>
	/// Describes pod affinity scheduling rules (e.g. co-locate this pod in the same node, zone, etc. as some other pod(s)).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podAffinity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodAffinity PodAffinity { get; set; }

	/// <summary>
	/// Describes pod anti-affinity scheduling rules (e.g. avoid putting this pod in the same node, zone, etc. as some other pod(s)).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podAntiAffinity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodAntiAffinity PodAntiAffinity { get; set; }

}