namespace Honest.Timesheet.Domain.Models
{
   public class ProjectDto
   {
      public long Id { get; set; }

      public string? Name { get; set; }

      public byte[]? Closed { get; set; }

      public virtual ICollection<TaskDto> Tasks { get; set; } = new List<TaskDto>();
   }
}
