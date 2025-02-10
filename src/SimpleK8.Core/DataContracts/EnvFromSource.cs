namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EnvFromSource represents the source of a set of ConfigMaps or Secrets
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EnvFromSource
{
	/// <summary>
	/// The ConfigMap to select from
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configMapRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ConfigMapEnvSource ConfigMapRef { get; set; }

	/// <summary>
	/// Optional text to prepend to the name of each environment variable. Must be a C_IDENTIFIER.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("prefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Prefix { get; set; }

	/// <summary>
	/// The Secret to select from
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretEnvSource SecretRef { get; set; }

}