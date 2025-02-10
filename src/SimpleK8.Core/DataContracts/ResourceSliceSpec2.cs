namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceSliceSpec contains the information published by the driver in one ResourceSlice.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceSliceSpec2
{
	/// <summary>
	/// AllNodes indicates that all nodes have access to the resources in the pool.
	/// <br/>
	/// <br/>Exactly one of NodeName, NodeSelector and AllNodes must be set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allNodes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? AllNodes { get; set; }

	/// <summary>
	/// Devices lists some or all of the devices in this pool.
	/// <br/>
	/// <br/>Must not have more than 128 entries.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Device2> Devices { get; set; }

	/// <summary>
	/// Driver identifies the DRA driver providing the capacity information. A field selector can be used to list only ResourceSlice objects with a certain driver name.
	/// <br/>
	/// <br/>Must be a DNS subdomain and should end with a DNS domain owned by the vendor of the driver. This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("driver", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Driver { get; set; }

	/// <summary>
	/// NodeName identifies the node which provides the resources in this pool. A field selector can be used to list only ResourceSlice objects belonging to a certain node.
	/// <br/>
	/// <br/>This field can be used to limit access from nodes to ResourceSlices with the same node name. It also indicates to autoscalers that adding new nodes of the same type as some old node might also make new resources available.
	/// <br/>
	/// <br/>Exactly one of NodeName, NodeSelector and AllNodes must be set. This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string NodeName { get; set; }

	/// <summary>
	/// NodeSelector defines which nodes have access to the resources in the pool, when that pool is not limited to a single node.
	/// <br/>
	/// <br/>Must use exactly one term.
	/// <br/>
	/// <br/>Exactly one of NodeName, NodeSelector and AllNodes must be set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeSelector NodeSelector { get; set; }

	/// <summary>
	/// Pool describes the pool that this ResourceSlice belongs to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pool", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public ResourcePool2 Pool { get; set; } = new ResourcePool2();

}