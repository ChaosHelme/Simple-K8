namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceClaimStatus tracks whether the resource has been allocated and what the result of that was.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceClaimStatus
{
	/// <summary>
	/// Allocation is set once the claim has been allocated successfully.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public AllocationResult Allocation { get; set; }

	/// <summary>
	/// Devices contains the status of each device allocated for this claim, as reported by the driver. This can include driver-specific information. Entries are owned by their respective drivers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<AllocatedDeviceStatus> Devices { get; set; }

	/// <summary>
	/// ReservedFor indicates which entities are currently allowed to use the claim. A Pod which references a ResourceClaim which is not reserved for that Pod will not be started. A claim that is in use or might be in use because it has been reserved must not get deallocated.
	/// <br/>
	/// <br/>In a cluster with multiple scheduler instances, two pods might get scheduled concurrently by different schedulers. When they reference the same ResourceClaim which already has reached its maximum number of consumers, only one pod can be scheduled.
	/// <br/>
	/// <br/>Both schedulers try to add their pod to the claim.status.reservedFor field, but only the update that reaches the API server first gets stored. The other one fails with an error and the scheduler which issued it knows that it must put the pod back into the queue, waiting for the ResourceClaim to become usable again.
	/// <br/>
	/// <br/>There can be at most 256 such reservations. This may get increased in the future, but not reduced.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reservedFor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ResourceClaimConsumerReference> ReservedFor { get; set; }

}