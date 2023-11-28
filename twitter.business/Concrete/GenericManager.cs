﻿using twitter.business.Interfaces;
using twitter.dataaccess.Interfaces;
using twitter.entities.Interfaces;

namespace twitter.business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _genericDal.AddAsync(entity);
        }

        public async Task<List<TEntity>> ListAsync()
        {
            return await _genericDal.ListAsync();
        }
    }
}
