using Honest.Timesheet.Domain.Models;
using Honest.Timesheet.Persistence.Entities;
using Riok.Mapperly.Abstractions;

namespace Honest.Timesheet.Persistence.Mappers;

[Mapper]
public static partial class Mappers
{
    public static partial ProjectDto ToDto(this ProjectDbo project);
}
