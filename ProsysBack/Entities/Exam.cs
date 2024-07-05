using ProsysBack.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsysBack.Entities;

public class Exam : BaseEntity
{
    [StringLength(3)]
    public string LessonCode { get; set; }

    [Column(TypeName = "decimal(5, 0)")]
    public decimal StudentNumber { get; set; }

    public DateTime Date { get; set; }

    [Column(TypeName = "decimal(1, 0)")]
    public int Grade { get; set; }
}
