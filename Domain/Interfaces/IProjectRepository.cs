using Honest.Timesheet.Domain.Models;

namespace Honest.Timesheet.Domain.Interfaces;

public interface IProjectRepository
{
   IEnumerable<ProjectDto> GetActiveProjects();
}