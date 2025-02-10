namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CELDeviceSelector contains a CEL expression for selecting a device.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CELDeviceSelector
{
	/// <summary>
	/// Expression is a CEL expression which evaluates a single device. It must evaluate to true when the device under consideration satisfies the desired criteria, and false when it does not. Any other result is an error and causes allocation of devices to abort.
	/// <br/>
	/// <br/>The expression's input is an object named "device", which carries the following properties:
	/// <br/> - driver (string): the name of the driver which defines this device.
	/// <br/> - attributes (map[string]object): the device's attributes, grouped by prefix
	/// <br/>   (e.g. device.attributes["dra.example.com"] evaluates to an object with all
	/// <br/>   of the attributes which were prefixed by "dra.example.com".
	/// <br/> - capacity (map[string]object): the device's capacities, grouped by prefix.
	/// <br/>
	/// <br/>Example: Consider a device with driver="dra.example.com", which exposes two attributes named "model" and "ext.example.com/family" and which exposes one capacity named "modules". This input to this expression would have the following fields:
	/// <br/>
	/// <br/>    device.driver
	/// <br/>    device.attributes["dra.example.com"].model
	/// <br/>    device.attributes["ext.example.com"].family
	/// <br/>    device.capacity["dra.example.com"].modules
	/// <br/>
	/// <br/>The device.driver field can be used to check for a specific driver, either as a high-level precondition (i.e. you only want to consider devices from this driver) or as part of a multi-clause expression that is meant to consider devices from different drivers.
	/// <br/>
	/// <br/>The value type of each attribute is defined by the device definition, and users who write these expressions must consult the documentation for their specific drivers. The value type of each capacity is Quantity.
	/// <br/>
	/// <br/>If an unknown prefix is used as a lookup in either device.attributes or device.capacity, an empty map will be returned. Any reference to an unknown field will cause an evaluation error and allocation to abort.
	/// <br/>
	/// <br/>A robust expression should check for the existence of attributes before referencing them.
	/// <br/>
	/// <br/>For ease of use, the cel.bind() function is enabled, and can be used to simplify expressions that access multiple attributes with the same domain. For example:
	/// <br/>
	/// <br/>    cel.bind(dra, device.attributes["dra.example.com"], dra.someBool &amp;&amp; dra.anotherBool)
	/// <br/>
	/// <br/>The length of the expression must be smaller or equal to 10 Ki. The cost of evaluating it is also limited based on the estimated number of logical steps.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expression", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Expression { get; set; }

}