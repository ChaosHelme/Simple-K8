namespace SimpleK8.Core.DataContracts;

/// <summary>
/// UserInfo holds the information about the user needed to implement the user.Info interface.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class UserInfo
{
	/// <summary>
	/// Any additional information provided by the authenticator.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("extra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> Extra { get; set; }

	/// <summary>
	/// The names of groups this user is a part of.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("groups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Groups { get; set; }

	/// <summary>
	/// A unique value that identifies this user across time. If this user is deleted and another user by the same name is added, they will have different UIDs.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

	/// <summary>
	/// The name that uniquely identifies this user among all active users.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Username { get; set; }

}