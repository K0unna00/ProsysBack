using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProsysBack.Models;

public class StudentVM 
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public int Class { get; set; }
}
