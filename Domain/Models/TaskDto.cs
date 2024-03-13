namespace Honest.Timesheet.Domain.Models
{
   public class TaskDto
   {
      public long Id { get; set; }

      public string Title { get; set; } = null!;

      public long PlannedTime { get; set; }

      public byte[] Closed { get; set; } = null!;

      public long RelProjectId { get; set; }

      public long SourceType { get; set; }

      public string SourceTaskId { get; set; } = null!;

      public virtual ICollection<RecordDto> Records { get; set; } = new List<RecordDto>();

      public virtual ProjectDto RelProject { get; set; } = null!;
   }
}
