namespace SimpleK8.Core.DataContracts;

/// <summary>
/// StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates. It includes any additional parameters necessary to perform the update for the indicated strategy.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StatefulSetUpdateStrategy
{
	/// <summary>
	/// RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rollingUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RollingUpdateStatefulSetStrategy RollingUpdate { get; set; }

	/// <summary>
	/// Type indicates the type of the StatefulSetUpdateStrategy. Default is RollingUpdate.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}