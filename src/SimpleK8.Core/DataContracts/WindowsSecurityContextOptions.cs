namespace SimpleK8.Core.DataContracts;

/// <summary>
/// WindowsSecurityContextOptions contain Windows-specific options and credentials.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class WindowsSecurityContextOptions
{
	/// <summary>
	/// GMSACredentialSpec is where the GMSA admission webhook (https://github.com/kubernetes-sigs/windows-gmsa) inlines the contents of the GMSA credential spec named by the GMSACredentialSpecName field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gmsaCredentialSpec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string GmsaCredentialSpec { get; set; }

	/// <summary>
	/// GMSACredentialSpecName is the name of the GMSA credential spec to use.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gmsaCredentialSpecName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string GmsaCredentialSpecName { get; set; }

	/// <summary>
	/// HostProcess determines if a container should be run as a 'Host Process' container. All of a Pod's containers must have the same effective HostProcess value (it is not allowed to have a mix of HostProcess containers and non-HostProcess containers). In addition, if HostProcess is true then HostNetwork must also be set to true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostProcess", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? HostProcess { get; set; }

	/// <summary>
	/// The UserName in Windows to run the entrypoint of the container process. Defaults to the user specified in image metadata if unspecified. May also be set in PodSecurityContext. If set in both SecurityContext and PodSecurityContext, the value specified in SecurityContext takes precedence.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("runAsUserName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RunAsUserName { get; set; }

}