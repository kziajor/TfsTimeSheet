using Honest.Timesheet.Domain.Interfaces;
using Honest.Timesheet.Domain.Models;
using Honest.Timesheet.Persistence.Mappers;

namespace Honest.Timesheet.Persistence.Repositories;
public class ProjectRepository : BaseRepository, IProjectRepository
{
    public ProjectRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<ProjectDto> GetActiveProjects()
    {
        return _dbContext.Projects
            .Select(p => p.ToDto())
            .ToList();
    }
}
