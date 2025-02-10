namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PersistentVolumeClaimStatus is the current status of a persistent volume claim.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PersistentVolumeClaimStatus
{
	/// <summary>
	/// accessModes contains the actual access modes the volume backing the PVC has. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
	/// </summary>
	[Newtonsoft.Json.JsonProperty("accessModes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> AccessModes { get; set; }

	/// <summary>
	/// allocatedResourceStatuses stores status of resource being resized for the given PVC. Key names follow standard Kubernetes label syntax. Valid values are either:
	/// <br/>	* Un-prefixed keys:
	/// <br/>		- storage - the capacity of the volume.
	/// <br/>	* Custom resources must use implementation-defined prefixed names such as "example.com/my-custom-resource"
	/// <br/>Apart from above values - keys that are unprefixed or have kubernetes.io prefix are considered reserved and hence may not be used.
	/// <br/>
	/// <br/>ClaimResourceStatus can be in any of following states:
	/// <br/>	- ControllerResizeInProgress:
	/// <br/>		State set when resize controller starts resizing the volume in control-plane.
	/// <br/>	- ControllerResizeFailed:
	/// <br/>		State set when resize has failed in resize controller with a terminal error.
	/// <br/>	- NodeResizePending:
	/// <br/>		State set when resize controller has finished resizing the volume but further resizing of
	/// <br/>		volume is needed on the node.
	/// <br/>	- NodeResizeInProgress:
	/// <br/>		State set when kubelet starts resizing the volume.
	/// <br/>	- NodeResizeFailed:
	/// <br/>		State set when resizing has failed in kubelet with a terminal error. Transient errors don't set
	/// <br/>		NodeResizeFailed.
	/// <br/>For example: if expanding a PVC for more capacity - this field can be one of the following states:
	/// <br/>	- pvc.status.allocatedResourceStatus['storage'] = "ControllerResizeInProgress"
	/// <br/>     - pvc.status.allocatedResourceStatus['storage'] = "ControllerResizeFailed"
	/// <br/>     - pvc.status.allocatedResourceStatus['storage'] = "NodeResizePending"
	/// <br/>     - pvc.status.allocatedResourceStatus['storage'] = "NodeResizeInProgress"
	/// <br/>     - pvc.status.allocatedResourceStatus['storage'] = "NodeResizeFailed"
	/// <br/>When this field is not set, it means that no resize operation is in progress for the given PVC.
	/// <br/>
	/// <br/>A controller that receives PVC update with previously unknown resourceName or ClaimResourceStatus should ignore the update for the purpose it was designed. For example - a controller that only is responsible for resizing capacity of the volume, should ignore PVC updates that change other valid resources associated with PVC.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling RecoverVolumeExpansionFailure feature.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocatedResourceStatuses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> AllocatedResourceStatuses { get; set; }

	/// <summary>
	/// allocatedResources tracks the resources allocated to a PVC including its capacity. Key names follow standard Kubernetes label syntax. Valid values are either:
	/// <br/>	* Un-prefixed keys:
	/// <br/>		- storage - the capacity of the volume.
	/// <br/>	* Custom resources must use implementation-defined prefixed names such as "example.com/my-custom-resource"
	/// <br/>Apart from above values - keys that are unprefixed or have kubernetes.io prefix are considered reserved and hence may not be used.
	/// <br/>
	/// <br/>Capacity reported here may be larger than the actual capacity when a volume expansion operation is requested. For storage quota, the larger value from allocatedResources and PVC.spec.resources is used. If allocatedResources is not set, PVC.spec.resources alone is used for quota calculation. If a volume expansion capacity request is lowered, allocatedResources is only lowered if there are no expansion operations in progress and if the actual volume capacity is equal or lower than the requested capacity.
	/// <br/>
	/// <br/>A controller that receives PVC update with previously unknown resourceName should ignore the update for the purpose it was designed. For example - a controller that only is responsible for resizing capacity of the volume, should ignore PVC updates that change other valid resources associated with PVC.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling RecoverVolumeExpansionFailure feature.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocatedResources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> AllocatedResources { get; set; }

	/// <summary>
	/// capacity represents the actual resources of the underlying volume.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Capacity { get; set; }

	/// <summary>
	/// conditions is the current Condition of persistent volume claim. If underlying persistent volume is being resized then the Condition will be set to 'Resizing'.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PersistentVolumeClaimCondition> Conditions { get; set; }

	/// <summary>
	/// currentVolumeAttributesClassName is the current name of the VolumeAttributesClass the PVC is using. When unset, there is no VolumeAttributeClass applied to this PersistentVolumeClaim This is a beta field and requires enabling VolumeAttributesClass feature (off by default).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentVolumeAttributesClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string CurrentVolumeAttributesClassName { get; set; }

	/// <summary>
	/// ModifyVolumeStatus represents the status object of ControllerModifyVolume operation. When this is unset, there is no ModifyVolume operation being attempted. This is a beta field and requires enabling VolumeAttributesClass feature (off by default).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("modifyVolumeStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ModifyVolumeStatus ModifyVolumeStatus { get; set; }

	/// <summary>
	/// phase represents the current phase of PersistentVolumeClaim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Phase { get; set; }

}