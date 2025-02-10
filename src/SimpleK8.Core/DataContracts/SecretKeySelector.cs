namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SecretKeySelector selects a key of a Secret.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SecretKeySelector
{
	/// <summary>
	/// The key of the secret to select from.  Must be a valid secret key.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Key { get; set; }

	/// <summary>
	/// Name of the referent. This field is effectively required, but due to backwards compatibility is allowed to be empty. Instances of this type with an empty value here are almost certainly wrong. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Specify whether the Secret or its key must be defined
	/// </summary>
	[Newtonsoft.Json.JsonProperty("optional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Optional { get; set; }

}