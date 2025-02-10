namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LeaseSpec is a specification of a Lease.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LeaseSpec
{
	/// <summary>
	/// acquireTime is a time when the current lease was acquired.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("acquireTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? AcquireTime { get; set; }

	/// <summary>
	/// holderIdentity contains the identity of the holder of a current lease. If Coordinated Leader Election is used, the holder identity must be equal to the elected LeaseCandidate.metadata.name field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("holderIdentity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string HolderIdentity { get; set; }

	/// <summary>
	/// leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measured against the time of last observed renewTime.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("leaseDurationSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? LeaseDurationSeconds { get; set; }

	/// <summary>
	/// leaseTransitions is the number of transitions of a lease between holders.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("leaseTransitions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? LeaseTransitions { get; set; }

	/// <summary>
	/// PreferredHolder signals to a lease holder that the lease has a more optimal holder and should be given up. This field can only be set if Strategy is also set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("preferredHolder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PreferredHolder { get; set; }

	/// <summary>
	/// renewTime is a time when the current holder of a lease has last updated the lease.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("renewTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? RenewTime { get; set; }

	/// <summary>
	/// Strategy indicates the strategy for picking the leader for coordinated leader election. If the field is not specified, there is no active coordination for this lease. (Alpha) Using this field requires the CoordinatedLeaderElection feature gate to be enabled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("strategy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Strategy { get; set; }

}