using System.Linq.Expressions;
using twitter.entities.Interfaces;

namespace twitter.dataaccess.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity: class, ITable, new()
    {
        Task<List<TEntity>> ListAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}