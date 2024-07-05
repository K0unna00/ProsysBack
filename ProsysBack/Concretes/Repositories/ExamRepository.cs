using ProsysBack.Abstractions.Repositories;
using ProsysBack.Concretes.Repositories.Base;
using ProsysBack.DAL;
using ProsysBack.Entities;

namespace ProsysBack.Concretes.Repositories;

public class ExamRepository : Repository<Exam>, IExamRepository
{
    public ExamRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
