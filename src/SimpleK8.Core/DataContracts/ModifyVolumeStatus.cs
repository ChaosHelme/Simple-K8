namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ModifyVolumeStatus represents the status object of ControllerModifyVolume operation
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ModifyVolumeStatus
{
	/// <summary>
	/// status is the status of the ControllerModifyVolume operation. It can be in any of following states:
	/// <br/> - Pending
	/// <br/>   Pending indicates that the PersistentVolumeClaim cannot be modified due to unmet requirements, such as
	/// <br/>   the specified VolumeAttributesClass not existing.
	/// <br/> - InProgress
	/// <br/>   InProgress indicates that the volume is being modified.
	/// <br/> - Infeasible
	/// <br/>  Infeasible indicates that the request has been rejected as invalid by the CSI driver. To
	/// <br/>	  resolve the error, a valid VolumeAttributesClass needs to be specified.
	/// <br/>Note: New statuses can be added in the future. Consumers should check for unknown statuses and fail appropriately.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Status { get; set; }

	/// <summary>
	/// targetVolumeAttributesClassName is the name of the VolumeAttributesClass the PVC currently being reconciled
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetVolumeAttributesClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TargetVolumeAttributesClassName { get; set; }

}