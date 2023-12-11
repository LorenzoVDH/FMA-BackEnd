#nullable enable

namespace FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
public interface IRepository<T> {
    Task<int> CreateAsync(T entity);
    Task<List<T>> GetAllAsync(int pageIndex, int pageLength);
    Task<T?> GetByIDAsync(int id);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task SaveChangesAsync();
}
