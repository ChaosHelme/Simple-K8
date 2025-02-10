namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a volume that is populated with the contents of a git repository. Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.
/// <br/>
/// <br/>DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class GitRepoVolumeSource
{
	/// <summary>
	/// directory is the target directory name. Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("directory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Directory { get; set; }

	/// <summary>
	/// repository is the URL
	/// </summary>
	[Newtonsoft.Json.JsonProperty("repository", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Repository { get; set; }

	/// <summary>
	/// revision is the commit hash for the specified revision.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("revision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Revision { get; set; }

}