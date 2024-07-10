using ProsysBack.Entities.Base;
using ProsysBack.Models;

namespace ProsysBack.Abstractions.Repositories.Base;

public interface IRepository<T> where T : BaseEntity
{
    Task<PaginationRs<T>> GetAllPaginationAsync(Pagination pagination);

    Task<List<T>> GetAllAsync();

    Task<T> GetByIdAsync(Guid id);

    Task<Guid> CreateAsync(T entity);

    Task<bool> UpdateAsync(T entity);

    Task<bool> DeleteAsync(Guid id);
}
