namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeMount describes a mounting of a Volume within a container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeMount
{
	/// <summary>
	/// Path within the container at which the volume should be mounted.  Must not contain ':'.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("mountPath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string MountPath { get; set; }

	/// <summary>
	/// mountPropagation determines how mounts are propagated from the host to container and the other way around. When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("mountPropagation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string MountPropagation { get; set; }

	/// <summary>
	/// This must match the Name of a Volume.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Mounted read-only if true, read-write otherwise (false or unspecified). Defaults to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// RecursiveReadOnly specifies whether read-only mounts should be handled recursively.
	/// <br/>
	/// <br/>If ReadOnly is false, this field has no meaning and must be unspecified.
	/// <br/>
	/// <br/>If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.
	/// <br/>
	/// <br/>If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).
	/// <br/>
	/// <br/>If this field is not specified, it is treated as an equivalent of Disabled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("recursiveReadOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RecursiveReadOnly { get; set; }

	/// <summary>
	/// Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subPath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string SubPath { get; set; }

	/// <summary>
	/// Expanded path within the volume from which the container's volume should be mounted. Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subPathExpr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string SubPathExpr { get; set; }

}