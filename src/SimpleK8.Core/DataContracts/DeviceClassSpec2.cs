namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceClassSpec is used in a [DeviceClass] to define what can be allocated and how to configure it.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceClassSpec2
{
	/// <summary>
	/// Config defines configuration parameters that apply to each device that is claimed via this class. Some classses may potentially be satisfied by multiple drivers, so each instance of a vendor configuration applies to exactly one driver.
	/// <br/>
	/// <br/>They are passed to the driver, but are not considered while allocating the claim.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("config", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceClassConfiguration2> Config { get; set; }

	/// <summary>
	/// Each selector must be satisfied by a device which is claimed via this class.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selectors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeviceSelector2> Selectors { get; set; }

}