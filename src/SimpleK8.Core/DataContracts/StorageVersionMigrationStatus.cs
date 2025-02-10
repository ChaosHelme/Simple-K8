namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Status of the storage version migration.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StorageVersionMigrationStatus
{
	/// <summary>
	/// The latest available observations of the migration's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<MigrationCondition> Conditions { get; set; }

	/// <summary>
	/// ResourceVersion to compare with the GC cache for performing the migration. This is the current resource version of given group, version and resource when kube-controller-manager first observes this StorageVersionMigration resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceVersion { get; set; }

}