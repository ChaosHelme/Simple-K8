using System.ComponentModel;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Common.DTOs;

public record DeploymentSpecDto
{
	[DefaultValue(1)]
	public int Replicas { get; set; }

	[DefaultValue(0)]
	public int MinReadySeconds { get; set; }

	[DefaultValue(600)]
	public int ProgressDeadlineSeconds { get; set; }

	public bool? Paused { get; set; }

	[DefaultValue(10)]
	public int? RevisionHistoryLimit { get; set; }
}

public record PodTemplateSpecDto
{
	public ObjectMeta Metadata { get; set; }
}