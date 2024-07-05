using Microsoft.EntityFrameworkCore;
using ProsysBack.Entities;

namespace ProsysBack.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Lesson> Lessons { get; set; }

    public DbSet<Exam> Exams { get; set; }

    public DbSet<Student> Students { get; set; }


}
