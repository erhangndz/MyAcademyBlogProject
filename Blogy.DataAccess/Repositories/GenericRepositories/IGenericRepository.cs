﻿using Blogy.Entity.Entities.Common;
using System.Linq.Expressions;

namespace Blogy.DataAccess.Repositories.GenericRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> filter);
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);


    }
}
