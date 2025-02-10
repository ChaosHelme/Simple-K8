namespace SimpleK8.Core.DataContracts;

/// <summary>
/// UserSubject holds detailed information for user-kind subject.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class UserSubject
{
	/// <summary>
	/// `name` is the username that matches, or "*" to match all usernames. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}