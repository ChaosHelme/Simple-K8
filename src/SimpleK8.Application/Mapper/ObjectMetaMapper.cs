using Riok.Mapperly.Abstractions;
using SimpleK8.Application.DTOs;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Mapper;

[Mapper]
public static partial class ObjectMetaMapper
{
	[MapValue(nameof(ObjectMeta.Uid), Use = nameof(CreateUuid))]
	public static partial ObjectMeta ObjectMetaFromObjectMetaDto(ObjectMetaDto objectMetaDto);
	
	static string CreateUuid() => Guid.CreateVersion7(DateTimeOffset.UtcNow).ToString();
}