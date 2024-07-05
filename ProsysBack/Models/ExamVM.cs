using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsysBack.Models;

public class ExamVM
{
    public Guid Id { get; set; }

    public string LessonCode { get; set; }

    public decimal StudentNumber { get; set; }

    public DateTime Date { get; set; }

    public int Grade { get; set; }
}
