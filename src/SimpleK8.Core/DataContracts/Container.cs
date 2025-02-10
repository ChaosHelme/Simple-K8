namespace SimpleK8.Core.DataContracts;

public record Container(string[] Args, string[] Command, string[] Environment, string Image, string Name);