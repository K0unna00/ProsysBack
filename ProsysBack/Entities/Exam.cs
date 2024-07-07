using ProsysBack.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsysBack.Entities;

public class Exam : BaseEntity
{
    public Guid LessonId { get; set; }

    public Guid StudentId { get; set; }

    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(1, 0)")]
    public decimal Grade { get; set; }

    [ForeignKey("LessonId")]
    public Lesson Lesson { get; set; }

    [ForeignKey("StudentId")]
    public Student Student { get; set; }
}
