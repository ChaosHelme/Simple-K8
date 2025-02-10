namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourcePool describes the pool that ResourceSlices belong to.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourcePool
{
	/// <summary>
	/// Generation tracks the change in a pool over time. Whenever a driver changes something about one or more of the resources in a pool, it must change the generation in all ResourceSlices which are part of that pool. Consumers of ResourceSlices should only consider resources from the pool with the highest generation number. The generation may be reset by drivers, which should be fine for consumers, assuming that all ResourceSlices in a pool are updated to match or deleted.
	/// <br/>
	/// <br/>Combined with ResourceSliceCount, this mechanism enables consumers to detect pools which are comprised of multiple ResourceSlices and are in an incomplete state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("generation", Required = Newtonsoft.Json.Required.Always)]
	public long Generation { get; set; }

	/// <summary>
	/// Name is used to identify the pool. For node-local devices, this is often the node name, but this is not required.
	/// <br/>
	/// <br/>It must not be longer than 253 characters and must consist of one or more DNS sub-domains separated by slashes. This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// ResourceSliceCount is the total number of ResourceSlices in the pool at this generation number. Must be greater than zero.
	/// <br/>
	/// <br/>Consumers can use this to check whether they have seen all ResourceSlices belonging to the same pool.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceSliceCount", Required = Newtonsoft.Json.Required.Always)]
	public long ResourceSliceCount { get; set; }

}