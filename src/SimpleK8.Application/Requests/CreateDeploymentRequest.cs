using SimpleK8.Application.DTOs;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Requests;

public record CreateDeploymentRequest(string Namespace, string Name, DeploymentSpecDto DeploymentSpec);