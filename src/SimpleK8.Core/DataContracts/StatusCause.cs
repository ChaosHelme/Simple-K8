namespace SimpleK8.Core.DataContracts;

/// <summary>
/// StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StatusCause
{
	/// <summary>
	/// The field of the resource that has caused this error, as named by its JSON serialization. May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.
	/// <br/>
	/// <br/>Examples:
	/// <br/>  "name" - the field "name" on the current resource
	/// <br/>  "items[0].name" - the field "name" on the first array entry in "items"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("field", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Field { get; set; }

	/// <summary>
	/// A human-readable description of the cause of the error.  This field may be presented as-is to a reader.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// A machine-readable description of the cause of the error. If this value is empty there is no information available.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

}