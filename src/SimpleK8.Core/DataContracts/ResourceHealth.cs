namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceHealth represents the health of a resource. It has the latest device health information. This is a part of KEP https://kep.k8s.io/4680.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceHealth
{
	/// <summary>
	/// Health of the resource. can be one of:
	/// <br/> - Healthy: operates as normal
	/// <br/> - Unhealthy: reported unhealthy. We consider this a temporary health issue
	/// <br/>              since we do not have a mechanism today to distinguish
	/// <br/>              temporary and permanent issues.
	/// <br/> - Unknown: The status cannot be determined.
	/// <br/>            For example, Device Plugin got unregistered and hasn't been re-registered since.
	/// <br/>
	/// <br/>In future we may want to introduce the PermanentlyUnhealthy Status.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("health", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Health { get; set; }

	/// <summary>
	/// ResourceID is the unique identifier of the resource. See the ResourceID type for more information.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ResourceID { get; set; }

}