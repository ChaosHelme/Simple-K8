namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Projection that may be projected along with other supported volume types. Exactly one of these fields must be set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeProjection
{
	/// <summary>
	/// ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.
	/// <br/>
	/// <br/>Alpha, gated by the ClusterTrustBundleProjection feature gate.
	/// <br/>
	/// <br/>ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.
	/// <br/>
	/// <br/>Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clusterTrustBundle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ClusterTrustBundleProjection ClusterTrustBundle { get; set; }

	/// <summary>
	/// configMap information about the configMap data to project
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ConfigMapProjection ConfigMap { get; set; }

	/// <summary>
	/// downwardAPI information about the downwardAPI data to project
	/// </summary>
	[Newtonsoft.Json.JsonProperty("downwardAPI", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DownwardAPIProjection DownwardAPI { get; set; }

	/// <summary>
	/// secret information about the secret data to project
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretProjection Secret { get; set; }

	/// <summary>
	/// serviceAccountToken is information about the serviceAccountToken data to project
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serviceAccountToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ServiceAccountTokenProjection ServiceAccountToken { get; set; }

}