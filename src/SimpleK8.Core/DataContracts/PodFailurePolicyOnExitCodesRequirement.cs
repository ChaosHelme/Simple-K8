namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodFailurePolicyOnExitCodesRequirement describes the requirement for handling a failed pod based on its container exit codes. In particular, it lookups the .state.terminated.exitCode for each app container and init container status, represented by the .status.containerStatuses and .status.initContainerStatuses fields in the Pod status, respectively. Containers completed with success (exit code 0) are excluded from the requirement check.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodFailurePolicyOnExitCodesRequirement
{
	/// <summary>
	/// Restricts the check for exit codes to the container with the specified name. When null, the rule applies to all containers. When specified, it should match one the container or initContainer names in the pod template.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ContainerName { get; set; }

	/// <summary>
	/// Represents the relationship between the container exit code(s) and the specified values. Containers completed with success (exit code 0) are excluded from the requirement check. Possible values are:
	/// <br/>
	/// <br/>- In: the requirement is satisfied if at least one container exit code
	/// <br/>  (might be multiple if there are multiple containers not restricted
	/// <br/>  by the 'containerName' field) is in the set of specified values.
	/// <br/>- NotIn: the requirement is satisfied if at least one container exit code
	/// <br/>  (might be multiple if there are multiple containers not restricted
	/// <br/>  by the 'containerName' field) is not in the set of specified values.
	/// <br/>Additional values are considered to be added in the future. Clients should react to an unknown operator by assuming the requirement is not satisfied.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("operator", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Operator { get; set; }

	/// <summary>
	/// Specifies the set of values. Each returned container exit code (might be multiple in case of multiple containers) is checked against this set of values with respect to the operator. The list of values must be ordered and must not contain duplicates. Value '0' cannot be used for the In operator. At least one element is required. At most 255 elements are allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<int> Values { get; set; } = new System.Collections.Generic.List<int>();

}