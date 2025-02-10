namespace SimpleK8.Core.DataContracts;

/// <summary>
/// UncountedTerminatedPods holds UIDs of Pods that have terminated but haven't been accounted in Job status counters.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class UncountedTerminatedPods
{
	/// <summary>
	/// failed holds UIDs of failed Pods.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("failed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Failed { get; set; }

	/// <summary>
	/// succeeded holds UIDs of succeeded Pods.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("succeeded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Succeeded { get; set; }

}