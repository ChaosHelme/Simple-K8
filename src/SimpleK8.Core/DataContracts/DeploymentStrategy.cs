using System.Text.Json.Serialization;

namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeploymentStrategy describes how to replace existing pods with new ones.
/// </summary>
public partial class DeploymentStrategy
{
	/// <summary>
	/// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
	/// </summary>
	[JsonPropertyName("rollingUpdate")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public RollingUpdateDeployment RollingUpdate { get; set; } = new RollingUpdateDeployment();

	/// <summary>
	/// Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
	/// </summary>
	[JsonPropertyName("type")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Type { get; set; } = "RollingUpdate";

}