using ProsysBack.Entities.Base;

namespace ProsysBack.Abstractions.Repositories.Base;

public interface IRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();

    Task<T> GetByIdAsync(Guid id);

    Task<Guid> CreateAsync(T entity);

    Task<bool> UpdateAsync(T entity);

    Task<bool> DeleteAsync(Guid id);
}
