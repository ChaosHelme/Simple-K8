namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AppArmorProfile defines a pod or container's AppArmor settings.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AppArmorProfile
{
	/// <summary>
	/// localhostProfile indicates a profile loaded on the node that should be used. The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("localhostProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string LocalhostProfile { get; set; }

	/// <summary>
	/// type indicates which kind of AppArmor profile will be applied. Valid options are:
	/// <br/>  Localhost - a profile pre-loaded on the node.
	/// <br/>  RuntimeDefault - the container runtime's default profile.
	/// <br/>  Unconfined - no AppArmor enforcement.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}