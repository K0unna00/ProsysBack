using ProsysBack.Entities;

namespace ProsysBack.Models;

public class ExamDTO
{
    public Guid Id { get; set; }

    public Guid LessonId { get; set; }

    public Guid StudentId { get; set; }

    public DateTime Date { get; set; }

    public decimal Grade { get; set; }
}
