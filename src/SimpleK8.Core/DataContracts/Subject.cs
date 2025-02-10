namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Subject matches the originator of a request, as identified by the request authentication system. There are three ways of matching an originator; by user, group, or service account.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Subject
{
	/// <summary>
	/// `group` matches based on user group name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GroupSubject Group { get; set; }

	/// <summary>
	/// `kind` indicates which one of the other fields is non-empty. Required
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Kind { get; set; }

	/// <summary>
	/// `serviceAccount` matches ServiceAccounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serviceAccount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ServiceAccountSubject ServiceAccount { get; set; }

	/// <summary>
	/// `user` matches based on username.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public UserSubject User { get; set; }

}