using System;
using System.Collections.Generic;

namespace Honest.Timesheet.Persistence.Entities;

public partial class ProjectDbo
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public byte[]? Closed { get; set; }

    public virtual ICollection<TaskDbo> Tasks { get; set; } = new List<TaskDbo>();
}
