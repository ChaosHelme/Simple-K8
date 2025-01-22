namespace SimpleK8.DataContracts;

public record Container(string[] args, string[] command, string[] environment, string image, string name);