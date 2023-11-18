using twitter.entities.Interfaces;

namespace twitter.dataaccess.Interfaces
{
    public interface IGenericDal<TEntity> where TEntity: class, ITable, new()
    {
        Task<List<TEntity>> GetAllAsync();
    }
}