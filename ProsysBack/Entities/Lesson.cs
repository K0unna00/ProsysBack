using ProsysBack.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProsysBack.Entities;

public class Lesson : BaseEntity
{
    [StringLength(3)]
    [Required(ErrorMessage ="Kod daxil edilmelidir!")]
    [MaxLength(3,ErrorMessage = "Max uzunluq 3 ola biler!")]
    public string Code { get; set; }  

    [StringLength(30)]
    [Required(ErrorMessage = "Kod daxil edilmelidir")]
    [MaxLength(30, ErrorMessage = "Max uzunluq 30 ola biler!")]
    public string Name { get; set; }   

    [Column(TypeName = "decimal(2, 0)")]
    [Required(ErrorMessage = "Kod daxil edilmelidir")]
    [RegularExpression(@"decimal\\(\\d{1,2},\\s*\\d{1,2}\\)")]
    public decimal Class { get; set; }     

    [StringLength(20)]
    [Required(ErrorMessage = "Kod daxil edilmelidir")]
    [MaxLength(20, ErrorMessage = "Max uzunluq 20 ola biler!")]
    public string TeacherName { get; set; } 

    [StringLength(20)]
    [Required(ErrorMessage = "Kod daxil edilmelidir")]
    [MaxLength(20, ErrorMessage = "Max uzunluq 20 ola biler!")]
    public string TeacherSurname { get; set; } 
}
