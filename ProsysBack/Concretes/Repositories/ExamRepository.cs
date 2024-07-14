using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProsysBack.Abstractions.Repositories;
using ProsysBack.Concretes.Repositories.Base;
using ProsysBack.DAL;
using ProsysBack.Entities;
using ProsysBack.Models;

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

    public async override Task<PaginationRs<Exam>> GetAllPaginationAsync(Pagination pagination)
    {
        var response = await _table.Include(x => x.Student).Include(x => x.Lesson).Skip(pagination.Page * pagination.Size).Take(pagination.Size).ToListAsync();

        var totalCount = await _table.CountAsync();

        return new PaginationRs<Exam> { Response = response, TotalCount = totalCount };
    }
}
