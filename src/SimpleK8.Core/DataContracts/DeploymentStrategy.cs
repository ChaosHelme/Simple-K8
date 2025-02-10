namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeploymentStrategy describes how to replace existing pods with new ones.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeploymentStrategy
{
	/// <summary>
	/// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rollingUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RollingUpdateDeployment RollingUpdate { get; set; }

	/// <summary>
	/// Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}