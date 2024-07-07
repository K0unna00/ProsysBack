using ProsysBack.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsysBack.Entities;

public class Student : BaseEntity
{
    [Column(TypeName = "decimal(5, 0)")]
    public decimal Number { get; set; }

    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(30)]
    public string Surname { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public decimal Class { get; set; }

    public ICollection<Exam> Exams { get; set; }
}
