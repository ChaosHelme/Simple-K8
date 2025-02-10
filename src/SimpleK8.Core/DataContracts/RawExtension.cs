namespace SimpleK8.Core.DataContracts;

/// <summary>
/// RawExtension is used to hold extensions in external versions.
/// <br/>
/// <br/>To use this, make a field which has RawExtension as its type in your external, versioned struct, and Object in your internal struct. You also need to register your various plugin types.
/// <br/>
/// <br/>// Internal package:
/// <br/>
/// <br/>	type MyAPIObject struct {
/// <br/>		runtime.TypeMeta `json:",inline"`
/// <br/>		MyPlugin runtime.Object `json:"myPlugin"`
/// <br/>	}
/// <br/>
/// <br/>	type PluginA struct {
/// <br/>		AOption string `json:"aOption"`
/// <br/>	}
/// <br/>
/// <br/>// External package:
/// <br/>
/// <br/>	type MyAPIObject struct {
/// <br/>		runtime.TypeMeta `json:",inline"`
/// <br/>		MyPlugin runtime.RawExtension `json:"myPlugin"`
/// <br/>	}
/// <br/>
/// <br/>	type PluginA struct {
/// <br/>		AOption string `json:"aOption"`
/// <br/>	}
/// <br/>
/// <br/>// On the wire, the JSON will look something like this:
/// <br/>
/// <br/>	{
/// <br/>		"kind":"MyAPIObject",
/// <br/>		"apiVersion":"v1",
/// <br/>		"myPlugin": {
/// <br/>			"kind":"PluginA",
/// <br/>			"aOption":"foo",
/// <br/>		},
/// <br/>	}
/// <br/>
/// <br/>So what happens? Decode first uses json or yaml to unmarshal the serialized data into your external MyAPIObject. That causes the raw JSON to be stored, but not unpacked. The next step is to copy (using pkg/conversion) into the internal struct. The runtime package's DefaultScheme has conversion functions installed which will unpack the JSON stored in RawExtension, turning it into the correct object type, and storing it in the Object. (TODO: In the case where the object is of an unknown type, a runtime.Unknown object will be created and stored.)
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class RawExtension
{

}