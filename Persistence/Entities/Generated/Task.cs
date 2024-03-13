using System;
using System.Collections.Generic;

namespace Honest.Timesheet.Persistence.Entities;

public partial class TaskDbo
{
    public long Id { get; set; }

    public required string Title { get; set; } = null!;

    public long PlannedTime { get; set; }

    public required byte[] Closed { get; set; } = null!;

    public long RelProjectId { get; set; }

    public long SourceType { get; set; }

    public required string SourceTaskId { get; set; } = null!;

    public virtual ICollection<RecordDbo> Records { get; set; } = new List<RecordDbo>();

    public virtual ProjectDbo RelProject { get; set; } = null!;
}
