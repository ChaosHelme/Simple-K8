namespace SimpleK8.Core.DataContracts;

/// <summary>
/// JobTemplateSpec describes the data a Job should have when created from a template
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class JobTemplateSpec
{
	/// <summary>
	/// Standard object's metadata of the jobs created from this template. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectMeta Metadata { get; set; }

	/// <summary>
	/// Specification of the desired behavior of the job. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	/// </summary>
	[Newtonsoft.Json.JsonProperty("spec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JobSpec Spec { get; set; }

}