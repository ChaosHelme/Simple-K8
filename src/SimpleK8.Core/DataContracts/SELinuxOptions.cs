namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SELinuxOptions are the labels to be applied to the container
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SELinuxOptions
{
	/// <summary>
	/// Level is SELinux level label that applies to the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("level", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Level { get; set; }

	/// <summary>
	/// Role is a SELinux role label that applies to the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Role { get; set; }

	/// <summary>
	/// Type is a SELinux type label that applies to the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

	/// <summary>
	/// User is a SELinux user label that applies to the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string User { get; set; }

}