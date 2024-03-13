using System;
using System.Collections.Generic;

namespace Honest.Timesheet.Persistence.Entities;

public partial class RecordDbo
{
    public long Id { get; set; }

    public required byte[] StartedAt { get; set; } = null!;

    public byte[]? FinishedAt { get; set; }

    public long MinutesSpent { get; set; }

    public string? Comment { get; set; }

    public long RelTaskId { get; set; }

    public virtual TaskDbo RelTask { get; set; } = null!;
}
