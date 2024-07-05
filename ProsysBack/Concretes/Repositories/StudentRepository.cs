using ProsysBack.Abstractions.Repositories;
using ProsysBack.Concretes.Repositories.Base;
using ProsysBack.DAL;
using ProsysBack.Entities;

namespace ProsysBack.Concretes.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
