namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerUser represents user identity information
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerUser
{
	/// <summary>
	/// Linux holds user identity information initially attached to the first process of the containers in Linux. Note that the actual running identity can be changed if the process has enough privilege to do so.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("linux", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LinuxContainerUser Linux { get; set; }

}