namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodFailurePolicyRule describes how a pod failure is handled when the requirements are met. One of onExitCodes and onPodConditions, but not both, can be used in each rule.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodFailurePolicyRule
{
	/// <summary>
	/// Specifies the action taken on a pod failure when the requirements are satisfied. Possible values are:
	/// <br/>
	/// <br/>- FailJob: indicates that the pod's job is marked as Failed and all
	/// <br/>  running pods are terminated.
	/// <br/>- FailIndex: indicates that the pod's index is marked as Failed and will
	/// <br/>  not be restarted.
	/// <br/>  This value is beta-level. It can be used when the
	/// <br/>  `JobBackoffLimitPerIndex` feature gate is enabled (enabled by default).
	/// <br/>- Ignore: indicates that the counter towards the .backoffLimit is not
	/// <br/>  incremented and a replacement pod is created.
	/// <br/>- Count: indicates that the pod is handled in the default way - the
	/// <br/>  counter towards the .backoffLimit is incremented.
	/// <br/>Additional values are considered to be added in the future. Clients should react to an unknown action by skipping the rule.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Action { get; set; }

	/// <summary>
	/// Represents the requirement on the container exit codes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("onExitCodes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodFailurePolicyOnExitCodesRequirement OnExitCodes { get; set; }

	/// <summary>
	/// Represents the requirement on the pod conditions. The requirement is represented as a list of pod condition patterns. The requirement is satisfied if at least one pattern matches an actual pod condition. At most 20 elements are allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("onPodConditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PodFailurePolicyOnPodConditionsPattern> OnPodConditions { get; set; }

}