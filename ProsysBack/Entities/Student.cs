using ProsysBack.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsysBack.Entities;

public class Student : BaseEntity
{
    [Column(TypeName = "decimal(5, 0)")]
    public int Number { get; set; }

    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(30)]
    public string Surname { get; set; }

    [Column(TypeName = "decimal(2, 0)")]
    public int Class { get; set; }
}
