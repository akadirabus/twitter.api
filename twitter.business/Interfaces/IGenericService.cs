
using twitter.entities.Interfaces;

namespace twitter.business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> ListAsync();
        Task AddAsync(TEntity entity);
    }
}