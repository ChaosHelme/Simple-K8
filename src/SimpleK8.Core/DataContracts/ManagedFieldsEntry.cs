namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the resource that the fieldset applies to.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ManagedFieldsEntry
{
	/// <summary>
	/// APIVersion defines the version of this resource that this field set applies to. The format is "group/version" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// FieldsType is the discriminator for the different fields format and version. There is currently only one possible value: "FieldsV1"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FieldsType { get; set; }

	/// <summary>
	/// FieldsV1 holds the first JSON version format as described in the "FieldsV1" type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldsV1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FieldsV1 FieldsV1 { get; set; }

	/// <summary>
	/// Manager is an identifier of the workflow managing these fields.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("manager", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Manager { get; set; }

	/// <summary>
	/// Operation is the type of operation which lead to this ManagedFieldsEntry being created. The only valid values for this field are 'Apply' and 'Update'.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("operation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Operation { get; set; }

	/// <summary>
	/// Subresource is the name of the subresource used to update that object, or empty string if the object was updated through the main resource. The value of this field is used to distinguish between managers, even if they share the same name. For example, a status update will be distinct from a regular update using the same manager name. Note that the APIVersion field is not related to the Subresource field and it always corresponds to the version of the main resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subresource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Subresource { get; set; }

	/// <summary>
	/// Time is the timestamp of when the ManagedFields entry was added. The timestamp will also be updated if a field is added, the manager changes any of the owned fields value or removes a field. The timestamp does not update when a field is removed from the entry because another manager took it over.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? Time { get; set; }

}