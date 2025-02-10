namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ObjectReference contains enough information to let you inspect or modify the referred object.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ObjectReference
{
	/// <summary>
	/// API version of the referent.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// If referring to a piece of an object instead of an entire object, this string should contain a valid JSON/Go field access statement, such as desiredState.manifest.containers[2]. For example, if the object reference is to a container within a pod, this would take on a value like: "spec.containers{name}" (where "name" refers to the name of the container that triggered the event) or if no container name is specified "spec.containers[2]" (container with index 2 in this pod). This syntax is chosen only to have some well-defined way of referencing a part of an object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FieldPath { get; set; }

	/// <summary>
	/// Kind of the referent. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Kind { get; set; }

	/// <summary>
	/// Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Namespace { get; set; }

	/// <summary>
	/// Specific resourceVersion to which this reference is made, if any. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceVersion { get; set; }

	/// <summary>
	/// UID of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#uids
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

}