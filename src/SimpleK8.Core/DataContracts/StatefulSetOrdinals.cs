namespace SimpleK8.Core.DataContracts;

/// <summary>
/// StatefulSetOrdinals describes the policy used for replica ordinal assignment in this StatefulSet.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StatefulSetOrdinals
{
	/// <summary>
	/// start is the number representing the first replica's index. It may be used to number replicas from an alternate index (eg: 1-indexed) over the default 0-indexed names, or to orchestrate progressive movement of replicas from one StatefulSet to another. If set, replica indices will be in the range:
	/// <br/>  [.spec.ordinals.start, .spec.ordinals.start + .spec.replicas).
	/// <br/>If unset, defaults to 0. Replica indices will be in the range:
	/// <br/>  [0, .spec.replicas).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Start { get; set; }

}