namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AggregationRule
{
	/// <summary>
	/// ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules. If any of the selectors match, then the ClusterRole's permissions will be added
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clusterRoleSelectors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<LabelSelector> ClusterRoleSelectors { get; set; }

}