namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Spec of the storage version migration.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StorageVersionMigrationSpec
{
	/// <summary>
	/// The token used in the list options to get the next chunk of objects to migrate. When the .status.conditions indicates the migration is "Running", users can use this token to check the progress of the migration.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("continueToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ContinueToken { get; set; }

	/// <summary>
	/// The resource that is being migrated. The migrator sends requests to the endpoint serving the resource. Immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public GroupVersionResource Resource { get; set; } = new GroupVersionResource();

}