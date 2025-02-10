namespace SimpleK8.Core.DataContracts;

/// <summary>
/// The node this Taint is attached to has the "effect" on any pod that does not tolerate the Taint.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Taint
{
	/// <summary>
	/// Required. The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("effect", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Effect { get; set; }

	/// <summary>
	/// Required. The taint key to be applied to a node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Key { get; set; }

	/// <summary>
	/// TimeAdded represents the time at which the taint was added. It is only written for NoExecute taints.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("timeAdded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? TimeAdded { get; set; }

	/// <summary>
	/// The taint value corresponding to the taint key.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Value { get; set; }

}