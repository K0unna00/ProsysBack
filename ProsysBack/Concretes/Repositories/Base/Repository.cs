using Microsoft.EntityFrameworkCore;
using ProsysBack.Abstractions.Repositories.Base;
using ProsysBack.DAL;
using ProsysBack.Entities.Base;

namespace ProsysBack.Concretes.Repositories.Base;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected AppDbContext _appDbContext;

    protected DbSet<T> _table;

    public Repository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;

        _table = appDbContext.Set<T>();
    }

    public virtual async Task<List<T>> GetAllAsync() => await _table.ToListAsync();

    public async Task<T> GetByIdAsync(Guid id) => await _table.FirstOrDefaultAsync(x => x.Id == id) ?? throw new KeyNotFoundException();

    public async Task<Guid> CreateAsync(T entity)
    {
        var result = await _table.AddAsync(entity);

        await _appDbContext.SaveChangesAsync();

        return result.Entity.Id;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        _table.Update(entity);

        var result = await _appDbContext.SaveChangesAsync();

        return result >= 1;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var data = await GetByIdAsync(id);

        _table.Remove(data);

        var result = await _appDbContext.SaveChangesAsync();

        return result >= 1;
    }
}
