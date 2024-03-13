namespace Honest.Timesheet.Persistence.Repositories;

public class BaseRepository
{
    protected readonly AppDbContext _dbContext;

    public BaseRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
}
