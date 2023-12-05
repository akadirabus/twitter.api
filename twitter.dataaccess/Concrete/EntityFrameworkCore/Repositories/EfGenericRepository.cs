using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Context;
using twitter.dataaccess.Interfaces;
using twitter.entities.Interfaces;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using var context = new TwitterContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using var context = new TwitterContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> ListAsync()
        {
            using var context = new TwitterContext();

            return await context.Set<TEntity>().ToListAsync();
        }
        
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new TwitterContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new TwitterContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
