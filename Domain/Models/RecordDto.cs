namespace Honest.Timesheet.Domain.Models
{
   public class RecordDto
   {
      public long Id { get; set; }

      public byte[] StartedAt { get; set; } = null!;

      public byte[]? FinishedAt { get; set; }

      public long MinutesSpent { get; set; }

      public string? Comment { get; set; }

      public long RelTaskId { get; set; }

      public virtual TaskDto RelTask { get; set; } = null!;
   }
}
