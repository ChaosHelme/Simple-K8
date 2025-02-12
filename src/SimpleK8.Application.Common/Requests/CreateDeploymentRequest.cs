using SimpleK8.Application.Common.DTOs;

namespace SimpleK8.Application.Common.Requests;

public record CreateDeploymentRequest(ObjectMetaDto ObjectMetaDto, DeploymentSpecDto DeploymentSpec);