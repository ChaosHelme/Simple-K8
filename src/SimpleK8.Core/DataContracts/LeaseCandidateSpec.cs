namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LeaseCandidateSpec is a specification of a Lease.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LeaseCandidateSpec
{
	/// <summary>
	/// BinaryVersion is the binary version. It must be in a semver format without leading `v`. This field is required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("binaryVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string BinaryVersion { get; set; }

	/// <summary>
	/// EmulationVersion is the emulation version. It must be in a semver format without leading `v`. EmulationVersion must be less than or equal to BinaryVersion. This field is required when strategy is "OldestEmulationVersion"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("emulationVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string EmulationVersion { get; set; }

	/// <summary>
	/// LeaseName is the name of the lease for which this candidate is contending. This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("leaseName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string LeaseName { get; set; }

	/// <summary>
	/// PingTime is the last time that the server has requested the LeaseCandidate to renew. It is only done during leader election to check if any LeaseCandidates have become ineligible. When PingTime is updated, the LeaseCandidate will respond by updating RenewTime.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pingTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? PingTime { get; set; }

	/// <summary>
	/// RenewTime is the time that the LeaseCandidate was last updated. Any time a Lease needs to do leader election, the PingTime field is updated to signal to the LeaseCandidate that they should update the RenewTime. Old LeaseCandidate objects are also garbage collected if it has been hours since the last renew. The PingTime field is updated regularly to prevent garbage collection for still active LeaseCandidates.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("renewTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? RenewTime { get; set; }

	/// <summary>
	/// Strategy is the strategy that coordinated leader election will use for picking the leader. If multiple candidates for the same Lease return different strategies, the strategy provided by the candidate with the latest BinaryVersion will be used. If there is still conflict, this is a user error and coordinated leader election will not operate the Lease until resolved. (Alpha) Using this field requires the CoordinatedLeaderElection feature gate to be enabled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("strategy", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Strategy { get; set; }

}