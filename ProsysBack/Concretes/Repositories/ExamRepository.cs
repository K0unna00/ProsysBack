using Microsoft.EntityFrameworkCore;
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

    public async override Task<List<Exam>> GetAllAsync()
    {
        return await _table.Include(x => x.Student).Include(x => x.Lesson).ToListAsync();
    }
}
