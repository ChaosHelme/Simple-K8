namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceDefinitionStatus indicates the state of the CustomResourceDefinition
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceDefinitionStatus
{
	/// <summary>
	/// acceptedNames are the names that are actually being used to serve discovery. They may be different than the names in spec.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("acceptedNames", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceDefinitionNames AcceptedNames { get; set; }

	/// <summary>
	/// conditions indicate state for particular aspects of a CustomResourceDefinition
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<CustomResourceDefinitionCondition> Conditions { get; set; }

	/// <summary>
	/// storedVersions lists all versions of CustomResources that were ever persisted. Tracking these versions allows a migration path for stored versions in etcd. The field is mutable so a migration controller can finish a migration to another version (ensuring no old objects are left in storage), and then remove the rest of the versions from this list. Versions may not be removed from `spec.versions` while they exist in this list.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storedVersions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> StoredVersions { get; set; }

}