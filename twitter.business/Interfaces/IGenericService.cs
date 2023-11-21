
using twitter.entities.Interfaces;

namespace twitter.business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
    }
}