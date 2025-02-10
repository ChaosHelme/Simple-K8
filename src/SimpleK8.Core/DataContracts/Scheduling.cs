namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Scheduling
{
	/// <summary>
	/// nodeSelector lists labels that must be present on nodes that support this RuntimeClass. Pods using this RuntimeClass can only be scheduled to a node matched by this selector. The RuntimeClass nodeSelector is merged with a pod's existing nodeSelector. Any conflicts will cause the pod to be rejected in admission.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> NodeSelector { get; set; }

	/// <summary>
	/// tolerations are appended (excluding duplicates) to pods running with this RuntimeClass during admission, effectively unioning the set of nodes tolerated by the pod and the RuntimeClass.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tolerations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Toleration> Tolerations { get; set; }

}