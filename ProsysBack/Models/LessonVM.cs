using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsysBack.Models;

public class LessonVM
{
    public Guid Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public decimal Class { get; set; }

    public string TeacherName { get; set; }

    public string TeacherSurname { get; set; }
}
